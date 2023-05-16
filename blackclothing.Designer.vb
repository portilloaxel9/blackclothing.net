<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class blackclothing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(blackclothing))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasYActualizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeMovimentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgrupaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblConexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNombreBase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenúPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasYActualizacionesToolStripMenuItem, Me.MovimientosToolStripMenuItem})
        Me.MenúPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú Principal"
        '
        'AltasYActualizacionesToolStripMenuItem
        '
        Me.AltasYActualizacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtículosToolStripMenuItem, Me.TiposDeMovimentosToolStripMenuItem, Me.AgrupaciónToolStripMenuItem})
        Me.AltasYActualizacionesToolStripMenuItem.Name = "AltasYActualizacionesToolStripMenuItem"
        Me.AltasYActualizacionesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AltasYActualizacionesToolStripMenuItem.Text = "Altas y Actualizaciones"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ArtículosToolStripMenuItem.Text = "Artículos"
        '
        'TiposDeMovimentosToolStripMenuItem
        '
        Me.TiposDeMovimentosToolStripMenuItem.Name = "TiposDeMovimentosToolStripMenuItem"
        Me.TiposDeMovimentosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TiposDeMovimentosToolStripMenuItem.Text = "Tipos de Movimento"
        '
        'AgrupaciónToolStripMenuItem
        '
        Me.AgrupaciónToolStripMenuItem.Name = "AgrupaciónToolStripMenuItem"
        Me.AgrupaciónToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AgrupaciónToolStripMenuItem.Text = "Agrupación"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblConexion, Me.lblEstado, Me.lblBase, Me.lblNombreBase})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 388)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(760, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblConexion
        '
        Me.lblConexion.ForeColor = System.Drawing.Color.Black
        Me.lblConexion.LinkColor = System.Drawing.Color.Black
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(61, 17)
        Me.lblConexion.Text = "Conexión:"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 17)
        '
        'lblBase
        '
        Me.lblBase.ForeColor = System.Drawing.Color.Black
        Me.lblBase.LinkColor = System.Drawing.Color.Black
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(34, 17)
        Me.lblBase.Text = "Base:"
        '
        'lblNombreBase
        '
        Me.lblNombreBase.Name = "lblNombreBase"
        Me.lblNombreBase.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(93, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 288)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(275, 61)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(393, 288)
        Me.txtStatus.TabIndex = 10
        '
        'blackclothing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(760, 410)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "blackclothing"
        Me.Text = "blackclothing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltasYActualizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeMovimentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgrupaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblConexion As ToolStripStatusLabel
    Friend WithEvents lblEstado As ToolStripStatusLabel
    Friend WithEvents lblBase As ToolStripStatusLabel
    Friend WithEvents lblNombreBase As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtStatus As TextBox
End Class
