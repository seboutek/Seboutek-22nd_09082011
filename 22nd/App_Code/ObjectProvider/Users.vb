Imports Microsoft.VisualBasic

Public Class Users

    Private _username As String
    Private _email As String
    Private _gender As String
    Private _password As String
    Private _userid As Integer

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal Value As String)
            _username = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property
    Public Property Gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal Value As String)
            _gender = Value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal Value As String)
            _password = Value
        End Set
    End Property
    Public Property UserId() As Integer
        Get
            Return _userid
        End Get
        Set(ByVal Value As Integer)
            _userid = Value
        End Set
    End Property
End Class
