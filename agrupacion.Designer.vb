<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agrupacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agrupacion))
        Me.listAgrupaciones = New System.Windows.Forms.ListBox()
        Me.lblAgrupacion = New System.Windows.Forms.Label()
        Me.txtNombreAgrupacion = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listAgrupaciones
        '
        Me.listAgrupaciones.BackColor = System.Drawing.Color.White
        Me.listAgrupaciones.FormattingEnabled = True
        Me.listAgrupaciones.Location = New System.Drawing.Point(42, 128)
        Me.listAgrupaciones.Name = "listAgrupaciones"
        Me.listAgrupaciones.Size = New System.Drawing.Size(400, 160)
        Me.listAgrupaciones.TabIndex = 52
        '
        'lblAgrupacion
        '
        Me.lblAgrupacion.AutoSize = True
        Me.lblAgrupacion.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgrupacion.Location = New System.Drawing.Point(166, 52)
        Me.lblAgrupacion.Name = "lblAgrupacion"
        Me.lblAgrupacion.Size = New System.Drawing.Size(134, 18)
        Me.lblAgrupacion.TabIndex = 51
        Me.lblAgrupacion.Text = "Nombre de la Agrupación"
        '
        'txtNombreAgrupacion
        '
        Me.txtNombreAgrupacion.BackColor = System.Drawing.Color.White
        Me.txtNombreAgrupacion.Location = New System.Drawing.Point(169, 80)
        Me.txtNombreAgrupacion.Margin = New System.Windows.Forms.Padding(93, 10, 23, 10)
        Me.txtNombreAgrupacion.Name = "txtNombreAgrupacion"
        Me.txtNombreAgrupacion.Size = New System.Drawing.Size(273, 20)
        Me.txtNombreAgrupacion.TabIndex = 49
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(471, 132)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 32)
        Me.btnEditar.TabIndex = 56
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(471, 182)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminar.TabIndex = 55
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(471, 234)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 32)
        Me.btnLimpiar.TabIndex = 54
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(471, 80)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 32)
        Me.btnAgregar.TabIndex = 53
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(42, 80)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(23, 10, 23, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 57
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(39, 52)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(41, 18)
        Me.lblCodigo.TabIndex = 58
        Me.lblCodigo.Text = "Código"
        '
        'agrupacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(603, 335)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.listAgrupaciones)
        Me.Controls.Add(Me.lblAgrupacion)
        Me.Controls.Add(Me.txtNombreAgrupacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agrupacion"
        Me.Text = "> agrupacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listAgrupaciones As ListBox
    Friend WithEvents lblAgrupacion As Label
    Friend WithEvents txtNombreAgrupacion As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
End Class
