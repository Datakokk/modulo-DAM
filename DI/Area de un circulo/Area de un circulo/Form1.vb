Public Class Form1


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Declarar una variable para el radio
        Dim radio As Double

        If Double.TryParse(txtRadio.Text, radio) Then
            ' Calcular el área (Área = π * radio^2)
            Dim area As Double = Math.PI * Math.Pow(radio, 2)

            ' Mostrar el área en lblArea
            txtArea.Visible = True
            txtArea.Text = area.ToString("F2") ' Formato con 2 decimales
        Else
            ' Mostrar un mensaje de error si el radio no es válido
            MessageBox.Show("Por favor, introduce un valor numérico válido para el radio.")
        End If
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        txtArea.Text = ""
        txtRadio.Text = ""
        txtArea.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub


End Class