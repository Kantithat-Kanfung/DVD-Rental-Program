Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class usrCtrlReturn

    Private getID As String
    Private getMovieName As String
    Private getOverdue As String
    Private getDayDifference As Integer

    Private Sub usrCtrlReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        SearchCustomer("")
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"
        Else
            dvgCustomer.Rows.Clear()
            SearchCustomer($"CONCAT(c.first_name, ' ', c.last_name) LIKE '%{TextBoxSearch.Text}%'")
        End If
    End Sub

    Private Sub ButtonRefesh_Click(sender As Object, e As EventArgs) Handles ButtonRefesh.Click
        dvgCustomer.Rows.Clear()
        SearchCustomer("")
    End Sub

    Private Sub dvgCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgCustomer.CellClick
        If IsNothing(dvgCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            getID = dvgCustomer.Rows(e.RowIndex).Cells("id").Value.ToString()
            getMovieName = dvgCustomer.Rows(e.RowIndex).Cells("movie").Value.ToString()
            getOverdue = dvgCustomer.Rows(e.RowIndex).Cells("overdue").Value.ToString()
            getDayDifference = dvgCustomer.Rows(e.RowIndex).Cells("day_difference").Value.ToString()
        End If
    End Sub

    Private Sub ButtonReturn_Click(sender As Object, e As EventArgs) Handles ButtonReturn.Click
        FormMsgProcessWarning.Msg("Do you want to return this movie?")
        FormMsgProcessWarning.ShowDialog()

        If FormMsgProcessWarning.Result = True Then
            If getOverdue = "False" Then
                If getDayDifference < 0 Then
                    ReplacementCost(Math.Abs(getDayDifference) * 10)
                    UpdateInventory()
                    FormMsgProcessComplete.Msg("Completed Successfully.")
                    FormMsgProcessComplete.ShowDialog()
                    ButtonRefesh_Click(sender, e)
                Else
                    UpdateInventory()
                    FormMsgProcessComplete.Msg("Completed Successfully.")
                    FormMsgProcessComplete.ShowDialog()
                    ButtonRefesh_Click(sender, e)
                End If
            Else
                UpdateInventory()
                FormMsgProcessComplete.Msg("Completed Successfully.")
                FormMsgProcessComplete.ShowDialog()
                ButtonRefesh_Click(sender, e)
            End If
        Else
            ButtonRefesh_Click(sender, e)
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ButtonRefesh_Click(sender, e)
    End Sub

    Private Sub SearchCustomer(ByVal condition As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                   SELECT
                                    	i.inventory_id,
                                    	CONCAT(c.first_name, ' ', c.last_name) AS full_name,
                                    	f.title,
                                    	r.rental_date,
                                    	r.return_date,
                                    	f.replacement_cost,
                                        CASE	
											WHEN	
												FORMAT(GETDATE(), 'dd-MM-yyyy') < FORMAT(r.return_date, 'dd-MM-yyyy') THEN 'True' 
											ELSE
												'False'
										END AS overdue,
                                        DATEDIFF(DAY, GETDATE(), r.return_date) AS day_difference
                                    FROM
                                    	rental AS r
                                    LEFT JOIN
                                    	inventory AS i ON i.inventory_id = r.inventory_id
                                    LEFT JOIN
                                    	film AS f ON f.film_id = i.film_id
                                    LEFT JOIN
                                    	customer AS c ON c.customer_id = r.customer_id
                                    WHERE
                                    	i.active = 0 AND 
                                        DATEPART(yy, r.rental_date) != '2005' AND 
                                        DATEPART(yy, r.return_date) != '1900' 
                                        {condition}
                                    ORDER BY
                                    	inventory_id ASC;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgCustomer.Rows.Add(Reader("inventory_id"),
                                     Reader("full_name"),
                                     Reader("title"),
                                     Reader("rental_date"),
                                     Reader("return_date"),
                                     Reader("replacement_cost"),
                                     Reader("overdue"),
                                     Reader("day_difference")
                                    )
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ReplacementCost(ByVal coin As Byte)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    UPDATE 
                                        film
                                    SET
                                        replacement_cost += {coin}
                                    WHERE
                                        title = {getMovieName}              
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub UpdateInventory()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    UPDATE 
                                        inventory
                                    SET
                                        active = '1'
                                    WHERE
                                        inventory_id = {getID}
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

End Class
