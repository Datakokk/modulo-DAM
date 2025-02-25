Public Class Form2
    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        Me.Hide()
        formulario3.Show()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Me.Hide()
        formulario1.Show()
    End Sub
End Class