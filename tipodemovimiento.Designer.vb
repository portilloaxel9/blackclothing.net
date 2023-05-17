<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tipodemovimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tipodemovimiento))
        Me.listTipoMovimiento = New System.Windows.Forms.ListBox()
        Me.cboxTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.lblNombreMovimiento = New System.Windows.Forms.Label()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.txtNombreMovimiento = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listTipoMovimiento
        '
        Me.listTipoMovimiento.BackColor = System.Drawing.Color.White
        Me.listTipoMovimiento.FormattingEnabled = True
        Me.listTipoMovimiento.Location = New System.Drawing.Point(149, 118)
        Me.listTipoMovimiento.Name = "listTipoMovimiento"
        Me.listTipoMovimiento.Size = New System.Drawing.Size(465, 173)
        Me.listTipoMovimiento.TabIndex = 39
        '
        'cboxTipoMovimiento
        '
        Me.cboxTipoMovimiento.BackColor = System.Drawing.Color.White
        Me.cboxTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoMovimiento.FormattingEnabled = True
        Me.cboxTipoMovimiento.Location = New System.Drawing.Point(493, 85)
        Me.cboxTipoMovimiento.Name = "cboxTipoMovimiento"
        Me.cboxTipoMovimiento.Size = New System.Drawing.Size(121, 21)
        Me.cboxTipoMovimiento.TabIndex = 38
        '
        'lblNombreMovimiento
        '
        Me.lblNombreMovimiento.AutoSize = True
        Me.lblNombreMovimiento.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMovimiento.Location = New System.Drawing.Point(146, 57)
        Me.lblNombreMovimiento.Name = "lblNombreMovimiento"
        Me.lblNombreMovimiento.Size = New System.Drawing.Size(125, 18)
        Me.lblNombreMovimiento.TabIndex = 36
        Me.lblNombreMovimiento.Text = "Nombre del Movimiento"
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.AutoSize = True
        Me.lblTipoMovimiento.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(490, 57)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(103, 18)
        Me.lblTipoMovimiento.TabIndex = 35
        Me.lblTipoMovimiento.Text = "Tipo de Movimiento"
        '
        'txtNombreMovimiento
        '
        Me.txtNombreMovimiento.BackColor = System.Drawing.Color.White
        Me.txtNombreMovimiento.Location = New System.Drawing.Point(149, 85)
        Me.txtNombreMovimiento.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtNombreMovimiento.Name = "txtNombreMovimiento"
        Me.txtNombreMovimiento.Size = New System.Drawing.Size(318, 20)
        Me.txtNombreMovimiento.TabIndex = 34
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(640, 137)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 32)
        Me.btnEditar.TabIndex = 48
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(640, 187)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminar.TabIndex = 47
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(640, 239)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 32)
        Me.btnLimpiar.TabIndex = 46
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(640, 85)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 32)
        Me.btnAgregar.TabIndex = 45
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(26, 85)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 49
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(23, 57)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(41, 18)
        Me.lblCodigo.TabIndex = 50
        Me.lblCodigo.Text = "Código"
        '
        'tipodemovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(816, 346)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.listTipoMovimiento)
        Me.Controls.Add(Me.cboxTipoMovimiento)
        Me.Controls.Add(Me.lblNombreMovimiento)
        Me.Controls.Add(Me.lblTipoMovimiento)
        Me.Controls.Add(Me.txtNombreMovimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tipodemovimiento"
        Me.Text = "> tipo de movimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listTipoMovimiento As ListBox
    Friend WithEvents cboxTipoMovimiento As ComboBox
    Friend WithEvents lblNombreMovimiento As Label
    Friend WithEvents lblTipoMovimiento As Label
    Friend WithEvents txtNombreMovimiento As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
End Class
