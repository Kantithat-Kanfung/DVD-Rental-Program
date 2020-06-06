Imports System.Data
Imports System.Data.SqlClient

Public Class FormLogin

    Public GetFirstName As String
    Public GetLastName As String

    Public MainSceenPage As New FormMainScreen

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
    End Sub

    Private Sub FormLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonLogin_Click(sender, e)
        End If
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Login()
    End Sub

    Private Sub Login()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            Else
                MsgBox("Not Connecting")
            End If

            Dim Sql As String = $"Select 
                                    first_name, 
                                    last_name, 
                                    username, 
                                    password 
                                  FROM 
                                    Staff 
                                  WHERE 
                                    username = '{TextBoxUsername.Text}' AND 
                                    password = '{MD5(TextBoxPassword.Text)}';"

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                GetFirstName = Reader("first_name")
                GetLastName = Reader("last_name")
                MainSceenPage.Show()
                Me.Close()
            Else
                LabelMsgLoginError.Text = "Error: Username or Password incorrect!"
            End If

            Connection.Close()
        Catch ex As SqlException
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

End Class