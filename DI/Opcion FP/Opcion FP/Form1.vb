Public Class Form1
    Private Sub btnDAM_Click(sender As Object, e As EventArgs) Handles btnDAM.Click
        txtMostrar.Text = btnDAM.Text
    End Sub

    Private Sub btnDAW_Click(sender As Object, e As EventArgs) Handles btnDAW.Click
        txtMostrar.Text = btnDAW.Text
    End Sub

    Private Sub btnASIR_Click(sender As Object, e As EventArgs) Handles btnASIR.Click
        txtMostrar.Text = "ASIR"
    End Sub

    Private Sub btnSMR_Click(sender As Object, e As EventArgs) Handles btnSMR.Click
        txtMostrar.Text = btnSMR.Text
    End Sub
End Class
