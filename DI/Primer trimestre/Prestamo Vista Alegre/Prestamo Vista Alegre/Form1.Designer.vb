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
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.lblCInteres = New System.Windows.Forms.Label()
        Me.lblCAcumulado = New System.Windows.Forms.Label()
        Me.txtCInteres = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtCAcumulado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(334, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(167, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Préstamo Vista Alegre"
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(175, 103)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 1
        Me.lblCapital.Text = "Cápital"
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(175, 152)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(50, 13)
        Me.lblInteres.TabIndex = 2
        Me.lblInteres.Text = "Interés %"
        '
        'lblCInteres
        '
        Me.lblCInteres.AutoSize = True
        Me.lblCInteres.Location = New System.Drawing.Point(175, 197)
        Me.lblCInteres.Name = "lblCInteres"
        Me.lblCInteres.Size = New System.Drawing.Size(84, 13)
        Me.lblCInteres.TabIndex = 3
        Me.lblCInteres.Text = "Cápital intereses"
        '
        'lblCAcumulado
        '
        Me.lblCAcumulado.AutoSize = True
        Me.lblCAcumulado.Location = New System.Drawing.Point(175, 245)
        Me.lblCAcumulado.Name = "lblCAcumulado"
        Me.lblCAcumulado.Size = New System.Drawing.Size(94, 13)
        Me.lblCAcumulado.TabIndex = 4
        Me.lblCAcumulado.Text = "Cápital acumulado"
        '
        'txtCInteres
        '
        Me.txtCInteres.Enabled = False
        Me.txtCInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCInteres.Location = New System.Drawing.Point(337, 194)
        Me.txtCInteres.Name = "txtCInteres"
        Me.txtCInteres.Size = New System.Drawing.Size(100, 20)
        Me.txtCInteres.TabIndex = 5
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(337, 149)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(100, 20)
        Me.txtInteres.TabIndex = 6
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(337, 100)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 7
        '
        'txtCAcumulado
        '
        Me.txtCAcumulado.Enabled = False
        Me.txtCAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAcumulado.Location = New System.Drawing.Point(337, 242)
        Me.txtCAcumulado.Name = "txtCAcumulado"
        Me.txtCAcumulado.Size = New System.Drawing.Size(100, 20)
        Me.txtCAcumulado.TabIndex = 8
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(178, 346)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(337, 346)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(481, 346)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCAcumulado)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.txtCInteres)
        Me.Controls.Add(Me.lblCAcumulado)
        Me.Controls.Add(Me.lblCInteres)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblInteres As Label
    Friend WithEvents lblCInteres As Label
    Friend WithEvents lblCAcumulado As Label
    Friend WithEvents txtCInteres As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtCAcumulado As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSalir As Button
End Class
