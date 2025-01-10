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
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.lblCambiaTemp = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(83, 72)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(27, 13)
        Me.lblMinTemp.TabIndex = 0
        Me.lblMinTemp.Text = "0 ºC"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(432, 72)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(33, 13)
        Me.lblMaxTemp.TabIndex = 1
        Me.lblMaxTemp.Text = "50 ºC"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(86, 118)
        Me.HScrollBar1.Maximum = 50
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(385, 17)
        Me.HScrollBar1.TabIndex = 2
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(86, 243)
        Me.HScrollBar2.Maximum = 50
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(385, 17)
        Me.HScrollBar2.TabIndex = 3
        '
        'lblCambiaTemp
        '
        Me.lblCambiaTemp.AutoSize = True
        Me.lblCambiaTemp.Location = New System.Drawing.Point(260, 173)
        Me.lblCambiaTemp.Name = "lblCambiaTemp"
        Me.lblCambiaTemp.Size = New System.Drawing.Size(27, 13)
        Me.lblCambiaTemp.TabIndex = 4
        Me.lblCambiaTemp.Text = "0 ºC"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(260, 312)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(46, 13)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Muy frío"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Termometro.My.Resources.Resources.muyFrio
        Me.PictureBox1.Location = New System.Drawing.Point(620, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCambiaTemp)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.lblMaxTemp)
        Me.Controls.Add(Me.lblMinTemp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents lblCambiaTemp As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
