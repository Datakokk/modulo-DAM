<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBoxTabaqueras = New System.Windows.Forms.GroupBox()
        Me.btnAltaTabaquera = New System.Windows.Forms.Button()
        Me.txtDireccionTabaquera = New System.Windows.Forms.TextBox()
        Me.txtNombreTabaquera = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBoxMarca = New System.Windows.Forms.GroupBox()
        Me.btnAltaMarca = New System.Windows.Forms.Button()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNicotina = New System.Windows.Forms.TextBox()
        Me.txtNCigarrillos = New System.Windows.Forms.TextBox()
        Me.txtNombreTb = New System.Windows.Forms.TextBox()
        Me.txtNombreMarca = New System.Windows.Forms.TextBox()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Nicotina = New System.Windows.Forms.Label()
        Me.lblNCigarrillos = New System.Windows.Forms.Label()
        Me.lblNombreTb = New System.Windows.Forms.Label()
        Me.lblNombreMarca = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBoxTabaqueras.SuspendLayout()
        Me.GroupBoxMarca.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTabaqueras
        '
        Me.GroupBoxTabaqueras.Controls.Add(Me.btnAltaTabaquera)
        Me.GroupBoxTabaqueras.Controls.Add(Me.txtDireccionTabaquera)
        Me.GroupBoxTabaqueras.Controls.Add(Me.txtNombreTabaquera)
        Me.GroupBoxTabaqueras.Controls.Add(Me.lblDireccion)
        Me.GroupBoxTabaqueras.Controls.Add(Me.lblNombre)
        Me.GroupBoxTabaqueras.Location = New System.Drawing.Point(59, 50)
        Me.GroupBoxTabaqueras.Name = "GroupBoxTabaqueras"
        Me.GroupBoxTabaqueras.Size = New System.Drawing.Size(237, 316)
        Me.GroupBoxTabaqueras.TabIndex = 0
        Me.GroupBoxTabaqueras.TabStop = False
        Me.GroupBoxTabaqueras.Text = "Tabaqueras"
        '
        'btnAltaTabaquera
        '
        Me.btnAltaTabaquera.Location = New System.Drawing.Point(59, 274)
        Me.btnAltaTabaquera.Name = "btnAltaTabaquera"
        Me.btnAltaTabaquera.Size = New System.Drawing.Size(95, 23)
        Me.btnAltaTabaquera.TabIndex = 4
        Me.btnAltaTabaquera.Text = "Alta Tabaquera"
        Me.btnAltaTabaquera.UseVisualStyleBackColor = True
        '
        'txtDireccionTabaquera
        '
        Me.txtDireccionTabaquera.Location = New System.Drawing.Point(113, 130)
        Me.txtDireccionTabaquera.Name = "txtDireccionTabaquera"
        Me.txtDireccionTabaquera.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccionTabaquera.TabIndex = 3
        '
        'txtNombreTabaquera
        '
        Me.txtNombreTabaquera.Location = New System.Drawing.Point(113, 62)
        Me.txtNombreTabaquera.Name = "txtNombreTabaquera"
        Me.txtNombreTabaquera.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreTabaquera.TabIndex = 2
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(15, 133)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 1
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(15, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre: "
        '
        'GroupBoxMarca
        '
        Me.GroupBoxMarca.Controls.Add(Me.btnAltaMarca)
        Me.GroupBoxMarca.Controls.Add(Me.txtFoto)
        Me.GroupBoxMarca.Controls.Add(Me.txtPrecio)
        Me.GroupBoxMarca.Controls.Add(Me.txtNicotina)
        Me.GroupBoxMarca.Controls.Add(Me.txtNCigarrillos)
        Me.GroupBoxMarca.Controls.Add(Me.txtNombreTb)
        Me.GroupBoxMarca.Controls.Add(Me.txtNombreMarca)
        Me.GroupBoxMarca.Controls.Add(Me.lblFoto)
        Me.GroupBoxMarca.Controls.Add(Me.lblPrecio)
        Me.GroupBoxMarca.Controls.Add(Me.Nicotina)
        Me.GroupBoxMarca.Controls.Add(Me.lblNCigarrillos)
        Me.GroupBoxMarca.Controls.Add(Me.lblNombreTb)
        Me.GroupBoxMarca.Controls.Add(Me.lblNombreMarca)
        Me.GroupBoxMarca.Location = New System.Drawing.Point(388, 50)
        Me.GroupBoxMarca.Name = "GroupBoxMarca"
        Me.GroupBoxMarca.Size = New System.Drawing.Size(335, 316)
        Me.GroupBoxMarca.TabIndex = 1
        Me.GroupBoxMarca.TabStop = False
        Me.GroupBoxMarca.Text = "Marca"
        '
        'btnAltaMarca
        '
        Me.btnAltaMarca.Location = New System.Drawing.Point(130, 274)
        Me.btnAltaMarca.Name = "btnAltaMarca"
        Me.btnAltaMarca.Size = New System.Drawing.Size(95, 23)
        Me.btnAltaMarca.TabIndex = 5
        Me.btnAltaMarca.Text = "Alta Marca"
        Me.btnAltaMarca.UseVisualStyleBackColor = True
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(194, 239)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(100, 20)
        Me.txtFoto.TabIndex = 11
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(194, 197)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 10
        '
        'txtNicotina
        '
        Me.txtNicotina.Location = New System.Drawing.Point(194, 154)
        Me.txtNicotina.Name = "txtNicotina"
        Me.txtNicotina.Size = New System.Drawing.Size(100, 20)
        Me.txtNicotina.TabIndex = 9
        '
        'txtNCigarrillos
        '
        Me.txtNCigarrillos.Location = New System.Drawing.Point(194, 115)
        Me.txtNCigarrillos.Name = "txtNCigarrillos"
        Me.txtNCigarrillos.Size = New System.Drawing.Size(100, 20)
        Me.txtNCigarrillos.TabIndex = 8
        '
        'txtNombreTb
        '
        Me.txtNombreTb.Location = New System.Drawing.Point(194, 80)
        Me.txtNombreTb.Name = "txtNombreTb"
        Me.txtNombreTb.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreTb.TabIndex = 7
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.Location = New System.Drawing.Point(194, 43)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreMarca.TabIndex = 6
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(23, 239)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(28, 13)
        Me.lblFoto.TabIndex = 5
        Me.lblFoto.Text = "Foto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(23, 197)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "Precio"
        '
        'Nicotina
        '
        Me.Nicotina.AutoSize = True
        Me.Nicotina.Location = New System.Drawing.Point(23, 154)
        Me.Nicotina.Name = "Nicotina"
        Me.Nicotina.Size = New System.Drawing.Size(56, 13)
        Me.Nicotina.TabIndex = 3
        Me.Nicotina.Text = "lblNicotina"
        '
        'lblNCigarrillos
        '
        Me.lblNCigarrillos.AutoSize = True
        Me.lblNCigarrillos.Location = New System.Drawing.Point(23, 115)
        Me.lblNCigarrillos.Name = "lblNCigarrillos"
        Me.lblNCigarrillos.Size = New System.Drawing.Size(66, 13)
        Me.lblNCigarrillos.TabIndex = 2
        Me.lblNCigarrillos.Text = "Nº Cigarrillos"
        '
        'lblNombreTb
        '
        Me.lblNombreTb.AutoSize = True
        Me.lblNombreTb.Location = New System.Drawing.Point(23, 80)
        Me.lblNombreTb.Name = "lblNombreTb"
        Me.lblNombreTb.Size = New System.Drawing.Size(60, 13)
        Me.lblNombreTb.TabIndex = 1
        Me.lblNombreTb.Text = "Nombre Tb"
        '
        'lblNombreMarca
        '
        Me.lblNombreMarca.AutoSize = True
        Me.lblNombreMarca.Location = New System.Drawing.Point(23, 43)
        Me.lblNombreMarca.Name = "lblNombreMarca"
        Me.lblNombreMarca.Size = New System.Drawing.Size(77, 13)
        Me.lblNombreMarca.TabIndex = 0
        Me.lblNombreMarca.Text = "Nombre Marca"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(302, 398)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBoxMarca)
        Me.Controls.Add(Me.GroupBoxTabaqueras)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBoxTabaqueras.ResumeLayout(False)
        Me.GroupBoxTabaqueras.PerformLayout()
        Me.GroupBoxMarca.ResumeLayout(False)
        Me.GroupBoxMarca.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxTabaqueras As GroupBox
    Friend WithEvents GroupBoxMarca As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAltaTabaquera As Button
    Friend WithEvents txtDireccionTabaquera As TextBox
    Friend WithEvents txtNombreTabaquera As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNicotina As TextBox
    Friend WithEvents txtNCigarrillos As TextBox
    Friend WithEvents txtNombreTb As TextBox
    Friend WithEvents txtNombreMarca As TextBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Nicotina As Label
    Friend WithEvents lblNCigarrillos As Label
    Friend WithEvents lblNombreTb As Label
    Friend WithEvents lblNombreMarca As Label
    Friend WithEvents btnAltaMarca As Button
End Class
