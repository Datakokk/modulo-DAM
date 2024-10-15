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
        Me.btnDAM = New System.Windows.Forms.Button()
        Me.btnDAW = New System.Windows.Forms.Button()
        Me.btnASIR = New System.Windows.Forms.Button()
        Me.btnSMR = New System.Windows.Forms.Button()
        Me.txtMostrar = New System.Windows.Forms.TextBox()
        Me.lblSolicitar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDAM
        '
        Me.btnDAM.Location = New System.Drawing.Point(77, 236)
        Me.btnDAM.Name = "btnDAM"
        Me.btnDAM.Size = New System.Drawing.Size(75, 23)
        Me.btnDAM.TabIndex = 1
        Me.btnDAM.Text = "DAM"
        Me.btnDAM.UseVisualStyleBackColor = True
        '
        'btnDAW
        '
        Me.btnDAW.Location = New System.Drawing.Point(189, 236)
        Me.btnDAW.Name = "btnDAW"
        Me.btnDAW.Size = New System.Drawing.Size(75, 23)
        Me.btnDAW.TabIndex = 2
        Me.btnDAW.Text = "DAW"
        Me.btnDAW.UseVisualStyleBackColor = True
        '
        'btnASIR
        '
        Me.btnASIR.Location = New System.Drawing.Point(312, 236)
        Me.btnASIR.Name = "btnASIR"
        Me.btnASIR.Size = New System.Drawing.Size(75, 23)
        Me.btnASIR.TabIndex = 3
        Me.btnASIR.Text = "ASIR"
        Me.btnASIR.UseVisualStyleBackColor = True
        '
        'btnSMR
        '
        Me.btnSMR.Location = New System.Drawing.Point(456, 236)
        Me.btnSMR.Name = "btnSMR"
        Me.btnSMR.Size = New System.Drawing.Size(75, 23)
        Me.btnSMR.TabIndex = 4
        Me.btnSMR.Text = "SMR"
        Me.btnSMR.UseVisualStyleBackColor = True
        '
        'txtMostrar
        '
        Me.txtMostrar.Location = New System.Drawing.Point(287, 95)
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(100, 20)
        Me.txtMostrar.TabIndex = 5
        Me.txtMostrar.Text = "que sera....."
        '
        'lblSolicitar
        '
        Me.lblSolicitar.AutoSize = True
        Me.lblSolicitar.Location = New System.Drawing.Point(161, 95)
        Me.lblSolicitar.Name = "lblSolicitar"
        Me.lblSolicitar.Size = New System.Drawing.Size(104, 13)
        Me.lblSolicitar.TabIndex = 6
        Me.lblSolicitar.Text = "la opcion elegida es:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSolicitar)
        Me.Controls.Add(Me.txtMostrar)
        Me.Controls.Add(Me.btnSMR)
        Me.Controls.Add(Me.btnASIR)
        Me.Controls.Add(Me.btnDAW)
        Me.Controls.Add(Me.btnDAM)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDAM As Button
    Friend WithEvents btnDAW As Button
    Friend WithEvents btnASIR As Button
    Friend WithEvents btnSMR As Button
    Friend WithEvents txtMostrar As TextBox
    Friend WithEvents lblSolicitar As Label
End Class
