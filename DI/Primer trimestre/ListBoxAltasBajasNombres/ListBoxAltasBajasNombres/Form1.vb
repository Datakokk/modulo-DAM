Public Class Form1
    'Dim nombres = lbNombres.SelectedItem.ToString()
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        lbNombres.Items.Add(txtElementoAnadir.Text)
        txtElementoAnadir.Clear()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        lbNombres.Items.Remove(txtElementoSeleccionado.Text)
        txtElementoSeleccionado.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lbNombres.Items.Clear()
        txtElementoSeleccionado.Clear()
        txtElementoAnadir.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub lbNombres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombres.SelectedIndexChanged
        If lbNombres.SelectedIndex <> -1 Then
            txtElementoSeleccionado.Text = lbNombres.SelectedItem.ToString
        End If
    End Sub
End Class
