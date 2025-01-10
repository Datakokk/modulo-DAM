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
        Me.txtElemento = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtVisualizar = New System.Windows.Forms.TextBox()
        Me.lblElemento = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnDisminuir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtElemento
        '
        Me.txtElemento.Enabled = False
        Me.txtElemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElemento.Location = New System.Drawing.Point(194, 51)
        Me.txtElemento.Name = "txtElemento"
        Me.txtElemento.Size = New System.Drawing.Size(100, 20)
        Me.txtElemento.TabIndex = 0
        Me.txtElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(204, 183)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(185, 20)
        Me.txtValor.TabIndex = 1
        '
        'txtVisualizar
        '
        Me.txtVisualizar.Location = New System.Drawing.Point(516, 28)
        Me.txtVisualizar.Multiline = True
        Me.txtVisualizar.Name = "txtVisualizar"
        Me.txtVisualizar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVisualizar.Size = New System.Drawing.Size(210, 236)
        Me.txtVisualizar.TabIndex = 2
        '
        'lblElemento
        '
        Me.lblElemento.AutoSize = True
        Me.lblElemento.Location = New System.Drawing.Point(57, 51)
        Me.lblElemento.Name = "lblElemento"
        Me.lblElemento.Size = New System.Drawing.Size(69, 13)
        Me.lblElemento.TabIndex = 3
        Me.lblElemento.Text = "Elemento......"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(57, 186)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(49, 13)
        Me.lblValor.TabIndex = 4
        Me.lblValor.Text = "Valor......"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(89, 328)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(314, 328)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(536, 328)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 9
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(337, 28)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(52, 47)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnDisminuir
        '
        Me.btnDisminuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisminuir.Location = New System.Drawing.Point(411, 28)
        Me.btnDisminuir.Name = "btnDisminuir"
        Me.btnDisminuir.Size = New System.Drawing.Size(52, 47)
        Me.btnDisminuir.TabIndex = 11
        Me.btnDisminuir.Text = "-"
        Me.btnDisminuir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisminuir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblElemento)
        Me.Controls.Add(Me.txtVisualizar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtElemento)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtElemento As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtVisualizar As TextBox
    Friend WithEvents lblElemento As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnDisminuir As Button
End Class
