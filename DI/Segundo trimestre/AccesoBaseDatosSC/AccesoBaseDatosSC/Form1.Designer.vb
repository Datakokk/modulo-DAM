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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(97, 342)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(219, 342)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'lstNombre
        '
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.Location = New System.Drawing.Point(114, 89)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(120, 186)
        Me.lstNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(467, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(467, 162)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 5
        Me.lblDireccion.Text = "Direccion"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(467, 241)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(599, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(599, 155)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(599, 234)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(340, 342)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 10
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(624, 342)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(470, 342)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(340, 393)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 13
        Me.btnFiltrar.Text = "Filtrar datos"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lstNombre)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents lstNombre As ListBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnFiltrar As Button
End Class
