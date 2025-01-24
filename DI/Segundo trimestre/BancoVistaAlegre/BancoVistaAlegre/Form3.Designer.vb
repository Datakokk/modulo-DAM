<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblNumeroCuenta = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.lblTitutloBanco3 = New System.Windows.Forms.Label()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnIngresos = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.AutoSize = True
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(98, 145)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(80, 13)
        Me.lblNumeroCuenta.TabIndex = 1
        Me.lblNumeroCuenta.Text = "Número cuenta"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(98, 187)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(98, 231)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(64, 13)
        Me.lblSaldoInicial.TabIndex = 3
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.AutoSize = True
        Me.lblSaldoActual.Location = New System.Drawing.Point(98, 271)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(67, 13)
        Me.lblSaldoActual.TabIndex = 4
        Me.lblSaldoActual.Text = "Saldo Actual"
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(354, 138)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCuenta.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(354, 180)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(354, 224)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoInicial.TabIndex = 7
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Location = New System.Drawing.Point(354, 268)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoActual.TabIndex = 8
        '
        'lblTitutloBanco3
        '
        Me.lblTitutloBanco3.AutoSize = True
        Me.lblTitutloBanco3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloBanco3.Location = New System.Drawing.Point(210, 28)
        Me.lblTitutloBanco3.Name = "lblTitutloBanco3"
        Me.lblTitutloBanco3.Size = New System.Drawing.Size(175, 17)
        Me.lblTitutloBanco3.TabIndex = 9
        Me.lblTitutloBanco3.Text = "Banco IES Vista Alegre"
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.Location = New System.Drawing.Point(253, 91)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(64, 17)
        Me.lblGestion.TabIndex = 10
        Me.lblGestion.Text = "Gestión"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(38, 362)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnIngresos
        '
        Me.btnIngresos.Location = New System.Drawing.Point(147, 362)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresos.TabIndex = 14
        Me.btnIngresos.Text = "Ingresos"
        Me.btnIngresos.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Location = New System.Drawing.Point(256, 362)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 23)
        Me.btnPagos.TabIndex = 15
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(366, 362)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(469, 362)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(576, 362)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnIngresos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblGestion)
        Me.Controls.Add(Me.lblTitutloBanco3)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.lblSaldoActual)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNumeroCuenta)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroCuenta As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents lblSaldoActual As Label
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtSaldoActual As TextBox
    Friend WithEvents lblTitutloBanco3 As Label
    Friend WithEvents lblGestion As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnIngresos As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVolver As Button
End Class
