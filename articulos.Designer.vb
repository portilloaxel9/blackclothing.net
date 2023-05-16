<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(articulos))
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.cboxAgrupacion = New System.Windows.Forms.ComboBox()
        Me.lblAgrupacion = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombreArticulo = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.listArticulos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(692, 265)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 32)
        Me.btnLimpiar.TabIndex = 39
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(692, 111)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 32)
        Me.btnAgregar.TabIndex = 38
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(689, 48)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(41, 18)
        Me.lblPrecio.TabIndex = 37
        Me.lblPrecio.Text = "Precio"
        '
        'cboxAgrupacion
        '
        Me.cboxAgrupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAgrupacion.ForeColor = System.Drawing.Color.Black
        Me.cboxAgrupacion.FormattingEnabled = True
        Me.cboxAgrupacion.Location = New System.Drawing.Point(524, 71)
        Me.cboxAgrupacion.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.cboxAgrupacion.Name = "cboxAgrupacion"
        Me.cboxAgrupacion.Size = New System.Drawing.Size(122, 21)
        Me.cboxAgrupacion.TabIndex = 36
        '
        'lblAgrupacion
        '
        Me.lblAgrupacion.AutoSize = True
        Me.lblAgrupacion.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgrupacion.Location = New System.Drawing.Point(521, 48)
        Me.lblAgrupacion.Name = "lblAgrupacion"
        Me.lblAgrupacion.Size = New System.Drawing.Size(65, 18)
        Me.lblAgrupacion.TabIndex = 35
        Me.lblAgrupacion.Text = "Agrupación"
        '
        'txtPrecio
        '
        Me.txtPrecio.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio.Location = New System.Drawing.Point(692, 71)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 34
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulo.Location = New System.Drawing.Point(177, 48)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(108, 18)
        Me.lblArticulo.TabIndex = 33
        Me.lblArticulo.Text = "Nombre del Artículo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(31, 48)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(41, 18)
        Me.lblCodigo.TabIndex = 32
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(34, 71)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 31
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.ForeColor = System.Drawing.Color.Black
        Me.txtNombreArticulo.Location = New System.Drawing.Point(180, 71)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(298, 20)
        Me.txtNombreArticulo.TabIndex = 30
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(692, 163)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 32)
        Me.btnEditar.TabIndex = 44
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(692, 213)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminar.TabIndex = 43
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'listArticulos
        '
        Me.listArticulos.BackColor = System.Drawing.Color.White
        Me.listArticulos.ForeColor = System.Drawing.Color.Black
        Me.listArticulos.FormattingEnabled = True
        Me.listArticulos.Location = New System.Drawing.Point(180, 136)
        Me.listArticulos.Name = "listArticulos"
        Me.listArticulos.Size = New System.Drawing.Size(464, 160)
        Me.listArticulos.TabIndex = 45
        '
        'articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(832, 363)
        Me.Controls.Add(Me.listArticulos)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cboxAgrupacion)
        Me.Controls.Add(Me.lblAgrupacion)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblArticulo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombreArticulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "articulos"
        Me.Text = "> artículos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents cboxAgrupacion As ComboBox
    Friend WithEvents lblAgrupacion As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblArticulo As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombreArticulo As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents listArticulos As ListBox
End Class
