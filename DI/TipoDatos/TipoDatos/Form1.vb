Public Class Form1
    Private Sub btnTipoDatos_Click(sender As Object, e As EventArgs) Handles btnTipoDatos.Click
        Dim boleana As Boolean = False
        Dim bytes As Byte = 101
        Dim caracter As Char = "a"
        Dim fechas_hora As Date
        Dim con_decimal As Decimal = 10.23
        Dim entera As Integer = 32000
        Dim doble As Double = 65498704
        Dim larga As Long = 765243981
        Dim corta As Short = 27000
        Dim cadena As String = "Hello everbody"

        'Asignar el valor de cada variable a los campos de texto'
        txtcampo1.Text = boleana
        txtcampo2.Text = bytes
        txtcampo3.Text = caracter
        txtcampo4.Text = fechas_hora
        txtcampo5.Text = con_decimal
        txtcampo6.Text = doble
        txtcampo7.Text = entera
        txtcampo8.Text = larga
        txtcampo9.Text = corta
        txtcampo10.Text = cadena
    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        End
    End Sub
End Class
