Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim oconexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbempresas.mdb;")
    Dim oadapter As New OleDbDataAdapter("SELECT * FROM dbempresas", oconexion)
    Dim odataset As New DataSet()
    Dim obuilder As New OleDbCommandBuilder(oadapter) 'Importante si queremos modificar /borrar/insertar/ datos
    Dim ofila As DataRow

    'Se realiza la conexion
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            oconexion.Open()
            oadapter.Fill(odataset, "tbAuxiliar")
            oconexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        DataGridView1.ClearSelection() 'Limpiamos el DatagridView para que no se repita al darle varias veces o se bloquee el boton'
        DataGridView1.DataSource = odataset 'Asignamos de donde extraemos los datos (odataset)
        DataGridView1.DataMember = "tbAuxiliar"
    End Sub

    'Boton para cargarlo en el DatagridView

End Class
