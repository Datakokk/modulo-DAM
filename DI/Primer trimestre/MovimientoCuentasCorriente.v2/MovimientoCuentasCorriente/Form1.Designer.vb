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
        Me.lblMovimientoCuentaCorriente = New System.Windows.Forms.Label()
        Me.lblNumeroCuenta = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMovimientoCuentaCorriente
        '
        Me.lblMovimientoCuentaCorriente.AutoSize = True
        Me.lblMovimientoCuentaCorriente.Location = New System.Drawing.Point(316, 21)
        Me.lblMovimientoCuentaCorriente.Name = "lblMovimientoCuentaCorriente"
        Me.lblMovimientoCuentaCorriente.Size = New System.Drawing.Size(189, 13)
        Me.lblMovimientoCuentaCorriente.TabIndex = 0
        Me.lblMovimientoCuentaCorriente.Text = "MOVIMIENTO CUENTA CORRIENTE"
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.AutoSize = True
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(148, 58)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(95, 13)
        Me.lblNumeroCuenta.TabIndex = 1
        Me.lblNumeroCuenta.Text = "Número de cuenta"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(148, 105)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(148, 153)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(64, 13)
        Me.lblSaldoInicial.TabIndex = 3
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.AutoSize = True
        Me.lblSaldoActual.Location = New System.Drawing.Point(148, 211)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(66, 13)
        Me.lblSaldoActual.TabIndex = 4
        Me.lblSaldoActual.Text = "Saldo actual"
        '
        'btnPago
        '
        Me.btnPago.Enabled = False
        Me.btnPago.Location = New System.Drawing.Point(151, 294)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(75, 23)
        Me.btnPago.TabIndex = 5
        Me.btnPago.Text = "Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Enabled = False
        Me.btnIngreso.Location = New System.Drawing.Point(151, 372)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(75, 23)
        Me.btnIngreso.TabIndex = 6
        Me.btnIngreso.Text = "Ingreso"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(360, 321)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 7
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Enabled = False
        Me.btnCliente.Location = New System.Drawing.Point(542, 294)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCliente.TabIndex = 8
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(542, 372)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(438, 58)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(179, 20)
        Me.txtNumeroCuenta.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(438, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Enabled = False
        Me.txtSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInicial.Location = New System.Drawing.Point(438, 150)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(179, 20)
        Me.txtSaldoInicial.TabIndex = 12
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Enabled = False
        Me.txtSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoActual.Location = New System.Drawing.Point(438, 204)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Size = New System.Drawing.Size(179, 20)
        Me.txtSaldoActual.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.lblSaldoActual)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNumeroCuenta)
        Me.Controls.Add(Me.lblMovimientoCuentaCorriente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMovimientoCuentaCorriente As Label
    Friend WithEvents lblNumeroCuenta As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents lblSaldoActual As Label
    Friend WithEvents btnPago As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtSaldoActual As TextBox
End Class
