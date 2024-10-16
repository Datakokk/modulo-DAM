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
        Me.lblElemento = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtElemento = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtVisualizar = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblElemento
        '
        Me.lblElemento.AutoSize = True
        Me.lblElemento.Location = New System.Drawing.Point(85, 57)
        Me.lblElemento.Name = "lblElemento"
        Me.lblElemento.Size = New System.Drawing.Size(69, 13)
        Me.lblElemento.TabIndex = 0
        Me.lblElemento.Text = "Elemento......"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(85, 153)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(49, 13)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor......"
        '
        'txtElemento
        '
        Me.txtElemento.Enabled = False
        Me.txtElemento.Location = New System.Drawing.Point(205, 54)
        Me.txtElemento.Name = "txtElemento"
        Me.txtElemento.Size = New System.Drawing.Size(100, 20)
        Me.txtElemento.TabIndex = 2
        Me.txtElemento.Text = "0"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(205, 150)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(165, 20)
        Me.txtValor.TabIndex = 3
        '
        'txtVisualizar
        '
        Me.txtVisualizar.Location = New System.Drawing.Point(545, 57)
        Me.txtVisualizar.Multiline = True
        Me.txtVisualizar.Name = "txtVisualizar"
        Me.txtVisualizar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVisualizar.Size = New System.Drawing.Size(180, 184)
        Me.txtVisualizar.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(153, 298)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(357, 298)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(575, 298)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 7
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(328, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(42, 41)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(390, 43)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(42, 41)
        Me.btnRestar.TabIndex = 9
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtVisualizar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtElemento)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblElemento)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblElemento As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents txtElemento As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtVisualizar As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRestar As Button
End Class
