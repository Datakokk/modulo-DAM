﻿Imports System.Text.RegularExpressions

Public Class Form1
    Private Structure clientes
        Public NumeroCuenta As Integer
        Public Nombre As String
        Public Saldo As Double

    End Structure

    Dim tbUsuarios(2) As clientes
    Dim listaClientes As New List(Of clientes)
    Dim saldoActual As Double

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        For i = 0 To 2
            tbUsuarios(i).NumeroCuenta = ValidarNumero("Introduce número de cuenta", "Banco Matriz")
            tbUsuarios(i).Nombre = ValidarTexto("Introduce un nombre", "Banco Matriz")
            tbUsuarios(i).Saldo = ValidarNumero("Introduce tu saldo Inicial", "Banco Matriz")
            listaClientes.Add(New clientes With {
                              .NumeroCuenta = tbUsuarios(i).NumeroCuenta,
                              .Nombre = tbUsuarios(i).Nombre,
                              .Saldo = tbUsuarios(i).Saldo
                })
        Next

        btnPago.Enabled = True
        btnIngreso.Enabled = True
        btnCliente.Enabled = True
        btnCargar.Enabled = False
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim cuentaEncontrada As Boolean
        Dim numCuenta As Decimal
        btnCliente.Enabled = True


        If Decimal.TryParse(txtNumeroCuenta.Text, numCuenta) Then
            For Each cliente As clientes In listaClientes
                If cliente.NumeroCuenta = numCuenta Then
                    txtNumeroCuenta.Text = cliente.NumeroCuenta.ToString()
                    txtNombre.Text = cliente.Nombre
                    txtSaldoInicial.Text = cliente.Saldo.ToString()
                    saldoActual = cliente.Saldo
                    txtSaldoActual.Text = cliente.Saldo.ToString()
                    cuentaEncontrada = True
                End If
            Next

            If Not cuentaEncontrada Then
                MessageBox.Show("Error, cuenta no encontrada", "Banco Matriz")
            End If
        Else
            MessageBox.Show("Inserte un numero por favor!")
        End If
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim cantidad As Double
        cantidad = InputBox("Introduce cantidad", "Banco Matriz")
        saldoActual -= cantidad

        txtSaldoActual.Text = saldoActual.ToString()
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim cantidad As Double
        cantidad = InputBox("Introduce cantidad", "Banco Matriz")
        saldoActual += cantidad

        txtSaldoActual.Text = saldoActual.ToString()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Function ValidarNumero(message As String, messageTitle As String)
        Dim cantidad As Decimal
        Dim input As String

        Do
            input = InputBox(message, messageTitle)

            If Not Decimal.TryParse(input, cantidad) OrElse cantidad < 0 Then
                MessageBox.Show("Por favor introduce un número valido y positivo")
            End If

        Loop Until Decimal.TryParse(input, cantidad) AndAlso cantidad >= 0
        Return cantidad
    End Function

    Private Function ValidarTexto(message As String, messageTitle As String)
        Dim nombre As String

        Do
            nombre = InputBox(message, messageTitle)
            If String.IsNullOrWhiteSpace(nombre) Then
                MessageBox.Show("El nombre no puede estar vacio, Error de entrada")
            ElseIf Not Regex.IsMatch(nombre, "^[a-zA-Z\s]+$") Then
                MessageBox.Show("El nombre solo puede hacer contener letra y espacios")
            End If
        Loop Until Not String.IsNullOrWhiteSpace(nombre) AndAlso Regex.IsMatch(nombre, "^[a-zA-Z\s]+$")
        Return nombre
    End Function

End Class
