Public Class Form1
    Private Structure libro
        Public Titulo As String
        Public Autor As String
        Public Tema As String
        Public NumPagin As String
        Public Formato1 As String
        Public Formato2 As String
        Public Formato3 As String
        Public Estado As String
    End Structure

    Dim listaClientes As New List(Of libro)
    Dim tema As String
    Private Sub cbTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTema.SelectedValueChanged
        tema = cbTema.SelectedItem.ToString()
    End Sub
    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim chbox1 As String = ""
        Dim chbox2 As String = ""
        Dim chbox3 As String = ""
        Dim rbutton As String

        If txtTitulo.Text.Equals("") AndAlso txtAutor.Text.Equals("") AndAlso txtPaginas.Text.Equals("") Then

        End If

        ' Comprobamos que Checked estan seleccionados
        If chbRústica.Checked Then
            chbox1 = "Rústica"
        End If

        If chbTapaDura.Checked Then
            chbox2 = "TapaDura"
        End If

        If ChbCartone.Checked Then
            chbox3 = "Cartoné"
        End If

        'Comprobamos los radiobutton que estan seleccionados
        If rbNovedad.Checked Then
            rbutton = "Novedad
"
        ElseIf rbReedición.Checked Then
            rbutton = "Reedición"
        End If

        listaClientes.Add(New libro With {
                          .Titulo = txtTitulo.Text,
                          .Autor = txtAutor.Text,
                          .Tema = tema,
                          .NumPagin = txtPaginas.Text,
                          .Formato1 = chbox1,
                          .Formato2 = chbox2,
                          .Formato3 = chbox3,
                          .Estado = rbutton
        })
        MessageBox.Show(tema)
        ListBoxLibros.Items.Add(txtTitulo.Text)
    End Sub

    Private Sub ListBoxLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLibros.SelectedIndexChanged
        If ListBoxLibros.SelectedIndex <> -1 Then

        End If
    End Sub
End Class
