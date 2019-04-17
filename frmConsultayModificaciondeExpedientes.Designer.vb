<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultayModificaciondeExpedientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultayModificaciondeExpedientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxFiltrosBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboEtapa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckbSinExpRel = New System.Windows.Forms.CheckBox()
        Me.MtxtAreaMovimiento = New Facturas.mTxtAutoComplete()
        Me.cmdbuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxtAreaE = New Facturas.mTxtAutoComplete()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cboTipoExpediente = New System.Windows.Forms.ComboBox()
        Me.lblTipoExpediente = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblNroComprobante = New System.Windows.Forms.Label()
        Me.txtNroComprobante = New System.Windows.Forms.TextBox()
        Me.cboTipoC = New System.Windows.Forms.ComboBox()
        Me.lblTipoC = New System.Windows.Forms.Label()
        Me.cboClaseC = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaH = New System.Windows.Forms.Label()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblNroExpediente = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtExpediente = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.cboEstadoE = New System.Windows.Forms.ComboBox()
        Me.cboEstado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblExplicacolorfilasE = New System.Windows.Forms.Label()
        Me.lblCantExp = New System.Windows.Forms.Label()
        Me.lblExplicacolorfilasET = New System.Windows.Forms.Label()
        Me.dgvlistadoExpedientes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTmenu = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.cdExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsNroExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsRazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsCuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsNroBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdEsExterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdTipoExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsTipoExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsComprobantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlPesos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlDolar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlEuro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlsf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdMovExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFechaMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsEtapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdDesglosado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdExpedienteRel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsExpedienteRel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gbxFiltrosBusqueda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvlistadoExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTmenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxFiltrosBusqueda
        '
        Me.gbxFiltrosBusqueda.BackColor = System.Drawing.Color.DarkGray
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboEtapa)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.Label3)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.ckbSinExpRel)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.MtxtAreaMovimiento)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cmdbuscar)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.Label2)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.mtxtAreaE)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblArea)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboTipoExpediente)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblTipoExpediente)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtGrupo)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblObservacion)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtObservacion)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.CheckBox1)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblNroComprobante)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtNroComprobante)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboTipoC)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblTipoC)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboClaseC)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.Label1)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.dtHasta)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblFechaH)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.dtDesde)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblNroExpediente)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtRazonSocial)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtExpediente)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblRazonSocial)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblCuit)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.txtCuit)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.lblFechaD)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboEstadoE)
        Me.gbxFiltrosBusqueda.Controls.Add(Me.cboEstado)
        Me.gbxFiltrosBusqueda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltrosBusqueda.ForeColor = System.Drawing.Color.Black
        Me.gbxFiltrosBusqueda.Location = New System.Drawing.Point(12, 50)
        Me.gbxFiltrosBusqueda.Name = "gbxFiltrosBusqueda"
        Me.gbxFiltrosBusqueda.Size = New System.Drawing.Size(1166, 239)
        Me.gbxFiltrosBusqueda.TabIndex = 3
        Me.gbxFiltrosBusqueda.TabStop = False
        Me.gbxFiltrosBusqueda.Text = "Ingresar Filtros de Búsqueda"
        '
        'cboEtapa
        '
        Me.cboEtapa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEtapa.FormattingEnabled = True
        Me.cboEtapa.Location = New System.Drawing.Point(225, 193)
        Me.cboEtapa.Name = "cboEtapa"
        Me.cboEtapa.Size = New System.Drawing.Size(144, 21)
        Me.cboEtapa.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(223, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 12)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Etapa del Movimiento"
        '
        'ckbSinExpRel
        '
        Me.ckbSinExpRel.AutoSize = True
        Me.ckbSinExpRel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbSinExpRel.ForeColor = System.Drawing.Color.Black
        Me.ckbSinExpRel.Location = New System.Drawing.Point(853, 134)
        Me.ckbSinExpRel.Name = "ckbSinExpRel"
        Me.ckbSinExpRel.Size = New System.Drawing.Size(205, 16)
        Me.ckbSinExpRel.TabIndex = 43
        Me.ckbSinExpRel.Text = "No incluir expedientes anexados"
        Me.ckbSinExpRel.UseVisualStyleBackColor = True
        '
        'MtxtAreaMovimiento
        '
        Me.MtxtAreaMovimiento.AutoSize = True
        Me.MtxtAreaMovimiento.BackColor = System.Drawing.Color.Transparent
        Me.MtxtAreaMovimiento.CodigoAnterior = Nothing
        Me.MtxtAreaMovimiento.Location = New System.Drawing.Point(12, 195)
        Me.MtxtAreaMovimiento.Name = "MtxtAreaMovimiento"
        Me.MtxtAreaMovimiento.Size = New System.Drawing.Size(199, 19)
        Me.MtxtAreaMovimiento.TabIndex = 42
        Me.MtxtAreaMovimiento.TipoOperacion = Nothing
        '
        'cmdbuscar
        '
        Me.cmdbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbuscar.ForeColor = System.Drawing.Color.Black
        Me.cmdbuscar.Image = CType(resources.GetObject("cmdbuscar.Image"), System.Drawing.Image)
        Me.cmdbuscar.Location = New System.Drawing.Point(570, 187)
        Me.cmdbuscar.Name = "cmdbuscar"
        Me.cmdbuscar.Size = New System.Drawing.Size(53, 30)
        Me.cmdbuscar.TabIndex = 13
        Me.cmdbuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 12)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Area del último Movimiento"
        '
        'mtxtAreaE
        '
        Me.mtxtAreaE.AutoSize = True
        Me.mtxtAreaE.BackColor = System.Drawing.Color.Transparent
        Me.mtxtAreaE.CodigoAnterior = Nothing
        Me.mtxtAreaE.Location = New System.Drawing.Point(537, 135)
        Me.mtxtAreaE.Name = "mtxtAreaE"
        Me.mtxtAreaE.Size = New System.Drawing.Size(310, 20)
        Me.mtxtAreaE.TabIndex = 40
        Me.mtxtAreaE.TipoOperacion = Nothing
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.Location = New System.Drawing.Point(535, 120)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(117, 12)
        Me.lblArea.TabIndex = 39
        Me.lblArea.Text = "Area del Expediente"
        '
        'cboTipoExpediente
        '
        Me.cboTipoExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoExpediente.FormattingEnabled = True
        Me.cboTipoExpediente.Location = New System.Drawing.Point(225, 135)
        Me.cboTipoExpediente.Name = "cboTipoExpediente"
        Me.cboTipoExpediente.Size = New System.Drawing.Size(144, 21)
        Me.cboTipoExpediente.TabIndex = 10
        '
        'lblTipoExpediente
        '
        Me.lblTipoExpediente.AutoSize = True
        Me.lblTipoExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoExpediente.ForeColor = System.Drawing.Color.Black
        Me.lblTipoExpediente.Location = New System.Drawing.Point(222, 120)
        Me.lblTipoExpediente.Name = "lblTipoExpediente"
        Me.lblTipoExpediente.Size = New System.Drawing.Size(114, 12)
        Me.lblTipoExpediente.TabIndex = 38
        Me.lblTipoExpediente.Text = "Tipo del Expediente"
        '
        'txtGrupo
        '
        Me.txtGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.Location = New System.Drawing.Point(689, 32)
        Me.txtGrupo.MaxLength = 9
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(137, 22)
        Me.txtGrupo.TabIndex = 37
        Me.txtGrupo.Visible = False
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacion.ForeColor = System.Drawing.Color.Black
        Me.lblObservacion.Location = New System.Drawing.Point(531, 71)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(76, 12)
        Me.lblObservacion.TabIndex = 36
        Me.lblObservacion.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(533, 86)
        Me.txtObservacion.MaxLength = 100
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(310, 22)
        Me.txtObservacion.TabIndex = 7
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(853, 94)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(175, 16)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Solo Pendientes de liquidar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.AutoSize = True
        Me.lblNroComprobante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroComprobante.ForeColor = System.Drawing.Color.Black
        Me.lblNroComprobante.Location = New System.Drawing.Point(9, 72)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(121, 12)
        Me.lblNroComprobante.TabIndex = 33
        Me.lblNroComprobante.Text = "Nro de Comprobante"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroComprobante.Location = New System.Drawing.Point(12, 87)
        Me.txtNroComprobante.MaxLength = 13
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(199, 22)
        Me.txtNroComprobante.TabIndex = 32
        '
        'cboTipoC
        '
        Me.cboTipoC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoC.FormattingEnabled = True
        Me.cboTipoC.Location = New System.Drawing.Point(386, 87)
        Me.cboTipoC.Name = "cboTipoC"
        Me.cboTipoC.Size = New System.Drawing.Size(144, 21)
        Me.cboTipoC.TabIndex = 4
        '
        'lblTipoC
        '
        Me.lblTipoC.AutoSize = True
        Me.lblTipoC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoC.ForeColor = System.Drawing.Color.Black
        Me.lblTipoC.Location = New System.Drawing.Point(385, 72)
        Me.lblTipoC.Name = "lblTipoC"
        Me.lblTipoC.Size = New System.Drawing.Size(125, 12)
        Me.lblTipoC.TabIndex = 31
        Me.lblTipoC.Text = "Tipo de Comprobante"
        '
        'cboClaseC
        '
        Me.cboClaseC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClaseC.FormattingEnabled = True
        Me.cboClaseC.Location = New System.Drawing.Point(224, 87)
        Me.cboClaseC.Name = "cboClaseC"
        Me.cboClaseC.Size = New System.Drawing.Size(144, 21)
        Me.cboClaseC.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(223, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 12)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Clase de Comprobante"
        '
        'dtHasta
        '
        Me.dtHasta.CalendarForeColor = System.Drawing.Color.SteelBlue
        Me.dtHasta.CalendarTitleBackColor = System.Drawing.Color.SteelBlue
        Me.dtHasta.CalendarTitleForeColor = System.Drawing.Color.SteelBlue
        Me.dtHasta.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue
        Me.dtHasta.Checked = False
        Me.dtHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(477, 193)
        Me.dtHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtHasta.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtHasta.TabIndex = 12
        '
        'lblFechaH
        '
        Me.lblFechaH.AutoSize = True
        Me.lblFechaH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaH.ForeColor = System.Drawing.Color.Black
        Me.lblFechaH.Location = New System.Drawing.Point(475, 178)
        Me.lblFechaH.Name = "lblFechaH"
        Me.lblFechaH.Size = New System.Drawing.Size(74, 12)
        Me.lblFechaH.TabIndex = 27
        Me.lblFechaH.Text = "Fecha hasta"
        '
        'dtDesde
        '
        Me.dtDesde.CalendarForeColor = System.Drawing.Color.SteelBlue
        Me.dtDesde.CalendarTitleBackColor = System.Drawing.Color.SteelBlue
        Me.dtDesde.CalendarTitleForeColor = System.Drawing.Color.SteelBlue
        Me.dtDesde.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue
        Me.dtDesde.Checked = False
        Me.dtDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(389, 193)
        Me.dtDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtDesde.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtDesde.TabIndex = 11
        '
        'lblNroExpediente
        '
        Me.lblNroExpediente.AutoSize = True
        Me.lblNroExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroExpediente.ForeColor = System.Drawing.Color.Black
        Me.lblNroExpediente.Location = New System.Drawing.Point(9, 119)
        Me.lblNroExpediente.Name = "lblNroExpediente"
        Me.lblNroExpediente.Size = New System.Drawing.Size(107, 12)
        Me.lblNroExpediente.TabIndex = 25
        Me.lblNroExpediente.Text = "Nro de Expediente"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(12, 32)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(593, 22)
        Me.txtRazonSocial.TabIndex = 1
        '
        'txtExpediente
        '
        Me.txtExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpediente.Location = New System.Drawing.Point(12, 134)
        Me.txtExpediente.MaxLength = 13
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.Size = New System.Drawing.Size(199, 22)
        Me.txtExpediente.TabIndex = 8
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.lblRazonSocial.Location = New System.Drawing.Point(9, 18)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(77, 12)
        Me.lblRazonSocial.TabIndex = 1
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuit.ForeColor = System.Drawing.Color.Black
        Me.lblCuit.Location = New System.Drawing.Point(611, 18)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(112, 12)
        Me.lblCuit.TabIndex = 0
        Me.lblCuit.Text = "CUIT del Proveedor"
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.Location = New System.Drawing.Point(611, 32)
        Me.txtCuit.MaxLength = 10
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(236, 22)
        Me.txtCuit.TabIndex = 2
        '
        'lblFechaD
        '
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaD.ForeColor = System.Drawing.Color.Black
        Me.lblFechaD.Location = New System.Drawing.Point(387, 178)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(77, 12)
        Me.lblFechaD.TabIndex = 14
        Me.lblFechaD.Text = "Fecha desde"
        '
        'cboEstadoE
        '
        Me.cboEstadoE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoE.FormattingEnabled = True
        Me.cboEstadoE.Location = New System.Drawing.Point(387, 134)
        Me.cboEstadoE.Name = "cboEstadoE"
        Me.cboEstadoE.Size = New System.Drawing.Size(143, 21)
        Me.cboEstadoE.TabIndex = 9
        '
        'cboEstado
        '
        Me.cboEstado.AutoSize = True
        Me.cboEstado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Location = New System.Drawing.Point(384, 120)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(128, 12)
        Me.cboEstado.TabIndex = 3
        Me.cboEstado.Text = "Estado del Expediente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.lblExplicacolorfilasE)
        Me.GroupBox1.Controls.Add(Me.lblCantExp)
        Me.GroupBox1.Controls.Add(Me.lblExplicacolorfilasET)
        Me.GroupBox1.Controls.Add(Me.dgvlistadoExpedientes)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1166, 474)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expedientes encontrados"
        '
        'lblExplicacolorfilasE
        '
        Me.lblExplicacolorfilasE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExplicacolorfilasE.AutoSize = True
        Me.lblExplicacolorfilasE.BackColor = System.Drawing.Color.LightBlue
        Me.lblExplicacolorfilasE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacolorfilasE.ForeColor = System.Drawing.Color.White
        Me.lblExplicacolorfilasE.Location = New System.Drawing.Point(9, 23)
        Me.lblExplicacolorfilasE.Name = "lblExplicacolorfilasE"
        Me.lblExplicacolorfilasE.Size = New System.Drawing.Size(124, 12)
        Me.lblExplicacolorfilasE.TabIndex = 16
        Me.lblExplicacolorfilasE.Text = "EGRESO RECUPERAR"
        '
        'lblCantExp
        '
        Me.lblCantExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantExp.AutoSize = True
        Me.lblCantExp.BackColor = System.Drawing.Color.DarkGray
        Me.lblCantExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantExp.ForeColor = System.Drawing.Color.Black
        Me.lblCantExp.Location = New System.Drawing.Point(5, 457)
        Me.lblCantExp.Name = "lblCantExp"
        Me.lblCantExp.Size = New System.Drawing.Size(194, 12)
        Me.lblCantExp.TabIndex = 9
        Me.lblCantExp.Text = "Se encontraron 9999 expedientes"
        '
        'lblExplicacolorfilasET
        '
        Me.lblExplicacolorfilasET.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExplicacolorfilasET.AutoSize = True
        Me.lblExplicacolorfilasET.BackColor = System.Drawing.Color.Plum
        Me.lblExplicacolorfilasET.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacolorfilasET.ForeColor = System.Drawing.Color.White
        Me.lblExplicacolorfilasET.Location = New System.Drawing.Point(136, 23)
        Me.lblExplicacolorfilasET.Name = "lblExplicacolorfilasET"
        Me.lblExplicacolorfilasET.Size = New System.Drawing.Size(122, 12)
        Me.lblExplicacolorfilasET.TabIndex = 15
        Me.lblExplicacolorfilasET.Text = "EGRESO TERMINADO"
        '
        'dgvlistadoExpedientes
        '
        Me.dgvlistadoExpedientes.AllowUserToAddRows = False
        Me.dgvlistadoExpedientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvlistadoExpedientes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvlistadoExpedientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvlistadoExpedientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlistadoExpedientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlistadoExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistadoExpedientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdExpediente, Me.dsNroExpediente, Me.dtFecha, Me.cdProveedor, Me.dsRazonSocial, Me.dsCuit, Me.dsNroBeneficiario, Me.cdEsExterior, Me.cdTipoExpediente, Me.dsTipoExpediente, Me.cdArea, Me.dsArea, Me.dsComprobantes, Me.vlPesos, Me.vlDolar, Me.vlEuro, Me.vlsf, Me.cdMovExpediente, Me.dtFechaMov, Me.dsEtapa, Me.cdSeguimiento, Me.sObservacion, Me.cdEstado, Me.cdDesglosado, Me.cdExpedienteRel, Me.dsExpedienteRel, Me.colEdit, Me.colEliminar})
        Me.dgvlistadoExpedientes.GridColor = System.Drawing.Color.DarkGray
        Me.dgvlistadoExpedientes.Location = New System.Drawing.Point(8, 39)
        Me.dgvlistadoExpedientes.MultiSelect = False
        Me.dgvlistadoExpedientes.Name = "dgvlistadoExpedientes"
        Me.dgvlistadoExpedientes.ReadOnly = True
        Me.dgvlistadoExpedientes.RowHeadersVisible = False
        Me.dgvlistadoExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistadoExpedientes.Size = New System.Drawing.Size(1152, 415)
        Me.dgvlistadoExpedientes.TabIndex = 14
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 105.9127!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "Facturacion.My.Resources.Resources.action_stop1"
        Me.DataGridViewImageColumn1.Width = 86
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 91.70046!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ToolTipText = "Facturacion.My.Resources.Resources.edit"
        Me.DataGridViewImageColumn2.Width = 75
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.FillWeight = 91.43104!
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ToolTipText = "acturacion.My.Resources.Resources.lupa"
        Me.DataGridViewImageColumn3.Width = 75
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.DarkGray
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(9, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(164, 12)
        Me.lblTitulo.TabIndex = 43
        Me.lblTitulo.Text = "BÚSQUEDA DE EXPEDIENTES"
        '
        'pnlTmenu
        '
        Me.pnlTmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTmenu.Controls.Add(Me.ToolStrip1)
        Me.pnlTmenu.Location = New System.Drawing.Point(0, 21)
        Me.pnlTmenu.Name = "pnlTmenu"
        Me.pnlTmenu.Size = New System.Drawing.Size(1188, 23)
        Me.pnlTmenu.TabIndex = 42
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMenu, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1188, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsMenu
        '
        Me.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tsMenu.Image = CType(resources.GetObject("tsMenu.Image"), System.Drawing.Image)
        Me.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsMenu.Size = New System.Drawing.Size(23, 22)
        Me.tsMenu.Text = "Ingresar Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'cdExpediente
        '
        Me.cdExpediente.DataPropertyName = "cdExpediente"
        Me.cdExpediente.HeaderText = "cdExpediente"
        Me.cdExpediente.Name = "cdExpediente"
        Me.cdExpediente.ReadOnly = True
        Me.cdExpediente.ToolTipText = "ToolTip1"
        Me.cdExpediente.Visible = False
        '
        'dsNroExpediente
        '
        Me.dsNroExpediente.DataPropertyName = "dsNroExpediente"
        Me.dsNroExpediente.FillWeight = 26.74002!
        Me.dsNroExpediente.HeaderText = "Nro Expediente"
        Me.dsNroExpediente.Name = "dsNroExpediente"
        Me.dsNroExpediente.ReadOnly = True
        Me.dsNroExpediente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dsNroExpediente.Width = 80
        '
        'dtFecha
        '
        Me.dtFecha.DataPropertyName = "dtFecha"
        Me.dtFecha.FillWeight = 20.05502!
        Me.dtFecha.HeaderText = "Fecha"
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.ReadOnly = True
        Me.dtFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dtFecha.Width = 70
        '
        'cdProveedor
        '
        Me.cdProveedor.DataPropertyName = "cdProveedor"
        Me.cdProveedor.HeaderText = "cdProveedor"
        Me.cdProveedor.Name = "cdProveedor"
        Me.cdProveedor.ReadOnly = True
        Me.cdProveedor.Visible = False
        '
        'dsRazonSocial
        '
        Me.dsRazonSocial.DataPropertyName = "dsRazonSocial"
        Me.dsRazonSocial.FillWeight = 26.74002!
        Me.dsRazonSocial.HeaderText = "RazonSocial"
        Me.dsRazonSocial.Name = "dsRazonSocial"
        Me.dsRazonSocial.ReadOnly = True
        Me.dsRazonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dsRazonSocial.Width = 170
        '
        'dsCuit
        '
        Me.dsCuit.DataPropertyName = "dsCuit"
        Me.dsCuit.FillWeight = 20.05502!
        Me.dsCuit.HeaderText = "Cuit"
        Me.dsCuit.Name = "dsCuit"
        Me.dsCuit.ReadOnly = True
        Me.dsCuit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dsCuit.Visible = False
        Me.dsCuit.Width = 120
        '
        'dsNroBeneficiario
        '
        Me.dsNroBeneficiario.DataPropertyName = "dsNroBeneficiario"
        Me.dsNroBeneficiario.HeaderText = "dsNroBeneficiario"
        Me.dsNroBeneficiario.Name = "dsNroBeneficiario"
        Me.dsNroBeneficiario.ReadOnly = True
        Me.dsNroBeneficiario.Visible = False
        '
        'cdEsExterior
        '
        Me.cdEsExterior.DataPropertyName = "cdEsExterior"
        Me.cdEsExterior.HeaderText = "cdEsExterior"
        Me.cdEsExterior.Name = "cdEsExterior"
        Me.cdEsExterior.ReadOnly = True
        Me.cdEsExterior.Visible = False
        '
        'cdTipoExpediente
        '
        Me.cdTipoExpediente.DataPropertyName = "cdTipoExpediente"
        Me.cdTipoExpediente.HeaderText = "cdTipoExpediente"
        Me.cdTipoExpediente.Name = "cdTipoExpediente"
        Me.cdTipoExpediente.ReadOnly = True
        Me.cdTipoExpediente.Visible = False
        '
        'dsTipoExpediente
        '
        Me.dsTipoExpediente.DataPropertyName = "dsTipoExpediente"
        Me.dsTipoExpediente.HeaderText = "Tipo de Expediente"
        Me.dsTipoExpediente.Name = "dsTipoExpediente"
        Me.dsTipoExpediente.ReadOnly = True
        Me.dsTipoExpediente.Visible = False
        '
        'cdArea
        '
        Me.cdArea.DataPropertyName = "cdArea"
        Me.cdArea.HeaderText = "cdArea"
        Me.cdArea.Name = "cdArea"
        Me.cdArea.ReadOnly = True
        Me.cdArea.Visible = False
        '
        'dsArea
        '
        Me.dsArea.DataPropertyName = "dsArea"
        Me.dsArea.HeaderText = "dsArea"
        Me.dsArea.Name = "dsArea"
        Me.dsArea.ReadOnly = True
        Me.dsArea.Visible = False
        '
        'dsComprobantes
        '
        Me.dsComprobantes.DataPropertyName = "dsComprobantes"
        Me.dsComprobantes.HeaderText = "Comprobantes"
        Me.dsComprobantes.Name = "dsComprobantes"
        Me.dsComprobantes.ReadOnly = True
        '
        'vlPesos
        '
        Me.vlPesos.DataPropertyName = "vlPesos"
        Me.vlPesos.HeaderText = "Importe en Pesos"
        Me.vlPesos.Name = "vlPesos"
        Me.vlPesos.ReadOnly = True
        Me.vlPesos.Width = 90
        '
        'vlDolar
        '
        Me.vlDolar.DataPropertyName = "vlDolar"
        Me.vlDolar.HeaderText = "Importe en Dólares"
        Me.vlDolar.Name = "vlDolar"
        Me.vlDolar.ReadOnly = True
        Me.vlDolar.Width = 90
        '
        'vlEuro
        '
        Me.vlEuro.DataPropertyName = "vlEuro"
        Me.vlEuro.HeaderText = "Importe en Euros"
        Me.vlEuro.Name = "vlEuro"
        Me.vlEuro.ReadOnly = True
        Me.vlEuro.Width = 90
        '
        'vlsf
        '
        Me.vlsf.DataPropertyName = "vlsf"
        Me.vlsf.HeaderText = "Importe en CHF"
        Me.vlsf.Name = "vlsf"
        Me.vlsf.ReadOnly = True
        '
        'cdMovExpediente
        '
        Me.cdMovExpediente.DataPropertyName = "dsDescUltMov"
        Me.cdMovExpediente.HeaderText = "Movimientos del Expediente"
        Me.cdMovExpediente.Name = "cdMovExpediente"
        Me.cdMovExpediente.ReadOnly = True
        Me.cdMovExpediente.Width = 80
        '
        'dtFechaMov
        '
        Me.dtFechaMov.DataPropertyName = "dtFechaMov"
        Me.dtFechaMov.HeaderText = "Fecha del Movimiento"
        Me.dtFechaMov.Name = "dtFechaMov"
        Me.dtFechaMov.ReadOnly = True
        Me.dtFechaMov.Width = 80
        '
        'dsEtapa
        '
        Me.dsEtapa.DataPropertyName = "dsEtapa"
        Me.dsEtapa.HeaderText = "Etapa del Movimiento"
        Me.dsEtapa.Name = "dsEtapa"
        Me.dsEtapa.ReadOnly = True
        Me.dsEtapa.Width = 80
        '
        'cdSeguimiento
        '
        Me.cdSeguimiento.DataPropertyName = "cdSeguimiento"
        Me.cdSeguimiento.HeaderText = "cdSeguimiento"
        Me.cdSeguimiento.Name = "cdSeguimiento"
        Me.cdSeguimiento.ReadOnly = True
        Me.cdSeguimiento.Visible = False
        '
        'sObservacion
        '
        Me.sObservacion.DataPropertyName = "sObservacion"
        Me.sObservacion.HeaderText = "Observación"
        Me.sObservacion.Name = "sObservacion"
        Me.sObservacion.ReadOnly = True
        Me.sObservacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.sObservacion.Width = 80
        '
        'cdEstado
        '
        Me.cdEstado.DataPropertyName = "cdEstado"
        Me.cdEstado.HeaderText = "cdEstado"
        Me.cdEstado.Name = "cdEstado"
        Me.cdEstado.ReadOnly = True
        Me.cdEstado.Visible = False
        '
        'cdDesglosado
        '
        Me.cdDesglosado.DataPropertyName = "cdDesglosado"
        Me.cdDesglosado.HeaderText = "cdDesglosado"
        Me.cdDesglosado.Name = "cdDesglosado"
        Me.cdDesglosado.ReadOnly = True
        Me.cdDesglosado.Visible = False
        '
        'cdExpedienteRel
        '
        Me.cdExpedienteRel.DataPropertyName = "cdExpedienteRel"
        Me.cdExpedienteRel.HeaderText = "cdExpedienteRel"
        Me.cdExpedienteRel.Name = "cdExpedienteRel"
        Me.cdExpedienteRel.ReadOnly = True
        Me.cdExpedienteRel.Visible = False
        Me.cdExpedienteRel.Width = 5
        '
        'dsExpedienteRel
        '
        Me.dsExpedienteRel.DataPropertyName = "dsExpedienteRel"
        Me.dsExpedienteRel.HeaderText = "Nro. Expediente Relacionado"
        Me.dsExpedienteRel.Name = "dsExpedienteRel"
        Me.dsExpedienteRel.ReadOnly = True
        Me.dsExpedienteRel.Width = 80
        '
        'colEdit
        '
        Me.colEdit.HeaderText = ""
        Me.colEdit.Image = CType(resources.GetObject("colEdit.Image"), System.Drawing.Image)
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Width = 30
        '
        'colEliminar
        '
        Me.colEliminar.HeaderText = ""
        Me.colEliminar.Image = CType(resources.GetObject("colEliminar.Image"), System.Drawing.Image)
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.ReadOnly = True
        Me.colEliminar.Width = 30
        '
        'frmConsultayModificaciondeExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1190, 799)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlTmenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxFiltrosBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultayModificaciondeExpedientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.Color.LightYellow
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbxFiltrosBusqueda.ResumeLayout(False)
        Me.gbxFiltrosBusqueda.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvlistadoExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTmenu.ResumeLayout(False)
        Me.pnlTmenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxFiltrosBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cmdbuscar As System.Windows.Forms.Button
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaH As System.Windows.Forms.Label
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNroExpediente As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtExpediente As System.Windows.Forms.TextBox
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaD As System.Windows.Forms.Label
    Friend WithEvents cboEstadoE As System.Windows.Forms.ComboBox
    Friend WithEvents cboEstado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantExp As System.Windows.Forms.Label
    Friend WithEvents dgvlistadoExpedientes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlTmenu As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoC As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoC As System.Windows.Forms.Label
    Friend WithEvents cboClaseC As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoExpediente As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoExpediente As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents mtxtAreaE As Facturas.mTxtAutoComplete
    Friend WithEvents MtxtAreaMovimiento As Facturas.mTxtAutoComplete
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExplicacolorfilasET As System.Windows.Forms.Label
    Friend WithEvents lblExplicacolorfilasE As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ckbSinExpRel As System.Windows.Forms.CheckBox
    Friend WithEvents cboEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cdExpediente As DataGridViewTextBoxColumn
    Friend WithEvents dsNroExpediente As DataGridViewTextBoxColumn
    Friend WithEvents dtFecha As DataGridViewTextBoxColumn
    Friend WithEvents cdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents dsRazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents dsCuit As DataGridViewTextBoxColumn
    Friend WithEvents dsNroBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents cdEsExterior As DataGridViewTextBoxColumn
    Friend WithEvents cdTipoExpediente As DataGridViewTextBoxColumn
    Friend WithEvents dsTipoExpediente As DataGridViewTextBoxColumn
    Friend WithEvents cdArea As DataGridViewTextBoxColumn
    Friend WithEvents dsArea As DataGridViewTextBoxColumn
    Friend WithEvents dsComprobantes As DataGridViewTextBoxColumn
    Friend WithEvents vlPesos As DataGridViewTextBoxColumn
    Friend WithEvents vlDolar As DataGridViewTextBoxColumn
    Friend WithEvents vlEuro As DataGridViewTextBoxColumn
    Friend WithEvents vlsf As DataGridViewTextBoxColumn
    Friend WithEvents cdMovExpediente As DataGridViewTextBoxColumn
    Friend WithEvents dtFechaMov As DataGridViewTextBoxColumn
    Friend WithEvents dsEtapa As DataGridViewTextBoxColumn
    Friend WithEvents cdSeguimiento As DataGridViewTextBoxColumn
    Friend WithEvents sObservacion As DataGridViewTextBoxColumn
    Friend WithEvents cdEstado As DataGridViewTextBoxColumn
    Friend WithEvents cdDesglosado As DataGridViewTextBoxColumn
    Friend WithEvents cdExpedienteRel As DataGridViewTextBoxColumn
    Friend WithEvents dsExpedienteRel As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colEliminar As DataGridViewImageColumn
End Class
