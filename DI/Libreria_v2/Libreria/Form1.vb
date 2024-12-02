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

            libros(num).titulo = txtTitulo.Text
            libros(num).autor = txtAutor.Text
            libros(num).tema = cbTema.Text
            libros(num).numPagin = txtPaginas.Text
            libros(num).portada = ComboBoxPortada.Text
            Dim ruta As String = Application.StartupPath & "\imagenes\" & ComboBoxPortada.Text & ".png"
            Try
                PictureBox1.Image = Image.FromFile(ruta)
            Catch ex As Exception
                MessageBox.Show("No se pudo cargar la imagen. Verifica que el archivo exista en la ruta especificada: " & ruta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ' Tratamos los CheckBoxes
            libros(num).formato1 = chbCartone.Checked
            libros(num).formato2 = chbRústica.Checked
            libros(num).formato3 = chbTapaDura.Checked

            ' Tratamos el RadioButton
            libros(num).estado = If(rbNovedad.Checked, "novedad", "reedicion")


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
            ComboBoxPortada.SelectedItem = libros(num).portada
            ' Mostrar imagen asociada
            Dim ruta As String = Application.StartupPath & "\imagenes\" & libros(num).portada & ".png"
            Try
                PictureBox1.Image = Image.FromFile(ruta)
            Catch ex As Exception
                PictureBox1.Image = Nothing ' Si no encuentra la imagen, limpiar PictureBox
                MessageBox.Show("No se pudo cargar la imagen: " & ruta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            chbCartone.Checked = libros(num).formato1
            chbRústica.Checked = libros(num).formato2
            chbTapaDura.Checked = libros(num).formato3

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

            LimpiarCampos()

            ListBoxLibros.Items.RemoveAt(ListBoxLibros.SelectedIndex())
            num -= 1
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

<<<<<<< HEAD
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBoxPortada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPortada.SelectedIndexChanged

    End Sub
End Class


=======
    Private Sub LimpiarCampos()
        txtTitulo.Clear()
        txtAutor.Clear()
        txtPaginas.Clear()
        ComboBoxPortada.SelectedIndex = -1
        chbCartone.Checked = False
        chbRústica.Checked = False
        chbTapaDura.Checked = False
        rbNovedad.Checked = True
        rbReedición.Checked = False
        cbTema.SelectedIndex = -1
        PictureBox1.Image = Nothing
    End Sub

End Class

>>>>>>> 03b45cc (DI: Se ha finalizado HsScrollBar_VsScrollBar al igual que Libreria)
