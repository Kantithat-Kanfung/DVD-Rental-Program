Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Staff

    Private getStaffID As String
    Private getFirstName As String
    Private getLastName As String
    Private getAddress As String
    Private getPhone As String
    Private getEmail As String
    Private getStore As String
    Private getActive As String
    Private getUsername As String
    Private getPassword As String
    Private getLastUpdate As String

    Private CheckEventButtonAddClicked As Boolean = False
    Private CheckEventButtonEditClicked As Boolean = False
    Private CheckEventButtonDeleteClicked As Boolean = False

    Private info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()

        LoadDataStaff()

        TextBoxSearch.Focus()

        ComboBoxBranch.Hide()
        ComboBoxActive.Hide()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"
        Else
            SearchStaff(TextBoxSearch.Text)

            TextBoxStaffID.Text = getStaffID
            TextBoxFirstName.Text = getFirstName
            TextBoxLastName.Text = getLastName
            TextBoxAddress.Text = getAddress
            TextBoxPhone.Text = getPhone
            TextBoxEmail.Text = getEmail
            TextBoxStore.Text = getStore
            TextBoxActive.Text = getActive
            TextBoxUsername.Text = getUsername
            TextBoxPassword.Text = getPassword
            TextBoxLastUpdate.Text = getLastUpdate

            ButtonAdd.Enabled = True
            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = True
            ButtonCancel.Enabled = True
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

        TextBoxSearch.Text = ""
        TextBoxStaffID.Text = ""
        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
        TextBoxAddress.Text = r
        TextBoxPhone.Text = ""
        TextBoxEmail.Text = ""
        TextBoxStore.Text = ""
        TextBoxActive.Text = ""
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxLastUpdate.Text = ""

        TextBoxStaffID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxAddress.ReadOnly = True
        TextBoxPhone.ReadOnly = False
        TextBoxEmail.ReadOnly = False
        TextBoxStore.Hide()
        TextBoxActive.Hide()
        TextBoxUsername.ReadOnly = False
        TextBoxPassword.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True

        ComboBoxBranch.Show()
        ComboBoxActive.Show()

        CheckEventButtonAddClicked = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Randomize()

        Dim r As Integer = CInt(Int((600 * Rnd()) + 1))

        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxAddress.Text = r
        TextBoxPassword.Text = ""

        TextBoxStaffID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxAddress.ReadOnly = True
        TextBoxPhone.ReadOnly = False
        TextBoxEmail.ReadOnly = False
        TextBoxStore.Hide()
        TextBoxActive.Hide()
        TextBoxUsername.ReadOnly = False
        TextBoxPassword.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True

        ComboBoxBranch.Show()
        ComboBoxActive.Show()

        CheckEventButtonEditClicked = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ButtonAdd.Enabled = False
        ButtonEdit.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxStaffID.ReadOnly = True
        TextBoxFirstName.ReadOnly = True
        TextBoxLastName.ReadOnly = True
        TextBoxAddress.ReadOnly = True
        TextBoxPhone.ReadOnly = True
        TextBoxEmail.ReadOnly = True
        TextBoxStore.ReadOnly = True
        TextBoxActive.ReadOnly = True
        TextBoxUsername.ReadOnly = True
        TextBoxPassword.ReadOnly = True
        TextBoxLastUpdate.ReadOnly = True

        CheckEventButtonDeleteClicked = True
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ClearElement()

        ComboBoxBranch.Hide()
        ComboBoxActive.Hide()

        TextBoxStore.Show()
        TextBoxActive.Show()

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
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    AddStaff()
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
                    ComboBoxActive.Hide()

                    TextBoxStore.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActive.Hide()

                TextBoxStore.Show()
                TextBoxActive.Show()

                CheckEventButtonAddClicked = False
            End If
        ElseIf CheckEventButtonEditClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to edit the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    EditStaff()
                    FormMsgProcessComplete.Msg("Edit data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxBranch.Hide()
                    ComboBoxActive.Hide()

                    TextBoxStore.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActive.Hide()

                TextBoxStore.Show()
                TextBoxActive.Show()

                CheckEventButtonEditClicked = False
            End If
        ElseIf CheckEventButtonDeleteClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to delete the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    DeleteStaff()
                    FormMsgProcessComplete.Msg("Delte data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxBranch.Hide()
                    ComboBoxActive.Hide()

                    TextBoxStore.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxBranch.Hide()
                ComboBoxActive.Hide()

                TextBoxStore.Show()
                TextBoxActive.Show()

                CheckEventButtonDeleteClicked = False
            End If
        End If
    End Sub

    Private Sub ButtonRefeshStaff_Click(sender As Object, e As EventArgs) Handles ButtonRefeshStaff.Click
        dvgStaff.Rows.Clear()
        LoadDataStaff()
    End Sub

    Private Sub dvgStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgStaff.CellClick
        If IsNothing(dvgStaff.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxStaffID.Text = dvgStaff.Rows(e.RowIndex).Cells("staff_id").Value.ToString()
            TextBoxFirstName.Text = dvgStaff.Rows(e.RowIndex).Cells("first_name").Value.ToString()
            TextBoxLastName.Text = dvgStaff.Rows(e.RowIndex).Cells("last_name").Value.ToString()
            TextBoxAddress.Text = dvgStaff.Rows(e.RowIndex).Cells("address").Value.ToString()
            TextBoxPhone.Text = dvgStaff.Rows(e.RowIndex).Cells("phone").Value.ToString()
            TextBoxEmail.Text = dvgStaff.Rows(e.RowIndex).Cells("email").Value.ToString()
            TextBoxStore.Text = dvgStaff.Rows(e.RowIndex).Cells("store").Value.ToString()
            TextBoxActive.Text = dvgStaff.Rows(e.RowIndex).Cells("active").Value.ToString()
            TextBoxUsername.Text = dvgStaff.Rows(e.RowIndex).Cells("username").Value.ToString()
            TextBoxPassword.Text = dvgStaff.Rows(e.RowIndex).Cells("password").Value.ToString()
            TextBoxLastUpdate.Text = dvgStaff.Rows(e.RowIndex).Cells("last_update").Value.ToString()
        End If

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub ClearElement()
        For Each tbx In {
                          TextBoxStaffID,
                          TextBoxFirstName,
                          TextBoxLastName,
                          TextBoxAddress,
                          TextBoxPhone,
                          TextBoxEmail,
                          TextBoxStore,
                          TextBoxActive,
                          TextBoxUsername,
                          TextBoxPassword,
                          TextBoxLastUpdate
                        }
            tbx.Clear()
            tbx.ReadOnly = True
        Next
    End Sub

    Private Sub LoadDataStaff()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                  SELECT
                                    stf.staff_id,
	                                stf.first_name,
	                                stf.last_name,
                                    CONCAT(
                                            adr.address, ', ', 
		                                    adr.district, ', ', 
		                                    cty.city, ', ', 
		                                    cnt.country, ', ', 
		                                    adr.postal_code
                                          ) AS address,
                                    adr.phone,
	                                stf.email,
                                    Case
		                                WHEN
			                                stf.store_id = 1 THEN 'Branch A'
		                                ELSE
			                                'Branch B'
	                                END AS store,
                                    CASE
		                                WHEN
			                                stf.active = 't' THEN 'True'
		                                ELSE
			                                'False'
	                                END AS active,
	                                stf.username,
	                                stf.password,
	                                stf.last_update,
                                    stf.picture
                                  FROM
                                    staff AS stf
                                  LEFT JOIN
                                    address AS adr ON adr.address_id = stf.address_id
                                  LEFT JOIN
                                    city AS cty ON cty.city_id = adr.city_id
                                  LEFT JOIN
                                    country AS cnt ON cnt.country_id = cty.country_id;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgStaff.Rows.Add(
                                    Reader("staff_id"),
                                    Reader("first_name"),
                                    Reader("last_name"),
                                    Reader("phone"),
                                    Reader("email"),
                                    Reader("store"),
                                    Reader("active"),
                                    Reader("username"),
                                    Reader("password"),
                                    Reader("last_update"),
                                    Reader("address")
                                 )
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfStaff.Text = $"Number of Actor : {dvgStaff.Rows.Count.ToString() - 1} Items"
    End Sub

    Private Sub SearchStaff(ByVal name As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                  SELECT
                                    stf.staff_id,
	                                stf.first_name,
	                                stf.last_name,
                                    CONCAT(
                                            adr.address, ', ', 
		                                    adr.district, ', ', 
		                                    cty.city, ', ', 
		                                    cnt.country, ', ', 
		                                    adr.postal_code
                                          ) AS address,
                                    adr.phone,
	                                stf.email,
                                    Case
		                                WHEN
			                                stf.store_id = 1 THEN 'Branch A'
		                                ELSE
			                                'Branch B'
	                                END AS store,
                                    CASE
		                                WHEN
			                                stf.active = 't' THEN 'True'
		                                ELSE
			                                'False'
	                                END AS active,
	                                stf.username,
	                                stf.password,
	                                stf.last_update,
                                    stf.picture
                                  FROM
                                    staff as stf
                                  LEFT JOIN
                                    address as adr on adr.address_id = stf.address_id
                                  LEFT JOIN
                                    city as cty on cty.city_id = adr.city_id
                                  LEFT JOIN
                                    country as cnt on cnt.country_id = cty.country_id
                                  WHERE
                                    CONCAT(stf.first_name, ' ', stf.last_name) LIKE '%{name}%';"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                getStaffID = Reader("staff_id")
                getFirstName = Reader("first_name")
                getLastName = Reader("last_name")
                getAddress = Reader("address")
                getPhone = Reader("phone")
                getEmail = Reader("email")
                getStore = Reader("store")
                getActive = Reader("active")
                getUsername = Reader("username")
                getPassword = Reader("password")
                getLastUpdate = Reader("last_update")
            End If

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfStaff.Text = $"Number of Actor : {dvgStaff.Rows.Count.ToString() - 1} Items"
    End Sub

    Public Sub AddStaff()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Dim CbxStoreID As String = ""
        Dim CbxActiveID As String = ""

        If ComboBoxBranch.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If ComboBoxActive.SelectedItem = "True" Then
            CbxActiveID = "t"
        Else
            CbxActiveID = "f"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    INSERT INTO
                                        staff
                                            (
                                        			first_name,
                                        			last_name,
                                        			address_id,
                                        			email,
                                        			store_id,
                                        			active,
                                        			username,
                                        			password,
                                        			last_update,
                                        			picture
                                            )
                                        VALUES
                                            (
                                        			'{TbxFname}', 
                                        			'{TbxLname}',
                                        			'{TextBoxAddress.Text}',
                                        			'{TextBoxEmail.Text}',
                                        			'{CbxStoreID}',
                                        			'{CbxActiveID}',
                                        			'{TextBoxUsername.Text}',
                                        			'{MD5(TextBoxPassword.Text)}',
                                        			GETDATE(),
                                        			''
                                            );
                                 "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EditStaff()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Dim CbxStoreID As String = ""
        Dim CbxActiveID As String = ""

        If ComboBoxBranch.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If ComboBoxActive.SelectedItem = "True" Then
            CbxActiveID = "t"
        Else
            CbxActiveID = "f"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"UPDATE 
                                    staff 
                                  SET 
                                    first_name = '{TbxFname}',
                                    last_name = '{TbxLname}',
                                    address_id = '{TextBoxAddress.Text}',
                                    email = '{TextBoxEmail.Text}',
                                    store_id = '{CbxStoreID}',
                                    active = '{CbxActiveID}',
                                    username = '{TextBoxUsername.Text}',
                                    password = '{MD5(TextBoxPassword.Text)}',
                                    last_update = GETDATE(),
                                    picture = ''
                                  WHERE 
                                    staff_id = CONVERT(INT, {getStaffID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub DeleteStaff()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"DELETE FROM 
                                    staff
                                  WHERE 
                                    staff_id = CONVERT(INT, {getStaffID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

End Class
