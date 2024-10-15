Public Class Form1

    Dim cantidad As Integer 
    Dim precioUnitatio As Double
    Dim precioCliente As Double 
    Dim precioTotal As New List(Of Double)

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Text = ""
        txtConcepto.Text = ""
        txtPU.Text = ""
        txtDTO.Text = ""
        txtPVP.Text = ""
        txtTotal.Text = ""
        precioCliente = 0
        
    End Sub

     Private Sub txtPU_TextChanged(sender As Object, e As EventArgs) Handles txtPU.TextChanged
      
         ' Validar si el texto es numérico y correcto
        If txtConcepto.Text <> "" Then
            ' Verificar si la cantidad es un número válido
            If Integer.TryParse(txtCantidad.Text.Trim(), cantidad) Then
                ' Verificar si el precio unitario es un número válido
                If Double.TryParse(txtPU.Text, precioUnitatio) Then
                
                    ' Calcula el precio segun la cantidad
                    Select Case cantidad
                        Case 1
                            'Asignamos el precioUnitario al precioCliente ya que no hay descuento
                            precioCliente = precioUnitatio
                            txtDTO.Text = "0%"
                        Case 2, 3
                            'Realizamos el calculo segun el porcentaje 3%
                            precioCliente = (precioUnitatio * cantidad) - ((precioUnitatio * cantidad) * 0.03)
                            txtDTO.Text = "3%"
                        Case 4, 5, 6, 7
                             'Realizamos el calculo segun el porcentaje 7%
                            precioCliente = (precioUnitatio * cantidad) - ((precioUnitatio * cantidad) * 0.07)
                            txtDTO.Text = "7%"
                        Case Else
                             'Realizamos el calculo segun el porcentaje 15%
                            precioCliente = (precioUnitatio * cantidad) - ((precioUnitatio * cantidad) * 0.15)
                            txtDTO.Text = "15%"
                    End Select
                    'Mostramos en el cmapo de texto de PVP
                     txtPVP.Text = precioCliente.ToString("0#,0.00")

                    'Agregamos el precioCliente a la Lista precioTotal
                    precioTotal.Add(precioCliente)
                 Else
                    MessageBox.Show("Introduce un precio unitario correcto.")
                End If
            Else
                MessageBox.Show("Introduce una cantidad correcta.")
            End If
        Else
            MessageBox.Show("El campo concepto no puede estar vacío.")
        End If
       
    End Sub


    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
       
        txtTotal.Visible = True
        lblTotal.Visible = True
        'Con este bucle sumamos los elementos de la lista precioTotal
        Dim suma As Double = 0
        For Each numero As Double In precioTotal 
            suma += numero
        Next
        'Mostramos la cantidad Total
        txtTotal .Text = suma.ToString("0#,0.00")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
