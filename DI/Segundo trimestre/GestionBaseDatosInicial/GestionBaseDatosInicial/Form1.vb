Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim oconexion As New OleDbConnection
    Private Sub bntConectar_Click(sender As Object, e As EventArgs) Handles bntConectar.Click
        oconexion.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbempresas.mdb;")
        MessageBox.Show("connection sucsesfull")
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim ocomando = New OleDbCommand("Select * from tbempresas", oconexion)
        Dim odatareader As OleDbDataReader
        Dim dt As New DataTable

        oconexion.Open()
        odatareader = ocomando.ExecuteReader

        dt.Load(odatareader)

        DataGridView1.DataSource = dt
        odatareader.Close()

        oconexion.Close()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'Dim icomando = New OleDbCommand("INSERT INTO tbempresas(nombre,direccion,telefono) VALUES ('Fernando','general 3222', '89898')", oconexion)'
        Dim icomando = New OleDbCommand("INSERT INTO tbempresas(nombre,direccion,telefono) VALUES (@A,@B,@)", oconexion)
        icomando.Parameters.AddWithValue(“@A”, txtNombre.Text)
        icomando.Parameters.AddWithValue(“@B”, txtDireccion.Text)
        icomando.Parameters.AddWithValue(“@C”, txtTelefono.Text)


        oconexion.Open()
        icomando.ExecuteNonQuery()
        oconexion.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bcomando = New OleDbCommand("Select * From tbempresas WHERE nombre='Fernando'", oconexion)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        odatareader = bcomando.ExecuteReader
        If (odatareader.Read()) Then
            txtNombre.Text = odatareader("nombre")
            txtDireccion.Text = odatareader("direccion")
            txtTelefono.Text = odatareader("telefono")
        Else
            MessageBox.Show("El elemento buscado no existe")
        End If
        oconexion.Close()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim dcomando = New OleDbCommand("DELETE FROM tbempresas WHERE nombre='Fernando'", oconexion)

        oconexion.Open()
        dcomando.ExecuteNonQuery()
        oconexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
