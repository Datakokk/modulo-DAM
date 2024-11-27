Module Module1
    Public variable As Date = Now
    Public valor As String

    Sub fecha()
        valor = Format(variable, "d/m/yy").ToString

        Form1.txtFecha.Visible = True
        Form1.txtHora.Visible = False
        Form1.txtFecha.Text = valor
    End Sub

    Sub hora()
        valor = Format(variable, "h:m:s")
        Form1.txtFecha.Visible = False
        Form1.txtHora.Visible = True
        Form1.txtHora.Text = valor
    End Sub
End Module
