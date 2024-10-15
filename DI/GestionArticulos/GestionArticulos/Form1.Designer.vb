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
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPU = New System.Windows.Forms.Label()
        Me.lblDTO = New System.Windows.Forms.Label()
        Me.lblPVP = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPU = New System.Windows.Forms.TextBox()
        Me.txtDTO = New System.Windows.Forms.TextBox()
        Me.txtPVP = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(47, 62)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(66, 13)
        Me.lblConcepto.TabIndex = 0
        Me.lblConcepto.Text = "CONCEPTO"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(194, 62)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(36, 13)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "CANT"
        '
        'lblPU
        '
        Me.lblPU.AutoSize = True
        Me.lblPU.Location = New System.Drawing.Point(339, 62)
        Me.lblPU.Name = "lblPU"
        Me.lblPU.Size = New System.Drawing.Size(25, 13)
        Me.lblPU.TabIndex = 2
        Me.lblPU.Text = "P.U"
        '
        'lblDTO
        '
        Me.lblDTO.AutoSize = True
        Me.lblDTO.Location = New System.Drawing.Point(488, 62)
        Me.lblDTO.Name = "lblDTO"
        Me.lblDTO.Size = New System.Drawing.Size(33, 13)
        Me.lblDTO.TabIndex = 3
        Me.lblDTO.Text = "DTO."
        '
        'lblPVP
        '
        Me.lblPVP.AutoSize = True
        Me.lblPVP.Location = New System.Drawing.Point(633, 62)
        Me.lblPVP.Name = "lblPVP"
        Me.lblPVP.Size = New System.Drawing.Size(34, 13)
        Me.lblPVP.TabIndex = 4
        Me.lblPVP.Text = "P.V.P"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(92, 187)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "TOTAL"
        Me.lblTotal.Visible = False
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(50, 99)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(100, 20)
        Me.txtConcepto.TabIndex = 6
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(197, 99)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'txtPU
        '
        Me.txtPU.Location = New System.Drawing.Point(342, 99)
        Me.txtPU.Name = "txtPU"
        Me.txtPU.Size = New System.Drawing.Size(100, 20)
        Me.txtPU.TabIndex = 8
        '
        'txtDTO
        '
        Me.txtDTO.Location = New System.Drawing.Point(485, 99)
        Me.txtDTO.Name = "txtDTO"
        Me.txtDTO.Size = New System.Drawing.Size(100, 20)
        Me.txtDTO.TabIndex = 9
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(636, 99)
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(100, 20)
        Me.txtPVP.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(255, 187)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(266, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(75, 315)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(322, 315)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 13
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(564, 315)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPVP)
        Me.Controls.Add(Me.txtDTO)
        Me.Controls.Add(Me.txtPU)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPVP)
        Me.Controls.Add(Me.lblDTO)
        Me.Controls.Add(Me.lblPU)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblConcepto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConcepto As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPU As Label
    Friend WithEvents lblDTO As Label
    Friend WithEvents lblPVP As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPU As TextBox
    Friend WithEvents txtDTO As TextBox
    Friend WithEvents txtPVP As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnSalir As Button
End Class
