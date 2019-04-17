<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes_Varios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes_Varios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsMenu = New System.Windows.Forms.ToolStripButton()
        Me.cboReporte = New System.Windows.Forms.ComboBox()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.gxbSeleccReport = New System.Windows.Forms.GroupBox()
        Me.gbPeriodo = New System.Windows.Forms.GroupBox()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaH = New System.Windows.Forms.Label()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.cboTipoExp = New System.Windows.Forms.ComboBox()
        Me.gxDatExp = New System.Windows.Forms.GroupBox()
        Me.txtExpediente = New System.Windows.Forms.TextBox()
        Me.lblExpediente = New System.Windows.Forms.Label()
        Me.lblTipoExp = New System.Windows.Forms.Label()
        Me.gxbAreaUltMov = New System.Windows.Forms.GroupBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.gbxRazonSocial = New System.Windows.Forms.GroupBox()
        Me.cboRS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gxbDatosComprobantes = New System.Windows.Forms.GroupBox()
        Me.txtNroComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClaseComp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.gxbSeleccReport.SuspendLayout()
        Me.gbPeriodo.SuspendLayout()
        Me.gxDatExp.SuspendLayout()
        Me.gxbAreaUltMov.SuspendLayout()
        Me.gbxRazonSocial.SuspendLayout()
        Me.gxbDatosComprobantes.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMenu})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 25)
        Me.ToolStrip1.TabIndex = 26
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
        'cboReporte
        '
        Me.cboReporte.FormattingEnabled = True
        Me.cboReporte.Location = New System.Drawing.Point(13, 32)
        Me.cboReporte.Name = "cboReporte"
        Me.cboReporte.Size = New System.Drawing.Size(577, 20)
        Me.cboReporte.TabIndex = 3
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Location = New System.Drawing.Point(9, 16)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(115, 12)
        Me.lblReporte.TabIndex = 0
        Me.lblReporte.Text = "Seleccione Reporte"
        '
        'gxbSeleccReport
        '
        Me.gxbSeleccReport.BackColor = System.Drawing.Color.DarkGray
        Me.gxbSeleccReport.Controls.Add(Me.cboReporte)
        Me.gxbSeleccReport.Controls.Add(Me.lblReporte)
        Me.gxbSeleccReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.gxbSeleccReport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gxbSeleccReport.Location = New System.Drawing.Point(0, 25)
        Me.gxbSeleccReport.Name = "gxbSeleccReport"
        Me.gxbSeleccReport.Size = New System.Drawing.Size(1035, 59)
        Me.gxbSeleccReport.TabIndex = 1
        Me.gxbSeleccReport.TabStop = False
        '
        'gbPeriodo
        '
        Me.gbPeriodo.BackColor = System.Drawing.Color.DarkGray
        Me.gbPeriodo.Controls.Add(Me.dtHasta)
        Me.gbPeriodo.Controls.Add(Me.lblFechaH)
        Me.gbPeriodo.Controls.Add(Me.dtDesde)
        Me.gbPeriodo.Controls.Add(Me.lblFechaD)
        Me.gbPeriodo.ForeColor = System.Drawing.Color.Black
        Me.gbPeriodo.Location = New System.Drawing.Point(0, 9)
        Me.gbPeriodo.Name = "gbPeriodo"
        Me.gbPeriodo.Size = New System.Drawing.Size(234, 69)
        Me.gbPeriodo.TabIndex = 27
        Me.gbPeriodo.TabStop = False
        Me.gbPeriodo.Text = "Seleccionar Periodo"
        '
        'dtHasta
        '
        Me.dtHasta.Checked = False
        Me.dtHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(112, 28)
        Me.dtHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtHasta.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.ShowCheckBox = True
        Me.dtHasta.Size = New System.Drawing.Size(96, 22)
        Me.dtHasta.TabIndex = 29
        '
        'lblFechaH
        '
        Me.lblFechaH.AutoSize = True
        Me.lblFechaH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaH.ForeColor = System.Drawing.Color.Black
        Me.lblFechaH.Location = New System.Drawing.Point(109, 16)
        Me.lblFechaH.Name = "lblFechaH"
        Me.lblFechaH.Size = New System.Drawing.Size(74, 12)
        Me.lblFechaH.TabIndex = 31
        Me.lblFechaH.Text = "Fecha hasta"
        '
        'dtDesde
        '
        Me.dtDesde.Checked = False
        Me.dtDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(12, 28)
        Me.dtDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtDesde.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.ShowCheckBox = True
        Me.dtDesde.Size = New System.Drawing.Size(94, 22)
        Me.dtDesde.TabIndex = 28
        '
        'lblFechaD
        '
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaD.ForeColor = System.Drawing.Color.Black
        Me.lblFechaD.Location = New System.Drawing.Point(9, 16)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(77, 12)
        Me.lblFechaD.TabIndex = 30
        Me.lblFechaD.Text = "Fecha desde"
        '
        'cboTipoExp
        '
        Me.cboTipoExp.FormattingEnabled = True
        Me.cboTipoExp.Location = New System.Drawing.Point(12, 29)
        Me.cboTipoExp.Name = "cboTipoExp"
        Me.cboTipoExp.Size = New System.Drawing.Size(129, 21)
        Me.cboTipoExp.TabIndex = 3
        '
        'gxDatExp
        '
        Me.gxDatExp.BackColor = System.Drawing.Color.DarkGray
        Me.gxDatExp.Controls.Add(Me.txtExpediente)
        Me.gxDatExp.Controls.Add(Me.lblExpediente)
        Me.gxDatExp.Controls.Add(Me.lblTipoExp)
        Me.gxDatExp.Controls.Add(Me.cboTipoExp)
        Me.gxDatExp.ForeColor = System.Drawing.Color.Black
        Me.gxDatExp.Location = New System.Drawing.Point(246, 9)
        Me.gxDatExp.Name = "gxDatExp"
        Me.gxDatExp.Size = New System.Drawing.Size(364, 69)
        Me.gxDatExp.TabIndex = 28
        Me.gxDatExp.TabStop = False
        Me.gxDatExp.Text = "Seleccionar Datos del Expediente"
        '
        'txtExpediente
        '
        Me.txtExpediente.Location = New System.Drawing.Point(147, 30)
        Me.txtExpediente.MaxLength = 13
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.Size = New System.Drawing.Size(197, 20)
        Me.txtExpediente.TabIndex = 32
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpediente.ForeColor = System.Drawing.Color.Black
        Me.lblExpediente.Location = New System.Drawing.Point(144, 16)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(113, 12)
        Me.lblExpediente.TabIndex = 31
        Me.lblExpediente.Text = "Nro. del Expediente"
        '
        'lblTipoExp
        '
        Me.lblTipoExp.AutoSize = True
        Me.lblTipoExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoExp.ForeColor = System.Drawing.Color.Black
        Me.lblTipoExp.Location = New System.Drawing.Point(9, 16)
        Me.lblTipoExp.Name = "lblTipoExp"
        Me.lblTipoExp.Size = New System.Drawing.Size(114, 12)
        Me.lblTipoExp.TabIndex = 30
        Me.lblTipoExp.Text = "Tipo del Expediente"
        '
        'gxbAreaUltMov
        '
        Me.gxbAreaUltMov.BackColor = System.Drawing.Color.DarkGray
        Me.gxbAreaUltMov.Controls.Add(Me.cboArea)
        Me.gxbAreaUltMov.Controls.Add(Me.lblArea)
        Me.gxbAreaUltMov.ForeColor = System.Drawing.Color.Black
        Me.gxbAreaUltMov.Location = New System.Drawing.Point(616, 9)
        Me.gxbAreaUltMov.Name = "gxbAreaUltMov"
        Me.gxbAreaUltMov.Size = New System.Drawing.Size(342, 69)
        Me.gxbAreaUltMov.TabIndex = 30
        Me.gxbAreaUltMov.TabStop = False
        Me.gxbAreaUltMov.Text = "Seleccionar Area"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(12, 29)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(317, 21)
        Me.cboArea.TabIndex = 32
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.Location = New System.Drawing.Point(9, 16)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(100, 12)
        Me.lblArea.TabIndex = 31
        Me.lblArea.Text = "Area que lo tiene"
        '
        'gbxRazonSocial
        '
        Me.gbxRazonSocial.BackColor = System.Drawing.Color.DarkGray
        Me.gbxRazonSocial.Controls.Add(Me.cboRS)
        Me.gbxRazonSocial.Controls.Add(Me.Label4)
        Me.gbxRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.gbxRazonSocial.Location = New System.Drawing.Point(0, 84)
        Me.gbxRazonSocial.Name = "gbxRazonSocial"
        Me.gbxRazonSocial.Size = New System.Drawing.Size(510, 59)
        Me.gbxRazonSocial.TabIndex = 31
        Me.gbxRazonSocial.TabStop = False
        Me.gbxRazonSocial.Text = "Seleccionar Proveedor"
        '
        'cboRS
        '
        Me.cboRS.FormattingEnabled = True
        Me.cboRS.Location = New System.Drawing.Point(12, 32)
        Me.cboRS.Name = "cboRS"
        Me.cboRS.Size = New System.Drawing.Size(480, 21)
        Me.cboRS.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 12)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Proveedor"
        '
        'gxbDatosComprobantes
        '
        Me.gxbDatosComprobantes.BackColor = System.Drawing.Color.DarkGray
        Me.gxbDatosComprobantes.Controls.Add(Me.txtNroComprobante)
        Me.gxbDatosComprobantes.Controls.Add(Me.Label5)
        Me.gxbDatosComprobantes.Controls.Add(Me.cboClaseComp)
        Me.gxbDatosComprobantes.Controls.Add(Me.Label1)
        Me.gxbDatosComprobantes.ForeColor = System.Drawing.Color.Black
        Me.gxbDatosComprobantes.Location = New System.Drawing.Point(522, 84)
        Me.gxbDatosComprobantes.Name = "gxbDatosComprobantes"
        Me.gxbDatosComprobantes.Size = New System.Drawing.Size(436, 59)
        Me.gxbDatosComprobantes.TabIndex = 32
        Me.gxbDatosComprobantes.TabStop = False
        Me.gxbDatosComprobantes.Text = "Seleccionar Datos del Comprobante"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(6, 33)
        Me.txtNroComprobante.MaxLength = 13
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(197, 20)
        Me.txtNroComprobante.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Nro. del Comprobante"
        '
        'cboClaseComp
        '
        Me.cboClaseComp.FormattingEnabled = True
        Me.cboClaseComp.Location = New System.Drawing.Point(218, 32)
        Me.cboClaseComp.Name = "cboClaseComp"
        Me.cboClaseComp.Size = New System.Drawing.Size(197, 21)
        Me.cboClaseComp.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(215, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 12)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Clase Comprobante"
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.DarkGray
        Me.gbFiltros.Controls.Add(Me.gxDatExp)
        Me.gbFiltros.Controls.Add(Me.gxbDatosComprobantes)
        Me.gbFiltros.Controls.Add(Me.gxbAreaUltMov)
        Me.gbFiltros.Controls.Add(Me.gbPeriodo)
        Me.gbFiltros.Controls.Add(Me.gbxRazonSocial)
        Me.gbFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbFiltros.Location = New System.Drawing.Point(0, 84)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1035, 178)
        Me.gbFiltros.TabIndex = 37
        Me.gbFiltros.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 262)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1035, 227)
        Me.WebBrowser1.TabIndex = 38
        '
        'frmReportes_Varios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1035, 489)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.gxbSeleccReport)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportes_Varios"
        Me.Text = "frmReportes_Varios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gxbSeleccReport.ResumeLayout(False)
        Me.gxbSeleccReport.PerformLayout()
        Me.gbPeriodo.ResumeLayout(False)
        Me.gbPeriodo.PerformLayout()
        Me.gxDatExp.ResumeLayout(False)
        Me.gxDatExp.PerformLayout()
        Me.gxbAreaUltMov.ResumeLayout(False)
        Me.gxbAreaUltMov.PerformLayout()
        Me.gbxRazonSocial.ResumeLayout(False)
        Me.gbxRazonSocial.PerformLayout()
        Me.gxbDatosComprobantes.ResumeLayout(False)
        Me.gxbDatosComprobantes.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboReporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblReporte As System.Windows.Forms.Label
    Friend WithEvents gxbSeleccReport As System.Windows.Forms.GroupBox
    Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoExp As System.Windows.Forms.ComboBox
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaH As System.Windows.Forms.Label
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaD As System.Windows.Forms.Label
    Friend WithEvents gxDatExp As System.Windows.Forms.GroupBox
    Friend WithEvents lblExpediente As System.Windows.Forms.Label
    Friend WithEvents lblTipoExp As System.Windows.Forms.Label
    Friend WithEvents gxbAreaUltMov As System.Windows.Forms.GroupBox
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents gbxRazonSocial As System.Windows.Forms.GroupBox
    Friend WithEvents cboRS As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gxbDatosComprobantes As System.Windows.Forms.GroupBox
    Friend WithEvents cboClaseComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExpediente As System.Windows.Forms.TextBox
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
