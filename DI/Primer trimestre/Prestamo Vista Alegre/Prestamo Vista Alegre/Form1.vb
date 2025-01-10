Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim capital As Double
        Dim interes As Double
        Dim resultado As Double

        If txtCapital.Text <> "" AndAlso Double.TryParse(txtCapital.Text, capital) AndAlso txtInteres.Text <> "" AndAlso Double.TryParse(txtInteres.Text, interes) Then
            ' Calculamos la cantidad del porcentaje dado

            resultado = (capital * interes) / 100

            ' Mostramos el capital interes y capital acumulado
            txtCInteres.Text = resultado.ToString("F2") ' Formato con 2 decimales
            txtCAcumulado.Text = (resultado + capital).ToString("F2") ' Formato con 2 decimales

            btnReset.Enabled = True
        Else
            ' Mostrar un mensaje de error si el capital o interes no es válido
            MessageBox.Show("Por favor, introduce un valor numérico válido.")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCapital.Text = ""
        txtInteres.Text = ""
        txtCInteres.Text = ""
        txtCAcumulado.Text = ""
        btnReset.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
