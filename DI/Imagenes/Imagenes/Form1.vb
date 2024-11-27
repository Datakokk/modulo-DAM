Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox4.Image = Image.FromFile(Application.StartupPath & "\fotos_animales\foto1.jpg")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox4.Image = PictureBox2.Image
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox4.Image = PictureBox3.Image
    End Sub

    Private Sub btnZoom_Click(sender As Object, e As EventArgs) Handles btnZoom.Click
        PictureBox4.Width = PictureBox4.Width + 5
        PictureBox4.Height = PictureBox4.Height + 5
    End Sub

    Private Sub btnNoZoom_Click(sender As Object, e As EventArgs) Handles btnNoZoom.Click
        PictureBox4.Width = PictureBox4.Width - 5
        PictureBox4.Height = PictureBox4.Height - 5
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
