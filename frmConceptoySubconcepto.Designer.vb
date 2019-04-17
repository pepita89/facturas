<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptoySubconcepto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptoySubconcepto))
        Me.gbxObservacion = New System.Windows.Forms.GroupBox
        Me.lblErrorConceptos = New System.Windows.Forms.Label
        Me.txtcdPadre = New System.Windows.Forms.TextBox
        Me.pnlConceptoF = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdAgregarComp = New System.Windows.Forms.Button
        Me.lblAddConcepto = New System.Windows.Forms.Label
        Me.txtObservacionesConceptos = New System.Windows.Forms.TextBox
        Me.btnNuevoConcepto = New System.Windows.Forms.Button
        Me.cboConcepto = New System.Windows.Forms.ComboBox
        Me.lblSeleccionarConcepto = New System.Windows.Forms.Label
        Me.cboSubConcepto = New System.Windows.Forms.ComboBox
        Me.lblSubconcepto = New System.Windows.Forms.Label
        Me.lblObservacionConceptos = New System.Windows.Forms.Label
        Me.PnlConcepSubConcep = New System.Windows.Forms.Panel
        Me.cboConceptoV = New System.Windows.Forms.ComboBox
        Me.txtSubConcepto = New System.Windows.Forms.TextBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.lblSubConceptoNuevio = New System.Windows.Forms.Label
        Me.lblConceptoNuevo = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.toolNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.gbxObservacion.SuspendLayout()
        Me.pnlConceptoF.SuspendLayout()
        Me.PnlConcepSubConcep.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxObservacion
        '
        Me.gbxObservacion.BackColor = System.Drawing.Color.DarkGray
        Me.gbxObservacion.Controls.Add(Me.lblErrorConceptos)
        Me.gbxObservacion.Controls.Add(Me.txtcdPadre)
        Me.gbxObservacion.Controls.Add(Me.pnlConceptoF)
        Me.gbxObservacion.Controls.Add(Me.PnlConcepSubConcep)
        Me.gbxObservacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxObservacion.ForeColor = System.Drawing.Color.Black
        Me.gbxObservacion.Location = New System.Drawing.Point(3, 24)
        Me.gbxObservacion.Name = "gbxObservacion"
        Me.gbxObservacion.Size = New System.Drawing.Size(558, 286)
        Me.gbxObservacion.TabIndex = 20
        Me.gbxObservacion.TabStop = False
        Me.gbxObservacion.Text = "Ingresar conceptos facturados"
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
        'txtcdPadre
        '
        Me.txtcdPadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcdPadre.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtcdPadre.Location = New System.Drawing.Point(959, 100)
        Me.txtcdPadre.Name = "txtcdPadre"
        Me.txtcdPadre.Size = New System.Drawing.Size(0, 22)
        Me.txtcdPadre.TabIndex = 37
        Me.txtcdPadre.Visible = False
        Me.txtcdPadre.WordWrap = False
        '
        'pnlConceptoF
        '
        Me.pnlConceptoF.BackColor = System.Drawing.Color.DarkGray
        Me.pnlConceptoF.Controls.Add(Me.Label2)
        Me.pnlConceptoF.Controls.Add(Me.Button1)
        Me.pnlConceptoF.Controls.Add(Me.cmdAgregarComp)
        Me.pnlConceptoF.Controls.Add(Me.lblAddConcepto)
        Me.pnlConceptoF.Controls.Add(Me.txtObservacionesConceptos)
        Me.pnlConceptoF.Controls.Add(Me.btnNuevoConcepto)
        Me.pnlConceptoF.Controls.Add(Me.cboConcepto)
        Me.pnlConceptoF.Controls.Add(Me.lblSeleccionarConcepto)
        Me.pnlConceptoF.Controls.Add(Me.cboSubConcepto)
        Me.pnlConceptoF.Controls.Add(Me.lblSubconcepto)
        Me.pnlConceptoF.Controls.Add(Me.lblObservacionConceptos)
        Me.pnlConceptoF.ForeColor = System.Drawing.Color.SteelBlue
        Me.pnlConceptoF.Location = New System.Drawing.Point(9, 21)
        Me.pnlConceptoF.Name = "pnlConceptoF"
        Me.pnlConceptoF.Size = New System.Drawing.Size(539, 190)
        Me.pnlConceptoF.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(400, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 12)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "(Nuevo Subconcepto)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(377, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdAgregarComp
        '
        Me.cmdAgregarComp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarComp.ForeColor = System.Drawing.Color.Black
        Me.cmdAgregarComp.Image = CType(resources.GetObject("cmdAgregarComp.Image"), System.Drawing.Image)
        Me.cmdAgregarComp.Location = New System.Drawing.Point(485, 122)
        Me.cmdAgregarComp.Name = "cmdAgregarComp"
        Me.cmdAgregarComp.Size = New System.Drawing.Size(40, 45)
        Me.cmdAgregarComp.TabIndex = 6
        Me.cmdAgregarComp.UseVisualStyleBackColor = True
        '
        'lblAddConcepto
        '
        Me.lblAddConcepto.AutoSize = True
        Me.lblAddConcepto.BackColor = System.Drawing.Color.DarkGray
        Me.lblAddConcepto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddConcepto.ForeColor = System.Drawing.Color.Black
        Me.lblAddConcepto.Location = New System.Drawing.Point(400, 25)
        Me.lblAddConcepto.Name = "lblAddConcepto"
        Me.lblAddConcepto.Size = New System.Drawing.Size(105, 12)
        Me.lblAddConcepto.TabIndex = 70
        Me.lblAddConcepto.Text = "(Nuevo Concepto)"
        '
        'txtObservacionesConceptos
        '
        Me.txtObservacionesConceptos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacionesConceptos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtObservacionesConceptos.Location = New System.Drawing.Point(12, 99)
        Me.txtObservacionesConceptos.Multiline = True
        Me.txtObservacionesConceptos.Name = "txtObservacionesConceptos"
        Me.txtObservacionesConceptos.Size = New System.Drawing.Size(464, 68)
        Me.txtObservacionesConceptos.TabIndex = 3
        '
        'btnNuevoConcepto
        '
        Me.btnNuevoConcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoConcepto.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoConcepto.Image = CType(resources.GetObject("btnNuevoConcepto.Image"), System.Drawing.Image)
        Me.btnNuevoConcepto.Location = New System.Drawing.Point(377, 19)
        Me.btnNuevoConcepto.Name = "btnNuevoConcepto"
        Me.btnNuevoConcepto.Size = New System.Drawing.Size(22, 21)
        Me.btnNuevoConcepto.TabIndex = 4
        Me.btnNuevoConcepto.UseVisualStyleBackColor = True
        '
        'cboConcepto
        '
        Me.cboConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboConcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.Location = New System.Drawing.Point(12, 19)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(318, 21)
        Me.cboConcepto.TabIndex = 1
        '
        'lblSeleccionarConcepto
        '
        Me.lblSeleccionarConcepto.AutoSize = True
        Me.lblSeleccionarConcepto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarConcepto.ForeColor = System.Drawing.Color.Black
        Me.lblSeleccionarConcepto.Location = New System.Drawing.Point(9, 3)
        Me.lblSeleccionarConcepto.Name = "lblSeleccionarConcepto"
        Me.lblSeleccionarConcepto.Size = New System.Drawing.Size(128, 12)
        Me.lblSeleccionarConcepto.TabIndex = 32
        Me.lblSeleccionarConcepto.Text = "Seleccionar concepto"
        '
        'cboSubConcepto
        '
        Me.cboSubConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSubConcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboSubConcepto.FormattingEnabled = True
        Me.cboSubConcepto.Location = New System.Drawing.Point(12, 59)
        Me.cboSubConcepto.Name = "cboSubConcepto"
        Me.cboSubConcepto.Size = New System.Drawing.Size(318, 21)
        Me.cboSubConcepto.TabIndex = 2
        '
        'lblSubconcepto
        '
        Me.lblSubconcepto.AutoSize = True
        Me.lblSubconcepto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubconcepto.ForeColor = System.Drawing.Color.Black
        Me.lblSubconcepto.Location = New System.Drawing.Point(9, 39)
        Me.lblSubconcepto.Name = "lblSubconcepto"
        Me.lblSubconcepto.Size = New System.Drawing.Size(148, 12)
        Me.lblSubconcepto.TabIndex = 33
        Me.lblSubconcepto.Text = "Seleccionar subconcepto"
        '
        'lblObservacionConceptos
        '
        Me.lblObservacionConceptos.AutoSize = True
        Me.lblObservacionConceptos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacionConceptos.ForeColor = System.Drawing.Color.Black
        Me.lblObservacionConceptos.Location = New System.Drawing.Point(9, 83)
        Me.lblObservacionConceptos.Name = "lblObservacionConceptos"
        Me.lblObservacionConceptos.Size = New System.Drawing.Size(139, 12)
        Me.lblObservacionConceptos.TabIndex = 34
        Me.lblObservacionConceptos.Text = "Ingresar Observaciones"
        '
        'PnlConcepSubConcep
        '
        Me.PnlConcepSubConcep.Controls.Add(Me.cboConceptoV)
        Me.PnlConcepSubConcep.Controls.Add(Me.txtSubConcepto)
        Me.PnlConcepSubConcep.Controls.Add(Me.txtConcepto)
        Me.PnlConcepSubConcep.Controls.Add(Me.lblSubConceptoNuevio)
        Me.PnlConcepSubConcep.Controls.Add(Me.lblConceptoNuevo)
        Me.PnlConcepSubConcep.Controls.Add(Me.ToolStrip2)
        Me.PnlConcepSubConcep.Location = New System.Drawing.Point(9, 21)
        Me.PnlConcepSubConcep.Name = "PnlConcepSubConcep"
        Me.PnlConcepSubConcep.Size = New System.Drawing.Size(539, 201)
        Me.PnlConcepSubConcep.TabIndex = 72
        Me.PnlConcepSubConcep.Visible = False
        '
        'cboConceptoV
        '
        Me.cboConceptoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboConceptoV.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboConceptoV.FormattingEnabled = True
        Me.cboConceptoV.Location = New System.Drawing.Point(9, 57)
        Me.cboConceptoV.Name = "cboConceptoV"
        Me.cboConceptoV.Size = New System.Drawing.Size(318, 21)
        Me.cboConceptoV.TabIndex = 1
        Me.cboConceptoV.Visible = False
        '
        'txtSubConcepto
        '
        Me.txtSubConcepto.Location = New System.Drawing.Point(9, 95)
        Me.txtSubConcepto.MaxLength = 30
        Me.txtSubConcepto.Name = "txtSubConcepto"
        Me.txtSubConcepto.Size = New System.Drawing.Size(321, 20)
        Me.txtSubConcepto.TabIndex = 80
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(9, 56)
        Me.txtConcepto.MaxLength = 30
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(321, 20)
        Me.txtConcepto.TabIndex = 79
        '
        'lblSubConceptoNuevio
        '
        Me.lblSubConceptoNuevio.AutoSize = True
        Me.lblSubConceptoNuevio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubConceptoNuevio.ForeColor = System.Drawing.Color.Black
        Me.lblSubConceptoNuevio.Location = New System.Drawing.Point(6, 79)
        Me.lblSubConceptoNuevio.Name = "lblSubConceptoNuevio"
        Me.lblSubConceptoNuevio.Size = New System.Drawing.Size(119, 13)
        Me.lblSubConceptoNuevio.TabIndex = 78
        Me.lblSubConceptoNuevio.Text = "Ingresar subconcepto"
        '
        'lblConceptoNuevo
        '
        Me.lblConceptoNuevo.AutoSize = True
        Me.lblConceptoNuevo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConceptoNuevo.ForeColor = System.Drawing.Color.Black
        Me.lblConceptoNuevo.Location = New System.Drawing.Point(6, 39)
        Me.lblConceptoNuevo.Name = "lblConceptoNuevo"
        Me.lblConceptoNuevo.Size = New System.Drawing.Size(100, 13)
        Me.lblConceptoNuevo.TabIndex = 77
        Me.lblConceptoNuevo.Text = "Ingresar concepto"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNuevo, Me.ToolGuardar, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(539, 25)
        Me.ToolStrip2.TabIndex = 74
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'toolNuevo
        '
        Me.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.toolNuevo.Image = CType(resources.GetObject("toolNuevo.Image"), System.Drawing.Image)
        Me.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNuevo.Name = "toolNuevo"
        Me.toolNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolNuevo.Size = New System.Drawing.Size(23, 22)
        Me.toolNuevo.Text = "Ingresar Nuevo Concepto"
        '
        'ToolGuardar
        '
        Me.ToolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolGuardar.Image = CType(resources.GetObject("ToolGuardar.Image"), System.Drawing.Image)
        Me.ToolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGuardar.Name = "ToolGuardar"
        Me.ToolGuardar.Size = New System.Drawing.Size(23, 22)
        Me.ToolGuardar.Text = "Agregar Nuevo Concepto"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Volver"
        '
        'frmConceptoySubconcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(563, 310)
        Me.Controls.Add(Me.gbxObservacion)
        Me.Name = "frmConceptoySubconcepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.gbxObservacion.ResumeLayout(False)
        Me.gbxObservacion.PerformLayout()
        Me.pnlConceptoF.ResumeLayout(False)
        Me.pnlConceptoF.PerformLayout()
        Me.PnlConcepSubConcep.ResumeLayout(False)
        Me.PnlConcepSubConcep.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxObservacion As System.Windows.Forms.GroupBox
    Friend WithEvents cboSubConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents lblErrorConceptos As System.Windows.Forms.Label
    Friend WithEvents txtcdPadre As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacionesConceptos As System.Windows.Forms.TextBox
    Friend WithEvents lblObservacionConceptos As System.Windows.Forms.Label
    Friend WithEvents lblSubconcepto As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionarConcepto As System.Windows.Forms.Label
    Friend WithEvents cboConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregarComp As System.Windows.Forms.Button
    Friend WithEvents btnNuevoConcepto As System.Windows.Forms.Button
    Friend WithEvents lblAddConcepto As System.Windows.Forms.Label
    Friend WithEvents PnlConcepSubConcep As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlConceptoF As System.Windows.Forms.Panel
    Friend WithEvents lblSubConceptoNuevio As System.Windows.Forms.Label
    Friend WithEvents lblConceptoNuevo As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtSubConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboConceptoV As System.Windows.Forms.ComboBox
End Class
