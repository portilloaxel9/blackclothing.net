Imports System.Data.SqlClient

Public Class articulos
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
    End Sub

    Sub Editar()
        On Error GoTo Errores
        Dim Rs As SqlDataReader
        Sql = "SELECT [nom articulo], [pco articulo], [nom agrupacion] FROM articulo INNER JOIN agrupacion ON articulo.[ID agrupacion] = agrupacion.[ID agrupacion] WHERE [nom articulo] = '" & Me.listArticulos.SelectedItem.ToString() & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        If Rs.Read() Then
            Me.txtNombreArticulo.Text = Rs("nom articulo").ToString()
            Me.txtPrecio.Text = Rs("pco articulo").ToString()
            Me.cboxAgrupacion.Text = Rs("nom agrupacion").ToString()
        End If
        Rs.Close()
        Sql = "DELETE FROM articulo WHERE [nom articulo] = '" & Me.listArticulos.SelectedItem.ToString() & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()
        MostrarArticulos()
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

        Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el artículo " & articulo & "?", vbYesNo + vbQuestion)
        If respuesta = MsgBoxResult.Yes Then
            Dim sql As String = "DELETE FROM articulo WHERE [nom articulo] = @nombre"
            Dim cmd As New SqlCommand(sql, DaoCon)
            cmd.Parameters.AddWithValue("@nombre", articulo)
            cmd.ExecuteNonQuery()
        Else respuesta = MsgBoxResult.No
            Me.listArticulos.ClearSelected()
        End If
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
    End Sub

    Private Sub blackclothing_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ActualizarStatus()
    End Sub

    Private Sub articulos_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub listArticulos_SelectedIndexChanged(sender As Object, e As EventArgs)
        MostrarArticulos()
    End Sub

    Private Sub txtNombreArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtNombreArticulo.TextChanged
        LimitarNombre(txtNombreArticulo)
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        LimitarPrecio(txtPrecio)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub
End Class