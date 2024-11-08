Public Class Form1
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If txtNombreAlumno.Text.Equals("") Then
            MessageBox.Show("No puede estar vacio el nombre del alumno")
        Else
            lbAlumno.Items.Add(txtNombreAlumno.Text)
            lbOptativas.Items.Add(cbAsigOpt.SelectedItem)
        End If
        txtNombreAlumno.Clear()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lbAlumno.SelectedIndex <> -1 Then
            lbOptativas.Items.RemoveAt(lbAlumno.SelectedIndex)
            lbAlumno.Items.Remove(lbAlumno.SelectedItem)
        End If
    End Sub
    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        lbAlumno.Items.Clear()
        lbOptativas.Items.Clear()
        txtNombreAlumno.Clear()
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        Close()
    End Sub
End Class
