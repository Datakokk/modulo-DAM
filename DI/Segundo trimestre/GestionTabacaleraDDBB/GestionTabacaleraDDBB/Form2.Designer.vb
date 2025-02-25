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
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGestion
        '
        Me.btnGestion.Location = New System.Drawing.Point(340, 159)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(75, 23)
        Me.btnGestion.TabIndex = 0
        Me.btnGestion.Text = "Gestión"
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(340, 241)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestión de tabacalera"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnGestion)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGestion As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents Label1 As Label
End Class
