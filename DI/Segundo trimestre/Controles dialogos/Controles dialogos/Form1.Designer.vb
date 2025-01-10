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
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.btnColorFondo = New System.Windows.Forms.Button()
        Me.btnColorLetra = New System.Windows.Forms.Button()
        Me.btnTipoLetra = New System.Windows.Forms.Button()
        Me.btnAbrirAplicacion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDam = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(580, 98)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(100, 23)
        Me.btnImagen.TabIndex = 0
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'btnColorFondo
        '
        Me.btnColorFondo.Location = New System.Drawing.Point(580, 155)
        Me.btnColorFondo.Name = "btnColorFondo"
        Me.btnColorFondo.Size = New System.Drawing.Size(100, 23)
        Me.btnColorFondo.TabIndex = 1
        Me.btnColorFondo.Text = "Color fondo"
        Me.btnColorFondo.UseVisualStyleBackColor = True
        '
        'btnColorLetra
        '
        Me.btnColorLetra.Location = New System.Drawing.Point(580, 215)
        Me.btnColorLetra.Name = "btnColorLetra"
        Me.btnColorLetra.Size = New System.Drawing.Size(100, 23)
        Me.btnColorLetra.TabIndex = 2
        Me.btnColorLetra.Text = "Color letra"
        Me.btnColorLetra.UseVisualStyleBackColor = True
        '
        'btnTipoLetra
        '
        Me.btnTipoLetra.Location = New System.Drawing.Point(580, 269)
        Me.btnTipoLetra.Name = "btnTipoLetra"
        Me.btnTipoLetra.Size = New System.Drawing.Size(100, 23)
        Me.btnTipoLetra.TabIndex = 3
        Me.btnTipoLetra.Text = "Tipo letra"
        Me.btnTipoLetra.UseVisualStyleBackColor = True
        '
        'btnAbrirAplicacion
        '
        Me.btnAbrirAplicacion.Location = New System.Drawing.Point(580, 338)
        Me.btnAbrirAplicacion.Name = "btnAbrirAplicacion"
        Me.btnAbrirAplicacion.Size = New System.Drawing.Size(100, 23)
        Me.btnAbrirAplicacion.TabIndex = 4
        Me.btnAbrirAplicacion.Text = "Abrir aplicación"
        Me.btnAbrirAplicacion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(166, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblDam
        '
        Me.lblDam.AutoSize = True
        Me.lblDam.Location = New System.Drawing.Point(191, 225)
        Me.lblDam.Name = "lblDam"
        Me.lblDam.Padding = New System.Windows.Forms.Padding(10)
        Me.lblDam.Size = New System.Drawing.Size(51, 33)
        Me.lblDam.TabIndex = 6
        Me.lblDam.Text = "DAM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDam)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAbrirAplicacion)
        Me.Controls.Add(Me.btnTipoLetra)
        Me.Controls.Add(Me.btnColorLetra)
        Me.Controls.Add(Me.btnColorFondo)
        Me.Controls.Add(Me.btnImagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImagen As Button
    Friend WithEvents btnColorFondo As Button
    Friend WithEvents btnColorLetra As Button
    Friend WithEvents btnTipoLetra As Button
    Friend WithEvents btnAbrirAplicacion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDam As Label
End Class
