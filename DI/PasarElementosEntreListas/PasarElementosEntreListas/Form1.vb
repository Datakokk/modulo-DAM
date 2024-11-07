Public Class Form1
    Dim temp As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.SelectedIndex <> -1 Then
                btnAbajo.Enabled = True
                btnDerecha.Enabled = True
            End If
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        For i = 0 To ListBox2.Items.Count - 1
            If ListBox2.SelectedIndex <> -1 Then
                btnAbajo.Enabled = True
                btnIzq.Enabled = True
                btnDerecha.Enabled = False
            End If
        Next
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        For i = 0 To ListBox3.Items.Count - 1
            If ListBox3.SelectedIndex <> -1 Then
                btnAbajo.Enabled = False
                btnIzq.Enabled = True
                btnDerecha.Enabled = True
            End If
        Next
    End Sub
    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.SelectedIndex <> -1 Then
                btnAbajo.Enabled = True
                btnDerecha.Enabled = True
                ListBox2.Items.Add(ListBox1.SelectedItem)
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        Next
    End Sub

    Private Sub btnIzq_Click(sender As Object, e As EventArgs) Handles btnIzq.Click
        For i = 0 To ListBox2.Items.Count - 1
            If ListBox2.SelectedIndex <> -1 Then
                btnAbajo.Enabled = True
                btnDerecha.Enabled = True
                ListBox1.Items.Add(ListBox2.SelectedItem)
                ListBox2.Items.Remove(ListBox2.SelectedItem)
            End If
        Next
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.SelectedIndex <> -1 Then
                btnIzq.Enabled = True
                btnDerecha.Enabled = True
                ListBox3.Items.Add(ListBox1.SelectedItem)
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        Next
    End Sub
End Class
