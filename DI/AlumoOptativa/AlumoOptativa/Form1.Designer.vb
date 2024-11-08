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
        Me.lbAlumno = New System.Windows.Forms.ListBox()
        Me.lbOptativas = New System.Windows.Forms.ListBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.cbAsigOpt = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblOptativa = New System.Windows.Forms.Label()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.lblAsignaturasOpt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbAlumno
        '
        Me.lbAlumno.FormattingEnabled = True
        Me.lbAlumno.Location = New System.Drawing.Point(92, 80)
        Me.lbAlumno.Name = "lbAlumno"
        Me.lbAlumno.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbAlumno.Size = New System.Drawing.Size(120, 173)
        Me.lbAlumno.TabIndex = 0
        '
        'lbOptativas
        '
        Me.lbOptativas.FormattingEnabled = True
        Me.lbOptativas.Location = New System.Drawing.Point(264, 80)
        Me.lbOptativas.Name = "lbOptativas"
        Me.lbOptativas.Size = New System.Drawing.Size(120, 173)
        Me.lbOptativas.TabIndex = 1
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(83, 347)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir.TabIndex = 2
        Me.btnAnadir.Text = "AÑADIR"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(281, 347)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(474, 347)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 4
        Me.btnVaciar.Text = "VACIAR"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(635, 347)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(75, 23)
        Me.btnFin.TabIndex = 5
        Me.btnFin.Text = "FIN"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(593, 80)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreAlumno.TabIndex = 6
        '
        'cbAsigOpt
        '
        Me.cbAsigOpt.FormattingEnabled = True
        Me.cbAsigOpt.Items.AddRange(New Object() {"Informática", "Frances", "Lengua", "Matemática", "Biología", "Química", "Física"})
        Me.cbAsigOpt.Location = New System.Drawing.Point(593, 154)
        Me.cbAsigOpt.Name = "cbAsigOpt"
        Me.cbAsigOpt.Size = New System.Drawing.Size(121, 21)
        Me.cbAsigOpt.TabIndex = 7
        Me.cbAsigOpt.Text = "Informática"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(92, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(53, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "ALUMNO"
        '
        'lblOptativa
        '
        Me.lblOptativa.AutoSize = True
        Me.lblOptativa.Location = New System.Drawing.Point(261, 28)
        Me.lblOptativa.Name = "lblOptativa"
        Me.lblOptativa.Size = New System.Drawing.Size(60, 13)
        Me.lblOptativa.TabIndex = 9
        Me.lblOptativa.Text = "OPTATIVA"
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.AutoSize = True
        Me.lblNombreAlumno.Location = New System.Drawing.Point(590, 28)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(81, 13)
        Me.lblNombreAlumno.TabIndex = 10
        Me.lblNombreAlumno.Text = "Nombre alumno"
        '
        'lblAsignaturasOpt
        '
        Me.lblAsignaturasOpt.AutoSize = True
        Me.lblAsignaturasOpt.Location = New System.Drawing.Point(590, 117)
        Me.lblAsignaturasOpt.Name = "lblAsignaturasOpt"
        Me.lblAsignaturasOpt.Size = New System.Drawing.Size(113, 13)
        Me.lblAsignaturasOpt.TabIndex = 11
        Me.lblAsignaturasOpt.Text = "Asiganturas Optativas "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAsignaturasOpt)
        Me.Controls.Add(Me.lblNombreAlumno)
        Me.Controls.Add(Me.lblOptativa)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cbAsigOpt)
        Me.Controls.Add(Me.txtNombreAlumno)
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.lbOptativas)
        Me.Controls.Add(Me.lbAlumno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAlumno As ListBox
    Friend WithEvents lbOptativas As ListBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents cbAsigOpt As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblOptativa As Label
    Friend WithEvents lblNombreAlumno As Label
    Friend WithEvents lblAsignaturasOpt As Label
End Class
