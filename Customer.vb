Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Customer

    Private getCustomerID As String
    Private getBranch As String
    Private getFirstName As String
    Private getLastName As String
    Private getEmail As String
    Private getActiveBool As String
    Private getCreateDate As String
    Private getActive As String
    Private getLastUpdate As String
    Private getAddress As String

    Private CheckEventButtonAddClicked As Boolean = False
    Private CheckEventButtonEditClicked As Boolean = False
    Private CheckEventButtonDeleteClicked As Boolean = False

    Private info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()

        TextBoxSearch.Focus()

        LoadDataCustomer()

        ComboBoxBranch.Hide()
        ComboBoxActiveBool.Hide()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"
        Else
            SearchCustomer(TextBoxSearch.Text)

            TextBoxCustomerID.Text = getCustomerID
            TextBoxFirstName.Text = getFirstName
            TextBoxLastName.Text = getLastName
            TextBoxEmail.Text = getEmail
            TextBoxStore.Text = getBranch
            TextBoxActive.Text = getActive
            TextBoxCreateDate.Text = getCreateDate
            TextBoxActiveBool.Text = getActiveBool
            TextBoxLastUpdate.Text = getLastUpdate
            TextBoxAddress.Text = getAddress

            ButtonAdd.Enabled = True
            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = True
            ButtonCancel.Enabled = True

            TextBoxSearch.Clear()
        End If
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Randomize()

        Dim r As Integer = CInt(Int((600 * Rnd()) + 1))

        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxSearch.Clear()

        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAddress.Text = r

        TextBoxCustomerID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxEmail.ReadOnly = False
        TextBoxStore.Hide()
        TextBoxCreateDate.ReadOnly = True
        TextBoxActiveBool.Hide()

        ComboBoxBranch.Show()
        ComboBoxActiveBool.Show()

        CheckEventButtonAddClicked = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Randomize()

        Dim r As Integer = CInt(Int((600 * Rnd()) + 1))

        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxSearch.Clear()

        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAddress.Text = r

        TextBoxCustomerID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxEmail.ReadOnly = False
        TextBoxStore.Hide()
        TextBoxActive.ReadOnly = True
        TextBoxCreateDate.ReadOnly = True
        TextBoxLastUpdate.ReadOnly = True
        TextBoxAddress.Text = r

        ComboBoxBranch.Show()
        ComboBoxActiveBool.Show()

        CheckEventButtonEditClicked = True
    End Sub

#Region "forDev"
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' ... Something ...
    End Sub
#End Region

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxSearch.Clear()

        ClearElement()

        ComboBoxBranch.Hide()
        ComboBoxActiveBool.Hide()

        TextBoxStore.Show()
        TextBoxActiveBool.Show()

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CheckEventButtonAddClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to add the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.Msg("Please input your data!")
                    FormMsgProcessError.ShowDialog()
                Else
                    AddCustomer()
                    FormMsgProcessComplete.Msg("Save data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxBranch.Hide()
                    ComboBoxActiveBool.Hide()

                    TextBoxStore.Show()
                    TextBoxActiveBool.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActiveBool.Hide()

                TextBoxStore.Show()
                TextBoxActiveBool.Show()

                CheckEventButtonAddClicked = False
            End If
        ElseIf CheckEventButtonEditClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to edit the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.Msg("Please input your data!")
                    FormMsgProcessError.ShowDialog()
                Else
                    EditCustomer()
                    FormMsgProcessComplete.Msg("Edit data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxBranch.Hide()
                    ComboBoxActiveBool.Hide()

                    TextBoxStore.Show()
                    TextBoxActiveBool.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActiveBool.Hide()

                TextBoxStore.Show()
                TextBoxActiveBool.Show()

                CheckEventButtonEditClicked = False
            End If
        ElseIf CheckEventButtonDeleteClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to delete the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.Msg("Please input your data!")
                    FormMsgProcessError.ShowDialog()
                Else
                    DeleteCustomer()
                    FormMsgProcessComplete.Msg("Delte data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxBranch.Hide()
                    ComboBoxActiveBool.Hide()

                    TextBoxStore.Show()
                    TextBoxActiveBool.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActiveBool.Hide()

                TextBoxStore.Show()
                TextBoxActiveBool.Show()

                CheckEventButtonDeleteClicked = False
            End If
        End If
    End Sub

    Private Sub ClearElement()
        For Each tbx In {
                        TextBoxCustomerID,
                        TextBoxFirstName,
                        TextBoxLastName,
                        TextBoxEmail,
                        TextBoxStore,
                        TextBoxActive,
                        TextBoxCreateDate,
                        TextBoxActiveBool,
                        TextBoxLastUpdate,
                        TextBoxAddress
                        }
            tbx.Clear()
            tbx.ReadOnly = True
        Next
    End Sub

    Private Sub ButtonRefeshCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRefeshCustomer.Click
        dvgCustomers.Rows.Clear()
        LoadDataCustomer()
    End Sub

    Private Sub dvgCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgCustomers.CellClick
        If IsNothing(dvgCustomers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxCustomerID.Text = dvgCustomers.Rows(e.RowIndex).Cells("id_customer").Value.ToString()
            TextBoxStore.Text = dvgCustomers.Rows(e.RowIndex).Cells("id_store").Value.ToString()
            TextBoxFirstName.Text = dvgCustomers.Rows(e.RowIndex).Cells("first_name").Value.ToString()
            TextBoxLastName.Text = dvgCustomers.Rows(e.RowIndex).Cells("last_name").Value.ToString()
            TextBoxEmail.Text = dvgCustomers.Rows(e.RowIndex).Cells("email").Value.ToString()
            TextBoxActive.Text = dvgCustomers.Rows(e.RowIndex).Cells("active").Value.ToString()
            TextBoxCreateDate.Text = dvgCustomers.Rows(e.RowIndex).Cells("create_date").Value.ToString()
            TextBoxActiveBool.Text = dvgCustomers.Rows(e.RowIndex).Cells("active_bool").Value.ToString()
            TextBoxLastUpdate.Text = dvgCustomers.Rows(e.RowIndex).Cells("last_update").Value.ToString()
            TextBoxAddress.Text = dvgCustomers.Rows(e.RowIndex).Cells("address").Value.ToString()
        End If

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub LoadDataCustomer()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        cus.customer_id,
                                    CASE
                                    	WHEN
                                    		cus.store_id = 1 then 'Branch A'
                                    	ELSE
                                    		'Branch B'
                                    END AS branch,
                                        cus.first_name,
	                                    cus.last_name,
	                                    cus.email,
                                    CONCAT(
                        			        adr.address, ', ', 
                        			        adr.district, ', ', 
                        			        cty.city, ', ', 
                        			        cnt.country, ', ', 
                        			        adr.postal_code
                                        ) AS address,
                                    CASE
                                    	WHEN
                                    		cus.activebool = 't' then 'True'
                                    	ELSE
                                    		'False'
                                    END AS activebool,
                                    FORMAT(
                                    		cus.create_date,
                                    		'dd-MM-yy'
                                    	) AS create_date,
                                    FORMAT(
                                    		cus.last_update,
                                    		'dd-MM-yy'
                                    	) AS last_update,
                                    	cus.active
                                    FROM
                                        customer AS cus
                                    LEFT JOIN
                                    	address AS adr ON adr.address_id = cus.address_id
                                    LEFT JOIN
                                    	city AS cty ON cty.city_id = adr.city_id
                                    LEFT JOIN
                                    	country AS cnt ON cnt.country_id = cty.country_id;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgCustomers.Rows.Add(
                                    Reader("customer_id"),
                                    Reader("branch"),
                                    Reader("first_name"),
                                    Reader("last_name"),
                                    Reader("email"),
                                    Reader("activebool"),
                                    Reader("create_date"),
                                    Reader("active"),
                                    Reader("last_update"),
                                    Reader("address")
                                 )
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

LabelNumberOfCustomer.Text = $"Number of Customers : {dvgCustomers.Rows.Count - 1} Items"
    End Sub

    Private Sub SearchCustomer(ByVal name As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        cus.customer_id,
                                    CASE
                                    	WHEN
                                    		cus.store_id = 1 then 'Branch A'
                                    	ELSE
                                    		'Branch B'
                                    END AS branch,
                                        cus.first_name,
	                                    cus.last_name,
	                                    cus.email,
                                    CONCAT(
                        			        adr.address, ', ', 
                        			        adr.district, ', ', 
                        			        cty.city, ', ', 
                        			        cnt.country, ', ', 
                        			        adr.postal_code
                                        ) AS address,
                                    CASE
                                    	WHEN
                                    		cus.activebool = 't' then 'True'
                                    	ELSE
                                    		'False'
                                    END AS activebool,
                                    FORMAT(
                                    		cus.create_date,
                                    		'dd-MM-yy'
                                    	) AS create_date,
                                    FORMAT(
                                    		cus.last_update,
                                    		'dd-MM-yy'
                                    	) AS last_update,
                                    	cus.active
                                    FROM
                                        customer AS cus
                                    LEFT JOIN
                                    	address AS adr ON adr.address_id = cus.address_id
                                    LEFT JOIN
                                    	city AS cty ON cty.city_id = adr.city_id
                                    LEFT JOIN
                                    	country AS cnt ON cnt.country_id = cty.country_id
                                    WHERE
                                    	CONCAT(cus.first_name, ' ', cus.last_name) LIKE '%{name}%';
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                getCustomerID = Reader("customer_id")
                getFirstName = Reader("first_name")
                getLastName = Reader("last_name")
                getBranch = Reader("branch")
                getEmail = Reader("email")
                getActiveBool = Reader("activebool")
                getCreateDate = Reader("create_date")
                getActive = Reader("active")
                getLastUpdate = Reader("last_update")
                getAddress = Reader("address")
            End If

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfCustomer.Text = $"Number of Customers : {dvgCustomers.Rows.Count.ToString() - 1} Items"
    End Sub

    Public Sub AddCustomer()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Dim CbxStoreID As String = ""
        Dim CbxActiveBool As String = ""

        If ComboBoxBranch.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If ComboBoxActiveBool.SelectedItem = "True" Then
            CbxActiveBool = "t"
        Else
            CbxActiveBool = "f"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    INSERT INTO
                                        customer
                                            (
                                        			store_id,
                                        			first_name,
                                        			last_name,
                                        			email,
                                        			address_id,
                                        			activebool,
                                        			create_date,
                                        			last_update,
                                        			active
                                            )
                                        VALUES
                                            (
                                        			'{CbxStoreID}',
                                        			'{TbxFname}', 
                                        			'{TbxLname}',
                                        			'{TextBoxEmail.Text}',
                                        			'{TextBoxAddress.Text}',
                                        			'{CbxActiveBool}',
                                        			GETDATE(),
                                        			GETDATE(),
                                        			'{TextBoxActive.Text}'
                                            );
                                    "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EditCustomer()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Dim CbxStoreID As String = ""
        Dim CbxActiveBool As String = ""

        If ComboBoxBranch.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If ComboBoxActiveBool.SelectedItem = "True" Then
            CbxActiveBool = "t"
        Else
            CbxActiveBool = "f"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    UPDATE
                                        customer
                                    SET
                                        store_id = CONVERT(INT, {CbxStoreID}),
                                        first_name = '{TbxFname}',
                                        last_name = '{TbxLname}',
                                        email = '{TextBoxEmail.Text}',
                                        address_id = '{TextBoxAddress.Text}',
                                        activebool = '{CbxActiveBool}',
                                        create_date = GETDATE(),
                                        last_update = GETDATE(),
                                        active = '0'
                                    WHERE
                                        customer_id = CONVERT(INT, {getCustomerID});
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

#Region "forDev"
    Public Sub DeleteCustomer()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    DELETE FROM 
                                        customer
                                     WHERE 
                                        customer_id = CONVERT(INT, {getCustomerID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub
#End Region

End Class
