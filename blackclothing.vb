Imports System.Data.SqlClient
Imports System.Threading

Public Class blackclothing
    Dim imagenes As New List(Of String)()
    Dim indiceActual As Integer = 0

    Private Sub MostrarSiguienteImagen()
        If indiceActual < imagenes.Count - 1 Then
            indiceActual += 1
        Else
            indiceActual = 0
        End If

        PictureBox1.ImageLocation = imagenes(indiceActual)
    End Sub
    Private Sub blackclothing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagenes.Add("C:\Users\Axel Portillo\Desktop\.NET\blackclothing\img\image-3.png")
        imagenes.Add("C:\Users\Axel Portillo\Desktop\.NET\blackclothing\img\image-5.png")
        imagenes.Add("C:\Users\Axel Portillo\Desktop\.NET\blackclothing\img\image-6.png")

        Timer1.Interval = 1000
        Timer1.Start()
        MostrarSiguienteImagen()

        ConectarBase()
        ActualizarStatus()
    End Sub

    Private Sub blackclothing_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        DaoCon.Close()
        MsgBox("Conexión Cerrada", vbInformation)
    End Sub

    Private Sub TiposDeMovimentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMovimentosToolStripMenuItem.Click
        tipodemovimiento.ShowDialog()
    End Sub

    Private Sub ArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem.Click
        articulos.ShowDialog()
    End Sub

    Private Sub AgrupaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgrupaciónToolStripMenuItem.Click
        agrupacion.ShowDialog()
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        movimientos.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MostrarSiguienteImagen()
    End Sub
End Class
