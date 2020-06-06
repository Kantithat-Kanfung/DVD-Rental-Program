Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Inventory

    Private getInventoryID As String
    Private getFilmID As String
    Private getTitle As String
    Private getStoreID As String
    Private getActive As String
    Private getLastupdate As String

    Private CheckEventButtonAddClicked As Boolean = False
    Private CheckEventButtonEditClicked As Boolean = False
    Private CheckEventButtonDeleteClicked As Boolean = False

    Dim info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()

        LoadDataInventory()

        ComboBoxStoreID.Hide()
        ComboBoxActive.Hide()

        ButtonAdd.Enabled = False
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"
        Else
            SearchFilm(TextBoxSearch.Text)
            TextBoxInventoryID.Text = getInventoryID
            TextBoxFilmID.Text = getFilmID
            TextBoxTitle.Text = getTitle
            TextBoxStoreID.Text = getStoreID
            TextBoxActive.Text = getActive
            TextBoxLastUpdate.Text = getLastupdate
            ButtonAdd.Enabled = True
            ButtonEdit.Enabled = True
            ButtonCancel.Enabled = True
        End If
        ButtonSave.Enabled = False
        ComboBoxStoreID.Hide()
        ComboBoxActive.Hide()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ButtonEdit.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxInventoryID.ReadOnly = True
        TextBoxFilmID.ReadOnly = True
        TextBoxTitle.ReadOnly = True
        TextBoxStoreID.ReadOnly = False
        TextBoxActive.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True

        ComboBoxStoreID.Show()
        ComboBoxActive.Hide()

        CheckEventButtonAddClicked = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxActive.Select()

        TextBoxInventoryID.ReadOnly = True
        TextBoxFilmID.ReadOnly = True
        TextBoxTitle.ReadOnly = True
        TextBoxStoreID.ReadOnly = True
        TextBoxActive.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True

        ComboBoxStoreID.Show()
        ComboBoxActive.Show()

        CheckEventButtonEditClicked = True
    End Sub

#Region "forDev"
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' ... Something ...
    End Sub
#End Region

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxSearch.Clear()
        TextBoxInventoryID.Clear()
        TextBoxFilmID.Clear()
        TextBoxTitle.Clear()
        TextBoxStoreID.Clear()
        TextBoxActive.Clear()
        TextBoxLastUpdate.Clear()

        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = False
        ButtonSave.Enabled = False

        ComboBoxStoreID.Hide()
        ComboBoxActive.Hide()

        TextBoxStoreID.Show()
        TextBoxActive.Show()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CheckEventButtonAddClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to add the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxStoreID.Text = "" OrElse TextBoxStoreID.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    AddInv()
                    FormMsgProcessComplete.Msg("Save data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxInventoryID.Clear()
                    TextBoxFilmID.Clear()
                    TextBoxTitle.Clear()
                    TextBoxStoreID.Clear()
                    TextBoxActive.Clear()
                    TextBoxLastUpdate.Clear()

                    ComboBoxStoreID.Hide()
                    ComboBoxActive.Hide()

                    TextBoxStoreID.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False
                CheckEventButtonAddClicked = False
            End If
        ElseIf CheckEventButtonEditClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to edit the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxStoreID.Text = "" OrElse TextBoxStoreID.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    EditInv()
                    FormMsgProcessComplete.Msg("Edit data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxInventoryID.Clear()
                    TextBoxFilmID.Clear()
                    TextBoxTitle.Clear()
                    TextBoxStoreID.Clear()
                    TextBoxActive.Clear()
                    TextBoxLastUpdate.Clear()

                    ComboBoxStoreID.Hide()
                    ComboBoxActive.Hide()

                    TextBoxStoreID.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False
                CheckEventButtonEditClicked = False
            End If
        ElseIf CheckEventButtonDeleteClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to delete the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxStoreID.Text = "" OrElse TextBoxStoreID.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    DeleteInv()
                    FormMsgProcessComplete.Msg("Delete data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxInventoryID.Clear()
                    TextBoxFilmID.Clear()
                    TextBoxTitle.Clear()
                    TextBoxStoreID.Clear()

                    ComboBoxStoreID.Hide()
                    ComboBoxActive.Hide()

                    TextBoxStoreID.Show()
                    TextBoxActive.Show()
                End If
            Else
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False
                CheckEventButtonDeleteClicked = False
            End If
        End If
    End Sub

    Private Sub ButtonRefeshInventory_Click(sender As Object, e As EventArgs) Handles ButtonRefeshInventory.Click
        dvgInventory.Rows.Clear()
        LoadDataInventory()
    End Sub

    Private Sub dvgInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgInventory.CellClick
        If IsNothing(dvgInventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxInventoryID.Text = dvgInventory.Rows(e.RowIndex).Cells("inventory_id").Value.ToString()
            TextBoxFilmID.Text = dvgInventory.Rows(e.RowIndex).Cells("film_id").Value.ToString()
            TextBoxTitle.Text = dvgInventory.Rows(e.RowIndex).Cells("title").Value.ToString()
            TextBoxStoreID.Text = dvgInventory.Rows(e.RowIndex).Cells("store_id").Value.ToString()
            TextBoxActive.Text = dvgInventory.Rows(e.RowIndex).Cells("active").Value.ToString()
            TextBoxLastUpdate.Text = dvgInventory.Rows(e.RowIndex).Cells("last_update").Value.ToString()
        End If

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
    End Sub

    Private Sub LoadDataInventory()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $" SELECT 
                                        i.inventory_id, 
                                        i.film_id,
                                        f.title, 
                                    CASE
                                        WHEN
                                            CONVERT(INT, i.store_id) = 1 THEN 'Branch A'
                                        ELSE
                                            'Branch B'
                                    END AS store_id,
                                    CASE
                                        WHEN
                                            CONVERT(INT, i.active) = 1 THEN 'True'
                                        ELSE
                                            'False'
                                    END AS active,
                                        i.last_update 
                                    FROM 
                                        inventory AS i
                                    LEFT JOIN
                                        film AS f ON f.film_id = i.film_id;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgInventory.Rows.Add(
                                        Reader("inventory_id"),
                                        Reader("film_id"),
                                        Reader("title"),
                                        Reader("store_id"),
                                        Reader("active"),
                                        Reader("last_update")
                                     )
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfInventory.Text = $"Number of Actor : {dvgInventory.Rows.Count.ToString() - 1} Items"
    End Sub

    Private Sub SearchFilm(ByVal id As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $" SELECT 
                                        i.inventory_id, 
                                        i.film_id,
                                        f.title, 
                                    CASE
                                        WHEN
                                            CONVERT(INT, i.store_id) = 1 THEN 'Branch A'
                                        ELSE
                                            'Branch B'
                                    END AS store_id,
                                    CASE
                                        WHEN
                                            CONVERT(INT, i.active) = 1 THEN 'True'
                                        ELSE
                                            'False'
                                    END AS active,
                                        i.last_update 
                                    FROM 
                                        inventory AS i
                                    LEFT JOIN
                                        film AS f ON f.film_id = i.film_id
                                    WHERE 
                                        i.Inventory_id LIKE {CInt(id)};
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                getInventoryID = Reader("inventory_id")
                getFilmID = Reader("film_id")
                getTitle = Reader("title")
                getStoreID = Reader("store_id")
                getActive = Reader("active")
                getLastupdate = Reader("last_update")
            End If

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfInventory.Text = $"Number of Actor : {dvgInventory.Rows.Count.ToString() - 1} Items"
    End Sub

    Public Sub AddInv()
        Dim CbxStoreID As String = ""
        Dim TbxActiveID As String = ""

        If ComboBoxStoreID.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If TextBoxActive.Text = "True" Then
            TbxActiveID = "1"
        Else
            TbxActiveID = "0"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"INSERT INTO 
                                       inventory(
                                                film_id, 
                                                store_id, 
                                                active, 
                                                last_update
                                             ) 
                                       VALUES(
                                               '{TextBoxFilmID.Text}', 
                                               '{CbxStoreID}', 
                                               '{TbxActiveID}', 
                                               GETDATE()
                                             );"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EditInv()
        Dim CbxStoreID As String = ""
        Dim TbxActive As String = ""

        If ComboBoxStoreID.SelectedItem = "Branch A" Then
            CbxStoreID = "1"
        Else
            CbxStoreID = "2"
        End If

        If TextBoxActive.Text = "True" Then
            TbxActive = "1"
        Else
            TbxActive = "0"
        End If

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"UPDATE 
                                    inventory 
                                  SET 
                                    film_id = '{TextBoxFilmID.Text}', 
                                    store_id = CONVERT(INT, {CbxStoreID}), 
                                    active = CONVERT(INT, {TbxActive})
                                  WHERE 
                                    inventory_id = CONVERT(INT, {getInventoryID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

#Region "Delete data the film in inventory"
    Public Sub DeleteInv()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"DELETE FROM 
                                    inventory
                                  WHERE 
                                    inventory_id = CONVERT(INT, {getInventoryID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub
#End Region

End Class
