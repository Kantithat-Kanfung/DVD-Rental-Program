Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text

Public Class Membership

    Private info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private dvdSender As String = "dvd.rental@example.com"

    Private getEmail As String

    Private content As String

    Private Attach As String = "C:\Users\Snakeman\Desktop\DVD RENTAL\img\cd.png"

    Private Sub Membership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        TextBoxSearch.Focus()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"

            ButtonSendMail.Enabled = False
            ButtonCancel.Enabled = False
        Else
            SearchCustomer(TextBoxSearch.Text)

            TextBoxFrom.Text = dvdSender
            TextBoxTo.Text = getEmail
            TextBoxAttach.Text = Attach
            TextBoxBody.Text = content

        End If

    End Sub

    Private Sub SearchCustomer(ByVal name As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $" 
                                    SELECT
                                        f.title,
                                        CONCAT(c.first_name, ' ', c.last_name) AS fullname,
                                        LOWER(concat(c.first_name, '.', c.last_name,'@example.com')) AS email,
	                                    FORMAT(r.rental_date, 'd', 'en-us') AS rental_date,
	                                    FORMAT(r.return_date, 'd', 'en-us') AS return_date,
	                                    DATEDIFF(day, r.rental_date, r.return_date) AS date_difference       
                                    FROM
                                    	rental AS r
                                    LEFT JOIN
                                    	inventory AS i ON i.inventory_id = r.inventory_id
                                    LEFT JOIN
                                    	film AS f ON f.film_id = i.film_id
                                    RIGHT JOIN
                                    	staff AS s ON s.staff_id = r.staff_id
                                    LEFT JOIN
                                    	customer AS c ON c.customer_id = r.customer_id
                                    WHERE
                                    	CONCAT(c.first_name, ' ', c.last_name) LIKE '%{name}%' AND 
                                    	FORMAT(r.rental_date, 'd', 'en-us') = '8/23/2005'  
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                getEmail = Reader("email")

                content &= $"Title : {Reader("title") & vbNewLine &
                           "Rental Date : " & Reader("rental_date") & vbNewLine &
                           "Return Date : " & Reader("return_date") & vbNewLine &
                           "The timing remaining : " & Reader("date_difference")}" & " Day" &
                           vbNewLine & "------- " & Reader("fullname") & " --------" & vbNewLine & vbNewLine
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonSendMail_Click(sender As Object, e As EventArgs) Handles ButtonSendMail.Click
        If TextBoxFrom.Text = "" And TextBoxTo.Text = "" And TextBoxSubject.Text = "" And TextBoxBody.Text = "" Then
            FormMsgProcessWarning.Msg("Please input your data!")
            FormMsgProcessWarning.ShowDialog()
        Else
            If IsNumeric(TextBoxTo.Text) Then
                FormMsgProcessError.Msg("Incorrect : Do not input number!")
                FormMsgProcessError.ShowDialog()
            Else
                If Not My.Computer.Network.IsAvailable Then
                    FormMsgProcessWarning.Msg("Unable to connect to the network!")
                    FormMsgProcessWarning.ShowDialog()
                End If

                Dim smtp As New SmtpClient("smtp.totisp.net")
                Dim mail As New MailMessage()

                mail.From = New MailAddress(TextBoxFrom.Text)
                mail.To.Add(TextBoxTo.Text)
                mail.Subject = TextBoxSubject.Text
                mail.Body = TextBoxBody.Text

                If ComboBoxEncoding.SelectedItem = "UTF-8" Then
                    mail.SubjectEncoding = Encoding.GetEncoding(65001)
                    mail.BodyEncoding = Encoding.GetEncoding(65001)
                Else ComboBoxEncoding.SelectedItem = "Windows-874"
                    mail.SubjectEncoding = Encoding.GetEncoding(874)
                    mail.BodyEncoding = Encoding.GetEncoding(874)
                End If

                If TextBoxAttach.Text <> "" Then
                    Dim attach As New Attachment(TextBoxAttach.Text)
                    mail.Attachments.Add(attach)
                End If

                Try
                    smtp.Send(mail)
                    Application.DoEvents()
                    FormMsgProcessComplete.Msg("Processed Completed.")
                    FormMsgProcessComplete.ShowDialog()
                    Me.Refresh()
                Catch ex As Exception
                    FormMsgProcessError.Msg("Can not the send mail!")
                    FormMsgProcessError.ShowDialog()
                    WriteLogMistakeSendMail(ex.Message.ToString())
                    Me.Refresh()
                Finally
                    smtp.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxSearch.Clear()
        TextBoxFrom.Clear()
        TextBoxSubject.Clear()
        TextBoxAttach.Clear()
        TextBoxBody.Clear()
    End Sub

#Region "forDev"
    Function IsValidString(ByVal str As String) As Boolean
        If IsNumeric(str) Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

End Class
