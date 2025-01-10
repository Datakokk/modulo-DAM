Public Class Form1
    Dim tbparking(9, 9) As Boolean
    Dim contPlazasLibrs As Integer
    Dim contPlazasOcup As Integer
    Dim contador As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        contador = 81 'Numero de plazas libres al iniciar la aplicación

        For i = 0 To 9
            For j = 0 To 9
                tbparking(i, j) = False
            Next
        Next
    End Sub

    Private Sub btnAparcar_Click(sender As Object, e As EventArgs) Handles btnAparcar.Click
        Dim calle, plaza As Integer
        If Integer.TryParse(txtCalle.Text, calle) AndAlso Integer.TryParse(txtPlaza.Text, plaza) Then
            If (calle >= 0 And calle <= 9) AndAlso (plaza >= 0 And plaza <= 9) Then
                If tbparking(calle, plaza).Equals(False) Then
                    MessageBox.Show("Plaza libre puede aparcar", "Coche")
                    tbparking(calle, plaza) = True
                    contador -= 1
                Else
                    MessageBox.Show("Ocupado no puedes aparcar", "Coche")
                End If
            Else
                MessageBox.Show("El número tiene que estar entre 0 y 9")
            End If
        Else
            MessageBox.Show("Introducir un número por favor")
        End If

        txtCalle.Clear()
        txtPlaza.Clear()

        txtNumPlaOcu.Text = (81 - contador).ToString
        txtNumPlaLib.Text = contador.ToString

    End Sub

    Private Sub btnSacarCoche_Click(sender As Object, e As EventArgs) Handles btnSacarCoche.Click
        Dim calle, plaza As Integer
        If Integer.TryParse(txtCalle.Text, calle) AndAlso Integer.TryParse(txtPlaza.Text, plaza) Then
            If (calle >= 0 And calle <= 9) AndAlso (plaza >= 0 And plaza <= 9) Then
                If tbparking(calle, plaza).Equals(True) Then
                    tbparking(calle, plaza) = False
                    MessageBox.Show("Coche sacado queda plaza libre", "Coche")
                    contador += 1
                Else
                    MessageBox.Show("No hay coches en esta plaza para sacar", "Coche")
                End If
            Else
                MessageBox.Show("El número tiene que estar entre 0 y 9")
            End If
        Else
            MessageBox.Show("Introducir un número por favor")
        End If

        txtCalle.Clear()
        txtPlaza.Clear()
        txtNumPlaOcu.Text = (81 - contador).ToString
        txtNumPlaLib.Text = contador.ToString
    End Sub
    Private Sub btnVisualizaPlazasLibres_Click(sender As Object, e As EventArgs) Handles btnVisualizaPlazasLibres.Click
        For i = 0 To 9
            For j = 0 To 9
                If tbparking(i, j).Equals(False) Then
                    txtPlazasLibres.Text = txtPlazasLibres.Text & "   " & i & "                       " & j & vbCrLf
                End If
            Next
        Next
    End Sub

    Private Sub btnVisualizaPlazasOcupadas_Click(sender As Object, e As EventArgs) Handles btnVisualizaPlazasOcupadas.Click
        txtPlazasOcupadas.Clear()

        For i = 0 To 9
            For j = 0 To 9
                If tbparking(i, j).Equals(True) Then
                    txtPlazasOcupadas.Text = txtPlazasOcupadas.Text & "   " & i & "                          " & j & vbCrLf
                End If
            Next
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

End Class
