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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnIzq = New System.Windows.Forms.Button()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.lblPrimeraLista = New System.Windows.Forms.Label()
        Me.lblSegundaLista = New System.Windows.Forms.Label()
        Me.lblTerceraLista = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"azul", "verde", "amarillo", "rojo"})
        Me.ListBox1.Location = New System.Drawing.Point(128, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"pera", "naranja", "melon"})
        Me.ListBox2.Location = New System.Drawing.Point(585, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"blanco", "manzana", "negro", "mandarina"})
        Me.ListBox3.Location = New System.Drawing.Point(338, 263)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 2
        '
        'btnDerecha
        '
        Me.btnDerecha.Enabled = False
        Me.btnDerecha.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnDerecha.Location = New System.Drawing.Point(363, 51)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(75, 23)
        Me.btnDerecha.TabIndex = 3
        Me.btnDerecha.Text = "->"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnIzq
        '
        Me.btnIzq.Enabled = False
        Me.btnIzq.Location = New System.Drawing.Point(363, 123)
        Me.btnIzq.Name = "btnIzq"
        Me.btnIzq.Size = New System.Drawing.Size(75, 23)
        Me.btnIzq.TabIndex = 4
        Me.btnIzq.Text = "<-"
        Me.btnIzq.UseVisualStyleBackColor = True
        '
        'btnAbajo
        '
        Me.btnAbajo.Enabled = False
        Me.btnAbajo.Location = New System.Drawing.Point(363, 192)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(75, 23)
        Me.btnAbajo.TabIndex = 5
        Me.btnAbajo.Text = "abajo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'lblPrimeraLista
        '
        Me.lblPrimeraLista.AutoSize = True
        Me.lblPrimeraLista.Location = New System.Drawing.Point(125, 32)
        Me.lblPrimeraLista.Name = "lblPrimeraLista"
        Me.lblPrimeraLista.Size = New System.Drawing.Size(63, 13)
        Me.lblPrimeraLista.TabIndex = 6
        Me.lblPrimeraLista.Text = "Primera lista"
        '
        'lblSegundaLista
        '
        Me.lblSegundaLista.AutoSize = True
        Me.lblSegundaLista.Location = New System.Drawing.Point(582, 32)
        Me.lblSegundaLista.Name = "lblSegundaLista"
        Me.lblSegundaLista.Size = New System.Drawing.Size(71, 13)
        Me.lblSegundaLista.TabIndex = 7
        Me.lblSegundaLista.Text = "Segunda lista"
        '
        'lblTerceraLista
        '
        Me.lblTerceraLista.AutoSize = True
        Me.lblTerceraLista.Location = New System.Drawing.Point(195, 302)
        Me.lblTerceraLista.Name = "lblTerceraLista"
        Me.lblTerceraLista.Size = New System.Drawing.Size(69, 13)
        Me.lblTerceraLista.TabIndex = 8
        Me.lblTerceraLista.Text = "Tercera Lista"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTerceraLista)
        Me.Controls.Add(Me.lblSegundaLista)
        Me.Controls.Add(Me.lblPrimeraLista)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.btnIzq)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnIzq As Button
    Friend WithEvents btnAbajo As Button
    Friend WithEvents lblPrimeraLista As Label
    Friend WithEvents lblSegundaLista As Label
    Friend WithEvents lblTerceraLista As Label
End Class
