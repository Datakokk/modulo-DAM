Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim oconexion As New OleDbConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        oconexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbbanco.accdb;")
    End Sub
    Private Sub btnVover_Click(sender As Object, e As EventArgs) Handles btnVover.Click
        Me.Hide()
        formulario1.Show()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

    End Sub


End Class