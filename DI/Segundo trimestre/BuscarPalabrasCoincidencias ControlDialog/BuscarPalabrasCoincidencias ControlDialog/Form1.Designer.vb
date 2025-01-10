<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblpalabra = New System.Windows.Forms.Label()
        Me.txtpalabra = New System.Windows.Forms.TextBox()
        Me.texto = New System.Windows.Forms.RichTextBox()
        Me.botonbuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpalabra
        '
        Me.lblpalabra.AutoSize = True
        Me.lblpalabra.Location = New System.Drawing.Point(70, 67)
        Me.lblpalabra.Name = "lblpalabra"
        Me.lblpalabra.Size = New System.Drawing.Size(125, 13)
        Me.lblpalabra.TabIndex = 0
        Me.lblpalabra.Text = "Palabra o frase a buscar:"
        '
        'txtpalabra
        '
        Me.txtpalabra.Location = New System.Drawing.Point(271, 67)
        Me.txtpalabra.Name = "txtpalabra"
        Me.txtpalabra.Size = New System.Drawing.Size(100, 20)
        Me.txtpalabra.TabIndex = 1
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(73, 174)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(279, 264)
        Me.texto.TabIndex = 2
        Me.texto.Text = resources.GetString("texto.Text")
        '
        'botonbuscar
        '
        Me.botonbuscar.Location = New System.Drawing.Point(150, 117)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(75, 23)
        Me.botonbuscar.TabIndex = 3
        Me.botonbuscar.Text = "Buscar coincidencias" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.botonbuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.botonbuscar)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.txtpalabra)
        Me.Controls.Add(Me.lblpalabra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblpalabra As Label
    Friend WithEvents txtpalabra As TextBox
    Friend WithEvents texto As RichTextBox
    Friend WithEvents botonbuscar As Button
End Class
