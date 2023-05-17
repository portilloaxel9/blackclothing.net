Imports System.Data.SqlClient

Public Class agrupacion
    Private editarActivo As Boolean = False
    Sub Agregar()
        On Error GoTo Errores
        If Me.txtNombreAgrupacion.Text = "" Then
            MsgBox("Todos los campos son requeridos.", vbCritical)
            Exit Sub
        End If
        Dim Sql As String = "INSERT INTO agrupacion ([nom agrupacion]) VALUES ('" & Me.txtNombreAgrupacion.Text & "')"
        Dim Instruccion As New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()
        MostrarAgrupaciones()
        LimpiarCampos(Me)
        Exit Sub
Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
        txtNombreAgrupacion.Text = ""
    End Sub

    Sub Editar()
        On Error GoTo Errores

        Dim nombreAgrupacion As String = Me.listAgrupaciones.SelectedItem.ToString()

        Dim selectSql As String = "SELECT [id agrupacion], [nom agrupacion] FROM agrupacion WHERE [nom agrupacion] = @nombre"
        Dim selectCmd As New SqlCommand(selectSql, DaoCon)
        selectCmd.Parameters.AddWithValue("@nombre", nombreAgrupacion)
        Dim reader As SqlDataReader = selectCmd.ExecuteReader()

        If reader.Read() Then
            Dim idAgrupacion As Integer = reader("id agrupacion").ToString()
            Dim nomAgrupacion As String = reader("nom agrupacion").ToString()

            Me.txtCodigo.Text = idAgrupacion
            Me.txtNombreAgrupacion.Text = nomAgrupacion
        End If
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
        If Me.listAgrupaciones.SelectedItem Is Nothing Then
            MsgBox("Seleccione una agrupación para eliminar.", vbCritical)
            Exit Sub
        End If

        Dim agrupacion As String = Me.listAgrupaciones.SelectedItem.ToString()

        Dim countSql As String = "SELECT COUNT(*) FROM articulo WHERE [ID agrupacion] = (SELECT [ID agrupacion] FROM agrupacion WHERE [nom agrupacion] = @nombre)"
        Dim countCmd As New SqlCommand(countSql, DaoCon)
        countCmd.Parameters.AddWithValue("@nombre", agrupacion)
        Dim count As Integer = CInt(countCmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("La agrupación " & agrupacion & " no puede ser eliminada porque está siendo utilizada en un articulo.", vbExclamation)
            listAgrupaciones.ClearSelected()
            Exit Sub
        End If

        Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar la agrupación " & agrupacion & "?", vbYesNo + vbQuestion)
        If respuesta = MsgBoxResult.Yes Then
            Dim sql As String = "DELETE FROM agrupacion WHERE [nom agrupacion] = @nombre"
            Dim cmd As New SqlCommand(sql, DaoCon)
            cmd.Parameters.AddWithValue("@nombre", agrupacion)
            cmd.ExecuteNonQuery()
        Else
            respuesta = MsgBoxResult.No
            Me.listAgrupaciones.ClearSelected()
        End If

        MostrarAgrupaciones()
    End Sub

    Sub MostrarAgrupaciones()
        Dim Rs As SqlDataReader
        Me.listAgrupaciones.Items.Clear()
        Dim Sql As String = "SELECT [nom agrupacion] FROM agrupacion WHERE [nom agrupacion] LIKE '%ropa%' ORDER BY [nom agrupacion]"
        Dim Instruccion As New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.listAgrupaciones.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Private Sub ActualizarAgrupacion()
        Dim idAgrupacion As Integer = Integer.Parse(txtCodigo.Text)

        Dim updateSql As String = "UPDATE agrupacion SET [nom agrupacion] = @nombre WHERE [id agrupacion] = @id"
        Dim updateCmd As New SqlCommand(updateSql, DaoCon)
        updateCmd.Parameters.AddWithValue("@nombre", txtNombreAgrupacion.Text)
        updateCmd.Parameters.AddWithValue("@id", idAgrupacion)
        updateCmd.ExecuteNonQuery()

        LimpiarCampos(Me)
        editarActivo = False

        MostrarAgrupaciones()
    End Sub

    Private Sub agrupacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos(Me)
        MostrarAgrupaciones()
        Me.btnEditar.Enabled = False
        Me.btnEliminar.Enabled = False
    End Sub

    Private Sub txtNombreAgrupacion_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAgrupacion.TextChanged
        LimitarNombre(txtNombreAgrupacion)
        Me.listAgrupaciones.ClearSelected()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If editarActivo = True Then
            ActualizarAgrupacion()
        Else
            Agregar()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarActivo = True
        Editar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub listAgrupaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listAgrupaciones.SelectedIndexChanged
        If listAgrupaciones.SelectedIndex >= 0 Then
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub listAgrupaciones_DoubleClick(sender As Object, e As EventArgs) Handles listAgrupaciones.DoubleClick
        If listAgrupaciones.SelectedIndex >= 0 Then
            editarActivo = True
            Editar()
        End If
    End Sub

    Private Sub txtNombreAgrupacion_Enter(sender As Object, e As EventArgs) Handles txtNombreAgrupacion.Enter
        listAgrupaciones.ClearSelected()
    End Sub
End Class
