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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNumeroCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(335, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(248, 17)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "MOVIMIENTOS CUENTA CORRIENTE"
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.AutoSize = True
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(111, 77)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(101, 13)
        Me.lblNumeroCuenta.TabIndex = 1
        Me.lblNumeroCuenta.Text = "Número de cuenta: "
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(111, 159)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(64, 13)
        Me.lblSaldoInicial.TabIndex = 2
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.AutoSize = True
        Me.lblSaldoActual.Location = New System.Drawing.Point(111, 251)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(67, 13)
        Me.lblSaldoActual.TabIndex = 3
        Me.lblSaldoActual.Text = "Saldo Actual"
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(433, 61)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(244, 20)
        Me.txtNumeroCuenta.TabIndex = 4
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Enabled = False
        Me.txtSaldoInicial.Location = New System.Drawing.Point(433, 152)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(211, 20)
        Me.txtSaldoInicial.TabIndex = 5
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Enabled = False
        Me.txtSaldoActual.Location = New System.Drawing.Point(433, 248)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Size = New System.Drawing.Size(211, 20)
        Me.txtSaldoActual.TabIndex = 6
        '
        'btnPago
        '
        Me.btnPago.Enabled = False
        Me.btnPago.Location = New System.Drawing.Point(53, 352)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(75, 23)
        Me.btnPago.TabIndex = 7
        Me.btnPago.Text = "Pagar"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Enabled = False
        Me.btnIngreso.Location = New System.Drawing.Point(238, 352)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(75, 23)
        Me.btnIngreso.TabIndex = 8
        Me.btnIngreso.Text = "Ingreso"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Location = New System.Drawing.Point(433, 352)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(619, 352)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.lblSaldoActual)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblNumeroCuenta)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNumeroCuenta As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents lblSaldoActual As Label
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtSaldoActual As TextBox
    Friend WithEvents btnPago As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
End Class
