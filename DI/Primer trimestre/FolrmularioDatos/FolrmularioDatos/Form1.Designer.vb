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
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.btnFecha = New System.Windows.Forms.Button()
        Me.btnHora = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(77, 65)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 0
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(523, 74)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 1
        '
        'btnFecha
        '
        Me.btnFecha.Location = New System.Drawing.Point(89, 285)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(75, 23)
        Me.btnFecha.TabIndex = 2
        Me.btnFecha.Text = "Fecha"
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'btnHora
        '
        Me.btnHora.Location = New System.Drawing.Point(548, 294)
        Me.btnHora.Name = "btnHora"
        Me.btnHora.Size = New System.Drawing.Size(75, 23)
        Me.btnHora.TabIndex = 3
        Me.btnHora.Text = "Hora"
        Me.btnHora.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHora)
        Me.Controls.Add(Me.btnFecha)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents btnFecha As Button
    Friend WithEvents btnHora As Button
End Class
