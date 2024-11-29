Public Class Form1
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll

        If HScrollBar1.Value > 1 AndAlso HScrollBar1.Value <= 10 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\frio.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Muy Frio"
            HScrollBar2.Value = HScrollBar1.Value
        ElseIf HScrollBar1.Value > 10 AndAlso HScrollBar1.Value <= 20 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\templado.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Frio"
            HScrollBar2.Value = HScrollBar1.Value
        ElseIf HScrollBar1.Value > 20 AndAlso HScrollBar1.Value <= 30 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\caliente.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Caliente"
            HScrollBar2.Value = HScrollBar1.Value
        ElseIf HScrollBar1.Value > 30 AndAlso HScrollBar1.Value < 40 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\muyCaliente.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Muy caliente"
            HScrollBar2.Value = HScrollBar1.Value
        ElseIf HScrollBar1.Value > 40 AndAlso HScrollBar1.Value < 50 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\ardiendo.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Ardiendo"
            HScrollBar2.Value = HScrollBar1.Value
        End If
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        If HScrollBar2.Value > 1 AndAlso HScrollBar2.Value <= 10 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\frio.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Muy Frio"
            HScrollBar1.Value = HScrollBar2.Value
            HScrollBar2.Value = HScrollBar1.Value
        ElseIf HScrollBar2.Value > 10 AndAlso HScrollBar2.Value <= 20 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\templado.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Frio"
            HScrollBar1.Value = HScrollBar2.Value
        ElseIf HScrollBar2.Value > 20 AndAlso HScrollBar2.Value <= 30 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\caliente.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Caliente"
            HScrollBar1.Value = HScrollBar2.Value
        ElseIf HScrollBar2.Value > 30 AndAlso HScrollBar2.Value < 40 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\muyCaliente.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Muy caliente"
            HScrollBar1.Value = HScrollBar2.Value
        ElseIf HScrollBar2.Value > 40 AndAlso HScrollBar2.Value < 50 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagenes\ardiendo.jpg")
            lblCambiaTemp.Text = HScrollBar1.Value & " ºC"
            lblDescripcion.Text = "Ardiendo"
            HScrollBar1.Value = HScrollBar2.Value
        End If
    End Sub
End Class
