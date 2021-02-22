Public Class Form1
    Private Sub btnGetClients_Click(sender As Object, e As EventArgs) Handles btnGetClients.Click
        Dim controlador As ClientController = New ClientController

        For Each item In controlador.GetClient().ToList()
            listBox1.Items.Add(item)
        Next
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim controller As ClientController = New ClientController()
        Dim client As Client = New Client With {
            .ClientId = 1,
            .FullName = "Luis Contreras"
        }
        controller.UpdateClient(client)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim controller As ClientController = New ClientController()
        Dim model As Client = New Client With {
            .ClientId = 3
        }
        controller.DelClient(model)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim controlador As ClientController = New ClientController()
        Dim model As Client = New Client With {
            .FullName = "Prueba",
            .Email = "prueba@prueba.com",
            .PhoneNumber = "2781231"
        }
        controlador.AddClient(model)
    End Sub
End Class
