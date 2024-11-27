Public Class Form1
    Dim num As Integer
    Private Structure libro
        Public titulo As String
        Public autor As String
        Public tema As String
        Public numPagin As String
        Public portada As String
        Public formato1 As String
        Public formato2 As String
        Public formato3 As String
        Public estado As String
    End Structure

    Dim libros(4) As libro

    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        If Me.ListBoxLibros.Items.Count - 1 < 4 Then
            num = Me.ListBoxLibros.Items.Count

            libros(num).titulo = txtTitulo.Text
            libros(num).autor = txtAutor.Text
            libros(num).tema = cbTema.SelectedItem
            libros(num).numPagin = txtPaginas.Text
            Dim ruta As String = Application.StartupPath & "\imagenes\aventura.jpg" & libros(num).portada
            MessageBox.Show(Application.StartupPath & "\imagenes\aventura.jpg")
            PictureBox1.Image = Image.FromFile(ruta)
            'Tratamos el checkbox
            If chbCartone.Checked Then
                libros(num).formato1 = True
            Else
                libros(num).formato1 = False
            End If

            If chbRústica.Checked Then
                libros(num).formato2 = True
            Else
                libros(num).formato2 = False
            End If

            If chbTapaDura.Checked Then
                libros(num).formato3 = True
            Else
                libros(num).formato3 = False
            End If

            ' Tratamos el radioButton
            If rbNovedad.Checked Then
                libros(num).estado = "novedad"
            Else
                libros(num).estado = "reedicion"
            End If

            ListBoxLibros.Items.Add(libros(num).titulo)
            num += 1

        Else
            MessageBox.Show("Maxmo de libros introducidos")
        End If
    End Sub

    Private Sub ListBoxLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLibros.SelectedIndexChanged
        If ListBoxLibros.SelectedIndex <> -1 Then
            num = ListBoxLibros.SelectedIndex

            txtTitulo.Text = libros(num).titulo
            txtAutor.Text = libros(num).autor
            cbTema.SelectedItem = libros(num).tema
            txtPaginas.Text = libros(num).numPagin

            If libros(num).formato1 Then
                chbCartone.Checked = True
            Else
                chbCartone.Checked = False
            End If
            If libros(num).formato2 Then
                chbRústica.Checked = True
            Else
                chbRústica.Checked = False
            End If
            If libros(num).formato1 Then
                chbTapaDura.Checked = True
            Else
                chbTapaDura.Checked = False
            End If

            If libros(num).estado = "novedad" Then
                rbNovedad.Checked = True
            Else
                rbReedición.Checked = True
            End If
        End If
    End Sub

    Private Sub btnBajas_Click(sender As Object, e As EventArgs) Handles btnBajas.Click
        If ListBoxLibros.SelectedIndex <> -1 Then

            For i = ListBoxLibros.SelectedIndex() To num - 1
                If (Not IsNothing(libros(i + 1)) And i <> num) Then
                    libros(i) = libros(i + 1)
                End If
            Next

            txtTitulo.Text = ""
            txtAutor.Text = ""
            txtPaginas.Text = ""
            chbCartone.Checked = False
            chbRústica.Checked = False
            chbTapaDura.Checked = False
            rbNovedad.Checked = True
            rbReedición.Checked = False
            ComboBoxPortada.SelectedItem = " "
            cbTema.SelectedIndex = -1
            PictureBox1.Image = Nothing

            ListBoxLibros.Items.RemoveAt(ListBoxLibros.SelectedIndex())
            num -= 1
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTitulo.Text = ""
        txtAutor.Text = ""
        txtPaginas.Text = ""
        ComboBoxPortada.SelectedItem = ""
        chbCartone.Checked = False
        chbRústica.Checked = False
        chbTapaDura.Checked = False
        rbNovedad.Checked = True
        rbReedición.Checked = False
        cbTema.SelectedIndex = -1
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
