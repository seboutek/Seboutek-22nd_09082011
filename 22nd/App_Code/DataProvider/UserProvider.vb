Imports System.Data.SqlClient

Namespace Account

    Public Class UserProvider

        'Private Shared ReadOnly connstr As String = "Server=OA99733-PC;Database=Media;Trusted_Connection=True;"
        Private Shared ReadOnly connstr As String = "Server=mssql1002.ixwebhosting.com;Database=22nd;User Id=oa99733;Password=pop;Trusted_Connection=False"


        Public Shared Function GetProfilebyUsernamePwd(ByVal Username As String, ByVal Password As String) As Users
            Dim conn As New SqlConnection(connstr)
            conn.Open()
            Dim command As New SqlCommand("GetUserProfie", conn)
            command.Parameters.AddWithValue("@username", Username)
            command.Parameters.AddWithValue("@password", Password)
            command.CommandType = Data.CommandType.StoredProcedure

            Dim reader As SqlDataReader = command.ExecuteReader
            Dim Users As New Users()

            If reader.Read() Then ' use if stat if hasrow to for tomorrow..........

                Users.Email = reader.Item("Email")
                Users.Gender = reader.Item("Gender")
                Users.Username = reader.Item("Username")
                Users.UserId = reader.Item("UserId")

                reader.Close()
                conn.Close()

            End If

            Return Users

        End Function
        Public Shared Sub AddUser(ByVal Username As String, ByVal email As String, ByVal gender As String, ByVal Password As String)
            Dim conn As New SqlConnection(connstr)
            conn.Open()
            Dim command As New SqlCommand("AddUser", conn)
            command.Parameters.AddWithValue("@username", Username)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Gender", gender)
            command.Parameters.AddWithValue("@Password", Password)
            command.CommandType = Data.CommandType.StoredProcedure

            command.ExecuteNonQuery()

            conn.Close()

        End Sub

    End Class
End Namespace
