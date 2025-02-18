Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim oconexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbtabaqueras.accdb;")
    Dim tabaquerasAdapter As New OleDbDataAdapter("SELECT * FROM tbtabaqueras", oconexion)
    Dim marcasAdapter As New OleDbDataAdapter("SELECT * FROM tbmarcas", oconexion)
    Dim pedidosAdapter As New OleDbDataAdapter("SELECT * FROM tbpedidos", oconexion)
    Dim odataset As New DataSet()
    Dim obuilder As New OleDbCommandBuilder(pedidosAdapter) 'Importante si queremos modificar /borrar/insertar/ datos

    Dim precioCajetilla As Double
    Dim marcaCajetilla As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'BorrarRegistroYResetearID()
        Try
            oconexion.Open()
            tabaquerasAdapter.Fill(odataset, "tbTabaqueras")
            marcasAdapter.Fill(odataset, "tbMarcas")
            pedidosAdapter.Fill(odataset, "tbpedidos")
            oconexion.Close()

            MsgBox("Conexión exitosa a la base de datos,  Ok!!", MsgBoxStyle.Information, "Estado de Conexión")

            LlenarComboBoxTabaqueras()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error de Conexión")
        End Try
    End Sub

    Private Sub CBoxTabaqueras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxTabaqueras.SelectedIndexChanged
        Dim i As Integer
        Dim expression As String
        Dim filaencontrada() As DataRow
        Try
            LBoxMarcas.Items.Clear()

            expression = "Nombretb = '" & CBoxTabaqueras.SelectedItem.ToString() & "'"
            filaencontrada = Me.odataset.Tables("tbmarcas").Select(expression)

            If filaencontrada.GetUpperBound(0) <> -1 Then
                For i = 0 To filaencontrada.GetUpperBound(0)
                    Me.LBoxMarcas.Items.Add(filaencontrada(i).Item("nombre_marca"))
                Next i
            Else
                MsgBox("Error, no existe")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las marcas: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LBoxMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxMarcas.SelectedIndexChanged
        Dim i As Integer
        Dim expression As String
        Dim filaencontrada() As DataRow
        Try
            expression = "nombre_marca = '" & LBoxMarcas.SelectedItem.ToString() & "'"
            filaencontrada = Me.odataset.Tables("tbmarcas").Select(expression)

            If filaencontrada.GetUpperBound(0) <> -1 Then
                For i = 0 To filaencontrada.GetUpperBound(0)
                    Me.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\MARCAS_CIGARROS\" & filaencontrada(i).Item("Foto"))
                    Me.txtNumCigarrillos.Text = filaencontrada(i).Item("Nº_Cigarrillos")
                    Me.txtNicotina.Text = filaencontrada(i).Item("Nicotina")
                    Me.txtPrecio.Text = filaencontrada(i).Item("Precio")
                    precioCajetilla = CDbl(filaencontrada(i).Item("Precio"))
                    marcaCajetilla = filaencontrada(i).Item("nombre_marca")

                Next i
            Else
                MsgBox("Error, no existe")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las marcas: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnRealizarPedido_Click(sender As Object, e As EventArgs) Handles btnRealizarPedido.Click
        Dim ofila As DataRow
        Dim cantidad As Double = Convert.ToDouble(NumericUpDownUnidades.Value)
        Dim precio_venta As Double

        If CheckBoxCartones.Checked Then
            precio_venta = cantidad * Convert.ToDouble(precioCajetilla) * 10
        Else
            cantidad = NumericUpDownUnidades.Value
            precio_venta = cantidad * Convert.ToDouble(precioCajetilla)
        End If

        ofila = odataset.Tables("tbpedidos").NewRow
        ofila("Nombre_marca") = marcaCajetilla
        ofila("cantidad") = cantidad
        ofila("total") = precio_venta

        odataset.Tables("tbpedidos").Rows.Add(ofila)

        ' Intentar actualizar la base de datos
        Try
            oconexion.Open()
            pedidosAdapter.Update(odataset, "tbpedidos")
            oconexion.Close()

            MessageBox.Show("Pedido realizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Recargamos el Dataset para obtener el cambio en la tabla
            odataset.Tables("tbpedidos").Clear()
            pedidosAdapter.Fill(odataset, "tbpedidos")

        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CargarIdPedidos()
        'MsgBox("EL TOTAL ES ... " & SumarPedidos().ToString, MsgBoxStyle.Information, "Examen_1EVA_2DAM")
        MsgBox("Marca: " & marcaCajetilla & " Cantidad: " & cantidad.ToString & " Precio: " & precio_venta & " Total: " & SumarPedidos().ToString("F2"))
    End Sub

    Private Sub btnBorrarPedido_Click(sender As Object, e As EventArgs) Handles btnBorrarPedido.Click
        Dim fila As DataRow
        If LBoxPedidos.SelectedItem Is Nothing Then
            MsgBox("Seleccione un pedido para borrar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        For Each fila In odataset.Tables("tbpedidos").Rows
            If fila("Id_pedido").ToString = LBoxPedidos.SelectedItem.ToString Then
                fila.Delete()
                oconexion.Open()
                pedidosAdapter.Update(odataset, "tbpedidos")
                oconexion.Close()
                Exit For
            End If
        Next

        Try
            oconexion.Open()
            pedidosAdapter.Update(odataset, "tbpedidos")
            oconexion.Close()

            MessageBox.Show("Se ha eliminado el pedido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Recargamos el Dataset para obtener el cambio en la tabla
            odataset.Tables("tbpedidos").Clear()
            pedidosAdapter.Fill(odataset, "tbpedidos")

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el pedido: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CargarIdPedidos()
    End Sub
    Private Sub LlenarComboBoxTabaqueras()
        Try
            CBoxTabaqueras.Items.Clear()

            For Each fila In odataset.Tables("tbTabaqueras").Rows
                CBoxTabaqueras.Items.Add(fila.Item("Nombre").ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LlenarListBoxMarcas()
        Try
            LBoxMarcas.Items.Clear()

            For Each fila In odataset.Tables("tbMarcas").Rows
                LBoxMarcas.Items.Add(fila.Item("nombre_marca").ToString)
            Next
        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CargarIdPedidos()
        Try
            oconexion.Open()
            pedidosAdapter.Update(odataset, "tbpedidos")
            oconexion.Close()

            LBoxPedidos.Items.Clear()

            For Each fila In odataset.Tables("tbpedidos").Rows
                LBoxPedidos.Items.Add(fila("Id_pedido").ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al llenar el LBoxPedidos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        formulario2.Show()
    End Sub
    Private Sub BorrarRegistroYResetearID()
        Try
            oconexion.Open()

            Dim borrarRegistros As New OleDbCommand("DELETE FROM tbpedidos", oconexion)
            Dim filasEliminadas As Integer = borrarRegistros.ExecuteNonQuery()

            '  Verificar si la tabla está vacía antes de resetear el ID
            Dim verificarVacio As New OleDbCommand("SELECT COUNT(*) FROM tbpedidos", oconexion)
            Dim cantidadRegistros As Integer = Convert.ToInt32(verificarVacio.ExecuteScalar())

            ' Ejecutamos ALTER TABLE si la tabla está completamente vacía
            If cantidadRegistros = 0 Then
                Dim resetComando As New OleDbCommand("ALTER TABLE tbpedidos ALTER COLUMN Id_pedido COUNTER (1,1);", oconexion)
                resetComando.ExecuteNonQuery()
            End If

            oconexion.Close()

            If odataset.Tables.Contains("tbpedidos") Then
                odataset.Tables("tbpedidos").Clear()
            End If
            LBoxPedidos.Items.Clear()

            MsgBox("Pedidos eliminados y contador reiniciado.", MsgBoxStyle.Information, "Éxito")

        Catch ex As Exception
            MsgBox("Error al limpiar pedidos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SumarPedidos() As Double
        Dim total As Double

        Try
            oconexion.Open()
            Dim consulta As String = "SELECT SUM(total) AS Total FROM tbpedidos"
            Dim comando As New OleDbCommand(consulta, oconexion)

            Dim resultado As Object = comando.ExecuteScalar()
            If Not IsDBNull(resultado) Then
                total = Convert.ToDouble(resultado)
            End If
            oconexion.Close()
        Catch ex As Exception
            MsgBox("Error al calcular la suma: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return total
    End Function
End Class
