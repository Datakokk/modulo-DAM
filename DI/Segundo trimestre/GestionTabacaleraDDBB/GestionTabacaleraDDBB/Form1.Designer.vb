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
        Me.GBoxProducto = New System.Windows.Forms.GroupBox()
        Me.lblMarcas = New System.Windows.Forms.Label()
        Me.lblTabaqueras = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBoxMarcas = New System.Windows.Forms.ListBox()
        Me.CBoxTabaqueras = New System.Windows.Forms.ComboBox()
        Me.GBoxCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.txtPromocion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNicotina = New System.Windows.Forms.TextBox()
        Me.txtNumCigarrillos = New System.Windows.Forms.TextBox()
        Me.lblPromocion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNicotina = New System.Windows.Forms.Label()
        Me.lblNumCigarrillos = New System.Windows.Forms.Label()
        Me.GBoxCompra = New System.Windows.Forms.GroupBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.CheckBoxCartones = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownUnidades = New System.Windows.Forms.NumericUpDown()
        Me.GBoxPedidos = New System.Windows.Forms.GroupBox()
        Me.btnBorrarPedido = New System.Windows.Forms.Button()
        Me.btnRealizarPedido = New System.Windows.Forms.Button()
        Me.LBoxPedidos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GBoxProducto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxCaracteristicas.SuspendLayout()
        Me.GBoxCompra.SuspendLayout()
        CType(Me.NumericUpDownUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxPedidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxProducto
        '
        Me.GBoxProducto.Controls.Add(Me.lblMarcas)
        Me.GBoxProducto.Controls.Add(Me.lblTabaqueras)
        Me.GBoxProducto.Controls.Add(Me.PictureBox1)
        Me.GBoxProducto.Controls.Add(Me.LBoxMarcas)
        Me.GBoxProducto.Controls.Add(Me.CBoxTabaqueras)
        Me.GBoxProducto.Location = New System.Drawing.Point(12, 53)
        Me.GBoxProducto.Name = "GBoxProducto"
        Me.GBoxProducto.Size = New System.Drawing.Size(386, 207)
        Me.GBoxProducto.TabIndex = 0
        Me.GBoxProducto.TabStop = False
        Me.GBoxProducto.Text = "PRODUCTO"
        '
        'lblMarcas
        '
        Me.lblMarcas.AutoSize = True
        Me.lblMarcas.Location = New System.Drawing.Point(191, 42)
        Me.lblMarcas.Name = "lblMarcas"
        Me.lblMarcas.Size = New System.Drawing.Size(52, 13)
        Me.lblMarcas.TabIndex = 4
        Me.lblMarcas.Text = "MARCAS"
        '
        'lblTabaqueras
        '
        Me.lblTabaqueras.AutoSize = True
        Me.lblTabaqueras.Location = New System.Drawing.Point(35, 42)
        Me.lblTabaqueras.Name = "lblTabaqueras"
        Me.lblTabaqueras.Size = New System.Drawing.Size(80, 13)
        Me.lblTabaqueras.TabIndex = 3
        Me.lblTabaqueras.Text = "TABAQUERAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(281, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LBoxMarcas
        '
        Me.LBoxMarcas.FormattingEnabled = True
        Me.LBoxMarcas.Location = New System.Drawing.Point(154, 58)
        Me.LBoxMarcas.Name = "LBoxMarcas"
        Me.LBoxMarcas.Size = New System.Drawing.Size(120, 121)
        Me.LBoxMarcas.TabIndex = 1
        '
        'CBoxTabaqueras
        '
        Me.CBoxTabaqueras.FormattingEnabled = True
        Me.CBoxTabaqueras.Location = New System.Drawing.Point(18, 58)
        Me.CBoxTabaqueras.Name = "CBoxTabaqueras"
        Me.CBoxTabaqueras.Size = New System.Drawing.Size(121, 21)
        Me.CBoxTabaqueras.TabIndex = 0
        Me.CBoxTabaqueras.Text = "TABACALERA"
        '
        'GBoxCaracteristicas
        '
        Me.GBoxCaracteristicas.Controls.Add(Me.txtPromocion)
        Me.GBoxCaracteristicas.Controls.Add(Me.txtPrecio)
        Me.GBoxCaracteristicas.Controls.Add(Me.txtNicotina)
        Me.GBoxCaracteristicas.Controls.Add(Me.txtNumCigarrillos)
        Me.GBoxCaracteristicas.Controls.Add(Me.lblPromocion)
        Me.GBoxCaracteristicas.Controls.Add(Me.lblPrecio)
        Me.GBoxCaracteristicas.Controls.Add(Me.lblNicotina)
        Me.GBoxCaracteristicas.Controls.Add(Me.lblNumCigarrillos)
        Me.GBoxCaracteristicas.Location = New System.Drawing.Point(404, 53)
        Me.GBoxCaracteristicas.Name = "GBoxCaracteristicas"
        Me.GBoxCaracteristicas.Size = New System.Drawing.Size(290, 141)
        Me.GBoxCaracteristicas.TabIndex = 1
        Me.GBoxCaracteristicas.TabStop = False
        Me.GBoxCaracteristicas.Text = "CARACTERISTICAS"
        '
        'txtPromocion
        '
        Me.txtPromocion.Location = New System.Drawing.Point(162, 105)
        Me.txtPromocion.Name = "txtPromocion"
        Me.txtPromocion.Size = New System.Drawing.Size(100, 20)
        Me.txtPromocion.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(21, 105)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'txtNicotina
        '
        Me.txtNicotina.Location = New System.Drawing.Point(162, 42)
        Me.txtNicotina.Name = "txtNicotina"
        Me.txtNicotina.Size = New System.Drawing.Size(100, 20)
        Me.txtNicotina.TabIndex = 5
        '
        'txtNumCigarrillos
        '
        Me.txtNumCigarrillos.Location = New System.Drawing.Point(21, 42)
        Me.txtNumCigarrillos.Name = "txtNumCigarrillos"
        Me.txtNumCigarrillos.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCigarrillos.TabIndex = 4
        '
        'lblPromocion
        '
        Me.lblPromocion.AutoSize = True
        Me.lblPromocion.Location = New System.Drawing.Point(178, 84)
        Me.lblPromocion.Name = "lblPromocion"
        Me.lblPromocion.Size = New System.Drawing.Size(73, 13)
        Me.lblPromocion.TabIndex = 3
        Me.lblPromocion.Text = "PROMOCION"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(18, 84)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "PRECIO"
        '
        'lblNicotina
        '
        Me.lblNicotina.AutoSize = True
        Me.lblNicotina.Location = New System.Drawing.Point(178, 20)
        Me.lblNicotina.Name = "lblNicotina"
        Me.lblNicotina.Size = New System.Drawing.Size(58, 13)
        Me.lblNicotina.TabIndex = 1
        Me.lblNicotina.Text = "NICOTINA"
        '
        'lblNumCigarrillos
        '
        Me.lblNumCigarrillos.AutoSize = True
        Me.lblNumCigarrillos.Location = New System.Drawing.Point(18, 20)
        Me.lblNumCigarrillos.Name = "lblNumCigarrillos"
        Me.lblNumCigarrillos.Size = New System.Drawing.Size(90, 13)
        Me.lblNumCigarrillos.TabIndex = 0
        Me.lblNumCigarrillos.Text = "NºCIGARRILLOS"
        '
        'GBoxCompra
        '
        Me.GBoxCompra.Controls.Add(Me.lblUnidades)
        Me.GBoxCompra.Controls.Add(Me.CheckBoxCartones)
        Me.GBoxCompra.Controls.Add(Me.NumericUpDownUnidades)
        Me.GBoxCompra.Location = New System.Drawing.Point(700, 53)
        Me.GBoxCompra.Name = "GBoxCompra"
        Me.GBoxCompra.Size = New System.Drawing.Size(155, 141)
        Me.GBoxCompra.TabIndex = 2
        Me.GBoxCompra.TabStop = False
        Me.GBoxCompra.Text = "COMPRA"
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(38, 112)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(63, 13)
        Me.lblUnidades.TabIndex = 2
        Me.lblUnidades.Text = "UNIDADES"
        '
        'CheckBoxCartones
        '
        Me.CheckBoxCartones.AutoSize = True
        Me.CheckBoxCartones.Location = New System.Drawing.Point(16, 20)
        Me.CheckBoxCartones.Name = "CheckBoxCartones"
        Me.CheckBoxCartones.Size = New System.Drawing.Size(85, 17)
        Me.CheckBoxCartones.TabIndex = 1
        Me.CheckBoxCartones.Text = "CARTONES"
        Me.CheckBoxCartones.UseVisualStyleBackColor = True
        '
        'NumericUpDownUnidades
        '
        Me.NumericUpDownUnidades.Location = New System.Drawing.Point(16, 77)
        Me.NumericUpDownUnidades.Name = "NumericUpDownUnidades"
        Me.NumericUpDownUnidades.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownUnidades.TabIndex = 0
        '
        'GBoxPedidos
        '
        Me.GBoxPedidos.Controls.Add(Me.btnBorrarPedido)
        Me.GBoxPedidos.Controls.Add(Me.btnRealizarPedido)
        Me.GBoxPedidos.Controls.Add(Me.LBoxPedidos)
        Me.GBoxPedidos.Location = New System.Drawing.Point(30, 266)
        Me.GBoxPedidos.Name = "GBoxPedidos"
        Me.GBoxPedidos.Size = New System.Drawing.Size(328, 151)
        Me.GBoxPedidos.TabIndex = 3
        Me.GBoxPedidos.TabStop = False
        Me.GBoxPedidos.Text = "PEDIDOS"
        '
        'btnBorrarPedido
        '
        Me.btnBorrarPedido.Location = New System.Drawing.Point(159, 93)
        Me.btnBorrarPedido.Name = "btnBorrarPedido"
        Me.btnBorrarPedido.Size = New System.Drawing.Size(138, 23)
        Me.btnBorrarPedido.TabIndex = 2
        Me.btnBorrarPedido.Text = "BORRAR PEDIDO"
        Me.btnBorrarPedido.UseVisualStyleBackColor = True
        '
        'btnRealizarPedido
        '
        Me.btnRealizarPedido.Location = New System.Drawing.Point(159, 49)
        Me.btnRealizarPedido.Name = "btnRealizarPedido"
        Me.btnRealizarPedido.Size = New System.Drawing.Size(138, 23)
        Me.btnRealizarPedido.TabIndex = 1
        Me.btnRealizarPedido.Text = "REALIZAR PEDIDO"
        Me.btnRealizarPedido.UseVisualStyleBackColor = True
        '
        'LBoxPedidos
        '
        Me.LBoxPedidos.FormattingEnabled = True
        Me.LBoxPedidos.Location = New System.Drawing.Point(6, 34)
        Me.LBoxPedidos.Name = "LBoxPedidos"
        Me.LBoxPedidos.Size = New System.Drawing.Size(120, 95)
        Me.LBoxPedidos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(576, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GBoxCaracteristicas)
        Me.Controls.Add(Me.GBoxCompra)
        Me.Controls.Add(Me.GBoxPedidos)
        Me.Controls.Add(Me.GBoxProducto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBoxProducto.ResumeLayout(False)
        Me.GBoxProducto.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxCaracteristicas.ResumeLayout(False)
        Me.GBoxCaracteristicas.PerformLayout()
        Me.GBoxCompra.ResumeLayout(False)
        Me.GBoxCompra.PerformLayout()
        CType(Me.NumericUpDownUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxPedidos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBoxProducto As GroupBox
    Friend WithEvents GBoxCaracteristicas As GroupBox
    Friend WithEvents GBoxCompra As GroupBox
    Friend WithEvents GBoxPedidos As GroupBox
    Friend WithEvents lblMarcas As Label
    Friend WithEvents lblTabaqueras As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBoxMarcas As ListBox
    Friend WithEvents CBoxTabaqueras As ComboBox
    Friend WithEvents lblPromocion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNicotina As Label
    Friend WithEvents lblNumCigarrillos As Label
    Friend WithEvents lblUnidades As Label
    Friend WithEvents CheckBoxCartones As CheckBox
    Friend WithEvents NumericUpDownUnidades As NumericUpDown
    Friend WithEvents LBoxPedidos As ListBox
    Friend WithEvents txtPromocion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNicotina As TextBox
    Friend WithEvents txtNumCigarrillos As TextBox
    Friend WithEvents btnBorrarPedido As Button
    Friend WithEvents btnRealizarPedido As Button
    Friend WithEvents Button1 As Button
End Class
