Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        formulario2.TextBox1.Text = "pepepepepepe"
        formulario2.Button1.BackColor = Color.Red

        formulario2.Show()
    End Sub
End Class
