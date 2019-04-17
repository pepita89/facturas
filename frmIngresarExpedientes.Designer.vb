<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresarExpedientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarExpedientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.colExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExcluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabSolapas = New System.Windows.Forms.TabControl()
        Me.TabComprobantes = New System.Windows.Forms.TabPage()
        Me.gbxComprobantesRel = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvComprobantesRel = New System.Windows.Forms.DataGridView()
        Me.cdExpediente1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdComprobante2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsNroExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsNroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFechaRel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdMonedaR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdClaseComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlImporteC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxDatosAsociados = New System.Windows.Forms.GroupBox()
        Me.lblDesglose = New System.Windows.Forms.Label()
        Me.cmdAgregarComp = New System.Windows.Forms.Button()
        Me.grbComprobante = New System.Windows.Forms.GroupBox()
        Me.lblAreaVC = New System.Windows.Forms.Label()
        Me.lblImporteCV = New System.Windows.Forms.Label()
        Me.lblCotizacionVC = New System.Windows.Forms.Label()
        Me.lblFechaVC = New System.Windows.Forms.Label()
        Me.lblNroComprobanteVC = New System.Windows.Forms.Label()
        Me.lblErrorCotizacion = New System.Windows.Forms.Label()
        Me.cmdModificarComprobante = New System.Windows.Forms.Button()
        Me.lblIValormporpesosVC = New System.Windows.Forms.Label()
        Me.lblIImporteVistaVC = New System.Windows.Forms.Label()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.colExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsComprobanteClaseTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcdMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdClaseComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdTipoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumcdPerio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsPerio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldtFechaDesde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldtFechaHasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.escdDesglose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsClaseComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumvlImporteFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlCotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsAbreviatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colver = New System.Windows.Forms.DataGridViewImageColumn()
        Me._Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.grxObservacion = New System.Windows.Forms.GroupBox()
        Me.txtObjeto = New System.Windows.Forms.RichTextBox()
        Me.cmdGuardarConvenio = New System.Windows.Forms.Button()
        Me.cmdModificarConvenio = New System.Windows.Forms.Button()
        Me.dtFechaC = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCotizacion = New System.Windows.Forms.Label()
        Me.txtCotMoneda = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblImporteO = New System.Windows.Forms.Label()
        Me.txtImporteOtros = New System.Windows.Forms.TextBox()
        Me.lblConvenio = New System.Windows.Forms.Label()
        Me.txtNroConvenio = New System.Windows.Forms.TextBox()
        Me.grpPeriodoServicio = New System.Windows.Forms.GroupBox()
        Me.btnDesactivarC = New System.Windows.Forms.Button()
        Me.dtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoPeriodicidad = New System.Windows.Forms.ComboBox()
        Me.cmdPeriodicidadC = New System.Windows.Forms.Button()
        Me.lblFechaHastaC = New System.Windows.Forms.Label()
        Me.lblFechaDesdeC = New System.Windows.Forms.Label()
        Me.lblPeriocidad = New System.Windows.Forms.Label()
        Me.cboPeriodicidadC = New System.Windows.Forms.ComboBox()
        Me.lblTipoPeriodo = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.lblObjeto = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rchObservacionO = New System.Windows.Forms.RichTextBox()
        Me.lblObservacionO = New System.Windows.Forms.Label()
        Me.TabAreas = New System.Windows.Forms.TabPage()
        Me.gbxUnidad = New System.Windows.Forms.GroupBox()
        Me.lblMensajeGrillaUnidad = New System.Windows.Forms.Label()
        Me.dgvUnidad = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblErrorunidad = New System.Windows.Forms.Label()
        Me.TabConceptos = New System.Windows.Forms.TabPage()
        Me.gbxObservacion = New System.Windows.Forms.GroupBox()
        Me.cmdAgregarConcepto = New System.Windows.Forms.Button()
        Me.dgvConceptos = New System.Windows.Forms.DataGridView()
        Me.ColumcdExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumcdSubConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumdsConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columSubConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumdsObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlDatosConceptos = New System.Windows.Forms.Panel()
        Me.txtObservacionesConceptos = New System.Windows.Forms.RichTextBox()
        Me.lblSubConcepto = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.lblErrorConceptos = New System.Windows.Forms.Label()
        Me.TabSeguimiento = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbxSolicitudes = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsNroExpSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdSolicitudEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlDatosMov = New System.Windows.Forms.Panel()
        Me.btnModificarSE = New System.Windows.Forms.Button()
        Me.lblAreaMovimiento = New System.Windows.Forms.Label()
        Me.rchObservacionMov = New System.Windows.Forms.RichTextBox()
        Me.lblAreaMov = New System.Windows.Forms.Label()
        Me.lblMovimiento = New System.Windows.Forms.Label()
        Me.lblObservMov = New System.Windows.Forms.Label()
        Me.cmdSeguimiento = New System.Windows.Forms.Button()
        Me.dgvSeguimiento = New System.Windows.Forms.DataGridView()
        Me.codSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columdsEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columcdArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columdsArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdEtapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsEtapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colum_ver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Columnedit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colum_delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabCabecera = New System.Windows.Forms.TabPage()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
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
        Me.gxpDatosExpediente = New System.Windows.Forms.GroupBox()
        Me.dsNroSolicitud = New System.Windows.Forms.TextBox()
        Me.txtcdSolicitud = New System.Windows.Forms.TextBox()
        Me.txtcdNroExpedienteRel = New System.Windows.Forms.TextBox()
        Me.txtNroExpedienteRel = New System.Windows.Forms.TextBox()
        Me.lblNroExpedienteRelacionado = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.txtcdExpediente = New System.Windows.Forms.TextBox()
        Me.txtNroExpediente = New System.Windows.Forms.TextBox()
        Me.cboTipoExpediente = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipoExp = New System.Windows.Forms.Label()
        Me.lblNroExpediente = New System.Windows.Forms.Label()
        Me.gxpListObservaciones = New System.Windows.Forms.GroupBox()
        Me.dgvComprobantesVer = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdDesglosado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvConceptosver = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarCabecera = New System.Windows.Forms.Button()
        Me.cmdModificarExp = New System.Windows.Forms.Button()
        Me.lblMensajeModificar = New System.Windows.Forms.Label()
        Me.rhcObservacionesE = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblErrorRS = New System.Windows.Forms.Label()
        Me.lblImpE = New System.Windows.Forms.Label()
        Me.lblImpD = New System.Windows.Forms.Label()
        Me.lblFechaV = New System.Windows.Forms.Label()
        Me.lblImpP = New System.Windows.Forms.Label()
        Me.lblProveedorV = New System.Windows.Forms.Label()
        Me.lblNroExpedienteV = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImporteD = New System.Windows.Forms.Label()
        Me.lblImporteE = New System.Windows.Forms.Label()
        Me.gpbDatosExp = New System.Windows.Forms.GroupBox()
        Me.lblExpedienteAnexado = New System.Windows.Forms.Label()
        Me.pnlProv = New System.Windows.Forms.Panel()
        Me.pnlValores = New System.Windows.Forms.Panel()
        Me.lblFs = New System.Windows.Forms.Label()
        Me.lblMensajeIngNuevo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTmenu = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsMenu = New System.Windows.Forms.ToolStripButton()
        Me.toolEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.mtxtArea = New Facturas.mTxtAutoComplete()
        Me.mtxtAreaE = New Facturas.mTxtAutoComplete()
        Me.lblCHF = New System.Windows.Forms.Label()
        Me.TabSolapas.SuspendLayout()
        Me.TabComprobantes.SuspendLayout()
        Me.gbxComprobantesRel.SuspendLayout()
        CType(Me.dgvComprobantesRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosAsociados.SuspendLayout()
        Me.grbComprobante.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grxObservacion.SuspendLayout()
        Me.grpPeriodoServicio.SuspendLayout()
        Me.TabAreas.SuspendLayout()
        Me.gbxUnidad.SuspendLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConceptos.SuspendLayout()
        Me.gbxObservacion.SuspendLayout()
        CType(Me.dgvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatosConceptos.SuspendLayout()
        Me.TabSeguimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxSolicitudes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatosMov.SuspendLayout()
        CType(Me.dgvSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCabecera.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.gxpDatosExpediente.SuspendLayout()
        Me.gxpListObservaciones.SuspendLayout()
        CType(Me.dgvComprobantesVer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConceptosver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosExp.SuspendLayout()
        Me.pnlProv.SuspendLayout()
        Me.pnlValores.SuspendLayout()
        Me.pnlTmenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colExpediente
        '
        Me.colExpediente.DataPropertyName = "colExpediente"
        Me.colExpediente.HeaderText = "cdExpediente"
        Me.colExpediente.Name = "colExpediente"
        Me.colExpediente.ReadOnly = True
        Me.colExpediente.Visible = False
        '
        'colExcluir
        '
        Me.colExcluir.HeaderText = "Excluir"
        Me.colExcluir.Image = CType(resources.GetObject("colExcluir.Image"), System.Drawing.Image)
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.ReadOnly = True
        '
        'TabSolapas
        '
        Me.TabSolapas.Controls.Add(Me.TabComprobantes)
        Me.TabSolapas.Controls.Add(Me.TabAreas)
        Me.TabSolapas.Controls.Add(Me.TabConceptos)
        Me.TabSolapas.Controls.Add(Me.TabSeguimiento)
        Me.TabSolapas.Controls.Add(Me.TabCabecera)
        Me.TabSolapas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSolapas.Location = New System.Drawing.Point(9, 131)
        Me.TabSolapas.Name = "TabSolapas"
        Me.TabSolapas.SelectedIndex = 0
        Me.TabSolapas.Size = New System.Drawing.Size(988, 776)
        Me.TabSolapas.TabIndex = 2
        '
        'TabComprobantes
        '
        Me.TabComprobantes.BackColor = System.Drawing.Color.DarkGray
        Me.TabComprobantes.Controls.Add(Me.gbxComprobantesRel)
        Me.TabComprobantes.Controls.Add(Me.gbxDatosAsociados)
        Me.TabComprobantes.Controls.Add(Me.grxObservacion)
        Me.TabComprobantes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabComprobantes.Location = New System.Drawing.Point(4, 21)
        Me.TabComprobantes.Name = "TabComprobantes"
        Me.TabComprobantes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabComprobantes.Size = New System.Drawing.Size(980, 751)
        Me.TabComprobantes.TabIndex = 0
        Me.TabComprobantes.Text = "Comprobantes"
        '
        'gbxComprobantesRel
        '
        Me.gbxComprobantesRel.BackColor = System.Drawing.Color.DarkGray
        Me.gbxComprobantesRel.Controls.Add(Me.TextBox1)
        Me.gbxComprobantesRel.Controls.Add(Me.dgvComprobantesRel)
        Me.gbxComprobantesRel.Controls.Add(Me.TextBox2)
        Me.gbxComprobantesRel.Controls.Add(Me.Label6)
        Me.gbxComprobantesRel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxComprobantesRel.ForeColor = System.Drawing.Color.Black
        Me.gbxComprobantesRel.Location = New System.Drawing.Point(567, 6)
        Me.gbxComprobantesRel.Name = "gbxComprobantesRel"
        Me.gbxComprobantesRel.Size = New System.Drawing.Size(455, 750)
        Me.gbxComprobantesRel.TabIndex = 83
        Me.gbxComprobantesRel.TabStop = False
        Me.gbxComprobantesRel.Text = "Comprobantes de Expedientes Anexados"
        Me.gbxComprobantesRel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(882, 44)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 22)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.Visible = False
        '
        'dgvComprobantesRel
        '
        Me.dgvComprobantesRel.AllowUserToAddRows = False
        Me.dgvComprobantesRel.AllowUserToDeleteRows = False
        Me.dgvComprobantesRel.AllowUserToOrderColumns = True
        Me.dgvComprobantesRel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComprobantesRel.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvComprobantesRel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComprobantesRel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComprobantesRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobantesRel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdExpediente1, Me.cdComprobante2, Me.dsNroExpediente, Me.dsNroComprobante, Me.dtFechaRel, Me.cdMonedaR, Me.DataGridViewTextBoxColumn27, Me.cdClaseComprobante, Me.vlImporteC})
        Me.dgvComprobantesRel.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvComprobantesRel.Location = New System.Drawing.Point(4, 14)
        Me.dgvComprobantesRel.MultiSelect = False
        Me.dgvComprobantesRel.Name = "dgvComprobantesRel"
        Me.dgvComprobantesRel.ReadOnly = True
        Me.dgvComprobantesRel.RowHeadersVisible = False
        Me.dgvComprobantesRel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvComprobantesRel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvComprobantesRel.Size = New System.Drawing.Size(403, 327)
        Me.dgvComprobantesRel.TabIndex = 82
        '
        'cdExpediente1
        '
        Me.cdExpediente1.DataPropertyName = "cdExpediente"
        Me.cdExpediente1.HeaderText = "colExp"
        Me.cdExpediente1.Name = "cdExpediente1"
        Me.cdExpediente1.ReadOnly = True
        Me.cdExpediente1.Visible = False
        '
        'cdComprobante2
        '
        Me.cdComprobante2.DataPropertyName = "cdComprobante"
        Me.cdComprobante2.HeaderText = "codComprobante"
        Me.cdComprobante2.Name = "cdComprobante2"
        Me.cdComprobante2.ReadOnly = True
        Me.cdComprobante2.Visible = False
        '
        'dsNroExpediente
        '
        Me.dsNroExpediente.DataPropertyName = "dsNroExpediente"
        Me.dsNroExpediente.FillWeight = 87.60152!
        Me.dsNroExpediente.HeaderText = "Nro. Expediente"
        Me.dsNroExpediente.Name = "dsNroExpediente"
        Me.dsNroExpediente.ReadOnly = True
        '
        'dsNroComprobante
        '
        Me.dsNroComprobante.DataPropertyName = "dsNroComprobante"
        Me.dsNroComprobante.FillWeight = 112.8276!
        Me.dsNroComprobante.HeaderText = "Nro.Comprobante"
        Me.dsNroComprobante.Name = "dsNroComprobante"
        Me.dsNroComprobante.ReadOnly = True
        '
        'dtFechaRel
        '
        Me.dtFechaRel.DataPropertyName = "dtFechaRel"
        Me.dtFechaRel.FillWeight = 118.2357!
        Me.dtFechaRel.HeaderText = "Fecha"
        Me.dtFechaRel.Name = "dtFechaRel"
        Me.dtFechaRel.ReadOnly = True
        '
        'cdMonedaR
        '
        Me.cdMonedaR.DataPropertyName = "cdMoneda"
        Me.cdMonedaR.HeaderText = "cdMonedaR"
        Me.cdMonedaR.Name = "cdMonedaR"
        Me.cdMonedaR.ReadOnly = True
        Me.cdMonedaR.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "dsMoneda"
        Me.DataGridViewTextBoxColumn27.FillWeight = 83.29709!
        Me.DataGridViewTextBoxColumn27.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'cdClaseComprobante
        '
        Me.cdClaseComprobante.DataPropertyName = "cdClaseComprobante"
        Me.cdClaseComprobante.HeaderText = "cdClaseComprobante"
        Me.cdClaseComprobante.Name = "cdClaseComprobante"
        Me.cdClaseComprobante.ReadOnly = True
        Me.cdClaseComprobante.Visible = False
        '
        'vlImporteC
        '
        Me.vlImporteC.DataPropertyName = "vlImporteC"
        Me.vlImporteC.FillWeight = 83.29709!
        Me.vlImporteC.HeaderText = "Monto"
        Me.vlImporteC.Name = "vlImporteC"
        Me.vlImporteC.ReadOnly = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(736, 43)
        Me.TextBox2.MaxLength = 13
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 22)
        Me.TextBox2.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(733, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Nro. del Expediente"
        '
        'gbxDatosAsociados
        '
        Me.gbxDatosAsociados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatosAsociados.BackColor = System.Drawing.Color.DarkGray
        Me.gbxDatosAsociados.Controls.Add(Me.lblDesglose)
        Me.gbxDatosAsociados.Controls.Add(Me.cmdAgregarComp)
        Me.gbxDatosAsociados.Controls.Add(Me.grbComprobante)
        Me.gbxDatosAsociados.Controls.Add(Me.cmdModificarComprobante)
        Me.gbxDatosAsociados.Controls.Add(Me.lblIValormporpesosVC)
        Me.gbxDatosAsociados.Controls.Add(Me.lblIImporteVistaVC)
        Me.gbxDatosAsociados.Controls.Add(Me.dgvlistado)
        Me.gbxDatosAsociados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosAsociados.ForeColor = System.Drawing.Color.Black
        Me.gbxDatosAsociados.Location = New System.Drawing.Point(0, 6)
        Me.gbxDatosAsociados.Name = "gbxDatosAsociados"
        Me.gbxDatosAsociados.Size = New System.Drawing.Size(559, 717)
        Me.gbxDatosAsociados.TabIndex = 7
        Me.gbxDatosAsociados.TabStop = False
        Me.gbxDatosAsociados.Text = "Comprobantes del expediente"
        '
        'lblDesglose
        '
        Me.lblDesglose.AutoSize = True
        Me.lblDesglose.BackColor = System.Drawing.Color.Plum
        Me.lblDesglose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesglose.ForeColor = System.Drawing.Color.Black
        Me.lblDesglose.Location = New System.Drawing.Point(47, 425)
        Me.lblDesglose.Name = "lblDesglose"
        Me.lblDesglose.Size = New System.Drawing.Size(455, 12)
        Me.lblDesglose.TabIndex = 81
        Me.lblDesglose.Text = "Las filas destacas en color purpura, se refieren a los comprobantes desglosados"
        Me.lblDesglose.Visible = False
        '
        'cmdAgregarComp
        '
        Me.cmdAgregarComp.Image = CType(resources.GetObject("cmdAgregarComp.Image"), System.Drawing.Image)
        Me.cmdAgregarComp.Location = New System.Drawing.Point(489, 374)
        Me.cmdAgregarComp.Name = "cmdAgregarComp"
        Me.cmdAgregarComp.Size = New System.Drawing.Size(39, 42)
        Me.cmdAgregarComp.TabIndex = 80
        Me.cmdAgregarComp.UseVisualStyleBackColor = True
        '
        'grbComprobante
        '
        Me.grbComprobante.BackColor = System.Drawing.Color.DarkGray
        Me.grbComprobante.Controls.Add(Me.lblAreaVC)
        Me.grbComprobante.Controls.Add(Me.lblImporteCV)
        Me.grbComprobante.Controls.Add(Me.lblCotizacionVC)
        Me.grbComprobante.Controls.Add(Me.lblFechaVC)
        Me.grbComprobante.Controls.Add(Me.lblNroComprobanteVC)
        Me.grbComprobante.Controls.Add(Me.lblErrorCotizacion)
        Me.grbComprobante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbComprobante.ForeColor = System.Drawing.Color.Black
        Me.grbComprobante.Location = New System.Drawing.Point(3, 447)
        Me.grbComprobante.Name = "grbComprobante"
        Me.grbComprobante.Size = New System.Drawing.Size(543, 264)
        Me.grbComprobante.TabIndex = 26
        Me.grbComprobante.TabStop = False
        Me.grbComprobante.Text = "Datos del  comprobante"
        Me.grbComprobante.Visible = False
        '
        'lblAreaVC
        '
        Me.lblAreaVC.AutoSize = True
        Me.lblAreaVC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaVC.ForeColor = System.Drawing.Color.Black
        Me.lblAreaVC.Location = New System.Drawing.Point(13, 179)
        Me.lblAreaVC.Name = "lblAreaVC"
        Me.lblAreaVC.Size = New System.Drawing.Size(49, 21)
        Me.lblAreaVC.TabIndex = 63
        Me.lblAreaVC.Text = "Area: "
        '
        'lblImporteCV
        '
        Me.lblImporteCV.AutoSize = True
        Me.lblImporteCV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteCV.ForeColor = System.Drawing.Color.Black
        Me.lblImporteCV.Location = New System.Drawing.Point(13, 110)
        Me.lblImporteCV.Name = "lblImporteCV"
        Me.lblImporteCV.Size = New System.Drawing.Size(72, 21)
        Me.lblImporteCV.TabIndex = 62
        Me.lblImporteCV.Text = "Importe: "
        '
        'lblCotizacionVC
        '
        Me.lblCotizacionVC.AutoSize = True
        Me.lblCotizacionVC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizacionVC.ForeColor = System.Drawing.Color.Black
        Me.lblCotizacionVC.Location = New System.Drawing.Point(13, 145)
        Me.lblCotizacionVC.Name = "lblCotizacionVC"
        Me.lblCotizacionVC.Size = New System.Drawing.Size(89, 21)
        Me.lblCotizacionVC.TabIndex = 61
        Me.lblCotizacionVC.Text = "Cotización: "
        '
        'lblFechaVC
        '
        Me.lblFechaVC.AutoSize = True
        Me.lblFechaVC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVC.ForeColor = System.Drawing.Color.Black
        Me.lblFechaVC.Location = New System.Drawing.Point(13, 72)
        Me.lblFechaVC.Name = "lblFechaVC"
        Me.lblFechaVC.Size = New System.Drawing.Size(57, 21)
        Me.lblFechaVC.TabIndex = 59
        Me.lblFechaVC.Text = "Fecha: "
        '
        'lblNroComprobanteVC
        '
        Me.lblNroComprobanteVC.AutoSize = True
        Me.lblNroComprobanteVC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroComprobanteVC.ForeColor = System.Drawing.Color.Black
        Me.lblNroComprobanteVC.Location = New System.Drawing.Point(13, 38)
        Me.lblNroComprobanteVC.Name = "lblNroComprobanteVC"
        Me.lblNroComprobanteVC.Size = New System.Drawing.Size(113, 21)
        Me.lblNroComprobanteVC.TabIndex = 58
        Me.lblNroComprobanteVC.Text = "Comprobante: "
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
        'cmdModificarComprobante
        '
        Me.cmdModificarComprobante.Enabled = False
        Me.cmdModificarComprobante.Image = CType(resources.GetObject("cmdModificarComprobante.Image"), System.Drawing.Image)
        Me.cmdModificarComprobante.Location = New System.Drawing.Point(449, 374)
        Me.cmdModificarComprobante.Name = "cmdModificarComprobante"
        Me.cmdModificarComprobante.Size = New System.Drawing.Size(39, 42)
        Me.cmdModificarComprobante.TabIndex = 79
        Me.cmdModificarComprobante.UseVisualStyleBackColor = True
        '
        'lblIValormporpesosVC
        '
        Me.lblIValormporpesosVC.AutoSize = True
        Me.lblIValormporpesosVC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIValormporpesosVC.ForeColor = System.Drawing.Color.Red
        Me.lblIValormporpesosVC.Location = New System.Drawing.Point(454, 349)
        Me.lblIValormporpesosVC.Name = "lblIValormporpesosVC"
        Me.lblIValormporpesosVC.Size = New System.Drawing.Size(29, 12)
        Me.lblIValormporpesosVC.TabIndex = 11
        Me.lblIValormporpesosVC.Text = "0,00"
        '
        'lblIImporteVistaVC
        '
        Me.lblIImporteVistaVC.AutoSize = True
        Me.lblIImporteVistaVC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIImporteVistaVC.ForeColor = System.Drawing.Color.Red
        Me.lblIImporteVistaVC.Location = New System.Drawing.Point(310, 349)
        Me.lblIImporteVistaVC.Name = "lblIImporteVistaVC"
        Me.lblIImporteVistaVC.Size = New System.Drawing.Size(142, 12)
        Me.lblIImporteVistaVC.TabIndex = 10
        Me.lblIImporteVistaVC.Text = "El importe total en pesos"
        '
        'dgvlistado
        '
        Me.dgvlistado.AllowUserToAddRows = False
        Me.dgvlistado.AllowUserToDeleteRows = False
        Me.dgvlistado.AllowUserToOrderColumns = True
        Me.dgvlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlistado.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvlistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExp, Me.codComprobante, Me.dsComprobante, Me.dsComprobanteClaseTipo, Me.dtFecha, Me.colcdMoneda, Me.dsMoneda, Me.monto, Me.cdClaseComp, Me.cdTipoC, Me.dsObservacion, Me.cdUnidad, Me.dsUnidad, Me.ColumcdPerio, Me.dsPerio, Me.cdProveedor, Me.dtFechaAlta, Me.coldtFechaDesde, Me.coldtFechaHasta, Me.escdDesglose, Me.dsClaseComprobante, Me.dsTipoComprobante, Me.ColumvlImporteFinal, Me.vlCotizacion, Me.dsAbreviatura, Me.colver, Me._Eliminar})
        Me.dgvlistado.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvlistado.Location = New System.Drawing.Point(5, 17)
        Me.dgvlistado.MultiSelect = False
        Me.dgvlistado.Name = "dgvlistado"
        Me.dgvlistado.ReadOnly = True
        Me.dgvlistado.RowHeadersVisible = False
        Me.dgvlistado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvlistado.Size = New System.Drawing.Size(523, 327)
        Me.dgvlistado.TabIndex = 8
        '
        'colExp
        '
        Me.colExp.DataPropertyName = "colExp"
        Me.colExp.HeaderText = "colExp"
        Me.colExp.Name = "colExp"
        Me.colExp.ReadOnly = True
        Me.colExp.Visible = False
        '
        'codComprobante
        '
        Me.codComprobante.DataPropertyName = "codComprobante"
        Me.codComprobante.HeaderText = "codComprobante"
        Me.codComprobante.Name = "codComprobante"
        Me.codComprobante.ReadOnly = True
        Me.codComprobante.Visible = False
        '
        'dsComprobante
        '
        Me.dsComprobante.DataPropertyName = "dsComprobante"
        Me.dsComprobante.HeaderText = "Nro.Comprobante"
        Me.dsComprobante.Name = "dsComprobante"
        Me.dsComprobante.ReadOnly = True
        Me.dsComprobante.Visible = False
        '
        'dsComprobanteClaseTipo
        '
        Me.dsComprobanteClaseTipo.DataPropertyName = "dsComprobanteClaseTipo"
        Me.dsComprobanteClaseTipo.FillWeight = 102.5475!
        Me.dsComprobanteClaseTipo.HeaderText = "Nro.Comprobante"
        Me.dsComprobanteClaseTipo.Name = "dsComprobanteClaseTipo"
        Me.dsComprobanteClaseTipo.ReadOnly = True
        '
        'dtFecha
        '
        Me.dtFecha.DataPropertyName = "dtFecha"
        Me.dtFecha.FillWeight = 102.5475!
        Me.dtFecha.HeaderText = "Fecha"
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.ReadOnly = True
        '
        'colcdMoneda
        '
        Me.colcdMoneda.DataPropertyName = "cdMoneda"
        Me.colcdMoneda.HeaderText = "cdMoneda"
        Me.colcdMoneda.Name = "colcdMoneda"
        Me.colcdMoneda.ReadOnly = True
        Me.colcdMoneda.Visible = False
        '
        'dsMoneda
        '
        Me.dsMoneda.DataPropertyName = "dsMoneda"
        Me.dsMoneda.FillWeight = 102.5475!
        Me.dsMoneda.HeaderText = "Moneda"
        Me.dsMoneda.Name = "dsMoneda"
        Me.dsMoneda.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.FillWeight = 102.5475!
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'cdClaseComp
        '
        Me.cdClaseComp.DataPropertyName = "cdClaseComp"
        Me.cdClaseComp.HeaderText = "cdClaseComp"
        Me.cdClaseComp.Name = "cdClaseComp"
        Me.cdClaseComp.ReadOnly = True
        Me.cdClaseComp.Visible = False
        '
        'cdTipoC
        '
        Me.cdTipoC.DataPropertyName = "cdTipoC"
        Me.cdTipoC.HeaderText = "cdTipoC"
        Me.cdTipoC.Name = "cdTipoC"
        Me.cdTipoC.ReadOnly = True
        Me.cdTipoC.Visible = False
        '
        'dsObservacion
        '
        Me.dsObservacion.DataPropertyName = "dsObservacion"
        Me.dsObservacion.HeaderText = "dsObservacion"
        Me.dsObservacion.Name = "dsObservacion"
        Me.dsObservacion.ReadOnly = True
        Me.dsObservacion.Visible = False
        '
        'cdUnidad
        '
        Me.cdUnidad.DataPropertyName = "cdUnidad"
        Me.cdUnidad.HeaderText = "cdUnidad"
        Me.cdUnidad.Name = "cdUnidad"
        Me.cdUnidad.ReadOnly = True
        Me.cdUnidad.Visible = False
        '
        'dsUnidad
        '
        Me.dsUnidad.DataPropertyName = "dsUnidad"
        Me.dsUnidad.HeaderText = "dsUnidad"
        Me.dsUnidad.Name = "dsUnidad"
        Me.dsUnidad.ReadOnly = True
        Me.dsUnidad.Visible = False
        '
        'ColumcdPerio
        '
        Me.ColumcdPerio.DataPropertyName = "cdPerio"
        Me.ColumcdPerio.HeaderText = "cdPerio"
        Me.ColumcdPerio.Name = "ColumcdPerio"
        Me.ColumcdPerio.ReadOnly = True
        Me.ColumcdPerio.Visible = False
        '
        'dsPerio
        '
        Me.dsPerio.DataPropertyName = "dsPerio"
        Me.dsPerio.HeaderText = "dsPerio"
        Me.dsPerio.Name = "dsPerio"
        Me.dsPerio.ReadOnly = True
        Me.dsPerio.Visible = False
        '
        'cdProveedor
        '
        Me.cdProveedor.DataPropertyName = "cdProveedor"
        Me.cdProveedor.HeaderText = "cdProveedor"
        Me.cdProveedor.Name = "cdProveedor"
        Me.cdProveedor.ReadOnly = True
        Me.cdProveedor.Visible = False
        '
        'dtFechaAlta
        '
        Me.dtFechaAlta.DataPropertyName = "dtFechaAlta"
        Me.dtFechaAlta.HeaderText = "dtFechaAlta"
        Me.dtFechaAlta.Name = "dtFechaAlta"
        Me.dtFechaAlta.ReadOnly = True
        Me.dtFechaAlta.Visible = False
        '
        'coldtFechaDesde
        '
        Me.coldtFechaDesde.DataPropertyName = "coldtFechaDesde"
        Me.coldtFechaDesde.HeaderText = "coldtFechaDesde"
        Me.coldtFechaDesde.Name = "coldtFechaDesde"
        Me.coldtFechaDesde.ReadOnly = True
        Me.coldtFechaDesde.Visible = False
        '
        'coldtFechaHasta
        '
        Me.coldtFechaHasta.DataPropertyName = "coldtFechaHasta"
        Me.coldtFechaHasta.HeaderText = "coldtFechaHasta"
        Me.coldtFechaHasta.Name = "coldtFechaHasta"
        Me.coldtFechaHasta.ReadOnly = True
        Me.coldtFechaHasta.Visible = False
        '
        'escdDesglose
        '
        Me.escdDesglose.DataPropertyName = "escdDesglose"
        Me.escdDesglose.HeaderText = "cdDesglose"
        Me.escdDesglose.Name = "escdDesglose"
        Me.escdDesglose.ReadOnly = True
        Me.escdDesglose.Visible = False
        '
        'dsClaseComprobante
        '
        Me.dsClaseComprobante.DataPropertyName = "dsClaseComprobante"
        Me.dsClaseComprobante.HeaderText = "dsClaseComprobante"
        Me.dsClaseComprobante.Name = "dsClaseComprobante"
        Me.dsClaseComprobante.ReadOnly = True
        Me.dsClaseComprobante.Visible = False
        '
        'dsTipoComprobante
        '
        Me.dsTipoComprobante.DataPropertyName = "dsTipoComprobante"
        Me.dsTipoComprobante.HeaderText = "dsTipoComprobante"
        Me.dsTipoComprobante.Name = "dsTipoComprobante"
        Me.dsTipoComprobante.ReadOnly = True
        Me.dsTipoComprobante.Visible = False
        '
        'ColumvlImporteFinal
        '
        Me.ColumvlImporteFinal.DataPropertyName = "vlImporteFinal"
        Me.ColumvlImporteFinal.HeaderText = "vlImporteFinal "
        Me.ColumvlImporteFinal.Name = "ColumvlImporteFinal"
        Me.ColumvlImporteFinal.ReadOnly = True
        Me.ColumvlImporteFinal.Visible = False
        '
        'vlCotizacion
        '
        Me.vlCotizacion.DataPropertyName = "vlCotizacion"
        Me.vlCotizacion.HeaderText = "vlCotizacion"
        Me.vlCotizacion.Name = "vlCotizacion"
        Me.vlCotizacion.ReadOnly = True
        Me.vlCotizacion.Visible = False
        '
        'dsAbreviatura
        '
        Me.dsAbreviatura.DataPropertyName = "dsAbreviatura"
        Me.dsAbreviatura.HeaderText = "dsAbreviatura"
        Me.dsAbreviatura.Name = "dsAbreviatura"
        Me.dsAbreviatura.ReadOnly = True
        Me.dsAbreviatura.Visible = False
        '
        'colver
        '
        Me.colver.FillWeight = 98.43943!
        Me.colver.HeaderText = ""
        Me.colver.Image = CType(resources.GetObject("colver.Image"), System.Drawing.Image)
        Me.colver.Name = "colver"
        Me.colver.ReadOnly = True
        '
        '_Eliminar
        '
        Me._Eliminar.FillWeight = 91.37056!
        Me._Eliminar.HeaderText = ""
        Me._Eliminar.Image = CType(resources.GetObject("_Eliminar.Image"), System.Drawing.Image)
        Me._Eliminar.Name = "_Eliminar"
        Me._Eliminar.ReadOnly = True
        '
        'grxObservacion
        '
        Me.grxObservacion.BackColor = System.Drawing.Color.DarkGray
        Me.grxObservacion.Controls.Add(Me.txtObjeto)
        Me.grxObservacion.Controls.Add(Me.cmdGuardarConvenio)
        Me.grxObservacion.Controls.Add(Me.cmdModificarConvenio)
        Me.grxObservacion.Controls.Add(Me.mtxtArea)
        Me.grxObservacion.Controls.Add(Me.dtFechaC)
        Me.grxObservacion.Controls.Add(Me.Label5)
        Me.grxObservacion.Controls.Add(Me.lblCotizacion)
        Me.grxObservacion.Controls.Add(Me.txtCotMoneda)
        Me.grxObservacion.Controls.Add(Me.cboMoneda)
        Me.grxObservacion.Controls.Add(Me.lblMoneda)
        Me.grxObservacion.Controls.Add(Me.lblImporteO)
        Me.grxObservacion.Controls.Add(Me.txtImporteOtros)
        Me.grxObservacion.Controls.Add(Me.lblConvenio)
        Me.grxObservacion.Controls.Add(Me.txtNroConvenio)
        Me.grxObservacion.Controls.Add(Me.grpPeriodoServicio)
        Me.grxObservacion.Controls.Add(Me.lblUnidad)
        Me.grxObservacion.Controls.Add(Me.lblObjeto)
        Me.grxObservacion.Controls.Add(Me.Label18)
        Me.grxObservacion.Controls.Add(Me.rchObservacionO)
        Me.grxObservacion.Controls.Add(Me.lblObservacionO)
        Me.grxObservacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grxObservacion.ForeColor = System.Drawing.Color.Black
        Me.grxObservacion.Location = New System.Drawing.Point(3, 6)
        Me.grxObservacion.Name = "grxObservacion"
        Me.grxObservacion.Size = New System.Drawing.Size(562, 751)
        Me.grxObservacion.TabIndex = 42
        Me.grxObservacion.TabStop = False
        Me.grxObservacion.Text = "Ingresar Datos "
        '
        'txtObjeto
        '
        Me.txtObjeto.Location = New System.Drawing.Point(12, 309)
        Me.txtObjeto.Name = "txtObjeto"
        Me.txtObjeto.Size = New System.Drawing.Size(487, 49)
        Me.txtObjeto.TabIndex = 4
        Me.txtObjeto.Text = ""
        '
        'cmdGuardarConvenio
        '
        Me.cmdGuardarConvenio.Image = CType(resources.GetObject("cmdGuardarConvenio.Image"), System.Drawing.Image)
        Me.cmdGuardarConvenio.Location = New System.Drawing.Point(480, 574)
        Me.cmdGuardarConvenio.Name = "cmdGuardarConvenio"
        Me.cmdGuardarConvenio.Size = New System.Drawing.Size(39, 42)
        Me.cmdGuardarConvenio.TabIndex = 15
        Me.cmdGuardarConvenio.UseVisualStyleBackColor = True
        '
        'cmdModificarConvenio
        '
        Me.cmdModificarConvenio.Enabled = False
        Me.cmdModificarConvenio.Image = CType(resources.GetObject("cmdModificarConvenio.Image"), System.Drawing.Image)
        Me.cmdModificarConvenio.Location = New System.Drawing.Point(440, 574)
        Me.cmdModificarConvenio.Name = "cmdModificarConvenio"
        Me.cmdModificarConvenio.Size = New System.Drawing.Size(39, 42)
        Me.cmdModificarConvenio.TabIndex = 16
        Me.cmdModificarConvenio.UseVisualStyleBackColor = True
        '
        'dtFechaC
        '
        Me.dtFechaC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaC.Location = New System.Drawing.Point(269, 375)
        Me.dtFechaC.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaC.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaC.Name = "dtFechaC"
        Me.dtFechaC.Size = New System.Drawing.Size(94, 22)
        Me.dtFechaC.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(266, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Fecha"
        '
        'lblCotizacion
        '
        Me.lblCotizacion.AutoSize = True
        Me.lblCotizacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblCotizacion.ForeColor = System.Drawing.Color.Black
        Me.lblCotizacion.Location = New System.Drawing.Point(9, 447)
        Me.lblCotizacion.Name = "lblCotizacion"
        Me.lblCotizacion.Size = New System.Drawing.Size(135, 13)
        Me.lblCotizacion.TabIndex = 72
        Me.lblCotizacion.Text = "Cotización de la Moneda"
        '
        'txtCotMoneda
        '
        Me.txtCotMoneda.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCotMoneda.Location = New System.Drawing.Point(12, 463)
        Me.txtCotMoneda.MaxLength = 12
        Me.txtCotMoneda.Name = "txtCotMoneda"
        Me.txtCotMoneda.Size = New System.Drawing.Size(210, 22)
        Me.txtCotMoneda.TabIndex = 8
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"Pesos", "Dólar", "Euros"})
        Me.cboMoneda.Location = New System.Drawing.Point(12, 423)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(210, 21)
        Me.cboMoneda.TabIndex = 7
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblMoneda.ForeColor = System.Drawing.Color.Black
        Me.lblMoneda.Location = New System.Drawing.Point(12, 407)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(50, 13)
        Me.lblMoneda.TabIndex = 71
        Me.lblMoneda.Text = "Moneda"
        '
        'lblImporteO
        '
        Me.lblImporteO.AutoSize = True
        Me.lblImporteO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteO.ForeColor = System.Drawing.Color.Black
        Me.lblImporteO.Location = New System.Drawing.Point(12, 361)
        Me.lblImporteO.Name = "lblImporteO"
        Me.lblImporteO.Size = New System.Drawing.Size(47, 13)
        Me.lblImporteO.TabIndex = 55
        Me.lblImporteO.Text = "Importe"
        '
        'txtImporteOtros
        '
        Me.txtImporteOtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteOtros.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.txtImporteOtros.Location = New System.Drawing.Point(12, 375)
        Me.txtImporteOtros.MaxLength = 10
        Me.txtImporteOtros.Name = "txtImporteOtros"
        Me.txtImporteOtros.Size = New System.Drawing.Size(244, 22)
        Me.txtImporteOtros.TabIndex = 5
        '
        'lblConvenio
        '
        Me.lblConvenio.AutoSize = True
        Me.lblConvenio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvenio.ForeColor = System.Drawing.Color.Black
        Me.lblConvenio.Location = New System.Drawing.Point(12, 19)
        Me.lblConvenio.Name = "lblConvenio"
        Me.lblConvenio.Size = New System.Drawing.Size(95, 13)
        Me.lblConvenio.TabIndex = 53
        Me.lblConvenio.Text = "Nro. de convenio"
        '
        'txtNroConvenio
        '
        Me.txtNroConvenio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNroConvenio.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.txtNroConvenio.Location = New System.Drawing.Point(12, 35)
        Me.txtNroConvenio.MaxLength = 13
        Me.txtNroConvenio.Name = "txtNroConvenio"
        Me.txtNroConvenio.Size = New System.Drawing.Size(521, 22)
        Me.txtNroConvenio.TabIndex = 1
        '
        'grpPeriodoServicio
        '
        Me.grpPeriodoServicio.BackColor = System.Drawing.Color.DarkGray
        Me.grpPeriodoServicio.Controls.Add(Me.btnDesactivarC)
        Me.grpPeriodoServicio.Controls.Add(Me.dtFechaHasta)
        Me.grpPeriodoServicio.Controls.Add(Me.dtFechaDesde)
        Me.grpPeriodoServicio.Controls.Add(Me.cboTipoPeriodicidad)
        Me.grpPeriodoServicio.Controls.Add(Me.cmdPeriodicidadC)
        Me.grpPeriodoServicio.Controls.Add(Me.lblFechaHastaC)
        Me.grpPeriodoServicio.Controls.Add(Me.lblFechaDesdeC)
        Me.grpPeriodoServicio.Controls.Add(Me.lblPeriocidad)
        Me.grpPeriodoServicio.Controls.Add(Me.cboPeriodicidadC)
        Me.grpPeriodoServicio.Controls.Add(Me.lblTipoPeriodo)
        Me.grpPeriodoServicio.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grpPeriodoServicio.ForeColor = System.Drawing.Color.Black
        Me.grpPeriodoServicio.Location = New System.Drawing.Point(8, 493)
        Me.grpPeriodoServicio.Name = "grpPeriodoServicio"
        Me.grpPeriodoServicio.Size = New System.Drawing.Size(514, 76)
        Me.grpPeriodoServicio.TabIndex = 9
        Me.grpPeriodoServicio.TabStop = False
        Me.grpPeriodoServicio.Text = "Periodicidad "
        '
        'btnDesactivarC
        '
        Me.btnDesactivarC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesactivarC.ForeColor = System.Drawing.Color.Black
        Me.btnDesactivarC.Image = CType(resources.GetObject("btnDesactivarC.Image"), System.Drawing.Image)
        Me.btnDesactivarC.Location = New System.Drawing.Point(275, 32)
        Me.btnDesactivarC.Name = "btnDesactivarC"
        Me.btnDesactivarC.Size = New System.Drawing.Size(22, 25)
        Me.btnDesactivarC.TabIndex = 12
        Me.btnDesactivarC.UseVisualStyleBackColor = True
        Me.btnDesactivarC.Visible = False
        '
        'dtFechaHasta
        '
        Me.dtFechaHasta.Checked = False
        Me.dtFechaHasta.Enabled = False
        Me.dtFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaHasta.Location = New System.Drawing.Point(405, 34)
        Me.dtFechaHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaHasta.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaHasta.Name = "dtFechaHasta"
        Me.dtFechaHasta.ShowCheckBox = True
        Me.dtFechaHasta.Size = New System.Drawing.Size(98, 22)
        Me.dtFechaHasta.TabIndex = 14
        Me.dtFechaHasta.Value = New Date(2014, 1, 8, 0, 0, 0, 0)
        '
        'dtFechaDesde
        '
        Me.dtFechaDesde.Checked = False
        Me.dtFechaDesde.Enabled = False
        Me.dtFechaDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDesde.Location = New System.Drawing.Point(302, 34)
        Me.dtFechaDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaDesde.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaDesde.Name = "dtFechaDesde"
        Me.dtFechaDesde.ShowCheckBox = True
        Me.dtFechaDesde.Size = New System.Drawing.Size(99, 22)
        Me.dtFechaDesde.TabIndex = 13
        Me.dtFechaDesde.Value = New Date(2014, 1, 8, 0, 0, 0, 0)
        '
        'cboTipoPeriodicidad
        '
        Me.cboTipoPeriodicidad.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboTipoPeriodicidad.FormattingEnabled = True
        Me.cboTipoPeriodicidad.ItemHeight = 13
        Me.cboTipoPeriodicidad.Items.AddRange(New Object() {"Sin Periodicidad", "Mensual", "Quincenal"})
        Me.cboTipoPeriodicidad.Location = New System.Drawing.Point(6, 35)
        Me.cboTipoPeriodicidad.Name = "cboTipoPeriodicidad"
        Me.cboTipoPeriodicidad.Size = New System.Drawing.Size(110, 21)
        Me.cboTipoPeriodicidad.TabIndex = 10
        '
        'cmdPeriodicidadC
        '
        Me.cmdPeriodicidadC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPeriodicidadC.ForeColor = System.Drawing.Color.Black
        Me.cmdPeriodicidadC.Image = CType(resources.GetObject("cmdPeriodicidadC.Image"), System.Drawing.Image)
        Me.cmdPeriodicidadC.Location = New System.Drawing.Point(275, 31)
        Me.cmdPeriodicidadC.Name = "cmdPeriodicidadC"
        Me.cmdPeriodicidadC.Size = New System.Drawing.Size(22, 25)
        Me.cmdPeriodicidadC.TabIndex = 16
        Me.cmdPeriodicidadC.UseVisualStyleBackColor = True
        '
        'lblFechaHastaC
        '
        Me.lblFechaHastaC.AutoSize = True
        Me.lblFechaHastaC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHastaC.ForeColor = System.Drawing.Color.Black
        Me.lblFechaHastaC.Location = New System.Drawing.Point(408, 18)
        Me.lblFechaHastaC.Name = "lblFechaHastaC"
        Me.lblFechaHastaC.Size = New System.Drawing.Size(69, 13)
        Me.lblFechaHastaC.TabIndex = 37
        Me.lblFechaHastaC.Text = "Fecha Hasta"
        '
        'lblFechaDesdeC
        '
        Me.lblFechaDesdeC.AutoSize = True
        Me.lblFechaDesdeC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDesdeC.ForeColor = System.Drawing.Color.Black
        Me.lblFechaDesdeC.Location = New System.Drawing.Point(302, 19)
        Me.lblFechaDesdeC.Name = "lblFechaDesdeC"
        Me.lblFechaDesdeC.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaDesdeC.TabIndex = 35
        Me.lblFechaDesdeC.Text = "Fecha Desde"
        '
        'lblPeriocidad
        '
        Me.lblPeriocidad.AutoSize = True
        Me.lblPeriocidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriocidad.ForeColor = System.Drawing.Color.Black
        Me.lblPeriocidad.Location = New System.Drawing.Point(119, 18)
        Me.lblPeriocidad.Name = "lblPeriocidad"
        Me.lblPeriocidad.Size = New System.Drawing.Size(71, 13)
        Me.lblPeriocidad.TabIndex = 34
        Me.lblPeriocidad.Text = "Periodicidad"
        '
        'cboPeriodicidadC
        '
        Me.cboPeriodicidadC.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboPeriodicidadC.FormattingEnabled = True
        Me.cboPeriodicidadC.ItemHeight = 13
        Me.cboPeriodicidadC.Location = New System.Drawing.Point(122, 34)
        Me.cboPeriodicidadC.Name = "cboPeriodicidadC"
        Me.cboPeriodicidadC.Size = New System.Drawing.Size(147, 21)
        Me.cboPeriodicidadC.TabIndex = 11
        '
        'lblTipoPeriodo
        '
        Me.lblTipoPeriodo.AutoSize = True
        Me.lblTipoPeriodo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPeriodo.ForeColor = System.Drawing.Color.Black
        Me.lblTipoPeriodo.Location = New System.Drawing.Point(3, 18)
        Me.lblTipoPeriodo.Name = "lblTipoPeriodo"
        Me.lblTipoPeriodo.Size = New System.Drawing.Size(112, 13)
        Me.lblTipoPeriodo.TabIndex = 32
        Me.lblTipoPeriodo.Text = "Tipo de Periodicidad"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.ForeColor = System.Drawing.Color.Black
        Me.lblUnidad.Location = New System.Drawing.Point(12, 247)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(102, 13)
        Me.lblUnidad.TabIndex = 49
        Me.lblUnidad.Text = "Unidad requirente"
        '
        'lblObjeto
        '
        Me.lblObjeto.AutoSize = True
        Me.lblObjeto.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblObjeto.ForeColor = System.Drawing.Color.Black
        Me.lblObjeto.Location = New System.Drawing.Point(12, 293)
        Me.lblObjeto.Name = "lblObjeto"
        Me.lblObjeto.Size = New System.Drawing.Size(112, 13)
        Me.lblObjeto.TabIndex = 51
        Me.lblObjeto.Text = "Objeto del convenio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label18.Location = New System.Drawing.Point(972, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Visible = False
        '
        'rchObservacionO
        '
        Me.rchObservacionO.Location = New System.Drawing.Point(12, 81)
        Me.rchObservacionO.Name = "rchObservacionO"
        Me.rchObservacionO.Size = New System.Drawing.Size(487, 159)
        Me.rchObservacionO.TabIndex = 2
        Me.rchObservacionO.Text = ""
        '
        'lblObservacionO
        '
        Me.lblObservacionO.AutoSize = True
        Me.lblObservacionO.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblObservacionO.ForeColor = System.Drawing.Color.Black
        Me.lblObservacionO.Location = New System.Drawing.Point(12, 60)
        Me.lblObservacionO.Name = "lblObservacionO"
        Me.lblObservacionO.Size = New System.Drawing.Size(170, 13)
        Me.lblObservacionO.TabIndex = 45
        Me.lblObservacionO.Text = "Ingresar Observación (opcional)"
        '
        'TabAreas
        '
        Me.TabAreas.BackColor = System.Drawing.Color.DarkGray
        Me.TabAreas.Controls.Add(Me.gbxUnidad)
        Me.TabAreas.Location = New System.Drawing.Point(4, 21)
        Me.TabAreas.Name = "TabAreas"
        Me.TabAreas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAreas.Size = New System.Drawing.Size(980, 751)
        Me.TabAreas.TabIndex = 1
        Me.TabAreas.Text = "Areas"
        '
        'gbxUnidad
        '
        Me.gbxUnidad.BackColor = System.Drawing.Color.DarkGray
        Me.gbxUnidad.Controls.Add(Me.lblMensajeGrillaUnidad)
        Me.gbxUnidad.Controls.Add(Me.dgvUnidad)
        Me.gbxUnidad.Controls.Add(Me.lblErrorunidad)
        Me.gbxUnidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxUnidad.ForeColor = System.Drawing.Color.Black
        Me.gbxUnidad.Location = New System.Drawing.Point(3, 0)
        Me.gbxUnidad.Name = "gbxUnidad"
        Me.gbxUnidad.Size = New System.Drawing.Size(937, 556)
        Me.gbxUnidad.TabIndex = 26
        Me.gbxUnidad.TabStop = False
        Me.gbxUnidad.Text = "Unidades Requirentes"
        '
        'lblMensajeGrillaUnidad
        '
        Me.lblMensajeGrillaUnidad.AutoSize = True
        Me.lblMensajeGrillaUnidad.BackColor = System.Drawing.Color.DarkGray
        Me.lblMensajeGrillaUnidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeGrillaUnidad.ForeColor = System.Drawing.Color.Blue
        Me.lblMensajeGrillaUnidad.Location = New System.Drawing.Point(6, 517)
        Me.lblMensajeGrillaUnidad.Name = "lblMensajeGrillaUnidad"
        Me.lblMensajeGrillaUnidad.Size = New System.Drawing.Size(327, 12)
        Me.lblMensajeGrillaUnidad.TabIndex = 56
        Me.lblMensajeGrillaUnidad.Text = "Los importes que se muestran estan valorizados en pesos"
        '
        'dgvUnidad
        '
        Me.dgvUnidad.AllowUserToAddRows = False
        Me.dgvUnidad.AllowUserToDeleteRows = False
        Me.dgvUnidad.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvUnidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnidad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.cdArea, Me.vlImporte})
        Me.dgvUnidad.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvUnidad.Location = New System.Drawing.Point(6, 14)
        Me.dgvUnidad.MultiSelect = False
        Me.dgvUnidad.Name = "dgvUnidad"
        Me.dgvUnidad.ReadOnly = True
        Me.dgvUnidad.RowHeadersVisible = False
        Me.dgvUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidad.Size = New System.Drawing.Size(853, 490)
        Me.dgvUnidad.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dsArea"
        Me.DataGridViewTextBoxColumn1.FillWeight = 94.08485!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Unidad Requirente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Width = 600
        '
        'cdArea
        '
        Me.cdArea.DataPropertyName = "cdArea"
        Me.cdArea.HeaderText = "cdArea"
        Me.cdArea.Name = "cdArea"
        Me.cdArea.ReadOnly = True
        Me.cdArea.Visible = False
        '
        'vlImporte
        '
        Me.vlImporte.DataPropertyName = "monto"
        Me.vlImporte.HeaderText = "Importe"
        Me.vlImporte.Name = "vlImporte"
        Me.vlImporte.ReadOnly = True
        Me.vlImporte.Width = 250
        '
        'lblErrorunidad
        '
        Me.lblErrorunidad.AutoSize = True
        Me.lblErrorunidad.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorunidad.Location = New System.Drawing.Point(900, 91)
        Me.lblErrorunidad.Name = "lblErrorunidad"
        Me.lblErrorunidad.Size = New System.Drawing.Size(10, 12)
        Me.lblErrorunidad.TabIndex = 17
        Me.lblErrorunidad.Text = "*"
        Me.lblErrorunidad.Visible = False
        '
        'TabConceptos
        '
        Me.TabConceptos.BackColor = System.Drawing.Color.DarkGray
        Me.TabConceptos.Controls.Add(Me.gbxObservacion)
        Me.TabConceptos.Location = New System.Drawing.Point(4, 21)
        Me.TabConceptos.Name = "TabConceptos"
        Me.TabConceptos.Size = New System.Drawing.Size(980, 751)
        Me.TabConceptos.TabIndex = 2
        Me.TabConceptos.Text = "Conceptos"
        '
        'gbxObservacion
        '
        Me.gbxObservacion.BackColor = System.Drawing.Color.DarkGray
        Me.gbxObservacion.Controls.Add(Me.cmdAgregarConcepto)
        Me.gbxObservacion.Controls.Add(Me.dgvConceptos)
        Me.gbxObservacion.Controls.Add(Me.pnlDatosConceptos)
        Me.gbxObservacion.Controls.Add(Me.lblErrorConceptos)
        Me.gbxObservacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxObservacion.ForeColor = System.Drawing.Color.Black
        Me.gbxObservacion.Location = New System.Drawing.Point(3, 3)
        Me.gbxObservacion.Name = "gbxObservacion"
        Me.gbxObservacion.Size = New System.Drawing.Size(941, 535)
        Me.gbxObservacion.TabIndex = 26
        Me.gbxObservacion.TabStop = False
        Me.gbxObservacion.Text = "Listado de conceptos"
        '
        'cmdAgregarConcepto
        '
        Me.cmdAgregarConcepto.Image = CType(resources.GetObject("cmdAgregarConcepto.Image"), System.Drawing.Image)
        Me.cmdAgregarConcepto.Location = New System.Drawing.Point(693, 176)
        Me.cmdAgregarConcepto.Name = "cmdAgregarConcepto"
        Me.cmdAgregarConcepto.Size = New System.Drawing.Size(39, 42)
        Me.cmdAgregarConcepto.TabIndex = 2
        Me.cmdAgregarConcepto.UseVisualStyleBackColor = True
        '
        'dgvConceptos
        '
        Me.dgvConceptos.AllowUserToAddRows = False
        Me.dgvConceptos.AllowUserToDeleteRows = False
        Me.dgvConceptos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConceptos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvConceptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConceptos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumcdExp, Me.ColumcdSubConcepto, Me.ColumdsConcepto, Me.columSubConcepto, Me.ColumdsObservaciones, Me.ver, Me.ColEliminar})
        Me.dgvConceptos.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvConceptos.Location = New System.Drawing.Point(6, 21)
        Me.dgvConceptos.MultiSelect = False
        Me.dgvConceptos.Name = "dgvConceptos"
        Me.dgvConceptos.ReadOnly = True
        Me.dgvConceptos.RowHeadersVisible = False
        Me.dgvConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConceptos.Size = New System.Drawing.Size(666, 197)
        Me.dgvConceptos.TabIndex = 1
        '
        'ColumcdExp
        '
        Me.ColumcdExp.DataPropertyName = "cdExp"
        Me.ColumcdExp.HeaderText = "cdExp"
        Me.ColumcdExp.Name = "ColumcdExp"
        Me.ColumcdExp.ReadOnly = True
        Me.ColumcdExp.Visible = False
        '
        'ColumcdSubConcepto
        '
        Me.ColumcdSubConcepto.DataPropertyName = "cdSubConcepto"
        Me.ColumcdSubConcepto.HeaderText = "cdSubConcepto"
        Me.ColumcdSubConcepto.Name = "ColumcdSubConcepto"
        Me.ColumcdSubConcepto.ReadOnly = True
        Me.ColumcdSubConcepto.Visible = False
        '
        'ColumdsConcepto
        '
        Me.ColumdsConcepto.DataPropertyName = "dsConcepto"
        Me.ColumdsConcepto.FillWeight = 65.93105!
        Me.ColumdsConcepto.HeaderText = "Concepto"
        Me.ColumdsConcepto.Name = "ColumdsConcepto"
        Me.ColumdsConcepto.ReadOnly = True
        '
        'columSubConcepto
        '
        Me.columSubConcepto.DataPropertyName = "dsSubConcepto"
        Me.columSubConcepto.FillWeight = 267.9397!
        Me.columSubConcepto.HeaderText = "SubConcepto"
        Me.columSubConcepto.Name = "columSubConcepto"
        Me.columSubConcepto.ReadOnly = True
        '
        'ColumdsObservaciones
        '
        Me.ColumdsObservaciones.DataPropertyName = "dsObservacion"
        Me.ColumdsObservaciones.FillWeight = 278.286!
        Me.ColumdsObservaciones.HeaderText = "Observaciones"
        Me.ColumdsObservaciones.Name = "ColumdsObservaciones"
        Me.ColumdsObservaciones.ReadOnly = True
        Me.ColumdsObservaciones.Visible = False
        '
        'ver
        '
        Me.ver.FillWeight = 6.842754!
        Me.ver.HeaderText = ""
        Me.ver.Image = CType(resources.GetObject("ver.Image"), System.Drawing.Image)
        Me.ver.Name = "ver"
        Me.ver.ReadOnly = True
        '
        'ColEliminar
        '
        Me.ColEliminar.FillWeight = 11.18062!
        Me.ColEliminar.HeaderText = ""
        Me.ColEliminar.Image = CType(resources.GetObject("ColEliminar.Image"), System.Drawing.Image)
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        '
        'pnlDatosConceptos
        '
        Me.pnlDatosConceptos.BackColor = System.Drawing.Color.DarkGray
        Me.pnlDatosConceptos.Controls.Add(Me.txtObservacionesConceptos)
        Me.pnlDatosConceptos.Controls.Add(Me.lblSubConcepto)
        Me.pnlDatosConceptos.Controls.Add(Me.lblConcepto)
        Me.pnlDatosConceptos.Controls.Add(Me.lblObservacion)
        Me.pnlDatosConceptos.Location = New System.Drawing.Point(16, 224)
        Me.pnlDatosConceptos.Name = "pnlDatosConceptos"
        Me.pnlDatosConceptos.Size = New System.Drawing.Size(685, 306)
        Me.pnlDatosConceptos.TabIndex = 3
        Me.pnlDatosConceptos.Visible = False
        '
        'txtObservacionesConceptos
        '
        Me.txtObservacionesConceptos.Enabled = False
        Me.txtObservacionesConceptos.Location = New System.Drawing.Point(27, 103)
        Me.txtObservacionesConceptos.Name = "txtObservacionesConceptos"
        Me.txtObservacionesConceptos.Size = New System.Drawing.Size(629, 185)
        Me.txtObservacionesConceptos.TabIndex = 51
        Me.txtObservacionesConceptos.Text = ""
        '
        'lblSubConcepto
        '
        Me.lblSubConcepto.AutoSize = True
        Me.lblSubConcepto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubConcepto.ForeColor = System.Drawing.Color.Black
        Me.lblSubConcepto.Location = New System.Drawing.Point(23, 48)
        Me.lblSubConcepto.Name = "lblSubConcepto"
        Me.lblSubConcepto.Size = New System.Drawing.Size(83, 12)
        Me.lblSubConcepto.TabIndex = 50
        Me.lblSubConcepto.Text = "SubConcepto:"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.ForeColor = System.Drawing.Color.Black
        Me.lblConcepto.Location = New System.Drawing.Point(23, 17)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(62, 12)
        Me.lblConcepto.TabIndex = 49
        Me.lblConcepto.Text = "Concepto:"
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacion.ForeColor = System.Drawing.Color.Black
        Me.lblObservacion.Location = New System.Drawing.Point(23, 79)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(92, 12)
        Me.lblObservacion.TabIndex = 48
        Me.lblObservacion.Text = "Observaciones:"
        '
        'lblErrorConceptos
        '
        Me.lblErrorConceptos.AutoSize = True
        Me.lblErrorConceptos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblErrorConceptos.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrorConceptos.Location = New System.Drawing.Point(934, 34)
        Me.lblErrorConceptos.Name = "lblErrorConceptos"
        Me.lblErrorConceptos.Size = New System.Drawing.Size(12, 13)
        Me.lblErrorConceptos.TabIndex = 38
        Me.lblErrorConceptos.Text = "*"
        Me.lblErrorConceptos.Visible = False
        '
        'TabSeguimiento
        '
        Me.TabSeguimiento.BackColor = System.Drawing.Color.DarkGray
        Me.TabSeguimiento.Controls.Add(Me.GroupBox1)
        Me.TabSeguimiento.Location = New System.Drawing.Point(4, 21)
        Me.TabSeguimiento.Name = "TabSeguimiento"
        Me.TabSeguimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSeguimiento.Size = New System.Drawing.Size(980, 751)
        Me.TabSeguimiento.TabIndex = 4
        Me.TabSeguimiento.Text = "Seguimiento de expediente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.gbxSolicitudes)
        Me.GroupBox1.Controls.Add(Me.pnlDatosMov)
        Me.GroupBox1.Controls.Add(Me.cmdSeguimiento)
        Me.GroupBox1.Controls.Add(Me.dgvSeguimiento)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 626)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados por los que ya paso el expediente"
        '
        'gbxSolicitudes
        '
        Me.gbxSolicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSolicitudes.BackColor = System.Drawing.Color.DarkGray
        Me.gbxSolicitudes.Controls.Add(Me.Panel1)
        Me.gbxSolicitudes.Controls.Add(Me.dgvSolicitudes)
        Me.gbxSolicitudes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSolicitudes.ForeColor = System.Drawing.Color.Black
        Me.gbxSolicitudes.Location = New System.Drawing.Point(8, 299)
        Me.gbxSolicitudes.Name = "gbxSolicitudes"
        Me.gbxSolicitudes.Size = New System.Drawing.Size(722, 285)
        Me.gbxSolicitudes.TabIndex = 8
        Me.gbxSolicitudes.TabStop = False
        Me.gbxSolicitudes.Text = "Estados por los que ya paso la solicitud"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(10, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 306)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(682, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 27)
        Me.Button1.TabIndex = 53
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(129, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Area:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(27, 103)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(649, 185)
        Me.RichTextBox1.TabIndex = 51
        Me.RichTextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Area:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Estado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Observacion:"
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.dsSolicitud, Me.dsNroExpSolicitud, Me.cdSolicitudEstado, Me.dsEstado, Me.dtSolicitud, Me.DataGridViewTextBoxColumn16})
        Me.dgvSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvSolicitudes.Location = New System.Drawing.Point(5, 21)
        Me.dgvSolicitudes.MultiSelect = False
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitudes.Size = New System.Drawing.Size(695, 247)
        Me.dgvSolicitudes.TabIndex = 1
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cdSolicitud"
        Me.DataGridViewTextBoxColumn8.FillWeight = 40.53149!
        Me.DataGridViewTextBoxColumn8.HeaderText = "NroSolicitud"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'dsSolicitud
        '
        Me.dsSolicitud.DataPropertyName = "dsSolicitud"
        Me.dsSolicitud.HeaderText = "dsSolicitud"
        Me.dsSolicitud.Name = "dsSolicitud"
        Me.dsSolicitud.ReadOnly = True
        Me.dsSolicitud.Visible = False
        '
        'dsNroExpSolicitud
        '
        Me.dsNroExpSolicitud.DataPropertyName = "dsNroExpSolicitud"
        Me.dsNroExpSolicitud.HeaderText = "dsNroExpSolicitud"
        Me.dsNroExpSolicitud.Name = "dsNroExpSolicitud"
        Me.dsNroExpSolicitud.ReadOnly = True
        Me.dsNroExpSolicitud.Visible = False
        '
        'cdSolicitudEstado
        '
        Me.cdSolicitudEstado.DataPropertyName = "cdSolicitudEstado"
        Me.cdSolicitudEstado.HeaderText = "cdEstado"
        Me.cdSolicitudEstado.Name = "cdSolicitudEstado"
        Me.cdSolicitudEstado.ReadOnly = True
        Me.cdSolicitudEstado.Visible = False
        '
        'dsEstado
        '
        Me.dsEstado.DataPropertyName = "dsEstado"
        Me.dsEstado.FillWeight = 71.15414!
        Me.dsEstado.HeaderText = "Estado"
        Me.dsEstado.Name = "dsEstado"
        Me.dsEstado.ReadOnly = True
        Me.dsEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'dtSolicitud
        '
        Me.dtSolicitud.DataPropertyName = "dtSolicitud"
        Me.dtSolicitud.FillWeight = 40.94414!
        Me.dtSolicitud.HeaderText = "Fecha"
        Me.dtSolicitud.Name = "dtSolicitud"
        Me.dtSolicitud.ReadOnly = True
        Me.dtSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "dsObservaciones"
        Me.DataGridViewTextBoxColumn16.FillWeight = 80.99299!
        Me.DataGridViewTextBoxColumn16.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'pnlDatosMov
        '
        Me.pnlDatosMov.Controls.Add(Me.btnModificarSE)
        Me.pnlDatosMov.Controls.Add(Me.lblAreaMovimiento)
        Me.pnlDatosMov.Controls.Add(Me.rchObservacionMov)
        Me.pnlDatosMov.Controls.Add(Me.lblAreaMov)
        Me.pnlDatosMov.Controls.Add(Me.lblMovimiento)
        Me.pnlDatosMov.Controls.Add(Me.lblObservMov)
        Me.pnlDatosMov.Location = New System.Drawing.Point(10, 296)
        Me.pnlDatosMov.Name = "pnlDatosMov"
        Me.pnlDatosMov.Size = New System.Drawing.Size(822, 306)
        Me.pnlDatosMov.TabIndex = 3
        Me.pnlDatosMov.Visible = False
        '
        'btnModificarSE
        '
        Me.btnModificarSE.Image = CType(resources.GetObject("btnModificarSE.Image"), System.Drawing.Image)
        Me.btnModificarSE.Location = New System.Drawing.Point(682, 261)
        Me.btnModificarSE.Name = "btnModificarSE"
        Me.btnModificarSE.Size = New System.Drawing.Size(28, 27)
        Me.btnModificarSE.TabIndex = 53
        Me.btnModificarSE.UseVisualStyleBackColor = True
        Me.btnModificarSE.Visible = False
        '
        'lblAreaMovimiento
        '
        Me.lblAreaMovimiento.AutoSize = True
        Me.lblAreaMovimiento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaMovimiento.ForeColor = System.Drawing.Color.Black
        Me.lblAreaMovimiento.Location = New System.Drawing.Point(129, 48)
        Me.lblAreaMovimiento.Name = "lblAreaMovimiento"
        Me.lblAreaMovimiento.Size = New System.Drawing.Size(45, 21)
        Me.lblAreaMovimiento.TabIndex = 52
        Me.lblAreaMovimiento.Text = "Area:"
        '
        'rchObservacionMov
        '
        Me.rchObservacionMov.Enabled = False
        Me.rchObservacionMov.Location = New System.Drawing.Point(27, 103)
        Me.rchObservacionMov.Name = "rchObservacionMov"
        Me.rchObservacionMov.Size = New System.Drawing.Size(649, 185)
        Me.rchObservacionMov.TabIndex = 51
        Me.rchObservacionMov.Text = ""
        '
        'lblAreaMov
        '
        Me.lblAreaMov.AutoSize = True
        Me.lblAreaMov.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaMov.ForeColor = System.Drawing.Color.Black
        Me.lblAreaMov.Location = New System.Drawing.Point(23, 48)
        Me.lblAreaMov.Name = "lblAreaMov"
        Me.lblAreaMov.Size = New System.Drawing.Size(45, 21)
        Me.lblAreaMov.TabIndex = 50
        Me.lblAreaMov.Text = "Area:"
        '
        'lblMovimiento
        '
        Me.lblMovimiento.AutoSize = True
        Me.lblMovimiento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovimiento.ForeColor = System.Drawing.Color.Black
        Me.lblMovimiento.Location = New System.Drawing.Point(23, 17)
        Me.lblMovimiento.Name = "lblMovimiento"
        Me.lblMovimiento.Size = New System.Drawing.Size(59, 21)
        Me.lblMovimiento.TabIndex = 49
        Me.lblMovimiento.Text = "Estado:"
        '
        'lblObservMov
        '
        Me.lblObservMov.AutoSize = True
        Me.lblObservMov.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservMov.ForeColor = System.Drawing.Color.Black
        Me.lblObservMov.Location = New System.Drawing.Point(23, 79)
        Me.lblObservMov.Name = "lblObservMov"
        Me.lblObservMov.Size = New System.Drawing.Size(100, 21)
        Me.lblObservMov.TabIndex = 48
        Me.lblObservMov.Text = "Observacion:"
        '
        'cmdSeguimiento
        '
        Me.cmdSeguimiento.Image = CType(resources.GetObject("cmdSeguimiento.Image"), System.Drawing.Image)
        Me.cmdSeguimiento.Location = New System.Drawing.Point(813, 236)
        Me.cmdSeguimiento.Name = "cmdSeguimiento"
        Me.cmdSeguimiento.Size = New System.Drawing.Size(39, 42)
        Me.cmdSeguimiento.TabIndex = 2
        Me.cmdSeguimiento.UseVisualStyleBackColor = True
        '
        'dgvSeguimiento
        '
        Me.dgvSeguimiento.AllowUserToAddRows = False
        Me.dgvSeguimiento.AllowUserToDeleteRows = False
        Me.dgvSeguimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSeguimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSeguimiento.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvSeguimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSeguimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codSeguimiento, Me.codExpediente, Me.cdEstado, Me.columdsEstado, Me.columFecha, Me.columcdArea, Me.columdsArea, Me.cdBaja, Me.sObservaciones, Me.cdEtapa, Me.dsEtapa, Me.colum_ver, Me.Columnedit, Me.colum_delete})
        Me.dgvSeguimiento.GridColor = System.Drawing.Color.Black
        Me.dgvSeguimiento.Location = New System.Drawing.Point(10, 21)
        Me.dgvSeguimiento.MultiSelect = False
        Me.dgvSeguimiento.Name = "dgvSeguimiento"
        Me.dgvSeguimiento.ReadOnly = True
        Me.dgvSeguimiento.RowHeadersVisible = False
        Me.dgvSeguimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSeguimiento.Size = New System.Drawing.Size(782, 257)
        Me.dgvSeguimiento.TabIndex = 1
        '
        'codSeguimiento
        '
        Me.codSeguimiento.DataPropertyName = "codSeguimiento"
        Me.codSeguimiento.FillWeight = 1.0!
        Me.codSeguimiento.HeaderText = "codSeguimiento"
        Me.codSeguimiento.MaxInputLength = 1
        Me.codSeguimiento.Name = "codSeguimiento"
        Me.codSeguimiento.ReadOnly = True
        Me.codSeguimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codSeguimiento.Visible = False
        '
        'codExpediente
        '
        Me.codExpediente.DataPropertyName = "codExpediente"
        Me.codExpediente.HeaderText = "cdExpediente"
        Me.codExpediente.Name = "codExpediente"
        Me.codExpediente.ReadOnly = True
        Me.codExpediente.Visible = False
        '
        'cdEstado
        '
        Me.cdEstado.DataPropertyName = "cdEstado"
        Me.cdEstado.HeaderText = "cdEstado"
        Me.cdEstado.Name = "cdEstado"
        Me.cdEstado.ReadOnly = True
        Me.cdEstado.Visible = False
        '
        'columdsEstado
        '
        Me.columdsEstado.DataPropertyName = "dsEstado"
        Me.columdsEstado.FillWeight = 111.4156!
        Me.columdsEstado.HeaderText = "Estado"
        Me.columdsEstado.Name = "columdsEstado"
        Me.columdsEstado.ReadOnly = True
        Me.columdsEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'columFecha
        '
        Me.columFecha.DataPropertyName = "dtFecha"
        Me.columFecha.FillWeight = 74.72075!
        Me.columFecha.HeaderText = "Fecha"
        Me.columFecha.Name = "columFecha"
        Me.columFecha.ReadOnly = True
        Me.columFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'columcdArea
        '
        Me.columcdArea.DataPropertyName = "cdArea"
        Me.columcdArea.HeaderText = "cdArea"
        Me.columcdArea.Name = "columcdArea"
        Me.columcdArea.ReadOnly = True
        Me.columcdArea.Visible = False
        '
        'columdsArea
        '
        Me.columdsArea.DataPropertyName = "dsArea"
        Me.columdsArea.FillWeight = 59.06064!
        Me.columdsArea.HeaderText = "Area del Responsable"
        Me.columdsArea.Name = "columdsArea"
        Me.columdsArea.ReadOnly = True
        Me.columdsArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'cdBaja
        '
        Me.cdBaja.DataPropertyName = "cdBaja"
        Me.cdBaja.HeaderText = "cdBaja"
        Me.cdBaja.Name = "cdBaja"
        Me.cdBaja.ReadOnly = True
        Me.cdBaja.Visible = False
        '
        'sObservaciones
        '
        Me.sObservaciones.DataPropertyName = "sObservaciones"
        Me.sObservaciones.FillWeight = 190.7839!
        Me.sObservaciones.HeaderText = "Observaciones"
        Me.sObservaciones.Name = "sObservaciones"
        Me.sObservaciones.ReadOnly = True
        '
        'cdEtapa
        '
        Me.cdEtapa.DataPropertyName = "cdEtapa"
        Me.cdEtapa.HeaderText = "cdEtapa"
        Me.cdEtapa.Name = "cdEtapa"
        Me.cdEtapa.ReadOnly = True
        Me.cdEtapa.Visible = False
        '
        'dsEtapa
        '
        Me.dsEtapa.DataPropertyName = "dsEtapa"
        Me.dsEtapa.FillWeight = 83.75881!
        Me.dsEtapa.HeaderText = "Etapa"
        Me.dsEtapa.Name = "dsEtapa"
        Me.dsEtapa.ReadOnly = True
        '
        'colum_ver
        '
        Me.colum_ver.FillWeight = 10.83494!
        Me.colum_ver.HeaderText = ""
        Me.colum_ver.Image = CType(resources.GetObject("colum_ver.Image"), System.Drawing.Image)
        Me.colum_ver.Name = "colum_ver"
        Me.colum_ver.ReadOnly = True
        '
        'Columnedit
        '
        Me.Columnedit.FillWeight = 7.66513!
        Me.Columnedit.HeaderText = ""
        Me.Columnedit.Image = CType(resources.GetObject("Columnedit.Image"), System.Drawing.Image)
        Me.Columnedit.Name = "Columnedit"
        Me.Columnedit.ReadOnly = True
        '
        'colum_delete
        '
        Me.colum_delete.FillWeight = 10.48223!
        Me.colum_delete.HeaderText = ""
        Me.colum_delete.Image = CType(resources.GetObject("colum_delete.Image"), System.Drawing.Image)
        Me.colum_delete.Name = "colum_delete"
        Me.colum_delete.ReadOnly = True
        '
        'TabCabecera
        '
        Me.TabCabecera.BackColor = System.Drawing.Color.DarkGray
        Me.TabCabecera.Controls.Add(Me.mtxtAreaE)
        Me.TabCabecera.Controls.Add(Me.lblArea)
        Me.TabCabecera.Controls.Add(Me.gbProveedor)
        Me.TabCabecera.Controls.Add(Me.gxpDatosExpediente)
        Me.TabCabecera.Controls.Add(Me.gxpListObservaciones)
        Me.TabCabecera.Controls.Add(Me.lblErrorRS)
        Me.TabCabecera.Location = New System.Drawing.Point(4, 21)
        Me.TabCabecera.Name = "TabCabecera"
        Me.TabCabecera.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCabecera.Size = New System.Drawing.Size(980, 751)
        Me.TabCabecera.TabIndex = 5
        Me.TabCabecera.Text = "Ingresar Nuevo Expediente"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.DarkGray
        Me.lblArea.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArea.Location = New System.Drawing.Point(37, 190)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(79, 12)
        Me.lblArea.TabIndex = 75
        Me.lblArea.Text = "Dependencia"
        '
        'gbProveedor
        '
        Me.gbProveedor.BackColor = System.Drawing.Color.DarkGray
        Me.gbProveedor.Controls.Add(Me.ToolStrip4)
        Me.gbProveedor.Controls.Add(Me.ToolStrip2)
        Me.gbProveedor.Controls.Add(Me.chkExterior)
        Me.gbProveedor.Controls.Add(Me.txtCuit)
        Me.gbProveedor.Controls.Add(Me.lblRazonSocial)
        Me.gbProveedor.Controls.Add(Me.lblNroBeneficiario)
        Me.gbProveedor.Controls.Add(Me.lblCuit)
        Me.gbProveedor.Controls.Add(Me.txtRazonSocial)
        Me.gbProveedor.Controls.Add(Me.txtNroBeneficiario)
        Me.gbProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProveedor.ForeColor = System.Drawing.Color.Black
        Me.gbProveedor.Location = New System.Drawing.Point(6, 75)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(909, 103)
        Me.gbProveedor.TabIndex = 1
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Proveedor"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3})
        Me.ToolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 25)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(24, 34)
        Me.ToolStrip4.TabIndex = 41
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Blanquear Proveedor"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNuevo, Me.ToolStripModificar})
        Me.ToolStrip2.Location = New System.Drawing.Point(801, 32)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(58, 25)
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
        Me.chkExterior.Location = New System.Drawing.Point(815, 12)
        Me.chkExterior.Name = "chkExterior"
        Me.chkExterior.Size = New System.Drawing.Size(84, 16)
        Me.chkExterior.TabIndex = 1
        Me.chkExterior.Text = "Es Exterior"
        Me.chkExterior.UseVisualStyleBackColor = False
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.Location = New System.Drawing.Point(695, 35)
        Me.txtCuit.MaxLength = 20
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(103, 22)
        Me.txtCuit.TabIndex = 4
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.BackColor = System.Drawing.Color.DarkGray
        Me.lblRazonSocial.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.lblRazonSocial.Location = New System.Drawing.Point(26, 19)
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
        Me.lblNroBeneficiario.Location = New System.Drawing.Point(576, 19)
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
        Me.lblCuit.Location = New System.Drawing.Point(692, 19)
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(29, 35)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(544, 22)
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtNroBeneficiario
        '
        Me.txtNroBeneficiario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBeneficiario.Location = New System.Drawing.Point(579, 35)
        Me.txtNroBeneficiario.MaxLength = 20
        Me.txtNroBeneficiario.Name = "txtNroBeneficiario"
        Me.txtNroBeneficiario.Size = New System.Drawing.Size(110, 22)
        Me.txtNroBeneficiario.TabIndex = 3
        '
        'gxpDatosExpediente
        '
        Me.gxpDatosExpediente.BackColor = System.Drawing.Color.DarkGray
        Me.gxpDatosExpediente.Controls.Add(Me.dsNroSolicitud)
        Me.gxpDatosExpediente.Controls.Add(Me.txtcdSolicitud)
        Me.gxpDatosExpediente.Controls.Add(Me.txtcdNroExpedienteRel)
        Me.gxpDatosExpediente.Controls.Add(Me.txtNroExpedienteRel)
        Me.gxpDatosExpediente.Controls.Add(Me.lblNroExpedienteRelacionado)
        Me.gxpDatosExpediente.Controls.Add(Me.dt)
        Me.gxpDatosExpediente.Controls.Add(Me.txtcdExpediente)
        Me.gxpDatosExpediente.Controls.Add(Me.txtNroExpediente)
        Me.gxpDatosExpediente.Controls.Add(Me.cboTipoExpediente)
        Me.gxpDatosExpediente.Controls.Add(Me.lblFecha)
        Me.gxpDatosExpediente.Controls.Add(Me.lblTipoExp)
        Me.gxpDatosExpediente.Controls.Add(Me.lblNroExpediente)
        Me.gxpDatosExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gxpDatosExpediente.ForeColor = System.Drawing.Color.Black
        Me.gxpDatosExpediente.Location = New System.Drawing.Point(6, 2)
        Me.gxpDatosExpediente.Name = "gxpDatosExpediente"
        Me.gxpDatosExpediente.Size = New System.Drawing.Size(911, 71)
        Me.gxpDatosExpediente.TabIndex = 5
        Me.gxpDatosExpediente.TabStop = False
        Me.gxpDatosExpediente.Text = "Datos básicos del expediente"
        '
        'dsNroSolicitud
        '
        Me.dsNroSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dsNroSolicitud.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dsNroSolicitud.Location = New System.Drawing.Point(583, 43)
        Me.dsNroSolicitud.MaxLength = 10
        Me.dsNroSolicitud.Name = "dsNroSolicitud"
        Me.dsNroSolicitud.Size = New System.Drawing.Size(28, 22)
        Me.dsNroSolicitud.TabIndex = 40
        Me.dsNroSolicitud.Text = "  "
        Me.dsNroSolicitud.Visible = False
        '
        'txtcdSolicitud
        '
        Me.txtcdSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcdSolicitud.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtcdSolicitud.Location = New System.Drawing.Point(583, 42)
        Me.txtcdSolicitud.MaxLength = 10
        Me.txtcdSolicitud.Name = "txtcdSolicitud"
        Me.txtcdSolicitud.Size = New System.Drawing.Size(28, 22)
        Me.txtcdSolicitud.TabIndex = 39
        Me.txtcdSolicitud.Text = "  "
        Me.txtcdSolicitud.Visible = False
        '
        'txtcdNroExpedienteRel
        '
        Me.txtcdNroExpedienteRel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcdNroExpedienteRel.Location = New System.Drawing.Point(882, 44)
        Me.txtcdNroExpedienteRel.MaxLength = 13
        Me.txtcdNroExpedienteRel.Name = "txtcdNroExpedienteRel"
        Me.txtcdNroExpedienteRel.Size = New System.Drawing.Size(10, 22)
        Me.txtcdNroExpedienteRel.TabIndex = 38
        Me.txtcdNroExpedienteRel.Visible = False
        '
        'txtNroExpedienteRel
        '
        Me.txtNroExpedienteRel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroExpedienteRel.Location = New System.Drawing.Point(736, 43)
        Me.txtNroExpedienteRel.MaxLength = 13
        Me.txtNroExpedienteRel.Name = "txtNroExpedienteRel"
        Me.txtNroExpedienteRel.Size = New System.Drawing.Size(140, 22)
        Me.txtNroExpedienteRel.TabIndex = 36
        '
        'lblNroExpedienteRelacionado
        '
        Me.lblNroExpedienteRelacionado.AutoSize = True
        Me.lblNroExpedienteRelacionado.BackColor = System.Drawing.Color.DarkGray
        Me.lblNroExpedienteRelacionado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroExpedienteRelacionado.ForeColor = System.Drawing.Color.Black
        Me.lblNroExpedienteRelacionado.Location = New System.Drawing.Point(733, 27)
        Me.lblNroExpedienteRelacionado.Name = "lblNroExpedienteRelacionado"
        Me.lblNroExpedienteRelacionado.Size = New System.Drawing.Size(127, 12)
        Me.lblNroExpedienteRelacionado.TabIndex = 37
        Me.lblNroExpedienteRelacionado.Text = "Unificar al Expediente"
        '
        'dt
        '
        Me.dt.Checked = False
        Me.dt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(176, 42)
        Me.dt.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dt.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(96, 22)
        Me.dt.TabIndex = 7
        '
        'txtcdExpediente
        '
        Me.txtcdExpediente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcdExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtcdExpediente.Location = New System.Drawing.Point(583, 42)
        Me.txtcdExpediente.MaxLength = 10
        Me.txtcdExpediente.Name = "txtcdExpediente"
        Me.txtcdExpediente.Size = New System.Drawing.Size(28, 22)
        Me.txtcdExpediente.TabIndex = 25
        Me.txtcdExpediente.Text = "  "
        Me.txtcdExpediente.Visible = False
        '
        'txtNroExpediente
        '
        Me.txtNroExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroExpediente.Location = New System.Drawing.Point(29, 42)
        Me.txtNroExpediente.MaxLength = 13
        Me.txtNroExpediente.Name = "txtNroExpediente"
        Me.txtNroExpediente.Size = New System.Drawing.Size(136, 22)
        Me.txtNroExpediente.TabIndex = 6
        '
        'cboTipoExpediente
        '
        Me.cboTipoExpediente.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboTipoExpediente.FormattingEnabled = True
        Me.cboTipoExpediente.Location = New System.Drawing.Point(278, 42)
        Me.cboTipoExpediente.Name = "cboTipoExpediente"
        Me.cboTipoExpediente.Size = New System.Drawing.Size(124, 21)
        Me.cboTipoExpediente.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.DarkGray
        Me.lblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(173, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 12)
        Me.lblFecha.TabIndex = 27
        Me.lblFecha.Text = "Fecha"
        '
        'lblTipoExp
        '
        Me.lblTipoExp.AutoSize = True
        Me.lblTipoExp.BackColor = System.Drawing.Color.DarkGray
        Me.lblTipoExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoExp.ForeColor = System.Drawing.Color.Black
        Me.lblTipoExp.Location = New System.Drawing.Point(275, 25)
        Me.lblTipoExp.Name = "lblTipoExp"
        Me.lblTipoExp.Size = New System.Drawing.Size(94, 12)
        Me.lblTipoExp.TabIndex = 35
        Me.lblTipoExp.Text = "Tipo Expediente"
        '
        'lblNroExpediente
        '
        Me.lblNroExpediente.AutoSize = True
        Me.lblNroExpediente.BackColor = System.Drawing.Color.DarkGray
        Me.lblNroExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroExpediente.ForeColor = System.Drawing.Color.Black
        Me.lblNroExpediente.Location = New System.Drawing.Point(26, 26)
        Me.lblNroExpediente.Name = "lblNroExpediente"
        Me.lblNroExpediente.Size = New System.Drawing.Size(113, 12)
        Me.lblNroExpediente.TabIndex = 8
        Me.lblNroExpediente.Text = "Nro. del Expediente"
        '
        'gxpListObservaciones
        '
        Me.gxpListObservaciones.BackColor = System.Drawing.Color.DarkGray
        Me.gxpListObservaciones.Controls.Add(Me.dgvComprobantesVer)
        Me.gxpListObservaciones.Controls.Add(Me.dgvConceptosver)
        Me.gxpListObservaciones.Controls.Add(Me.btnAgregarCabecera)
        Me.gxpListObservaciones.Controls.Add(Me.cmdModificarExp)
        Me.gxpListObservaciones.Controls.Add(Me.lblMensajeModificar)
        Me.gxpListObservaciones.Controls.Add(Me.rhcObservacionesE)
        Me.gxpListObservaciones.Controls.Add(Me.Label4)
        Me.gxpListObservaciones.Controls.Add(Me.Label3)
        Me.gxpListObservaciones.Controls.Add(Me.Label12)
        Me.gxpListObservaciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gxpListObservaciones.ForeColor = System.Drawing.Color.Black
        Me.gxpListObservaciones.Location = New System.Drawing.Point(6, 232)
        Me.gxpListObservaciones.Name = "gxpListObservaciones"
        Me.gxpListObservaciones.Size = New System.Drawing.Size(906, 397)
        Me.gxpListObservaciones.TabIndex = 10
        Me.gxpListObservaciones.TabStop = False
        Me.gxpListObservaciones.Text = "Datos Adicionales"
        '
        'dgvComprobantesVer
        '
        Me.dgvComprobantesVer.AllowUserToAddRows = False
        Me.dgvComprobantesVer.AllowUserToDeleteRows = False
        Me.dgvComprobantesVer.AllowUserToOrderColumns = True
        Me.dgvComprobantesVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComprobantesVer.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvComprobantesVer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComprobantesVer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvComprobantesVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobantesVer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.cdDesglosado})
        Me.dgvComprobantesVer.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvComprobantesVer.Location = New System.Drawing.Point(29, 117)
        Me.dgvComprobantesVer.MultiSelect = False
        Me.dgvComprobantesVer.Name = "dgvComprobantesVer"
        Me.dgvComprobantesVer.ReadOnly = True
        Me.dgvComprobantesVer.RowHeadersVisible = False
        Me.dgvComprobantesVer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvComprobantesVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvComprobantesVer.Size = New System.Drawing.Size(499, 197)
        Me.dgvComprobantesVer.TabIndex = 83
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cdExpediente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "colExp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cdComprobante"
        Me.DataGridViewTextBoxColumn13.HeaderText = "codComprobante"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "dsNroExpediente"
        Me.DataGridViewTextBoxColumn21.FillWeight = 87.60152!
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nro. Expediente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "dsNroComprobante"
        Me.DataGridViewTextBoxColumn22.FillWeight = 112.8276!
        Me.DataGridViewTextBoxColumn22.HeaderText = "Nro.Comprobante"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "dtFechaRel"
        Me.DataGridViewTextBoxColumn23.FillWeight = 118.2357!
        Me.DataGridViewTextBoxColumn23.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "cdMoneda"
        Me.DataGridViewTextBoxColumn26.HeaderText = "cdMonedaR"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "dsMoneda"
        Me.DataGridViewTextBoxColumn29.FillWeight = 83.29709!
        Me.DataGridViewTextBoxColumn29.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "cdClaseComprobante"
        Me.DataGridViewTextBoxColumn32.HeaderText = "cdClaseComprobante"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "vlImporteC"
        Me.DataGridViewTextBoxColumn33.FillWeight = 83.29709!
        Me.DataGridViewTextBoxColumn33.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'cdDesglosado
        '
        Me.cdDesglosado.DataPropertyName = "cdDesglosado"
        Me.cdDesglosado.HeaderText = "cdDesglosado"
        Me.cdDesglosado.Name = "cdDesglosado"
        Me.cdDesglosado.ReadOnly = True
        Me.cdDesglosado.Visible = False
        '
        'dgvConceptosver
        '
        Me.dgvConceptosver.AllowUserToAddRows = False
        Me.dgvConceptosver.AllowUserToDeleteRows = False
        Me.dgvConceptosver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConceptosver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConceptosver.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvConceptosver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConceptosver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvConceptosver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConceptosver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvConceptosver.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgvConceptosver.Location = New System.Drawing.Point(542, 117)
        Me.dgvConceptosver.MultiSelect = False
        Me.dgvConceptosver.Name = "dgvConceptosver"
        Me.dgvConceptosver.ReadOnly = True
        Me.dgvConceptosver.RowHeadersVisible = False
        Me.dgvConceptosver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConceptosver.Size = New System.Drawing.Size(350, 197)
        Me.dgvConceptosver.TabIndex = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cdSubConcepto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cdSubConcepto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dsConcepto"
        Me.DataGridViewTextBoxColumn4.FillWeight = 181.341!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dsSubConcepto"
        Me.DataGridViewTextBoxColumn5.FillWeight = 152.5298!
        Me.DataGridViewTextBoxColumn5.HeaderText = "SubConcepto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sObservacion"
        Me.DataGridViewTextBoxColumn6.FillWeight = 278.286!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btnAgregarCabecera
        '
        Me.btnAgregarCabecera.Image = CType(resources.GetObject("btnAgregarCabecera.Image"), System.Drawing.Image)
        Me.btnAgregarCabecera.Location = New System.Drawing.Point(757, 331)
        Me.btnAgregarCabecera.Name = "btnAgregarCabecera"
        Me.btnAgregarCabecera.Size = New System.Drawing.Size(39, 42)
        Me.btnAgregarCabecera.TabIndex = 12
        Me.btnAgregarCabecera.UseVisualStyleBackColor = True
        '
        'cmdModificarExp
        '
        Me.cmdModificarExp.Enabled = False
        Me.cmdModificarExp.Image = CType(resources.GetObject("cmdModificarExp.Image"), System.Drawing.Image)
        Me.cmdModificarExp.Location = New System.Drawing.Point(717, 331)
        Me.cmdModificarExp.Name = "cmdModificarExp"
        Me.cmdModificarExp.Size = New System.Drawing.Size(39, 42)
        Me.cmdModificarExp.TabIndex = 13
        Me.cmdModificarExp.UseVisualStyleBackColor = True
        '
        'lblMensajeModificar
        '
        Me.lblMensajeModificar.AutoSize = True
        Me.lblMensajeModificar.BackColor = System.Drawing.Color.DarkGray
        Me.lblMensajeModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeModificar.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMensajeModificar.Location = New System.Drawing.Point(439, 361)
        Me.lblMensajeModificar.Name = "lblMensajeModificar"
        Me.lblMensajeModificar.Size = New System.Drawing.Size(272, 12)
        Me.lblMensajeModificar.TabIndex = 76
        Me.lblMensajeModificar.Text = "(Presione Aqui si desea Modificar el expediente)"
        '
        'rhcObservacionesE
        '
        Me.rhcObservacionesE.Location = New System.Drawing.Point(29, 34)
        Me.rhcObservacionesE.Name = "rhcObservacionesE"
        Me.rhcObservacionesE.Size = New System.Drawing.Size(767, 50)
        Me.rhcObservacionesE.TabIndex = 11
        Me.rhcObservacionesE.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(539, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Conceptos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 12)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Todos los Comprobantes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(26, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Ingresar Observación (opcional)"
        '
        'lblErrorRS
        '
        Me.lblErrorRS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblErrorRS.AutoSize = True
        Me.lblErrorRS.ForeColor = System.Drawing.Color.Red
        Me.lblErrorRS.Location = New System.Drawing.Point(629, 93)
        Me.lblErrorRS.Name = "lblErrorRS"
        Me.lblErrorRS.Size = New System.Drawing.Size(10, 12)
        Me.lblErrorRS.TabIndex = 18
        Me.lblErrorRS.Text = "*"
        Me.lblErrorRS.Visible = False
        '
        'lblImpE
        '
        Me.lblImpE.AutoSize = True
        Me.lblImpE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpE.ForeColor = System.Drawing.Color.Yellow
        Me.lblImpE.Location = New System.Drawing.Point(170, 5)
        Me.lblImpE.Name = "lblImpE"
        Me.lblImpE.Size = New System.Drawing.Size(12, 12)
        Me.lblImpE.TabIndex = 60
        Me.lblImpE.Text = "€"
        '
        'lblImpD
        '
        Me.lblImpD.AutoSize = True
        Me.lblImpD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpD.ForeColor = System.Drawing.Color.Yellow
        Me.lblImpD.Location = New System.Drawing.Point(81, 5)
        Me.lblImpD.Name = "lblImpD"
        Me.lblImpD.Size = New System.Drawing.Size(27, 12)
        Me.lblImpD.TabIndex = 59
        Me.lblImpD.Text = "U$S"
        '
        'lblFechaV
        '
        Me.lblFechaV.AutoSize = True
        Me.lblFechaV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaV.ForeColor = System.Drawing.Color.Black
        Me.lblFechaV.Location = New System.Drawing.Point(182, 16)
        Me.lblFechaV.Name = "lblFechaV"
        Me.lblFechaV.Size = New System.Drawing.Size(41, 17)
        Me.lblFechaV.TabIndex = 58
        Me.lblFechaV.Text = "Fecha"
        '
        'lblImpP
        '
        Me.lblImpP.AutoSize = True
        Me.lblImpP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpP.ForeColor = System.Drawing.Color.Yellow
        Me.lblImpP.Location = New System.Drawing.Point(2, 5)
        Me.lblImpP.Name = "lblImpP"
        Me.lblImpP.Size = New System.Drawing.Size(12, 12)
        Me.lblImpP.TabIndex = 56
        Me.lblImpP.Text = "$"
        '
        'lblProveedorV
        '
        Me.lblProveedorV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProveedorV.AutoSize = True
        Me.lblProveedorV.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedorV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedorV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProveedorV.Location = New System.Drawing.Point(3, 5)
        Me.lblProveedorV.Name = "lblProveedorV"
        Me.lblProveedorV.Size = New System.Drawing.Size(83, 12)
        Me.lblProveedorV.TabIndex = 55
        Me.lblProveedorV.Text = "Sin Proveedor"
        Me.lblProveedorV.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNroExpedienteV
        '
        Me.lblNroExpedienteV.AutoSize = True
        Me.lblNroExpedienteV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroExpedienteV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNroExpedienteV.Location = New System.Drawing.Point(18, 16)
        Me.lblNroExpedienteV.Name = "lblNroExpedienteV"
        Me.lblNroExpedienteV.Size = New System.Drawing.Size(68, 12)
        Me.lblNroExpedienteV.TabIndex = 54
        Me.lblNroExpedienteV.Text = "Exp(Nuevo)"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(239, 45)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(337, 12)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "EL ULTIMO ESTADO DEL EXPEDIENTE FUE--PARA EL AREA---"
        Me.lblTitulo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(16, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "0.00"
        '
        'lblImporteD
        '
        Me.lblImporteD.AutoSize = True
        Me.lblImporteD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteD.ForeColor = System.Drawing.Color.Yellow
        Me.lblImporteD.Location = New System.Drawing.Point(111, 5)
        Me.lblImporteD.Name = "lblImporteD"
        Me.lblImporteD.Size = New System.Drawing.Size(29, 12)
        Me.lblImporteD.TabIndex = 62
        Me.lblImporteD.Text = "0.00"
        '
        'lblImporteE
        '
        Me.lblImporteE.AutoSize = True
        Me.lblImporteE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteE.ForeColor = System.Drawing.Color.Yellow
        Me.lblImporteE.Location = New System.Drawing.Point(185, 5)
        Me.lblImporteE.Name = "lblImporteE"
        Me.lblImporteE.Size = New System.Drawing.Size(29, 12)
        Me.lblImporteE.TabIndex = 63
        Me.lblImporteE.Text = "0.00"
        '
        'gpbDatosExp
        '
        Me.gpbDatosExp.Controls.Add(Me.lblExpedienteAnexado)
        Me.gpbDatosExp.Controls.Add(Me.lblTitulo)
        Me.gpbDatosExp.Controls.Add(Me.pnlProv)
        Me.gpbDatosExp.Controls.Add(Me.pnlValores)
        Me.gpbDatosExp.Controls.Add(Me.lblMensajeIngNuevo)
        Me.gpbDatosExp.Controls.Add(Me.lblNroExpedienteV)
        Me.gpbDatosExp.Controls.Add(Me.lblFechaV)
        Me.gpbDatosExp.Location = New System.Drawing.Point(9, 56)
        Me.gpbDatosExp.Name = "gpbDatosExp"
        Me.gpbDatosExp.Size = New System.Drawing.Size(988, 69)
        Me.gpbDatosExp.TabIndex = 1
        Me.gpbDatosExp.TabStop = False
        Me.gpbDatosExp.Text = "Datos del Expediente"
        '
        'lblExpedienteAnexado
        '
        Me.lblExpedienteAnexado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpedienteAnexado.AutoSize = True
        Me.lblExpedienteAnexado.BackColor = System.Drawing.Color.Transparent
        Me.lblExpedienteAnexado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpedienteAnexado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblExpedienteAnexado.Location = New System.Drawing.Point(9, 43)
        Me.lblExpedienteAnexado.Name = "lblExpedienteAnexado"
        Me.lblExpedienteAnexado.Size = New System.Drawing.Size(139, 12)
        Me.lblExpedienteAnexado.TabIndex = 68
        Me.lblExpedienteAnexado.Text = "Sin Expediente Anexado"
        Me.lblExpedienteAnexado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlProv
        '
        Me.pnlProv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProv.Controls.Add(Me.lblProveedorV)
        Me.pnlProv.Location = New System.Drawing.Point(178, 11)
        Me.pnlProv.Name = "pnlProv"
        Me.pnlProv.Size = New System.Drawing.Size(474, 28)
        Me.pnlProv.TabIndex = 67
        '
        'pnlValores
        '
        Me.pnlValores.Controls.Add(Me.lblCHF)
        Me.pnlValores.Controls.Add(Me.lblFs)
        Me.pnlValores.Controls.Add(Me.lblImporteE)
        Me.pnlValores.Controls.Add(Me.lblImpD)
        Me.pnlValores.Controls.Add(Me.lblImporteD)
        Me.pnlValores.Controls.Add(Me.lblImpE)
        Me.pnlValores.Controls.Add(Me.Label1)
        Me.pnlValores.Controls.Add(Me.lblImpP)
        Me.pnlValores.Location = New System.Drawing.Point(641, 11)
        Me.pnlValores.Name = "pnlValores"
        Me.pnlValores.Size = New System.Drawing.Size(338, 28)
        Me.pnlValores.TabIndex = 66
        '
        'lblFs
        '
        Me.lblFs.AutoSize = True
        Me.lblFs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFs.ForeColor = System.Drawing.Color.Yellow
        Me.lblFs.Location = New System.Drawing.Point(268, 5)
        Me.lblFs.Name = "lblFs"
        Me.lblFs.Size = New System.Drawing.Size(29, 12)
        Me.lblFs.TabIndex = 64
        Me.lblFs.Text = "0.00"
        '
        'lblMensajeIngNuevo
        '
        Me.lblMensajeIngNuevo.AutoSize = True
        Me.lblMensajeIngNuevo.BackColor = System.Drawing.Color.DarkGray
        Me.lblMensajeIngNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeIngNuevo.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeIngNuevo.Location = New System.Drawing.Point(6, 11)
        Me.lblMensajeIngNuevo.Name = "lblMensajeIngNuevo"
        Me.lblMensajeIngNuevo.Size = New System.Drawing.Size(155, 12)
        Me.lblMensajeIngNuevo.TabIndex = 65
        Me.lblMensajeIngNuevo.Text = "Ingresar Nuevo Expediente"
        Me.lblMensajeIngNuevo.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 12)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "INGRESO Y MODIFICACIÓN DE EXPEDIENTES"
        '
        'pnlTmenu
        '
        Me.pnlTmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTmenu.Controls.Add(Me.ToolStrip1)
        Me.pnlTmenu.Location = New System.Drawing.Point(2, 25)
        Me.pnlTmenu.Name = "pnlTmenu"
        Me.pnlTmenu.Size = New System.Drawing.Size(1062, 24)
        Me.pnlTmenu.TabIndex = 46
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMenu, Me.toolEliminar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 24
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
        'toolEliminar
        '
        Me.toolEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolEliminar.Image = CType(resources.GetObject("toolEliminar.Image"), System.Drawing.Image)
        Me.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolEliminar.Name = "toolEliminar"
        Me.toolEliminar.Size = New System.Drawing.Size(23, 22)
        Me.toolEliminar.Text = "Eliminar Expediente"
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
        'mtxtArea
        '
        Me.mtxtArea.AutoSize = True
        Me.mtxtArea.BackColor = System.Drawing.Color.Transparent
        Me.mtxtArea.CodigoAnterior = Nothing
        Me.mtxtArea.Location = New System.Drawing.Point(12, 263)
        Me.mtxtArea.Name = "mtxtArea"
        Me.mtxtArea.Size = New System.Drawing.Size(487, 18)
        Me.mtxtArea.TabIndex = 3
        Me.mtxtArea.TipoOperacion = Nothing
        '
        'mtxtAreaE
        '
        Me.mtxtAreaE.AutoSize = True
        Me.mtxtAreaE.BackColor = System.Drawing.Color.Transparent
        Me.mtxtAreaE.CodigoAnterior = Nothing
        Me.mtxtAreaE.Location = New System.Drawing.Point(35, 206)
        Me.mtxtAreaE.Name = "mtxtAreaE"
        Me.mtxtAreaE.Size = New System.Drawing.Size(766, 18)
        Me.mtxtAreaE.TabIndex = 9
        Me.mtxtAreaE.TipoOperacion = Nothing
        '
        'lblCHF
        '
        Me.lblCHF.AutoSize = True
        Me.lblCHF.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHF.ForeColor = System.Drawing.Color.Yellow
        Me.lblCHF.Location = New System.Drawing.Point(240, 5)
        Me.lblCHF.Name = "lblCHF"
        Me.lblCHF.Size = New System.Drawing.Size(28, 12)
        Me.lblCHF.TabIndex = 65
        Me.lblCHF.Text = "CHF"
        '
        'frmIngresarExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1105, 912)
        Me.Controls.Add(Me.pnlTmenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gpbDatosExp)
        Me.Controls.Add(Me.TabSolapas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIngresarExpedientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabSolapas.ResumeLayout(False)
        Me.TabComprobantes.ResumeLayout(False)
        Me.gbxComprobantesRel.ResumeLayout(False)
        Me.gbxComprobantesRel.PerformLayout()
        CType(Me.dgvComprobantesRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosAsociados.ResumeLayout(False)
        Me.gbxDatosAsociados.PerformLayout()
        Me.grbComprobante.ResumeLayout(False)
        Me.grbComprobante.PerformLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grxObservacion.ResumeLayout(False)
        Me.grxObservacion.PerformLayout()
        Me.grpPeriodoServicio.ResumeLayout(False)
        Me.grpPeriodoServicio.PerformLayout()
        Me.TabAreas.ResumeLayout(False)
        Me.gbxUnidad.ResumeLayout(False)
        Me.gbxUnidad.PerformLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConceptos.ResumeLayout(False)
        Me.gbxObservacion.ResumeLayout(False)
        Me.gbxObservacion.PerformLayout()
        CType(Me.dgvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatosConceptos.ResumeLayout(False)
        Me.pnlDatosConceptos.PerformLayout()
        Me.TabSeguimiento.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbxSolicitudes.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatosMov.ResumeLayout(False)
        Me.pnlDatosMov.PerformLayout()
        CType(Me.dgvSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCabecera.ResumeLayout(False)
        Me.TabCabecera.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.gxpDatosExpediente.ResumeLayout(False)
        Me.gxpDatosExpediente.PerformLayout()
        Me.gxpListObservaciones.ResumeLayout(False)
        Me.gxpListObservaciones.PerformLayout()
        CType(Me.dgvComprobantesVer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConceptosver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosExp.ResumeLayout(False)
        Me.gpbDatosExp.PerformLayout()
        Me.pnlProv.ResumeLayout(False)
        Me.pnlProv.PerformLayout()
        Me.pnlValores.ResumeLayout(False)
        Me.pnlValores.PerformLayout()
        Me.pnlTmenu.ResumeLayout(False)
        Me.pnlTmenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabSolapas As System.Windows.Forms.TabControl
    Friend WithEvents TabComprobantes As System.Windows.Forms.TabPage
    Friend WithEvents TabAreas As System.Windows.Forms.TabPage
    Friend WithEvents colExpediente As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents colExcluir As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TabConceptos As System.Windows.Forms.TabPage
    Friend WithEvents gbxUnidad As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUnidad As System.Windows.Forms.DataGridView
    Friend WithEvents lblErrorunidad As System.Windows.Forms.Label
    Friend WithEvents gbxObservacion As System.Windows.Forms.GroupBox
    Friend WithEvents lblErrorConceptos As System.Windows.Forms.Label
    Friend WithEvents cboTipoExpediente As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoExp As System.Windows.Forms.Label
    Friend WithEvents txtcdExpediente As System.Windows.Forms.TextBox
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblErrorRS As System.Windows.Forms.Label
    Friend WithEvents txtNroExpediente As System.Windows.Forms.TextBox
    Friend WithEvents lblNroExpediente As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents TabSeguimiento As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSeguimiento As System.Windows.Forms.DataGridView
    Public WithEvents gbxDatosAsociados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvlistado As System.Windows.Forms.DataGridView
    Friend WithEvents lblIImporteVistaVC As System.Windows.Forms.Label
    Friend WithEvents lblIValormporpesosVC As System.Windows.Forms.Label
    Friend WithEvents TabCabecera As System.Windows.Forms.TabPage
    Friend WithEvents gxpListObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents rhcObservacionesE As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblProveedorV As System.Windows.Forms.Label
    Friend WithEvents lblNroExpedienteV As System.Windows.Forms.Label
    Friend WithEvents lblFechaV As System.Windows.Forms.Label
    Friend WithEvents lblImpP As System.Windows.Forms.Label
    Public WithEvents grbComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents lblImporteCV As System.Windows.Forms.Label
    Friend WithEvents lblCotizacionVC As System.Windows.Forms.Label
    Friend WithEvents lblFechaVC As System.Windows.Forms.Label
    Friend WithEvents lblNroComprobanteVC As System.Windows.Forms.Label
    Friend WithEvents lblErrorCotizacion As System.Windows.Forms.Label
    Public WithEvents grxObservacion As System.Windows.Forms.GroupBox
    Friend WithEvents lblImporteO As System.Windows.Forms.Label
    Friend WithEvents txtImporteOtros As System.Windows.Forms.TextBox
    Friend WithEvents lblConvenio As System.Windows.Forms.Label
    Friend WithEvents txtNroConvenio As System.Windows.Forms.TextBox
    Friend WithEvents grpPeriodoServicio As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesactivarC As System.Windows.Forms.Button
    Friend WithEvents cmdPeriodicidadC As System.Windows.Forms.Button
    Friend WithEvents lblFechaHastaC As System.Windows.Forms.Label
    Friend WithEvents lblFechaDesdeC As System.Windows.Forms.Label
    Friend WithEvents lblPeriocidad As System.Windows.Forms.Label
    Friend WithEvents cboPeriodicidadC As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents lblObjeto As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents rchObservacionO As System.Windows.Forms.RichTextBox
    Friend WithEvents lblObservacionO As System.Windows.Forms.Label
    Friend WithEvents pnlDatosConceptos As System.Windows.Forms.Panel
    Friend WithEvents lblSubConcepto As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents gxpDatosExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents lblImpD As System.Windows.Forms.Label
    Friend WithEvents lblCotizacion As System.Windows.Forms.Label
    Friend WithEvents txtCotMoneda As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblImpE As System.Windows.Forms.Label
    Friend WithEvents lblImporteE As System.Windows.Forms.Label
    Friend WithEvents lblImporteD As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpbDatosExp As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtxtArea As Facturas.mTxtAutoComplete
    Friend WithEvents dgvConceptos As System.Windows.Forms.DataGridView
    Friend WithEvents mtxtAreaE As Facturas.mTxtAutoComplete
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblMensajeIngNuevo As System.Windows.Forms.Label
    Friend WithEvents lblMensajeModificar As System.Windows.Forms.Label
    Friend WithEvents cmdModificarExp As System.Windows.Forms.Button
    Friend WithEvents btnAgregarCabecera As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarComp As System.Windows.Forms.Button
    Friend WithEvents cmdModificarComprobante As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarConcepto As System.Windows.Forms.Button
    Friend WithEvents cmdSeguimiento As System.Windows.Forms.Button
    Friend WithEvents cmdGuardarConvenio As System.Windows.Forms.Button
    Friend WithEvents cmdModificarConvenio As System.Windows.Forms.Button
    Friend WithEvents ColumcdExp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumcdSubConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumdsConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columSubConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumdsObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblDesglose As System.Windows.Forms.Label
    Friend WithEvents lblAreaVC As System.Windows.Forms.Label
    Friend WithEvents txtObservacionesConceptos As System.Windows.Forms.RichTextBox
    Friend WithEvents txtObjeto As System.Windows.Forms.RichTextBox
    Friend WithEvents lblMensajeGrillaUnidad As System.Windows.Forms.Label
    Friend WithEvents cboTipoPeriodicidad As System.Windows.Forms.ComboBox
    Friend WithEvents colExp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsComprobanteClaseTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcdMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdClaseComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdTipoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsObservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumcdPerio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsPerio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldtFechaDesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldtFechaHasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents escdDesglose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsClaseComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsTipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumvlImporteFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlCotizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsAbreviatura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents _Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlDatosMov As System.Windows.Forms.Panel
    Friend WithEvents rchObservacionMov As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAreaMov As System.Windows.Forms.Label
    Friend WithEvents lblMovimiento As System.Windows.Forms.Label
    Friend WithEvents lblObservMov As System.Windows.Forms.Label
    Friend WithEvents lblAreaMovimiento As System.Windows.Forms.Label
    Friend WithEvents dtFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlValores As System.Windows.Forms.Panel
    Friend WithEvents pnlProv As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTmenu As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvConceptosver As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificarSE As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkExterior As System.Windows.Forms.CheckBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblNroBeneficiario As System.Windows.Forms.Label
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtNroBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtcdNroExpedienteRel As System.Windows.Forms.TextBox
    Friend WithEvents txtNroExpedienteRel As System.Windows.Forms.TextBox
    Friend WithEvents lblNroExpedienteRelacionado As System.Windows.Forms.Label
    Friend WithEvents gbxComprobantesRel As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvComprobantesRel As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvComprobantesVer As System.Windows.Forms.DataGridView
    Friend WithEvents cdExpediente1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdComprobante2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsNroExpediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsNroComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFechaRel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdMonedaR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdClaseComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlImporteC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblExpedienteAnexado As System.Windows.Forms.Label
    Friend WithEvents txtcdSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents dsNroSolicitud As System.Windows.Forms.TextBox
    Public WithEvents gbxSolicitudes As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvSolicitudes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsNroExpSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdSolicitudEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codSeguimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codExpediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columdsEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columcdArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columdsArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdBaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdEtapa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsEtapa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colum_ver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Columnedit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colum_delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdDesglosado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblFs As Label
    Friend WithEvents lblCHF As Label
End Class
