Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim oconexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbempresas.mdb;")
    Dim oadapter As New OleDbDataAdapter("SELECT * FROM tbempresas", oconexion)
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

    'Boton para cargarlo en el DatagridView
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        DataGridView1.ClearSelection() 'Limpiamos el DatagridView para que no se repita al darle varias veces o se bloquee el boton'
        DataGridView1.DataSource = odataset 'Asignamos de donde extraemos los datos (odataset)
        DataGridView1.DataMember = "tbAuxiliar"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        oconexion.Open()
        oadapter.Update(odataset, "tbAuxiliar")
        oconexion.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtNombre.Text = odataset.Tables("tbAuxiliar").Rows(e.RowIndex).Item("nombre")
        txtDireccion.Text = odataset.Tables("tbAuxiliar").Rows(e.RowIndex).Item("direccion")
        txtTelefono.Text = odataset.Tables("tbAuxiliar").Rows(e.RowIndex).Item("telefono")
    End Sub

    Private Sub btnRecorrer_Click(sender As Object, e As EventArgs) Handles btnRecorrer.Click
        If DataGridView1.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                If Not Fila Is Nothing Then
                    For Each Celda As DataGridViewCell In Fila.Cells
                        If Not Celda.Value Is Nothing Then
                            MsgBox(Celda.Value)
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub btnMostrarNombre_Click(sender As Object, e As EventArgs) Handles btnMostrarNombre.Click
        If DataGridView1.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                'Fila.Cells.Item("columna").Value

                If Not Fila.Cells.Item("nombre").Value Is Nothing Then
                    MsgBox(Fila.Cells.Item("nombre").Value)
                End If

            Next
        End If
    End Sub

    Private Sub btnInsertDDBB_Click(sender As Object, e As EventArgs) Handles btnInsertDDBB.Click
        ofila = odataset.Tables("tbAuxiliar").NewRow

        If txtNombre.Text.Length > 0 And txtDireccion.Text.Length > 0 And txtTelefono.Text.Length > 0 Then
            ofila("nombre") = txtNombre.Text
            ofila("direccion") = txtDireccion.Text
            ofila("telefono") = txtTelefono.Text

            odataset.Tables("tbAuxiliar").Rows.Add(ofila)

            oconexion.Open()
            oadapter.Update(odataset, "tbAuxiliar")
            oconexion.Close()
        Else
            MsgBox("No puede haber un campo vacio")
        End If

        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

    End Sub
End Class
