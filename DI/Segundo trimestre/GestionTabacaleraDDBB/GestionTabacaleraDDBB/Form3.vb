Public Class Form3
    Private Sub btnTabaquera_Click(sender As Object, e As EventArgs) Handles btnTabaquera.Click
        Me.Hide()
        formulario4.Show()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        formulario2.Show()
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        Me.Hide()
        formulario4.Show()
    End Sub
End Class