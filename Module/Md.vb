Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Module Md

    Public ConStr As String = My.Settings.ConStr

    Public Sub ConnectDatabase()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Connection.Close()
        Catch ex As SqlException
            WriteLogErrorConnectDatabase(ex.Message.ToString())
        End Try
    End Sub

    Private Sub WriteLogErrorConnectDatabase(ByVal Content As String)
        Dim fs = My.Computer.FileSystem

        Dim f As String = "Logs\Log_Error_Connect_Database.Log"

        If fs.GetFileInfo(f).Exists Then
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        Else
            fs.CreateDirectory("Logs")
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        End If
    End Sub

    Public Sub WriteLogMistakeQuery(ByVal Content As String)
        Dim fs = My.Computer.FileSystem

        Dim f As String = "Logs\Log_Mistake_Query.Log"

        If fs.GetFileInfo(f).Exists Then
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        Else
            fs.CreateDirectory("Logs")
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        End If
    End Sub

    Public Sub WriteLogMistakeSendMail(ByVal Content As String)
        Dim fs = My.Computer.FileSystem

        Dim f As String = "Logs\Log_Mistake_Send_Mail.Log"

        If fs.GetFileInfo(f).Exists Then
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        Else
            fs.CreateDirectory("Logs")
            fs.WriteAllText(f, Now.ToString("dd/MM/yyyy HH:mm:ss") & " || " & Content & vbNewLine, True)
        End If
    End Sub

    Public Function MD5(ByVal text As String) As String
        Dim Hash As New Security.Cryptography.MD5CryptoServiceProvider

        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(text)

        ByteString = Hash.ComputeHash(ByteString)

        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next

        Return FinalString
    End Function

    ' About Application
    Public ProductName As String = My.Settings.ProductName
    Public Version As String = My.Settings.Version
    Public Copyright As String = My.Settings.Copyright
    Public Company As String = My.Settings.Company
    Public Description As String = My.Settings.Description

End Module
