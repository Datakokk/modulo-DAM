Public Class Form2
    Inherits System.Windows.Forms.Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        formulario1.Button1.BackColor = Color.Purple
        formulario1.Show()
    End Sub
End Class