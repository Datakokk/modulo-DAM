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
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.txtCapitalAcumulado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblIntereses = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblCuotaMensual = New System.Windows.Forms.Label()
        Me.txtMensualidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(125, 49)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 0
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(363, 49)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(100, 20)
        Me.txtInteres.TabIndex = 1
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(577, 49)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(100, 20)
        Me.txtTiempo.TabIndex = 2
        '
        'txtCapitalAcumulado
        '
        Me.txtCapitalAcumulado.Location = New System.Drawing.Point(148, 120)
        Me.txtCapitalAcumulado.Multiline = True
        Me.txtCapitalAcumulado.Name = "txtCapitalAcumulado"
        Me.txtCapitalAcumulado.Size = New System.Drawing.Size(529, 89)
        Me.txtCapitalAcumulado.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(125, 350)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(388, 350)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 5
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(619, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(145, 87)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 7
        Me.lblCapital.Text = "Capital"
        '
        'lblIntereses
        '
        Me.lblIntereses.AutoSize = True
        Me.lblIntereses.Location = New System.Drawing.Point(372, 87)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Size = New System.Drawing.Size(75, 13)
        Me.lblIntereses.TabIndex = 8
        Me.lblIntereses.Text = "% de interesés"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(584, 87)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(84, 13)
        Me.lblTiempo.TabIndex = 9
        Me.lblTiempo.Text = "Periodo en años"
        '
        'lblCuotaMensual
        '
        Me.lblCuotaMensual.AutoSize = True
        Me.lblCuotaMensual.Location = New System.Drawing.Point(234, 267)
        Me.lblCuotaMensual.Name = "lblCuotaMensual"
        Me.lblCuotaMensual.Size = New System.Drawing.Size(78, 13)
        Me.lblCuotaMensual.TabIndex = 10
        Me.lblCuotaMensual.Text = "Cuota Mensual"
        '
        'txtMensualidad
        '
        Me.txtMensualidad.Location = New System.Drawing.Point(363, 248)
        Me.txtMensualidad.Multiline = True
        Me.txtMensualidad.Name = "txtMensualidad"
        Me.txtMensualidad.Size = New System.Drawing.Size(245, 45)
        Me.txtMensualidad.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMensualidad)
        Me.Controls.Add(Me.lblCuotaMensual)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblIntereses)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCapitalAcumulado)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.txtCapital)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents txtCapitalAcumulado As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblIntereses As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblCuotaMensual As Label
    Friend WithEvents txtMensualidad As TextBox
End Class
