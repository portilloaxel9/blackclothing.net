Imports System.Data.SqlClient

Public Class movimientos
    Sub MostrarArticulos()
        Dim Rs As SqlDataReader
        Me.cboxArticulo.Items.Clear()
        Sql = "SELECT [nom articulo] FROM articulo"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.cboxArticulo.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Sub MostrarTipoMovimiento()
        Dim Rs As SqlDataReader
        Me.cboxTipoMovimiento.Items.Clear()
        Sql = "SELECT [nom tipomovi] FROM tipomovi"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.cboxTipoMovimiento.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Sub MostrarPrecio()
        If cboxArticulo.SelectedIndex >= 0 Then
            Dim precio As Decimal

            ' Consulta para obtener el precio del artículo seleccionado
            Dim sqlPrecio As String = "SELECT [pco articulo] FROM articulo WHERE [nom articulo] = @nombreArticulo"
            Dim cmdPrecio As New SqlCommand(sqlPrecio, DaoCon)
            cmdPrecio.Parameters.AddWithValue("@nombreArticulo", cboxArticulo.Text)
            precio = CDec(cmdPrecio.ExecuteScalar())

            txtPrecio.Text = precio.ToString()
        End If
    End Sub

    Sub Agregar()
        On Error GoTo Errores
        If Me.cboxArticulo.Text = "" Or cboxTipoMovimiento.Text = "" Or txtCantidad.Text = "" Or txtObservacion.Text = "" Then
            MsgBox("Todos los campos son requeridos.", vbCritical)
            Exit Sub
        End If

        Dim idArticulo As Integer
        Dim idTipoMovimiento As Integer
        Dim fechaMovimiento = Date.Today
        Dim observacion As String = txtObservacion.Text
        Dim cantidad As Integer = CInt(txtCantidad.Text)
        Dim precio As Decimal = CDec(txtPrecio.Text)
        Dim total As Decimal = cantidad * precio

        Dim sqlArticulo As String = "SELECT [id articulo] FROM articulo WHERE [nom articulo] = @nombreArticulo"
        Dim cmdArticulo As New SqlCommand(sqlArticulo, DaoCon)
        cmdArticulo.Parameters.AddWithValue("@nombreArticulo", cboxArticulo.Text)
        idArticulo = CInt(cmdArticulo.ExecuteScalar())

        Dim sqlTipoMovimiento As String = "SELECT [id tipomovi] FROM tipomovi WHERE [nom tipomovi] = @nombreTipoMovimiento"
        Dim cmdTipoMovimiento As New SqlCommand(sqlTipoMovimiento, DaoCon)
        cmdTipoMovimiento.Parameters.AddWithValue("@nombreTipoMovimiento", cboxTipoMovimiento.Text)
        idTipoMovimiento = CInt(cmdTipoMovimiento.ExecuteScalar())

        Dim sql As String = "INSERT INTO movimiento ([id articulo], [id tipomovi], [fec movimiento], [obs movimiento], [can movimiento], [pre movimiento]) " &
                        "VALUES (@idArticulo, @idTipoMovimiento, @fechaMovimiento, @observacion, @cantidad, @total)"

        Dim cmd As New SqlCommand(sql, DaoCon)

        cmd.Parameters.AddWithValue("@idArticulo", idArticulo)
        cmd.Parameters.AddWithValue("@idTipoMovimiento", idTipoMovimiento)
        cmd.Parameters.AddWithValue("@fechaMovimiento", fechaMovimiento)
        cmd.Parameters.AddWithValue("@observacion", observacion)
        cmd.Parameters.AddWithValue("@cantidad", cantidad)
        cmd.Parameters.AddWithValue("@total", total)

        cmd.ExecuteNonQuery()
        MostrarArticulos()
        LimpiarCampos(Me)
        Exit Sub

Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
        MostrarArticulos()
    End Sub

    Private Sub movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = ObtenerFecha()
        MostrarArticulos()
        MostrarTipoMovimiento()
    End Sub

    Private Sub movimiento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ActualizarStatus()
    End Sub

    Private Sub cboxArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxArticulo.SelectedIndexChanged
        MostrarPrecio()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        LimitarPrecio(txtPrecio)
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        LimitarCantidad(txtCantidad)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos(Me)
    End Sub
End Class