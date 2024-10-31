Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim resultado As String = ""
        'Comprobamos los radiobutton que estan seleccionados
        If rb_i3.Checked Then
            resultado &= "Procesador: i3  " & vbCrLf
        ElseIf rb_i5.Checked Then
            resultado &= "Procesador: i5  " & vbCrLf
        ElseIf rb_i7.Checked Then
            resultado &= "Procesador: i7  " & vbCrLf
        End If

        If rb_8GB.Checked Then
            resultado &= "RAM: 8GB  " & vbCrLf
        ElseIf rb_12GB.Checked Then
            resultado &= "RAM: 12GB  " & vbCrLf
        ElseIf rb_16GB.Checked Then
            resultado &= "RAM: 16GB  " & vbCrLf
        End If

        If rb_500GB.Checked Then
            resultado &= "Disco: 500GB  " & vbCrLf
        ElseIf rb_1TB.Checked Then
            resultado &= "Disco: 1TB  " & vbCrLf
        ElseIf rb_2TB.Checked Then
            resultado &= "Disco: 2TB  " & vbCrLf
        End If

        ' Comprobamos que Checked estan seleccionados
        If cbDVD.Checked Then
            resultado &= "Opción: DVD  " & vbCrLf
        End If

        If cbAudio.Checked Then
            resultado &= "Opción: Audio  " & vbCrLf
        End If

        If cbAltavoces.Checked Then
            resultado &= "Opción: Altavoces  " & vbCrLf
        End If

        If cbImpresora.Checked Then
            resultado &= "Opción: Impresora  " & vbCrLf
        End If

        'Mostramos el resultado
        txtMostrar.Text = resultado

    End Sub
End Class
