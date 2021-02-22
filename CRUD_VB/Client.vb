Public Class Client

    Public Sub New()
    End Sub

    Public Sub New(ByVal ClientId As Integer, ByVal FullName As String, ByVal Email As String, ByVal PhoneNumber As String)
        Me.ClientId = ClientId
        Me.FullName = FullName
        Me.Email = Email
        Me.PhoneNumber = PhoneNumber
    End Sub

    Public Property ClientId As Integer
    Public Property FullName As String
    Public Property Email As String
    Public Property PhoneNumber As String

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1} ({2})", FullName, Email, PhoneNumber)
    End Function

End Class
