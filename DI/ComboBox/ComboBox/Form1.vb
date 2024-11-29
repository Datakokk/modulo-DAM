Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lbName.Items.Add(cbName.Text)
        cbName.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lbName.SelectedIndex <> -1 Then
            lbName.Items.Remove(lbName.SelectedItem)
        End If
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Close()
    End Sub
End Class
