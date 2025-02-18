<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnTabaquera = New System.Windows.Forms.Button()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTabaquera
        '
        Me.btnTabaquera.Location = New System.Drawing.Point(308, 130)
        Me.btnTabaquera.Name = "btnTabaquera"
        Me.btnTabaquera.Size = New System.Drawing.Size(75, 34)
        Me.btnTabaquera.TabIndex = 0
        Me.btnTabaquera.Text = "Tabaquera"
        Me.btnTabaquera.UseVisualStyleBackColor = True
        '
        'btnMarca
        '
        Me.btnMarca.Location = New System.Drawing.Point(308, 208)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(75, 38)
        Me.btnMarca.TabIndex = 1
        Me.btnMarca.Text = "Marca"
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.Location = New System.Drawing.Point(311, 52)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(72, 20)
        Me.lblGestion.TabIndex = 2
        Me.lblGestion.Text = "Gestión"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(308, 303)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblGestion)
        Me.Controls.Add(Me.btnMarca)
        Me.Controls.Add(Me.btnTabaquera)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTabaquera As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents lblGestion As Label
    Friend WithEvents btnVolver As Button
End Class
