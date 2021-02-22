Imports System.Data.SqlClient
Imports CRUD_CSharp
Imports CRUD_VB

Public Class ClientController

    Private conexion As Conexion = New Conexion()

    Public Sub AddClient(ByVal client As Client)
        Using con As SqlConnection = conexion.GetConexion()
            Dim consulta As String = "insert into Clients (FullName, Email, PhoneNumber) values (@FullName, @Email, @PhoneNumber) "
            Dim comando As SqlCommand = New SqlCommand(consulta, con)
            comando.Parameters.AddWithValue("@FullName", client.FullName)
            comando.Parameters.AddWithValue("@Email", client.Email)
            comando.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber)
            Dim lector As SqlDataReader = comando.ExecuteReader()
            lector.Close()
        End Using
    End Sub

    Public Function GetClient() As List(Of Client)
        Dim _client As List(Of Client) = New List(Of Client)()
        Dim con As SqlConnection = conexion.GetConexion()
        Dim consulta As String = "select * from Clients"
        Dim comando As SqlCommand = New SqlCommand(consulta, con)
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter(comando)
        Dim datos As DataSet = New DataSet()
        adaptador.Fill(datos)

        If datos IsNot Nothing Then

            For Each item As DataRow In datos.Tables(0).Rows
                Dim c As Client = New Client()
                c.ClientId = CInt(item("ClientId"))
                c.FullName = CStr(item("FullName"))
                c.Email = CStr(item("Email"))
                c.PhoneNumber = CStr(item("PhoneNumber"))
                _client.Add(c)
            Next

            con.Close()
        End If

        Return _client
    End Function

    'Public Function getClient() As List(Of Client)
    '    Using cnn As SqlConnection = conexion.GetConexion()
    '        Dim clientes As List(Of Client) = New List(Of Client)()
    '        Dim cmd As SqlCommand = New SqlCommand($"select * from Clients", cnn)
    '        Dim sdr As SqlDataReader = cmd.ExecuteReader()

    '        If sdr.HasRows Then
    '            Dim c As Client = New Client()

    '            While sdr.Read()
    '                c.ClientId = CInt(sdr("ClientId"))
    '                c.FullName = CStr(sdr("FullName"))
    '                c.Email = CStr(sdr("Email"))
    '                c.PhoneNumber = CStr(sdr("PhoneNumber"))
    '                clientes.Add(c)
    '            End While

    '            cnn.Close()
    '        End If

    '        Return clientes
    '    End Using
    'End Function

    Public Sub DelClient(ByVal client As Client)
        Using con As SqlConnection = conexion.GetConexion()
            Dim query As String = "Delete Clients where ClientId=" & client.ClientId
            Dim command As SqlCommand = New SqlCommand(query, con)
            Dim c As Client = New Client()
            c.ClientId = client.ClientId
            Dim reader As SqlDataReader = command.ExecuteReader()
            con.Close()
        End Using
    End Sub

    Public Sub UpdateClient(ByVal client As Client)
        Using con As SqlConnection = conexion.GetConexion()
            Dim query As String = "Update Clients set FullName=@FullName where ClientId=@ClientId"
            Dim command As SqlCommand = New SqlCommand(query, con)
            command.Parameters.AddWithValue("@FullName", client.FullName)
            command.Parameters.AddWithValue("@ClientId", client.ClientId)
            Dim reader As SqlDataReader = command.ExecuteReader()
            con.Close()
        End Using
    End Sub

    'Friend Sub DelClient(model As Client)
    '    Dim conexion As Conexion = New Conexion()
    '    Using con As SqlConnection = conexion.GetConexion()
    '        Dim query As String = "Delete Clients where ClientId=" & model.ClientId
    '        Dim command As SqlCommand = New SqlCommand(query, con)
    '        Dim c As Client = New Client()
    '        c.ClientId = model.ClientId
    '        Dim reader As SqlDataReader = command.ExecuteReader()
    '        con.Close()
    '    End Using
    'End Sub

    'Friend Sub UpdateClient(client As Client)
    '    Dim conexion As Conexion = New Conexion()
    '    Using con As SqlConnection = conexion.GetConexion()
    '        Dim query As String = "Update Clients set FullName=@FullName where ClientId=@ClientId"
    '        Dim command As SqlCommand = New SqlCommand(query, con)
    '        command.Parameters.AddWithValue("@FullName", client.FullName)
    '        command.Parameters.AddWithValue("@ClientId", client.ClientId)
    '        Dim reader As SqlDataReader = command.ExecuteReader()
    '        con.Close()
    '    End Using
    'End Sub

    'Friend Function GetClient() As List(Of Client)
    '    Dim conexion As Conexion = New Conexion()
    '    Dim _client As List(Of Client) = New List(Of Client)()
    '    Dim con As SqlConnection = conexion.GetConexion()
    '    Dim consulta As String = "select * from Clients"
    '    Dim comando As SqlCommand = New SqlCommand(consulta, con)
    '    Dim adaptador As SqlDataAdapter = New SqlDataAdapter(comando)
    '    Dim datos As DataSet = New DataSet()
    '    adaptador.Fill(datos)

    '    If datos IsNot Nothing Then
    '        For Each item As DataRow In datos.Tables(0).Rows
    '            Dim c As Client = New Client()
    '            c.ClientId = CInt(item("ClientId"))
    '            c.FullName = CStr(item("FullName"))
    '            c.Email = CStr(item("Email"))
    '            c.PhoneNumber = CStr(item("PhoneNumber"))
    '            _client.Add(c)
    '        Next
    '        con.Close()
    '    End If

    '    Return _client
    'End Function

End Class
