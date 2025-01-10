Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Declarar una variable para el radio
        Dim centigrados As Double
        Dim farhenheit As Double
        Dim resultado As Double

        If txtCentigrados.Text <> "" AndAlso Double.TryParse(txtCentigrados.Text, centigrados) AndAlso txtFarenheit.Text = "" Then
            ' Calcular de centigrados a fahrenheit
            resultado = (centigrados * 9 / 5 + 32)

            ' Mostrar los grados en fahrenheit
            txtFarenheit.Text = resultado.ToString("F2") ' Formato con 2 decimales
        ElseIf txtFarenheit.Text <> "" AndAlso Double.TryParse(txtFarenheit.Text, farhenheit) AndAlso txtCentigrados.Text = "" Then
            ' Calcular de fahrenheit a centigrados
            resultado = (farhenheit - 32) * 5 / 9

            ' Mostrar los grados en centigrados
            txtCentigrados.Text = resultado.ToString("F2") ' Formato con 2 decimales
        Else
            ' Mostrar un mensaje de error si el dato introducido no es válido o no se ha reseteado los textboxs
            MessageBox.Show("Por favor, introduce un valor numérico válido ó haz click en Resetear.")
        End If
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        txtFarenheit.Text = ""
        txtCentigrados.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
