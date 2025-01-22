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
        Me.SuspendLayout()
        '
        'lblTitutloBanco
        '
        Me.lblTitutloBanco.AutoSize = True
        Me.lblTitutloBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloBanco.Location = New System.Drawing.Point(282, 57)
        Me.lblTitutloBanco.Name = "lblTitutloBanco"
        Me.lblTitutloBanco.Size = New System.Drawing.Size(175, 17)
        Me.lblTitutloBanco.TabIndex = 1
        Me.lblTitutloBanco.Text = "Banco IES Vista Alegre"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(245, 167)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnVover
        '
        Me.btnVover.Location = New System.Drawing.Point(417, 167)
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
        Me.lblGestion.Location = New System.Drawing.Point(335, 113)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(64, 17)
        Me.lblGestion.TabIndex = 4
        Me.lblGestion.Text = "Gestión"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
