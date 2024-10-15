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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRadio = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtRadio = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(141, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(123, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "AREA DE UN CIRCULO"
        '
        'lblRadio
        '
        Me.lblRadio.AutoSize = True
        Me.lblRadio.Location = New System.Drawing.Point(102, 97)
        Me.lblRadio.Name = "lblRadio"
        Me.lblRadio.Size = New System.Drawing.Size(53, 13)
        Me.lblRadio.TabIndex = 1
        Me.lblRadio.Text = "Radio......"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(102, 227)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(44, 13)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Area....."
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(105, 283)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnResetear
        '
        Me.btnResetear.Location = New System.Drawing.Point(310, 283)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(75, 23)
        Me.btnResetear.TabIndex = 4
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(213, 365)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtRadio
        '
        Me.txtRadio.Location = New System.Drawing.Point(252, 97)
        Me.txtRadio.Name = "txtRadio"
        Me.txtRadio.Size = New System.Drawing.Size(100, 20)
        Me.txtRadio.TabIndex = 6
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(252, 220)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 7
        Me.txtArea.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtRadio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblRadio)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRadio As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnResetear As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtRadio As TextBox
    Friend WithEvents txtArea As TextBox
End Class
