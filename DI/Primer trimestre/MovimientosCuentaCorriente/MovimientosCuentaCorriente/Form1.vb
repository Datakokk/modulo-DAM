Public Class Form1

    Dim cantidadPago As Double
    Dim cantidadIngreso As Double
    Dim cantidadTotal As Double
    Dim saldoInicial As Double
    Dim saldoActual As Double

    Private Sub txtNumeroCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Validar si el texto es exactamente "123"
            If txtNumeroCuenta.Text.Trim() = "123" Then
                MessageBox.Show("La cuenta  es correcta")
                txtSaldoInicial.Text = "50000"
                saldoInicial = Convert.ToDouble(txtSaldoInicial.Text)
                btnPago.Enabled = True
                btnIngreso.Enabled = True
                btnBorrar.Enabled = True
                txtSaldoActual.Focus()
            Else
                MessageBox.Show("La cuenta no es correcta")
            End If
        End If
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim inputText As String
        inputText = InputBox("Introduce un valor:", "Input Box")

        ' Validar si se introdujo algún valor
        If inputText <> "" AndAlso Double.TryParse(inputText, cantidadPago) Then

            MessageBox.Show("Has introducido: " & inputText)
            cantidadTotal = saldoInicial - cantidadPago

            'Mostramos
            txtSaldoActual.Text = cantidadTotal.ToString("#0,0.00")
        Else
            MessageBox.Show("Introduce un cantidad correcta por favor.")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim inputText As String
        inputText = InputBox("Introduce un valor:", "Input Box")

        ' Validar si se introdujo algún valor
        If inputText <> "" AndAlso Double.TryParse(inputText, cantidadIngreso) Then
            MessageBox.Show("Has introducido: " & inputText)
            cantidadTotal = saldoInicial + cantidadIngreso

            'Mostramos
            txtSaldoActual.Text = cantidadTotal.ToString("#0,0.00")
        Else
            MessageBox.Show("Introduce un cantidad correcta por favor!.")
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNumeroCuenta.Text = ""
        txtSaldoActual.Text = ""
        txtSaldoInicial.Text = ""
    End Sub
End Class
