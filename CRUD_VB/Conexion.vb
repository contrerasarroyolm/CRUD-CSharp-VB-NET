Imports System.Data.SqlClient

Public Class Conexion
    Public Function GetConexion() As SqlConnection
        Dim cadena As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MyDbContext;Integrated Security=True;"
        Dim con As SqlConnection = New SqlConnection(cadena)
        con.Open()
        Return con
    End Function
End Class
