Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module funciones
    Public DaoCon As SqlConnection
    Public Sql As String ' Cadena de SQL SERVER
    Public Instruccion As SqlCommand '

    ' CONECTAR BASE ()
    Sub ConectarBase()
        On Error GoTo Errores
        Dim Servidor As String = "estack.ddns.net"
        Dim Base As String = "UCES01"
        DaoCon = New SqlConnection("server=" & Servidor & ";database=" & Base & ";User ID=sa;Password=Ita1821!")
        DaoCon.Open()
        blackclothing.lblEstado.Text = "Establecida"
        blackclothing.lblNombreBase.Text = Base
        Exit Sub
Errores:
        Select Case Err.Number
            Case 5
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"), vbInformation)
                MsgBox("El programa se Cerrará", vbCritical)
                End
            Case Else
                MsgBox(Err.Description & " (" & Format(Err.Number, "00000)"))
                Exit Sub
        End Select
    End Sub

    ' LIMPIAR CAMPOS ()
    Public Sub LimpiarCampos(ByVal contenedor As Control)
        For Each control As Control In contenedor.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = -1
            ElseIf TypeOf control Is MaskedTextBox Then
                CType(control, MaskedTextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                CType(control, NumericUpDown).Value = 0
            ElseIf TypeOf control Is CheckBox Then
                CType(control, CheckBox).Checked = False
            ElseIf TypeOf control Is RadioButton Then
                CType(control, RadioButton).Checked = False
            ElseIf control.HasChildren Then
                LimpiarCampos(control)
            End If
        Next
    End Sub

    ' OBTENER FECHA ()
    Public Function ObtenerFecha() As String
        Dim fechaActual As String = Date.Today
        Return fechaActual
    End Function

    ' LIMITAR CÓDIGO ()
    Public Sub LimitarCodigo(ByVal TextBox As TextBox)
        TextBox.Text = Regex.Replace(TextBox.Text, "[^\d]", "")
        If TextBox.TextLength > 4 Then
            TextBox.Text = TextBox.Text.Substring(0, 4)
        End If
    End Sub

    ' LIMITAR CANTIDAD ()
    Public Sub LimitarCantidad(ByVal TextBox As TextBox)
        TextBox.Text = Regex.Replace(TextBox.Text, "[^\d]", "")
        If TextBox.TextLength > 2 Then
            TextBox.Text = TextBox.Text.Substring(0, 4)
        End If
    End Sub

    ' LIMITAR NOMBRE ()
    Public Sub LimitarNombre(ByVal TextBox As TextBox)
        TextBox.Text = Regex.Replace(TextBox.Text, "[^a-zA-Z ]", "")
        TextBox.Text = Regex.Replace(TextBox.Text, "\s+", " ")
        If TextBox.TextLength > 50 Then
            TextBox.Text = TextBox.Text.Substring(0, 50)
        End If
    End Sub

    ' LIMITAR PRECIO ()
    Public Sub LimitarPrecio(ByVal TextBox As TextBox)
        TextBox.Text = TextBox.Text.Replace(",", ".")
        TextBox.Text = Regex.Replace(TextBox.Text, "[^\d\.]", "")
        Dim puntos As MatchCollection = Regex.Matches(TextBox.Text, "\.")
        If puntos.Count > 1 Then
            TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.LastIndexOf("."))
        End If
        If TextBox.Text.Contains(".") Then
            Dim partes() As String = TextBox.Text.Split(".")
            If partes(1).Length > 2 Then
                partes(1) = partes(1).Substring(0, 2)
                TextBox.Text = partes(0) & "." & partes(1)
            End If
        End If
        If TextBox.TextLength > 12 Then
            TextBox.Text = TextBox.Text.Substring(0, 12)
        End If
    End Sub
    ' ACTUALIZAR STATUS ()
    Public Sub ActualizarStatus()
        Dim cantidad As Integer = 0
        Dim total As Decimal = 0
        Dim movimientos As Integer = 0
        Dim sqlCantidad As String = "SELECT COUNT([id articulo]) FROM articulo"
        Dim cmdCantidad As New SqlCommand(sqlCantidad, DaoCon)
        cantidad = CInt(cmdCantidad.ExecuteScalar())
        Dim sqlTotal As String = "SELECT SUM([pco articulo]) FROM articulo"
        Dim cmdTotal As New SqlCommand(sqlTotal, DaoCon)
        total = CDec(cmdTotal.ExecuteScalar())
        Dim sqlMovimientos As String = "SELECT COUNT([id movimiento]) FROM movimiento"
        Dim cmdMovimientos As New SqlCommand(sqlMovimientos, DaoCon)
        movimientos = CInt(cmdMovimientos.ExecuteScalar())
        Dim precioEstimadoUSD As Decimal = Math.Round(total / 490, 2) ' Calcula y redondea el precio estimado en U$D a 2 decimales

        blackclothing.txtStatus.Text = $"> Prendas en stock: {cantidad}{Environment.NewLine}{Environment.NewLine}> Total de stock en AR$: {total}{Environment.NewLine}{Environment.NewLine}> Precio estimado de stock en U$D: {precioEstimadoUSD}{Environment.NewLine}{Environment.NewLine}> Movimientos totales: {movimientos}"
    End Sub
End Module