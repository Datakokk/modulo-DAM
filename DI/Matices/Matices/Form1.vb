Public Class Form1
    Dim num As Integer = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If num <= 19 AndAlso num >= 0 Then
            num += 1
            txtElemento.Text = num
        Else
            num = 20
        End If

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        If num <= 20 AndAlso num >= 1 Then
            num -= 1
            txtElemento.Text = num
        Else
            num = 0
        End If
    End Sub
End Class
