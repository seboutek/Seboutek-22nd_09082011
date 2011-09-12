Imports System.Net.Mail

Namespace NCEmail

    Public Class Email
        'Private Shared ReadOnly SmtpServer As String = ConfigurationSettings.AppSettings("SmtpServer")
        'Private Shared ReadOnly Domain As String = ConfigurationSettings.AppSettings("Domain")
        'This fucntion will send the email according to the strings passsed
        Public Shared Sub SendEmail(ByVal Sendto As String, ByVal From As String, ByVal Subject As String, ByVal Body As String)

            'Try
            Dim Message As MailMessage = New MailMessage()

            'Set properties of the email to be sent
            With Message
                .To.Add(Sendto)
                .From = New MailAddress(From)
                .Subject = Subject
                .Body = Body
                .IsBodyHtml = True
            End With

            'Select SmtpSever set in webconfig and send email
            Dim msmtpclient As New SmtpClient()
            msmtpclient.Host = "localhost"
            msmtpclient.Port = 25
            msmtpclient.UseDefaultCredentials = False
            msmtpclient.Send(Message)

            'Catch ex As System.Web.HttpException

            '    Throw ex

            ' End Try
        End Sub

    End Class

End Namespace

