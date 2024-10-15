Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim capital As Double
        Dim interes As Double
        Dim tiempo As Double
        Dim capitalAcumulado As Double
        Dim cuotaMensual As Double

        If txtCapital.Text <> "" AndAlso Double.TryParse(txtCapital.Text, capital) AndAlso txtInteres.Text <> "" AndAlso Double.TryParse(txtInteres.Text, interes) AndAlso txtTiempo.Text <> "" AndAlso Integer.TryParse(txtTiempo.Text, tiempo) Then
            ' Calculamos del capital acumulado con interes compuesto
            capitalAcumulado = capital * Math.Pow((1 + (interes / 100) / 1), 1 * tiempo)

            ' Cálculo de la cuota mensual usando la fórmula de amortización
            cuotaMensual = (capital * ((interes / 100) / 12)) / (1 - Math.Pow(1 + ((interes / 100) / 12), -12 * tiempo))

            ' Mostramos el capital interes y capital acumulado
            txtCapitalAcumulado.Text = "Capital acumulado después de " + tiempo.ToString("") + " años " + capitalAcumulado.ToString("#0,0.00 €") ' Formato con 2 decimales

            ' Mostramos el capital interes y capital acumulado
            txtMensualidad.Text = cuotaMensual.ToString("#0 €")
        Else
            ' Mostrar un mensaje de error si el capital o interes no es válido
            MessageBox.Show("Por favor, introduce un valor numérico válido o que se corresponda con el casillero.")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtCapital.Text = ""
        txtInteres.Text = ""
        txtTiempo.Text = ""
        txtCapitalAcumulado.Text = ""
        txtMensualidad.Text = ""

    End Sub
End Class
