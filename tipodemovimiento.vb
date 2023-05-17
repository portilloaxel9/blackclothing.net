Imports System.Data.SqlClient

Public Class tipodemovimiento
    Private editarActivo As Boolean = False
    Sub Agregar()
        On Error GoTo Errores
        If Me.txtNombreMovimiento.Text = "" Or cboxTipoMovimiento.Text = "" Then
            MsgBox("Todos los campos son requeridos.", vbCritical)
            Exit Sub
        End If
        Sql = "INSERT INTO tipomovi ([nom tipomovi], [tip tipomovi]) VALUES ('" & Me.txtNombreMovimiento.Text & "', '" & cboxTipoMovimiento.Text & "')"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()
        MostrarTipoMovimiento()
        LimpiarCampos(Me)
        Exit Sub
Errores:
        Select Case Err.Number
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
    End Sub

    Sub Editar()
        On Error GoTo Errores

        Dim nombreTipoMovimiento As String = Me.listTipoMovimiento.SelectedItem.ToString()

        Dim selectSql As String = "SELECT [id tipomovi], [nom tipomovi], [tip tipomovi] FROM tipomovi WHERE [nom tipomovi] = @nombre"
        Dim selectCmd As New SqlCommand(selectSql, DaoCon)
        selectCmd.Parameters.AddWithValue("@nombre", nombreTipoMovimiento)
        Dim reader As SqlDataReader = selectCmd.ExecuteReader()

        If reader.Read() Then
            Dim idTipoMovimiento As Integer = reader("id tipomovi").ToString()
            Dim nomTipoMovimiento As String = reader("nom tipomovi").ToString()
            Dim tipTipoMovimiento As String = reader("tip tipomovi").ToString()

            Me.txtCodigo.Text = idTipoMovimiento
            Me.txtNombreMovimiento.Text = nomTipoMovimiento
            Me.cboxTipoMovimiento.Text = tipTipoMovimiento
            Me.cboxTipoMovimiento.Enabled = False
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
        If Me.listTipoMovimiento.SelectedItem IsNot Nothing Then
            Dim itemSeleccionado As String = Me.listTipoMovimiento.SelectedItem.ToString()

            Dim countSql As String = "SELECT COUNT(*) FROM movimiento WHERE [ID tipomovi] = (SELECT [ID tipomovi] FROM tipomovi WHERE [nom tipomovi] = @nombre)"
            Dim countCmd As New SqlCommand(countSql, DaoCon)
            countCmd.Parameters.AddWithValue("@nombre", itemSeleccionado)
            Dim count As Integer = CInt(countCmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("El tipo de movimiento " & itemSeleccionado & " no puede ser eliminado porque está siendo utilizado en un movimiento.", vbExclamation)
                listTipoMovimiento.ClearSelected()
                Exit Sub
            End If

            Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el movimiento " & itemSeleccionado & "?", vbYesNo + vbQuestion)
            If respuesta = vbYes Then
                Sql = "DELETE FROM tipomovi WHERE [nom tipomovi] = '" & itemSeleccionado & "'"
                Instruccion = New SqlCommand(Sql, DaoCon)
                Instruccion.ExecuteNonQuery()
            Else
                respuesta = MsgBoxResult.No
                Me.listTipoMovimiento.ClearSelected()
            End If
        End If

        MostrarTipoMovimiento()
    End Sub

    Sub MostrarTipoMovimiento()
        Dim Rs As SqlDataReader
        Me.listTipoMovimiento.Items.Clear()
        Sql = "SELECT [nom tipomovi] FROM tipomovi"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()
        While Rs.Read
            Me.listTipoMovimiento.Items.Add(Rs(0))
        End While
        Rs.Close()
    End Sub

    Private Sub tipodemovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboxTipoMovimiento.Items.Clear()
        Me.cboxTipoMovimiento.Items.Add("E")
        Me.cboxTipoMovimiento.Items.Add("S")
        Me.btnEliminar.Enabled = False
        Me.btnEditar.Enabled = False
        LimpiarCampos(Me)
        MostrarTipoMovimiento()
    End Sub

    Private Sub ActualizarTipoMovimiento()
        Dim idTipoMovimiento As Integer = Integer.Parse(txtCodigo.Text)

        Dim updateSql As String = "UPDATE tipomovi SET [nom tipomovi] = @nombre WHERE [id tipomovi] = @id"
        Dim updateCmd As New SqlCommand(updateSql, DaoCon)
        updateCmd.Parameters.AddWithValue("@nombre", txtNombreMovimiento.Text)
        updateCmd.Parameters.AddWithValue("@id", idTipoMovimiento)
        updateCmd.ExecuteNonQuery()

        LimpiarCampos(Me)
        editarActivo = False

        MostrarTipoMovimiento()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If editarActivo = True Then
            ActualizarTipoMovimiento()
            Me.cboxTipoMovimiento.Enabled = True
        Else
            Agregar()
        End If
    End Sub

    Private Sub listTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTipoMovimiento.SelectedIndexChanged
        If listTipoMovimiento.SelectedIndex >= 0 Then
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
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

    Private Sub txtNombreMovimiento_TextChanged(sender As Object, e As EventArgs) Handles txtNombreMovimiento.TextChanged
        LimitarNombre(txtNombreMovimiento)
        Me.listTipoMovimiento.ClearSelected()
    End Sub

    Private Sub cboxTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTipoMovimiento.SelectedIndexChanged
        If listTipoMovimiento.SelectedIndex >= 0 Then
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub listTipoMovimiento_DoubleClick(sender As Object, e As EventArgs) Handles listTipoMovimiento.DoubleClick
        If listTipoMovimiento.SelectedIndex >= 0 Then
            editarActivo = True
            Editar()
        End If
    End Sub

    Private Sub txtNombreMovimiento_Enter(sender As Object, e As EventArgs) Handles txtNombreMovimiento.Enter
        listTipoMovimiento.ClearSelected()
    End Sub
End Class