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
        Me.lblGradosCentigrados = New System.Windows.Forms.Label()
        Me.lblGradosFarenheit = New System.Windows.Forms.Label()
        Me.txtFarenheit = New System.Windows.Forms.TextBox()
        Me.txtCentigrados = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGradosCentigrados
        '
        Me.lblGradosCentigrados.AutoSize = True
        Me.lblGradosCentigrados.Location = New System.Drawing.Point(173, 84)
        Me.lblGradosCentigrados.Name = "lblGradosCentigrados"
        Me.lblGradosCentigrados.Size = New System.Drawing.Size(100, 13)
        Me.lblGradosCentigrados.TabIndex = 0
        Me.lblGradosCentigrados.Text = "Grados Centigrados"
        '
        'lblGradosFarenheit
        '
        Me.lblGradosFarenheit.AutoSize = True
        Me.lblGradosFarenheit.Location = New System.Drawing.Point(173, 210)
        Me.lblGradosFarenheit.Name = "lblGradosFarenheit"
        Me.lblGradosFarenheit.Size = New System.Drawing.Size(94, 13)
        Me.lblGradosFarenheit.TabIndex = 1
        Me.lblGradosFarenheit.Text = "Grados Farhenheit"
        '
        'txtFarenheit
        '
        Me.txtFarenheit.Location = New System.Drawing.Point(384, 210)
        Me.txtFarenheit.Name = "txtFarenheit"
        Me.txtFarenheit.Size = New System.Drawing.Size(100, 20)
        Me.txtFarenheit.TabIndex = 2
        '
        'txtCentigrados
        '
        Me.txtCentigrados.Location = New System.Drawing.Point(384, 84)
        Me.txtCentigrados.Name = "txtCentigrados"
        Me.txtCentigrados.Size = New System.Drawing.Size(100, 20)
        Me.txtCentigrados.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(176, 274)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnResetear
        '
        Me.btnResetear.Location = New System.Drawing.Point(409, 274)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(75, 23)
        Me.btnResetear.TabIndex = 5
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(294, 333)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCentigrados)
        Me.Controls.Add(Me.txtFarenheit)
        Me.Controls.Add(Me.lblGradosFarenheit)
        Me.Controls.Add(Me.lblGradosCentigrados)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGradosCentigrados As Label
    Friend WithEvents lblGradosFarenheit As Label
    Friend WithEvents txtFarenheit As TextBox
    Friend WithEvents txtCentigrados As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnResetear As Button
    Friend WithEvents btnSalir As Button
End Class
