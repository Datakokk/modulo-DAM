Public Class Form1
    Private Structure libro
        Public Titulo As String
        Public Autor As String
        Public Tema As String
        Public NumPagin As String
        Public Formato As String
        Public Estado As String
    End Structure

    Dim listaClientes As New List(Of libro)
    Dim tema As String
    Private Sub cbTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTema.SelectedValueChanged
        tema = cbTema.SelectedItem.ToString()
    End Sub
    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim ctrl As Control
        Dim x As Integer

        For x = Me.Controls.Count - 1 To 0 Step -1
            ctrl = Me.Controls.Item(x)
            If TypeOf (ctrl) Is CheckBox Then
                MessageBox.Show(ctrl.Text)
            End If
        Next


        listaClientes.Add(New libro With {
                          .Titulo = txtTitulo.Text,
                          .Autor = txtAutor.Text,
                          .Tema = tema,
                          .NumPagin = txtPaginas.Text,
                          .Formato = "",
                          .Estado = ""
        })
        MessageBox.Show(tema)
    End Sub


End Class
