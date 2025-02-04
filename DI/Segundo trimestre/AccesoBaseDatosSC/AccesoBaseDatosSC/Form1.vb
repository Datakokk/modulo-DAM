Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim oconexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbempresas.mdb;")
    Dim odataadapter As New OleDbDataAdapter("SELECT * FROM tbempresas", oconexion)
    Dim odataset As New DataSet
    Dim obuilder As New OleDbCommandBuilder(odataadapter)

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            ' Abrir la conexión
            oconexion.Open()
            odataadapter.Fill(odataset, "tb1")
            MsgBox("Conexión exitosa a la base de datos,  Ok!!", MsgBoxStyle.Information, "Estado de Conexión")
        Catch ex As OleDbException
            ' Manejo de errores específicos de OleDb
            MsgBox("Error al conectar a la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error de Conexión")
        Catch ex As Exception
            ' Manejo de otros errores generales
            MsgBox("Se produjo un error: " & ex.Message, MsgBoxStyle.Critical, "Error General")
        Finally
            ' Asegurarse de cerrar la conexión, incluso si ocurre un error
            If oconexion.State = ConnectionState.Open Then
                oconexion.Close()
            End If
        End Try
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim ofila As DataRow
        lstNombre.Items.Clear()

        For Each ofila In odataset.Tables("tb1").Rows
            lstNombre.Items.Add(ofila.Item("Nombre"))
        Next

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim ofila As DataRow
        Dim enc As Boolean = False

        ' Verificar si el nombre ya existe en la tabla
        For Each fila As DataRow In odataset.Tables("tb1").Rows
            If fila("Nombre").ToString() = txtNombre.Text Then
                MessageBox.Show("El nombre ya existe, por favor pruebe con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                enc = True
                Exit For
            End If
        Next

        ' Solo insertar si no hay duplicados
        If Not enc Then
            ofila = odataset.Tables("tb1").NewRow
            ofila("Nombre") = txtNombre.Text
            ofila("Direccion") = txtDireccion.Text
            ofila("Telefono") = txtTelefono.Text

            odataset.Tables("tb1").Rows.Add(ofila)

            ' Intentar actualizar la base de datos
            Try
                oconexion.Open()
                odataadapter.Update(odataset, "tb1")
                oconexion.Close()

                MessageBox.Show("Se ha insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al insertar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
