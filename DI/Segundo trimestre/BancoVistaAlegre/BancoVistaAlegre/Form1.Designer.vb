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
        Me.lblTitutloBanco1 = New System.Windows.Forms.Label()
        Me.btnOperacion = New System.Windows.Forms.Button()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitutloBanco1
        '
        Me.lblTitutloBanco1.AutoSize = True
        Me.lblTitutloBanco1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloBanco1.Location = New System.Drawing.Point(315, 68)
        Me.lblTitutloBanco1.Name = "lblTitutloBanco1"
        Me.lblTitutloBanco1.Size = New System.Drawing.Size(206, 20)
        Me.lblTitutloBanco1.TabIndex = 0
        Me.lblTitutloBanco1.Text = "Banco IES Vista Alegre"
        '
        'btnOperacion
        '
        Me.btnOperacion.Location = New System.Drawing.Point(293, 162)
        Me.btnOperacion.Name = "btnOperacion"
        Me.btnOperacion.Size = New System.Drawing.Size(75, 23)
        Me.btnOperacion.TabIndex = 1
        Me.btnOperacion.Text = "Operación"
        Me.btnOperacion.UseVisualStyleBackColor = True
        '
        'btnGestion
        '
        Me.btnGestion.Location = New System.Drawing.Point(487, 162)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(75, 23)
        Me.btnGestion.TabIndex = 2
        Me.btnGestion.Text = "Gestión"
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(388, 208)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGestion)
        Me.Controls.Add(Me.btnOperacion)
        Me.Controls.Add(Me.lblTitutloBanco1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitutloBanco1 As Label
    Friend WithEvents btnOperacion As Button
    Friend WithEvents btnGestion As Button
    Friend WithEvents btnSalir As Button
End Class
