Public Class Form1
    Dim numeros(19) As Integer
    Dim indiceActual As Integer = 0
    Dim camponVisualizar As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        For ele As Integer = 0 To 19
            numeros(ele) = 0
        Next
        txtElemento.Text = indiceActual
        txtValor.Text = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If indiceActual < 19 Then
            indiceActual += 1
        End If
        txtElemento.Text = indiceActual
        txtValor.Focus()
    End Sub
    Private Sub btnDisminuir_Click(sender As Object, e As EventArgs) Handles btnDisminuir.Click
        If indiceActual > 0 Then
            indiceActual -= 1
        End If
        txtElemento.Text = indiceActual
        txtValor.Focus()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim valor As Integer
        If Integer.TryParse(txtValor.Text, valor) Then
            numeros(indiceActual) = valor
            camponVisualizar = camponVisualizar & valor.ToString() & vbCrLf
        Else
            MessageBox.Show("Introducir un número")
        End If
        txtValor.Text = ""
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        txtVisualizar.Text = camponVisualizar
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

End Class
