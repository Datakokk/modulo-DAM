Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim oconexion As New OleDbConnection
    Dim id As Integer = 331
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        oconexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbbanco.accdb;")
    End Sub
    Private Sub btnVover_Click(sender As Object, e As EventArgs) Handles btnVover.Click
        Me.Hide()
        formulario1.Show()
        lblIntroCuenta.Visible = False
        txtIntroCuenta.Visible = False
        btnPresioneActualizar.Visible = False
        btnPresioneAlta.Visible = False
        btnPresioneActualizar.Visible = False
        lblIntroDireccion.Visible = False
        lblIntroNombre.Visible = False
        lblIntroSaldo.Visible = False
        lblIntroTelefono.Visible = False
        txtIntroDireccion.Visible = False
        txtIntroNombre.Visible = False
        txtIntroTelefono.Visible = False
        txtIntroSaldo.Visible = False
        btnBuscar.Visible = False
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        lblIntroCuenta.Visible = False
        txtIntroCuenta.Visible = False
        btnPresioneActualizar.Visible = False
        btnPresioneAlta.Visible = True
        btnPresioneActualizar.Visible = True
        lblIntroDireccion.Visible = True
        lblIntroNombre.Visible = True
        lblIntroSaldo.Visible = True
        lblIntroTelefono.Visible = True
        txtIntroDireccion.Visible = True
        txtIntroNombre.Visible = True
        txtIntroTelefono.Visible = True
        txtIntroSaldo.Visible = True
        txtIntroSaldo.Enabled = True
        btnBuscar.Visible = False
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        lblIntroCuenta.Visible = True
        txtIntroCuenta.Visible = True
        btnPresioneAlta.Visible = False
        btnPresioneActualizar.Visible = True
        lblIntroDireccion.Visible = True
        lblIntroNombre.Visible = True
        lblIntroSaldo.Visible = True
        lblIntroTelefono.Visible = True
        txtIntroDireccion.Visible = True
        txtIntroNombre.Visible = True
        txtIntroTelefono.Visible = True
        txtIntroSaldo.Visible = True
        txtIntroSaldo.Enabled = False
        btnBuscar.Visible = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bcomando = New OleDbCommand("Select tbcuentas.Saldo, tbdatos.Nombre, tbdatos.Direccion, tbdatos.Telefono From tbdatos 
                                            INNER JOIN tbcuentas ON tbdatos.Numero_cuenta = tbcuentas.Numero_cuenta 
                                            WHERE tbdatos.Numero_cuenta=@A", oconexion)
        bcomando.Parameters.AddWithValue("@A", txtIntroCuenta.Text)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        odatareader = bcomando.ExecuteReader
        If (odatareader.Read()) Then
            txtIntroSaldo.Text = odatareader("Saldo")
            txtIntroDireccion.Text = odatareader("Direccion")
            txtIntroNombre.Text = odatareader("Nombre")
            txtIntroTelefono.Text = odatareader("Telefono")
        Else
            MessageBox.Show("El elemento buscado no existe")
        End If
        oconexion.Close()
    End Sub

    Private Sub btnPresioneActualizar_Click(sender As Object, e As EventArgs) Handles btnPresioneActualizar.Click
        Dim ocomando = New OleDbCommand("UPDATE tbdatos SET Nombre, Direccion, Telefono WHERE Numero_cuenta = @A;", oconexion)
        ocomando.Parameters.AddWithValue("@A", txtIntroCuenta.Text)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        odatareader = ocomando.ExecuteReader
        oconexion.Close()

        txtIntroNombre.Clear()
        txtIntroSaldo.Clear()
        txtIntroDireccion.Clear()
        txtIntroTelefono.Clear()
        txtIntroCuenta.Clear()
    End Sub

    Private Sub btnPresioneAlta_Click(sender As Object, e As EventArgs) Handles btnPresioneAlta.Click
        Dim icomando = New OleDbCommand("INSERT INTO tbdatos(Id, Nombre,Direccion,Telefono) VALUES ('@A','@B', '@C', '@D')", oconexion)
        Dim ucomando = New OleDbCommand("INSERT INTO tbcuentas(Id, Saldo) VALUES ('@E','@F')", oconexion)
        icomando.Parameters.AddWithValue("@A", id)
        icomando.Parameters.AddWithValue("@B", txtIntroNombre)
        icomando.Parameters.AddWithValue("@C", txtIntroDireccion)
        icomando.Parameters.AddWithValue("@D", txtIntroTelefono)
        ucomando.Parameters.AddWithValue("@E", id)
        ucomando.Parameters.AddWithValue("@F", txtIntroSaldo)
        oconexion.Open()
        icomando.ExecuteNonQuery()
        ucomando.ExecuteNonQuery()
        oconexion.Close()
    End Sub
End Class