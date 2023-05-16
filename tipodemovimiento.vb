Imports System.Data.SqlClient

Public Class tipodemovimiento
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
        Dim Rs As SqlDataReader
        Dim itemSeleccionado As String = Me.listTipoMovimiento.SelectedItem.ToString()

        Sql = "SELECT [nom tipomovi], [tip tipomovi] FROM tipomovi WHERE [nom tipomovi] = '" & itemSeleccionado & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Rs = Instruccion.ExecuteReader()

        If Rs.Read() Then
            Me.txtNombreMovimiento.Text = Rs("nom tipomovi").ToString()
            Me.cboxTipoMovimiento.Text = Rs("tip tipomovi").ToString()
        End If

        Rs.Close()

        Sql = "DELETE FROM tipomovi WHERE [nom tipomovi] = '" & itemSeleccionado & "'"
        Instruccion = New SqlCommand(Sql, DaoCon)
        Instruccion.ExecuteNonQuery()

        MostrarTipoMovimiento()
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
            Dim respuesta As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el movimiento " & itemSeleccionado & "?", vbYesNo + vbQuestion)
            If respuesta = vbYes Then
                Sql = "DELETE FROM tipomovi WHERE [nom tipomovi] = '" & itemSeleccionado & "'"
                Instruccion = New SqlCommand(Sql, DaoCon)
                Instruccion.ExecuteNonQuery()
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
        LimpiarCampos(Me)
        MostrarTipoMovimiento()
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