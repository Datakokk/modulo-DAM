Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Dim oconexion As New OleDbConnection
    Dim saldoActual As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        oconexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbbanco.accdb;")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bcomando = New OleDbCommand("Select tbcuentas.Saldo, tbdatos.Nombre From tbdatos 
                                            INNER JOIN tbcuentas ON tbdatos.Numero_cuenta = tbcuentas.Numero_cuenta 
                                            WHERE tbdatos.Numero_cuenta=@A", oconexion)
        bcomando.Parameters.AddWithValue(“@A”, txtNumeroCuenta.Text)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        odatareader = bcomando.ExecuteReader
        If (odatareader.Read()) Then
            saldoActual = odatareader("Saldo")
            txtSaldoInicial.Text = odatareader("Saldo")
            txtNombre.Text = odatareader("Nombre")

        Else
            MessageBox.Show("El elemento buscado no existe")
        End If
        oconexion.Close()
    End Sub

    Private Sub btnIngresos_Click(sender As Object, e As EventArgs) Handles btnIngresos.Click
        Dim cantidad As Double
        cantidad = InputBox("Introduce cantidad", "DB Banco")
        saldoActual += cantidad

        txtSaldoActual.Text = saldoActual.ToString()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        Dim cantidad As Double
        cantidad = InputBox("Introduce cantidad", "DB Banco")
        saldoActual -= cantidad

        txtSaldoActual.Text = saldoActual.ToString()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ocomando = New OleDbCommand("UPDATE tbcuentas SET Saldo = @A WHERE Numero_cuenta = @B;", oconexion)
        ocomando.Parameters.AddWithValue("@A", txtSaldoActual.Text)
        ocomando.Parameters.AddWithValue("@B", txtNumeroCuenta.Text)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        odatareader = ocomando.ExecuteReader
        oconexion.Close()
        saldoActual = 0
        txtNombre.Clear()
        txtSaldoInicial.Clear()
        txtSaldoActual.Clear()
        txtNumeroCuenta.Clear()

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        formulario1.Show()
    End Sub
End Class
