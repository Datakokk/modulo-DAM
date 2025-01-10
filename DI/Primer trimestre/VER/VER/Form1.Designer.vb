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
        Me.lblHola = New System.Windows.Forms.Label()
        Me.lblAdios = New System.Windows.Forms.Label()
        Me.btbVer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHola
        '
        Me.lblHola.AutoSize = True
        Me.lblHola.Location = New System.Drawing.Point(113, 104)
        Me.lblHola.Name = "lblHola"
        Me.lblHola.Size = New System.Drawing.Size(29, 13)
        Me.lblHola.TabIndex = 0
        Me.lblHola.Text = "Hola"
        '
        'lblAdios
        '
        Me.lblAdios.AutoSize = True
        Me.lblAdios.Location = New System.Drawing.Point(113, 196)
        Me.lblAdios.Name = "lblAdios"
        Me.lblAdios.Size = New System.Drawing.Size(33, 13)
        Me.lblAdios.TabIndex = 1
        Me.lblAdios.Text = "Adios"
        '
        'btbVer
        '
        Me.btbVer.Location = New System.Drawing.Point(498, 196)
        Me.btbVer.Name = "btbVer"
        Me.btbVer.Size = New System.Drawing.Size(75, 23)
        Me.btbVer.TabIndex = 2
        Me.btbVer.Text = "Ver"
        Me.btbVer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 565)
        Me.Controls.Add(Me.btbVer)
        Me.Controls.Add(Me.lblAdios)
        Me.Controls.Add(Me.lblHola)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHola As Label
    Friend WithEvents lblAdios As Label
    Friend WithEvents btbVer As Button
End Class
