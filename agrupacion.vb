Imports System.Data.SqlClient

Public Class agrupacion
    Sub Agregar()
        On Error GoTo Errores
        If Me.txtNombreAgrupacion.Text = "" Then
            MsgBox("Todos los campos son requeridos.", vbCritical)
            Exit Sub
        End If
        Dim Sql As String = "INSERT INTO agrupacion ([nom agrupacion]) VALUES ('" & Me.txtNombreAgrupacion.Text & "')"
        Dim Instruccion As New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()
        Exit Sub
Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
        txtNombreAgrupacion.Text = ""
        MostrarAgrupaciones()
        LimpiarCampos(Me)
    End Sub

    Sub Editar()
        On Error GoTo Errores
        Dim Rs As SqlDataReader
        Sql = "SELECT [nom agrupacion] FROM agrupacion WHERE [nom agrupacion] = '" & Me.listAgrupaciones.SelectedItem.ToString() & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        If Rs.Read() Then
            Me.txtNombreAgrupacion.Text = Rs("nom agrupacion").ToString()
        End If
        Rs.Close()
        Sql = "DELETE FROM agrupacion WHERE [nom agrupacion] = '" & Me.listAgrupaciones.SelectedItem.ToString() & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
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
    End Sub

    Sub Eliminar()
        If Me.listAgrupaciones.SelectedItem Is Nothing Then
            MsgBox("Seleccione una agrupación para eliminar.", vbCritical)
            Exit Sub
        End If

        Dim agrupacion As String = Me.listAgrupaciones.SelectedItem.ToString()

        Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar la agrupación " & agrupacion & "?", vbYesNo + vbQuestion)
        If respuesta = MsgBoxResult.Yes Then
            Dim sql As String = "DELETE FROM agrupacion WHERE [nom agrupacion] = @nombre"
            Dim cmd As New SqlCommand(sql, DaoCon)
            cmd.Parameters.AddWithValue("@nombre", agrupacion)
            cmd.ExecuteNonQuery()
        Else respuesta = MsgBoxResult.No
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

    Private Sub txtNombreAgrupacion_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAgrupacion.TextChanged
        LimitarNombre(txtNombreAgrupacion)
    End Sub

    Private Sub agrupacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAgrupaciones()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos(Me)
    End Sub
End Class
