<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblTitutloBanco = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnVover = New System.Windows.Forms.Button()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblIntroCuenta = New System.Windows.Forms.Label()
        Me.lblIntroNombre = New System.Windows.Forms.Label()
        Me.lblIntroDireccion = New System.Windows.Forms.Label()
        Me.lblIntroTelefono = New System.Windows.Forms.Label()
        Me.lblIntroSaldo = New System.Windows.Forms.Label()
        Me.txtIntroCuenta = New System.Windows.Forms.TextBox()
        Me.txtIntroNombre = New System.Windows.Forms.TextBox()
        Me.txtIntroDireccion = New System.Windows.Forms.TextBox()
        Me.txtIntroTelefono = New System.Windows.Forms.TextBox()
        Me.txtIntroSaldo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnPresioneAlta = New System.Windows.Forms.Button()
        Me.btnPresioneActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitutloBanco
        '
        Me.lblTitutloBanco.AutoSize = True
        Me.lblTitutloBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloBanco.Location = New System.Drawing.Point(285, 31)
        Me.lblTitutloBanco.Name = "lblTitutloBanco"
        Me.lblTitutloBanco.Size = New System.Drawing.Size(175, 17)
        Me.lblTitutloBanco.TabIndex = 1
        Me.lblTitutloBanco.Text = "Banco IES Vista Alegre"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(218, 105)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnVover
        '
        Me.btnVover.Location = New System.Drawing.Point(507, 105)
        Me.btnVover.Name = "btnVover"
        Me.btnVover.Size = New System.Drawing.Size(75, 23)
        Me.btnVover.TabIndex = 3
        Me.btnVover.Text = "Volver"
        Me.btnVover.UseVisualStyleBackColor = True
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.Location = New System.Drawing.Point(334, 64)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(64, 17)
        Me.lblGestion.TabIndex = 4
        Me.lblGestion.Text = "Gestión"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(360, 105)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblIntroCuenta
        '
        Me.lblIntroCuenta.AutoSize = True
        Me.lblIntroCuenta.Location = New System.Drawing.Point(245, 163)
        Me.lblIntroCuenta.Name = "lblIntroCuenta"
        Me.lblIntroCuenta.Size = New System.Drawing.Size(90, 13)
        Me.lblIntroCuenta.TabIndex = 6
        Me.lblIntroCuenta.Text = "Introducir cuenta:"
        Me.lblIntroCuenta.Visible = False
        '
        'lblIntroNombre
        '
        Me.lblIntroNombre.AutoSize = True
        Me.lblIntroNombre.Location = New System.Drawing.Point(245, 205)
        Me.lblIntroNombre.Name = "lblIntroNombre"
        Me.lblIntroNombre.Size = New System.Drawing.Size(95, 13)
        Me.lblIntroNombre.TabIndex = 7
        Me.lblIntroNombre.Text = "Introducir nombre: "
        Me.lblIntroNombre.Visible = False
        '
        'lblIntroDireccion
        '
        Me.lblIntroDireccion.AutoSize = True
        Me.lblIntroDireccion.Location = New System.Drawing.Point(245, 250)
        Me.lblIntroDireccion.Name = "lblIntroDireccion"
        Me.lblIntroDireccion.Size = New System.Drawing.Size(100, 13)
        Me.lblIntroDireccion.TabIndex = 8
        Me.lblIntroDireccion.Text = "Introducir dirección:"
        Me.lblIntroDireccion.Visible = False
        '
        'lblIntroTelefono
        '
        Me.lblIntroTelefono.AutoSize = True
        Me.lblIntroTelefono.Location = New System.Drawing.Point(245, 296)
        Me.lblIntroTelefono.Name = "lblIntroTelefono"
        Me.lblIntroTelefono.Size = New System.Drawing.Size(101, 17)
        Me.lblIntroTelefono.TabIndex = 9
        Me.lblIntroTelefono.Text = "Introducir teléfono: "
        Me.lblIntroTelefono.UseCompatibleTextRendering = True
        Me.lblIntroTelefono.Visible = False
        '
        'lblIntroSaldo
        '
        Me.lblIntroSaldo.AutoSize = True
        Me.lblIntroSaldo.Location = New System.Drawing.Point(245, 334)
        Me.lblIntroSaldo.Name = "lblIntroSaldo"
        Me.lblIntroSaldo.Size = New System.Drawing.Size(85, 13)
        Me.lblIntroSaldo.TabIndex = 10
        Me.lblIntroSaldo.Text = "Introducir saldo: "
        Me.lblIntroSaldo.Visible = False
        '
        'txtIntroCuenta
        '
        Me.txtIntroCuenta.Location = New System.Drawing.Point(399, 163)
        Me.txtIntroCuenta.Name = "txtIntroCuenta"
        Me.txtIntroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroCuenta.TabIndex = 11
        Me.txtIntroCuenta.Visible = False
        '
        'txtIntroNombre
        '
        Me.txtIntroNombre.Location = New System.Drawing.Point(399, 205)
        Me.txtIntroNombre.Name = "txtIntroNombre"
        Me.txtIntroNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroNombre.TabIndex = 12
        Me.txtIntroNombre.Visible = False
        '
        'txtIntroDireccion
        '
        Me.txtIntroDireccion.Location = New System.Drawing.Point(399, 250)
        Me.txtIntroDireccion.Name = "txtIntroDireccion"
        Me.txtIntroDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroDireccion.TabIndex = 13
        Me.txtIntroDireccion.Visible = False
        '
        'txtIntroTelefono
        '
        Me.txtIntroTelefono.Location = New System.Drawing.Point(399, 289)
        Me.txtIntroTelefono.Name = "txtIntroTelefono"
        Me.txtIntroTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroTelefono.TabIndex = 14
        Me.txtIntroTelefono.Visible = False
        '
        'txtIntroSaldo
        '
        Me.txtIntroSaldo.Location = New System.Drawing.Point(399, 327)
        Me.txtIntroSaldo.Name = "txtIntroSaldo"
        Me.txtIntroSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroSaldo.TabIndex = 15
        Me.txtIntroSaldo.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(218, 385)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.Visible = False
        '
        'btnPresioneAlta
        '
        Me.btnPresioneAlta.Location = New System.Drawing.Point(423, 385)
        Me.btnPresioneAlta.Name = "btnPresioneAlta"
        Me.btnPresioneAlta.Size = New System.Drawing.Size(147, 23)
        Me.btnPresioneAlta.TabIndex = 17
        Me.btnPresioneAlta.Text = "Presione para dar de Alta"
        Me.btnPresioneAlta.UseVisualStyleBackColor = True
        Me.btnPresioneAlta.Visible = False
        '
        'btnPresioneActualizar
        '
        Me.btnPresioneActualizar.Location = New System.Drawing.Point(423, 385)
        Me.btnPresioneActualizar.Name = "btnPresioneActualizar"
        Me.btnPresioneActualizar.Size = New System.Drawing.Size(147, 23)
        Me.btnPresioneActualizar.TabIndex = 18
        Me.btnPresioneActualizar.Text = "Presione para Actualizar"
        Me.btnPresioneActualizar.UseVisualStyleBackColor = True
        Me.btnPresioneActualizar.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPresioneActualizar)
        Me.Controls.Add(Me.btnPresioneAlta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtIntroSaldo)
        Me.Controls.Add(Me.txtIntroTelefono)
        Me.Controls.Add(Me.txtIntroDireccion)
        Me.Controls.Add(Me.txtIntroNombre)
        Me.Controls.Add(Me.txtIntroCuenta)
        Me.Controls.Add(Me.lblIntroSaldo)
        Me.Controls.Add(Me.lblIntroTelefono)
        Me.Controls.Add(Me.lblIntroDireccion)
        Me.Controls.Add(Me.lblIntroNombre)
        Me.Controls.Add(Me.lblIntroCuenta)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblGestion)
        Me.Controls.Add(Me.btnVover)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblTitutloBanco)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitutloBanco As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnVover As Button
    Friend WithEvents lblGestion As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblIntroCuenta As Label
    Friend WithEvents lblIntroNombre As Label
    Friend WithEvents lblIntroDireccion As Label
    Friend WithEvents lblIntroTelefono As Label
    Friend WithEvents lblIntroSaldo As Label
    Friend WithEvents txtIntroCuenta As TextBox
    Friend WithEvents txtIntroNombre As TextBox
    Friend WithEvents txtIntroDireccion As TextBox
    Friend WithEvents txtIntroTelefono As TextBox
    Friend WithEvents txtIntroSaldo As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnPresioneAlta As Button
    Friend WithEvents btnPresioneActualizar As Button
End Class
