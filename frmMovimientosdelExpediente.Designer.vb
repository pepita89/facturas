<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientosdelExpediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientosdelExpediente))
        Me.grbEstadoExpediente = New System.Windows.Forms.GroupBox
        Me.cboEtapa = New System.Windows.Forms.ComboBox
        Me.lblEtapa = New System.Windows.Forms.Label
        Me.mtxtArea = New Facturas.mTxtAutoComplete
        Me.cmdAgregarComp = New System.Windows.Forms.Button
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtFechaN = New System.Windows.Forms.DateTimePicker
        Me.lblFechaN = New System.Windows.Forms.Label
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.lblEstado = New System.Windows.Forms.Label
        Me.grbEstadoExpediente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEstadoExpediente
        '
        Me.grbEstadoExpediente.BackColor = System.Drawing.Color.DarkGray
        Me.grbEstadoExpediente.Controls.Add(Me.cboEtapa)
        Me.grbEstadoExpediente.Controls.Add(Me.lblEtapa)
        Me.grbEstadoExpediente.Controls.Add(Me.mtxtArea)
        Me.grbEstadoExpediente.Controls.Add(Me.cmdAgregarComp)
        Me.grbEstadoExpediente.Controls.Add(Me.lblArea)
        Me.grbEstadoExpediente.Controls.Add(Me.txtObservacion)
        Me.grbEstadoExpediente.Controls.Add(Me.Label6)
        Me.grbEstadoExpediente.Controls.Add(Me.dtFechaN)
        Me.grbEstadoExpediente.Controls.Add(Me.lblFechaN)
        Me.grbEstadoExpediente.Controls.Add(Me.cboEstado)
        Me.grbEstadoExpediente.Controls.Add(Me.lblEstado)
        Me.grbEstadoExpediente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEstadoExpediente.ForeColor = System.Drawing.Color.Black
        Me.grbEstadoExpediente.Location = New System.Drawing.Point(3, 3)
        Me.grbEstadoExpediente.Name = "grbEstadoExpediente"
        Me.grbEstadoExpediente.Size = New System.Drawing.Size(437, 395)
        Me.grbEstadoExpediente.TabIndex = 7
        Me.grbEstadoExpediente.TabStop = False
        Me.grbEstadoExpediente.Text = "Cambiar el estado del expediente"
        '
        'cboEtapa
        '
        Me.cboEtapa.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboEtapa.FormattingEnabled = True
        Me.cboEtapa.Location = New System.Drawing.Point(26, 354)
        Me.cboEtapa.Name = "cboEtapa"
        Me.cboEtapa.Size = New System.Drawing.Size(203, 21)
        Me.cboEtapa.TabIndex = 35
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.ForeColor = System.Drawing.Color.Black
        Me.lblEtapa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEtapa.Location = New System.Drawing.Point(23, 338)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(37, 12)
        Me.lblEtapa.TabIndex = 36
        Me.lblEtapa.Text = "Etapa"
        '
        'mtxtArea
        '
        Me.mtxtArea.AutoSize = True
        Me.mtxtArea.BackColor = System.Drawing.Color.Transparent
        Me.mtxtArea.CodigoAnterior = Nothing
        Me.mtxtArea.Location = New System.Drawing.Point(26, 315)
        Me.mtxtArea.Name = "mtxtArea"
        Me.mtxtArea.Size = New System.Drawing.Size(401, 20)
        Me.mtxtArea.TabIndex = 34
        Me.mtxtArea.TipoOperacion = Nothing
        '
        'cmdAgregarComp
        '
        Me.cmdAgregarComp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarComp.ForeColor = System.Drawing.Color.Black
        Me.cmdAgregarComp.Image = CType(resources.GetObject("cmdAgregarComp.Image"), System.Drawing.Image)
        Me.cmdAgregarComp.Location = New System.Drawing.Point(387, 341)
        Me.cmdAgregarComp.Name = "cmdAgregarComp"
        Me.cmdAgregarComp.Size = New System.Drawing.Size(40, 45)
        Me.cmdAgregarComp.TabIndex = 5
        Me.cmdAgregarComp.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArea.Location = New System.Drawing.Point(23, 297)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(105, 12)
        Me.lblArea.TabIndex = 33
        Me.lblArea.Text = "Área Interviniente"
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtObservacion.Location = New System.Drawing.Point(26, 87)
        Me.txtObservacion.MaxLength = 1000
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(401, 207)
        Me.txtObservacion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(23, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 12)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Aclaración o Motivo"
        '
        'dtFechaN
        '
        Me.dtFechaN.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtFechaN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaN.Location = New System.Drawing.Point(220, 38)
        Me.dtFechaN.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaN.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtFechaN.Name = "dtFechaN"
        Me.dtFechaN.Size = New System.Drawing.Size(126, 22)
        Me.dtFechaN.TabIndex = 2
        '
        'lblFechaN
        '
        Me.lblFechaN.AutoSize = True
        Me.lblFechaN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaN.ForeColor = System.Drawing.Color.Black
        Me.lblFechaN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFechaN.Location = New System.Drawing.Point(217, 23)
        Me.lblFechaN.Name = "lblFechaN"
        Me.lblFechaN.Size = New System.Drawing.Size(43, 12)
        Me.lblFechaN.TabIndex = 29
        Me.lblFechaN.Text = "Fecha "
        '
        'cboEstado
        '
        Me.cboEstado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(26, 39)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(172, 21)
        Me.cboEstado.TabIndex = 1
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstado.Location = New System.Drawing.Point(23, 23)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 12)
        Me.lblEstado.TabIndex = 9
        Me.lblEstado.Text = "Estado"
        '
        'frmMovimientosdelExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(454, 406)
        Me.Controls.Add(Me.grbEstadoExpediente)
        Me.Name = "frmMovimientosdelExpediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grbEstadoExpediente.ResumeLayout(False)
        Me.grbEstadoExpediente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents grbEstadoExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFechaN As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaN As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarComp As System.Windows.Forms.Button
    Friend WithEvents mtxtArea As Facturas.mTxtAutoComplete
    Friend WithEvents cboEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
End Class
