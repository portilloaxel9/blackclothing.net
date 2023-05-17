<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class movimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(movimientos))
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cboxTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.cboxArticulo = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.listMovimientos = New System.Windows.Forms.ListBox()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.AutoSize = True
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(81, 223)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(64, 26)
        Me.lblTipoMovimiento.TabIndex = 27
        Me.lblTipoMovimiento.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movimiento:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(81, 133)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 26
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(665, 47)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(51, 18)
        Me.lblCantidad.TabIndex = 25
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulo.Location = New System.Drawing.Point(175, 47)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(48, 18)
        Me.lblArticulo.TabIndex = 24
        Me.lblArticulo.Text = "Artículo"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(519, 47)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(41, 18)
        Me.lblPrecio.TabIndex = 23
        Me.lblPrecio.Text = "Precio"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(29, 47)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(38, 18)
        Me.lblFecha.TabIndex = 22
        Me.lblFecha.Text = "Fecha"
        '
        'cboxTipoMovimiento
        '
        Me.cboxTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoMovimiento.FormattingEnabled = True
        Me.cboxTipoMovimiento.Location = New System.Drawing.Point(178, 228)
        Me.cboxTipoMovimiento.Margin = New System.Windows.Forms.Padding(13, 30, 23, 10)
        Me.cboxTipoMovimiento.Name = "cboxTipoMovimiento"
        Me.cboxTipoMovimiento.Size = New System.Drawing.Size(298, 21)
        Me.cboxTipoMovimiento.TabIndex = 19
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(178, 130)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(13, 30, 23, 10)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(444, 58)
        Me.txtObservacion.TabIndex = 18
        '
        'cboxArticulo
        '
        Me.cboxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArticulo.FormattingEnabled = True
        Me.cboxArticulo.Location = New System.Drawing.Point(178, 70)
        Me.cboxArticulo.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.cboxArticulo.Name = "cboxArticulo"
        Me.cboxArticulo.Size = New System.Drawing.Size(298, 21)
        Me.cboxArticulo.TabIndex = 17
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(668, 70)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 16
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(522, 70)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 26)
        Me.txtPrecio.TabIndex = 15
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(32, 70)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 14
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(668, 182)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 32)
        Me.btnLimpiar.TabIndex = 41
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(668, 130)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 32)
        Me.btnAgregar.TabIndex = 40
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'listMovimientos
        '
        Me.listMovimientos.FormattingEnabled = True
        Me.listMovimientos.Location = New System.Drawing.Point(178, 304)
        Me.listMovimientos.Name = "listMovimientos"
        Me.listMovimientos.Size = New System.Drawing.Size(444, 134)
        Me.listMovimientos.TabIndex = 42
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.Location = New System.Drawing.Point(175, 283)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(133, 18)
        Me.lblHistorial.TabIndex = 43
        Me.lblHistorial.Text = "Historial de movimientos:"
        '
        'movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(822, 450)
        Me.Controls.Add(Me.lblHistorial)
        Me.Controls.Add(Me.listMovimientos)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblTipoMovimiento)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cboxTipoMovimiento)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.cboxArticulo)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtFecha)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "movimientos"
        Me.Text = "> movimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTipoMovimiento As Label
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblArticulo As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents cboxTipoMovimiento As ComboBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents cboxArticulo As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents listMovimientos As ListBox
    Friend WithEvents lblHistorial As Label
End Class
