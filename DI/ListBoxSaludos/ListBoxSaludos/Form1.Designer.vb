<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbSaludos = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblSaludos = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtSaludos = New System.Windows.Forms.TextBox()
        Me.pbPais = New System.Windows.Forms.PictureBox()
        CType(Me.pbPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Alemania", "España", "Italia", "Inglaterra"})
        Me.ListBox1.Location = New System.Drawing.Point(74, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 147)
        Me.ListBox1.TabIndex = 0
        '
        'lbSaludos
        '
        Me.lbSaludos.AutoSize = True
        Me.lbSaludos.Location = New System.Drawing.Point(81, 22)
        Me.lbSaludos.Name = "lbSaludos"
        Me.lbSaludos.Size = New System.Drawing.Size(59, 13)
        Me.lbSaludos.TabIndex = 1
        Me.lbSaludos.Text = "LstSaludos"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(367, 63)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(27, 13)
        Me.lblPais.TabIndex = 2
        Me.lblPais.Text = "Pais"
        '
        'lblSaludos
        '
        Me.lblSaludos.AutoSize = True
        Me.lblSaludos.Location = New System.Drawing.Point(367, 154)
        Me.lblSaludos.Name = "lblSaludos"
        Me.lblSaludos.Size = New System.Drawing.Size(45, 13)
        Me.lblSaludos.TabIndex = 3
        Me.lblSaludos.Text = "Saludos"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(370, 88)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(100, 20)
        Me.txtPais.TabIndex = 4
        Me.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaludos
        '
        Me.txtSaludos.Location = New System.Drawing.Point(370, 190)
        Me.txtSaludos.Name = "txtSaludos"
        Me.txtSaludos.Size = New System.Drawing.Size(100, 20)
        Me.txtSaludos.TabIndex = 5
        Me.txtSaludos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbPais
        '
        Me.pbPais.Location = New System.Drawing.Point(227, 107)
        Me.pbPais.Name = "pbPais"
        Me.pbPais.Size = New System.Drawing.Size(100, 50)
        Me.pbPais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPais.TabIndex = 6
        Me.pbPais.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbPais)
        Me.Controls.Add(Me.txtSaludos)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.lblSaludos)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lbSaludos)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbSaludos As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblSaludos As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtSaludos As TextBox
    Friend WithEvents pbPais As PictureBox
End Class
