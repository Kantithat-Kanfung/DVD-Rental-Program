Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Actor

    Private getActorID As String
    Private getFirstName As String
    Private getLastName As String
    Private getLastUpdate As String

    Private CheckEventButtonAddClicked As Boolean = False
    Private CheckEventButtonEditClicked As Boolean = False
    Private CheckEventButtonDeleteClicked As Boolean = False

    Dim info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private Sub Actor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        LoadDataActor()
        ButtonAdd.Enabled = True
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"
        Else
            SearchActor(TextBoxSearch.Text)
            TextBoxActorID.Text = getActorID
            TextBoxFirstName.Text = getFirstName
            TextBoxLastName.Text = getLastName
            TextBoxLastUpdate.Text = getLastUpdate
            ButtonAdd.Enabled = True
            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = True
            ButtonCancel.Enabled = True
        End If
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxActorID.Text = ""
        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
        TextBoxLastUpdate.Text = ""

        TextBoxActorID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True
        CheckEventButtonAddClicked = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxFirstName.Select()
        TextBoxFirstName.Focus()

        TextBoxActorID.ReadOnly = True
        TextBoxFirstName.ReadOnly = False
        TextBoxLastName.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True

        CheckEventButtonEditClicked = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ButtonAdd.Enabled = False
        ButtonEdit.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxActorID.ReadOnly = True
        TextBoxFirstName.ReadOnly = True
        TextBoxLastName.ReadOnly = True
        TextBoxLastUpdate.ReadOnly = True

        CheckEventButtonDeleteClicked = True
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxSearch.Clear()
        TextBoxActorID.Clear()
        TextBoxFirstName.Clear()
        TextBoxLastName.Clear()
        TextBoxLastUpdate.Clear()

        TextBoxFirstName.ReadOnly = True
        TextBoxLastName.ReadOnly = True

        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CheckEventButtonAddClicked = True Then
            FormMsgProcessWarning.Msg("What do you want add actor?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input a name actor!")
                Else
                    AddActor()
                    FormMsgProcessComplete.Msg("Save data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxActorID.Clear()
                    TextBoxFirstName.Clear()
                    TextBoxLastName.Clear()
                    TextBoxLastUpdate.Clear()
                End If
            Else
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False
                CheckEventButtonAddClicked = False
            End If
        ElseIf CheckEventButtonEditClicked = True Then
            FormMsgProcessWarning.Msg("What do you want edit actor?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Error: Textbox empty!")
                Else
                    EditActor()
                    FormMsgProcessComplete.Msg("Edit data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxActorID.Clear()
                    TextBoxFirstName.Clear()
                    TextBoxLastName.Clear()
                    TextBoxLastUpdate.Clear()
                End If
            Else
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False
                CheckEventButtonEditClicked = False
            End If
        ElseIf CheckEventButtonDeleteClicked = True Then
            FormMsgProcessWarning.Msg("What do you want delete actor?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFirstName.Text = "" OrElse TextBoxLastName.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    DeleteActor()
                    FormMsgProcessComplete.Msg("Delete data completed.")
                    FormMsgProcessComplete.ShowDialog()
                    TextBoxSearch.Clear()
                    TextBoxActorID.Clear()
                    TextBoxFirstName.Clear()
                    TextBoxLastName.Clear()
                    TextBoxLastUpdate.Clear()
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

    Private Sub ButtonRefeshActor_Click(sender As Object, e As EventArgs) Handles ButtonRefeshActor.Click
        dvgActor.Rows.Clear()
        LoadDataActor()
    End Sub

    Private Sub dvgActor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgActor.CellClick
        If IsNothing(dvgActor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxActorID.Text = dvgActor.Rows(e.RowIndex).Cells("id_actor").Value.ToString()
            TextBoxFirstName.Text = dvgActor.Rows(e.RowIndex).Cells("first_name").Value.ToString()
            TextBoxLastName.Text = dvgActor.Rows(e.RowIndex).Cells("last_name").Value.ToString()
            TextBoxLastUpdate.Text = dvgActor.Rows(e.RowIndex).Cells("last_update").Value.ToString()
        End If

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub LoadDataActor()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $" SELECT 
                                        actor_id, 
                                        first_name, 
                                        last_name, 
                                        last_update 
                                    FROM 
                                        actor; 
                                        "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgActor.Rows.Add(Reader("actor_id"), Reader("first_name"), Reader("last_name"), Reader("last_update"))
            End While

        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfActor.Text = $"Number of Actor : {dvgActor.Rows.Count - 1} Items"
    End Sub

    Private Sub SearchActor(ByVal name As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $" SELECT 
                                        actor_id, 
                                        first_name, 
                                        last_name, 
                                        last_update 
                                    FROM 
                                        actor 
                                    WHERE 
                                        CONCAT(first_name,' ',last_name) LIKE '%{name}%';
                                        "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                getActorID = Reader("actor_id")
                getFirstName = Reader("first_name")
                getLastName = Reader("last_name")
                getLastUpdate = Reader("last_update")
            End If

        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfActor.Text = $"Number of Actor : {dvgActor.Rows.Count - 1} Items"
    End Sub

    Public Sub AddActor()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"INSERT INTO 
                                    actor(
                                            first_name, 
                                            last_name, 
                                            last_update
                                         ) 
                                    VALUES(
                                            '{TbxFname}', 
                                            '{TbxLname}', 
                                            GETDATE());"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EditActor()
        Dim TbxFname As String = info.ToTitleCase(TextBoxFirstName.Text)
        Dim TbxLname As String = info.ToTitleCase(TextBoxLastName.Text)

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"UPDATE 
                                    actor 
                                  SET 
                                    first_name = '{TbxFname}', 
                                    last_name = '{TbxLname}' 
                                  WHERE 
                                    actor_id = CONVERT(INT, {getActorID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub DeleteActor()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"DELETE FROM 
                                    actor 
                                  WHERE 
                                    actor_id = CONVERT(INT, {getActorID});"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

End Class
