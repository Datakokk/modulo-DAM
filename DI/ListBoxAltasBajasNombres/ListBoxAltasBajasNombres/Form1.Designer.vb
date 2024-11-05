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
        Me.lbNombres = New System.Windows.Forms.ListBox()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtElementoAnadir = New System.Windows.Forms.TextBox()
        Me.txtElementoSeleccionado = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblElemAnadir = New System.Windows.Forms.Label()
        Me.lblElemSeleccionado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbNombres
        '
        Me.lbNombres.FormattingEnabled = True
        Me.lbNombres.Items.AddRange(New Object() {"Ana"})
        Me.lbNombres.Location = New System.Drawing.Point(151, 42)
        Me.lbNombres.Name = "lbNombres"
        Me.lbNombres.Size = New System.Drawing.Size(120, 160)
        Me.lbNombres.TabIndex = 0
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(470, 42)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 1
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(470, 143)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnBaja.TabIndex = 2
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(470, 252)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(470, 366)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtElementoAnadir
        '
        Me.txtElementoAnadir.Location = New System.Drawing.Point(151, 230)
        Me.txtElementoAnadir.Name = "txtElementoAnadir"
        Me.txtElementoAnadir.Size = New System.Drawing.Size(116, 20)
        Me.txtElementoAnadir.TabIndex = 5
        '
        'txtElementoSeleccionado
        '
        Me.txtElementoSeleccionado.Location = New System.Drawing.Point(151, 324)
        Me.txtElementoSeleccionado.Name = "txtElementoSeleccionado"
        Me.txtElementoSeleccionado.Size = New System.Drawing.Size(116, 20)
        Me.txtElementoSeleccionado.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(148, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'lblElemAnadir
        '
        Me.lblElemAnadir.AutoSize = True
        Me.lblElemAnadir.Location = New System.Drawing.Point(148, 262)
        Me.lblElemAnadir.Name = "lblElemAnadir"
        Me.lblElemAnadir.Size = New System.Drawing.Size(84, 13)
        Me.lblElemAnadir.TabIndex = 8
        Me.lblElemAnadir.Text = "Elemento Añadir"
        '
        'lblElemSeleccionado
        '
        Me.lblElemSeleccionado.AutoSize = True
        Me.lblElemSeleccionado.Location = New System.Drawing.Point(148, 366)
        Me.lblElemSeleccionado.Name = "lblElemSeleccionado"
        Me.lblElemSeleccionado.Size = New System.Drawing.Size(119, 13)
        Me.lblElemSeleccionado.TabIndex = 9
        Me.lblElemSeleccionado.Text = "Elemento Seleccionado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblElemSeleccionado)
        Me.Controls.Add(Me.lblElemAnadir)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtElementoSeleccionado)
        Me.Controls.Add(Me.txtElementoAnadir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lbNombres)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombres As ListBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtElementoAnadir As TextBox
    Friend WithEvents txtElementoSeleccionado As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblElemAnadir As Label
    Friend WithEvents lblElemSeleccionado As Label
End Class
