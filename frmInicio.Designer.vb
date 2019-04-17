<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.pnlCabecera = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblMesActual = New System.Windows.Forms.Label
        Me.lblMesAnterior = New System.Windows.Forms.Label
        Me.dthasta = New System.Windows.Forms.DateTimePicker
        Me.lblPasadoCompPendientes = New System.Windows.Forms.Label
        Me.lblPasadoComLiquidados = New System.Windows.Forms.Label
        Me.lblTotalExpNoLiquidados = New System.Windows.Forms.Label
        Me.lblTotalExpLiquidados = New System.Windows.Forms.Label
        Me.lblTotalExp = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCompIngresados = New System.Windows.Forms.Label
        Me.lblCompLiquiImpagos = New System.Windows.Forms.Label
        Me.lblCompliquipagados = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dt = New System.Windows.Forms.DateTimePicker
        Me.lblComprobantesIngresados = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblComprobantesLiqPag = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblHayExpLiquidado = New System.Windows.Forms.Label
        Me.lblHayCPagados = New System.Windows.Forms.Label
        Me.lblHayExpPagados = New System.Windows.Forms.Label
        Me.lblEnCompPagados = New System.Windows.Forms.Label
        Me.lblHayCLiquidado = New System.Windows.Forms.Label
        Me.lblEnCompLiquidado = New System.Windows.Forms.Label
        Me.lblHayExpIng = New System.Windows.Forms.Label
        Me.lblHayCI = New System.Windows.Forms.Label
        Me.lblEnCIngreso = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblSaludo = New System.Windows.Forms.Label
        Me.pnlCabecera.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.DarkGray
        Me.pnlCabecera.Controls.Add(Me.Label11)
        Me.pnlCabecera.Controls.Add(Me.Label7)
        Me.pnlCabecera.Controls.Add(Me.lblMesActual)
        Me.pnlCabecera.Controls.Add(Me.lblMesAnterior)
        Me.pnlCabecera.Controls.Add(Me.dthasta)
        Me.pnlCabecera.Controls.Add(Me.lblPasadoCompPendientes)
        Me.pnlCabecera.Controls.Add(Me.lblPasadoComLiquidados)
        Me.pnlCabecera.Controls.Add(Me.lblTotalExpNoLiquidados)
        Me.pnlCabecera.Controls.Add(Me.lblTotalExpLiquidados)
        Me.pnlCabecera.Controls.Add(Me.lblTotalExp)
        Me.pnlCabecera.Controls.Add(Me.pnl)
        Me.pnlCabecera.Controls.Add(Me.lblCompIngresados)
        Me.pnlCabecera.Controls.Add(Me.lblCompLiquiImpagos)
        Me.pnlCabecera.Controls.Add(Me.lblCompliquipagados)
        Me.pnlCabecera.Controls.Add(Me.PictureBox1)
        Me.pnlCabecera.Controls.Add(Me.dt)
        Me.pnlCabecera.Controls.Add(Me.lblComprobantesIngresados)
        Me.pnlCabecera.Controls.Add(Me.Label5)
        Me.pnlCabecera.Controls.Add(Me.lblComprobantesLiqPag)
        Me.pnlCabecera.Controls.Add(Me.Label4)
        Me.pnlCabecera.Controls.Add(Me.Label3)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.lblHayExpLiquidado)
        Me.pnlCabecera.Controls.Add(Me.lblHayCPagados)
        Me.pnlCabecera.Controls.Add(Me.lblHayExpPagados)
        Me.pnlCabecera.Controls.Add(Me.lblEnCompPagados)
        Me.pnlCabecera.Controls.Add(Me.lblHayCLiquidado)
        Me.pnlCabecera.Controls.Add(Me.lblEnCompLiquidado)
        Me.pnlCabecera.Controls.Add(Me.lblHayExpIng)
        Me.pnlCabecera.Controls.Add(Me.lblHayCI)
        Me.pnlCabecera.Controls.Add(Me.lblEnCIngreso)
        Me.pnlCabecera.Controls.Add(Me.PictureBox2)
        Me.pnlCabecera.Controls.Add(Me.lblMensaje)
        Me.pnlCabecera.Controls.Add(Me.lblUsuario)
        Me.pnlCabecera.Controls.Add(Me.lblSaludo)
        Me.pnlCabecera.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlCabecera.Size = New System.Drawing.Size(1272, 791)
        Me.pnlCabecera.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(695, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(269, 32)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Totales del sistema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(4, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 28)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Indicadores del mes de"
        '
        'lblMesActual
        '
        Me.lblMesActual.AutoSize = True
        Me.lblMesActual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesActual.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMesActual.Location = New System.Drawing.Point(284, 209)
        Me.lblMesActual.Name = "lblMesActual"
        Me.lblMesActual.Size = New System.Drawing.Size(59, 28)
        Me.lblMesActual.TabIndex = 56
        Me.lblMesActual.Text = "Mes"
        '
        'lblMesAnterior
        '
        Me.lblMesAnterior.AutoSize = True
        Me.lblMesAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesAnterior.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMesAnterior.Location = New System.Drawing.Point(652, 490)
        Me.lblMesAnterior.Name = "lblMesAnterior"
        Me.lblMesAnterior.Size = New System.Drawing.Size(68, 32)
        Me.lblMesAnterior.TabIndex = 56
        Me.lblMesAnterior.Text = "Mes"
        '
        'dthasta
        '
        Me.dthasta.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.dthasta.Checked = False
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(1093, 31)
        Me.dthasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dthasta.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(80, 22)
        Me.dthasta.TabIndex = 55
        Me.dthasta.Visible = False
        '
        'lblPasadoCompPendientes
        '
        Me.lblPasadoCompPendientes.AutoSize = True
        Me.lblPasadoCompPendientes.BackColor = System.Drawing.Color.DarkGray
        Me.lblPasadoCompPendientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasadoCompPendientes.ForeColor = System.Drawing.Color.Black
        Me.lblPasadoCompPendientes.Location = New System.Drawing.Point(380, 631)
        Me.lblPasadoCompPendientes.Name = "lblPasadoCompPendientes"
        Me.lblPasadoCompPendientes.Size = New System.Drawing.Size(65, 22)
        Me.lblPasadoCompPendientes.TabIndex = 54
        Me.lblPasadoCompPendientes.Text = "$ 0,00"
        '
        'lblPasadoComLiquidados
        '
        Me.lblPasadoComLiquidados.AutoSize = True
        Me.lblPasadoComLiquidados.BackColor = System.Drawing.Color.DarkGray
        Me.lblPasadoComLiquidados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasadoComLiquidados.ForeColor = System.Drawing.Color.Black
        Me.lblPasadoComLiquidados.Location = New System.Drawing.Point(380, 566)
        Me.lblPasadoComLiquidados.Name = "lblPasadoComLiquidados"
        Me.lblPasadoComLiquidados.Size = New System.Drawing.Size(65, 22)
        Me.lblPasadoComLiquidados.TabIndex = 53
        Me.lblPasadoComLiquidados.Text = "$ 0,00"
        '
        'lblTotalExpNoLiquidados
        '
        Me.lblTotalExpNoLiquidados.AutoSize = True
        Me.lblTotalExpNoLiquidados.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotalExpNoLiquidados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpNoLiquidados.ForeColor = System.Drawing.Color.Black
        Me.lblTotalExpNoLiquidados.Location = New System.Drawing.Point(1152, 631)
        Me.lblTotalExpNoLiquidados.Name = "lblTotalExpNoLiquidados"
        Me.lblTotalExpNoLiquidados.Size = New System.Drawing.Size(21, 22)
        Me.lblTotalExpNoLiquidados.TabIndex = 52
        Me.lblTotalExpNoLiquidados.Text = "0"
        '
        'lblTotalExpLiquidados
        '
        Me.lblTotalExpLiquidados.AutoSize = True
        Me.lblTotalExpLiquidados.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotalExpLiquidados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpLiquidados.ForeColor = System.Drawing.Color.Black
        Me.lblTotalExpLiquidados.Location = New System.Drawing.Point(1152, 704)
        Me.lblTotalExpLiquidados.Name = "lblTotalExpLiquidados"
        Me.lblTotalExpLiquidados.Size = New System.Drawing.Size(21, 22)
        Me.lblTotalExpLiquidados.TabIndex = 50
        Me.lblTotalExpLiquidados.Text = "0"
        '
        'lblTotalExp
        '
        Me.lblTotalExp.AutoSize = True
        Me.lblTotalExp.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotalExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExp.ForeColor = System.Drawing.Color.Black
        Me.lblTotalExp.Location = New System.Drawing.Point(1152, 269)
        Me.lblTotalExp.Name = "lblTotalExp"
        Me.lblTotalExp.Size = New System.Drawing.Size(21, 22)
        Me.lblTotalExp.TabIndex = 48
        Me.lblTotalExp.Text = "0"
        '
        'pnl
        '
        Me.pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BackColor = System.Drawing.Color.White
        Me.pnl.Controls.Add(Me.Label1)
        Me.pnl.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pnl.Location = New System.Drawing.Point(0, 135)
        Me.pnl.Name = "pnl"
        Me.pnl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnl.Size = New System.Drawing.Size(1272, 71)
        Me.pnl.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Resumen de Facturas y Pagos a Proveedores"
        '
        'lblCompIngresados
        '
        Me.lblCompIngresados.AutoSize = True
        Me.lblCompIngresados.BackColor = System.Drawing.Color.DarkGray
        Me.lblCompIngresados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompIngresados.ForeColor = System.Drawing.Color.Black
        Me.lblCompIngresados.Location = New System.Drawing.Point(1152, 556)
        Me.lblCompIngresados.Name = "lblCompIngresados"
        Me.lblCompIngresados.Size = New System.Drawing.Size(21, 22)
        Me.lblCompIngresados.TabIndex = 46
        Me.lblCompIngresados.Text = "0"
        '
        'lblCompLiquiImpagos
        '
        Me.lblCompLiquiImpagos.AutoSize = True
        Me.lblCompLiquiImpagos.BackColor = System.Drawing.Color.DarkGray
        Me.lblCompLiquiImpagos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompLiquiImpagos.ForeColor = System.Drawing.Color.Black
        Me.lblCompLiquiImpagos.Location = New System.Drawing.Point(1152, 411)
        Me.lblCompLiquiImpagos.Name = "lblCompLiquiImpagos"
        Me.lblCompLiquiImpagos.Size = New System.Drawing.Size(21, 22)
        Me.lblCompLiquiImpagos.TabIndex = 44
        Me.lblCompLiquiImpagos.Text = "0"
        '
        'lblCompliquipagados
        '
        Me.lblCompliquipagados.AutoSize = True
        Me.lblCompliquipagados.BackColor = System.Drawing.Color.DarkGray
        Me.lblCompliquipagados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompliquipagados.ForeColor = System.Drawing.Color.Black
        Me.lblCompliquipagados.Location = New System.Drawing.Point(1152, 326)
        Me.lblCompliquipagados.Name = "lblCompliquipagados"
        Me.lblCompliquipagados.Size = New System.Drawing.Size(21, 22)
        Me.lblCompliquipagados.TabIndex = 42
        Me.lblCompliquipagados.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(721, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'dt
        '
        Me.dt.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.dt.Checked = False
        Me.dt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(1093, 3)
        Me.dt.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dt.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(80, 22)
        Me.dt.TabIndex = 39
        Me.dt.Visible = False
        '
        'lblComprobantesIngresados
        '
        Me.lblComprobantesIngresados.AutoSize = True
        Me.lblComprobantesIngresados.BackColor = System.Drawing.Color.DarkGray
        Me.lblComprobantesIngresados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprobantesIngresados.ForeColor = System.Drawing.Color.Black
        Me.lblComprobantesIngresados.Location = New System.Drawing.Point(380, 411)
        Me.lblComprobantesIngresados.Name = "lblComprobantesIngresados"
        Me.lblComprobantesIngresados.Size = New System.Drawing.Size(65, 22)
        Me.lblComprobantesIngresados.TabIndex = 38
        Me.lblComprobantesIngresados.Text = "$ 0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(380, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 22)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "$ 0,00"
        '
        'lblComprobantesLiqPag
        '
        Me.lblComprobantesLiqPag.AutoSize = True
        Me.lblComprobantesLiqPag.BackColor = System.Drawing.Color.DarkGray
        Me.lblComprobantesLiqPag.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprobantesLiqPag.ForeColor = System.Drawing.Color.Black
        Me.lblComprobantesLiqPag.Location = New System.Drawing.Point(380, 269)
        Me.lblComprobantesLiqPag.Name = "lblComprobantesLiqPag"
        Me.lblComprobantesLiqPag.Size = New System.Drawing.Size(65, 22)
        Me.lblComprobantesLiqPag.TabIndex = 36
        Me.lblComprobantesLiqPag.Text = "$ 0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 631)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 44)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Comprobantes pendientes de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "liquidar(impagos)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 566)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Comprobantes liquidados (pagados)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(319, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 32)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Indicadores del mes de "
        '
        'lblHayExpLiquidado
        '
        Me.lblHayExpLiquidado.AutoSize = True
        Me.lblHayExpLiquidado.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayExpLiquidado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayExpLiquidado.ForeColor = System.Drawing.Color.Black
        Me.lblHayExpLiquidado.Location = New System.Drawing.Point(697, 704)
        Me.lblHayExpLiquidado.Name = "lblHayExpLiquidado"
        Me.lblHayExpLiquidado.Size = New System.Drawing.Size(315, 22)
        Me.lblHayExpLiquidado.TabIndex = 32
        Me.lblHayExpLiquidado.Text = "Expedientes liquidados(pagados)"
        '
        'lblHayCPagados
        '
        Me.lblHayCPagados.AutoSize = True
        Me.lblHayCPagados.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayCPagados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayCPagados.ForeColor = System.Drawing.Color.Black
        Me.lblHayCPagados.Location = New System.Drawing.Point(697, 566)
        Me.lblHayCPagados.Name = "lblHayCPagados"
        Me.lblHayCPagados.Size = New System.Drawing.Size(251, 22)
        Me.lblHayCPagados.TabIndex = 31
        Me.lblHayCPagados.Text = "Comprobantes ingresados"
        '
        'lblHayExpPagados
        '
        Me.lblHayExpPagados.AutoSize = True
        Me.lblHayExpPagados.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayExpPagados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayExpPagados.ForeColor = System.Drawing.Color.Black
        Me.lblHayExpPagados.Location = New System.Drawing.Point(697, 631)
        Me.lblHayExpPagados.Name = "lblHayExpPagados"
        Me.lblHayExpPagados.Size = New System.Drawing.Size(262, 44)
        Me.lblHayExpPagados.TabIndex = 30
        Me.lblHayExpPagados.Text = "Expedientes pendientes de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "liquidar(impagos)"
        Me.lblHayExpPagados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEnCompPagados
        '
        Me.lblEnCompPagados.AutoSize = True
        Me.lblEnCompPagados.BackColor = System.Drawing.Color.DarkGray
        Me.lblEnCompPagados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnCompPagados.ForeColor = System.Drawing.Color.Black
        Me.lblEnCompPagados.Location = New System.Drawing.Point(14, 411)
        Me.lblEnCompPagados.Name = "lblEnCompPagados"
        Me.lblEnCompPagados.Size = New System.Drawing.Size(256, 22)
        Me.lblEnCompPagados.TabIndex = 29
        Me.lblEnCompPagados.Text = "Comprobantes ingresados "
        '
        'lblHayCLiquidado
        '
        Me.lblHayCLiquidado.AutoSize = True
        Me.lblHayCLiquidado.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayCLiquidado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayCLiquidado.ForeColor = System.Drawing.Color.Black
        Me.lblHayCLiquidado.Location = New System.Drawing.Point(701, 411)
        Me.lblHayCLiquidado.Name = "lblHayCLiquidado"
        Me.lblHayCLiquidado.Size = New System.Drawing.Size(445, 22)
        Me.lblHayCLiquidado.TabIndex = 28
        Me.lblHayCLiquidado.Text = "Comprobantes pendientes de liquidar(impagos)"
        Me.lblHayCLiquidado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEnCompLiquidado
        '
        Me.lblEnCompLiquidado.AutoSize = True
        Me.lblEnCompLiquidado.BackColor = System.Drawing.Color.DarkGray
        Me.lblEnCompLiquidado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnCompLiquidado.ForeColor = System.Drawing.Color.Black
        Me.lblEnCompLiquidado.Location = New System.Drawing.Point(15, 326)
        Me.lblEnCompLiquidado.Name = "lblEnCompLiquidado"
        Me.lblEnCompLiquidado.Size = New System.Drawing.Size(284, 44)
        Me.lblEnCompLiquidado.TabIndex = 27
        Me.lblEnCompLiquidado.Text = "Comprobantes pendientes de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "liquidar (impagos) "
        Me.lblEnCompLiquidado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHayExpIng
        '
        Me.lblHayExpIng.AutoSize = True
        Me.lblHayExpIng.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayExpIng.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayExpIng.ForeColor = System.Drawing.Color.Black
        Me.lblHayExpIng.Location = New System.Drawing.Point(702, 269)
        Me.lblHayExpIng.Name = "lblHayExpIng"
        Me.lblHayExpIng.Size = New System.Drawing.Size(230, 22)
        Me.lblHayExpIng.TabIndex = 26
        Me.lblHayExpIng.Text = "Expedientes Ingresados"
        '
        'lblHayCI
        '
        Me.lblHayCI.AutoSize = True
        Me.lblHayCI.BackColor = System.Drawing.Color.DarkGray
        Me.lblHayCI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHayCI.ForeColor = System.Drawing.Color.Black
        Me.lblHayCI.Location = New System.Drawing.Point(701, 326)
        Me.lblHayCI.Name = "lblHayCI"
        Me.lblHayCI.Size = New System.Drawing.Size(337, 22)
        Me.lblHayCI.TabIndex = 25
        Me.lblHayCI.Text = "Comprobantes liquidados(pagados)"
        '
        'lblEnCIngreso
        '
        Me.lblEnCIngreso.AutoSize = True
        Me.lblEnCIngreso.BackColor = System.Drawing.Color.DarkGray
        Me.lblEnCIngreso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnCIngreso.ForeColor = System.Drawing.Color.Black
        Me.lblEnCIngreso.Location = New System.Drawing.Point(12, 269)
        Me.lblEnCIngreso.Name = "lblEnCIngreso"
        Me.lblEnCIngreso.Size = New System.Drawing.Size(352, 22)
        Me.lblEnCIngreso.TabIndex = 24
        Me.lblEnCIngreso.Text = "Comprobantes liquidados (pagados)  "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(594, 97)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Black
        Me.lblMensaje.Location = New System.Drawing.Point(612, 92)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(392, 22)
        Me.lblMensaje.TabIndex = 13
        Me.lblMensaje.Text = "Si necesita soporte llame al Tel. 43443674"
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.Location = New System.Drawing.Point(15, 66)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(479, 22)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Gustavo Quinteros, es un gusto tenerlo nuevamente"
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaludo.ForeColor = System.Drawing.Color.Black
        Me.lblSaludo.Location = New System.Drawing.Point(15, 31)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(212, 22)
        Me.lblSaludo.TabIndex = 11
        Me.lblSaludo.Text = "Bienvenido a Facturas"
        '
        'frmInicio
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1276, 797)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCabecera)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblSaludo As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHayExpLiquidado As System.Windows.Forms.Label
    Friend WithEvents lblHayCPagados As System.Windows.Forms.Label
    Friend WithEvents lblHayExpPagados As System.Windows.Forms.Label
    Friend WithEvents lblEnCompPagados As System.Windows.Forms.Label
    Friend WithEvents lblHayCLiquidado As System.Windows.Forms.Label
    Friend WithEvents lblEnCompLiquidado As System.Windows.Forms.Label
    Friend WithEvents lblHayExpIng As System.Windows.Forms.Label
    Friend WithEvents lblHayCI As System.Windows.Forms.Label
    Friend WithEvents lblEnCIngreso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblComprobantesLiqPag As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblComprobantesIngresados As System.Windows.Forms.Label
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompLiquiImpagos As System.Windows.Forms.Label
    Friend WithEvents lblCompliquipagados As System.Windows.Forms.Label
    Friend WithEvents lblCompIngresados As System.Windows.Forms.Label
    Friend WithEvents lblTotalExp As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpNoLiquidados As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpLiquidados As System.Windows.Forms.Label
    Friend WithEvents lblPasadoCompPendientes As System.Windows.Forms.Label
    Friend WithEvents lblPasadoComLiquidados As System.Windows.Forms.Label
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMesActual As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMesAnterior As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
