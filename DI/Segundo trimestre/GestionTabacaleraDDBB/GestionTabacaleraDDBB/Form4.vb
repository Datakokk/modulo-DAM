Imports System.Data.OleDb
Imports System.Data
Public Class Form4
    Dim oconexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbtabaqueras.accdb;")
    Dim tabaquerasAdapter As New OleDbDataAdapter("SELECT * FROM tbtabaqueras", oconexion)
    Dim marcasAdapter As New OleDbDataAdapter("SELECT * FROM tbmarcas", oconexion)
    Dim odataset As New DataSet()
    Dim obuilderTabaqueras As New OleDbCommandBuilder(tabaquerasAdapter) 'Importante si queremos modificar /borrar/insertar/ datos
    Dim obuilderMarcas As New OleDbCommandBuilder(marcasAdapter) 'Importante si queremos modificar /borrar/insertar/ datos

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            oconexion.Open()
            tabaquerasAdapter.Fill(odataset, "tbTabaqueras")
            marcasAdapter.Fill(odataset, "tbMarcas")
            oconexion.Close()

            MsgBox("Conexión exitosa a la base de datos,  Ok!!", MsgBoxStyle.Information, "Estado de Conexión")

        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error de Conexión")
        End Try
    End Sub
    Private Sub btnAltaTabaquera_Click(sender As Object, e As EventArgs) Handles btnAltaTabaquera.Click

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        formulario3.Show()
    End Sub


End Class