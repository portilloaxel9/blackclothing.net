Imports System.Data.SqlClient

Public Class articulos
    Private editarActivo As Boolean = False
    Sub Agregar()
        On Error GoTo Errores
        If Me.txtNombreArticulo.Text = "" Or cboxAgrupacion.Text = "" Or txtPrecio.Text = "" Then
            MsgBox("Todos los campos son requeridos.", vbCritical)
            Exit Sub
        End If

        Dim idAgrupacion As Integer
        Sql = "SELECT [ID agrupacion] FROM agrupacion WHERE [nom agrupacion] = '" & Me.cboxAgrupacion.Text & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        idAgrupacion = Instruccion.ExecuteScalar()

        Sql = "INSERT INTO articulo ([nom articulo], [ID agrupacion], [pco articulo]) VALUES ('" & Me.txtNombreArticulo.Text & "', '" & idAgrupacion & "', '" & txtPrecio.Text & "')"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()
        MostrarArticulos()
        LimpiarCampos(Me)
        Exit Sub
Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
        txtNombreArticulo.Text = ""
        MostrarArticulos()
        listArticulos.ClearSelected()
    End Sub

    Sub Editar()
        On Error GoTo Errores

        ' Obtener el nombre del artículo seleccionado
        Dim nombreArticulo As String = Me.listArticulos.SelectedItem.ToString()

        ' Consultar los datos del artículo seleccionado
        Dim selectSql As String = "SELECT [id articulo], [nom articulo], [pco articulo], [nom agrupacion] FROM articulo INNER JOIN agrupacion ON articulo.[ID agrupacion] = agrupacion.[ID agrupacion] WHERE [nom articulo] = @nombre"
        Dim selectCmd As New SqlCommand(selectSql, DaoCon)
        selectCmd.Parameters.AddWithValue("@nombre", nombreArticulo)
        Dim reader As SqlDataReader = selectCmd.ExecuteReader()

        If reader.Read() Then
            ' Obtener los valores del artículo
            Dim idArticulo As Integer = reader("id articulo").ToString()
            Dim nomArticulo As String = reader("nom articulo").ToString()
            Dim pcoArticulo As String = reader("pco articulo").ToString()
            Dim nomAgrupacion As String = reader("nom agrupacion").ToString()

            ' Asignar los valores a los controles del formulario
            Me.txtCodigo.Text = idArticulo
            Me.txtNombreArticulo.Text = nomArticulo
            Me.txtPrecio.Text = pcoArticulo
            Me.cboxAgrupacion.Text = nomAgrupacion
            Me.cboxAgrupacion.Enabled = False
        End If

        ' Cerrar el lector de datos
        reader.Close()

        Exit Sub

Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
    End Sub

    Sub Eliminar()
        If Me.listArticulos.SelectedItem Is Nothing Then
            MsgBox("Seleccione un artículo para eliminar.", vbCritical)
            Exit Sub
        End If

        Dim articulo As String = Me.listArticulos.SelectedItem.ToString()

        Dim countSql As String = "SELECT COUNT(*) FROM movimiento WHERE [ID articulo] = (SELECT [ID articulo] FROM articulo WHERE [nom articulo] = @nombre)"
        Dim countCmd As New SqlCommand(countSql, DaoCon)
        countCmd.Parameters.AddWithValue("@nombre", articulo)
        Dim count As Integer = CInt(countCmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("El artículo " & articulo & " no puede ser eliminado porque fue utilizado en un movimiento.", vbExclamation)
            listArticulos.ClearSelected()
            Exit Sub
        End If

        Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el artículo " & articulo & "?", vbYesNo + vbQuestion)
        If respuesta = MsgBoxResult.Yes Then
            Dim sql As String = "DELETE FROM articulo WHERE [nom articulo] = @nombre"
            Dim cmd As New SqlCommand(sql, DaoCon)
            cmd.Parameters.AddWithValue("@nombre", articulo)
            cmd.ExecuteNonQuery()
        Else
            respuesta = MsgBoxResult.No
            Me.listArticulos.ClearSelected()
        End If

        MostrarArticulos()
    End Sub

    Private Sub ActualizarArticulo()
        ' Obtener el ID del artículo a actualizar
        Dim idArticulo As Integer = Integer.Parse(txtCodigo.Text)

        ' Realizar la actualización en la base de datos
        Dim updateSql As String = "UPDATE articulo SET [nom articulo] = @nombre, [pco articulo] = @precio WHERE [id articulo] = @id"
        Dim updateCmd As New SqlCommand(updateSql, DaoCon)
        updateCmd.Parameters.AddWithValue("@nombre", txtNombreArticulo.Text)
        updateCmd.Parameters.AddWithValue("@precio", txtPrecio.Text)
        updateCmd.Parameters.AddWithValue("@id", idArticulo)
        updateCmd.ExecuteNonQuery()

        ' Limpiar campos y desactivar el modo de edición
        LimpiarCampos(Me)
        editarActivo = False

        ' Actualizar la lista de artículos
        MostrarArticulos()
    End Sub

    Sub MostrarAgrupaciones()
        Dim Rs As SqlDataReader
        Me.cboxAgrupacion.Items.Clear()
        Sql = "SELECT [nom agrupacion] FROM agrupacion WHERE [nom agrupacion] LIKE '%ropa%'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.cboxAgrupacion.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Sub MostrarArticulos()
        Dim Rs As SqlDataReader
        Me.listArticulos.Items.Clear()
        Sql = "SELECT [nom articulo] FROM articulo"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.listArticulos.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Private Sub articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAgrupaciones()
        MostrarArticulos()
        Me.btnEliminar.Enabled = False
        Me.btnEditar.Enabled = False
    End Sub

    Private Sub blackclothing_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ActualizarStatus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If editarActivo Then
            ActualizarArticulo() ' Realizar actualización
            Me.cboxAgrupacion.Enabled = True
        Else
            Agregar() ' Realizar inserción
        End If
    End Sub

    Private Sub listArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listArticulos.SelectedIndexChanged
        If listArticulos.SelectedIndex >= 0 Then
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub listArticulos_DoubleClick(sender As Object, e As EventArgs) Handles listArticulos.DoubleClick
        If listArticulos.SelectedIndex >= 0 Then
            editarActivo = True
            Editar()
        End If
    End Sub

    Private Sub txtNombreArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtNombreArticulo.TextChanged
        LimitarNombre(txtNombreArticulo)
        Me.listArticulos.ClearSelected()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        LimitarPrecio(txtPrecio)
        txtPrecio.SelectionStart = txtPrecio.Text.Length()
        Me.listArticulos.ClearSelected()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarActivo = True ' Activar el modo de edición
        Editar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub txtNombreArticulo_Enter(sender As Object, e As EventArgs) Handles txtNombreArticulo.Enter
        listArticulos.ClearSelected()
    End Sub

    Private Sub txtPrecio_Enter(sender As Object, e As EventArgs) Handles txtNombreArticulo.Enter
        listArticulos.ClearSelected()
    End Sub
End Class