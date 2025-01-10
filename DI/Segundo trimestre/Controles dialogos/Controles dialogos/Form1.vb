Public Class Form1
    Private Sub btnColorFondo_Click(sender As Object, e As EventArgs) Handles btnColorFondo.Click
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            lblDam.BackColor = colorDialog.Color ' Cambiar el fondo del Label (DAM)
        End If
    End Sub

    Private Sub btnColorLetra_Click(sender As Object, e As EventArgs) Handles btnColorLetra.Click
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            lblDam.ForeColor = colorDialog.Color ' Cambiar el color del texto
        End If
    End Sub

    Private Sub btnTipoLetra_Click(sender As Object, e As EventArgs) Handles btnTipoLetra.Click
        Dim fontDialog As New FontDialog()
        If fontDialog.ShowDialog() = DialogResult.OK Then
            lblDam.Font = fontDialog.Font ' Cambiar el tipo de letra del texto
        End If
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.bmp;*.gif" ' Filtro de formatos de imagen

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName) ' Cargar la imagen en el PictureBox
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ' Ajustar tamaño
        End If
    End Sub
End Class
