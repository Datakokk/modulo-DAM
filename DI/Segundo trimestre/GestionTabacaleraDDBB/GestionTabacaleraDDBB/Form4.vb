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
        Dim ofila As DataRow
        Dim enc As Boolean = False

        ' Verificar si el nombre ya existe en la tabla
        For Each fila As DataRow In odataset.Tables("tbTabaqueras").Rows
            If fila("Nombre").ToString() = txtNombreTabaquera.Text Then
                MessageBox.Show("El nombre ya existe, por favor pruebe con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                enc = True
                Exit For
            End If
        Next

        ' Solo insertar si no hay duplicados
        If Not enc Then
            ofila = odataset.Tables("tbTabaqueras").NewRow
            ofila("Nombre") = txtNombreTabaquera.Text
            ofila("Direccion") = txtDireccionTabaquera.Text

            odataset.Tables("tbTabaqueras").Rows.Add(ofila)

            ' Intentar actualizar la base de datos
            Try
                oconexion.Open()
                tabaquerasAdapter.Update(odataset, "tbTabaqueras")
                oconexion.Close()

                txtNombreTabaquera.Clear()
                txtDireccionTabaquera.Clear()

                MessageBox.Show("Se ha dado de alta correctamente la tabaquera", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error No se ha podido dar de alta la tabaquera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAltaMarca_Click(sender As Object, e As EventArgs) Handles btnAltaMarca.Click
        Dim ofila As DataRow
        Dim enc As Boolean = False

        ' Verificar si el nombre ya existe en la tabla
        For Each fila As DataRow In odataset.Tables("tbMarcas").Rows
            If fila("nombre_marca").ToString() = txtNombreMarca.Text Then
                MessageBox.Show("El nombre ya existe, por favor pruebe con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                enc = True
                Exit For
            End If
        Next

        ' Solo insertar si no hay duplicados
        If Not enc Then
            ofila = odataset.Tables("tbMarcas").NewRow
            ofila("nombre_marca") = txtNombreMarca.Text
            ofila("Nombretb") = txtNombreTabaquera.Text
            ofila("Nº_Cigarrillos") = txtNCigarrillos.Text
            ofila("Nicotina") = txtNicotina.Text
            ofila("Precio") = txtPrecio.Text
            ofila("Foto") = txtFoto.Text

            odataset.Tables("tbMarcas").Rows.Add(ofila)

            ' Intentar actualizar la base de datos
            Try
                oconexion.Open()
                tabaquerasAdapter.Update(odataset, "tbMarcas")
                oconexion.Close()

                txtNombreTabaquera.Clear()
                txtDireccionTabaquera.Clear()

                MessageBox.Show("Se ha dado de alta correctamente la marca", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error No se ha podido dar de alta la marca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        formulario3.Show()
    End Sub

End Class