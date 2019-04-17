Imports clsFacturas
Imports System.Text.RegularExpressions
Public Class frmIngresodeComprobantesOtros
    Public codArea As Integer
    Public _cdTipoPer As Integer
    Public _cdExpediente As Integer
    Public _cdComprobante As Integer
    Private Arr As New ArrayList
    Public ocls As New clsComprobantes
    Public oclsD As New clsExpedientes
    Public intExp As Integer
    Public _codproveedor As Integer
    Dim oclsCot As New clsCotizaciones
    Dim dtFechaAlta As DateTime
    Public _codUsuario As Integer
    Public _cdClaseC As Integer
    Public _cdTipoC As Integer
    Public _checked As Integer
    Public _intComprobante As Integer
    Private ArrAreas As New ArrayList
    Public strArea As String = ""
    Public cierre As Integer
    Public _cdPerio As Integer
    Public _EsExterior As Integer
    Public _dsNroExp As String
    Public _dsProveedor As String
    Public _dsCuit As String
    Public _dsNroBen As String
    Public ArrProveedor As ArrayList
    Public vlFS As Integer
    Public vlDolar As Integer
    Public vlEuro As Integer

#Region "METODOS"
    Public Property EsExterior()
        Get
            Return _EsExterior
        End Get
        Set(ByVal value)
            _EsExterior = value
        End Set
    End Property
    Public Sub NumConFrac(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "," And Not CajaTexto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub VaciarDatos()
        Me.txtExpedienteExistente.Visible = False
        ArrProveedor = New ArrayList()
        Me.txtcdProveedor.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtNroBeneficiario.Text = ""
        Me.txtCuit.Text = ""
        Me.chkExterior.Checked = False
        ArrAreas = New ArrayList
        Me.mtxtArea.Text = ""
        codArea = 0
        Me.txtObservacion.Text = False
        cmdEliminar.Visible = False
        Me.dtFechac.Value = Today
        Me.txtNroComprobante.Text = ""
        Me._cdComprobante = 0
        Me.txtExpedienteExistente.Text = ""
        Me.chkExcluir.Checked = False
        Me.txtGrupo.Text = ""
        txtImporteC.Text = "0,00"
        Me.txtCotizacion.Text = "0,0000"
        Me.txtGrupo.Text = ""
        CargarClaseComprobante(-2)
        CargarTipoPeriodicidad(-2)
        CargarAreasNombre()
        Me.cboTipoPeriodicidad.SelectedValue = 1
        Me.cboPeriodicidad.Text = "Sin Periodicidad"
        Me.cmdPeriodicidad.Visible = True
        Me.dtFechaDesde.Visible = False
        Me.dtFechaHasta.Visible = False
        Me.lblFechaDesde.Visible = False
        Me.lblFechaHasta.Visible = False
        Me.txtImporteC.Enabled = True
        Me.cboMoneda.Enabled = True
        Me.txtCotizacion.Enabled = True
        Me.cboTipoPeriodicidad.Enabled = True
        Me.txtObservacion.Text = ""
        Me.cboPeriodicidad.Enabled = True
        Me.dtFechaDesde.Enabled = True
        Me.dtFechaHasta.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.mtxtArea.Enabled = True
        Me.txtNroComprobante.Enabled = True
        Me.dtFechac.Enabled = True
        Me.cboClaseComprobante.Enabled = True
        Me.cmdModificar.Enabled = False
        Me.cboTipoComp.Enabled = True
        If (Me._checked = 0) Then
            Me.chkExcluir.Checked = False
            Me.txtdesglosar.Visible = False
            Me.Label8.Visible = False
        Else
            Me.chkExcluir.Checked = True
            Me.txtdesglosar.Visible = True
            Me.Label8.Visible = True
        End If
        Me.cboTipoPeriodicidad.SelectedValue = 1
        Me.cboPeriodicidad.Text = "Sin Periodicidad"
    End Sub
    Public Sub Modificacion()

        Dim ds As New DataSet
        If (Me._cdClaseC = 5) Then

            Me.cboClaseComprobante.SelectedValue = Me._cdClaseC
            Me.cboClaseComprobante.Text = "MI"
        Else
            Me.CargarClaseComprobante(-2)
            Me.cboClaseComprobante.SelectedValue = Me._cdClaseC
        End If

        If (Me._cdTipoC = 0) Then
            Me.cboTipoComp.SelectedValue = Me._cdTipoC
            Me.cboTipoComp.Text = "MIG"
        Else
            Me.CargarTipoComprobante(Me.txtGrupo.Text)
            Me.cboTipoComp.SelectedValue = Me._cdTipoC
        End If
        ds = WS.VALIDA_EXPEDIENTESCOMPROBANTES_(Me._cdComprobante, Me._checked)
        If (ds.Tables(0).Rows().Count > 0) Then
            Me.chkExcluir.Enabled = False
            Me.txtImporteC.Text = ds.Tables(0).Rows(0).Item("vlImporte")
            Me.txtImporteC.Enabled = False
            Me.cboMoneda.SelectedValue = ds.Tables(0).Rows(0).Item("cdMoneda")
            Me.cboMoneda.Enabled = False
            If (ds.Tables(0).Rows(0).Item("cdMoneda") = 2) Then
                vlDolar = ds.Tables(0).Rows(0).Item("vlCotizacion").ToString()
            End If
            If (ds.Tables(0).Rows(0).Item("cdMoneda") = 3) Then
                vlEuro = ds.Tables(0).Rows(0).Item("vlCotizacion").ToString()
            End If
            If (ds.Tables(0).Rows(0).Item("cdMoneda") = 4) Then
                vlFS = ds.Tables(0).Rows(0).Item("vlCotizacion").ToString()
            End If

            If (ds.Tables(0).Rows(0).Item("vlCotizacion").ToString() <> Nothing) Then
                Me.txtCotizacion.Text = ds.Tables(0).Rows(0).Item("vlCotizacion").ToString()
            End If
            Me.txtCotizacion.Enabled = False

                Me.cboTipoPeriodicidad.Enabled = False

                Me.cboPeriodicidad.Enabled = False

                Me.txtObservacion.Text = ds.Tables(0).Rows(0).Item("sObservacion").ToString()
                Me.txtObservacion.Enabled = False
                Me.dtFechaAlta = ds.Tables(0).Rows(0).Item("dtFechaAlta")
                _codUsuario = ds.Tables(0).Rows(0).Item("cdUsuarioAlta")
                Me.codArea = ds.Tables(0).Rows(0).Item("cdAreaRequirente")
                Me.mtxtArea.Text = ds.Tables(0).Rows(0).Item("dsArea")
                Me.mtxtArea.Enabled = False
                Me.cmdAgregarComp.Enabled = False
                Me.cmdModificar.Enabled = True
                Me.txtNroComprobante.Enabled = False
                Me.dtFechac.Enabled = False
                Me.dtFechac.Value = ds.Tables(0).Rows(0).Item("dtFecha")

                Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario")
                Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento")
                Me.ToolStrip2.Enabled = False

                If (ds.Tables(0).Rows(0).Item("cdEsExterior") = 0) Then
                    Me.chkExterior.Checked = False
                Else
                    Me.chkExterior.Checked = True
                End If

                Me.txtNroBeneficiario.Enabled = False
                Me.txtCuit.Enabled = False
                Me.chkExterior.Enabled = False
                Me.cboClaseComprobante.Enabled = False
                Me.cboTipoComp.Enabled = False
                Me.txtRazonSocial.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.txtCuit.Enabled = False

                If (ds.Tables(0).Rows(0).Item("cdProveedor") = _codproveedor) Then
                    Me.chkProveedorExp.Checked = True
                Else
                    Me.chkProveedorExp.Checked = False
                End If


                Me.txtcdProveedor.Text = ds.Tables(0).Rows(0).Item("cdProveedor")
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()


                '  Me.CargarTipoPeriodicidad(cboTipoPeriodicidad.SelectedValue)
                _cdTipoPer = ds.Tables(0).Rows(0).Item("cdTipoPeriodicidad").ToString()
                If (_cdTipoPer = 1) Then
                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                End If
                If (_cdTipoPer = 3) Then
                    '  Me.cboTipoPeriodicidad.SelectedValue = 3
                    cboTipoPeriodicidad.Text = "Mensual"
                End If
                If (_cdTipoPer = 4) Then
                    Me.cboTipoPeriodicidad.Text = "Quincenal"
                End If

                If (_cdTipoPer = 14) Then
                    CargarTipoPeriodicidad(-1)
                    Me.cboTipoPeriodicidad.Text = "Migracion"
                ElseIf (_cdTipoPer = 0) Then
                    CargarTipoPeriodicidad(-2)
                End If
                If (_cdTipoPer = 1) Then
                    If (ds.Tables(0).Rows(0).Item("dtFechaDesde").ToString() <> Nothing And ds.Tables(0).Rows(0).Item("dtFechaHasta").ToString() <> Nothing) Then

                        Me.dtFechaDesde.Value = ds.Tables(0).Rows(0).Item("dtFechaDesde")
                        Me.dtFechaDesde.Enabled = False
                        Me.dtFechaHasta.Value = ds.Tables(0).Rows(0).Item("dtFechaHasta")
                        Me.dtFechaHasta.Enabled = False
                        Me.dtFechaDesde.Visible = True
                        Me.dtFechaHasta.Visible = True
                        Me.lblFechaDesde.Visible = True
                        Me.lblFechaHasta.Visible = True
                    Else
                        Me.dtFechaDesde.Visible = False
                        Me.dtFechaHasta.Visible = False
                        Me.lblFechaDesde.Visible = False
                        Me.lblFechaHasta.Visible = False
                        Me.cmdPeriodicidad.Visible = True
                    End If
                ElseIf (cboTipoPeriodicidad.SelectedValue <> 1) Then
                    If (ds.Tables(0).Rows(0).Item("dtFechaDesde").ToString() <> Nothing And ds.Tables(0).Rows(0).Item("dtFechaHasta").ToString() <> Nothing) Then
                        Me.dtFechaDesde.Value = ds.Tables(0).Rows(0).Item("dtFechaDesde")
                        Me.dtFechaDesde.Enabled = False
                        Me.dtFechaHasta.Value = ds.Tables(0).Rows(0).Item("dtFechaHasta")
                        Me.dtFechaHasta.Enabled = False
                    Else
                        Me.dtFechaDesde.Visible = False
                        Me.dtFechaHasta.Visible = False
                        Me.lblFechaDesde.Visible = False
                        Me.lblFechaHasta.Visible = False
                        Me.cmdPeriodicidad.Visible = True
                    End If
                End If
                Me.cboPeriodicidad.Text = ds.Tables(0).Rows(0).Item("dsPeriodicidad").ToString()
                CargarAreasNombre()

                If (Me._checked = 0) Then
                    Me.chkExcluir.Checked = False
                    Me.txtdesglosar.Visible = False
                    Me.txtExpedienteExistente.Visible = False
                    '     Me.txtdesglosar.Visible = True
                    Me.Label8.Visible = False
                Else
                    Me.chkExcluir.Checked = True

                    If (Me.chkExcluir.Checked = True) Then
                        Dim d As New DataSet
                        d = WS.TRAER_EXPEDIENTE_DESGLOSADO(Me._cdComprobante)
                        For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                            If (d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then
                                '   If (d.Tables(0).Rows(i).Item("dsNroExpediente") <> _dsNroExp) Then
                                Me.txtExpedienteExistente.Visible = True
                                Me.txtdesglosar.Visible = False
                                Me.Label8.Visible = True
                                Me.txtExpedienteExistente.Text = d.Tables(0).Rows(i).Item("dsNroExpediente")
                                Me.txtcdExpediente.Text = d.Tables(0).Rows(i).Item("cdExpediente")
                                '   End If
                            End If
                        Next
                    End If
                End If
            End If
    End Sub
    Public Sub CargarCotizacionMoneda()
        Try


            Dim arrCot As New List(Of clsCotizaciones)
            If (Me.cboMoneda.SelectedValue <> 1) Then
                oclsCot._cdMoneda = cboMoneda.SelectedValue
            Else
                Exit Sub
            End If
            oclsCot._dtFecha = Me.dtFechac.Value
            oclsCot._vlCotizacion = Me.txtCotizacion.Text
            arrCot.Add(oclsCot)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarMonedas(ByVal cdmoneda As Integer)
        Try
            Dim ds As New DataSet()
            ds = WS.Obtener_Monedas(cdmoneda)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.cboMoneda.DisplayMember = "dsMoneda"
                Me.cboMoneda.ValueMember = "cdMoneda"
                Me.cboMoneda.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarTipoPeriodicidad(ByVal intTipo As Integer)
        Try
            Dim ds As New DataTable()
            ds = WS.Obtener_TipoPeriodicidad(intTipo).Tables(0)
            If ds.Rows.Count > 0 Then
                Me.cboTipoPeriodicidad.DisplayMember = "dsTipoPeriodicidad"
                Me.cboTipoPeriodicidad.ValueMember = "cdTipoPeriodicidad"
                Me.cboTipoPeriodicidad.DataSource = ds
            End If
            'If (ds.Tables(0).Rows(0).Item("cdTipoPeriodicidad") = 1) Then
            '    Me.dtFechaDesde.Visible = False
            '    Me.dtFechaHasta.Visible = False
            '    Me.lblFechaDesde.Visible = False
            '    Me.lblFechaHasta.Visible = False
            '    Me.cmdPeriodicidad.Visible = True

            'Else
            '    Me.cmdPeriodicidad.Visible = False
            'End If
        Catch ex As Exception

        End Try
    End Sub
    Sub CargarClaseComprobante(ByVal cdComp As Integer)
        Try
            Dim i As Integer
            Dim ds As New DataSet()
            ' If ( _TipoExpediente = 0) Then
            ds = WS.Obtener_ClaseComprobantes(cdComp)
            Dim ocls As New clsFacturas.clsProveedores
            If ds.Tables(0).Rows.Count > 0 Then
                Me.cboClaseComprobante.DisplayMember = "dsClaseComprobante"
                Me.cboClaseComprobante.ValueMember = "cdClaseComprobante"
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim obj As New clsFacturas.clsProveedores
                    Me.txtGrupo.Text = ds.Tables(0).Rows(i).Item("cdGrupo")
                Next
                Me.cboClaseComprobante.DataSource = ds.Tables(0)
            End If
            '  End If

            'If ( _TipoExpediente = 1) Then
            '    ds = WS.Obtener_ClaseComprobantes(cdComp)
            '    Dim ocls As New clsFacturas.clsProveedores
            '    If ds.Tables(0).Rows.Count > 0 Then
            '        Me.cboClaseComprobante.DisplayMember = "dsClaseComprobante"
            '        Me.cboClaseComprobante.ValueMember = "cdClaseComprobante"
            '        For i = 0 To ds.Tables(0).Rows.Count - 1
            '            Dim obj As New clsFacturas.clsProveedores
            '            Me.txtGrupo.Text = ds.Tables(0).Rows(i).Item("cdGrupo")
            '        Next
            '        Me.cboClaseComprobante.DataSource = ds.Tables(0)
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarAreasNombre()
        'Me.txtUnidadC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ' Me.txtUnidadC.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim ds As System.Data.DataSet
        Dim i As Integer
        mtxtArea.TextBox.AutoCompleteCustomSource.Clear()
        ArrAreas.Clear()
        ds = WS.Obtener_Areas(-1, "")
        If Not IsNothing(ds.Tables(0)) Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim ocls As New clsAreas
                ocls.cdArea = ds.Tables(0).Rows(i).Item("cdArea")
                ocls.dsArea = ds.Tables(0).Rows(i).Item("dsArea")
                mtxtArea.TextBox.AutoCompleteCustomSource.Add(ocls.dsArea)
                ArrAreas.Add(ocls)
                strArea = Me.mtxtArea.Text
            Next i
        End If
    End Sub
    Public Sub INICIO()
        If (_TipoExpediente = 0) Then
            VaciarDatos()
            Me.chkProveedorExp.Checked = True
            Me.txtcdProveedor.Text = _codproveedor
            Me.txtRazonSocial.Text = _dsProveedor
            Me.txtRazonSocial.Enabled = False
        End If

        If (_TipoExpediente = 1) Then
            cmdEliminar.Visible = False
            Me.chkProveedorExp.Enabled = False

            Modificacion()

        End If
        'Eliminar
        If (_TipoExpediente = 2) Then

            Modificacion()
            Me.cmdModificar.Enabled = False
            Me.cmdAgregarComp.Enabled = False
            Me.chkProveedorExp.Enabled = False
            cmdEliminar.Visible = True
        End If
    End Sub
    Public Sub CargarcodArea(ByVal txtArea As String)
        Dim ds As System.Data.DataSet
        Dim i As Integer
        ds = WS.Obtener_Areas(-1, txtArea)
        If (ds.Tables(0).Rows().Count > 0) Then
            Me.codArea = ds.Tables(0).Rows(i).Item("cdArea")
        Else
            Me.codArea = 0
        End If
    End Sub
    Sub CargarPeriodicidad_PorTipo(ByVal cdTipo As Integer, ByVal modo As Integer)
        Try
            If (_TipoExpediente = 0) Then

                If (Me.cboTipoPeriodicidad.Text = "MIGRACION") Then
                    Me.txtPeriodicidad.Visible = True
                    Me.txtPeriodicidad.Enabled = True
                    Me.cmdPeriodicidad.Visible = True
                    Me.dtFechaHasta.Visible = False
                    Me.dtFechaDesde.Visible = False
                    Me.lblFechaDesde.Visible = False
                    Me.lblFechaHasta.Visible = False
                    Me.cmdPeriodicidad.Visible = False
                    btnDesactivar.Visible = False
                End If

                Dim i As Integer
                Dim ds As New DataSet()
                ds = WS.Obtener_Periodicidad(cdTipo)
                If ds.Tables(0).Rows.Count > 0 Then
                    If (Me.cboTipoPeriodicidad.Text <> "Sin Periodicidad") Then
                        Me.cboPeriodicidad.DisplayMember = "dsPeriodicidad"

                        For i = 0 To ds.Tables(0).Rows.Count - 1
                            If (modo = 1) Then
                                If (Me.cboPeriodicidad.Text = ds.Tables(0).Rows(i).Item("dsPeriodicidad")) Then
                                    Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                    ' Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                    Me.dtFechaHasta.Visible = False
                                    Me.dtFechaDesde.Visible = False
                                    Me.lblFechaDesde.Visible = False
                                    Me.lblFechaHasta.Visible = False
                                    Me.cmdPeriodicidad.Visible = False
                                    btnDesactivar.Visible = False

                                End If
                            Else
                                Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                Me.dtFechaHasta.Visible = False
                                Me.dtFechaDesde.Visible = False
                                Me.lblFechaDesde.Visible = False
                                Me.lblFechaHasta.Visible = False
                                Me.cmdPeriodicidad.Visible = False
                                btnDesactivar.Visible = False
                            End If
                        Next

                    Else
                        Me.cboPeriodicidad.DisplayMember = "dsPeriodicidad"
                        Me.cboPeriodicidad.DataSource = ds.Tables(0)
                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesde.Visible = False
                        Me.lblFechaHasta.Visible = False
                        Me.cmdPeriodicidad.Visible = True
                        btnDesactivar.Visible = False
                    End If
                End If
            Else

                Dim i As Integer
                Dim ds As New DataSet()
                ds = WS.Obtener_Periodicidad(cdTipo)
                If (Me.cboTipoPeriodicidad.Text = "MIGRACION") Then
                    Me.txtPeriodicidad.Visible = True
                    Me.txtPeriodicidad.Enabled = True
                    Me.cmdPeriodicidad.Visible = True
                    Me.dtFechaHasta.Visible = False
                    Me.dtFechaDesde.Visible = False
                    Me.lblFechaDesde.Visible = False
                    Me.lblFechaHasta.Visible = False
                    Me.cmdPeriodicidad.Visible = False
                    btnDesactivar.Visible = False
                End If

                If ds.Tables(0).Rows.Count > 0 Then

                    If (Me.cboTipoPeriodicidad.Text <> "Sin Periodicidad") Then
                        Me.cmdPeriodicidad.Visible = False
                        Me.cboPeriodicidad.DisplayMember = "dsPeriodicidad"
                        For i = 0 To ds.Tables(0).Rows.Count - 1
                            If (modo = 1) Then
                                If (Me.cboPeriodicidad.Text = ds.Tables(0).Rows(i).Item("dsPeriodicidad")) Then
                                    ' Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                    Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                End If
                            Else
                                Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                            End If

                        Next

                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesde.Visible = False
                        Me.lblFechaHasta.Visible = False
                        Me.cmdPeriodicidad.Visible = False
                        btnDesactivar.Visible = False

                    Else
                        Me.cmdPeriodicidad.Visible = True
                        Me.cboPeriodicidad.DisplayMember = "dsPeriodicidad"
                        Me.cboPeriodicidad.DataSource = ds.Tables(0)
                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesde.Visible = False
                        Me.lblFechaHasta.Visible = False
                        Me.cmdPeriodicidad.Visible = True
                        btnDesactivar.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarTipoComprobante(ByVal cdGrupo As Integer)
        Try
            Dim ds As New DataSet()
            ds = WS.Obtener_TipoComprobantes(cdGrupo)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.cboTipoComp.DisplayMember = "dsTipoComprobante"
                Me.cboTipoComp.ValueMember = "cdTipoComprobante"
                Me.cboTipoComp.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarDatos()
        Try

            CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)


            If (Me.cboTipoPeriodicidad.Text = "Sin Periodicidad") Then
                ' Me.cboTipoPeriodicidad.SelectedValue = 1
                _cdTipoPer = 1
            End If
            If (cboTipoPeriodicidad.Text = "Mensual") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 3
                _cdTipoPer = 3
            End If
            If (Me.cboTipoPeriodicidad.Text = "Quincenal") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 4
                _cdTipoPer = 4
            End If
            If (Me.cboTipoPeriodicidad.Text = "Migración") Then
                ' Me.cboTipoPeriodicidad.SelectedValue = 1
                _cdTipoPer = 14
            End If
            If (_cdTipoPer = 0) Then
                Me.CargarPeriodicidad_PorTipo(_cdTipoPer, 0)
            End If

            Dim arr As New List(Of clsComprobantes)
            If (_cdComprobante <> 0) Then
                ocls.cdComprobante = _cdComprobante
            End If
            ocls.intExp = intExp
            If (Me.dtFechaDesde.Checked = True) Then
                ocls.dtFechaDesde = Me.dtFechaDesde.Value
            End If
            If (Me.dtFechaHasta.Checked = True) Then
                ocls.dtFechaHasta = Me.dtFechaHasta.Value
            End If
            ocls.cdTipoPeriodicidad = Me._cdTipoPer
            If (Me.cboClaseComprobante.SelectedValue <> Nothing) Then
                ocls.cdClaseComprobante = cboClaseComprobante.SelectedValue
            Else
                ocls.cdClaseComprobante = Me._cdClaseC
            End If
            ocls.cdMoneda = Me.cboMoneda.SelectedValue
            ocls.cdProveedor = Me.txtcdProveedor.Text
            ocls.cdTipoComprobante = Me.cboTipoComp.SelectedValue
            ocls.dsNroComprobante = Me.txtNroComprobante.Text ' Decimal.Parse(dr("cdPresentacion").ToString())
            ocls.dsPeriodicidad = Me.cboPeriodicidad.Text ' Decimal.Parse(dr("vlSubTotal").ToString())
            ocls.dtFecha = Me.dtFechac.Value
            ocls.dtFechaAlta = Date.Today()
            ocls.sObservacion = Me.txtObservacion.Text
            txtCotizacion.Text = FormatNumber(txtCotizacion.Text, 4)
            ocls.vlCotizacion = txtCotizacion.Text
            txtImporteC.Text = FormatNumber(txtImporteC.Text, 2)
            ocls.vlImporte = txtImporteC.Text
            ocls.cdAreaRequirente = Me.codArea

            If (chkExcluir.Checked = True) Then
                ocls.cdDesglose = 1
            Else

                ocls.cdDesglose = 0
            End If
            ocls.ArraC = arr
            arr.Add(ocls)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarDatosDesglose(ByVal val As Integer)
        Try
            Arr = New ArrayList
            Dim arr1 As New List(Of clsExpedientes)
            If (_cdComprobante <> 0) Then
                oclsD.cdComprobante = _cdComprobante
            End If
            If (val = 0) Then
                oclsD.cdExpediente = txtcdExpediente.Text
                oclsD.cdDesglosado = 0
            Else
                oclsD.cdExpediente = intExp
                oclsD.cdDesglosado = 1
            End If
            oclsD.ArraS = arr1
            arr1.Add(oclsD)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarDatosCotizacionMoneda()
        Try
            Dim arrCot As New List(Of clsCotizaciones)

            If (Me.cboMoneda.SelectedValue <> 1) Then
                oclsCot._cdMoneda = cboMoneda.SelectedValue
            Else
                Exit Sub
            End If
            oclsCot._dtFecha = Me.dtFechac.Value
            oclsCot._vlCotizacion = Me.txtCotizacion.Text
            arrCot.Add(oclsCot)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCotizaciones(ByVal cdmoneda As Integer)
        Try
            If (Me.cboMoneda.SelectedText = "Pesos") Then
                Me.txtCotizacion.Text = "0,000"
            End If
            If (Me.cboMoneda.SelectedText = "Dolar") Then
                Me.txtCotizacion.Text = vlDolar
            End If
            If (Me.cboMoneda.SelectedText = "Euro") Then
                Me.txtCotizacion.Text = vlEuro

            End If
            If (Me.cboMoneda.SelectedText = "Francos Suizos") Then
                Me.txtCotizacion.Text = vlFS

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub ValidarCotizacion(ByVal cdmoneda As Integer, ByVal pdtFecha As DateTime)
        Try

            If (Me.cboMoneda.SelectedText = "Pesos") Then
                Me.txtCotizacion.Text = "0,000"
            End If
            If (Me.cboMoneda.SelectedText = "Dolar") Then
                Me.txtCotizacion.Text = vlDolar
            End If
            If (Me.cboMoneda.SelectedText = "Euro") Then
                Me.txtCotizacion.Text = vlEuro

            End If
            If (Me.cboMoneda.SelectedText = "Francos Suizos") Then
                Me.txtCotizacion.Text = vlFS

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCotizaciones(ByVal cdmoneda As Integer, ByVal intE As Integer)
        Try
            If (Me.cboMoneda.SelectedText <> "Pesos") Then
                Me.txtCotizacion.Text = "0,000"

            End If
            If (Me.cboMoneda.SelectedText = "Dolar") Then
                Me.txtCotizacion.Text = vlDolar
            End If
            If (Me.cboMoneda.SelectedText = "Euro") Then
                Me.txtCotizacion.Text = vlEuro
            End If
            If (Me.cboMoneda.SelectedText = "Francos Suizos") Then
                Me.txtCotizacion.Text = vlFS
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function validarcampos(ByVal Val As Integer) As Boolean

        If (Val = 1) Then
            If (Me.txtNroComprobante.Text = "") Then
                MessageBox.Show("Debe ingresar el Nro. de Comprobante")
                Return False
                Exit Function
            End If
            If (Me.dtFechaHasta.Value >= dtFechaDesde.Value) Then
            Else
                MessageBox.Show("No debe superar la fecha hasta  de la periodicidad")
                Return False
                Exit Function
            End If
            If (Me.dtFechac.Value <= Date.Now) Then
            Else
                MessageBox.Show("No debe superar la fecha de emision del comprobante")
                Return False
                Exit Function
            End If
            If (Me.cboClaseComprobante.SelectedValue = -1) Then
                MessageBox.Show("Debe ingresar la clase del comprobante")
                Return False
                Exit Function
            End If
            If (Me.cboTipoComp.SelectedValue = -1) Then
                MessageBox.Show("Debe ingresar el tipo del comprobante")
                Return False
                Exit Function
            End If
            If (Me.txtImporteC.Text = "0,00") Then
                MessageBox.Show("El importe debe ser mayor a 0")
                Return False
                Exit Function
            End If
            If (_TipoExpediente = 0) Then
                If (Me.chkExcluir.Checked = True) Then
                    If (Me.txtdesglosar.Text = "") Then
                        MessageBox.Show("Debe ingresar el Nro del expediente del desglose")
                        Return False
                        Exit Function


                    End If
                End If


                If (Me.chkExcluir.Checked = True) Then
                    If (Me.txtcdExpediente.Text = "") Then
                        MessageBox.Show("Debe ingresar un Nro de expediente valido")
                        Return False
                        Exit Function
                    End If
                    If (Me._dsNroExp = Me.txtdesglosar.Text) Then
                        MessageBox.Show("No se puede desglosar al expediente actual")
                        Return False
                        Exit Function
                    End If
                End If
            End If
            If (_TipoExpediente = 1) Then
                If (Me.chkExcluir.Checked = True) Then
                    If (Me.txtExpedienteExistente.Text = "") Then
                        If (Me.txtdesglosar.Text = "") Then
                            MessageBox.Show("Debe ingresar el Nro del expediente del desglose")
                            Return False
                            Exit Function
                        End If
                    End If
                End If
                If (Me.chkExcluir.Checked = True) Then
                    If (Me.txtcdExpediente.Text = "") Then
                        MessageBox.Show("Debe ingresar un Nro de expediente valido")
                        Return False
                        Exit Function
                    End If
                End If
                If (Me.chkExcluir.Checked = True) Then
                    If (Me._dsNroExp = Me.txtdesglosar.Text) Then
                        MessageBox.Show("No se puede desglosar al expediente actual")
                        Return False
                        Exit Function
                    End If
                End If
            End If

                If (Me.mtxtArea.Text = "") Then
                MessageBox.Show("Debe ingresar la unidad requirente")
                Return False
                Exit Function
            End If
            If (Me.codArea = 0) Then
                MessageBox.Show("Debe ingresar una unidad requirente valida")
                Return False
                Exit Function
            End If
            If (Me.txtRazonSocial.Text = "") Then
                Me.txtcdProveedor.Text = ""
            End If
            If (Me.txtcdProveedor.Text = "") Then
                Me.lblErrorProv.Visible = True
                MessageBox.Show("Debe ingresar el proveedor del comprobante")
                Return False
                Exit Function
            Else
                Me.lblErrorProv.Visible = False
            End If



            Dim strComp As String = Me.AutoFormatoComprobante(Me.cboClaseComprobante.Text, Me.txtNroComprobante.Text)
            Dim str As String = ValidarFormatoComprobante(Me.cboClaseComprobante.Text, strComp)
            If str <> "" Then
                MessageBox.Show(str)
                txtNroComprobante.Focus()
                Return False
                Exit Function
            Else
                txtNroComprobante.Text = strComp
            End If
            Return True
        End If
        If (Val = 2) Then
            If (Me.txtNroComprobante.Text = "") Then
                MessageBox.Show("Debe ingresar el Nro. de Comprobante")
                Return False
                Exit Function
            End If
            If (Me.dtFechaHasta.Value >= dtFechaDesde.Value) Then
            Else
                MessageBox.Show("No debe superar la fecha hasta  de la periodicidad")
                Return False
                Exit Function
            End If
            If (Me.dtFechac.Value <= Date.Now) Then
            Else
                MessageBox.Show("No debe superar la fecha de emision del comprobante")
                Return False
                Exit Function
            End If



            If (Me.cboClaseComprobante.SelectedValue = -1) Then
                MessageBox.Show("Debe ingresar la clase del comprobante")
                Return False
                Exit Function
            End If
            If (Me.cboTipoComp.SelectedValue = -1) Then
                MessageBox.Show("Debe ingresar el tipo del comprobante")
                Return False
                Exit Function
            End If
            If (Me.txtImporteC.Text = "0,00") Then
                MessageBox.Show("El importe debe ser mayor a 0")
                Return False
                Exit Function
            End If
          

            If (Me.mtxtArea.Text = "") Then
                MessageBox.Show("Debe ingresar la unidad requirente")
                Return False
                Exit Function
            End If
            If (Me.codArea = 0) Then
                MessageBox.Show("Debe ingresar una unidad requirente valida")
                Return False
                Exit Function
            End If

            Dim strComp As String = Me.AutoFormatoComprobante(Me.cboClaseComprobante.Text, Me.txtNroComprobante.Text)
            Dim str As String = ValidarFormatoComprobante(Me.cboClaseComprobante.Text, strComp)
            If str <> "" Then
                MessageBox.Show(str)
                txtNroComprobante.Focus()
                Return False
                Exit Function
            Else
                txtNroComprobante.Text = strComp
            End If
            If (Me.txtRazonSocial.Text = "") Then
                Me.txtcdProveedor.Text = ""
            End If
            If (Me.txtcdProveedor.Text = "") Then
                Me.lblErrorProv.Visible = True
                MessageBox.Show("Debe ingresar el proveedor del comprobante")
                Return False
                Exit Function
            Else
                Me.lblErrorProv.Visible = False
            End If


            Return True
        End If
    End Function
    Public Function vlComprobante() As Boolean
        Dim ds As New DataSet
        ds = WS.ValidarComprobantes_BycdProv(Me.txtNroComprobante.Text, Me.txtcdProveedor.Text, Me.cboClaseComprobante.SelectedValue, Me.cboTipoComp.SelectedValue)
        If (_TipoExpediente = 1) Then
            If (ds.Tables(0).Rows().Count > 0) Then
                Me.txtImporteC.Text = ds.Tables(0).Rows(0).Item("vlImporte")
                Me.cboMoneda.SelectedValue = ds.Tables(0).Rows(0).Item("cdMoneda")
                Me.txtCotizacion.Text = ds.Tables(0).Rows(0).Item("vlCotizacion")
                Me._cdTipoPer = ds.Tables(0).Rows(0).Item("cdTipoPeriodicidad")
                '  Me.cboTipoPeriodicidad.SelectedValue = ds.Tables(0).Rows(0).Item("cdTipoPeriodicidad")
                If (_cdTipoPer = 1) Then
                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                End If
                If (_cdTipoPer = 3) Then
                    '  Me.cboTipoPeriodicidad.SelectedValue = 3
                    cboTipoPeriodicidad.Text = "Mensual"
                End If
                If (_cdTipoPer = 4) Then
                    Me.cboTipoPeriodicidad.Text = "Quincenal"
                End If
                If (_cdTipoPer = 14) Then
                    CargarTipoPeriodicidad(-1)
                    Me.cboTipoPeriodicidad.Text = "Migracion"

                End If
                Me.cboPeriodicidad.Text = ds.Tables(0).Rows(0).Item("dsPeriodicidad")
                If (ds.Tables(0).Rows(0).Item("dtFechaDesde").ToString() <> Nothing And ds.Tables(0).Rows(0).Item("dtFechaHasta").ToString() <> Nothing) Then
                    Me.dtFechaDesde.Value = ds.Tables(0).Rows(0).Item("dtFechaDesde")
                    Me.dtFechaHasta.Value = ds.Tables(0).Rows(0).Item("dtFechaHasta")
                End If
                Me.txtObservacion.Text = ds.Tables(0).Rows(0).Item("sObservacion").ToString()
                Me.dtFechaAlta = ds.Tables(0).Rows(0).Item("dtFechaAlta")
                _codUsuario = ds.Tables(0).Rows(0).Item("cdUsuarioAlta")
                Me.codArea = ds.Tables(0).Rows(0).Item("cdAreaRequirente")
            End If
        End If
        If (_TipoExpediente = 0) Then
            If (ds.Tables(0).Rows().Count > 0) Then
                MessageBox.Show("El comprobante que desea ingresar ya existe")
            End If
        End If
    End Function
    Public Function ValidarFormatoComprobante(ByVal dsClaseComprobante As String, ByVal strNroComp As String) As String
        ValidarFormatoComprobante = ""
        If strNroComp <> " " Then
            Select Case dsClaseComprobante
                Case "FC"
                    'If EsExterior <> 0 Then
                    Dim rx As New Regex("[0-9]{1,4}(-)")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999- , Ejemplo : 0001-" & vbCrLf

                    End If
                    '   End If
                Case "TK"
                    'If EsExterior <> 0 Then
                    Dim rx As New Regex("[0-9]{1,4}(-)")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ' ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999- , Ejemplo : 0001-" & vbCrLf
                    End If
                    '  End If
                Case "ND"
                    Dim rx As New Regex("[0-9]{1,4}(-)")
                    If Not (rx.IsMatch(strNroComp)) Then
                        '  ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999- , Ejemplo : 0001-" & vbCrLf
                    End If
                Case "NC"
                    If EsExterior <> 0 Then
                        Dim rx As New Regex("[0-9]{1,4}(-)")
                        If Not (rx.IsMatch(strNroComp)) Then
                            ' ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf
                            ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999- , Ejemplo : 0001-" & vbCrLf
                        End If
                    End If
                Case "RE"
                    Dim rx As New Regex("[0-9]{1,8}")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ' ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 99999999, Ejemplo: 456" & vbCrLf
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999- , Ejemplo : 0001-" & vbCrLf
                    End If
                Case "LE"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If


                Case "DE"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf

                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "AA"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "OC"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "ME"
                Case "CC"

                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{1,2}(-C.)[0-9]{1,5}")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El formato debe ser [Nro Caja Chica]/[Año]-C.[Nro. Orden del Comprobante], Ejemplo: 24/09-C.3" & vbCrLf
                    End If



            End Select

        End If






        Return ValidarFormatoComprobante

    End Function
    Public Function AutoFormatoComprobante(ByVal dsClaseComprobante As String, ByVal strNroComp As String) As String
        AutoFormatoComprobante = strNroComp
        Select Case dsClaseComprobante

            Case "FC"
                'Dim intNroLetras As Integer
                'intNroLetras = Me.txtNroComprobante.Text.Length
                'Dim Intl As Integer
                'For Intl = 0 To Me.txtNroComprobante.Text.Length - 1
                '    If (Intl = 4) Then


                '    End If
                'Next


                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 1 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-"
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-" & arrnrocomp(1)
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                End If

            Case "TK"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 1 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-"
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-" & arrnrocomp(1)
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                End If
            Case "ND"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 1 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-"
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-" & arrnrocomp(1)
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                End If
            Case "NC"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 1 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-"
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0")) & "-" & arrnrocomp(1)
                        ' AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 8, arrnrocomp(0), arrnrocomp(0).PadLeft(8, "0"))
                        'AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                    End If
                End If
            Case "RE"

            Case "LE"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If
            Case "DE"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If
            Case "AA"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)


                        End If

                    End If
                End If
            Case "OC"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If


            Case "ME"
            Case "CC"
                AutoFormatoComprobante = strNroComp.ToUpper()

        End Select
        Return AutoFormatoComprobante
    End Function

    Sub CargarcodProv(ByVal txtProve As String, ByVal txtcuit As String)
        If txtProve.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                Me.txtRazonSocial.Text = Prov.dsProveedor
                Me.txtcdProveedor.Text = Prov.cdProveedor
              
            End If
        End If
    End Sub
    Function AutoCompletarProveedor(ByVal dsNombre As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsProveedor.ToUpper() = dsNombre.ToUpper() Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = obj.dsCuit
                Me.txtCuit.Text = obj.dsCuit
                oProveedor.cdProveedor = obj.cdProveedor
                Me.txtcdProveedor.Text = obj.cdProveedor

                oProveedor.dsNroBeneficiario = obj.dsNroBeneficiario
                Me.txtNroBeneficiario.Text = obj.dsNroBeneficiario
                oProveedor.cdEsExterior = obj.cdEsExterior
            End If
        Next
        Return oProveedor
    End Function

    'Function AutoCompletarProveedor(ByVal dsNombre As String) As clsProveedor

    '    Dim oProveedor As New clsProveedor
    '    For Each obj As clsProveedor In ArrProveedor
    '        If obj.dsProveedor.ToUpper() = dsNombre.ToUpper() Then
    '            oProveedor.cdProveedor = obj.cdProveedor
    '            Me.txtcdProveedor.Text = obj.cdProveedor
    '        End If
    '    Next
    '    Return oProveedor
    'End Function
    'Sub CompletarCuit(ByVal txtProve As String)
    '    If txtProve.Length <> 0 Then
    '        Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
    '        If Prov.dsProveedor <> "" Then
    '            Me.txtRazonSocial.Text = Prov.dsProveedor
    '            Me.txtcdProveedor.Text = Prov.cdProveedor
    '        End If
    '    End If
    'End Sub


    Sub CompletarCuit(ByVal txtProve As String, ByVal txtcuit As String)
        If txtProve.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                Me.txtRazonSocial.Text = Prov.dsProveedor
                Me.txtCuit.Text = Prov.dsCuit
                If (Prov.cdEsExterior = 0) Then
                    Me.chkExterior.Checked = False
                Else
                    Me.chkExterior.Checked = True
                End If
                Me.txtcdProveedor.Text = Prov.cdProveedor
                Me.txtNroBeneficiario.Text = Prov.dsNroBeneficiario

                ToolStripModificar.Enabled = True
                Me.ToolStripNuevo.Enabled = True
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.txtRazonSocial.Enabled = False

            End If
        End If
    End Sub

    Public Function verifica_cuit(ByVal CUIT As String) As String
        Dim coeficiente(0 To 10) As Integer
        Dim i, sumador, veri_nro, resultado As Integer
        Dim cuit_rearmado As String
        coeficiente(1) = 5
        coeficiente(2) = 4
        coeficiente(3) = 3
        coeficiente(4) = 2
        coeficiente(5) = 7
        coeficiente(6) = 6
        coeficiente(7) = 5
        coeficiente(8) = 4
        coeficiente(9) = 3
        coeficiente(10) = 2
        CUIT = Trim(CUIT)
        cuit_rearmado = ""
        For i = 1 To Len(CUIT)      'separo cualquier caracter que no tenga que ver con numeros
            If Asc(Mid(CUIT, i, 1)) >= 48 And Asc(Mid(CUIT, i, 1)) <= 57 Then
                cuit_rearmado = cuit_rearmado & Mid(CUIT, i, 1)
            End If
        Next
        cuit_rearmado = Trim(cuit_rearmado)
        If Len(cuit_rearmado) <> 11 Then            ' si to estan todos los digitos

            MsgBox("El CUIT no tiene el formato válido", vbDefaultButton1, "Error en el C.U.I.T.")
        Else
            sumador = 0
            veri_nro = Val(Mid(cuit_rearmado, 11, 1)) 'tomo el digito verificador
            For i = 1 To 10
                sumador = sumador + Val(Mid(cuit_rearmado, i, 1)) * coeficiente(i)
                'separo cada digito y lo multiplico por el coeficiente
            Next
            resultado = sumador Mod 11
            resultado = 11 - resultado  'saco el digito verificador
            If (resultado = 11) Then resultado = 0
            veri_nro = Val(veri_nro)
            If veri_nro <> resultado Then
                MsgBox("No coincide el dígito verificador. " & Str(veri_nro), vbDefaultButton1, "Error en el C.U.I.T.")
            Else
                cuit_rearmado = Mid(cuit_rearmado, 1, 2) & "-" & Mid(cuit_rearmado, 3, 8) & "-" & Mid(cuit_rearmado, 11, 1)
            End If
        End If
        verifica_cuit = cuit_rearmado
    End Function
    Sub AutoCompletarProveedores_Organismo(ByVal Exterior As Integer)
        Try

            ArrProveedor = New ArrayList()

            Me.txtRazonSocial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource
            Me.txtRazonSocial.AutoCompleteCustomSource.Clear()

            Dim i As Integer
            Dim DatRubro As System.Data.DataSet
            DatRubro = WS.Obtener_Proveedores_Organismos(Exterior, 0)
            For i = 0 To DatRubro.Tables(0).Rows.Count - 1
                Dim obj As New clsProveedor
                obj.cdProveedor = DatRubro.Tables(0).Rows(i).Item("cdProveedor").ToString()
                Me.txtcdProveedor.Text = DatRubro.Tables(0).Rows(i).Item("cdProveedor").ToString()
                obj.dsProveedor = DatRubro.Tables(0).Rows(i).Item("dsProveedor").ToString()
                obj.dsCuit = DatRubro.Tables(0).Rows(i).Item("dsCuit").ToString()
                obj.cdEsExterior = DatRubro.Tables(0).Rows(i).Item("cdEsExterior").ToString()
                obj.dsNroBeneficiario = DatRubro.Tables(0).Rows(i).Item("dsNroBeneficiario").ToString()
                Me.txtRazonSocial.AutoCompleteCustomSource.Add(obj.dsProveedor)
                ArrProveedor.Add(obj)
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub cargarcuit(ByVal dscuit As String)
        Try

            If (Me.chkExterior.Checked = True) Then
            Else
                verifica_cuit(txtCuit.Text)
            End If
            Dim ds As New DataSet
            ds = WS.Obtener_Proveedores_Bycuit(Me.txtCuit.Text, "")
            Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
            Me.txtcdProveedor.Text = ds.Tables(0).Rows(0).Item("cdProveedor")
            Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario")
            If (ds.Tables(0).Rows(0).Item("cdEsExterior") = 0) Then
                Me.chkExterior.Checked = False
            Else
                Me.chkExterior.Checked = True
            End If
            txtRazonSocial.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
            Me.txtCuit.Enabled = False
            ToolStripModificar.Enabled = True
            Me.ToolStripNuevo.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region
    Private Sub frmIngresodeComprobantesOtros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblCotizacion.Visible = True
            Me.txtCotizacion.Text = "0,0000"
            Me.txtImporteC.Text = "0,00"
            If (Me.cboMoneda.SelectedValue = 1) Then
                Me.txtCotizacion.Visible = False
                Me.lblCotizacion.Visible = False
            End If
            Me.cboTipoPeriodicidad.SelectedValue = 1
            Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
            CargarMonedas(-1)
            Me.CargarClaseComprobante(-2)
            CargarTipoPeriodicidad(-2)
            CargarProveedores(-1)
            INICIO()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboPeriodicidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodicidad.Leave, cboPeriodicidad.SelectedIndexChanged
        Try
            If (_cdTipoPer <> 0 Or Me.cboTipoPeriodicidad.SelectedValue <> 1) Then
                Me.CargarPeriodicidad_PorTipo(cboTipoPeriodicidad.SelectedValue, 1)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cboTipoPeriodicidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPeriodicidad.Leave, cboTipoPeriodicidad.SelectedIndexChanged
        Try
            If (Me.cboTipoPeriodicidad.SelectedValue <> Nothing) Then
                Me.CargarPeriodicidad_PorTipo(cboTipoPeriodicidad.SelectedValue, 0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboClaseComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClaseComprobante.SelectedIndexChanged
        Try
            If (Me.cboClaseComprobante.SelectedValue <> -1 Or _cdClaseC <> 0) Then
                Dim ds As DataSet
                ds = WS.Obtener_ClaseComprobantes(Me.cboClaseComprobante.SelectedValue)

                Dim i As Integer
                If ds.Tables(0).Rows.Count > 0 Then
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        Me.txtGrupo.Text = ds.Tables(0).Rows(i).Item("cdGrupo")
                    Next
                End If
                If (Me.txtGrupo.Text <> "") Then
                    Me.CargarTipoComprobante(Me.txtGrupo.Text)
                    '  Me.CargarTipoComprobante(1)
                End If
                If (Me.txtNroComprobante.Text <> "" And Me.cboClaseComprobante.SelectedValue <> -1 And Me.cboTipoComp.SelectedValue <> -1) Then
                    vlComprobante()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdPeriodicidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeriodicidad.Click
        Me.cmdPeriodicidad.Visible = False
        btnDesactivar.Visible = True
        Me.dtFechaDesde.Visible = True
        Me.dtFechaHasta.Visible = True
        Me.lblFechaDesde.Visible = True
        Me.lblFechaHasta.Visible = True

    End Sub
    Private Sub btnDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivar.Click
        btnDesactivar.Visible = False
        Me.cmdPeriodicidad.Visible = True
        Me.dtFechaDesde.Visible = False
        Me.dtFechaHasta.Visible = False
        Me.lblFechaDesde.Visible = False
        Me.lblFechaHasta.Visible = False
    End Sub
    Private Sub txtImporteC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporteC.Leave
        If (Me.txtImporteC.Text = "") Then
            Me.txtImporteC.Text = "0,00"
        End If
        If (IsNumeric(Me.txtImporteC.Text)) Then
            txtImporteC.Text = FormatNumber(txtImporteC.Text, 2)
        Else
            Me.txtImporteC.Text = "0,00"
        End If
    End Sub
    Private Sub cmdAgregarComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarComp.Click
        Try
            If (_TipoExpediente = 0) Then
                'Insert Comprobante/ Desglose Sin Expediente Relacionado
                If (Me.chkExcluir.Checked = True And Me.txtExpedienteExistente.Text = "" And Me.txtcdExpediente.Text = "") Then
                    If (validarcampos(2) = True) Then
                        CargarDatos()
                        CargarCotizacionMoneda()
                        Dim dsC As New DataSet
                        Dim ds As New DataSet
                        If (Me.cboMoneda.SelectedValue <> 1) Then
                            ds = WS.CotizacionMoneda_IU(oclsCot.ToXmlc)
                        End If

                        dsC = WS.Insert_DESGLOSECOMPROBANTES_SIN_EXPEDIENTES(ocls.XmlDesglose_SinExpediente, 0)
                        If (dsC.Tables(0).Rows().Count > 0) Then
                            Me._cdComprobante = dsC.Tables(0).Rows(0).Item("COLUMN1")
                            CargarDatosDesglose(1)
                            Dim dsD As New DataSet()
                            dsD = WS.INSERT_DESGLOSE(oclsD.XmlDesglose)
                        End If
                        MessageBox.Show("EL comprobante se ha ingresado con exito")
                        cierre = 1
                        _TipoExpediente = 4
                        VaciarDatos()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                    'Insert Comprobante/ Desglose con Expediente Relacionado
                Else
                    If (validarcampos(1) = True) Then
                        CargarDatos()
                        CargarCotizacionMoneda()
                        Dim dsC As New DataSet
                        Dim ds As New DataSet
                        If (Me.cboMoneda.SelectedValue <> 1) Then
                            ds = WS.CotizacionMoneda_IU(oclsCot.ToXmlc)
                        End If
                        dsC = WS.Insert_COMPROBANTES_EC(ocls.ToXml, 0)
                        If (dsC.Tables(0).Rows().Count > 0) Then
                            Me._cdComprobante = dsC.Tables(0).Rows(0).Item("COLUMN1")
                            MessageBox.Show("EL comprobante se ha ingresado con exito")
                            If (_checked = 1) Then

                                Dim dsD As New DataSet()
                                CargarDatosDesglose(0)
                                dsD = WS.INSERT_DESGLOSE(oclsD.XmlDesglose)
                            End If
                            cierre = 1
                            _TipoExpediente = 4
                            VaciarDatos()
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If

            'Modificacion de Comprobantes / Desglose con Expediente Relacionado
            If (_TipoExpediente = 1) Then
                'Modificacion Sin Expediente relacionado
                If (Me.chkExcluir.Checked = True And Me.txtExpedienteExistente.Text = "" And Me.txtcdExpediente.Text = "") Then
                    If (validarcampos(2) = True) Then
                        CargarDatos()
                        CargarCotizacionMoneda()
                        Dim dsC As New DataSet
                        Dim ds As New DataSet
                        If (Me.cboMoneda.SelectedValue <> 1) Then
                            ds = WS.CotizacionMoneda_IU(oclsCot.ToXmlc)
                        End If
                        dsC = WS.Update_C(ocls.ToXml, 1)
                        cierre = 1
                        VaciarDatos()
                        Me.DialogResult = Windows.Forms.DialogResult.Abort
                        Me.Close()
                    End If
                    'Modificacion Con Expediente relacionado
                Else

                    If (validarcampos(1) = True) Then
                        CargarDatos()
                        CargarCotizacionMoneda()
                        Dim dsC As New DataSet
                        Dim ds As New DataSet
                        If (Me.cboMoneda.SelectedValue <> 1) Then
                            ds = WS.CotizacionMoneda_IU(oclsCot.ToXmlc)
                            '   Me._cdComprobante = dsC.Tables(0).Rows(0).Item("COLUMN1")
                        End If
                        dsC = WS.Update_C(ocls.ToXml, 1)
                        MessageBox.Show("EL comprobante se ha modificado con exito")
                        If (_checked = 1) Then
                            If (Me.txtExpedienteExistente.Text = "") Then
                                Dim dsD As New DataSet()
                                CargarDatosDesglose(0)
                                dsD = WS.INSERT_DESGLOSE(oclsD.XmlDesglose)
                            End If
                        End If
                        cierre = 1
                        VaciarDatos()
                        Me.DialogResult = Windows.Forms.DialogResult.Abort
                        Me.Close()
                    End If
                End If
            End If
            ' If (Me.ckSinExpediente.Checked = True) Then

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboMonedaC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
        Try
            If (Me.cboMoneda.SelectedValue = 1) Then
                Me.txtCotizacion.Visible = False
                Me.lblCotizacion.Visible = False
            Else
                Me.txtCotizacion.Visible = True
                Me.lblCotizacion.Visible = True
                CargarCotizaciones(Me.cboMoneda.SelectedValue())
                ValidarCotizacion(Me.cboMoneda.SelectedValue(), Me.dtFechac.Value)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboTipoComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoComp.SelectedIndexChanged
        Try
            If (Me.txtNroComprobante.Text <> "" And Me.cboClaseComprobante.SelectedValue <> -1 And Me.cboTipoComp.SelectedValue <> -1) Then
                vlComprobante()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtNroComprobante_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroComprobante.Leave
        If (Me.txtNroComprobante.Text <> "" And Me.cboClaseComprobante.SelectedValue <> -1 And Me.cboTipoComp.SelectedValue <> -1) Then
            If (_cdComprobante = 0) Then
                Me.EsExterior = 0
            End If
            Dim strComp As String = Me.AutoFormatoComprobante(Me.cboClaseComprobante.Text, Me.txtNroComprobante.Text)
            Dim str As String = ValidarFormatoComprobante(Me.cboClaseComprobante.Text, strComp)
            If str <> "" Then
                MessageBox.Show(str)
                txtNroComprobante.Text = ""
                txtNroComprobante.Focus()
            Else
                txtNroComprobante.Text = strComp
            End If
        End If
    End Sub
    Private Sub chkExcluir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExcluir.CheckedChanged
        If (Me.chkExcluir.Checked = True) Then
            _checked = 1
            Me.txtdesglosar.Visible = True

            Me.Label8.Visible = True
        Else
            _checked = 0
            Me.txtdesglosar.Visible = False
            Me.Label8.Visible = False

        End If
    End Sub
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.chkExcluir.Enabled = True
        Me.cmdAgregarComp.Enabled = True
        Me.ToolStrip2.Enabled = True
        Me.cmdModificar.Enabled = False
        Me.txtImporteC.Enabled = True
        Me.cboMoneda.Enabled = True
        Me.txtCotizacion.Enabled = True
        Me.cboTipoPeriodicidad.Enabled = True
        Me.cboPeriodicidad.Enabled = True
        Me.dtFechaDesde.Enabled = True
        Me.dtFechaHasta.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.mtxtArea.Enabled = True
        Me.txtNroComprobante.Enabled = True
        Me.dtFechac.Enabled = True
        Me.cboClaseComprobante.Enabled = True
        Me.cboTipoComp.Enabled = True
        Me.txtRazonSocial.Enabled = True
        Me.chkProveedorExp.Enabled = True
        Me.txtNroBeneficiario.Enabled = True
        Me.txtCuit.Enabled = True
        Me.chkExterior.Enabled = True
        Me.txtRazonSocial.Enabled = True
        Me.txtNroBeneficiario.Enabled = True
        Me.txtCuit.Enabled = True
        _TipoExpediente = 1



    End Sub
    Private Sub grbComprobante_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grbComprobante.Enter

    End Sub
    Private Sub txtCotizacion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCotizacion.Leave
        If (txtCotizacion.Text = "") Then
            txtCotizacion.Text = "0,0000"
        End If
        If (IsNumeric(Me.txtCotizacion.Text)) Then
            txtCotizacion.Text = FormatNumber(txtCotizacion.Text, 4)
        Else
            txtCotizacion.Text = "0,0000"
        End If
    End Sub
    Private Sub dtFechac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub frmIngresodeComprobantesOtros_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If (cierre <> 1) Then
                Dim res As DialogResult = MsgBox("LOS DATOS DEL COMPROBANTE SE BORRARAN, ¿DESEA SALIR DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (res = Windows.Forms.DialogResult.Yes) Then
                    cierre = 0
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub mtxtArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtArea.Leave
        If (mtxtArea.Text.Length <> 0) Then
            CargarcodArea(mtxtArea.Text)
        End If
    End Sub
    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me._cdComprobante = 0
            Me.mtxtArea.Text = ""
            Me.codArea = 0
            Me.cmdModificar.Enabled = False
            Me.cmdAgregarComp.Enabled = True
            Me.dtFechac.Value = Today
            Me.txtGrupo.Text = ""
            Me.CargarMonedas(-1)
            Me.txtObservacion.Text = ""
            Me.txtdesglosar.Text = ""
            If (Me.chkExcluir.Checked = True) Then
                _checked = 1
                Me.txtdesglosar.Visible = True
                Me.Label8.Visible = True
            Else
                _checked = 0
                Me.txtdesglosar.Visible = False
                Me.Label8.Visible = False
            End If
            txtImporteC.Text = "0,00"
            Me.txtCotizacion.Text = "0,0000"
            Me.txtGrupo.Text = ""
            Me.txtNroComprobante.Text = ""
            Me.dtFechac.Value = Today
            CargarClaseComprobante(-1)
            CargarTipoPeriodicidad(-2)
            Me.cboTipoPeriodicidad.SelectedValue = 1
            Me.cboPeriodicidad.Text = "Sin Peridicidad"
            Me.cmdPeriodicidad.Visible = True
            Me.dtFechaDesde.Visible = False
            Me.dtFechaHasta.Visible = False
            Me.lblFechaDesde.Visible = False
            Me.lblFechaHasta.Visible = False
            CargarAreasNombre()
            Me.txtImporteC.Enabled = True
            Me.cboMoneda.Enabled = True
            Me.txtCotizacion.Enabled = True
            Me.cboTipoPeriodicidad.Enabled = True
            Me.cboPeriodicidad.Enabled = True
            Me.dtFechaDesde.Enabled = True
            Me.dtFechaHasta.Enabled = True
            Me.txtObservacion.Enabled = True
            Me.mtxtArea.Enabled = True
            Me.txtNroComprobante.Enabled = True
            Me.dtFechac.Enabled = True
            Me.cboClaseComprobante.Enabled = True
            Me.cboTipoComp.Enabled = True
            If (Me._checked = 0) Then
                Me.chkExcluir.Checked = False
                Me.txtdesglosar.Visible = False
                Me.Label8.Visible = False
            Else
                Me.chkExcluir.Checked = True
                Me.txtdesglosar.Visible = True
                Me.Label8.Visible = True
            End If
            Me.cboTipoPeriodicidad.SelectedValue = 1
            Me.cboPeriodicidad.Text = "Sin Peridicidad"
            _TipoExpediente = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdModificar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Leave

    End Sub
    Private Sub txtdesglosar_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesglosar.Validated
        Try
            If (txtdesglosar.Text <> "") Then
                Dim ds As New DataSet
                ds = WS.ValidarDesglose(Me.txtdesglosar.Text)
                If (ds.Tables(0).Rows().Count > 0) Then
                    Me.txtcdExpediente.Text = ds.Tables(0).Rows(0).Item("cdExpediente")
                Else
                    Me.txtcdExpediente.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            Dim ds As New DataSet
            ds = WS.ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(_cdComprobante, Me.intExp, 0)
            MessageBox.Show("El comprobante se elimino correctamente")
            cierre = 1
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtImporteC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteC.KeyPress
        NumConFrac(txtImporteC, e)
    End Sub
    Private Sub txtCotizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCotizacion.KeyPress
        NumConFrac(txtCotizacion, e)
    End Sub
    Private Sub dtFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaDesde.ValueChanged
    End Sub
    Sub CargarProveedores(ByVal Exterior As Integer)
        Try
            ArrProveedor = New ArrayList
            Me.txtRazonSocial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource
            Me.txtRazonSocial.AutoCompleteCustomSource.Clear()

            Dim i As Integer
            Dim DatRubro As System.Data.DataSet
            DatRubro = WS.Obtener_Proveedores_Organismos(Exterior, 0)
            For i = 0 To DatRubro.Tables(0).Rows.Count - 1
                Dim obj As New clsProveedor
                obj.cdProveedor = DatRubro.Tables(0).Rows(i).Item("cdProveedor").ToString()
                obj.dsProveedor = DatRubro.Tables(0).Rows(i).Item("dsProveedor").ToString()
                obj.dsCuit = DatRubro.Tables(0).Rows(i).Item("dsCuit").ToString()
                obj.cdEsExterior = DatRubro.Tables(0).Rows(i).Item("cdEsExterior").ToString()
                obj.dsNroBeneficiario = DatRubro.Tables(0).Rows(i).Item("dsNroBeneficiario").ToString()



                Me.txtRazonSocial.AutoCompleteCustomSource.Add(obj.dsProveedor)
                ArrProveedor.Add(obj)
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub txtRazonSocial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Leave
        Try
            If (Me.txtRazonSocial.Text <> "" Or Me.txtCuit.Text <> "") Then
                CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkProveedorExp_CheckedChanged(sender As Object, e As EventArgs) Handles chkProveedorExp.CheckedChanged
        If (Me.chkProveedorExp.Checked = False) Then
            Me.txtRazonSocial.Text = ""
            Me.txtcdProveedor.Text = ""
            Me.txtCuit.Text = ""
            Me.txtNroBeneficiario.Text = ""

            Me.chkExterior.Checked = False
            txtRazonSocial.Enabled = True

            Me.txtNroBeneficiario.Enabled = True
            Me.txtCuit.Enabled = True
        End If
        If (Me.chkProveedorExp.Checked = True) Then
            txtRazonSocial.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
            Me.txtCuit.Enabled = False

            Me.txtRazonSocial.Text = _dsProveedor
            Me.txtcdProveedor.Text = _codproveedor
            Me.txtNroBeneficiario.Text = _dsNroBen
            Me.txtCuit.Text = _dsCuit

            If (_EsExterior = 0) Then
                Me.chkExterior.Checked = False
            Else
                Me.chkExterior.Checked = True
            End If


        End If

    End Sub

    Private Sub txtNroBeneficiario_Leave(sender As Object, e As EventArgs) Handles txtNroBeneficiario.Leave
        Try
            If (Me.txtNroBeneficiario.Text = "" And Me.txtRazonSocial.Text = "" And Me.txtCuit.Text = "") Then
                Me.txtcdProveedor.Text = ""
            End If
            If (Me.txtRazonSocial.Text = "" And txtNroBeneficiario.Text <> "" And Me.txtCuit.Text = "") Then
                Dim ds As New DataSet
                ds = WS.Obtener_Proveedores_Bycuit("", Me.txtNroBeneficiario.Text)
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
                Me.txtcdProveedor.Text = ds.Tables(0).Rows(0).Item("cdProveedor")
                Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario")
                If (ds.Tables(0).Rows(0).Item("cdEsExterior") = 0) Then
                    Me.chkExterior.Checked = False
                Else
                    Me.chkExterior.Checked = True
                End If

                txtRazonSocial.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.txtCuit.Enabled = False
                ToolStripModificar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCuit_Leave(sender As Object, e As EventArgs) Handles txtCuit.Leave
        Try
            If (Me.txtCuit.Text = "" And Me.txtRazonSocial.Text = "" And Me.txtNroBeneficiario.Text = "") Then
                Me.txtcdProveedor.Text = ""
                Me.txtNroBeneficiario.Text = ""
                Me.chkExterior.Checked = False

            ElseIf (Me.txtRazonSocial.Text = "" And Me.txtCuit.Text <> "") Then
                cargarcuit(Me.txtCuit.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkExterior_CheckedChanged(sender As Object, e As EventArgs) Handles chkExterior.CheckedChanged
        Try
            If (Me.chkExterior.Checked = True) Then
                Me._EsExterior = 1
            Else
                Me._EsExterior = 0
            End If

            AutoCompletarProveedores_Organismo(_EsExterior)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripNuevo.Click
        Try
            Dim ofrmp As New frmProveedores
            ofrmp.cdModo = 0
            ofrmp.ShowDialog()
            If (_codProv <> 0) Then
                Dim ds As New DataSet
                ds = WS.SP_OBTENERPROVEEDOR_PORCODIGO(_codProv)
                If (ds.Tables(0).Rows().Count > 0) Then
                    Dim cdExt As Integer = 0
                    Me.txtcdProveedor.Text = _codProv
                    Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                    Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                    Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                    cdExt = ds.Tables(0).Rows(0).Item("cdEsExterior").ToString()
                    If (cdExt = 1) Then
                        Me.chkExterior.Checked = True
                    Else
                        Me.chkExterior.Checked = False
                    End If
                    Me.AutoCompletarProveedores_Organismo(-1)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripModificar_Click(sender As Object, e As EventArgs) Handles ToolStripModificar.Click
        Try
            If (Me.txtRazonSocial.Text <> "") Then
                If (txtcdProveedor.Text = 0 Or txtcdProveedor.Text <> "") Then
                    CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)
                End If
                If (txtcdProveedor.Text <> 0 Or txtcdProveedor.Text <> "") Then
                    '  Me.AutoCompletarProveedores_Organismo(-1)
                    If (Me.txtcdProveedor.Text <> 0 Or txtcdProveedor.Text <> "" Or Me.txtRazonSocial.Text <> "") Then
                        Dim ofrmp As New frmProveedores
                        ofrmp.txtcodProv.Text = txtcdProveedor.Text
                        ofrmp.txtRazonSocial.Text = Me.txtRazonSocial.Text
                        ofrmp.txtCuit.Text = Me.txtCuit.Text
                        ofrmp.txtNroBeneficiario.Text = Me.txtNroBeneficiario.Text
                        ofrmp.cdModo = 1
                        If (Me.chkExterior.Checked = True) Then
                            Me._EsExterior = 1
                        Else
                            Me._EsExterior = 0
                        End If
                        ofrmp._cdExterior = Me._EsExterior
                        ofrmp.ShowDialog()
                        Dim ds As New DataSet
                        ds = WS.SP_OBTENERPROVEEDOR_PORCODIGO(txtcdProveedor.Text)
                        If (ds.Tables(0).Rows().Count > 0) Then
                            Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                            Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                            Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                            Me._EsExterior = ds.Tables(0).Rows(0).Item("cdEsExterior").ToString()
                            Me._dsCuit = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                            Me._dsNroBen = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()

                            Me.txtRazonSocial.Enabled = False
                            Me.txtNroBeneficiario.Enabled = False
                            Me.txtCuit.Enabled = False
                            Me.chkExterior.Enabled = False
                            If (_EsExterior = 1) Then
                                Me.chkExterior.Checked = True
                            Else
                                Me.chkExterior.Checked = False
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.txtRazonSocial.Enabled = True
        Me.txtCuit.Enabled = True
        Me.txtNroBeneficiario.Enabled = True
        Me.txtRazonSocial.Text = ""
        Me.txtCuit.Text = ""
        Me.txtNroBeneficiario.Text = ""
        Me.txtcdProveedor.Text = ""
        Me.chkExterior.Enabled = True
        Me.AutoCompletarProveedores_Organismo(-1)
    End Sub
End Class