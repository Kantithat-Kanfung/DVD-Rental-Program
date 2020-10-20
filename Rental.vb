Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class RentalPage

    Private getCustomerID As String
    Private getStaffID As String
    Private getRentalID As String
    Private getAmount As String

    Private Sub RentalPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()

        SearchFilm("")

        SearchCustomer("")
    End Sub

    Private Sub ButtonSearchFilm_Click(sender As Object, e As EventArgs) Handles ButtonSearchFilm.Click
        If TextBoxSearchFilm.Text <> "" Then
            dvgFilm.Rows.Clear()
            SearchFilm($"AND f.title = '{TextBoxSearchFilm.Text}'")
        Else
            TextBoxSearchFilm.Text = "Please input your film!"
        End If
    End Sub

    Private Sub ButtonSearchCustomer_Click(sender As Object, e As EventArgs) Handles ButtonSearchCustomer.Click
        If TextBoxSearchCustomer.Text <> "" Then
            dvgCustomer.Rows.Clear()
            SearchCustomer($"
                            WHERE
                                CONCAT(first_name, ' ', last_name) LIKE '%{TextBoxSearchCustomer.Text}%'
                            ")
        Else
            TextBoxSearchCustomer.Text = "Please input customer name!"
        End If
    End Sub

    Private Sub ButtonRefeshFilm_Click(sender As Object, e As EventArgs) Handles ButtonRefeshFilm.Click
        dvgFilm.Rows.Clear()
        SearchFilm("")
        TextBoxSearchFilm.Clear()
    End Sub

    Private Sub ButtonRefeshCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRefeshCustomer.Click
        dvgCustomer.Rows.Clear()
        SearchCustomer("")
        TextBoxSearchCustomer.Clear()
    End Sub

    Private Sub dvgFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgFilm.CellClick
        If IsNothing(dvgFilm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxDVDRental.Text = dvgFilm.Rows(e.RowIndex).Cells("id_film").Value.ToString()
            TextBoxRentalDuration.Text = dvgFilm.Rows(e.RowIndex).Cells("rental_duration").Value.ToString()
            TextBoxRentalRate.Text = dvgFilm.Rows(e.RowIndex).Cells("rental_rate").Value.ToString()
        End If
    End Sub

    Private Sub dvgCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgCustomer.CellClick
        If IsNothing(dvgCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxCustomer.Text = dvgCustomer.Rows(e.RowIndex).Cells("id_customer").Value.ToString()
        End If
    End Sub

    Private Sub TextBoxRentalDuration_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRentalDuration.TextChanged
        ComboBoxStaff.Items.Clear()
        ComboBoxStore.Items.Clear()

        If IsNumeric(TextBoxRentalDuration.Text) Then
            TextBoxRentalDate.Text = Now.ToString()
            TextBoxReturnDate.Text = Now.AddDays(TextBoxRentalDuration.Text)
            Staff("")
            Store("")
        Else
            TextBoxRentalDuration.Clear()
            TextBoxRentalDuration.Focus()
        End If
    End Sub

    Private Sub TextBoxRentalRate_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRentalRate.TextChanged
        If IsNumeric(TextBoxRentalRate.Text) Then
            TextBoxRentalRate.ForeColor = Color.ForestGreen
        Else
            TextBoxRentalRate.Text = "***"
            TextBoxRentalRate.ForeColor = Color.Maroon
        End If
    End Sub

    Private Sub dvgPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgPayment.CellClick
        getCustomerID = dvgPayment.Rows(0).Cells("customer_id").Value.ToString()
        getStaffID = dvgPayment.Rows(0).Cells("staff_id").Value.ToString()
        getRentalID = dvgPayment.Rows(0).Cells("rental_id").Value.ToString()
        getAmount = dvgPayment.Rows(0).Cells("amount").Value.ToString()
    End Sub

    Private Sub ButtonPaymentNow_Click(sender As Object, e As EventArgs) Handles ButtonPaymentNow.Click
        FormMsgProcessWarning.Msg("Do you want to pay for movie?")
        FormMsgProcessWarning.ShowDialog()

        If FormMsgProcessWarning.Result = True Then
            Payment()
            FormMsgProcessComplete.Msg("Completed Successfully.")
            FormMsgProcessComplete.ShowDialog()
            FormMainScreen.ButtonRental_Click(sender, e)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        UpdateInventory()
        AddRental()

        ButtonRefeshFilm_Click(sender, e)
        ButtonRefeshCustomer_Click(sender, e)

        dvgPayment.Rows(0).Cells("customer_id").Value = TextBoxCustomer.Text
        dvgPayment.Rows(0).Cells("staff_id").Value = 1
        dvgPayment.Rows(0).Cells("amount").Value = TextBoxRentalRate.Text

        RentIDOfCustomer()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        FormMainScreen.ButtonRental_Click(sender, e)
    End Sub

    Private Sub SearchFilm(ByVal condition As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                   SELECT
                                        f.title,
                                        f.rental_duration,
                                        f.rental_rate, 
                                   	    i.inventory_id
                                   FROM 
                                   	    film AS f
                                   RIGHT JOIN
                                   	    inventory AS i ON i.film_id = f.film_id
                                   WHERE
                                   	    i.active != 0 AND i.store_id = 1 {condition}
                                   GROUP BY
                                   	    f.title,
                                        f.rental_duration,
                                        f.rental_rate, 
                                        i.inventory_id
                                   ORDER BY
	                                    f.title ASC;   
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgFilm.Rows.Add(Reader("inventory_id"), Reader("title"), Reader("rental_duration"), Reader("rental_rate"))
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfMovies.Text = $"Number of Movies : {dvgFilm.Rows.Count - 1} Items"
    End Sub

    Private Sub SearchCustomer(ByVal condition As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        customer_id,
                                    	CONCAT(first_name, ' ', last_name) AS full_name
                                    FROM
                                    	customer;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgCustomer.Rows.Add(Reader("customer_id"), Reader("full_name"))
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumerOfCustomer.Text = $"Number of Customers : {dvgCustomer.Rows.Count - 1} Items"
    End Sub

    Private Sub Staff(ByVal condition As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        staff_id,
                                    	CONCAT(first_name, ' ', last_name) AS full_name
                                    FROM
                                    	staff
                                    {condition};
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                ComboBoxStaff.Items.Add(Reader("full_name"))
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Store(ByVal condition As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        CASE
                                            WHEN store_id = 1 THEN 'Branch A'
                                        ELSE
                                            'Branch B'
                                        END AS store_id
                                    FROM
                                    	store
                                    {condition};
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                ComboBoxStore.Items.Add(Reader("store_id"))
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub AddRental()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                INSERT INTO
                                   rental
                                       (
                                           rental_date,
                                		   inventory_id,
                                		   customer_id,
                                		   return_date,
                                           staff_id,
                                           last_update 
                                       )
                                   VALUES
                                       (
                                          '{TextBoxRentalDate.Text}',
                                          '{TextBoxDVDRental.Text}',
                                          '{TextBoxCustomer.Text}',
                                          '{TextBoxReturnDate.Text}',
                                          '1', 
                                          GETDATE()
                                       );
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
                                	active = 0,
                                	last_update = GETDATE()
                                WHERE
                                	inventory_id = {TextBoxDVDRental.Text} AND store_id = 1;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RentIDOfCustomer()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                SELECT
                                	rental_id
                                FROM
                                	rental
                                WHERE
                                	rental_date = '{TextBoxRentalDate.Text}'
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                dvgPayment.Rows(0).Cells("rental_id").Value = Reader("rental_id")
            End If

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Payment()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                INSERT
                                    payment
                                        (
                                            customer_id,
                                            staff_id,
                                            rental_id,
                                            amount,
                                            payment_date
                                        )
                                    VALUES
                                        (
                                            '{getCustomerID}',
                                            '{getStaffID}',
                                            '{getRentalID}',
                                            '{getAmount}',
                                            GETDATE()
                                        )
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

End Class
