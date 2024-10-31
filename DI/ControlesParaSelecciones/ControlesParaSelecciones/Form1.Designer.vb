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
        Me.gbProcesador = New System.Windows.Forms.GroupBox()
        Me.rb_i7 = New System.Windows.Forms.RadioButton()
        Me.rb_i5 = New System.Windows.Forms.RadioButton()
        Me.rb_i3 = New System.Windows.Forms.RadioButton()
        Me.gbRAM = New System.Windows.Forms.GroupBox()
        Me.rb_16GB = New System.Windows.Forms.RadioButton()
        Me.rb_12GB = New System.Windows.Forms.RadioButton()
        Me.rb_8GB = New System.Windows.Forms.RadioButton()
        Me.gbDisco = New System.Windows.Forms.GroupBox()
        Me.rb_2TB = New System.Windows.Forms.RadioButton()
        Me.rb_1TB = New System.Windows.Forms.RadioButton()
        Me.rb_500GB = New System.Windows.Forms.RadioButton()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.cbImpresora = New System.Windows.Forms.CheckBox()
        Me.cbAudio = New System.Windows.Forms.CheckBox()
        Me.cbAltavoces = New System.Windows.Forms.CheckBox()
        Me.cbDVD = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtMostrar = New System.Windows.Forms.TextBox()
        Me.gbProcesador.SuspendLayout()
        Me.gbRAM.SuspendLayout()
        Me.gbDisco.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProcesador
        '
        Me.gbProcesador.Controls.Add(Me.rb_i7)
        Me.gbProcesador.Controls.Add(Me.rb_i5)
        Me.gbProcesador.Controls.Add(Me.rb_i3)
        Me.gbProcesador.Location = New System.Drawing.Point(28, 57)
        Me.gbProcesador.Name = "gbProcesador"
        Me.gbProcesador.Size = New System.Drawing.Size(113, 182)
        Me.gbProcesador.TabIndex = 0
        Me.gbProcesador.TabStop = False
        Me.gbProcesador.Text = "Procesador"
        '
        'rb_i7
        '
        Me.rb_i7.AutoSize = True
        Me.rb_i7.Location = New System.Drawing.Point(14, 129)
        Me.rb_i7.Name = "rb_i7"
        Me.rb_i7.Size = New System.Drawing.Size(33, 17)
        Me.rb_i7.TabIndex = 2
        Me.rb_i7.TabStop = True
        Me.rb_i7.Text = "i7"
        Me.rb_i7.UseVisualStyleBackColor = True
        '
        'rb_i5
        '
        Me.rb_i5.AutoSize = True
        Me.rb_i5.Location = New System.Drawing.Point(14, 77)
        Me.rb_i5.Name = "rb_i5"
        Me.rb_i5.Size = New System.Drawing.Size(33, 17)
        Me.rb_i5.TabIndex = 1
        Me.rb_i5.TabStop = True
        Me.rb_i5.Text = "i5"
        Me.rb_i5.UseVisualStyleBackColor = True
        '
        'rb_i3
        '
        Me.rb_i3.AutoSize = True
        Me.rb_i3.Location = New System.Drawing.Point(15, 32)
        Me.rb_i3.Name = "rb_i3"
        Me.rb_i3.Size = New System.Drawing.Size(33, 17)
        Me.rb_i3.TabIndex = 0
        Me.rb_i3.TabStop = True
        Me.rb_i3.Text = "i3"
        Me.rb_i3.UseVisualStyleBackColor = True
        '
        'gbRAM
        '
        Me.gbRAM.Controls.Add(Me.rb_16GB)
        Me.gbRAM.Controls.Add(Me.rb_12GB)
        Me.gbRAM.Controls.Add(Me.rb_8GB)
        Me.gbRAM.Location = New System.Drawing.Point(205, 57)
        Me.gbRAM.Name = "gbRAM"
        Me.gbRAM.Size = New System.Drawing.Size(123, 182)
        Me.gbRAM.TabIndex = 1
        Me.gbRAM.TabStop = False
        Me.gbRAM.Text = "RAM"
        '
        'rb_16GB
        '
        Me.rb_16GB.AutoSize = True
        Me.rb_16GB.Location = New System.Drawing.Point(16, 130)
        Me.rb_16GB.Name = "rb_16GB"
        Me.rb_16GB.Size = New System.Drawing.Size(52, 17)
        Me.rb_16GB.TabIndex = 2
        Me.rb_16GB.TabStop = True
        Me.rb_16GB.Text = "16GB"
        Me.rb_16GB.UseVisualStyleBackColor = True
        '
        'rb_12GB
        '
        Me.rb_12GB.AutoSize = True
        Me.rb_12GB.Location = New System.Drawing.Point(16, 77)
        Me.rb_12GB.Name = "rb_12GB"
        Me.rb_12GB.Size = New System.Drawing.Size(52, 17)
        Me.rb_12GB.TabIndex = 1
        Me.rb_12GB.TabStop = True
        Me.rb_12GB.Text = "12GB"
        Me.rb_12GB.UseVisualStyleBackColor = True
        '
        'rb_8GB
        '
        Me.rb_8GB.AutoSize = True
        Me.rb_8GB.Location = New System.Drawing.Point(16, 29)
        Me.rb_8GB.Name = "rb_8GB"
        Me.rb_8GB.Size = New System.Drawing.Size(46, 17)
        Me.rb_8GB.TabIndex = 0
        Me.rb_8GB.TabStop = True
        Me.rb_8GB.Text = "8GB"
        Me.rb_8GB.UseVisualStyleBackColor = True
        '
        'gbDisco
        '
        Me.gbDisco.Controls.Add(Me.rb_2TB)
        Me.gbDisco.Controls.Add(Me.rb_1TB)
        Me.gbDisco.Controls.Add(Me.rb_500GB)
        Me.gbDisco.Location = New System.Drawing.Point(406, 57)
        Me.gbDisco.Name = "gbDisco"
        Me.gbDisco.Size = New System.Drawing.Size(125, 182)
        Me.gbDisco.TabIndex = 1
        Me.gbDisco.TabStop = False
        Me.gbDisco.Text = "Disco"
        '
        'rb_2TB
        '
        Me.rb_2TB.AutoSize = True
        Me.rb_2TB.Location = New System.Drawing.Point(22, 129)
        Me.rb_2TB.Name = "rb_2TB"
        Me.rb_2TB.Size = New System.Drawing.Size(45, 17)
        Me.rb_2TB.TabIndex = 2
        Me.rb_2TB.TabStop = True
        Me.rb_2TB.Text = "2TB"
        Me.rb_2TB.UseVisualStyleBackColor = True
        '
        'rb_1TB
        '
        Me.rb_1TB.AutoSize = True
        Me.rb_1TB.Location = New System.Drawing.Point(22, 77)
        Me.rb_1TB.Name = "rb_1TB"
        Me.rb_1TB.Size = New System.Drawing.Size(45, 17)
        Me.rb_1TB.TabIndex = 1
        Me.rb_1TB.TabStop = True
        Me.rb_1TB.Text = "1TB"
        Me.rb_1TB.UseVisualStyleBackColor = True
        '
        'rb_500GB
        '
        Me.rb_500GB.AutoSize = True
        Me.rb_500GB.Location = New System.Drawing.Point(22, 29)
        Me.rb_500GB.Name = "rb_500GB"
        Me.rb_500GB.Size = New System.Drawing.Size(58, 17)
        Me.rb_500GB.TabIndex = 0
        Me.rb_500GB.TabStop = True
        Me.rb_500GB.Text = "500GB"
        Me.rb_500GB.UseVisualStyleBackColor = True
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.cbImpresora)
        Me.gbOpciones.Controls.Add(Me.cbAudio)
        Me.gbOpciones.Controls.Add(Me.cbAltavoces)
        Me.gbOpciones.Controls.Add(Me.cbDVD)
        Me.gbOpciones.Location = New System.Drawing.Point(596, 57)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(134, 182)
        Me.gbOpciones.TabIndex = 1
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'cbImpresora
        '
        Me.cbImpresora.AutoSize = True
        Me.cbImpresora.Location = New System.Drawing.Point(16, 130)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(72, 17)
        Me.cbImpresora.TabIndex = 3
        Me.cbImpresora.Text = "Impresora"
        Me.cbImpresora.UseVisualStyleBackColor = True
        '
        'cbAudio
        '
        Me.cbAudio.AutoSize = True
        Me.cbAudio.Location = New System.Drawing.Point(16, 54)
        Me.cbAudio.Name = "cbAudio"
        Me.cbAudio.Size = New System.Drawing.Size(53, 17)
        Me.cbAudio.TabIndex = 2
        Me.cbAudio.Text = "Audio"
        Me.cbAudio.UseVisualStyleBackColor = True
        '
        'cbAltavoces
        '
        Me.cbAltavoces.AutoSize = True
        Me.cbAltavoces.Location = New System.Drawing.Point(16, 88)
        Me.cbAltavoces.Name = "cbAltavoces"
        Me.cbAltavoces.Size = New System.Drawing.Size(73, 17)
        Me.cbAltavoces.TabIndex = 1
        Me.cbAltavoces.Text = "Altavoces"
        Me.cbAltavoces.UseVisualStyleBackColor = True
        '
        'cbDVD
        '
        Me.cbDVD.AutoSize = True
        Me.cbDVD.Location = New System.Drawing.Point(16, 19)
        Me.cbDVD.Name = "cbDVD"
        Me.cbDVD.Size = New System.Drawing.Size(49, 17)
        Me.cbDVD.TabIndex = 0
        Me.cbDVD.Text = "DVD"
        Me.cbDVD.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(355, 275)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtMostrar
        '
        Me.txtMostrar.Location = New System.Drawing.Point(74, 355)
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(666, 20)
        Me.txtMostrar.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMostrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbDisco)
        Me.Controls.Add(Me.gbRAM)
        Me.Controls.Add(Me.gbProcesador)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbProcesador.ResumeLayout(False)
        Me.gbProcesador.PerformLayout()
        Me.gbRAM.ResumeLayout(False)
        Me.gbRAM.PerformLayout()
        Me.gbDisco.ResumeLayout(False)
        Me.gbDisco.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbProcesador As GroupBox
    Friend WithEvents rb_i7 As RadioButton
    Friend WithEvents rb_i5 As RadioButton
    Friend WithEvents rb_i3 As RadioButton
    Friend WithEvents gbRAM As GroupBox
    Friend WithEvents rb_16GB As RadioButton
    Friend WithEvents rb_12GB As RadioButton
    Friend WithEvents rb_8GB As RadioButton
    Friend WithEvents gbDisco As GroupBox
    Friend WithEvents rb_2TB As RadioButton
    Friend WithEvents rb_1TB As RadioButton
    Friend WithEvents rb_500GB As RadioButton
    Friend WithEvents gbOpciones As GroupBox
    Friend WithEvents cbImpresora As CheckBox
    Friend WithEvents cbAudio As CheckBox
    Friend WithEvents cbAltavoces As CheckBox
    Friend WithEvents cbDVD As CheckBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtMostrar As TextBox
End Class
