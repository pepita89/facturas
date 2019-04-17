<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.chkExterior = New System.Windows.Forms.CheckBox
        Me.txtCuit = New System.Windows.Forms.TextBox
        Me.lblNroBeneficiario = New System.Windows.Forms.Label
        Me.lblCuit = New System.Windows.Forms.Label
        Me.txtRazonSocial = New System.Windows.Forms.TextBox
        Me.txtNroBeneficiario = New System.Windows.Forms.TextBox
        Me.grbComprobante = New System.Windows.Forms.GroupBox
        Me.txtcodProv = New System.Windows.Forms.TextBox
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.lblErrorCotizacion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblRazonS = New System.Windows.Forms.Label
        Me.grbComprobante.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkExterior
        '
        Me.chkExterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkExterior.AutoSize = True
        Me.chkExterior.BackColor = System.Drawing.Color.DarkGray
        Me.chkExterior.ForeColor = System.Drawing.Color.Black
        Me.chkExterior.Location = New System.Drawing.Point(818, 75)
        Me.chkExterior.Name = "chkExterior"
        Me.chkExterior.Size = New System.Drawing.Size(84, 16)
        Me.chkExterior.TabIndex = 1
        Me.chkExterior.Text = "Es Exterior"
        Me.chkExterior.UseVisualStyleBackColor = False
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.Location = New System.Drawing.Point(767, 47)
        Me.txtCuit.MaxLength = 20
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(135, 22)
        Me.txtCuit.TabIndex = 4
        '
        'lblNroBeneficiario
        '
        Me.lblNroBeneficiario.AutoSize = True
        Me.lblNroBeneficiario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroBeneficiario.ForeColor = System.Drawing.Color.Black
        Me.lblNroBeneficiario.Location = New System.Drawing.Point(646, 32)
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
        Me.lblCuit.Location = New System.Drawing.Point(764, 31)
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(12, 48)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(631, 22)
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtNroBeneficiario
        '
        Me.txtNroBeneficiario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBeneficiario.Location = New System.Drawing.Point(649, 48)
        Me.txtNroBeneficiario.MaxLength = 20
        Me.txtNroBeneficiario.Name = "txtNroBeneficiario"
        Me.txtNroBeneficiario.Size = New System.Drawing.Size(110, 22)
        Me.txtNroBeneficiario.TabIndex = 3
        '
        'grbComprobante
        '
        Me.grbComprobante.BackColor = System.Drawing.Color.DarkGray
        Me.grbComprobante.Controls.Add(Me.txtcodProv)
        Me.grbComprobante.Controls.Add(Me.cmdModificar)
        Me.grbComprobante.Controls.Add(Me.chkExterior)
        Me.grbComprobante.Controls.Add(Me.cmdAgregar)
        Me.grbComprobante.Controls.Add(Me.txtCuit)
        Me.grbComprobante.Controls.Add(Me.lblNroBeneficiario)
        Me.grbComprobante.Controls.Add(Me.lblErrorCotizacion)
        Me.grbComprobante.Controls.Add(Me.lblCuit)
        Me.grbComprobante.Controls.Add(Me.Label2)
        Me.grbComprobante.Controls.Add(Me.txtNroBeneficiario)
        Me.grbComprobante.Controls.Add(Me.lblRazonS)
        Me.grbComprobante.Controls.Add(Me.txtRazonSocial)
        Me.grbComprobante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbComprobante.ForeColor = System.Drawing.Color.Black
        Me.grbComprobante.Location = New System.Drawing.Point(1, 12)
        Me.grbComprobante.Name = "grbComprobante"
        Me.grbComprobante.Size = New System.Drawing.Size(936, 175)
        Me.grbComprobante.TabIndex = 43
        Me.grbComprobante.TabStop = False
        Me.grbComprobante.Text = "Ingreso y modificación de proveedores"
        '
        'txtcodProv
        '
        Me.txtcodProv.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodProv.Location = New System.Drawing.Point(892, 48)
        Me.txtcodProv.MaxLength = 20
        Me.txtcodProv.Name = "txtcodProv"
        Me.txtcodProv.Size = New System.Drawing.Size(10, 22)
        Me.txtcodProv.TabIndex = 37
        Me.txtcodProv.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.White
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(818, 111)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 42)
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ForeColor = System.Drawing.Color.Black
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.Location = New System.Drawing.Point(862, 111)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(40, 42)
        Me.cmdAgregar.TabIndex = 19
        Me.cmdAgregar.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "*"
        Me.Label2.Visible = False
        '
        'lblRazonS
        '
        Me.lblRazonS.AutoSize = True
        Me.lblRazonS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonS.ForeColor = System.Drawing.Color.Black
        Me.lblRazonS.Location = New System.Drawing.Point(9, 28)
        Me.lblRazonS.Name = "lblRazonS"
        Me.lblRazonS.Size = New System.Drawing.Size(77, 12)
        Me.lblRazonS.TabIndex = 2
        Me.lblRazonS.Text = "Razón Social"
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(938, 199)
        Me.Controls.Add(Me.grbComprobante)
        Me.Name = "frmProveedores"
        Me.Text = "Ingreso y modificación de proveedores"
        Me.grbComprobante.ResumeLayout(False)
        Me.grbComprobante.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkExterior As System.Windows.Forms.CheckBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblNroBeneficiario As System.Windows.Forms.Label
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtNroBeneficiario As System.Windows.Forms.TextBox
    Public WithEvents grbComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lblErrorCotizacion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRazonS As System.Windows.Forms.Label
    Friend WithEvents txtcodProv As System.Windows.Forms.TextBox
End Class
