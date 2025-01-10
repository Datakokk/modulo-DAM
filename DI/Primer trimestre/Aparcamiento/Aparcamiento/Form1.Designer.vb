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
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblPlaza = New System.Windows.Forms.Label()
        Me.lblNumPlaLibres = New System.Windows.Forms.Label()
        Me.lblNumPlaOcupa = New System.Windows.Forms.Label()
        Me.lblPlazasLibres = New System.Windows.Forms.Label()
        Me.lblPLCalle = New System.Windows.Forms.Label()
        Me.lblPLPlazas = New System.Windows.Forms.Label()
        Me.lblPlaOcupa = New System.Windows.Forms.Label()
        Me.lblPOCalle = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblPOPlaza = New System.Windows.Forms.Label()
        Me.txtPlaza = New System.Windows.Forms.TextBox()
        Me.txtNumPlaLib = New System.Windows.Forms.TextBox()
        Me.txtNumPlaOcu = New System.Windows.Forms.TextBox()
        Me.txtPlazasLibres = New System.Windows.Forms.TextBox()
        Me.txtPlazasOcupadas = New System.Windows.Forms.TextBox()
        Me.btnAparcar = New System.Windows.Forms.Button()
        Me.btnSacarCoche = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVisualizaPlazasLibres = New System.Windows.Forms.Button()
        Me.btnVisualizaPlazasOcupadas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(30, 21)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle"
        '
        'lblPlaza
        '
        Me.lblPlaza.AutoSize = True
        Me.lblPlaza.Location = New System.Drawing.Point(150, 21)
        Me.lblPlaza.Name = "lblPlaza"
        Me.lblPlaza.Size = New System.Drawing.Size(33, 13)
        Me.lblPlaza.TabIndex = 1
        Me.lblPlaza.Text = "Plaza"
        '
        'lblNumPlaLibres
        '
        Me.lblNumPlaLibres.AutoSize = True
        Me.lblNumPlaLibres.Location = New System.Drawing.Point(400, 21)
        Me.lblNumPlaLibres.Name = "lblNumPlaLibres"
        Me.lblNumPlaLibres.Size = New System.Drawing.Size(104, 13)
        Me.lblNumPlaLibres.TabIndex = 2
        Me.lblNumPlaLibres.Text = "Número plazas libres"
        '
        'lblNumPlaOcupa
        '
        Me.lblNumPlaOcupa.AutoSize = True
        Me.lblNumPlaOcupa.Location = New System.Drawing.Point(400, 57)
        Me.lblNumPlaOcupa.Name = "lblNumPlaOcupa"
        Me.lblNumPlaOcupa.Size = New System.Drawing.Size(127, 13)
        Me.lblNumPlaOcupa.TabIndex = 3
        Me.lblNumPlaOcupa.Text = "Número plazas ocupadas"
        '
        'lblPlazasLibres
        '
        Me.lblPlazasLibres.AutoSize = True
        Me.lblPlazasLibres.Location = New System.Drawing.Point(94, 179)
        Me.lblPlazasLibres.Name = "lblPlazasLibres"
        Me.lblPlazasLibres.Size = New System.Drawing.Size(89, 13)
        Me.lblPlazasLibres.TabIndex = 4
        Me.lblPlazasLibres.Text = "PLAZAS LIBRES"
        '
        'lblPLCalle
        '
        Me.lblPLCalle.AutoSize = True
        Me.lblPLCalle.Location = New System.Drawing.Point(68, 202)
        Me.lblPLCalle.Name = "lblPLCalle"
        Me.lblPLCalle.Size = New System.Drawing.Size(40, 13)
        Me.lblPLCalle.TabIndex = 5
        Me.lblPLCalle.Text = "CALLE"
        '
        'lblPLPlazas
        '
        Me.lblPLPlazas.AutoSize = True
        Me.lblPLPlazas.Location = New System.Drawing.Point(150, 202)
        Me.lblPLPlazas.Name = "lblPLPlazas"
        Me.lblPLPlazas.Size = New System.Drawing.Size(48, 13)
        Me.lblPLPlazas.TabIndex = 6
        Me.lblPLPlazas.Text = "PLAZAS"
        '
        'lblPlaOcupa
        '
        Me.lblPlaOcupa.AutoSize = True
        Me.lblPlaOcupa.Location = New System.Drawing.Point(304, 179)
        Me.lblPlaOcupa.Name = "lblPlaOcupa"
        Me.lblPlaOcupa.Size = New System.Drawing.Size(110, 13)
        Me.lblPlaOcupa.TabIndex = 7
        Me.lblPlaOcupa.Text = "PLAZAS OCUPADAS"
        '
        'lblPOCalle
        '
        Me.lblPOCalle.AutoSize = True
        Me.lblPOCalle.Location = New System.Drawing.Point(284, 202)
        Me.lblPOCalle.Name = "lblPOCalle"
        Me.lblPOCalle.Size = New System.Drawing.Size(40, 13)
        Me.lblPOCalle.TabIndex = 8
        Me.lblPOCalle.Text = "CALLE"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(33, 54)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(34, 20)
        Me.txtCalle.TabIndex = 10
        '
        'lblPOPlaza
        '
        Me.lblPOPlaza.AutoSize = True
        Me.lblPOPlaza.Location = New System.Drawing.Point(364, 202)
        Me.lblPOPlaza.Name = "lblPOPlaza"
        Me.lblPOPlaza.Size = New System.Drawing.Size(41, 13)
        Me.lblPOPlaza.TabIndex = 11
        Me.lblPOPlaza.Text = "PLAZA"
        '
        'txtPlaza
        '
        Me.txtPlaza.Location = New System.Drawing.Point(153, 54)
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.Size = New System.Drawing.Size(30, 20)
        Me.txtPlaza.TabIndex = 12
        '
        'txtNumPlaLib
        '
        Me.txtNumPlaLib.Location = New System.Drawing.Point(578, 21)
        Me.txtNumPlaLib.Name = "txtNumPlaLib"
        Me.txtNumPlaLib.Size = New System.Drawing.Size(79, 20)
        Me.txtNumPlaLib.TabIndex = 13
        '
        'txtNumPlaOcu
        '
        Me.txtNumPlaOcu.Location = New System.Drawing.Point(578, 57)
        Me.txtNumPlaOcu.Name = "txtNumPlaOcu"
        Me.txtNumPlaOcu.Size = New System.Drawing.Size(79, 20)
        Me.txtNumPlaOcu.TabIndex = 14
        '
        'txtPlazasLibres
        '
        Me.txtPlazasLibres.Location = New System.Drawing.Point(74, 218)
        Me.txtPlazasLibres.Multiline = True
        Me.txtPlazasLibres.Name = "txtPlazasLibres"
        Me.txtPlazasLibres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlazasLibres.Size = New System.Drawing.Size(148, 170)
        Me.txtPlazasLibres.TabIndex = 15
        '
        'txtPlazasOcupadas
        '
        Me.txtPlazasOcupadas.Location = New System.Drawing.Point(278, 218)
        Me.txtPlazasOcupadas.Multiline = True
        Me.txtPlazasOcupadas.Name = "txtPlazasOcupadas"
        Me.txtPlazasOcupadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlazasOcupadas.Size = New System.Drawing.Size(148, 170)
        Me.txtPlazasOcupadas.TabIndex = 16
        '
        'btnAparcar
        '
        Me.btnAparcar.Location = New System.Drawing.Point(71, 131)
        Me.btnAparcar.Name = "btnAparcar"
        Me.btnAparcar.Size = New System.Drawing.Size(75, 23)
        Me.btnAparcar.TabIndex = 17
        Me.btnAparcar.Text = "Aparcar"
        Me.btnAparcar.UseVisualStyleBackColor = True
        '
        'btnSacarCoche
        '
        Me.btnSacarCoche.Location = New System.Drawing.Point(256, 131)
        Me.btnSacarCoche.Name = "btnSacarCoche"
        Me.btnSacarCoche.Size = New System.Drawing.Size(125, 23)
        Me.btnSacarCoche.TabIndex = 18
        Me.btnSacarCoche.Text = "Sacar coche"
        Me.btnSacarCoche.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(482, 131)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVisualizaPlazasLibres
        '
        Me.btnVisualizaPlazasLibres.Location = New System.Drawing.Point(74, 402)
        Me.btnVisualizaPlazasLibres.Name = "btnVisualizaPlazasLibres"
        Me.btnVisualizaPlazasLibres.Size = New System.Drawing.Size(148, 23)
        Me.btnVisualizaPlazasLibres.TabIndex = 20
        Me.btnVisualizaPlazasLibres.Text = "Visualiza plazas libres"
        Me.btnVisualizaPlazasLibres.UseVisualStyleBackColor = True
        '
        'btnVisualizaPlazasOcupadas
        '
        Me.btnVisualizaPlazasOcupadas.Location = New System.Drawing.Point(278, 402)
        Me.btnVisualizaPlazasOcupadas.Name = "btnVisualizaPlazasOcupadas"
        Me.btnVisualizaPlazasOcupadas.Size = New System.Drawing.Size(148, 23)
        Me.btnVisualizaPlazasOcupadas.TabIndex = 21
        Me.btnVisualizaPlazasOcupadas.Text = "Visualiza plazas ocupadas"
        Me.btnVisualizaPlazasOcupadas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVisualizaPlazasOcupadas)
        Me.Controls.Add(Me.btnVisualizaPlazasLibres)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSacarCoche)
        Me.Controls.Add(Me.btnAparcar)
        Me.Controls.Add(Me.txtPlazasOcupadas)
        Me.Controls.Add(Me.txtPlazasLibres)
        Me.Controls.Add(Me.txtNumPlaOcu)
        Me.Controls.Add(Me.txtNumPlaLib)
        Me.Controls.Add(Me.txtPlaza)
        Me.Controls.Add(Me.lblPOPlaza)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblPOCalle)
        Me.Controls.Add(Me.lblPlaOcupa)
        Me.Controls.Add(Me.lblPLPlazas)
        Me.Controls.Add(Me.lblPLCalle)
        Me.Controls.Add(Me.lblPlazasLibres)
        Me.Controls.Add(Me.lblNumPlaOcupa)
        Me.Controls.Add(Me.lblNumPlaLibres)
        Me.Controls.Add(Me.lblPlaza)
        Me.Controls.Add(Me.lblCalle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalle As Label
    Friend WithEvents lblPlaza As Label
    Friend WithEvents lblNumPlaLibres As Label
    Friend WithEvents lblNumPlaOcupa As Label
    Friend WithEvents lblPlazasLibres As Label
    Friend WithEvents lblPLCalle As Label
    Friend WithEvents lblPLPlazas As Label
    Friend WithEvents lblPlaOcupa As Label
    Friend WithEvents lblPOCalle As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblPOPlaza As Label
    Friend WithEvents txtPlaza As TextBox
    Friend WithEvents txtNumPlaLib As TextBox
    Friend WithEvents txtNumPlaOcu As TextBox
    Friend WithEvents txtPlazasLibres As TextBox
    Friend WithEvents txtPlazasOcupadas As TextBox
    Friend WithEvents btnAparcar As Button
    Friend WithEvents btnSacarCoche As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVisualizaPlazasLibres As Button
    Friend WithEvents btnVisualizaPlazasOcupadas As Button
End Class
