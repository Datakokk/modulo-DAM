Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim oconexion As New OleDbConnection
    Dim Numero_cuenta As Integer = 331
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
        Dim ocomando = New OleDbCommand("UPDATE tbdatos SET Nombre = @A, Direccion = @B, Telefono = @C WHERE Numero_cuenta = @D;", oconexion)
        ocomando.Parameters.AddWithValue("@A", txtIntroNombre.Text)
        ocomando.Parameters.AddWithValue("@B", txtIntroDireccion.Text)
        ocomando.Parameters.AddWithValue("@C", txtIntroTelefono.Text)
        ocomando.Parameters.AddWithValue("@D", txtIntroCuenta.Text)

        oconexion.Open()
        ocomando.ExecuteNonQuery()
        oconexion.Close()

        txtIntroNombre.Clear()
        txtIntroSaldo.Clear()
        txtIntroDireccion.Clear()
        txtIntroTelefono.Clear()
        txtIntroCuenta.Clear()
    End Sub

    Private Sub btnPresioneAlta_Click(sender As Object, e As EventArgs) Handles btnPresioneAlta.Click
        Dim icomando = New OleDbCommand("INSERT INTO tbdatos(Numero_cuenta, Nombre, Direccion, Telefono) VALUES (?, ?, ?, ?)", oconexion)
        Dim ucomando = New OleDbCommand("INSERT INTO tbcuentas(Numero_cuenta, Saldo) VALUES (?, ?)", oconexion)
        icomando.Parameters.AddWithValue("?", Numero_cuenta)
        icomando.Parameters.AddWithValue("?", txtIntroNombre.Text)
        icomando.Parameters.AddWithValue("?", txtIntroDireccion.Text)
        icomando.Parameters.AddWithValue("?", txtIntroTelefono.Text)

        ucomando.Parameters.AddWithValue("?", Numero_cuenta)
        ucomando.Parameters.AddWithValue("?", txtIntroSaldo.Text)
        oconexion.Open()
        icomando.ExecuteNonQuery()
        ucomando.ExecuteNonQuery()
        oconexion.Close()

        txtIntroNombre.Clear()
        txtIntroSaldo.Clear()
        txtIntroDireccion.Clear()
        txtIntroTelefono.Clear()
        Numero_cuenta = Nothing
    End Sub
End Class