Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim oconexion As New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        oconexion.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbempresas.mdb;")
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        Dim ocomando = New OleDbCommand("Select * from tbempresas", oconexion)
        Dim odatareader As OleDbDataReader

        oconexion.Open()
        MessageBox.Show("connection sucsesfull")
        odatareader = ocomando.ExecuteReader

        odatareader.Read()
        'Recorremos lo almacenado con un while para mostrar en un dataview'
        TextBox1.Text = odatareader("nombre")
        TextBox2.Text = odatareader("direccion")
        TextBox3.Text = odatareader("telefono")

        oconexion.Close()
    End Sub
End Class
