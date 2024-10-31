Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim pais As String = ListBox1.SelectedItem.ToString()

            ' Usamos Select Case para evaluar el pais seleccionado
            Select Case pais
                Case "Alemania"
                    txtPais.Text = "Alemania"
                    txtSaludos.Text = "Hallo"
                    pbPais.Image = Image.FromFile("C:\\Users\\fiodo\\Source\\Repos\\ListBoxSaludos\\Banderas\\Alemania.png")

                Case "España"
                    txtPais.Text = "España"
                    txtSaludos.Text = "Hola"
                    pbPais.Image = Image.FromFile("C:\\Users\\fiodo\\Source\\Repos\\ListBoxSaludos\\Banderas\\España.png")

                Case "Italia"
                    txtPais.Text = "Italia"
                    txtSaludos.Text = "Ciao"
                    pbPais.Image = Image.FromFile("C:\\Users\\fiodo\\Source\\Repos\\ListBoxSaludos\\Banderas\\Argentina.png")

                Case "Inglaterra"
                    txtPais.Text = "Inglaterra"
                    txtSaludos.Text = "Hello"
                    pbPais.Image = Image.FromFile("C:\\Users\\fiodo\\Source\\Repos\\ListBoxSaludos\\Banderas\\Catar.jpg")

            End Select
        End If


    End Sub
End Class
