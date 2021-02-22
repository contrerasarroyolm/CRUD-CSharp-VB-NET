<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.btnGetClients = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(518, 309)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(284, 309)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(171, 309)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(31, 46)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(747, 238)
        Me.listBox1.TabIndex = 6
        '
        'btnGetClients
        '
        Me.btnGetClients.Location = New System.Drawing.Point(397, 309)
        Me.btnGetClients.Name = "btnGetClients"
        Me.btnGetClients.Size = New System.Drawing.Size(75, 23)
        Me.btnGetClients.TabIndex = 5
        Me.btnGetClients.Text = "Obtener"
        Me.btnGetClients.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.btnGetClients)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnActualizar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents listBox1 As ListBox
    Private WithEvents btnGetClients As Button
End Class
