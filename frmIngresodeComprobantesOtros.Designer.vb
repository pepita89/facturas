<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresodeComprobantesOtros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresodeComprobantesOtros))
        Me.lblClaseCOmp = New System.Windows.Forms.Label()
        Me.lblTipoComprobante = New System.Windows.Forms.Label()
        Me.cboClaseComprobante = New System.Windows.Forms.ComboBox()
        Me.cboTipoComp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblErrorCoti = New System.Windows.Forms.Label()
        Me.lblErrorCotizacion = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtcdComprobante = New System.Windows.Forms.TextBox()
        Me.lblErrorImporte = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.lblErrorComp = New System.Windows.Forms.Label()
        Me.chkExcluir = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNroComprobante = New System.Windows.Forms.TextBox()
        Me.txtdesglosar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPeriodicidad = New System.Windows.Forms.TextBox()
        Me.cmdPeriodicidad = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.dtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblPeriodicidad = New System.Windows.Forms.Label()
        Me.cboPeriodicidad = New System.Windows.Forms.ComboBox()
        Me.lblTipoPeriodicidad = New System.Windows.Forms.Label()
        Me.cboTipoPeriodicidad = New System.Windows.Forms.ComboBox()
        Me.lblImporteC = New System.Windows.Forms.Label()
        Me.txtImporteC = New System.Windows.Forms.TextBox()
        Me.cmdAgregarComp = New System.Windows.Forms.Button()
        Me.lblCotizacion = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.txtcdExpediente = New System.Windows.Forms.TextBox()
        Me.grbComprobante = New System.Windows.Forms.GroupBox()
        Me.lblErrorProv = New System.Windows.Forms.Label()
        Me.txtcdProveedor = New System.Windows.Forms.TextBox()
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.chkProveedorExp = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripModificar = New System.Windows.Forms.ToolStripButton()
        Me.chkExterior = New System.Windows.Forms.CheckBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblNroBeneficiario = New System.Windows.Forms.Label()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtNroBeneficiario = New System.Windows.Forms.TextBox()
        Me.txtExpedienteExistente = New System.Windows.Forms.TextBox()
        Me.dtFechac = New System.Windows.Forms.DateTimePicker()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.mtxtArea = New Facturas.mTxtAutoComplete()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.grbComprobante.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClaseCOmp
        '
        Me.lblClaseCOmp.AutoSize = True
        Me.lblClaseCOmp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaseCOmp.ForeColor = System.Drawing.Color.Black
        Me.lblClaseCOmp.Location = New System.Drawing.Point(13, 31)
        Me.lblClaseCOmp.Name = "lblClaseCOmp"
        Me.lblClaseCOmp.Size = New System.Drawing.Size(132, 12)
        Me.lblClaseCOmp.TabIndex = 2
        Me.lblClaseCOmp.Text = "Clase de Comprobante"
        '
        'lblTipoComprobante
        '
        Me.lblTipoComprobante.AutoSize = True
        Me.lblTipoComprobante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoComprobante.ForeColor = System.Drawing.Color.Black
        Me.lblTipoComprobante.Location = New System.Drawing.Point(205, 31)
        Me.lblTipoComprobante.Name = "lblTipoComprobante"
        Me.lblTipoComprobante.Size = New System.Drawing.Size(125, 12)
        Me.lblTipoComprobante.TabIndex = 3
        Me.lblTipoComprobante.Text = "Tipo de Comprobante"
        '
        'cboClaseComprobante
        '
        Me.cboClaseComprobante.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboClaseComprobante.FormattingEnabled = True
        Me.cboClaseComprobante.ItemHeight = 13
        Me.cboClaseComprobante.Location = New System.Drawing.Point(13, 47)
        Me.cboClaseComprobante.Name = "cboClaseComprobante"
        Me.cboClaseComprobante.Size = New System.Drawing.Size(186, 21)
        Me.cboClaseComprobante.TabIndex = 1
        '
        'cboTipoComp
        '
        Me.cboTipoComp.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboTipoComp.FormattingEnabled = True
        Me.cboTipoComp.Location = New System.Drawing.Point(205, 47)
        Me.cboTipoComp.Name = "cboTipoComp"
        Me.cboTipoComp.Size = New System.Drawing.Size(186, 21)
        Me.cboTipoComp.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(410, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "*"
        Me.Label2.Visible = False
        '
        'lblErrorCoti
        '
        Me.lblErrorCoti.AutoSize = True
        Me.lblErrorCoti.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorCoti.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorCoti.Location = New System.Drawing.Point(201, 68)
        Me.lblErrorCoti.Name = "lblErrorCoti"
        Me.lblErrorCoti.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorCoti.TabIndex = 22
        Me.lblErrorCoti.Text = "*"
        Me.lblErrorCoti.Visible = False
        '
        'lblErrorCotizacion
        '
        Me.lblErrorCotizacion.AutoSize = True
        Me.lblErrorCotizacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorCotizacion.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorCotizacion.Location = New System.Drawing.Point(972, 57)
        Me.lblErrorCotizacion.Name = "lblErrorCotizacion"
        Me.lblErrorCotizacion.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorCotizacion.TabIndex = 23
        Me.lblErrorCotizacion.Text = "*"
        Me.lblErrorCotizacion.Visible = False
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGrupo.Location = New System.Drawing.Point(124, 273)
        Me.txtGrupo.MaxLength = 10
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(14, 22)
        Me.txtGrupo.TabIndex = 33
        Me.txtGrupo.Text = " "
        Me.txtGrupo.Visible = False
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacion.ForeColor = System.Drawing.Color.Black
        Me.lblObservacion.Location = New System.Drawing.Point(224, 280)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(185, 12)
        Me.lblObservacion.TabIndex = 32
        Me.lblObservacion.Text = "Ingresar Observación (opcional)"
        '
        'txtcdComprobante
        '
        Me.txtcdComprobante.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtcdComprobante.Location = New System.Drawing.Point(576, 509)
        Me.txtcdComprobante.Name = "txtcdComprobante"
        Me.txtcdComprobante.Size = New System.Drawing.Size(17, 22)
        Me.txtcdComprobante.TabIndex = 35
        Me.txtcdComprobante.Visible = False
        '
        'lblErrorImporte
        '
        Me.lblErrorImporte.AutoSize = True
        Me.lblErrorImporte.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorImporte.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorImporte.Location = New System.Drawing.Point(457, 378)
        Me.lblErrorImporte.Name = "lblErrorImporte"
        Me.lblErrorImporte.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorImporte.TabIndex = 34
        Me.lblErrorImporte.Text = "*"
        Me.lblErrorImporte.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 12)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fecha "
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(215, 293)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(378, 210)
        Me.txtObservacion.TabIndex = 17
        Me.txtObservacion.Text = ""
        '
        'lblErrorComp
        '
        Me.lblErrorComp.AutoSize = True
        Me.lblErrorComp.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorComp.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorComp.Location = New System.Drawing.Point(163, 280)
        Me.lblErrorComp.Name = "lblErrorComp"
        Me.lblErrorComp.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorComp.TabIndex = 21
        Me.lblErrorComp.Text = "*"
        Me.lblErrorComp.Visible = False
        '
        'chkExcluir
        '
        Me.chkExcluir.AutoSize = True
        Me.chkExcluir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcluir.Location = New System.Drawing.Point(112, 437)
        Me.chkExcluir.Name = "chkExcluir"
        Me.chkExcluir.Size = New System.Drawing.Size(89, 16)
        Me.chkExcluir.TabIndex = 9
        Me.chkExcluir.Text = "Desglosado"
        Me.chkExcluir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(397, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nro. del Comprobante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 12)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Expediente del desglose"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNroComprobante.Location = New System.Drawing.Point(397, 46)
        Me.txtNroComprobante.MaxLength = 50
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(196, 22)
        Me.txtNroComprobante.TabIndex = 3
        '
        'txtdesglosar
        '
        Me.txtdesglosar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesglosar.Location = New System.Drawing.Point(12, 484)
        Me.txtdesglosar.MaxLength = 13
        Me.txtdesglosar.Name = "txtdesglosar"
        Me.txtdesglosar.Size = New System.Drawing.Size(189, 22)
        Me.txtdesglosar.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(412, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "*"
        Me.Label9.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 517)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 12)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Unidad requirente"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Controls.Add(Me.txtPeriodicidad)
        Me.GroupBox3.Controls.Add(Me.cmdPeriodicidad)
        Me.GroupBox3.Controls.Add(Me.btnDesactivar)
        Me.GroupBox3.Controls.Add(Me.dtFechaHasta)
        Me.GroupBox3.Controls.Add(Me.lblFechaHasta)
        Me.GroupBox3.Controls.Add(Me.dtFechaDesde)
        Me.GroupBox3.Controls.Add(Me.lblFechaDesde)
        Me.GroupBox3.Controls.Add(Me.lblPeriodicidad)
        Me.GroupBox3.Controls.Add(Me.cboPeriodicidad)
        Me.GroupBox3.Controls.Add(Me.lblTipoPeriodicidad)
        Me.GroupBox3.Controls.Add(Me.cboTipoPeriodicidad)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(13, 570)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(580, 76)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periodicidad "
        '
        'txtPeriodicidad
        '
        Me.txtPeriodicidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodicidad.Location = New System.Drawing.Point(139, 34)
        Me.txtPeriodicidad.MaxLength = 13
        Me.txtPeriodicidad.Name = "txtPeriodicidad"
        Me.txtPeriodicidad.Size = New System.Drawing.Size(161, 22)
        Me.txtPeriodicidad.TabIndex = 13
        Me.txtPeriodicidad.Visible = False
        '
        'cmdPeriodicidad
        '
        Me.cmdPeriodicidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPeriodicidad.ForeColor = System.Drawing.Color.Black
        Me.cmdPeriodicidad.Image = CType(resources.GetObject("cmdPeriodicidad.Image"), System.Drawing.Image)
        Me.cmdPeriodicidad.Location = New System.Drawing.Point(303, 29)
        Me.cmdPeriodicidad.Name = "cmdPeriodicidad"
        Me.cmdPeriodicidad.Size = New System.Drawing.Size(22, 25)
        Me.cmdPeriodicidad.TabIndex = 14
        Me.cmdPeriodicidad.UseVisualStyleBackColor = True
        Me.cmdPeriodicidad.Visible = False
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesactivar.ForeColor = System.Drawing.Color.Black
        Me.btnDesactivar.Image = CType(resources.GetObject("btnDesactivar.Image"), System.Drawing.Image)
        Me.btnDesactivar.Location = New System.Drawing.Point(306, 29)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(22, 25)
        Me.btnDesactivar.TabIndex = 16
        Me.btnDesactivar.UseVisualStyleBackColor = True
        '
        'dtFechaHasta
        '
        Me.dtFechaHasta.Checked = False
        Me.dtFechaHasta.Enabled = False
        Me.dtFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaHasta.Location = New System.Drawing.Point(456, 33)
        Me.dtFechaHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaHasta.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaHasta.Name = "dtFechaHasta"
        Me.dtFechaHasta.ShowCheckBox = True
        Me.dtFechaHasta.Size = New System.Drawing.Size(121, 22)
        Me.dtFechaHasta.TabIndex = 16
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHasta.ForeColor = System.Drawing.Color.Black
        Me.lblFechaHasta.Location = New System.Drawing.Point(456, 18)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(75, 12)
        Me.lblFechaHasta.TabIndex = 37
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'dtFechaDesde
        '
        Me.dtFechaDesde.Checked = False
        Me.dtFechaDesde.Enabled = False
        Me.dtFechaDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDesde.Location = New System.Drawing.Point(331, 33)
        Me.dtFechaDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaDesde.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaDesde.Name = "dtFechaDesde"
        Me.dtFechaDesde.ShowCheckBox = True
        Me.dtFechaDesde.Size = New System.Drawing.Size(122, 22)
        Me.dtFechaDesde.TabIndex = 15
        Me.dtFechaDesde.Value = New Date(2013, 11, 12, 10, 0, 0, 0)
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDesde.ForeColor = System.Drawing.Color.Black
        Me.lblFechaDesde.Location = New System.Drawing.Point(328, 18)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(78, 12)
        Me.lblFechaDesde.TabIndex = 35
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblPeriodicidad
        '
        Me.lblPeriodicidad.AutoSize = True
        Me.lblPeriodicidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodicidad.ForeColor = System.Drawing.Color.Black
        Me.lblPeriodicidad.Location = New System.Drawing.Point(136, 18)
        Me.lblPeriodicidad.Name = "lblPeriodicidad"
        Me.lblPeriodicidad.Size = New System.Drawing.Size(75, 12)
        Me.lblPeriodicidad.TabIndex = 34
        Me.lblPeriodicidad.Text = "Periodicidad"
        '
        'cboPeriodicidad
        '
        Me.cboPeriodicidad.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboPeriodicidad.FormattingEnabled = True
        Me.cboPeriodicidad.ItemHeight = 13
        Me.cboPeriodicidad.Location = New System.Drawing.Point(139, 34)
        Me.cboPeriodicidad.Name = "cboPeriodicidad"
        Me.cboPeriodicidad.Size = New System.Drawing.Size(161, 21)
        Me.cboPeriodicidad.TabIndex = 13
        '
        'lblTipoPeriodicidad
        '
        Me.lblTipoPeriodicidad.AutoSize = True
        Me.lblTipoPeriodicidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPeriodicidad.ForeColor = System.Drawing.Color.Black
        Me.lblTipoPeriodicidad.Location = New System.Drawing.Point(3, 18)
        Me.lblTipoPeriodicidad.Name = "lblTipoPeriodicidad"
        Me.lblTipoPeriodicidad.Size = New System.Drawing.Size(119, 12)
        Me.lblTipoPeriodicidad.TabIndex = 32
        Me.lblTipoPeriodicidad.Text = "Tipo de Periodicidad"
        '
        'cboTipoPeriodicidad
        '
        Me.cboTipoPeriodicidad.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboTipoPeriodicidad.FormattingEnabled = True
        Me.cboTipoPeriodicidad.ItemHeight = 13
        Me.cboTipoPeriodicidad.Items.AddRange(New Object() {"Sin Periodicidad", "Mensual", "Quincenal"})
        Me.cboTipoPeriodicidad.Location = New System.Drawing.Point(6, 34)
        Me.cboTipoPeriodicidad.Name = "cboTipoPeriodicidad"
        Me.cboTipoPeriodicidad.Size = New System.Drawing.Size(127, 21)
        Me.cboTipoPeriodicidad.TabIndex = 12
        '
        'lblImporteC
        '
        Me.lblImporteC.AutoSize = True
        Me.lblImporteC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteC.ForeColor = System.Drawing.Color.Black
        Me.lblImporteC.Location = New System.Drawing.Point(16, 304)
        Me.lblImporteC.Name = "lblImporteC"
        Me.lblImporteC.Size = New System.Drawing.Size(48, 12)
        Me.lblImporteC.TabIndex = 54
        Me.lblImporteC.Text = "Importe"
        '
        'txtImporteC
        '
        Me.txtImporteC.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtImporteC.Location = New System.Drawing.Point(16, 319)
        Me.txtImporteC.MaxLength = 13
        Me.txtImporteC.Name = "txtImporteC"
        Me.txtImporteC.Size = New System.Drawing.Size(186, 22)
        Me.txtImporteC.TabIndex = 6
        '
        'cmdAgregarComp
        '
        Me.cmdAgregarComp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarComp.ForeColor = System.Drawing.Color.Black
        Me.cmdAgregarComp.Image = CType(resources.GetObject("cmdAgregarComp.Image"), System.Drawing.Image)
        Me.cmdAgregarComp.Location = New System.Drawing.Point(553, 652)
        Me.cmdAgregarComp.Name = "cmdAgregarComp"
        Me.cmdAgregarComp.Size = New System.Drawing.Size(40, 42)
        Me.cmdAgregarComp.TabIndex = 18
        Me.cmdAgregarComp.UseVisualStyleBackColor = True
        '
        'lblCotizacion
        '
        Me.lblCotizacion.AutoSize = True
        Me.lblCotizacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizacion.ForeColor = System.Drawing.Color.Black
        Me.lblCotizacion.Location = New System.Drawing.Point(10, 388)
        Me.lblCotizacion.Name = "lblCotizacion"
        Me.lblCotizacion.Size = New System.Drawing.Size(141, 12)
        Me.lblCotizacion.TabIndex = 72
        Me.lblCotizacion.Text = "Cotización de la Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(15, 360)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(186, 21)
        Me.cboMoneda.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Moneda"
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCotizacion.Location = New System.Drawing.Point(12, 405)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Size = New System.Drawing.Size(189, 22)
        Me.txtCotizacion.TabIndex = 8
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.White
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(509, 652)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 42)
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'txtcdExpediente
        '
        Me.txtcdExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcdExpediente.Location = New System.Drawing.Point(186, 459)
        Me.txtcdExpediente.MaxLength = 13
        Me.txtcdExpediente.Name = "txtcdExpediente"
        Me.txtcdExpediente.Size = New System.Drawing.Size(13, 22)
        Me.txtcdExpediente.TabIndex = 74
        Me.txtcdExpediente.Visible = False
        '
        'grbComprobante
        '
        Me.grbComprobante.BackColor = System.Drawing.Color.DarkGray
        Me.grbComprobante.Controls.Add(Me.txtcdProveedor)
        Me.grbComprobante.Controls.Add(Me.lblErrorProv)
        Me.grbComprobante.Controls.Add(Me.gbProveedor)
        Me.grbComprobante.Controls.Add(Me.txtExpedienteExistente)
        Me.grbComprobante.Controls.Add(Me.dtFechac)
        Me.grbComprobante.Controls.Add(Me.cmdEliminar)
        Me.grbComprobante.Controls.Add(Me.txtcdExpediente)
        Me.grbComprobante.Controls.Add(Me.mtxtArea)
        Me.grbComprobante.Controls.Add(Me.cmdModificar)
        Me.grbComprobante.Controls.Add(Me.txtCotizacion)
        Me.grbComprobante.Controls.Add(Me.Label5)
        Me.grbComprobante.Controls.Add(Me.cboMoneda)
        Me.grbComprobante.Controls.Add(Me.lblCotizacion)
        Me.grbComprobante.Controls.Add(Me.cmdAgregarComp)
        Me.grbComprobante.Controls.Add(Me.txtImporteC)
        Me.grbComprobante.Controls.Add(Me.lblImporteC)
        Me.grbComprobante.Controls.Add(Me.GroupBox3)
        Me.grbComprobante.Controls.Add(Me.Label11)
        Me.grbComprobante.Controls.Add(Me.Label9)
        Me.grbComprobante.Controls.Add(Me.txtdesglosar)
        Me.grbComprobante.Controls.Add(Me.txtNroComprobante)
        Me.grbComprobante.Controls.Add(Me.Label8)
        Me.grbComprobante.Controls.Add(Me.Label3)
        Me.grbComprobante.Controls.Add(Me.chkExcluir)
        Me.grbComprobante.Controls.Add(Me.lblErrorComp)
        Me.grbComprobante.Controls.Add(Me.txtObservacion)
        Me.grbComprobante.Controls.Add(Me.Label1)
        Me.grbComprobante.Controls.Add(Me.lblErrorImporte)
        Me.grbComprobante.Controls.Add(Me.txtcdComprobante)
        Me.grbComprobante.Controls.Add(Me.lblObservacion)
        Me.grbComprobante.Controls.Add(Me.txtGrupo)
        Me.grbComprobante.Controls.Add(Me.lblErrorCotizacion)
        Me.grbComprobante.Controls.Add(Me.lblErrorCoti)
        Me.grbComprobante.Controls.Add(Me.Label2)
        Me.grbComprobante.Controls.Add(Me.cboTipoComp)
        Me.grbComprobante.Controls.Add(Me.cboClaseComprobante)
        Me.grbComprobante.Controls.Add(Me.lblTipoComprobante)
        Me.grbComprobante.Controls.Add(Me.lblClaseCOmp)
        Me.grbComprobante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbComprobante.ForeColor = System.Drawing.Color.Black
        Me.grbComprobante.Location = New System.Drawing.Point(1, 2)
        Me.grbComprobante.Name = "grbComprobante"
        Me.grbComprobante.Size = New System.Drawing.Size(618, 709)
        Me.grbComprobante.TabIndex = 42
        Me.grbComprobante.TabStop = False
        Me.grbComprobante.Text = "-"
        '
        'lblErrorProv
        '
        Me.lblErrorProv.AutoSize = True
        Me.lblErrorProv.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorProv.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorProv.Location = New System.Drawing.Point(578, 220)
        Me.lblErrorProv.Name = "lblErrorProv"
        Me.lblErrorProv.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorProv.TabIndex = 78
        Me.lblErrorProv.Text = "*"
        Me.lblErrorProv.Visible = False
        '
        'txtcdProveedor
        '
        Me.txtcdProveedor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcdProveedor.Location = New System.Drawing.Point(517, 45)
        Me.txtcdProveedor.MaxLength = 20
        Me.txtcdProveedor.Name = "txtcdProveedor"
        Me.txtcdProveedor.Size = New System.Drawing.Size(76, 22)
        Me.txtcdProveedor.TabIndex = 77
        Me.txtcdProveedor.Visible = False
        '
        'gbProveedor
        '
        Me.gbProveedor.BackColor = System.Drawing.Color.DarkGray
        Me.gbProveedor.Controls.Add(Me.ToolStrip2)
        Me.gbProveedor.Controls.Add(Me.chkProveedorExp)
        Me.gbProveedor.Controls.Add(Me.chkExterior)
        Me.gbProveedor.Controls.Add(Me.txtCuit)
        Me.gbProveedor.Controls.Add(Me.lblRazonSocial)
        Me.gbProveedor.Controls.Add(Me.lblNroBeneficiario)
        Me.gbProveedor.Controls.Add(Me.lblCuit)
        Me.gbProveedor.Controls.Add(Me.txtRazonSocial)
        Me.gbProveedor.Controls.Add(Me.txtNroBeneficiario)
        Me.gbProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProveedor.ForeColor = System.Drawing.Color.Black
        Me.gbProveedor.Location = New System.Drawing.Point(6, 84)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(602, 133)
        Me.gbProveedor.TabIndex = 76
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Proveedor"
        '
        'chkProveedorExp
        '
        Me.chkProveedorExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkProveedorExp.AutoSize = True
        Me.chkProveedorExp.BackColor = System.Drawing.Color.DarkGray
        Me.chkProveedorExp.ForeColor = System.Drawing.Color.Black
        Me.chkProveedorExp.Location = New System.Drawing.Point(265, 104)
        Me.chkProveedorExp.Name = "chkProveedorExp"
        Me.chkProveedorExp.Size = New System.Drawing.Size(223, 16)
        Me.chkProveedorExp.TabIndex = 41
        Me.chkProveedorExp.Text = "Mantener proveedor del expediente"
        Me.chkProveedorExp.UseVisualStyleBackColor = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripModificar, Me.ToolStripNuevo})
        Me.ToolStrip2.Location = New System.Drawing.Point(487, 95)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip2.Size = New System.Drawing.Size(112, 25)
        Me.ToolStrip2.TabIndex = 40
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripNuevo
        '
        Me.ToolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNuevo.Image = CType(resources.GetObject("ToolStripNuevo.Image"), System.Drawing.Image)
        Me.ToolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNuevo.Name = "ToolStripNuevo"
        Me.ToolStripNuevo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNuevo.Text = "ToolStripNuevo"
        Me.ToolStripNuevo.ToolTipText = "Ingresar un proveedor nuevo"
        '
        'ToolStripModificar
        '
        Me.ToolStripModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripModificar.Image = CType(resources.GetObject("ToolStripModificar.Image"), System.Drawing.Image)
        Me.ToolStripModificar.ImageTransparentColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripModificar.Name = "ToolStripModificar"
        Me.ToolStripModificar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripModificar.Text = "Modificar Proveedor"
        Me.ToolStripModificar.ToolTipText = "Modificar el nombre de un Proveedor"
        '
        'chkExterior
        '
        Me.chkExterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkExterior.AutoSize = True
        Me.chkExterior.BackColor = System.Drawing.Color.DarkGray
        Me.chkExterior.ForeColor = System.Drawing.Color.Black
        Me.chkExterior.Location = New System.Drawing.Point(175, 104)
        Me.chkExterior.Name = "chkExterior"
        Me.chkExterior.Size = New System.Drawing.Size(84, 16)
        Me.chkExterior.TabIndex = 1
        Me.chkExterior.Text = "Es Exterior"
        Me.chkExterior.UseVisualStyleBackColor = False
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.Location = New System.Drawing.Point(10, 98)
        Me.txtCuit.MaxLength = 20
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(159, 22)
        Me.txtCuit.TabIndex = 4
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.BackColor = System.Drawing.Color.DarkGray
        Me.lblRazonSocial.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.lblRazonSocial.Location = New System.Drawing.Point(7, 40)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(77, 12)
        Me.lblRazonSocial.TabIndex = 1
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'lblNroBeneficiario
        '
        Me.lblNroBeneficiario.AutoSize = True
        Me.lblNroBeneficiario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroBeneficiario.ForeColor = System.Drawing.Color.Black
        Me.lblNroBeneficiario.Location = New System.Drawing.Point(390, 39)
        Me.lblNroBeneficiario.Name = "lblNroBeneficiario"
        Me.lblNroBeneficiario.Size = New System.Drawing.Size(113, 12)
        Me.lblNroBeneficiario.TabIndex = 0
        Me.lblNroBeneficiario.Text = "Nro de Beneficiario"
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuit.ForeColor = System.Drawing.Color.Black
        Me.lblCuit.Location = New System.Drawing.Point(7, 82)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(115, 12)
        Me.lblCuit.TabIndex = 36
        Me.lblCuit.Text = "CUIT del Proveedor "
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRazonSocial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(9, 55)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(376, 22)
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtNroBeneficiario
        '
        Me.txtNroBeneficiario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBeneficiario.Location = New System.Drawing.Point(393, 55)
        Me.txtNroBeneficiario.MaxLength = 20
        Me.txtNroBeneficiario.Name = "txtNroBeneficiario"
        Me.txtNroBeneficiario.Size = New System.Drawing.Size(194, 22)
        Me.txtNroBeneficiario.TabIndex = 3
        '
        'txtExpedienteExistente
        '
        Me.txtExpedienteExistente.BackColor = System.Drawing.Color.White
        Me.txtExpedienteExistente.Enabled = False
        Me.txtExpedienteExistente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpedienteExistente.Location = New System.Drawing.Point(12, 484)
        Me.txtExpedienteExistente.MaxLength = 13
        Me.txtExpedienteExistente.Name = "txtExpedienteExistente"
        Me.txtExpedienteExistente.Size = New System.Drawing.Size(189, 22)
        Me.txtExpedienteExistente.TabIndex = 10
        Me.txtExpedienteExistente.Visible = False
        '
        'dtFechac
        '
        Me.dtFechac.Checked = False
        Me.dtFechac.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechac.Location = New System.Drawing.Point(18, 273)
        Me.dtFechac.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechac.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechac.Name = "dtFechac"
        Me.dtFechac.Size = New System.Drawing.Size(102, 22)
        Me.dtFechac.TabIndex = 5
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.White
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.Location = New System.Drawing.Point(466, 652)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(42, 42)
        Me.cmdEliminar.TabIndex = 75
        Me.cmdEliminar.UseVisualStyleBackColor = False
        Me.cmdEliminar.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton3"
        Me.ToolStripButton2.ToolTipText = "Blanquear Proveedor"
        '
        'mtxtArea
        '
        Me.mtxtArea.AutoSize = True
        Me.mtxtArea.BackColor = System.Drawing.Color.Transparent
        Me.mtxtArea.CodigoAnterior = Nothing
        Me.mtxtArea.Location = New System.Drawing.Point(15, 533)
        Me.mtxtArea.Name = "mtxtArea"
        Me.mtxtArea.Size = New System.Drawing.Size(577, 18)
        Me.mtxtArea.TabIndex = 11
        Me.mtxtArea.TipoOperacion = Nothing
        '
        'frmIngresodeComprobantesOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(637, 723)
        Me.Controls.Add(Me.grbComprobante)
        Me.Name = "frmIngresodeComprobantesOtros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grbComprobante.ResumeLayout(False)
        Me.grbComprobante.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClaseCOmp As System.Windows.Forms.Label
    Friend WithEvents lblTipoComprobante As System.Windows.Forms.Label
    Friend WithEvents cboClaseComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblErrorCoti As System.Windows.Forms.Label
    Friend WithEvents lblErrorCotizacion As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtcdComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorImporte As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblErrorComp As System.Windows.Forms.Label
    Friend WithEvents chkExcluir As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents txtdesglosar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPeriodicidad As System.Windows.Forms.TextBox
    Friend WithEvents cmdPeriodicidad As System.Windows.Forms.Button
    Friend WithEvents btnDesactivar As System.Windows.Forms.Button
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblPeriodicidad As System.Windows.Forms.Label
    Friend WithEvents cboPeriodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoPeriodicidad As System.Windows.Forms.Label
    Friend WithEvents cboTipoPeriodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblImporteC As System.Windows.Forms.Label
    Friend WithEvents txtImporteC As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregarComp As System.Windows.Forms.Button
    Friend WithEvents lblCotizacion As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents mtxtArea As Facturas.mTxtAutoComplete
    Friend WithEvents txtcdExpediente As System.Windows.Forms.TextBox
    Public WithEvents grbComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents dtFechac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtExpedienteExistente As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbProveedor As GroupBox
    Friend WithEvents chkProveedorExp As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripNuevo As ToolStripButton
    Friend WithEvents ToolStripModificar As ToolStripButton
    Friend WithEvents chkExterior As CheckBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblNroBeneficiario As Label
    Friend WithEvents lblCuit As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtNroBeneficiario As TextBox
    Friend WithEvents lblErrorProv As Label
    Friend WithEvents txtcdProveedor As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
