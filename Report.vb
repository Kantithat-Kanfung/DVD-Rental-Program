Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Report

    Private getID As String
    Private getFullName As String
    Private getAmount As Double

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSearch.Clear()
        TextBoxSearch.Focus()

        ListCustomerPaymentAmount()
        ChartRevenuePerYear()
    End Sub

    Private Sub ListCustomerPaymentAmount()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                SELECT
                                	p.customer_id,
                                	CONCAT(c.first_name, ' ', c.last_name) AS fullname,
                                	SUM(p.amount) AS amount
                                FROM
                                	payment AS p
                                INNER JOIN
                                	customer AS c ON c.customer_id = p.customer_id
                                GROUP BY
                                	p.customer_id,
                                	CONCAT(c.first_name, ' ', c.last_name)	
                                ORDER BY p.customer_id
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                getID = Reader("customer_id")
                getFullName = Reader("fullname")
                getAmount = Reader("amount")

                DataGridView1.Rows.Add(getID, getFullName, getAmount)
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        DataGridView1.Rows.Clear()
        SearchCustomerPaymentAmount(TextBoxSearch.Text)
    End Sub

    Private Sub SearchCustomerPaymentAmount(ByVal name As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                SELECT
                                	p.customer_id,
                                	CONCAT(c.first_name, ' ', c.last_name) AS fullname,
                                	SUM(p.amount) AS amount
                                FROM
                                	payment AS p
                                INNER JOIN
                                	customer AS c ON c.customer_id = p.customer_id
                                WHERE
                                    CONCAT(c.first_name, ' ', c.last_name) LIKE '%{name}%'
                                GROUP BY
                                	p.customer_id,
                                	CONCAT(c.first_name, ' ', c.last_name)	
                                ORDER BY p.customer_id
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                getID = Reader("customer_id")
                getFullName = Reader("fullname")
                getAmount = Reader("amount")

                DataGridView1.Rows.Add(getID, getFullName, getAmount)
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ChartRevenuePerYear()
        Randomize()
        Chart.Series("Sales").Points.AddXY("2001", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2002", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2003", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2004", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2005", CInt(Int((100000 * Rnd()) + 1)))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MsgBox(DataGridView1.Rows(0).Cells(1).Value.ToString())
    End Sub

    Private Sub CheckBoxDay_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDay.CheckedChanged
        Randomize()
        CheckBoxMonth.CheckState = CheckState.Unchecked
        CheckBoxYear.CheckState = CheckState.Unchecked
        Chart.Series("Sales").Points.Clear()
        Chart.Series("Sales").Color = Color.YellowGreen
        Chart.Series("Sales").Points.AddXY("Sunday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Monday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Thuesday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Wednesday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Thursday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Friday", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Saturday", CInt(Int((1000 * Rnd()) + 1)))
    End Sub

    Private Sub CheckBoxMonth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMonth.CheckedChanged
        Randomize()
        CheckBoxDay.CheckState = CheckState.Unchecked
        CheckBoxYear.CheckState = CheckState.Unchecked
        Chart.Series("Sales").Points.Clear()
        Chart.Series("Sales").Color = Color.DarkViolet
        Chart.Series("Sales").Points.AddXY("January", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("February", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("March", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("Apil", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("May", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("June", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("July", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("August", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("September", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("October", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("November", CInt(Int((1000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("December", CInt(Int((1000 * Rnd()) + 1)))
    End Sub

    Private Sub CheckBoxYear_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxYear.CheckedChanged
        Randomize()
        CheckBoxDay.CheckState = CheckState.Unchecked
        CheckBoxMonth.CheckState = CheckState.Unchecked
        Chart.Series("Sales").Points.Clear()
        Chart.Series("Sales").Color = Color.Cyan
        Chart.Series("Sales").Points.AddXY("2001", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2002", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2003", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2004", CInt(Int((100000 * Rnd()) + 1)))
        Chart.Series("Sales").Points.AddXY("2005", CInt(Int((100000 * Rnd()) + 1)))
    End Sub

End Class
