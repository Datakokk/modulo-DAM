Public Class Form1
    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        Me.Hide()
        formulario2.Show()
    End Sub

    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnOperacion.Click
        Me.Hide()
        formulario3.Show()
    End Sub
End Class
