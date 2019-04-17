Imports System.Text.RegularExpressions
Imports clsFacturas
Public Class frmIngresarExpedientes
    Private ArrProveedor As New ArrayList
    Private Arr As New ArrayList
    Dim dsP As New DataSet
    Public _codproveedor As Integer
    Private _oclsE As New clsExpedientes()
    Private ocls As New clsComprobante()
    Public _cdExpediente As Integer
    Public _cdSolicitud As Integer
    Public List As New List(Of clsComprobante)
    Public bs As BindingSource
    Public str As String = ""
    Dim indice As Integer
    Public _Chk As Integer
    Public _Tipo As Integer
    Public fecha As DateTime
    Public cdDesg As Integer
    Public oclsMov As New clsSeguimientoExpedientes
    Public _cdComprobante As Integer
    Private _EsExterior As Integer
    Public dsNroRel As String
    Public bl As Boolean
    Public ListConcepto As New List(Of clsConcepto)
    Public ListPeri As New List(Of clsPeriodicidad)
    Public bsArea As BindingSource
    Public bsPeri As BindingSource
    Public bsConcepto As BindingSource
    Public _cdPerio As Integer
    Public bsS As BindingSource
    Public ListAreas As New List(Of clsAreas)
    Public ListS As New List(Of clsSeguimientoExpedientes)
    Public oclsC As New clsComprobantes
    Public _cdExterior As Integer
    Public _cdClaseC As Integer
    Public _cdTipo As Integer
    Public _cdMoneda As Integer
    Public _cdConcepto As Integer
    Public _cdTipoPer As Integer
    Public _TipoProv As Integer
    Public codArea As Integer
    Public codDependencia As Integer
    Public oclsE As New clsExpedientes()
    Public oclsECO As New clsExpedientesConvenioOtros()
    Public oclsProv As New clsProveedores
    Public _intcdComprobante As Integer
    Public _cdDesglose As Integer
    Public vlPesos As Decimal
    Public vlDolares As Decimal
    Public vlEuros As Decimal
    Public vlFrancoS As Decimal
    Public cdEstadoAnt As Integer
    Public _dsNroComp As String
    Public oclsCot As New clsCotizaciones
    Private ArrAreas As New ArrayList
    Public strArea As String = ""
    Public codAreaE As Integer
    Public _Edit As Integer
    Public _cdSeguimiento As Integer
    Public _dsNroCuit As Integer
    Public _cdExpRel As Integer
    Public oclsES As New ClsSolicitudes
    Dim ListSol As New List(Of ClsSolicitudes)
    Public bsSol As BindingSource
    Public objLoad As New System.Object
    Public e As New System.EventArgs
    Public Property codproveedor() As Integer
        Get
            Return _codproveedor
        End Get
        Set(ByVal value As Integer)
            _codproveedor = value
        End Set
    End Property
#Region "Metodos"
    Public Function ValidarAnexado() As Boolean
        Dim val As Boolean
        Dim ds As New DataSet
        ' If (Me._cdExpRel = 0) Then
        _cdExpRel = Me.txtcdNroExpedienteRel.Text
        ' End If
        ds = WS.VALIDAR_ANEXADO(Me._cdExpRel)
        If (ds.Tables(0).Rows().Count > 0) Then
            If (ds.Tables(0).Rows(0).Item("cdExpedienterel").ToString() <> 0) Then
                MessageBox.Show("No se puede anexar el expediente a otro que se encuentre anexado", "Anexar expediente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                val = False
                txtcdNroExpedienteRel.Text = ""
                txtNroExpedienteRel.Text = ""
            Else

                val = True
            End If
        End If
    End Function
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
                MsgBox("No coincide el dígito verificador. " & str(veri_nro), vbDefaultButton1, "Error en el C.U.I.T.")
            Else
                cuit_rearmado = Mid(cuit_rearmado, 1, 2) & "-" & Mid(cuit_rearmado, 3, 8) & "-" & Mid(cuit_rearmado, 11, 1)
            End If
        End If
        verifica_cuit = cuit_rearmado
    End Function
    Public Function vlCabecera() As Boolean

        If (dt.Value <= Date.Now) Then
        Else
            MessageBox.Show("No se puede ingresar una fecha superior a la fecha de hoy")
            Return False
            Exit Function
        End If
        If (Me.txtNroExpediente.Text = "") Then
            MessageBox.Show("Debe ingresar el nro del expedietne")
            Return False
            Exit Function
        End If
        If (Me.txtRazonSocial.Text = "") Then
            MessageBox.Show("Debe ingresar el proveedor")
            Return False
            Exit Function
        End If
        If (codproveedor = 0) Then
            MessageBox.Show("Debe ingresar un proveedor existente")
            Return False
            Exit Function
        End If

        If (Me.mtxtAreaE.Text = "") Then
            MessageBox.Show("Debe ingresar la dependencia")
            Return False
            Exit Function
        End If
        If (Me.codAreaE = 0) Then
            MessageBox.Show("Debe ingresar una dependencia valida")
            Return False
            Exit Function
        End If
        If (_Modo = 0) Then
            Dim d As New DataSet
            d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
            If (d.Tables(0).Rows().Count > 0) Then
                MessageBox.Show("No se puede ingresar, ya existe el expediente con el mismo proveedor")
                Return False
                Exit Function
            End If
        End If
        If (_Modo = 1) Then
            Dim dsVl As New DataSet
            Dim Val As Integer
            dsVl = WS.Obtener_codExpediente(Me.txtNroExpediente.Text)
            If (dsVl.Tables(0).Rows.Count > 0) Then
                Val = dsVl.Tables(0).Rows(0).Item("cdExpediente")
                If (Val = Me._cdExpediente) Then
                Else
                    MessageBox.Show("El Nro de expediente ya existe")
                    Return False
                    Exit Function
                End If
            End If
        End If
        Return True
    End Function
    Sub CargarMonedas(ByVal cdmoneda As Integer)
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_Monedas(cdmoneda)
            If (ds.Tables(0).Rows().Count > 0) Then
                cboMoneda.DisplayMember = "dsMoneda"
                cboMoneda.ValueMember = "cdMoneda"
                cboMoneda.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarcodExpRel()
        Try

            If (Me.txtNroExpedienteRel.Text <> "") Then
                Dim d As New DataSet
                d = WS.Obtener_codExpediente(Me.txtNroExpedienteRel.Text) ', Me.codproveedor)
                If (d.Tables(0).Rows().Count > 0) Then
                    If (d.Tables(0).Rows(0).Item("cdExpediente") <> _cdExpediente) Then
                        Dim dsVal As DataSet
                        dsVal = WS.VALIDAR_INFORMANDOEXPEDIENTEANEXADO(Me._cdExpediente)
                        If (dsVal.Tables(0).Rows().Count > 0) Then
                            MessageBox.Show("El expediente tiene otros expedientes relacionados, los mismos se anexaran al Nro " + Me.txtNroExpedienteRel.Text)
                        End If
                        Me.txtcdNroExpedienteRel.Text = d.Tables(0).Rows(0).Item("cdExpediente")
                        dsNroRel = Me.txtNroExpedienteRel.Text
                        'Me.txtNroExpedienteRel.Text = ""
                        ' Me.lblExpedienteAnexado.Text = "Expediente Anexado Nro." + Me.txtNroExpedienteRel.Text
                        'If (d.Tables(0).Rows(0).Item("dsExpAnexados").ToString <> "") Then
                        '    MessageBox.Show("El expediente se anexará al " + txtNroExpedienteRel.Text + " (Ya se encuentran los expedientes " + Mid$(d.Tables(0).Rows(0).Item("dsExpAnexados").ToString, 3) + ")", "Expediente anexado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'End If
                    Else
                        Me.txtcdNroExpedienteRel.Text = _cdExpRel
                        Me.txtNroExpedienteRel.Text = Me.dsNroRel
                        Exit Sub

                    End If
                    '   cdanio = d.Tables(0).Rows(0).Item("cdExpediente")
                Else
                    Me.txtNroExpedienteRel.Text = ""
                    Me.txtcdNroExpedienteRel.Text = 0
                    'Me.lblExpedienteAnexado.Text = ""
                    '  Me.lblExpedienteAnexado.Text = "Sin Expediente Anexado"
                End If
            ElseIf (dsNroRel <> "") Then
                Dim d As New DataSet
                d = WS.Obtener_codExpediente(dsNroRel) ', Me.codproveedor)
                If (d.Tables(0).Rows().Count > 0) Then
                    If (d.Tables(0).Rows(0).Item("cdExpediente").ToString() <> _cdExpediente) Then

                        Dim dsVal As DataSet
                        dsVal = WS.VALIDAR_INFORMANDOEXPEDIENTEANEXADO(Me._cdExpediente)
                        If (dsVal.Tables(0).Rows().Count > 0) Then
                            MessageBox.Show("El expediente tiene otros expedientes relacionados, los mismos se anexaran al Nro " + Me.txtNroExpedienteRel.Text)
                        End If
                        '  Dim res As DialogResult = MsgBox("El expediente esta anexado al Expediente Nro." + dsNroRel + " ¿Desea efectuar el cambio?", MsgBoxStyle.YesNo + 32, "Confirmación")
                        If (d.Tables(0).Rows(0).Item("dsExpAnexados").ToString <> "") Then
                            MessageBox.Show("El expediente se anexará al " + txtNroExpedienteRel.Text + " (Ya se encuentran los expedientes " + Mid$(d.Tables(0).Rows(0).Item("dsExpAnexados").ToString, 3) + ")", "Expediente anexado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Me.txtcdNroExpedienteRel.Text = d.Tables(0).Rows(0).Item("cdExpediente")
                        'dsNroRel = Me.txtNroExpedienteRel.Text
                        'Me.txtNroExpedienteRel.Text = ""
                        'Me.txtNroExpedienteRel.Text = dsNroRel + d.Tables(0).Rows(0).Item("intAnio")
                        '   cdanio = d.Tables(0).Rows(0).Item("cdExpediente")
                        ' Me.lblExpedienteAnexado.Text = ""

                    Else
                        Me.txtcdNroExpedienteRel.Text = _cdExpRel
                        Me.txtNroExpedienteRel.Text = Me.dsNroRel
                        Exit Sub
                    End If

                Else
                    '   Me.lblExpedienteAnexado.Text = ""
                    '   Me.lblExpedienteAnexado.Text = "Sin Expediente Anexado"
                    Me.txtNroExpedienteRel.Text = ""
                    Me.txtcdNroExpedienteRel.Text = 0
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarDatosExpediente()
        Try
            If (_Modo = 0) Then
                Dim arr As New List(Of clsExpedientes)
                Dim strFecha As Date
                oclsE.cdExpediente = Me._cdExpediente
                oclsE.dsExpediente = Me.txtNroExpediente.Text
                Me.lblNroExpedienteV.Text = Me.txtNroExpediente.Text
                Me.lblProveedorV.Text = Me.txtRazonSocial.Text
                strFecha = dt.Value
                Me.lblFechaV.Text = strFecha.ToShortDateString()
                oclsE.cdTipoExpediente = Me.cboTipoExpediente.SelectedValue
                oclsE.dtFecha = strFecha
                oclsE.cdProveedor = codproveedor
                oclsE.dsObservacion = Me.rhcObservacionesE.Text
                oclsE.cdAreaGasto = Me.codAreaE
                oclsE.cdBaja = 0
                If (Me.txtcdNroExpedienteRel.Text = "") Then
                    Me.txtcdNroExpedienteRel.Text = 0
                End If
                oclsE.cdExpedienteRel = Me.txtcdNroExpedienteRel.Text
                arr.Add(oclsE)
                oclsE.ArraS = arr
            End If
            If (_Modo <> 0) Then

                Dim arr As New List(Of clsExpedientes)
                Dim strFecha As Date
                Me.txtcdExpediente.Text = Me._cdExpediente
                oclsE.cdExpediente = Me.txtcdExpediente.Text
                oclsE.dsExpediente = Me.txtNroExpediente.Text
                Me.lblNroExpedienteV.Text = Me.txtNroExpediente.Text
                Me.lblProveedorV.Text = Me.txtRazonSocial.Text
                strFecha = dt.Value
                Me.lblFechaV.Text = strFecha.ToShortDateString()
                oclsE.cdTipoExpediente = Me.cboTipoExpediente.SelectedValue
                oclsE.dtFecha = strFecha
                oclsE.cdProveedor = codproveedor
                oclsE.dsObservacion = Me.rhcObservacionesE.Text
                oclsE.cdAreaGasto = Me.codAreaE
                oclsE.cdBaja = 0
                oclsE.cdExpedienteRel = Me.txtcdNroExpedienteRel.Text
                arr.Add(oclsE)

                oclsE.ArraS = arr
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarDatosConveniosOtros()
        Try
            If (Me.cboTipoPeriodicidad.Text = "Sin Periodicidad") Then
                ' Me.cboTipoPeriodicidad.SelectedValue = 1
                _cdPerio = 1
            End If
            If (cboTipoPeriodicidad.Text = "Mensual") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 3
                _cdPerio = 3
            End If
            If (Me.cboTipoPeriodicidad.Text = "Quincenal") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 4
                _cdPerio = 4
            End If
            If (Me.cboTipoPeriodicidad.Text = "Migración") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 4
                _cdPerio = 14
            End If
            If (_cdPerio <> 0) Then
                Me.CargarPeriodicidad_PorTipo(_cdPerio, 0)
            End If
            If (Me.txtCotMoneda.Text = "") Then
                Me.txtCotMoneda.Text = "0,000"
            End If
            Dim arr As New List(Of clsExpedientesConvenioOtros)


            oclsECO.intcdExp = Me._cdExpediente
            oclsECO.dtFecha = Me.dtFechaC.Value
            oclsECO.sObjeto = Me.txtObjeto.Text
            oclsECO.dsObservacion = Me.rchObservacionO.Text
            oclsECO.dsNroConvenio = Me.txtNroConvenio.Text
            oclsECO.cdTipoPerio = _cdPerio

            If (Me.dtFechaDesde.Checked = True) Then
                oclsECO.dtFechaD = Me.dtFechaDesde.Value

            End If
            If (Me.dtFechaHasta.Checked = True) Then
                oclsECO.dtFechaH = Me.dtFechaHasta.Value
            End If
            oclsECO.dsPerio = Me.cboPeriodicidadC.Text
            Me.txtImporteOtros.Text = FormatNumber(Me.txtImporteOtros.Text, 2)
            oclsECO.vlImporte = Me.txtImporteOtros.Text
            If (Me.cboMoneda.Text = "Pesos") Then
                oclsECO.cdMoneda = 1
            End If
            If (Me.cboMoneda.Text = "Dólar") Then
                oclsECO.cdMoneda = 2
            End If
            If (Me.cboMoneda.Text = "Euros") Then
                oclsECO.cdMoneda = 3
            End If

            If (Me.txtCotMoneda.Text <> "0,000") Then
                Me.txtCotMoneda.Text = FormatNumber(Me.txtCotMoneda.Text, 3)
                oclsECO.vlCotizacion = Me.txtCotMoneda.Text
            Else
                oclsECO.vlCotizacion = "0,000"
            End If
            oclsECO.cdAreaRequi = Me.codArea
            arr.Add(oclsECO)
            oclsECO.ArraS = arr

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function vlConvenioOtros() As Boolean
        If (Me.cboTipoExpediente.SelectedValue = 11) Then
            If (Me.txtNroConvenio.Text <> "") Then
            Else
                MessageBox.Show("Debe ingresar el nro del convenio")
                Return False
                Exit Function
            End If
            If (Me.txtImporteOtros.Text <> "0,00") Then
            Else
                MessageBox.Show("El importe debe ser mayor a 0")
                Return False
                Exit Function
            End If

            If (Me.mtxtArea.Text <> "") Then
            Else
                MessageBox.Show("Debe ingresar el unidad requirente")
                Return False
                Exit Function
            End If
            If (codArea <> 0) Then
            Else
                MessageBox.Show("Debe ingresar una unidad requirente valida")
                Return False
                Exit Function
            End If
            If (Me.txtObjeto.Text <> "") Then

            Else
                MessageBox.Show("Debe ingresar el objeto del convenio")
                Return False
                Exit Function
            End If


            If (Me.cboMoneda.Text <> "Pesos") Then
                If (Me.txtCotMoneda.Text = "0,000") Then
                    MessageBox.Show("La cotizacion de la moneda debe ser mayor a 0")
                    Return False
                    Exit Function
                End If
            End If
            Return True
        End If
        If (Me.cboTipoExpediente.SelectedValue = 13) Then
            If (Me.txtImporteOtros.Text <> "0,00") Then
            Else
                MessageBox.Show("El importe debe ser mayor a 0")
                Return False
                Exit Function
            End If
            If (Me.cboMoneda.SelectedValue <> -1) Then
            Else
                MessageBox.Show("Debe ingresar la moneda")
                Return False
                Exit Function
            End If
            If (mtxtArea.Text <> "") Then
            Else
                MessageBox.Show("Debe ingresar el area requirente")
                Return False
                Exit Function
            End If
            If (codArea <> 0) Then
            Else
                MessageBox.Show("Debe ingresar una unidad requirente valida")
                Return False
                Exit Function
            End If
            If (Me.cboMoneda.Text <> "Pesos") Then
                If (Me.txtCotMoneda.Text = "0,000") Then
                    MessageBox.Show("La cotizacion de la moneda debe ser mayor a 0")
                    Return False
                    Exit Function
                End If
            End If
        End If
        Return True
    End Function
    Sub CargarTipoPeriodicidad(ByVal intTipo As Integer)
        Try
            Dim ds As New DataTable()
            ds = WS.Obtener_TipoPeriodicidad(intTipo).Tables(0)
            If ds.Rows.Count > 0 Then
                Me.cboTipoPeriodicidad.DisplayMember = "dsTipoPeriodicidad"
                Me.cboTipoPeriodicidad.ValueMember = "cdTipoPeriodicidad"
                Me.cboTipoPeriodicidad.DataSource = ds
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Function getCodArea(ByVal pNombreArea As String) As Integer
        Try
            Dim ds As System.Data.DataSet
            Dim i As Integer
            ds = WS.Obtener_Areas(-1, pNombreArea)
            If (ds.Tables(0).Rows().Count > 0) Then
                Return ds.Tables(0).Rows(i).Item("cdArea")
            End If
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Sub CargarPeriodicidad_PorTipo(ByVal cdTipo As Integer, ByVal modo As Integer)
        Try
            If (_Modo = 0) Then
                If (Me.cboTipoPeriodicidad.Text = "MIGRACION") Then
                    Me.cmdPeriodicidadC.Visible = True
                    Me.dtFechaHasta.Visible = False
                    Me.dtFechaDesde.Visible = False
                    Me.lblFechaDesdeC.Visible = False
                    Me.lblFechaHastaC.Visible = False
                    Me.cmdPeriodicidadC.Visible = False
                    btnDesactivarC.Visible = False
                End If

                Dim i As Integer
                Dim ds As New DataSet()
                ds = WS.Obtener_Periodicidad(cdTipo)
                If ds.Tables(0).Rows.Count > 0 Then
                    If (Me.cboTipoPeriodicidad.Text <> "Sin Periodicidad") Then
                        Me.cboPeriodicidadC.DisplayMember = "dsPeriodicidad"

                        For i = 0 To ds.Tables(0).Rows.Count - 1
                            If (modo = 1) Then
                                If (Me.cboPeriodicidadC.Text = ds.Tables(0).Rows(i).Item("dsPeriodicidad")) Then
                                    Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    'Me.dtPrueba2.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    'Me.dtPrueba1.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                    Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                    ' Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                    Me.dtFechaHasta.Visible = False
                                    Me.dtFechaDesde.Visible = False
                                    Me.lblFechaDesdeC.Visible = False
                                    Me.lblFechaHastaC.Visible = False
                                    Me.cmdPeriodicidadC.Visible = False
                                    btnDesactivarC.Visible = False

                                End If
                            Else
                                Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                'Me.dtPrueba2.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                'Me.dtPrueba1.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                Me.cboPeriodicidadC.DataSource = ds.Tables(0)
                                Me.dtFechaHasta.Visible = False
                                Me.dtFechaDesde.Visible = False
                                Me.lblFechaDesdeC.Visible = False
                                Me.lblFechaHastaC.Visible = False
                                Me.cmdPeriodicidadC.Visible = False
                                btnDesactivarC.Visible = False
                            End If
                        Next

                    Else
                        Me.cboPeriodicidadC.DisplayMember = "dsPeriodicidad"
                        Me.cboPeriodicidadC.DataSource = ds.Tables(0)
                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesdeC.Visible = False
                        Me.lblFechaHastaC.Visible = False
                        Me.cmdPeriodicidadC.Visible = True
                        btnDesactivarC.Visible = False
                    End If
                End If
            Else

                Dim i As Integer
                Dim ds As New DataSet()
                ds = WS.Obtener_Periodicidad(cdTipo)
                If (Me.cboTipoPeriodicidad.Text = "MIGRACION") Then
                    Me.cmdPeriodicidadC.Visible = True
                    Me.dtFechaHasta.Visible = False
                    Me.dtFechaDesde.Visible = False
                    Me.lblFechaDesdeC.Visible = False
                    Me.lblFechaHastaC.Visible = False
                    Me.cmdPeriodicidadC.Visible = False
                    btnDesactivarC.Visible = False
                End If

                If ds.Tables(0).Rows.Count > 0 Then

                    If (Me.cboTipoPeriodicidad.Text <> "Sin Periodicidad") Then
                        Me.cmdPeriodicidadC.Visible = False
                        Me.cboPeriodicidadC.DisplayMember = "dsPeriodicidad"
                        For i = 0 To ds.Tables(0).Rows.Count - 1
                            If (modo = 1) Then
                                If (Me.cboPeriodicidadC.Text = ds.Tables(0).Rows(i).Item("dsPeriodicidad")) Then
                                    ' Me.cboPeriodicidad.DataSource = ds.Tables(0)
                                    Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                    'Me.dtPrueba2.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                    'Me.dtPrueba1.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                End If
                            Else
                                Me.cboPeriodicidadC.DataSource = ds.Tables(0)
                                Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                                'Me.dtPrueba2.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                                'Me.dtPrueba1.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                            End If

                        Next
                        Me.dtFechaDesde.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                        Me.dtFechaHasta.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                        'Me.dtPrueba2.Value = ds.Tables(0).Rows(i).Item("fecha_fin")
                        'Me.dtPrueba1.Value = ds.Tables(0).Rows(i).Item("fecha_inicio")
                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesdeC.Visible = False
                        Me.lblFechaHastaC.Visible = False
                        Me.cmdPeriodicidadC.Visible = False
                        btnDesactivarC.Visible = False

                    Else
                        Me.cmdPeriodicidadC.Visible = True
                        Me.cboPeriodicidadC.DisplayMember = "dsPeriodicidad"
                        Me.cboPeriodicidadC.DataSource = ds.Tables(0)
                        Me.dtFechaHasta.Visible = False
                        Me.dtFechaDesde.Visible = False
                        Me.lblFechaDesdeC.Visible = False
                        Me.lblFechaHastaC.Visible = False
                        Me.cmdPeriodicidadC.Visible = True
                        btnDesactivarC.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function AutoCompletarPorCuit(ByVal Cuit As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsCuit = Cuit Or obj.dsProveedor = Cuit Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = Cuit
                oProveedor.cdProveedor = obj.cdProveedor
            End If
        Next
        Return oProveedor
    End Function
    Public Function ValidacionOrtograficaExpediente() As Boolean
        Try
            Dim dsExpediente As String
            dsExpediente = Me.txtNroExpediente.Text
            dsExpediente.Split("")
            Me.txtNroExpediente.Text = dsExpediente
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ValidaCampos() As Boolean
        Try


            If (Me.txtCuit.Text = "") Then
                Me.lblErrorRS.Visible = True
                MessageBox.Show("Debe ingresar el Cuit del Proveedor.")
                Me.lblErrorRS.Text = "Debe ingresar el Cuit del Proveedor."
                Return False
                Exit Function
            Else
                Me.lblErrorRS.Visible = False
            End If

            If (Me.txtRazonSocial.Text = "") Then
                Me.txtRazonSocial.Visible = True
                MessageBox.Show("Debe ingresar la Razon Social.")
                Me.lblErrorRS.Text = "Debe ingresar la Razon Social."
                Return False
                Exit Function
            Else
            End If
            If (Me.txtNroExpediente.Text = "") Then
                Me.lblErrorRS.Visible = True
                MessageBox.Show("Debe ingresar el Nro. del Expediente")
                Me.lblErrorRS.Text = "Debe ingresar la Razon Social."
                Return False
                Exit Function
            Else
                Me.lblErrorRS.Visible = False
            End If
            If (Me.dgvlistado.Rows.Count > 0) Then
            Else
                MessageBox.Show("Debe ingresar al menos un comprobante asociado")
                Return False
                Exit Function
            End If
            Dim intFecha As Integer
            If (Me.dt.Checked = False) Then
                intFecha = -1
            Else
                intFecha = 1
            End If

            '  If (Me.dgvlistado.Rows.Count > 0) Then
            'Dim d As New DataSet
            'd = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
            'If (d.Tables(0).Rows().Count > 0) Then
            '    MessageBox.Show("El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678")
            '    Return False
            '    Exit Function
            'End If


            '    Dim ds As New DataSet
            '    Dim dt1 As New DataTable
            '    Dim dr1 As clsComprobante
            '    Dim str As String
            '    For Each dr1 In bs
            '        str = dr1.dsComprobante

            '        ds = WS.ValidarComprobantes_BycdProv(str, codproveedor, -1, -1)
            '        If (ds.Tables(0).Rows().Count > 0) Then
            '        Else
            '            Me.txtRazonSocial.Enabled = True
            '            Me.txtCuit.Enabled = True
            '            MessageBox.Show("No se puede cambiar el proveedor del expediente")
            '            Return False
            '            Exit Function
            '        End If
            '    Next
            'End If

            Dim rx As New Regex("[0-9]{1,4}(-)[0-9]{1,8}")
            If Not (rx.IsMatch(Me.txtNroExpediente.Text)) Then
                MessageBox.Show("El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678")
                Return False
                Exit Function
            End If
            ' End If
            Return True
            Me.lblErrorRS.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Sub CargarCotizacionMoneda()
        Try
            Dim arrCot As New List(Of clsCotizaciones)

            If (Me.cboMoneda.Text = "Pesos") Then
                oclsCot._cdMoneda = 1
            End If

            If (Me.cboMoneda.Text = "Dólar") Then
                oclsCot._cdMoneda = 2
            End If
            If (Me.cboMoneda.Text = "Euros") Then
                oclsCot._cdMoneda = 3
            End If
            If (Me.cboMoneda.Text <> "Pesos") Then
                oclsCot._vlCotizacion = Me.txtCotMoneda.Text
            Else
                oclsCot._vlCotizacion = "0,000"
            End If
            oclsCot._dtFecha = Me.dtFechaC.Value
            arrCot.Add(oclsCot)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCotizaciones(ByVal cdmoneda As Integer)
        Try
            If (Me.cboMoneda.SelectedText = "Pesos") Then
                Dim ds As New DataSet()
                ds = WS.Obtener_Cotizaciones(Me.cboMoneda.SelectedValue)
                If ds.Tables(0).Rows.Count > 0 Then
                    Me.txtCotMoneda.Text = ds.Tables(0).Rows(0).Item("vlcotizacion") '
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub ValidarCotizacion(ByVal cdmoneda As Integer, ByVal pdtFecha As DateTime)
        Try
            Dim ds As New DataSet()
            ds = WS.SP_ValidaCotizacion_BycdMoneda_byFecha(cdmoneda, pdtFecha)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.txtCotMoneda.Text = ds.Tables(0).Rows(0).Item("vlcotizacion")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarGrillaConceptos()
        If (_cdExpediente <> 0) Then
            ListConcepto = New List(Of clsConcepto)
            bsConcepto = New BindingSource(ListConcepto, "")
            Me.dgvConceptos.DataSource = bsConcepto
            Dim ds As New DataSet
            ds = WS.TraerPantalla_ByConcepto(_cdExpediente)
            If (ds.Tables(0).Rows.Count > 0) Then

                Dim dt1 As New DataTable
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim oclsConcep As New clsConcepto
                    oclsConcep.cdExp = _cdExpediente
                    oclsConcep.cdSubConcepto = ds.Tables(0).Rows(i).Item("cdSubConcepto")
                    oclsConcep.dsConcepto = ds.Tables(0).Rows(i).Item("dsConcepto")
                    oclsConcep.dsSubConcepto = ds.Tables(0).Rows(i).Item("dsSubConcepto")
                    oclsConcep.dsObservacion = ds.Tables(0).Rows(i).Item("sObservacion").ToString()
                    ListConcepto.Add(oclsConcep)
                    bsConcepto.ResetBindings(False)
                Next
                Me.dgvConceptosver.DataSource = ds.Tables(0)
            Else
                Me.dgvConceptosver.DataSource = ds.Tables(0)
            End If
        ElseIf (_cdExpediente = 0) Then
            Dim ds1 As New DataSet
            ds1 = WS.TraerPantalla_ByConcepto(0)
            Me.dgvConceptosver.DataSource = ds1.Tables(0)
        End If

    End Sub
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
    Public Sub TraerCA_Por_Expediente()
        Dim txtObservacion As String = ""
        Dim txtNroSolicitud As String = ""

        If (Me.dgvlistado.Rows.Count > 0) Then
            Dim d As New DataSet
            d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
            If (d.Tables(0).Rows().Count > 0) Then
                btnAgregarCabecera.Enabled = False
                Me.cmdModificarExp.Visible = True
                TraerUltimoEstado(_cdExpediente)
                Me.txtNroExpediente.Enabled = True

            Else
                'Me.dgvConceptosver.Refresh()
                'Me.dgvComprobantesVer.Refresh()
                dgvConceptos.Rows.Clear()
                Me.bsConcepto = New BindingSource(ListConcepto, "")
                Me.dgvConceptos.DataSource = bsConcepto
                Me._cdExpediente = 0
                Me.dgvlistado.Rows.Clear()
                Me.txtNroExpediente.Enabled = False
                bs = New BindingSource(List, "")
                Me.dgvlistado.DataSource = bs
                Me.txtRazonSocial.Enabled = True
                Me.txtNroBeneficiario.Enabled = True
                Me.txtCuit.Enabled = True
                _Tipo = 0
                Me.chkExterior.Enabled = True
                btnAgregarCabecera.Enabled = True
                Me.cmdModificarExp.Visible = False
                Me.lblMensajeModificar.Visible = False
                Me.Label1.Text = "$0,00"
                lblNroExpedienteV.Text = "Exp(Nuevo)"
                lblFechaV.Text = "Fecha"
                lblProveedorV.Text = "Sin Proveedor"
                lblImporteD.Text = "0,000"
                lblImporteE.Text = "0,000"
                Me.lblFs.Text = "0,000"
            End If
        Else
            Dim ds As New DataSet
            ds = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
            If (ds.Tables(0).Rows().Count > 0) Then
                Me._cdExpediente = ds.Tables(0).Rows(0).Item("cdExpediente") '
                TraerUltimoEstado(_cdExpediente)
                _Tipo = 1
                Me.cboTipoExpediente.SelectedValue = ds.Tables(0).Rows(0).Item("cdTipoExpediente")
                If (ds.Tables(0).Rows(0).Item("cdTipoExpediente") = 11) Then
                    Me.TabComprobantes.Text = "Convenio"
                End If
                Dim cdTipoExp As Integer
                cdTipoExp = ds.Tables(0).Rows(0).Item("cdTipoExpediente")
                If ((cdTipoExp = 12) Or (cdTipoExp = 21) Or (cdTipoExp = 22)) Then
                    Me.TabComprobantes.Text = "Comprobantes"
                End If
                If (ds.Tables(0).Rows(0).Item("cdTipoExpediente") = 13) Then
                    Me.TabComprobantes.Text = "Otros"
                End If

                _Modo = 1
                Me.dt.Value = ds.Tables(0).Rows(0).Item("dtFecha").ToString()

                'Me.rhcObservacionesE.Text
                txtObservacion = ds.Tables(0).Rows(0).Item("sObservacion").ToString()


                codAreaE = ds.Tables(0).Rows(0).Item("cdAreaGasto").ToString()
                Me.mtxtAreaE.Text = ds.Tables(0).Rows(0).Item("dsArea").ToString()
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor").ToString()
                If (ds.Tables(0).Rows(0).Item("cdExpedienteRel").ToString() <> 0) Then
                    Me.txtcdNroExpedienteRel.Text = ds.Tables(0).Rows(0).Item("cdExpedienteRel").ToString()
                    If (Me.txtcdNroExpedienteRel.Text <> 0) Then
                        Dim dsRel As New DataSet
                        dsRel = WS.SP_SELECT_NroExpedienteRel(txtcdNroExpedienteRel.Text)
                        If (dsRel.Tables(0).Rows().Count > 0) Then
                            Me.txtNroExpedienteRel.Text = dsRel.Tables(0).Rows(0).Item("dsNroExpediente").ToString()
                        Else
                            Me.txtNroExpedienteRel.Text = ""
                        End If

                    End If
                End If

                If (ds.Tables(0).Rows(0).Item("cdEsExterior").ToString() = 0) Then
                    Me.chkExterior.Checked = False
                Else
                    Me.chkExterior.Checked = True
                End If
                Me.txtNroExpedienteRel.Enabled = False
                Me.txtRazonSocial.Enabled = False
                Me.chkExterior.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.mtxtAreaE.Enabled = False
                Me.rhcObservacionesE.Enabled = False
                Me.dt.Enabled = False
                Me.cboTipoExpediente.Enabled = False
                Me.txtNroExpediente.Enabled = False
                Me.lblNroExpedienteV.Text = "Exp " + Me.txtNroExpediente.Text
                Me.lblProveedorV.Text = Me.txtRazonSocial.Text
                Me.lblFechaV.Text = dt.Value.ToString()
                'Me.lblFechaV.Text = Me.lblFechaV.ToString("yyyyMMdd")
                btnAgregarCabecera.Enabled = False
                Me.cmdModificarExp.Visible = True
                Me.lblMensajeModificar.Visible = False
                CargarGrillaConceptos()
                AgregarDatosGrilla_ConveniosOtros(Me.cboTipoExpediente.SelectedValue)
                If (ds.Tables(1).Rows().Count > 0) Then
                    Me._cdSolicitud = ds.Tables(1).Rows(0).Item("cdSolicitud") '
                    Me.txtNroExpediente.Text = ds.Tables(1).Rows(0).Item("dsNroExpSolicitud")
                    txtNroSolicitud = ds.Tables(1).Rows(0).Item("dsSolicitud")
                    CargarEstadosSolicitudes()

                End If
            Else
                If (ds.Tables(1).Rows().Count > 0) Then
                    Me._cdSolicitud = ds.Tables(1).Rows(0).Item("cdSolicitud") '
                    Me.txtNroExpediente.Text = ds.Tables(1).Rows(0).Item("dsNroExpSolicitud")
                    txtNroSolicitud = ds.Tables(1).Rows(0).Item("dsSolicitud")
           
                    Me.CargarEstadosSolicitudes()
                End If
                Me.txtNroExpedienteRel.Enabled = True
                Me.txtNroExpedienteRel.Enabled = True
                'Me.dgvComprobantesVer.Refresh()
                dgvConceptos.Rows.Clear()
                Me.dgvComprobantesRel.Rows.Clear()
                Me.bsConcepto = New BindingSource(ListConcepto, "")
                Me.dgvConceptos.DataSource = bsConcepto
                Me._cdExpediente = 0
                bs = New BindingSource(List, "")
                Me.dgvlistado.DataSource = bs
                Me.txtRazonSocial.Enabled = True
                Me.txtCuit.Enabled = True
                Me.chkExterior.Enabled = True
                Me.txtNroBeneficiario.Enabled = True
                'btnAgregarCabecera.Enabled = False
                'Me.cmdModificarExp.Visible = True
                'Me.lblMensajeModificar.Visible = False
                Me.Label1.Text = "$0,00"
                lblNroExpedienteV.Text = "Exp(Nuevo)"
                lblFechaV.Text = "Fecha"
                lblProveedorV.Text = "Sin Proveedor"
                lblImporteD.Text = "0,000"
                lblImporteE.Text = "0,000"
                Me.lblFs.Text = "0,000"
                Me.lblTitulo.Visible = False
                _Modo = 0
                _Tipo = 0
            End If
       
        End If
        Me.rhcObservacionesE.Text = ""
        If (txtNroSolicitud <> "") Then
            Me.rhcObservacionesE.Text = txtNroSolicitud + " " + txtObservacion
        Else
            Me.rhcObservacionesE.Text = txtObservacion
        End If
    End Sub
    Public Sub TraerExpedienteMod()
        Dim ds As New DataSet
        ds = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
        If (ds.Tables(0).Rows().Count > 0) Then
            Me._cdExpediente = ds.Tables(0).Rows(0).Item("cdExpediente") '
            TraerUltimoEstado(_cdExpediente)
            _Tipo = 1
            Me.cboTipoExpediente.SelectedValue = ds.Tables(0).Rows(0).Item("cdTipoExpediente")
            If (ds.Tables(0).Rows(0).Item("cdTipoExpediente") = 11) Then
                Me.TabComprobantes.Text = "Convenio"
            End If
            Dim cdTipoExp As Integer
            cdTipoExp = ds.Tables(0).Rows(0).Item("cdTipoExpediente")
            If ((cdTipoExp = 12) Or (cdTipoExp = 21) Or (cdTipoExp = 22)) Then
                Me.TabComprobantes.Text = "Comprobantes"
            End If
            If (ds.Tables(0).Rows(0).Item("cdTipoExpediente") = 13) Then
                Me.TabComprobantes.Text = "Otros"
            End If

            _Modo = 1

            Me.dt.Value = ds.Tables(0).Rows(0).Item("dtFecha").ToString()

            Me.rhcObservacionesE.Text = ds.Tables(0).Rows(0).Item("sObservacion").ToString()
            codAreaE = ds.Tables(0).Rows(0).Item("cdAreaGasto").ToString()
            Me.mtxtAreaE.Text = ds.Tables(0).Rows(0).Item("dsArea").ToString()
            Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
            Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
            Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
            Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor").ToString()
            If (ds.Tables(0).Rows(0).Item("cdExpedienteRel").ToString() <> Nothing) Then
                Me.txtcdNroExpedienteRel.Text = ds.Tables(0).Rows(0).Item("cdExpedienteRel").ToString()
                Dim dsRel As New DataSet
                dsRel = WS.SP_SELECT_NroExpedienteRel(txtcdNroExpedienteRel.Text)
                If (dsRel.Tables(0).Rows().Count > 0) Then
                    Me.txtNroExpedienteRel.Text = dsRel.Tables(0).Rows(0).Item("dsNroExpediente").ToString()
                Else
                    Me.txtNroExpedienteRel.Text = ""
                End If
            End If

            If (ds.Tables(0).Rows(0).Item("cdEsExterior").ToString() = 0) Then
                Me.chkExterior.Checked = False
            Else
                Me.chkExterior.Checked = True
            End If
            Me.txtNroExpedienteRel.Enabled = False
            Me.txtRazonSocial.Enabled = False
            Me.chkExterior.Enabled = False
            Me.txtCuit.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
            Me.mtxtAreaE.Enabled = False
            Me.rhcObservacionesE.Enabled = False
            Me.dt.Enabled = False
            Me.cboTipoExpediente.Enabled = False
            Me.txtNroExpediente.Enabled = False
            Me.lblNroExpedienteV.Text = "Exp " + Me.txtNroExpediente.Text
            Me.lblProveedorV.Text = Me.txtRazonSocial.Text
            Me.lblFechaV.Text = dt.Value.ToString()
            'Me.lblFechaV.Text = Me.lblFechaV.ToString("yyyyMMdd")
            btnAgregarCabecera.Enabled = False
            Me.cmdModificarExp.Visible = True
            Me.lblMensajeModificar.Visible = False
            CargarGrillaConceptos()
            AgregarDatosGrilla_ConveniosOtros(Me.cboTipoExpediente.SelectedValue)

        End If
    End Sub
    Function AutoCompletarProveedor(ByVal dsNombre As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsProveedor.ToUpper() = dsNombre.ToUpper() Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = obj.dsCuit
                oProveedor.cdProveedor = obj.cdProveedor
                oProveedor.dsNroBeneficiario = obj.dsNroBeneficiario
                oProveedor.cdEsExterior = obj.cdEsExterior
            End If
        Next
        Return oProveedor
    End Function
    Sub CompletarRazonSocial(ByVal txtCuit As String, ByVal txtNombre As String, ByVal txtCod As Integer, ByVal txtBeneficiario As String)
        If Me.txtCuit.Text.Length <> 0 Then
            Dim org As clsProveedor = AutoCompletarPorCuit(txtCuit)
            If org.dsProveedor <> "" Then
                Me.txtCuit.Text = org.dsCuit
                txtCod = org.cdProveedor
                Me.txtRazonSocial.Text = org.dsProveedor
                txtBeneficiario = org.dsNroBeneficiario
            End If
        End If

    End Sub
    Sub CompletarCuit(ByVal txtProve As TextBox, ByVal txtcuit As TextBox)
        If txtProve.Text.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve.Text) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                txtProve.Text = Prov.dsProveedor
                txtcuit.Text = Prov.dsCuit
                codproveedor = Prov.cdProveedor

            End If
        End If
    End Sub
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

                Me.txtCuit.Enabled = False
                codproveedor = Prov.cdProveedor
                Me.txtNroBeneficiario.Text = Prov.dsNroBeneficiario
                Me.txtRazonSocial.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.chkExterior.Enabled = False
                ' ToolStripAgregar.Enabled = False
                ToolStripModificar.Enabled = True
                Me.ToolStripNuevo.Enabled = True
            End If
        End If
    End Sub
    Public Sub LimpiarDatos()
        Me.txtNroExpediente.Text = ""
        Me.codproveedor = 0
        Me._cdExpediente = 0
        Me.txtRazonSocial.Text = ""
        Me.txtCuit.Text = ""
        _Modo = 0
        _Tipo = 0
        ' Me.txtComprobantesAsociados.Text = ""
        Me.chkExterior.Checked = False
        Me.dgvlistado.Rows.Clear()
        Me.dt.Value = Today
        bs = New BindingSource(List, "")
        Me.dgvlistado.DataSource = bs
        If (Me.chkExterior.Checked = True) Then
            _Chk = 1
        Else
            _Chk = 0
        End If
        AutoCompletarProveedores_Organismo(0)
        Me.txtRazonSocial.Enabled = True
        Me.txtCuit.Enabled = True
    End Sub
    Public Sub CargarGrillaComprobantesRel(ByVal cdExpRel As Integer)
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_ComprobantesRel(cdExpRel)
            If (ds.Tables(0).Rows().Count > 0) Then
                Me.dgvComprobantesRel.DataSource = ds.Tables(0)
                gbxComprobantesRel.Visible = True
            Else
                gbxComprobantesRel.Visible = False
            End If
            Dim dsT As New DataSet
            dsT = WS.Obtener_ComprobantesTodos(_cdExpediente)
            If (dsT.Tables(0).Rows().Count > 0) Then
                dgvComprobantesVer.DataSource = dsT.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub AgregarDatosGrilla_ConveniosOtros(ByVal int As Integer)
        List = New List(Of clsComprobante)
        bs = New BindingSource(List, "")
        Me.dgvlistado.DataSource = bs
        If ((int = 12) Or (int = 21) Or (int = 22) Or (int = 24)) Then
            Dim d As New DataSet
            Dim i As Integer
            d = WS.Obtener_ComprobantesAsociados(_cdExpediente, 0)
            If (d.Tables(0).Rows().Count > 0) Then
                Me.txtRazonSocial.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                mtxtAreaE.Enabled = False
                Me.rhcObservacionesE.Enabled = False
                Me.dt.Enabled = False
                Me.lblNroExpedienteV.Text = "Exp " + Me.txtNroExpediente.Text
                Me.lblProveedorV.Text = Me.txtRazonSocial.Text
                Me.lblFechaV.Text = dt.Value

                For i = 0 To d.Tables(0).Rows.Count - 1
                    Dim ocls As New clsComprobante
                    Dim clse As DataSet
                    Dim tipo As DataSet

                    If (d.Tables(0).Rows(i).Item("cdComprobante").ToString() <> Nothing) Then


                        ocls.colExp = d.Tables(0).Rows(i).Item("cdExpediente")
                        ocls.codComprobante = d.Tables(0).Rows(i).Item("cdComprobante").ToString()
                        ocls.dsComprobante = d.Tables(0).Rows(i).Item("dsNroComprobante").ToString()
                        ocls.dsComprobanteClaseTipo = d.Tables(0).Rows(i).Item("dsAbreviatura").ToString() + "   " + d.Tables(0).Rows(i).Item("dsTipoComprobante").ToString() + "   " + ocls.dsComprobante
                        ocls.dtFecha = d.Tables(0).Rows(i).Item("dtFecha").ToString()
                        ocls.monto = d.Tables(0).Rows(i).Item("vlImporteC").ToString()
                        ocls.cdClaseComp = d.Tables(0).Rows(i).Item("cdClaseComprobante").ToString()
                        ocls.cdTipoC = d.Tables(0).Rows(i).Item("cdTipoComprobante").ToString()
                        clse = WS.Obtener_ClaseComprobantes(ocls.cdClaseComp)
                        tipo = WS.Obtener_TipoComprobantes(ocls.cdTipoC)
                        ocls.dsObservacion = d.Tables(0).Rows(i).Item("sObservacion").ToString()
                        ocls.cdUnidad = d.Tables(0).Rows(i).Item("cdUnidad").ToString()
                        ocls.dsUnidad = d.Tables(0).Rows(i).Item("dsArea").ToString()
                        ocls.cdPerio = d.Tables(0).Rows(i).Item("cdTipoPeriodicidad").ToString()
                        ocls.dsPerio = d.Tables(0).Rows(i).Item("dsPeriodicidad").ToString()
                        ocls.dtFechaAlta = d.Tables(0).Rows(i).Item("dtFechaAlta").ToString()
                        If (d.Tables(0).Rows(i).Item("dtFechaDesde").ToString() <> Nothing And d.Tables(0).Rows(i).Item("dtFechaHasta").ToString() <> Nothing) Then
                            ocls.coldtFechaDesde = d.Tables(0).Rows(i).Item("dtFechaDesde").ToString()
                            ocls.coldtFechaHasta = d.Tables(0).Rows(i).Item("dtFechaHasta").ToString()


                        End If
                        ocls.EscdDesglose = d.Tables(0).Rows(i).Item("cdDesglosado").ToString()
                        ocls.cdMoneda = d.Tables(0).Rows(i).Item("cdMoneda").ToString()
                        Dim vlCot As Decimal
                        If (d.Tables(0).Rows(i).Item("vlCotizacion").ToString() = Nothing) Then
                            vlCot = "0,000"
                            ocls.vlCotizacion = vlCot
                        Else
                            vlCot = d.Tables(0).Rows(i).Item("vlCotizacion").ToString()
                            ocls.vlCotizacion = vlCot
                        End If
                        If (ocls.cdMoneda = 1) Then
                            ocls.dsMoneda = "Pesos"
                        End If
                        If (ocls.cdMoneda = 2) Then
                            ocls.dsMoneda = "Dólar"
                        End If
                        If (ocls.cdMoneda = 3) Then
                            ocls.dsMoneda = "Euros"
                        End If
                        If (ocls.cdMoneda = 4) Then
                            ocls.dsMoneda = "Francos Suizos"
                        End If
                        ocls.dsClaseComprobante = d.Tables(0).Rows(i).Item("dsClaseComprobante").ToString()
                        ocls.dsTipoComprobante = d.Tables(0).Rows(i).Item("dsTipoComprobante").ToString()

                        ocls.dsAbreviatura = d.Tables(0).Rows(i).Item("dsAbreviatura").ToString()

                        ' Me.lblClaseComprobanteVC.Text = "Clase de comprobante " + d.Tables(0).Rows(i).Item("dsAbreviatura").ToString()
                        If (vlCot <> 0) Then
                            ocls.vlImporteFinal = ocls.monto * vlCot
                        Else
                            ocls.vlImporteFinal = ocls.monto
                        End If
                        List.Add(ocls)
                        bs.ResetBindings(False)
                        ' Me.dgvlistado.SelectedRows(-1).Selected = False

                        If (Me.txtcdNroExpedienteRel.Text = "") Then
                            Me.txtcdNroExpedienteRel.Text = 0
                        End If


                        CargarGrillaComprobantesRel(Me._cdExpediente)
                        AgruparImporte_PorMoneda(ocls.cdMoneda, 1)

                        Dim dr As clsComprobante
                        Dim impFinal As Decimal
                        For Each dr In List
                            If (dr.cdClaseComp <> 3) Then
                                lblIValormporpesosVC.Text = Me.Label1.Text
                                '(lblIValormporpesosVC.Text + dr.vlImporteFinal)
                            Else
                                impFinal = Me.Label1.Text
                                impFinal = (impFinal - dr.vlImporteFinal)
                                lblIValormporpesosVC.Text = impFinal
                            End If
                        Next
                    Else

                        ' d = WS.Obtener_ComprobantesAsociados(0, 0)
                        '  Me.dgvComprobantesVer.DataSource = d.Tables(0)
                        Me.dgvComprobantesVer.Rows.Clear()
                        Me.dgvlistado.Rows.Clear()
                        Me.dgvComprobantesRel.Rows.Clear()
                        Me.dgvComprobantesRel.Visible = False
                        bs = New BindingSource(List, "")
                        Me.dgvlistado.DataSource = bs
                        _Tipo = 0
                        '  Me.TabSolapas.Location = New Point(1, 30)
                    End If
                Next
            Else
                d = WS.Obtener_ComprobantesAsociados(0, 0)
                Me.dgvComprobantesVer.DataSource = d.Tables(0)
                _Tipo = 0
            End If
            Me.TabComprobantes.Parent = Me.TabSolapas
            Me.TabAreas.Parent = Me.TabSolapas
            Me.TabConceptos.Parent = Me.TabSolapas
            Me.TabSeguimiento.Parent = Me.TabSolapas


        End If
        If ((int = 13) Or (int = 11)) Then
            Me.dgvComprobantesVer.Refresh()
            Me.dgvConceptosver.Refresh()
            Me.dgvConceptosver.Enabled = False
            Me.dgvComprobantesVer.Enabled = False
            Me.txtRazonSocial.Enabled = False
            Me.txtCuit.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
            Me.mtxtAreaE.Enabled = False
            Me.rhcObservacionesE.Enabled = False
            Me.dt.Enabled = False
            Me.lblNroExpedienteV.Text = "Exp " + Me.txtNroExpediente.Text
            Me.lblProveedorV.Text = Me.txtRazonSocial.Text
            Me.lblFechaV.Text = dt.Value
            '

            '  Me.cboTipoPeriodicidadC.SelectedValue = 1
            Me.TabAreas.Parent = Nothing
            Dim d As New DataSet
            Dim i As Integer
            d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
            If (d.Tables(0).Rows().Count > 0) Then
                For i = 0 To d.Tables(0).Rows.Count - 1
                    Dim cdMon As Integer
                    Dim oclsECO As New clsExpedientesConvenioOtros
                    Me.txtNroConvenio.Text = d.Tables(0).Rows(i).Item("dsNroConvenio").ToString()
                    Me.txtObjeto.Text = d.Tables(0).Rows(i).Item("sObjetoConvenio").ToString()
                    rchObservacionO.Text = d.Tables(0).Rows(i).Item("sObservacion").ToString()

                    _cdPerio = d.Tables(0).Rows(i).Item("cdTipoPeriodicidad").ToString()
                    Me.cboPeriodicidadC.Text = d.Tables(0).Rows(i).Item("dsPeriodicidad").ToString()
                    If (_cdPerio = 14) Then
                        Me.cboTipoPeriodicidad.Text = "Migracion"
                        Me.cboTipoPeriodicidad.SelectedValue = 14
                        '  Else
                        ' Me.cboTipoPeriodicidad.SelectedValue = _cdPerio
                    End If
                    If (_cdPerio = 1) Then
                        Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                        Me.cboTipoPeriodicidad.SelectedValue = 1

                        If (d.Tables(0).Rows(0).Item("dtFechaDesde").ToString() <> Nothing And d.Tables(0).Rows(0).Item("dtFechaHasta").ToString() <> Nothing) Then
                            grpPeriodoServicio.Enabled = True
                            Dim vld As Date, vlH As Date

                            vld = d.Tables(0).Rows(0).Item("dtFechaDesde")
                            Me.dtFechaDesde.Value = vld
                            Me.dtFechaDesde.Checked = True
                            Me.dtFechaDesde.Enabled = False
                            Me.dtFechaDesde.Visible = True

                            vlH = d.Tables(0).Rows(0).Item("dtFechaHasta")
                            Me.dtFechaHasta.Value = vlH
                            Me.dtFechaHasta.Checked = True
                            Me.dtFechaHasta.Visible = True

                            Me.lblFechaDesdeC.Visible = True
                            Me.lblFechaHastaC.Visible = True
                            Me.cmdPeriodicidadC.Visible = False
                            Me.btnDesactivarC.Visible = True
                            'Me.dtPrueba2.Value = d.Tables(0).Rows(i).Item("dtFechaHasta")
                            'Me.dtPrueba1.Value = d.Tables(0).Rows(i).Item("dtFechaDesde")
                        Else
                            Me.dtFechaDesde.Visible = False
                            Me.dtFechaHasta.Visible = False
                            Me.lblFechaDesdeC.Visible = False
                            Me.lblFechaHastaC.Visible = False
                            Me.cmdPeriodicidadC.Visible = False
                            Me.btnDesactivarC.Visible = True
                        End If

                    End If
                    If (_cdPerio = 3) Then
                        Me.cboTipoPeriodicidad.Text = "Mensual"
                        Me.cboTipoPeriodicidad.SelectedValue = 3
                        Me.dtFechaDesde.Visible = False
                        Me.dtFechaHasta.Visible = False
                        Me.lblFechaDesdeC.Visible = False
                        Me.lblFechaHastaC.Visible = False
                        Me.cmdPeriodicidadC.Visible = False
                        Me.btnDesactivarC.Visible = False
                    End If
                    If (_cdPerio = 4) Then
                        Me.cboTipoPeriodicidad.Text = "Quincenal"
                        Me.cboTipoPeriodicidad.SelectedValue = 4
                        Me.dtFechaDesde.Visible = False
                        Me.dtFechaHasta.Visible = False
                        Me.lblFechaDesdeC.Visible = False
                        Me.lblFechaHastaC.Visible = False
                        Me.cmdPeriodicidadC.Visible = False
                        Me.btnDesactivarC.Visible = False
                    End If
                    'If (d.Tables(0).Rows(0).Item("dtFechaDesde").ToString() <> Nothing And d.Tables(0).Rows(0).Item("dtFechaHasta").ToString() <> Nothing) Then
                    '    Me.dtFechaDesdeC.Value = d.Tables(0).Rows(0).Item("dtFechaDesde")
                    '    Me.dtFechaDesdeC.Enabled = False
                    '    Me.dtFechaHastaC.Value = d.Tables(0).Rows(0).Item("dtFechaHasta")
                    '    Me.dtFechaHastaC.Enabled = False
                    'Else
                    '    Me.dtFechaDesdeC.Visible = False
                    '    Me.dtFechaHastaC.Visible = False
                    '    Me.lblFechaDesdeC.Visible = False
                    '    Me.lblFechaHastaC.Visible = False
                    '    Me.cmdPeriodicidadC.Visible = False
                    '    Me.btnDesactivarC.Visible = True
                    'End If

                    'Me.dtFechaDesdeC.Value = d.Tables(0).Rows(i).Item("dtFechaDesde").ToString()
                    'Me.dtFechaHastaC.Value = d.Tables(0).Rows(i).Item("dtFechaHasta").ToString()
                    Me.txtImporteOtros.Text = d.Tables(0).Rows(i).Item("vlImporte").ToString()
                    cdMon = d.Tables(0).Rows(i).Item("cdMoneda").ToString()
                    If (cdMon = 1) Then
                        Me.lblCotizacion.Visible = False
                        Me.txtCotMoneda.Visible = False
                        Me.txtCotMoneda.Text = "$0,000"
                        '    Me.cboMoneda.SelectedValue = 1
                        Me.cboMoneda.Text = "Pesos"
                    End If
                    If (cdMon = 2) Then
                        Me.lblCotizacion.Visible = True
                        Me.txtCotMoneda.Visible = True
                        Me.txtCotMoneda.Text = d.Tables(0).Rows(i).Item("vlCotizacion").ToString()
                        '    Me.cboMoneda.SelectedValue = cdMon
                        Me.cboMoneda.Text = "Dólar"
                    End If
                    If (cdMon = 3) Then
                        Me.lblCotizacion.Visible = True
                        Me.txtCotMoneda.Visible = True
                        Me.txtCotMoneda.Text = d.Tables(0).Rows(i).Item("vlCotizacion").ToString()
                        '   Me.cboMoneda.SelectedValue = cdMon
                        Me.cboMoneda.Text = "Euros"
                    End If
                    If (cdMon = 4) Then
                        Me.lblCotizacion.Visible = True
                        Me.txtCotMoneda.Visible = True
                        Me.txtCotMoneda.Text = d.Tables(0).Rows(i).Item("vlCotizacion").ToString()
                        Me.cboMoneda.Text = "Francos Suizos"
                    End If
                    '
                    Me.codArea = d.Tables(0).Rows(i).Item("cdUnidadReq").ToString()
                    mtxtArea.Text = d.Tables(0).Rows(i).Item("dsArea").ToString()
                    Me.dtFechaC.Value = d.Tables(0).Rows(i).Item("dtFechaConvenio").ToString()

                    AgruparImporte_PorMoneda(Me.cboMoneda.SelectedValue, 0)
                Next

                Me.cmdModificarConvenio.Enabled = True
                Me.txtNroConvenio.Enabled = False
                Me.rchObservacionO.Enabled = False
                mtxtArea.Enabled = False
                Me.txtObjeto.Enabled = False
                Me.txtImporteOtros.Enabled = False
                Me.dtFechaC.Enabled = False
                Me.cboMoneda.Enabled = False
                Me.txtCotMoneda.Enabled = False
                grpPeriodoServicio.Enabled = False
                Me.cmdGuardarConvenio.Enabled = False
            Else
                '    Me.CargarTipoPeriodicidad_Otros(-2)
                '   Me.txtImporteOtros.Text = "0,00"
                '  Me.txtCotMoneda.Text = "0,000"
                '   Me.cboPeriodicidadC.Text = "SIN PERIODICIDAD"
                Me.cmdPeriodicidadC.Visible = True
                Me.cmdGuardarConvenio.Enabled = True
                Me.cmdModificarConvenio.Enabled = False
                Me.txtImporteOtros.Text = "0,00"
                '   CargarTipoPeriodicidad(-2)
                If (cboTipoPeriodicidad.Text = "Sin Periodicidad") Then
                    Me.cboTipoPeriodicidad.SelectedValue = 1
                    Me.dtFechaDesde.Visible = False
                    Me.dtFechaHasta.Visible = False
                    Me.lblFechaDesdeC.Visible = False
                    Me.lblFechaHastaC.Visible = False
                    Me.cmdPeriodicidadC.Visible = True
                    Me.btnDesactivarC.Visible = False
                End If
                If (Me.cboTipoPeriodicidad.Text = "Mensual") Then
                    Me.cboTipoPeriodicidad.SelectedValue = 3
                    Me.dtFechaDesde.Visible = False
                    Me.dtFechaHasta.Visible = False
                    Me.lblFechaDesdeC.Visible = False
                    Me.lblFechaHastaC.Visible = False
                    Me.cmdPeriodicidadC.Visible = False
                    Me.btnDesactivarC.Visible = False
                End If
                If (Me.cboTipoPeriodicidad.Text = "Quincenal") Then
                    Me.cboTipoPeriodicidad.SelectedValue = 4
                    Me.dtFechaDesde.Visible = False
                    Me.dtFechaHasta.Visible = False
                    Me.lblFechaDesdeC.Visible = False
                    Me.lblFechaHastaC.Visible = False
                    Me.cmdPeriodicidadC.Visible = False
                    Me.btnDesactivarC.Visible = False
                End If
                'Me.cboTipoPeriodicidad.SelectedValue = 1
                'Me.cboPeriodicidadC.Text = "SIN PERIODICIDAD"
                'Me.dtFechaDesdeC.Visible = False
                'Me.dtFechaHastaC.Visible = False
                'Me.lblFechaDesdeC.Visible = False
                'Me.lblFechaHastaC.Visible = False

                Me.cmdPeriodicidadC.Visible = True
                Me.btnDesactivarC.Visible = False
                Me.CargarMonedas(-1)
                Me.txtCotMoneda.Visible = False
                Me.lblCotizacion.Visible = False
                Me.cboTipoPeriodicidad.SelectedValue = 1
                Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                Me.cboPeriodicidadC.Text = "SIN PERIODICIDAD"
            End If
            Me.TabComprobantes.Parent = Me.TabSolapas
            Me.TabAreas.Parent = Nothing
            Me.TabConceptos.Parent = Me.TabSolapas
            Me.TabSeguimiento.Parent = Me.TabSolapas
        End If
        CambioColorFontGrilla()
    End Sub
    Public Sub CargarAreasNombre(ByVal str As String)
        If (str = "") Then
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
        End If
        If (str <> "") Then
            Dim ds As System.Data.DataSet
            Dim i As Integer
            mtxtAreaE.TextBox.AutoCompleteCustomSource.Clear()
            ArrAreas.Clear()
            ds = WS.Obtener_Areas(-1, "")
            If Not IsNothing(ds.Tables(0)) Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim ocls As New clsAreas
                    ocls.cdArea = ds.Tables(0).Rows(i).Item("cdArea")
                    ocls.dsArea = ds.Tables(0).Rows(i).Item("dsArea")
                    mtxtAreaE.TextBox.AutoCompleteCustomSource.Add(ocls.dsArea)
                    ArrAreas.Add(ocls)
                    strArea = Me.mtxtAreaE.Text
                Next i
            End If
        End If

    End Sub
    Public Sub CargarEliminacion(ByVal obj As clsComprobante, ByVal i As Integer)
        Dim intComp As Integer
        Dim intExp As Integer
        intComp = obj.codComprobante
        intExp = obj.colExp
        ocls = obj
        If (intComp <> 0) Then
            If (intExp <> 0) Then
                WS.ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(intComp, intExp, intError)
                MessageBox.Show("El Comprobante Asociado se a excluido correctamente")

            End If
        Else
        End If
    End Sub
    Public Sub TraerUltimoEstado(ByVal cdExp As Integer)
        Dim ds As DataSet
        ds = WS.OBTENER_ULTIMO_ESTADO(cdExp)
        If (ds.Tables(0).Rows().Count > 0) Then
            Me.lblTitulo.Visible = True
            Me.lblTitulo.Text = ds.Tables(0).Rows(0).Item("dsEstado") + " a " + ds.Tables(0).Rows(0).Item("dsArea") + " " + ds.Tables(0).Rows(0).Item("dtFecha") + " " + ds.Tables(0).Rows(0).Item("sObservaciones")
        Else
            Me.lblTitulo.Visible = False
        End If
    End Sub
    Public Sub INICIO()
        Try
            If (_Modo = 0) Then
                toolEliminar.Visible = False
                ToolStripButton3.Enabled = True
                ToolStrip2.Enabled = True
                Me.ToolStrip4.Enabled = True
                Me.CargarTipoExpediente(1)
                Me.cboTipoExpediente.SelectedValue = 12
                Me.txtCuit.Text = ""
                Me.txtRazonSocial.Text = ""
                Me.txtRazonSocial.Visible = True
                txtImporteOtros.Text = "0,00"
                txtCotMoneda.Text = "0,0000"
                Me.txtRazonSocial.Enabled = True
                Me.txtCuit.Enabled = True
                Me.codproveedor = 0
                Me.txtObservacionesConceptos.Text = ""
                Me._cdComprobante = 0
                Me._cdConcepto = 0
                Me._cdExterior = 0
                Me.txtcdNroExpedienteRel.Text = ""
                Me.txtNroExpedienteRel.Text = ""
                Me.gbxComprobantesRel.Visible = False
                Me._cdMoneda = 0
                _cdPerio = 0 = 0
                Me.txtcdNroExpedienteRel.Text = 0
                Me.txtNroExpedienteRel.Text = ""
                Me.txtNroExpedienteRel.Enabled = True
                Me._cdTipo = 0
                Me._cdTipoPer = 0
                Me._codproveedor = 0
                If (Me.chkExterior.Checked = True) Then
                    _cdExterior = 1
                Else
                    _cdExterior = 0
                End If
                txtCotMoneda.Text = "0,0000"

                Me.cmdPeriodicidadC.Visible = True
                Me.dtFechaDesde.Visible = False
                Me.dtFechaHasta.Visible = False
                Me.lblFechaDesdeC.Visible = False
                Me.lblFechaHastaC.Visible = False
                Me.txtRazonSocial.Visible = True
                CargarAreasNombre("")
                CargarAreasNombre("segunda")
                Me.TabCabecera.Text = "Ingresar Nuevo expediente"
                lblNroExpedienteV.Visible = False
                lblFechaV.Visible = False
                Me.pnlProv.Visible = False
                Me.pnlValores.Visible = False
                lblProveedorV.Visible = False
                Me.pnlProv.Visible = False
                lblImpP.Visible = False
                Label1.Visible = False
                Me.pnlValores.Visible = False
                lblImpD.Visible = False
                lblImporteD.Visible = False
                lblImpE.Visible = False
                lblCHF.Visible = False
                lblImporteE.Visible = False
                Me.lblFs.Visible = False
                Me.lblMensajeIngNuevo.Visible = True
                lblMensajeModificar.Visible = False
                AutoCompletarProveedores_Organismo(-1)
                Me.CargarMonedas(-1)
                Me.gbxComprobantesRel.Visible = False

            End If
            If (_Modo = 2) Then
                ToolStripButton3.Enabled = False
                Me.TabCabecera.Text = "Modificar expediente"
                Me.cmdPeriodicidadC.Visible = True
                Me.dtFechaDesde.Visible = False
                Me.dtFechaHasta.Visible = False
                Me.lblFechaDesdeC.Visible = False
                Me.lblFechaHastaC.Visible = False
                Me.txtRazonSocial.Visible = True
                CargarAreasNombre("")
                CargarAreasNombre("segunda")
                ToolStrip2.Enabled = False
                Me.ToolStrip4.Enabled = False
                Me.CargarTipoExpediente(1)
                Me.txtNroBeneficiario.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtRazonSocial.Enabled = False
                ToolStripModificar.Enabled = True
                ToolStripButton3.Enabled = True
                ToolStripNuevo.Enabled = False
                If (Me.chkExterior.Checked = True) Then
                    _cdExterior = 1
                Else
                    _cdExterior = 0
                End If
                CargarGrillaConceptos()
                If (dsNroRel <> "") Then
                    Dim d As New DataSet
                    d = WS.Obtener_codExpediente(dsNroRel)
                    If (d.Tables(0).Rows().Count > 0) Then
                        If (d.Tables(0).Rows(0).Item("cdExpediente") <> _cdExpediente) Then
                            Me.txtcdNroExpedienteRel.Text = d.Tables(0).Rows(0).Item("cdExpediente")
                            '      Me.lblExpedienteAnexado.Text = "Expediente Anexado Nro." + Me.txtNroExpedienteRel.Text
                        End If
                    End If
                End If
                Me.cboTipoExpediente.SelectedValue = Me._cdTipo
                AgregarDatosGrilla_ConveniosOtros(Me.cboTipoExpediente.SelectedValue)
                Dim pcdExp As Integer
                pcdExp = Me.txtcdNroExpedienteRel.Text


                Me.txtNroExpedienteRel.Enabled = False

                Me.cboTipoExpediente.Enabled = False
                Me.chkExterior.Enabled = False
                Me.txtNroExpediente.Enabled = False

                toolEliminar.Visible = False
                Dim ds As DataSet
                ds = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
                If (ds.Tables(0).Rows().Count > 0) Then
                    Me.dt.Value = ds.Tables(0).Rows(0).Item("dtFecha").ToString()
                    Me.lblFechaV.Text = ds.Tables(0).Rows(0).Item("dtFecha").ToString()

                    Me.rhcObservacionesE.Text = ds.Tables(0).Rows(0).Item("sObservacion").ToString()

                    codAreaE = ds.Tables(0).Rows(0).Item("cdAreaGasto").ToString()
                    Me.mtxtAreaE.Text = ds.Tables(0).Rows(0).Item("dsArea").ToString()
                    Me._cdExpediente = ds.Tables(0).Rows(0).Item("cdExpediente").ToString()
                    Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                    Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                    Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                    Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor").ToString()
                    If (ds.Tables(0).Rows(0).Item("cdEsExterior").ToString() = 0) Then
                        Me.chkExterior.Checked = False
                    Else
                        Me.chkExterior.Checked = True
                    End If
                    Me.txtcdExpediente.Text = Me._cdExpediente
                    TraerUltimoEstado(Me.txtcdExpediente.Text)
                End If
                If (ds.Tables(1).Rows().Count > 0) Then
                    Me.txtcdSolicitud.Text = ds.Tables(1).Rows(0).Item("cdSolicitud").ToString()

                    Me.rhcObservacionesE.Text = ds.Tables(1).Rows(0).Item("dsSolicitud").ToString() + " " + ds.Tables(0).Rows(0).Item("sObservacion").ToString()
                    CargarEstadosSolicitudes()
                End If

                If (ds.Tables(0).Rows(0).Item("dsExpAnexados").ToString() <> "") Then
                    Me.lblExpedienteAnexado.Text = "Expedientes Anexados: " + ds.Tables(0).Rows(0).Item("dsExpAnexados").ToString()
                Else
                    Me.lblExpedienteAnexado.Text = "Sin Expediente Anexado"
                End If



                Me.lblMensajeIngNuevo.Visible = False
                lblNroExpedienteV.Visible = True

                lblFechaV.Visible = True
                Me.pnlProv.Visible = True
                Me.pnlValores.Visible = True
                lblProveedorV.Visible = True
                lblImpP.Visible = True
                Label1.Visible = True
                lblImpD.Visible = True
                lblImporteD.Visible = True
                lblImpE.Visible = True
                lblCHF.Visible = True
                lblImporteE.Visible = True
                Me.lblFs.Visible = True
                Me.CargarEstadosSeguimiento()
                cmdModificarExp.Enabled = True
                btnAgregarCabecera.Enabled = False
                Me.ToolStripModificar.Enabled = True
                Me.ToolStripNuevo.Enabled = True
                AutoCompletarProveedores_Organismo(-1)
            End If
            If (_Modo = 3) Then
                ToolStripButton3.Enabled = False
                Me.lblMensajeIngNuevo.Visible = False
                toolEliminar.Visible = True
                Me.cmdPeriodicidadC.Visible = True
                Me.dtFechaDesde.Visible = False
                Me.dtFechaHasta.Visible = False
                Me.lblFechaDesdeC.Visible = False
                Me.lblFechaHastaC.Visible = False
                Me.txtRazonSocial.Visible = True
                CargarAreasNombre("")
                CargarAreasNombre("segunda")
                ToolStrip2.Enabled = False
                Me.ToolStrip4.Enabled = False
                Me.CargarTipoExpediente(1)
                '   CargarTipoPeriodicidad_Otros(-1)
                If (Me.chkExterior.Checked = True) Then
                    _cdExterior = 1
                Else
                    _cdExterior = 0
                End If

                CargarGrillaConceptos()
                Me.cboTipoExpediente.SelectedValue = Me._cdTipo
                AgregarDatosGrilla_ConveniosOtros(Me.cboTipoExpediente.SelectedValue)
                TraerUltimoEstado(_cdExpediente)
                Me.cboTipoExpediente.Enabled = False
                Me.chkExterior.Enabled = False
                Me.txtNroExpediente.Enabled = False
                Me.cmdModificarConvenio.Enabled = False
                Me.dgvSeguimiento.Enabled = False
                Me.dgvlistado.Enabled = False
                Me.dgvConceptos.Enabled = False
                Me.cmdModificarComprobante.Enabled = False
                Me.cmdAgregarComp.Enabled = False
                Me.cmdGuardarConvenio.Enabled = False
                Me.cmdAgregarConcepto.Enabled = False
                Me.cmdSeguimiento.Enabled = False
                CargarEstadosSeguimiento()
                Me.btnAgregarCabecera.Enabled = False
                AutoCompletarProveedores_Organismo(-1)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub
    Sub CargarTipoExpediente(ByVal int As Integer)
        Try

            Dim ds As DataSet
            ds = WS.Obtener_TipoExpediente(int)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.cboTipoExpediente.DisplayMember = "dsValor"
                Me.cboTipoExpediente.ValueMember = "cdValor"
                Me.cboTipoExpediente.DataSource = ds.Tables(0)
            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub cargarUnidades()
        Me.ListAreas = New List(Of clsAreas)
        bsArea = New BindingSource(Me.ListAreas, "")
        Me.dgvUnidad.DataSource = bsArea
        If ((Me.cboTipoExpediente.SelectedValue = 12) Or (Me.cboTipoExpediente.SelectedValue = 21) Or (Me.cboTipoExpediente.SelectedValue = 22)) Then
            If (Me.dgvlistado.Rows.Count > 0) Then
                Dim d As New DataSet
                Dim dt As New DataTable
                Dim i As Integer
                d = WS.Obtener_ComprobantesAsociados(_cdExpediente, 1)
                For i = 0 To d.Tables(0).Rows.Count - 1
                    Dim oclsA As New clsAreas
                    oclsA.cdArea = d.Tables(0).Rows(i).Item("cdUnidad")
                    oclsA.monto = d.Tables(0).Rows(i).Item("column1").ToString()
                    oclsA.dsArea = d.Tables(0).Rows(i).Item("dsArea")
                    ListAreas.Add(oclsA)
                    bsArea.ResetBindings(False)
                Next
            End If
        End If
        'If (Me.cboTipoExpediente.SelectedValue <> 12) Then
        '    Dim d As New DataSet
        '    Dim dt1 As New DataTable
        '    Dim dt As New DataTable
        '    Dim dr As New clsAreas
        '    Dim i As Integer
        '    d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 1)
        '    For i = 0 To d.Tables(0).Rows.Count - 1
        '        Dim oclsA As New clsAreas
        '        oclsA.cdArea = d.Tables(0).Rows(i).Item("cdUnidadReq")
        '        oclsA.monto = d.Tables(0).Rows(i).Item("column1")
        '        oclsA.dsArea = d.Tables(0).Rows(i).Item("dsArea")
        '        ListAreas.Add(oclsA)
        '        bsArea.ResetBindings(False)
        '    Next
        'End If
    End Sub
    Public Sub CargarProveedor()
        Try
            Dim arrProv As New List(Of clsProveedores)
            If (Me.codproveedor <> 0) Then
                oclsProv.cdProveedor = codproveedor
                _TipoProv = 1
            Else
                _TipoProv = 0
            End If
            oclsProv.dsNroDocumento = Me.txtCuit.Text
            oclsProv.dsRazonSocial = Me.txtRazonSocial.Text
            oclsProv.dsNroBeneficiario = Me.txtNroBeneficiario.Text
            If (Me.chkExterior.Checked = True) Then
                _cdExterior = 1
            Else
                _cdExterior = 0
            End If
            oclsProv.cdExterior = _cdExterior
            arrProv.Add(oclsProv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarEstadosSeguimiento()
        Try
            ListS = New List(Of clsSeguimientoExpedientes)
            bsS = New BindingSource(ListS, "")
            Me.dgvSeguimiento.DataSource = bsS

            Dim ds As New DataSet
            ds = WS.OBTENER_ESTADOS_ByEXPEDIENTE(_cdExpediente)
            If (ds.Tables(0).Rows.Count > 0) Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim oclsSE As New clsSeguimientoExpedientes()
                    oclsSE.codSeguimiento = ds.Tables(0).Rows(i).Item("codSeguimiento")
                    oclsSE.codExpediente = ds.Tables(0).Rows(i).Item("codExpediente")
                    oclsSE.cdEstado = ds.Tables(0).Rows(i).Item("cdEstado")
                    oclsSE.dsEstado = ds.Tables(0).Rows(i).Item("dsEstado")
                    oclsSE.dtFecha = ds.Tables(0).Rows(i).Item("dtFecha")
                    oclsSE.cdArea = ds.Tables(0).Rows(i).Item("cdArea")
                    oclsSE.dsArea = ds.Tables(0).Rows(i).Item("dsArea")
                    oclsSE.cdBaja = ds.Tables(0).Rows(i).Item("cdBaja")
                    oclsSE.sObservaciones = ds.Tables(0).Rows(i).Item("sObservaciones").ToString()
                    oclsSE.cdEtapa = ds.Tables(0).Rows(i).Item("cdEtapa")
                    oclsSE.dsEtapa = ds.Tables(0).Rows(i).Item("dsEtapa")
                    ListS.Add(oclsSE)
                    bsS.ResetBindings(False)
                Next
            Else
                ListS = New List(Of clsSeguimientoExpedientes)
                bsS = New BindingSource(ListS, "")
                Me.dgvSeguimiento.DataSource = bsS
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarEstadosSolicitudes()
        Dim dsSol As New DataSet
        ListSol = New List(Of ClsSolicitudes)
        bsSol = New BindingSource(ListSol, "")
        Me.dgvSolicitudes.DataSource = bsSol
        dsSol = WS.Obtener_codExpediente(Me.txtNroExpediente.Text)
        If (dsSol.Tables(1).Rows.Count > 0) Then
            For i As Integer = 0 To dsSol.Tables(1).Rows.Count - 1
                Dim oclsSol As New ClsSolicitudes()
                oclsSol.cdSolicitud = dsSol.Tables(1).Rows(i).Item("cdSolicitud")
                oclsSol.dsSolicitud = dsSol.Tables(1).Rows(i).Item("dsSolicitud")
                oclsSol.dsNroExpSolicitud = dsSol.Tables(1).Rows(i).Item("dsNroExpSolicitud")
                oclsSol.dtSolicitud = dsSol.Tables(1).Rows(i).Item("dtSolicitud")
                oclsSol.cdSolicitudEstado = dsSol.Tables(1).Rows(i).Item("cdSolicitudEstado")
                oclsSol.dsEstado = dsSol.Tables(1).Rows(i).Item("dsEstado")
                oclsSol.dsObservaciones = dsSol.Tables(1).Rows(i).Item("dsObservaciones").ToString()

                ListSol.Add(oclsSol)
                bsSol.ResetBindings(False)

            Next
            Me.dgvSolicitudes.DataSource = bsSol
        Else
            ListSol = New List(Of ClsSolicitudes)
            bsSol = New BindingSource(ListS, "")
            Me.dgvSolicitudes.DataSource = bsS
        End If
    End Sub

    Public Function ValidaExpediente() As Boolean
        If (Me.codproveedor <> 0 And Me.txtNroExpediente.Text <> "") Then
            If (Me.dgvSeguimiento.Rows.Count > 0) Then
                Dim d As New DataSet
                d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
                If (d.Tables(0).Rows().Count > 0) Then
                    Me._cdExpediente = d.Tables(0).Rows(0).Item("cdExpediente")
                    Me.txtcdExpediente.Text = _cdExpediente
                    Return True
                Else
                    bs = New BindingSource(List, "")
                    Me.dgvSeguimiento.DataSource = bs
                    Me.txtRazonSocial.Enabled = True
                    Me.txtCuit.Enabled = True
                    Me.CargarTipoExpediente(1)
                    mtxtAreaE.Enabled = True
                    Me.rhcObservacionesE.Enabled = True
                    Me.dt.Enabled = True
                    Me.cboTipoExpediente.Enabled = True
                    Me.txtNroExpediente.Enabled = True
                    Me.TabAreas.Parent = Nothing
                    Me.TabConceptos.Parent = Nothing
                    Me.TabSeguimiento.Parent = Nothing
                    Me.TabComprobantes.Parent = Nothing
                    Return False
                    Exit Function
                End If
            Else
                Dim d As New DataSet
                Dim i As Integer
                d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
                If (d.Tables(0).Rows().Count > 0) Then
                    Me._cdExpediente = d.Tables(0).Rows(i).Item("cdExpediente")
                    Me.txtcdExpediente.Text = Me._cdExpediente
                    '   CargarEstadosSeguimiento(1)
                    Return True
                Else
                    Me._cdExpediente = 0
                    Me.txtcdExpediente.Text = ""
                    bs = New BindingSource(List, "")
                    Me.dgvSeguimiento.DataSource = bs
                    Me.txtRazonSocial.Enabled = True
                    Me.txtCuit.Enabled = True
                    mtxtAreaE.Enabled = True
                    Me.rhcObservacionesE.Enabled = True
                    Me.dt.Enabled = True
                    Me.cboTipoExpediente.Enabled = True
                    Me.txtNroExpediente.Enabled = True
                    Me.TabAreas.Parent = Nothing
                    Me.TabConceptos.Parent = Nothing
                    Me.TabSeguimiento.Parent = Nothing
                    Me.TabComprobantes.Parent = Nothing
                    Return False
                    Exit Function
                End If
            End If
        Else
            Return False
            Exit Function
        End If
        Return True
    End Function
    Public Sub AgruparImporte_PorMoneda(ByVal intMoneda As Integer, ByVal cdRelacion As Integer)
        Dim d As DataSet
        Dim i As Integer
        vlPesos = New Boolean
        vlDolares = New Boolean
        vlEuros = New Boolean
        vlFrancoS = New Boolean


        Me.Label1.Text = "$0,00"
        lblIValormporpesosVC.Text = "$0,00"
        Me.lblImporteD.Text = "0,000"
        Me.lblImporteE.Text = "0,000"
        lblIValormporpesosVC.Text = "0,00"
        Me.lblFs.Text = "0,000"
        If (Me.cboTipoExpediente.SelectedValue = 12 Or Me.cboTipoExpediente.SelectedValue = 21 Or Me.cboTipoExpediente.SelectedValue = 22) Then

            d = WS.Obtener_ComprobantesTodos(_cdExpediente)
            For i = 0 To d.Tables(0).Rows.Count - 1
                Dim SigP As String = "$"
                Dim cdtipomoneda As Integer
                cdtipomoneda = d.Tables(0).Rows(i).Item("cdMoneda")
                If (cdtipomoneda = 1 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then
                    If (d.Tables(0).Rows(i).Item("cdClaseComprobante") = 3) Then

                        vlPesos = (vlPesos - d.Tables(0).Rows(i).Item("vlImporteC"))

                        Me.Label1.Text = vlPesos
                    Else

                        vlPesos = (vlPesos + d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.Label1.Text = vlPesos
                    End If
                End If
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 2 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then
                    If (d.Tables(0).Rows(i).Item("cdClaseComprobante") = 3) Then
                        vlDolares = (vlDolares - d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblImporteD.Text = vlDolares
                    Else
                        vlDolares = (vlDolares + d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblImporteD.Text = vlDolares
                    End If
                End If
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 3 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then
                    If (d.Tables(0).Rows(i).Item("cdClaseComprobante") = 3) Then
                        vlEuros = (vlEuros - d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblImporteE.Text = vlEuros
                        '   lblImporteValorEurosVC.Text = vlEuros
                    Else
                        vlEuros = (vlEuros + d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblImporteE.Text = vlEuros
                        '  lblImporteValorEurosVC.Text = vlEuros
                    End If
                End If

                If (d.Tables(0).Rows(i).Item("cdMoneda") = 4 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then
                    If (d.Tables(0).Rows(i).Item("cdClaseComprobante") = 3) Then
                        vlFrancoS = (vlFrancoS - d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblFs.Text = vlFrancoS

                    Else
                        vlFrancoS = (vlFrancoS + d.Tables(0).Rows(i).Item("vlImporteC"))
                        Me.lblFs.Text = vlFrancoS

                    End If
                End If


            Next
        End If
        If (Me.cboTipoExpediente.SelectedValue <> 12) Then
            d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
            For i = 0 To d.Tables(0).Rows.Count - 1
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 1 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then

                    vlPesos = vlPesos + d.Tables(0).Rows(i).Item("vlImporte")
                    Me.Label1.Text = vlPesos
                End If
            Next
            d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
            For i = 0 To d.Tables(0).Rows.Count - 1
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 2 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then

                    vlDolares = (vlPesos + d.Tables(0).Rows(i).Item("vlImporte"))
                    Me.lblImporteD.Text = vlDolares
                End If
            Next
            d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
            For i = 0 To d.Tables(0).Rows.Count - 1
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 3 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then

                    vlEuros = (vlPesos + d.Tables(0).Rows(i).Item("vlImporte"))
                    Me.lblImporteE.Text = vlEuros
                End If
            Next
            d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
            For i = 0 To d.Tables(0).Rows.Count - 1
                If (d.Tables(0).Rows(i).Item("cdMoneda") = 4 And d.Tables(0).Rows(i).Item("cdDesglosado") = 0) Then

                    Me.vlFrancoS = (vlPesos + d.Tables(0).Rows(i).Item("vlImporte"))
                    Me.lblFs.Text = vlFrancoS
                End If
            Next
        End If
    End Sub
    Public Sub CargarMovimiento()
        Try

            Dim arr As New List(Of clsSeguimientoExpedientes)
            oclsMov.codSeguimiento = 0
            oclsMov.codExpediente = Me._cdExpediente
            oclsMov.cdEstado = 1
            oclsMov.dtFecha = dt.Value
            oclsMov.sObservaciones = ""
            oclsMov.cdArea = codAreaE
            oclsMov.cdBaja = 0
            arr.Add(oclsMov)
            oclsMov.ArraS = arr
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
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
#End Region
    Private Sub btnNuevoComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (ValidaCampos() = True) Then
                MessageBox.Show("ValidacionCorrecta")
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CambioColorFontGrilla()

        With Me.dgvComprobantesVer
            .ForeColor = Color.Black
        End With
        With Me.dgvlistado
            .ForeColor = Color.Black
        End With
    End Sub
    Public Sub frmIngresarExpedientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objLoad = sender
            e = e
            If (Me.chkExterior.Checked = True) Then
                _Chk = 1
            Else
                _Chk = 0
            End If
            CambioColorFontGrilla()
            Me.cmdAgregarComp.Visible = True


            bsSol = New BindingSource(ListSol, "")
            Me.dgvSolicitudes.DataSource = bsSol
            bsS = New BindingSource(ListS, "")
            Me.dgvSeguimiento.DataSource = bsS
            bs = New BindingSource(List, "")
            Me.dgvlistado.DataSource = bs

            bsConcepto = New BindingSource(ListConcepto, "")
            Me.dgvConceptos.DataSource = bsConcepto
            bsArea = New BindingSource(ListAreas, "")
            Me.dgvUnidad.DataSource = bsArea
            Me.txtNroExpediente.Enabled = True
            Me.cboTipoExpediente.Enabled = True

            Me.TabAreas.Parent = Nothing
            Me.TabConceptos.Parent = Nothing
            Me.TabSeguimiento.Parent = Nothing
            Me.TabComprobantes.Parent = Nothing
            Me.TabComprobantes.BackColor = Color.DarkGray
            Me.TabConceptos.BackColor = Color.DarkGray
            Me.TabSeguimiento.BackColor = Color.DarkGray
            Me.TabCabecera.BackColor = Color.DarkGray
            INICIO()
            'Me.gbxCabecera.Visible = False
            'Me.TabSolapas.Location = New Point(1, 30)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ofrmCon As New frmConsultayModificaciondeExpedientes()
        '     Dim ofmC As New frmConsultayModificacionComprobantes()
        If (_Formulario = 4) Then
            ofrmCon.MdiParent = frmMenu
            ofrmCon.StartPosition = FormStartPosition.Manual
            Me.AutoScroll = False
            Me.Close()
            ofrmCon.Show()
        End If
        If (_Formulario = 3) Then
            Me.Close()
        End If
        If (_Formulario = 2) Then
            ofrmCon.MdiParent = frmMenu
            ofrmCon.StartPosition = FormStartPosition.Manual
            Me.AutoScroll = False
            ' ofmC.Show()
            Me.Close()
        End If
    End Sub
    Private Sub txtRazonSocial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Leave
        Try

            CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)

            '  Me.AutoCompletarProveedores_Organismo(-1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.txtRazonSocial.Text = ""
            Me.txtCuit.Text = ""
            Me.txtNroExpediente.Text = ""
            dt.Value = Today
            dt.Checked = False
            codproveedor = 0
            Me.AutoCompletarProveedor(-1)
            Me.dgvlistado.Rows.Clear()
            bs = New BindingSource(List, "")
            Me.dgvlistado.DataSource = bs
            '  Me.txtComprobantesAsociados.Text = ""
            Me._cdExpediente = 0
            Me.txtcdExpediente.Text = ""
            Me._Tipo = 0
            _Modo = 0
            codArea = 0
            '  Me.txtcdComp.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvlistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlistado.CellContentClick
        If e.ColumnIndex = Me.colver.Index Then
            Me.cmdModificarComprobante.Enabled = True
            '    Me.cmdAgregarComp.Location = New Point(383, 427)
            _dsNroComp = Me.dgvlistado.Rows(e.RowIndex).Cells("dsComprobante").Value.ToString()
            Me.lblNroComprobanteVC.Text = "Comprobante: " + dgvlistado.Rows(e.RowIndex).Cells("dsAbreviatura").Value.ToString() + "   " + dgvlistado.Rows(e.RowIndex).Cells("dsTipoComprobante").Value.ToString() + "   " + _dsNroComp  'Me.dgvlistado.Rows(e.RowIndex).Cells("dsComprobante").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
            Dim st As String
            st = "Fecha: " + Me.dgvlistado.Rows(e.RowIndex).Cells("dtFecha").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
            Me.lblFechaVC.Text = st
            'Me.lblFechaVC.Text = lblFechaVC.Text.ToString("yyyyMMdd")
            ' Me.lblClaseComprobanteVC.Text = "Clase de comprobante " + Me.dgvlistado.Rows(e.RowIndex).Cells("dsClaseComprobante").Value.ToString()
            Me.lblCotizacionVC.Text = "Tipo de comprobante " + Me.dgvlistado.Rows(e.RowIndex).Cells("dsTipoComprobante").Value.ToString()
            '  Me.lblMonedaVC.Text = Me.dgvlistado.Rows(e.RowIndex).Cells("dsMoneda").Value.ToString()
            If (Me.dgvlistado.Rows(e.RowIndex).Cells("dsMoneda").Value.ToString() = "Pesos") Then
                Me.lblImporteCV.Text = "El importe: $" + Me.dgvlistado.Rows(e.RowIndex).Cells("monto").Value.ToString()
            End If
            If (Me.dgvlistado.Rows(e.RowIndex).Cells("dsMoneda").Value.ToString() = "Dólar") Then
                Me.lblImporteCV.Text = "El importe: U$S" + Me.dgvlistado.Rows(e.RowIndex).Cells("monto").Value.ToString()
            End If
            If (Me.dgvlistado.Rows(e.RowIndex).Cells("dsMoneda").Value.ToString() = "Euros") Then
                Me.lblImporteCV.Text = "El importe: €" + Me.dgvlistado.Rows(e.RowIndex).Cells("monto").Value.ToString()
            End If
            If (Me.dgvlistado.Rows(e.RowIndex).Cells("dsMoneda").Value.ToString() = "Francos Suizos") Then
                Me.lblImporteCV.Text = "El importe: CHF" + Me.dgvlistado.Rows(e.RowIndex).Cells("monto").Value.ToString()
            End If

            cdDesg = Me.dgvlistado.Rows(e.RowIndex).Cells("escdDesglose").Value.ToString()
            '  Me.lblPeriodicidadVC.Text = ""Me.dgvlistado.Rows(e.RowIndex).Cells("dsPerio").Value.ToString()
            _intcdComprobante = Me.dgvlistado.Rows(e.RowIndex).Cells("codComprobante").Value.ToString()
            _dsNroComp = Me.dgvlistado.Rows(e.RowIndex).Cells("dsComprobante").Value.ToString()

            Me._cdClaseC = Me.dgvlistado.Rows(e.RowIndex).Cells("cdClaseComp").Value.ToString()
            _cdTipo = Me.dgvlistado.Rows(e.RowIndex).Cells("cdTipoC").Value.ToString()

            If (dgvlistado.Rows(e.RowIndex).Cells("vlCotizacion").Value.ToString() = "$0,000") Then
                lblCotizacionVC.Text = "Cotización: No aplica a pesos"
            Else
                lblCotizacionVC.Text = "Cotización: " + FormatNumber(dgvlistado.Rows(e.RowIndex).Cells("vlCotizacion").Value.ToString(), 4)

            End If
            Me.lblAreaVC.Text = "Area: " + dgvlistado.Rows(e.RowIndex).Cells("dsUnidad").Value.ToString()
            grbComprobante.Visible = True


        End If
        If e.ColumnIndex = Me._Eliminar.Index Then
            _dsNroComp = Me.dgvlistado.Rows(e.RowIndex).Cells("dsComprobante").Value.ToString()
            _intcdComprobante = Me.dgvlistado.Rows(e.RowIndex).Cells("codComprobante").Value.ToString()
            _dsNroComp = Me.dgvlistado.Rows(e.RowIndex).Cells("dsComprobante").Value.ToString()
            Me._cdClaseC = Me.dgvlistado.Rows(e.RowIndex).Cells("cdClaseComp").Value.ToString()
            _cdTipo = Me.dgvlistado.Rows(e.RowIndex).Cells("cdTipoC").Value.ToString()
            grbComprobante.Visible = True
            Dim ofrm As New frmIngresodeComprobantesOtros()
            ofrm.intExp = Me._cdExpediente
            cdDesg = Me.dgvlistado.Rows(e.RowIndex).Cells("escdDesglose").Value.ToString()
            ofrm._codproveedor = Me.codproveedor
            _TipoExpediente = 2
            ofrm.intExp = Me._cdExpediente
            ofrm._cdComprobante = _intcdComprobante
            ofrm.txtNroComprobante.Text = _dsNroComp
            ofrm._EsExterior = Me.dgvlistado.Rows(e.RowIndex).Cells("cdTipoC").Value.ToString()
            ofrm._cdClaseC = _cdClaseC
            ofrm._cdTipoC = _cdTipo
            ofrm._checked = cdDesg
            ofrm._cdComprobante = _intcdComprobante
            ofrm.ShowDialog()
            grbComprobante.Visible = False
            AgregarDatosGrilla_ConveniosOtros(12)
            cargarUnidades()
            Me.cmdModificarComprobante.Enabled = False
            ofrm = Nothing
        End If
    End Sub
    Private Sub txtNroExpediente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroExpediente.Validated
        Try
            If (_Modo = 0) Then
                If (Me.txtNroExpediente.Text = "") Then ' And codproveedor = 0) Then
                    Me.txtRazonSocial.Enabled = True
                    Me.txtCuit.Enabled = True
                    ListS = New List(Of clsSeguimientoExpedientes)
                    bsS = New BindingSource(ListS, "")
                    Me.dgvSeguimiento.DataSource = bsS

                    ListSol = New List(Of ClsSolicitudes)
                    bsSol = New BindingSource(ListSol, "")
                    Me.dgvSolicitudes.DataSource = bsSol
                Else
                    Me.TraerCA_Por_Expediente()
                    If (ValidaExpediente() = True) Then
                        gxpDatosExpediente.Enabled = False
                        cmdModificarExp.Visible = True
                        cmdModificarExp.Enabled = True
                        Me.lblMensajeModificar.Visible = True
                        btnAgregarCabecera.Enabled = False
                        CargarEstadosSeguimiento()
                        lblNroExpedienteV.Visible = True
                        Me.pnlValores.Visible = True
                        Me.pnlProv.Visible = True
                        lblFechaV.Visible = True
                        lblProveedorV.Visible = True
                        lblImpP.Visible = True
                        Label1.Visible = True
                        lblImpD.Visible = True
                        lblImporteD.Visible = True
                        lblImpE.Visible = True
                        lblCHF.Visible = True
                        lblImporteE.Visible = True
                        Me.lblFs.Visible = True
                        Me.lblMensajeIngNuevo.Visible = False
                        bsS = New BindingSource(ListS, "")
                        Me.dgvSeguimiento.DataSource = bsS


                        bsSol = New BindingSource(ListSol, "")
                        Me.dgvSolicitudes.DataSource = bsSol


                        Me.ToolStripModificar.Enabled = True
                    Else
                        gxpDatosExpediente.Enabled = True

                        ListS = New List(Of clsSeguimientoExpedientes)
                        bsS = New BindingSource(ListS, "")
                        Me.dgvSeguimiento.DataSource = bsS

                        ''ListSol = New List(Of ClsSolicitudes)
                        ''bsSol = New BindingSource(ListSol, "")
                        ''Me.dgvSolicitudes.DataSource = bsSol

                        cmdModificarExp.Visible = False
                        lblNroExpedienteV.Visible = False
                        lblFechaV.Visible = False
                        Me.pnlProv.Visible = False
                        Me.pnlValores.Visible = False
                        lblProveedorV.Visible = False
                        lblImpP.Visible = False
                        Label1.Visible = False
                        lblImpD.Visible = False
                        lblImporteD.Visible = False
                        lblImpE.Visible = False
                        lblCHF.Visible = False
                        lblImporteE.Visible = False
                        Me.lblFs.Visible = False
                        Me.lblMensajeIngNuevo.Visible = True
                    End If

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub ToolDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim icom As Integer
    '        If (Me.dgvlistado.Rows.Count > 0) Then
    '            icom = 1
    '        Else
    '            icom = 0
    '        End If
    '        If (Me.dgvlistado.Rows.Count > 0) Then
    '            Dim res As DialogResult = MsgBox("EL EXPEDIENTE TIENE COMPROBANTES ASOCIADOS, ¿DESEA ELIMINARLO DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
    '            If (res = Windows.Forms.DialogResult.Yes) Then

    '                WS.Delete_Expedientes(Me._cdExpediente, icom, intError)
    '                MessageBox.Show("El expediente se elimino correctamente")
    '                _Modo = 0
    '                LimpiarDatos()
    '                If (_Formulario = 4) Then
    '                    Dim ofrmCon As New frmConsultayModificaciondeExpedientes
    '                    ofrmCon.MdiParent = frmMenu
    '                    ofrmCon.StartPosition = FormStartPosition.Manual
    '                    Me.AutoScroll = False
    '                    Me.Close()
    '                    ofrmCon.Show()
    '                End If
    '            End If
    '        Else
    '            WS.Delete_Expedientes(Me._cdExpediente, icom, intError)
    '            MessageBox.Show("El expediente se elimino correctamente")
    '            _Modo = 0
    '            LimpiarDatos()
    '            If (_Formulario = 4) Then
    '                Dim ofrmCon As New frmConsultayModificaciondeExpedientes
    '                ofrmCon.MdiParent = frmMenu
    '                ofrmCon.StartPosition = FormStartPosition.Manual
    '                Me.AutoScroll = False
    '                Me.Close()
    '                ofrmCon.Show()
    '            End If

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub txtCuit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuit.Leave
        Try

            If (Me.txtCuit.Text = "" Or Me.txtRazonSocial.Text = "") Then
                Me.codproveedor = 0
            End If
            If (Me.txtRazonSocial.Text = "" And Me.txtCuit.Text <> "") Then
                If (Me.chkExterior.Checked = True) Then
                Else
                    verifica_cuit(txtCuit.Text)
                End If
                Dim ds As New DataSet
                ds = WS.Obtener_Proveedores_Bycuit(Me.txtCuit.Text, "")
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
                Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor")
                Me.txtRazonSocial.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                ' ToolStripAgregar.Enabled = False
                ToolStripModificar.Enabled = True
                Me.ToolStripNuevo.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboTipoExpediente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoExpediente.SelectedIndexChanged
        Try

            If (Me.cboTipoExpediente.SelectedValue = 11) Then
                Me.TabComprobantes.Text = "Convenio"
                Me.lblNroExpedienteRelacionado.Visible = False
                Me.txtNroExpedienteRel.Visible = False
            End If
            If ((Me.cboTipoExpediente.SelectedValue = 12) Or (Me.cboTipoExpediente.SelectedValue = 21) Or (Me.cboTipoExpediente.SelectedValue = 22) Or (Me.cboTipoExpediente.SelectedValue = 24)) Then
                Me.TabComprobantes.Text = "Comprobantes"
                Me.lblNroExpedienteRelacionado.Visible = True
                Me.txtNroExpedienteRel.Visible = True
            End If
            If (Me.cboTipoExpediente.SelectedValue = 13) Then
                Me.TabComprobantes.Text = "Otros"
                Me.lblNroExpedienteRelacionado.Visible = False
                Me.txtNroExpedienteRel.Visible = False
            End If

            'If (_Edit = 1) Then
            '    If (Me.cboTipoExpediente.SelectedValue = 11) Then
            '        Me.TabComprobantes.Text = "Convenio"
            '        CargarTipoPeriodicidad_Otros(-2)
            '        Me.txtNroConvenio.Text = ""
            '        Me.rchObservacionO.Text = ""
            '        Me.mtxtArea.Text = ""
            '        Me.txtObjeto.Text = ""
            '        Me.txtImporteOtros.Text = "0,00"
            '        Me.txtCotMoneda.Text = "0,000"
            '        Me.CargarMonedas(-1)

            '    End If
            '    If (Me.cboTipoExpediente.SelectedValue = 12) Then
            '        Me.TabComprobantes.Text = "Comprobantes"
            '        List = New List(Of clsComprobante)
            '        bs = New BindingSource(List, "")
            '        Me.dgvlistado.DataSource = bs

            '    End If
            '    If (Me.cboTipoExpediente.SelectedValue = 13) Then
            '        Me.TabComprobantes.Text = "Otros"
            '        CargarTipoPeriodicidad_Otros(-2)
            '        Me.txtNroConvenio.Text = ""
            '        Me.rchObservacionO.Text = ""
            '        Me.mtxtArea.Text = ""
            '        Me.txtObjeto.Text = ""
            '        Me.txtImporteOtros.Text = "0,00"
            '        Me.txtCotMoneda.Text = "0,000"
            '        Me.CargarMonedas(-1)


            '    End If
            ' End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtImpCompradorC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Try
                Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
                KeyAscii = CShort(SoloNumeros(KeyAscii))
                If KeyAscii = 0 Then
                    e.Handled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Try
                Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
                KeyAscii = CShort(SoloNumeros(KeyAscii))
                If KeyAscii = 0 Then
                    e.Handled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        Catch ex As Exception

        End Try
    End Sub
    'Private Sub txtImporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (IsNumeric(Me.txtImporte.Text)) Then
    '        txtImporte.Text = FormatNumber(txtImporte.Text, 3)
    '    End If
    'End Sub
    Private Sub btnDesactiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivarC.Click
        btnDesactivarC.Visible = False
        Me.cmdPeriodicidadC.Visible = True
        Me.dtFechaDesde.Visible = False
        Me.dtFechaHasta.Visible = False
        Me.lblFechaDesdeC.Visible = False
        Me.lblFechaHastaC.Visible = False
    End Sub
    Private Sub cmdPeriodicidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeriodicidadC.Click
        Me.cmdPeriodicidadC.Visible = False
        btnDesactivarC.Visible = True
        Me.dtFechaDesde.Visible = True
        Me.dtFechaHasta.Visible = True
        Me.lblFechaDesdeC.Visible = True
        Me.lblFechaHastaC.Visible = True
        Me.dtFechaDesde.Enabled = True
        Me.dtFechaHasta.Enabled = True
        If (Me.dtFechaDesde.Value = Today And Me.dtFechaHasta.Value = Today) Then
            Me.dtFechaDesde.Checked = False
            Me.dtFechaHasta.Checked = False
        End If
    End Sub
    'Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If (Me.cboMoneda.SelectedValue = 1) Then
    '            Me.txtCotizacion.Visible = False
    '            Me.lblCotizacion.Visible = False
    '        Else
    '            Me.txtCotizacion.Visible = True
    '            Me.lblCotizacion.Visible = True
    '            CargarCotizaciones(Me.cboMoneda.SelectedValue())
    '            ValidarCotizacion(Me.cboMoneda.SelectedValue(), Me.dt.Value)
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub
    Private Sub TabExpedientes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabComprobantes.Leave
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub txtImporteOtros_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (IsNumeric(Me.txtImporteOtros.Text)) Then
            txtImporteOtros.Text = FormatNumber(txtImporteOtros.Text, 3)
        End If
    End Sub
    Private Sub TabCabecera_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabCabecera.Leave
        Try
            If (Me.cboTipoExpediente.SelectedValue = 12) Then
                Me.TabComprobantes.Text = "Comprobantes"
                Me.grxObservacion.Visible = False
                'Me.grbComprobante.Visible = True
                Me.gbxDatosAsociados.Visible = True
                Me.gbxDatosAsociados.Location = New Point(3, 4)
                Me.txtNroConvenio.Text = ""
                Me.rchObservacionO.Text = ""
                mtxtArea.Text = ""
                Me.codArea = 0
                Me.txtObjeto.Text = ""
                Me.txtImporteOtros.Text = "0,0000"
                ' '  Me.cboTipoPeriodicidad.SelectedValue = 1
                ' Me.cboPeriodicidad.Text = "Sin Periodicidad"
                Me.lblFechaDesdeC.Visible = False
                Me.lblFechaHastaC.Visible = False
                Me.dtFechaDesde.Visible = False
                Me.dtFechaHasta.Visible = False
                Me.cmdAgregarComp.Visible = True
            End If
            If (Me.cboTipoExpediente.SelectedValue = 11) Then

                Me.TabComprobantes.Text = "Convenio"
                Me.grxObservacion.Visible = True
                Me.grbComprobante.Visible = False
                mtxtArea.Visible = True
                Me.lblUnidad.Visible = True
                Me.lblObjeto.Visible = True
                Me.txtObjeto.Visible = True
                Me.gbxDatosAsociados.Visible = False
                Me.grxObservacion.Location = New Point(3, 4)
                Me.txtNroConvenio.Visible = True
                Me.lblConvenio.Visible = True
                Me.lblConvenio.Location = New Point(12, 19)
                txtNroConvenio.Location = New Point(12, 35)
                Me.lblObservacionO.Location = New Point(12, 60)
                Me.rchObservacionO.Location = New Point(12, 81)
                Me.lblUnidad.Location = New Point(12, 247)
                mtxtArea.Location = New Point(12, 263)
                Me.lblObjeto.Location = New Point(12, 293)
                Me.txtObjeto.Location = New Point(12, 309)
                Me.lblImporteO.Location = New Point(12, 361)
                Me.txtImporteOtros.Location = New Point(12, 375)
                Me.lblCotizacion.Location = New Point(9, 447)
                Me.txtCotMoneda.Location = New Point(9, 463)
                Me.grpPeriodoServicio.Location = New Point(8, 493)
                Me.cmdModificarConvenio.Location = New Point(388, 575)
                Me.cmdGuardarConvenio.Location = New Point(428, 575)
                Me.Label5.Location = New Point(233, 361)
                Me.dtFechaC.Location = New Point(236, 375)

                If (Me.txtNroConvenio.Text = "" And mtxtArea.Text = "") Then
                    Me.txtCotMoneda.Visible = False
                    Me.lblCotizacion.Visible = False
                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
                    Me.txtImporteOtros.Text = "0,0000"
                    Me.txtCotMoneda.Text = "0,0000"
                End If
            End If
            If (Me.cboTipoExpediente.SelectedValue = 13) Then
                Me.TabComprobantes.Text = "Otros"
                Me.grxObservacion.Visible = True
                Me.grbComprobante.Visible = False
                Me.gbxDatosAsociados.Visible = False
                Me.txtObjeto.Visible = False
                Me.lblObjeto.Visible = False
                Me.lblConvenio.Visible = False
                Me.txtNroConvenio.Visible = False
                Me.grxObservacion.Location = New Point(3, 4)
                Me.lblObservacionO.Location = New Point(12, 19)
                Me.rchObservacionO.Location = New Point(12, 35)
                Me.lblImporteO.Visible = True
                Me.lblImporteO.Location = New Point(12, 288)
                Me.txtImporteOtros.Location = New Point(12, 302)
                Me.lblUnidad.Location = New Point(12, 244)
                mtxtArea.Location = New Point(12, 260)
                Me.Label5.Location = New Point(233, 288)
                Me.dtFechaC.Location = New Point(236, 302)
                Me.lblMoneda.Location = New Point(12, 334)
                Me.cboMoneda.Location = New Point(12, 350)
                Me.lblCotizacion.Location = New Point(12, 374)
                Me.txtCotMoneda.Location = New Point(12, 390)
                Me.grpPeriodoServicio.Location = New Point(4, 418)
                Me.cmdGuardarConvenio.Location = New Point(428, 504)
                Me.cmdModificarConvenio.Location = New Point(388, 504)



                If (Me.txtImporteOtros.Text = "0,0000" And Me.mtxtArea.Text = "") Then
                    txtCotMoneda.Text = "0,0000"
                    Me.txtCotMoneda.Visible = False
                    Me.lblCotizacion.Visible = False
                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
                    Me.txtImporteOtros.Text = "0,0000"
                End If
            End If
            cargarUnidades()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub btnAgregarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCabecera.Click
    '    If (vlCabecera() = True) Then
    '        Dim dR As New DataSet
    '        If (Me.txtcdNroExpedienteRel.Text = "" Or Me.txtcdNroExpedienteRel.Text = 0) Then
    '            Me.txtcdNroExpedienteRel.Text = Me._cdExpRel
    '        End If

    '        dR = WS.Obtener_codExpediente(Me.txtNroExpedienteRel.Text) ', Me.codproveedor)
    '        Dim cdExpRel As Integer
    '        If (dR.Tables(0).Rows.Count > 0) Then
    '            cdExpRel = dR.Tables(0).Rows(0).Item("cdExpediente")

    '            '    Dim d1 As New DataSet
    '            '   d1 = WS.VALIDAR_INFORMANDOEXPEDIENTESANEXADO(cdExpRel)

    '            'If (d1.Tables(0).Rows(0).Item("cdExpediente") <> 0) Then
    '            '    Dim res As DialogResult = MsgBox("Hay expedientes relacionados que quedaran relacionados con el Nro" + Me.txtNroExpedienteRel.Text + " ¿Desea efectuar el cambio?", MsgBoxStyle.YesNo + 32, "Confirmación")
    '            '    CargarDatosExpediente()
    '            '    Dim ds As DataSet
    '            '    ds = WS.Insert_E(oclsE.ToXml)
    '            '    MessageBox.Show("La cabecera del comprobante se ha guardado con exito")
    '            '    Me.btnAgregarCabecera.Enabled = False
    '            '    Me.cmdModificarExp.Visible = True
    '            '    Me.cmdModificarExp.Enabled = True
    '            'Else


    '            CargarDatosExpediente()

    '            Me.txtcdNroExpedienteRel.Text = Me._cdExpRel
    '            Me.txtcdNroExpedienteRel.Text = Me.dsNroRel
    '            If (_Modo = 1) Then
    '                Dim dsVl As New DataSet
    '                Dim Val As Integer
    '                dsVl = WS.Obtener_codExpediente(Me.txtNroExpediente.Text)

    '                If (dsVl.Tables(0).Rows.Count > 0) Then
    '                    Val = dsVl.Tables(0).Rows(0).Item("cdExpediente")
    '                    If (Val = Me._cdExpediente) Then
    '                        CargarDatosExpediente()
    '                        Dim ds As DataSet
    '                        ds = WS.Insert_E(oclsE.ToXml)
    '                        MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                        Me.btnAgregarCabecera.Enabled = False
    '                        Me.cmdModificarExp.Visible = True
    '                        Me.cmdModificarExp.Enabled = True
    '                    Else
    '                        MessageBox.Show("El Nro de expediente ya existe", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                    End If
    '                Else

    '                    CargarDatosExpediente()
    '                    Dim ds As DataSet
    '                    ds = WS.Insert_E(oclsE.ToXml)
    '                    MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                    Me.btnAgregarCabecera.Enabled = False
    '                    Me.cmdModificarExp.Visible = True
    '                    Me.cmdModificarExp.Enabled = True
    '                End If
    '            End If
    '        Else
    '            If (_Modo = 1) Then
    '                Dim dsVl As New DataSet
    '                Dim Val As Integer
    '                dsVl = WS.Obtener_codExpediente(Me.txtNroExpediente.Text)
    '                If (dsVl.Tables(0).Rows.Count > 0) Then
    '                    Val = dsVl.Tables(0).Rows(0).Item("cdExpediente")
    '                    If (Val = Me._cdExpediente) Then
    '                        CargarDatosExpediente()
    '                        Dim ds As DataSet
    '                        ds = WS.Insert_E(oclsE.ToXml)
    '                        MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                        Me.btnAgregarCabecera.Enabled = False
    '                        Me.cmdModificarExp.Visible = True
    '                        Me.cmdModificarExp.Enabled = True
    '                    Else
    '                        MessageBox.Show("El Nro de expediente ya existe", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                    End If
    '                Else
    '                    CargarDatosExpediente()
    '                    Dim ds As DataSet
    '                    ds = WS.Insert_E(oclsE.ToXml)
    '                    MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                    Me.btnAgregarCabecera.Enabled = False
    '                    Me.cmdModificarExp.Visible = True
    '                    Me.cmdModificarExp.Enabled = True
    '                End If
    '            End If
    '        End If









    '        If (_Modo = 0) Then

    '            Dim d As New DataSet
    '            d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
    '            If (d.Tables(0).Rows().Count > 0) Then
    '                Me._cdExpediente = d.Tables(0).Rows(0).Item("cdExpediente") '
    '                Me.txtcdExpediente.Text = _cdExpediente
    '                ' Dim ocls As New clsSeguimientoExpedientes()
    '                'CargarMovimiento()
    '                ' Dim dsomov As New DataSet
    '                '  dsomov = WS.Insert_SEGUIMIENTO_ESTADO(oclsMov.ToXml)
    '                '  Me.CargarEstadosSeguimiento()

    '                CargarDatosExpediente()
    '                Dim ds As DataSet
    '                ds = WS.Insert_E(oclsE.ToXml)
    '                MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                Me.btnAgregarCabecera.Enabled = False
    '                Me.cmdModificarExp.Visible = True
    '                Me.cmdModificarExp.Enabled = True
    '                TraerUltimoEstado(_cdExpediente)
    '                If (_Modo = 1) Then
    '                    '  Dim ocls As New clsSeguimientoExpedientes()
    '                    ' CargarMovimiento()
    '                    'Dim dsomov As New DataSet
    '                    '      dsomov = WS.Insert_SEGUIMIENTO_ESTADO(oclsMov.ToXml)
    '                    '   Me.CargarEstadosSeguimiento()
    '                    TraerUltimoEstado(_cdExpediente)
    '                    CargarGrillaConceptos()
    '                    Me.btnAgregarCabecera.Enabled = False
    '                    Me.cmdModificarExp.Visible = True
    '                    Me.cmdModificarExp.Enabled = True
    '                End If

    '                If (Me.cboTipoExpediente.SelectedValue = 11) Then
    '                    Me.txtCotMoneda.Visible = False
    '                    Me.lblCotizacion.Visible = False
    '                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
    '                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
    '                    Me.txtImporteOtros.Text = "0,00"
    '                    Me.txtCotMoneda.Text = "0,000"
    '                    Me.TabComprobantes.Text = "Convenio"
    '                    Me.TabComprobantes.Parent = Me.TabSolapas
    '                    Me.TabAreas.Parent = Nothing
    '                    Me.TabConceptos.Parent = Me.TabSolapas
    '                    Me.TabSeguimiento.Parent = Me.TabSolapas

    '                    Me.cmdGuardarConvenio.Enabled = True
    '                    Me.cmdModificarConvenio.Enabled = False

    '                End If

    '                If (Me.cboTipoExpediente.SelectedValue = 13) Then
    '                    Me.TabComprobantes.Text = "Otros"
    '                    Me.txtCotMoneda.Visible = False
    '                    Me.lblCotizacion.Visible = False
    '                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
    '                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
    '                    Me.txtImporteOtros.Text = "0,00"
    '                    Me.txtCotMoneda.Text = "0,000"
    '                    Me.TabComprobantes.Parent = Me.TabSolapas
    '                    Me.TabAreas.Parent = Me.TabSolapas
    '                    Me.TabConceptos.Parent = Me.TabSolapas
    '                    Me.TabSeguimiento.Parent = Me.TabSolapas
    '                    Me.cmdGuardarConvenio.Enabled = True
    '                    Me.cmdModificarConvenio.Enabled = False

    '                End If
    '            Else
    '                CargarDatosExpediente()
    '                Dim ds As DataSet
    '                ds = WS.Insert_E(oclsE.ToXml)
    '                MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                Me.btnAgregarCabecera.Enabled = False
    '                Me.cmdModificarExp.Visible = True
    '                Me.cmdModificarExp.Enabled = True
    '                TraerUltimoEstado(_cdExpediente)
    '                If (_Modo = 1) Then
    '                    '  Dim ocls As New clsSeguimientoExpedientes()
    '                    ' CargarMovimiento()
    '                    'Dim dsomov As New DataSet
    '                    '      dsomov = WS.Insert_SEGUIMIENTO_ESTADO(oclsMov.ToXml)
    '                    '   Me.CargarEstadosSeguimiento()
    '                    TraerUltimoEstado(_cdExpediente)
    '                    CargarGrillaConceptos()
    '                    Me.btnAgregarCabecera.Enabled = False
    '                    Me.cmdModificarExp.Visible = True
    '                    Me.cmdModificarExp.Enabled = True
    '                End If

    '                If (Me.cboTipoExpediente.SelectedValue = 11) Then
    '                    Me.txtCotMoneda.Visible = False
    '                    Me.lblCotizacion.Visible = False
    '                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
    '                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
    '                    Me.txtImporteOtros.Text = "0,00"
    '                    Me.txtCotMoneda.Text = "0,000"
    '                    Me.TabComprobantes.Text = "Convenio"
    '                    Me.TabComprobantes.Parent = Me.TabSolapas
    '                    Me.TabAreas.Parent = Nothing
    '                    Me.TabConceptos.Parent = Me.TabSolapas
    '                    Me.TabSeguimiento.Parent = Me.TabSolapas

    '                    Me.cmdGuardarConvenio.Enabled = True
    '                    Me.cmdModificarConvenio.Enabled = False

    '                End If

    '                If (Me.cboTipoExpediente.SelectedValue = 13) Then
    '                    Me.TabComprobantes.Text = "Otros"
    '                    Me.txtCotMoneda.Visible = False
    '                    Me.lblCotizacion.Visible = False
    '                    Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
    '                    Me.cboPeriodicidadC.Text = "Sin Periodicidad"
    '                    Me.txtImporteOtros.Text = "0,00"
    '                    Me.txtCotMoneda.Text = "0,000"
    '                    Me.TabComprobantes.Parent = Me.TabSolapas
    '                    Me.TabAreas.Parent = Me.TabSolapas
    '                    Me.TabConceptos.Parent = Me.TabSolapas
    '                    Me.TabSeguimiento.Parent = Me.TabSolapas
    '                    Me.cmdGuardarConvenio.Enabled = True
    '                    Me.cmdModificarConvenio.Enabled = False

    '                End If

    '            End If

    '            If (Me.cboTipoExpediente.SelectedValue = 12 Or Me.cboTipoExpediente.SelectedValue = 21 Or Me.cboTipoExpediente.SelectedValue = 22) Then

    '                Me.TabComprobantes.Text = "Comprobantes"
    '                Me.TabComprobantes.Parent = Me.TabSolapas
    '                Me.TabAreas.Parent = Me.TabSolapas
    '                Me.TabConceptos.Parent = Me.TabSolapas
    '                Me.TabSeguimiento.Parent = Me.TabSolapas
    '            End If
    '            Me.pnlProv.Visible = True
    '            Me.pnlValores.Visible = True
    '            Me.btnAgregarCabecera.Visible = False
    '            Me.cmdModificarExp.Visible = True
    '            Me.cmdModificarExp.Enabled = True
    '            Me.lblMensajeModificar.Visible = True
    '            btnAgregarCabecera.Enabled = False
    '            lblNroExpedienteV.Visible = True
    '            lblFechaV.Visible = True
    '            lblProveedorV.Visible = True
    '            lblImpP.Visible = True
    '            Label1.Visible = True
    '            lblImpD.Visible = True
    '            lblImporteD.Visible = True
    '            lblImpE.Visible = True
    '            lblImporteE.Visible = True
    '            Me.lblMensajeIngNuevo.Visible = False
    '            Me.gxpDatosExpediente.Enabled = False
    '            mtxtAreaE.Enabled = False
    '            Me.rhcObservacionesE.Enabled = False
    '            Me.gbProveedor.Enabled = False
    '            btnAgregarCabecera.Enabled = False
    '            Me.grxObservacion.Enabled = True
    '            ToolStrip2.Enabled = False
    '            Me.ToolStrip4.Enabled = False
    '        End If

    '    Else
    '        ' cmdModificarExp.Visible = False
    '        Me.btnAgregarCabecera.Enabled = True
    '        cmdModificarExp.Enabled = False
    '    End If

    'End Sub
    'Public Function ValidaSolicitudes() As Boolean
    '    Dim d As New DataSet
    '    d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
    '    If (d.Tables(1).Rows().Count > 0) Then
    '        ValidaSolicitudes = True
    '        Dim _cdSeg As Integer
    '        Dim arr As New List(Of clsSeguimientoExpedientes)
    '        If (_cdSeg <> 0) Then
    '            oclsSG.codSeguimiento = _cdSeg
    '        Else
    '            oclsSG.codSeguimiento = 0
    '        End If
    '        oclsSG.codExpediente = _cdExpediente
    '        oclsSG.cdEstado = d.Tables(1).Rows(0).Item("cdSolicitudEstado")
    '        oclsSG.dtFecha = d.Tables(1).Rows(0).Item("dtSolicitud")
    '        oclsSG.cdArea = Me.codAreaE
    '        oclsSG.cdBaja = 0
    '        oclsSG.dsObservaciones = d.Tables(1).Rows(0).Item("dsObservaciones")
    '        oclsSG.cdEtapa = 0
    '        arr.Add(oclsSG)
    '        oclsSG.ArraS = arr


    '    Else
    '        ValidaSolicitudes = False
    '    End If
    '    Return ValidaSolicitudes
    'End Function
    Private Sub btnAgregarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCabecera.Click
        If (vlCabecera() = True) Then
            Dim dR As New DataSet
            If (Me.txtcdNroExpedienteRel.Text = 0) Then
                Me.txtcdNroExpedienteRel.Text = Me._cdExpRel
            End If

            dR = WS.Obtener_codExpediente(Me.txtNroExpedienteRel.Text) ', Me.codproveedor)
            Dim cdExpRel As Integer
            If (dR.Tables(0).Rows.Count > 0) Then
                cdExpRel = dR.Tables(0).Rows(0).Item("cdExpediente")

                '    Dim d1 As New DataSet
                '   d1 = WS.VALIDAR_INFORMANDOEXPEDIENTESANEXADO(cdExpRel)

                'If (d1.Tables(0).Rows(0).Item("cdExpediente") <> 0) Then
                '    Dim res As DialogResult = MsgBox("Hay expedientes relacionados que quedaran relacionados con el Nro" + Me.txtNroExpedienteRel.Text + " ¿Desea efectuar el cambio?", MsgBoxStyle.YesNo + 32, "Confirmación")
                '    CargarDatosExpediente()
                '    Dim ds As DataSet
                '    ds = WS.Insert_E(oclsE.ToXml)
                '    MessageBox.Show("La cabecera del comprobante se ha guardado con exito")
                '    Me.btnAgregarCabecera.Enabled = False
                '    Me.cmdModificarExp.Visible = True
                '    Me.cmdModificarExp.Enabled = True
                'Else
                CargarDatosExpediente()

                Me.txtcdNroExpedienteRel.Text = Me._cdExpRel
                Me.txtcdNroExpedienteRel.Text = Me.dsNroRel
                Dim ds As DataSet
                ds = WS.Insert_E(oclsE.ToXml)
                Me._cdExpediente = ds.Tables(0).Rows(0).Item("id")
                'If (ValidaSolicitudes() = True) Then
                '    Dim ds2 As DataSet
                '    ds2 = WS.Insert_SEGUIMIENTO_ESTADO(oclsSG.ToXml)
                'End If
                MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.btnAgregarCabecera.Enabled = False
                Me.cmdModificarExp.Visible = True
                Me.cmdModificarExp.Enabled = True


            Else
                CargarDatosExpediente()


                Dim ds As DataSet
                ds = WS.Insert_E(oclsE.ToXml)
                Me._cdExpediente = ds.Tables(0).Rows(0).Item("id") '

                'If (ValidaSolicitudes() = True) Then
                '    Dim ds2 As DataSet
                '    ds2 = WS.Insert_SEGUIMIENTO_ESTADO(oclsSG.ToXml)
                'End If
                MessageBox.Show("La grabación fue exitosa", "Grabación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.btnAgregarCabecera.Enabled = False
                Me.cmdModificarExp.Visible = True
                Me.cmdModificarExp.Enabled = True
            End If
            If (_Modo = 0) Then
                Dim d As New DataSet
                d = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
                If (d.Tables(0).Rows().Count > 0) Then
                    Me._cdExpediente = d.Tables(0).Rows(0).Item("cdExpediente") '
                    Me.txtcdExpediente.Text = _cdExpediente
                    ' Dim ocls As New clsSeguimientoExpedientes()
                    'CargarMovimiento()
                    ' Dim dsomov As New DataSet
                    '  dsomov = WS.Insert_SEGUIMIENTO_ESTADO(oclsMov.ToXml)
                    '  Me.CargarEstadosSeguimiento()
                    TraerUltimoEstado(_cdExpediente)

                    'If (ValidaSolicitudes() = True) Then
                    '    Dim ds2 As DataSet
                    '    ds2 = WS.Insert_SEGUIMIENTO_ESTADO(oclsSG.ToXml)
                    'End If
                    If (_Modo = 1) Then
                        '  Dim ocls As New clsSeguimientoExpedientes()
                        ' CargarMovimiento()
                        'Dim dsomov As New DataSet
                        '      dsomov = WS.Insert_SEGUIMIENTO_ESTADO(oclsMov.ToXml)
                        '   Me.CargarEstadosSeguimiento()
                        TraerUltimoEstado(_cdExpediente)
                        CargarGrillaConceptos()
                        Me.btnAgregarCabecera.Enabled = False
                        Me.cmdModificarExp.Visible = True
                        Me.cmdModificarExp.Enabled = True
                    End If

                    If (Me.cboTipoExpediente.SelectedValue = 11) Then
                        Me.txtCotMoneda.Visible = False
                        Me.lblCotizacion.Visible = False
                        Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                        Me.cboPeriodicidadC.Text = "Sin Periodicidad"
                        Me.txtImporteOtros.Text = "0,0000"
                        Me.txtCotMoneda.Text = "0,0000"
                        Me.TabComprobantes.Text = "Convenio"
                        Me.TabComprobantes.Parent = Me.TabSolapas
                        Me.TabAreas.Parent = Nothing
                        Me.TabConceptos.Parent = Me.TabSolapas
                        Me.TabSeguimiento.Parent = Me.TabSolapas

                        Me.cmdGuardarConvenio.Enabled = True
                        Me.cmdModificarConvenio.Enabled = False

                    End If

                    If (Me.cboTipoExpediente.SelectedValue = 13) Then
                        Me.TabComprobantes.Text = "Otros"
                        Me.txtCotMoneda.Visible = False
                        Me.lblCotizacion.Visible = False
                        Me.cboTipoPeriodicidad.Text = "Sin Periodicidad"
                        Me.cboPeriodicidadC.Text = "Sin Periodicidad"
                        Me.txtImporteOtros.Text = "0,0000"
                        Me.txtCotMoneda.Text = "0,0000"
                        Me.TabComprobantes.Parent = Me.TabSolapas
                        Me.TabAreas.Parent = Me.TabSolapas
                        Me.TabConceptos.Parent = Me.TabSolapas
                        Me.TabSeguimiento.Parent = Me.TabSolapas
                        Me.cmdGuardarConvenio.Enabled = True
                        Me.cmdModificarConvenio.Enabled = False

                    End If

                End If



                If (Me.cboTipoExpediente.SelectedValue = 12 Or Me.cboTipoExpediente.SelectedValue = 21 Or Me.cboTipoExpediente.SelectedValue = 22 Or Me.cboTipoExpediente.SelectedValue = 24) Then

                    Me.TabComprobantes.Text = "Comprobantes"
                    Me.TabComprobantes.Parent = Me.TabSolapas
                    Me.TabAreas.Parent = Me.TabSolapas
                    Me.TabConceptos.Parent = Me.TabSolapas
                    Me.TabSeguimiento.Parent = Me.TabSolapas
                End If
                Me.pnlProv.Visible = True
                Me.pnlValores.Visible = True
                Me.btnAgregarCabecera.Visible = False
                Me.cmdModificarExp.Visible = True
                Me.cmdModificarExp.Enabled = True
                Me.lblMensajeModificar.Visible = True
                btnAgregarCabecera.Enabled = False
                lblNroExpedienteV.Visible = True
                lblFechaV.Visible = True
                lblProveedorV.Visible = True
                lblImpP.Visible = True
                Label1.Visible = True
                lblImpD.Visible = True
                lblImporteD.Visible = True
                lblImpE.Visible = True
                lblCHF.Visible = True
                lblImporteE.Visible = True
                Me.lblFs.Visible = True
                Me.lblMensajeIngNuevo.Visible = False
                Me.gxpDatosExpediente.Enabled = False
                mtxtAreaE.Enabled = False
                Me.rhcObservacionesE.Enabled = False
                Me.gbProveedor.Enabled = False
                btnAgregarCabecera.Enabled = False
                Me.grxObservacion.Enabled = True
                ToolStrip2.Enabled = False
                Me.ToolStrip4.Enabled = False
            End If

        Else
            ' cmdModificarExp.Visible = False
            Me.btnAgregarCabecera.Enabled = True
            cmdModificarExp.Enabled = False
        End If

    End Sub
    Private Sub cmdAgregarComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarComp.Click
        Try
            Dim ofrm As New frmIngresodeComprobantesOtros()
            Dim ds As DataSet
            If (Me._cdExpediente = 0) Then
                ds = WS.Obtener_codExpediente(Me.txtNroExpediente.Text) ', Me.codproveedor)
                Me._cdExpediente = ds.Tables(0).Rows(0).Item("cdExpediente") '
            End If
            Me.cmdModificarComprobante.Enabled = False
            ofrm.intExp = Me._cdExpediente
            ofrm._cdClaseC = Me._cdClaseC
            ofrm._dsNroExp = Me.txtNroExpediente.Text
            _TipoExpediente = 0
            ofrm._codproveedor = Me.codproveedor
            ofrm.txtcdProveedor.Text = codproveedor
            ofrm._dsProveedor = Me.txtRazonSocial.Text

            If (Me.chkExterior.Checked = True) Then
                ofrm._EsExterior = 1
            Else
                ofrm._EsExterior = 0
            End If
            If (Me.txtNroBeneficiario.Text <> "") Then
                ofrm._dsNroBen = Me.txtNroBeneficiario.Text
                ofrm.txtNroBeneficiario.Text = Me.txtNroBeneficiario.Text
            End If
            If (Me.txtCuit.Text <> "") Then

                ofrm._dsCuit = Me.txtCuit.Text
                ofrm.txtCuit.Text = Me.txtCuit.Text
            End If
            ofrm._dsNroExp = Me.txtNroExpediente.Text

            Dim res As DialogResult
            res = ofrm.ShowDialog()
            AgregarDatosGrilla_ConveniosOtros(12)
            cargarUnidades()
            grbComprobante.Visible = False
            While (res = Windows.Forms.DialogResult.OK)
                _TipoExpediente = 0

                res = ofrm.ShowDialog()
                AgregarDatosGrilla_ConveniosOtros(12)
                cargarUnidades()

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdAgregarConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarConcepto.Click
        Try
            Dim ofrm As New frmConceptoySubconcepto()
            ofrm._intExp = _cdExpediente
            ofrm.ShowDialog()
            CargarGrillaConceptos()
            ofrm = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNuevo.Click
        Try
            Dim ofrmp As New frmProveedores
            ofrmp.cdModo = 0
            ofrmp.ShowDialog()
            Dim ds As New DataSet
            ds = WS.SP_OBTENERPROVEEDOR_PORCODIGO(_codProv)
            If (ds.Tables(0).Rows().Count > 0) Then
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                Me._cdExterior = ds.Tables(0).Rows(0).Item("cdEsExterior").ToString()
                If (_cdExterior = 1) Then
                    Me.chkExterior.Checked = True
                Else
                    Me.chkExterior.Checked = False
                End If

            End If
            Me.AutoCompletarProveedores_Organismo(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '  If (_Modo = 1) Then

        '    Dim ds As New DataSet
        '    ds = WS.Val_BycdCom_BycdProveedor(Me._cdExpediente, codproveedor)
        '    If (ds.Tables(0).Rows.Count > 0) Then
        '        Dim c As New DataSet
        '        c = WS.Obtener_ComprobantesAsociados(_cdExpediente, 0)
        '        If (c.Tables(0).Rows().Count > 0) Then
        '            If (c.Tables(0).Rows(0).Item("cdComprobante").ToString() <> Nothing) Then
        '                MessageBox.Show("No se puede modificar el proveedor ya que tiene datos relacionados")
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        'End If
        '_Tipo = 0
        'Me.codproveedor = 0
        'Me.chkExterior.Checked = False
        'Me.chkExterior.Enabled = True
        'Me.txtRazonSocial.Text = ""
        'Me.txtCuit.Text = ""
        'Me.txtCuit.Enabled = True
        'Me.txtRazonSocial.Enabled = True
        'Me.txtNroBeneficiario.Text = ""
        'txtNroBeneficiario.Enabled = True
        'ToolStripAgregar.Enabled = True
        'ToolStripModificar.Enabled = False
        'Me.ToolStripNuevo.Enabled = False


    End Sub
    'Private Sub ToolStripAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAgregar.Click
    '    Try

    '        If (Me.chkExterior.Checked = True) Then
    '            If (Me.txtRazonSocial.Text <> "") Then
    '                '  If (codproveedor <> 0) Then
    '                Me.CargarProveedor()
    '                WS.Proveedor_IU(oclsProv.ToXml)
    '                Me.txtRazonSocial.Enabled = False
    '                Me.txtCuit.Enabled = False
    '                Me.txtNroBeneficiario.Enabled = False
    '                If (_Tipo = 0) Then
    '                    ' MessageBox.Show("El proveedor se agrego con exito")
    '                    Me.codproveedor = 0

    '                    ToolStripAgregar.Enabled = False
    '                    ToolStripModificar.Enabled = True
    '                    Me.ToolStripNuevo.Enabled = True
    '                    'Me.txtRazonSocial.Enabled = False
    '                    'Me.txtCuit.Enabled = False
    '                    'Me.txtNroBeneficiario.Enabled = False


    '                Else
    '                    MessageBox.Show("El proveedor se modifico con exito")
    '                    ToolStripAgregar.Enabled = False
    '                    ToolStripModificar.Enabled = True
    '                    Me.ToolStripNuevo.Enabled = True
    '                    'Me.txtRazonSocial.Enabled = False
    '                    'Me.txtCuit.Enabled = False
    '                    'Me.txtNroBeneficiario.Enabled = False
    '                End If
    '                AutoCompletarProveedores_Organismo(-1)
    '                _TipoProv = 0
    '            Else
    '                MessageBox.Show("Debe ingresar el nombre del proveedor que desea agregar")
    '                ToolStripAgregar.Enabled = True
    '                ToolStripModificar.Enabled = False
    '                Me.ToolStripNuevo.Enabled = True
    '                Me.txtRazonSocial.Enabled = True
    '                Me.txtCuit.Enabled = True
    '                Me.txtNroBeneficiario.Enabled = True
    '            End If
    '            '     Else
    '            '   MessageBox.Show("El proveedor que desea ingresar ya existe")
    '            ' End If

    '        End If
    '        If (Me.chkExterior.Checked = False) Then
    '            If (Me.txtRazonSocial.Text <> "") Then
    '                Me.CargarProveedor()
    '                WS.Proveedor_IU(oclsProv.ToXml)

    '                Me.txtRazonSocial.Enabled = False
    '                Me.txtCuit.Enabled = False
    '                Me.txtNroBeneficiario.Enabled = False

    '                If (_Tipo = 0) Then
    '                    '  MessageBox.Show("El proveedor se agrego con exito")
    '                    Me.codproveedor = 0
    '                    ToolStripAgregar.Enabled = False
    '                    ToolStripModificar.Enabled = True
    '                    Me.ToolStripNuevo.Enabled = True
    '                    'Me.txtRazonSocial.Enabled = False
    '                    'Me.txtCuit.Enabled = False
    '                    'Me.txtNroBeneficiario.Enabled = False
    '                Else
    '                    '  MessageBox.Show("El proveedor se modifico con exito")
    '                    ToolStripAgregar.Enabled = False
    '                    ToolStripModificar.Enabled = True
    '                    Me.ToolStripNuevo.Enabled = True
    '                    'Me.txtRazonSocial.Enabled = False
    '                    'Me.txtCuit.Enabled = False
    '                    'Me.txtNroBeneficiario.Enabled = False

    '                End If
    '                AutoCompletarProveedores_Organismo(-1)
    '                _TipoProv = 0
    '            Else
    '                MessageBox.Show("Debe ingresar el nombre del proveedor que desea agregar")
    '                ToolStripAgregar.Enabled = True
    '                ToolStripModificar.Enabled = False
    '                Me.ToolStripNuevo.Enabled = True
    '                Me.txtRazonSocial.Enabled = True
    '                Me.txtCuit.Enabled = True
    '                Me.txtNroBeneficiario.Enabled = True
    '            End If
    '        End If  
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub ToolStripModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripModificar.Click
        Try
            If (Me.txtRazonSocial.Text <> "") Then
                If (codproveedor = 0) Then
                    CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)
                End If
                If (codproveedor <> 0) Then
                    '  Me.AutoCompletarProveedores_Organismo(-1)
                    If (Me.codproveedor <> 0 Or Me.txtRazonSocial.Text <> "") Then
                        Dim ofrmp As New frmProveedores
                        ofrmp.txtcodProv.Text = Me.codproveedor
                        ofrmp.txtRazonSocial.Text = Me.txtRazonSocial.Text
                        ofrmp.txtCuit.Text = Me.txtCuit.Text
                        ofrmp.txtNroBeneficiario.Text = Me.txtNroBeneficiario.Text
                        ofrmp.cdModo = 1
                        If (Me.chkExterior.Checked = True) Then
                            Me._cdExterior = 1
                        Else
                            Me._cdExterior = 0
                        End If
                        ofrmp._cdExterior = Me._cdExterior
                        ofrmp.ShowDialog()
                        Dim ds As New DataSet
                        ds = WS.SP_OBTENERPROVEEDOR_PORCODIGO(codproveedor)
                        If (ds.Tables(0).Rows().Count > 0) Then
                            Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial").ToString()
                            Me.txtCuit.Text = ds.Tables(0).Rows(0).Item("dsNroDocumento").ToString()
                            Me.txtNroBeneficiario.Text = ds.Tables(0).Rows(0).Item("dsNroBeneficiario").ToString()
                            Me._cdExterior = ds.Tables(0).Rows(0).Item("cdEsExterior").ToString()
                            Me.txtRazonSocial.Enabled = False
                            Me.txtNroBeneficiario.Enabled = False
                            Me.txtCuit.Enabled = False
                            Me.chkExterior.Enabled = False
                            If (_cdExterior = 1) Then
                                Me.chkExterior.Checked = True
                            Else
                                Me.chkExterior.Checked = False
                            End If
                            ' Me.AutoCompletarProveedores_Organismo(-1)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdModificarExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarExp.Click
        Try
            Me.txtNroExpediente.Enabled = False
            _Modo = 1
            If (Me.cboTipoExpediente.SelectedValue = 12 Or Me.cboTipoExpediente.SelectedValue = 21 Or Me.cboTipoExpediente.SelectedValue = 22) Then
                Dim d As DataSet
                d = WS.Obtener_ComprobantesAsociados(_cdExpediente, 0)
                If (d.Tables(0).Rows().Count > 0) Then
                    'Me.txtRazonSocial.Enabled = False
                    'Me.txtCuit.Enabled = False
                    'Me.txtNroBeneficiario.Enabled = False
                    mtxtAreaE.Enabled = True
                    Me.rhcObservacionesE.Enabled = True
                    Me.dt.Enabled = True
                    'Me.lblNroExpedienteV.Text = "Exp " + Me.txtNroExpediente.Text
                    'Me.lblProveedorV.Text = Me.txtRazonSocial.Text
                    'Dim st As String
                    'st = dt.Value.ToString()
                    'Me.lblFechaV.Text = st
                    Dim i As Integer
                    Dim ocls As New clsComprobante
                    If (d.Tables(0).Rows(i).Item("cdComprobante").ToString() <> Nothing) Then
                        ' MessageBox.Show("No se puede modificar el tipo de expediente, ya que tiene comprobantes relacionados")
                        '  Me.cboTipoExpediente.Enabled = False
                    Else
                        '  Me.cboTipoExpediente.Enabled = True
                        _Edit = 1
                    End If
                End If
                Me.cboTipoExpediente.Enabled = True
                CargarTipoExpediente(0)
            End If
            If (Me.cboTipoExpediente.SelectedValue = 11) Then
                Dim d As DataSet
                d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
                If (d.Tables(0).Rows().Count > 0) Then
                    '  MessageBox.Show("No se puede modificar el tipo de expediente, ya que tiene Convenios relacionados")
                    Me.cboTipoExpediente.Enabled = False
                Else
                    Me.cboTipoExpediente.Enabled = True
                    _Edit = 1
                End If
            End If
            If (Me.cboTipoExpediente.SelectedValue = 13) Then
                Dim d As DataSet
                d = WS.SP_Busqueda_ConvenioOtros(_cdExpediente, 0)
                If (d.Tables(0).Rows().Count > 0) Then
                    ' MessageBox.Show("No se puede modificar el tipo de expediente, ya que tiene Otros relacionados")
                    Me.cboTipoExpediente.Enabled = False
                Else
                    Me.cboTipoExpediente.Enabled = True
                    _Edit = 1
                End If
            End If
            '  Me.txtRazonSocial.Enabled = True
            '    Me.txtCuit.Enabled = True
            '  Me.txtNroBeneficiario.Enabled = True
            '  Me.chkExterior.Enabled = True
            ToolStripButton3.Enabled = True
            Me.txtNroExpedienteRel.Enabled = True
            gxpListObservaciones.Enabled = True
            btnAgregarCabecera.Enabled = True
            Me.btnAgregarCabecera.Visible = True
            cmdModificarExp.Enabled = False
            Me.lblMensajeModificar.Visible = False
            mtxtAreaE.Enabled = True
            Me.rhcObservacionesE.Enabled = True
            Me.dt.Enabled = True
            Me.txtNroExpediente.Enabled = True
            gxpDatosExpediente.Enabled = True
            mtxtAreaE.Enabled = True
            Me.dt.Enabled = True
            ToolStrip2.Enabled = True
            Me.ToolStrip4.Enabled = True

        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdModificarComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarComprobante.Click
        Dim ofrm As New frmIngresodeComprobantesOtros()
        ofrm.intExp = Me._cdExpediente
        ofrm._codproveedor = Me.codproveedor
        ofrm.txtcdProveedor.Text = codproveedor
        ofrm._dsProveedor = Me.txtRazonSocial.Text
        _TipoExpediente = 1
        ofrm.intExp = Me._cdExpediente
        ofrm._cdComprobante = _intcdComprobante
        ofrm.txtNroComprobante.Text = _dsNroComp
        ofrm._cdClaseC = _cdClaseC
        ofrm._cdTipoC = _cdTipo
        ofrm._checked = cdDesg
        ofrm._cdComprobante = _intcdComprobante

        ofrm.ShowDialog()
        grbComprobante.Visible = False
        AgregarDatosGrilla_ConveniosOtros(12)
        cargarUnidades()
        Me.cmdModificarComprobante.Enabled = False
        ofrm = Nothing
    End Sub
    Private Sub txtCotMoneda_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCotMoneda.Leave
        If (txtCotMoneda.Text = "") Then
            txtCotMoneda.Text = "0,0000"
        End If
        If (IsNumeric(Me.txtCotMoneda.Text)) Then
            txtCotMoneda.Text = FormatNumber(txtCotMoneda.Text, 3)
        Else
            txtCotMoneda.Text = "0,0000"
        End If
    End Sub
    Private Sub cmdGuardarConvenio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarConvenio.Click
        Try
            If (vlConvenioOtros() = True) Then
                CargarCotizacionMoneda()
                Dim ds1 As New DataSet
                If (Me.cboMoneda.Text <> "Pesos") Then
                    ds1 = WS.CotizacionMoneda_IU(oclsCot.ToXmlc)
                End If
                CargarDatosConveniosOtros()
                Dim ds As New DataSet
                ds = WS.ExpedientesConveniosOtros_IU(oclsECO.ToXml)
                If (ds.Tables(0).Rows().Count > 0) Then
                    MessageBox.Show("Los datos se guardaron correctamente")
                    '   Me.grxObservacion.Enabled = False

                    AgruparImporte_PorMoneda(Me.cboMoneda.SelectedValue, 0)
                    cargarUnidades()
                    If (Me.cboTipoExpediente.SelectedValue = 11) Then
                        Me.TabComprobantes.Text = "Convenio"
                    End If
                    If (Me.cboTipoExpediente.SelectedValue = 12) Then
                        Me.TabComprobantes.Text = "Comprobantes"
                    End If
                    If (Me.cboTipoExpediente.SelectedValue = 13) Then
                        Me.TabComprobantes.Text = "Otros"
                    End If
                End If
                Me.txtNroBeneficiario.Enabled = False
                Me.rchObservacionO.Enabled = False
                Me.mtxtArea.Enabled = False
                Me.txtObjeto.Enabled = False
                Me.txtImporteOtros.Enabled = False
                Me.dtFechaC.Enabled = False
                Me.cboMoneda.Enabled = False
                Me.txtCotMoneda.Enabled = False
                grpPeriodoServicio.Enabled = False
                cmdGuardarConvenio.Enabled = False
                Me.cmdModificarConvenio.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
        Try

            If (Me.cboMoneda.Text = "Pesos" Or Me.cboMoneda.SelectedValue = 1) Then
                Me.txtCotMoneda.Visible = False
                Me.lblCotizacion.Visible = False
                Me.txtCotMoneda.Text = "0,0000"
            Else
                Me.txtCotMoneda.Visible = True
                Me.lblCotizacion.Visible = True
                CargarCotizaciones(Me.cboMoneda.SelectedValue())
                ValidarCotizacion(Me.cboMoneda.SelectedValue(), Me.dtFechaC.Value)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdModificarConvenio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarConvenio.Click

        Me.dtFechaDesde.Enabled = True
        Me.dtFechaHasta.Enabled = True
        Me.txtNroConvenio.Enabled = True
        Me.cmdModificarConvenio.Enabled = False
        Me.cmdGuardarConvenio.Enabled = True
        Me.grxObservacion.Enabled = True
        Me.rchObservacionO.Enabled = True
        mtxtArea.Enabled = True
        Me.txtObjeto.Enabled = True
        Me.txtImporteOtros.Enabled = True
        Me.dtFechaC.Enabled = True
        Me.cboMoneda.Enabled = True
        Me.txtCotMoneda.Enabled = True

        grpPeriodoServicio.Enabled = True
        AgruparImporte_PorMoneda(Me.cboMoneda.SelectedValue, 0)
        cargarUnidades()

        '   Me.CargarTipoPeriodicidad_Otros(-2)
    End Sub
    Private Sub tsMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMenu.Click
        Try

            If (Me.txtNroExpediente.Text <> "" And Me.txtRazonSocial.Text <> "") Then
                Dim res As DialogResult = MsgBox("LOS DATOS DEL EXPEDIENTE SE BORRARAN, ¿DESEA VACIAR LOS CAMPOS DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (res = Windows.Forms.DialogResult.Yes) Then


                    If (Me.chkExterior.Checked = True) Then
                        _Chk = 1
                    Else
                        _Chk = 0
                    End If
                    _cdPerio = 0
                    _cdExpediente = 0
                    Me.lblTitulo.Visible = False
                    pnlDatosMov.Visible = False
                    lblDesglose.Visible = False
                    Me.lblMensajeIngNuevo.Visible = True
                    cmdModificarExp.Visible = False
                    lblNroExpedienteV.Visible = False
                    lblFechaV.Visible = False
                    Me.pnlDatosMov.Visible = False
                    Me.pnlValores.Visible = False
                    lblProveedorV.Visible = False
                    lblImpP.Visible = False
                    Label1.Visible = False
                    lblImpD.Visible = False
                    lblImporteD.Visible = False
                    lblImpE.Visible = False
                    lblCHF.Visible = False
                    lblImporteE.Visible = False
                    Me.lblFs.Visible = False
                    Me.lblMensajeIngNuevo.Visible = True
                    gbProveedor.Enabled = True
                    _cdExpediente = 0
                    _Edit = 0
                    codproveedor = 0
                    Me.txtRazonSocial.Text = ""
                    Me.txtCuit.Text = ""
                    Me.txtNroBeneficiario.Text = ""
                    Me.txtRazonSocial.Enabled = True
                    Me.txtCuit.Enabled = True
                    Me.txtNroBeneficiario.Enabled = True
                    Me.ToolStripNuevo.Enabled = True
                    Me.ToolStripModificar.Enabled = False
                    ' Me.ToolStripAgregar.Enabled = False
                    Me.dtFechaDesde.Checked = False
                    Me.dtFechaHasta.Checked = False
                    Me.dtFechaDesde.Value = Today
                    Me.dtFechaHasta.Value = Today
                    ToolStrip2.Enabled = True
                    Me.ToolStrip4.Enabled = True
                    Me.cmdAgregarComp.Visible = True
                    Me.Label1.Text = "$0,000"
                    lblNroExpedienteV.Text = "Exp(Nuevo)"
                    lblFechaV.Text = "Fecha"
                    lblProveedorV.Text = "Sin Proveedor"
                    Me._cdExpRel = 0
                    Me.dsNroRel = ""
                    Me.txtNroExpedienteRel.Text = ""
                    Me.txtcdNroExpedienteRel.Text = 0
                    lblImporteD.Text = "0,000"
                    lblImporteE.Text = "0,000"

                    Me.lblFs.Text = "0,000"

                    Me.mtxtAreaE.Text = ""
                    codAreaE = 0
                    dgvlistado.Rows.Clear()
                    bs = New BindingSource(List, "")
                    Me.dgvlistado.DataSource = bs
                    bsConcepto = New BindingSource(ListConcepto, "")
                    Me.dgvConceptos.DataSource = bsConcepto
                    bsArea = New BindingSource(ListAreas, "")
                    Me.dgvUnidad.DataSource = bsArea
                    Me.chkExterior.Checked = False
                    Me.chkExterior.Enabled = False
                    bsS = New BindingSource(ListS, "")
                    dgvSeguimiento.DataSource = bsS
                    Me.AgregarDatosGrilla_ConveniosOtros(12)
                    CargarMonedas(-1)
                    Me.CargarGrillaConceptos()
                    Me.TabAreas.Parent = Nothing
                    Me.TabConceptos.Parent = Nothing
                    Me.TabSeguimiento.Parent = Nothing
                    Me.TabComprobantes.Parent = Nothing
                    Me.cmdModificarConvenio.Enabled = True
                    Me.cmdGuardarConvenio.Enabled = False
                    Me.grxObservacion.Enabled = True
                    Me.txtNroConvenio.Text = ""
                    Me.rchObservacionO.Text = ""
                    mtxtArea.Text = ""
                    Me.txtObjeto.Text = ""
                    Me.txtImporteOtros.Text = ""
                    Me.dtFechaC.Value = Today
                    Me.txtcdNroExpedienteRel.Text = ""
                    Me.txtNroExpedienteRel.Text = ""
                    Me.gbxComprobantesRel.Visible = False
                    Me.cboMoneda.Text = ""
                    Me.txtCotMoneda.Text = ""
                    grpPeriodoServicio.Enabled = True
                    Me.rhcObservacionesE.Text = ""
                    Me.txtNroBeneficiario.Text = ""
                    Me.txtRazonSocial.Text = ""
                    Me.txtCuit.Text = ""
                    Me.txtNroExpediente.Text = ""
                    Me.dt.Value = Today
                    Me.dt.Enabled = True
                    mtxtAreaE.Enabled = True
                    Me.cboTipoExpediente.SelectedValue = 12
                    Me.btnAgregarCabecera.Visible = True
                    cmdModificarExp.Visible = False
                    Me.lblMensajeModificar.Visible = False

                    Me.txtNroBeneficiario.Enabled = True
                    Me.rhcObservacionesE.Enabled = True
                    Me.dt.Enabled = True
                    Me.cboTipoExpediente.Enabled = True
                    Me.pnlTmenu.Enabled = True
                    Me.txtNroExpediente.Enabled = True
                    gxpDatosExpediente.Enabled = True

                    Me.chkExterior.Enabled = True
                    _Modo = 0
                    Me.txtNroExpediente.Enabled = True
                    gxpDatosExpediente.Enabled = True
                    Me.cboTipoExpediente.Enabled = True
                    INICIO()
                    Me.btnAgregarCabecera.Enabled = True
                    _Modo = 0
                    '  Me.frmIngresarExpedientes_Load(objLoad, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeguimiento.Click
        Try
            Dim ofrm As New frmMovimientosdelExpediente
            ofrm._cdExp = _cdExpediente
            ofrm.ShowDialog()
            Me.CargarEstadosSeguimiento()
            TraerUltimoEstado(_cdExpediente)
            ofrm = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvSeguimiento_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSeguimiento.CellContentClick
        Try
            If e.ColumnIndex = Me.colum_ver.Index Then
                'Me.lblMovimiento.Text = "Estado:              " + Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsEstado").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me.lblAreaMovimiento.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columdsArea").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me.rchObservacionMov.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsObservacion").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me.pnlDatosMov.Visible = True
                'Me.rchObservacionMov.Enabled = False
                'btnModificarSE.Visible = False

                Dim ofrm As New frmMovimientosdelExpediente

                ofrm._cbocdEstado = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEstado").Value '
                ofrm.cboEstado.Enabled = False
                ofrm._cbodsEstado = dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsEstado").Value.ToString()

                ofrm.cboEstado.SelectedValue = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEstado").Value
                ofrm.codAreaE = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columcdArea").Value.ToString()
                ofrm.mtxtArea.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columdsArea").Value.ToString()
                ofrm.mtxtArea.Enabled = False
                ofrm.txtObservacion.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("sObservaciones").Value.ToString()
                ofrm.txtObservacion.Enabled = False
                ofrm.dtFechaN.Value = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columFecha").Value.ToString()
                ofrm.dtFechaN.Enabled = False
                ofrm._cdSeg = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codSeguimiento").Value.ToString()
                ofrm._cdExp = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codExpediente").Value.ToString()
                ofrm._cbocdEtapa = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEtapa").Value.ToString()
                ofrm.cboEtapa.Enabled = False
                ofrm.ShowDialog()
                Me.CargarEstadosSeguimiento()
                TraerUltimoEstado(_cdExpediente)
                ofrm = Nothing
            End If
            If e.ColumnIndex = Me.Columnedit.Index Then
                Dim ofrm As New frmMovimientosdelExpediente

                ofrm._cbocdEstado = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEstado").Value '
                ofrm._cbodsEstado = dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsEstado").Value.ToString()
                ofrm.cboEstado.SelectedValue = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEstado").Value
                ofrm.codAreaE = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columcdArea").Value.ToString()
                ofrm.mtxtArea.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columdsArea").Value.ToString()
                ofrm.txtObservacion.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("sObservaciones").Value.ToString()
                ofrm.dtFechaN.Value = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columFecha").Value.ToString()
                ofrm._cdSeg = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codSeguimiento").Value.ToString()
                ofrm._cdExp = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codExpediente").Value.ToString()
                ofrm._cbocdEtapa = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("cdEtapa").Value.ToString()
                ofrm.ShowDialog()
                Me.CargarEstadosSeguimiento()
                TraerUltimoEstado(_cdExpediente)
                ofrm = Nothing

                'Me.lblMovimiento.Text = "Estado:              " + Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsEstado").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me.lblAreaMovimiento.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("columdsArea").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me.rchObservacionMov.Text = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumdsObservacion").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                'Me._cdSeguimiento = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumncdSeguimiento").Value.ToString()
                'Me._cdExpediente = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumncodExpediente").Value.ToString()
                'Me.pnlDatosMov.Visible = True
                'Me.rchObservacionMov.Enabled = True
                'btnModificarSE.Visible = True
            End If
            If e.ColumnIndex = Me.colum_delete.Index Then
                Dim cdSeg As New Integer
                cdSeg = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codSeguimiento").Value.ToString()
                Dim cdExp As New Integer
                cdExp = Me.dgvSeguimiento.Rows(e.RowIndex).Cells("codExpediente").Value.ToString()
                'Dim ds As DataSet
                'ds = WS.OBTENER_ULTIMO_ESTADO(_cdExpediente)
                'If (ds.Tables(0).Rows().Count > 0) Then
                Me.lblTitulo.Visible = True
                'cdSeg = ds.Tables(0).Rows(0).Item("cdSeguimiento")
                'cdExp = ds.Tables(0).Rows(0).Item("cdExpediente")
                ' If (Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumncdSeguimiento").Value.ToString() = cdSeg) Then
                'If (Me.dgvSeguimiento.Rows(e.RowIndex).Cells("ColumncodExpediente").Value.ToString() = cdExp) Then
                Dim omov As New DataSet
                omov = WS.Delete_Movimientos(cdSeg, cdExp)
                Me.CargarEstadosSeguimiento()
                Me.TraerUltimoEstado(_cdExpediente)
                MessageBox.Show("El movimiento se elimino con exito")
                'Else
                '    MessageBox.Show("Solo se puede eliminar el ultimo movimiento ingresado")
                'End If
                'End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gbxObservacion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxObservacion.Enter

    End Sub
    Private Sub chkExterior_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExterior.CheckedChanged
        Try
            If (Me.chkExterior.Checked = True) Then
                Me._Chk = 1
            Else
                Me._Chk = 0
            End If

            AutoCompletarProveedores_Organismo(_Chk)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtImporteOtros_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporteOtros.Leave
        If (txtImporteOtros.Text = "") Then
            txtImporteOtros.Text = "0,0000"
        End If
        If (IsNumeric(Me.txtImporteOtros.Text)) Then
            txtImporteOtros.Text = FormatNumber(txtImporteOtros.Text, 2)
        Else
            txtImporteOtros.Text = ""
        End If
    End Sub
    Private Sub txtNroBeneficiario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroBeneficiario.Leave
        Try
            If (Me.txtNroBeneficiario.Text = "" And Me.txtRazonSocial.Text = "") Then
                codproveedor = 0
            ElseIf (Me.txtRazonSocial.Text = "") Then
                Dim ds As New DataSet
                ds = WS.Obtener_Proveedores_Bycuit("", Me.txtNroBeneficiario.Text)
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
                Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor")
                Me.txtRazonSocial.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                '  ToolStripAgregar.Enabled = False
                ToolStripModificar.Enabled = True
                Me.ToolStripNuevo.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub toolEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolEliminar.Click
        Try
            Dim res As DialogResult = MsgBox("EL EXPEDIENTE Nro." + Me.txtNroExpediente.Text + " SE ELIMINARA, ¿DESEA ELIMINARLO?", MsgBoxStyle.YesNo + 32, "Confirmación")
            If (res = Windows.Forms.DialogResult.Yes) Then
                Dim ofrmC As New frmConsultayModificaciondeExpedientes

                Dim ds As DataSet
                ds = WS.DELETE_EXPEDIENTE_RELACIONES(Me._cdExpediente)
                MessageBox.Show("El Expediente se elimino correctamente")
                Me.Close()
                ofrmC.MdiParent = frmMenu
                ofrmC.StartPosition = FormStartPosition.Manual
                ofrmC.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub mtxtArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtArea.Leave
        codArea = getCodArea(mtxtArea.Text)
    End Sub
    Private Sub mtxtAreaE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtAreaE.Leave
        codAreaE = getCodArea(mtxtAreaE.Text)
    End Sub
    Private Sub dt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt.Validated

    End Sub
    Private Sub dgvConceptos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConceptos.CellContentClick
        Try
            If e.ColumnIndex = Me.ver.Index Then
                Me.lblConcepto.Text = "Concepto:     " + Me.dgvConceptos.Rows(e.RowIndex).Cells("ColumdsConcepto").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                Me.lblSubConcepto.Text = "Subconcepto:  " + Me.dgvConceptos.Rows(e.RowIndex).Cells("columSubConcepto").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                txtObservacionesConceptos.Text = Me.dgvConceptos.Rows(e.RowIndex).Cells("ColumdsObservaciones").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                Me.pnlDatosConceptos.Visible = True
            End If
            If e.ColumnIndex = Me.ColEliminar.Index Then
                Dim res As DialogResult = MsgBox("EL CONCEPTO SE ELIMINARA DEL EXPEDIENTE, ¿DESEA BORRARLO DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (res = Windows.Forms.DialogResult.Yes) Then
                    Dim ds As DataSet
                    ds = WS.Delete_Conceptos(_cdExpediente, Me.dgvConceptos.Rows(e.RowIndex).Cells("ColumcdSubConcepto").Value.ToString())
                    MessageBox.Show("El concepto se ha eliminado del expediente")
                    CargarGrillaConceptos()
                    Me.pnlDatosConceptos.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtCotMoneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCotMoneda.TextChanged

    End Sub
    Private Sub cboTipoPeriodicidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPeriodicidad.SelectedIndexChanged
        Try
            If (Me.cboTipoPeriodicidad.Text = "Sin Periodicidad") Then
                ' Me.cboTipoPeriodicidad.SelectedValue = 1
                _cdPerio = 1
                Me.CargarPeriodicidad_PorTipo(_cdPerio, 0)
            End If
            If (cboTipoPeriodicidad.Text = "Mensual") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 3
                _cdPerio = 3
            End If
            If (Me.cboTipoPeriodicidad.Text = "Quincenal") Then
                '  Me.cboTipoPeriodicidad.SelectedValue = 4
                _cdPerio = 4
            End If
            If (_cdPerio = 0) Then
                Me.CargarPeriodicidad_PorTipo(_cdPerio, 0)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub txtImporteOtros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteOtros.KeyPress
        NumConFrac(txtImporteOtros, e)
    End Sub
    Private Sub txtCotMoneda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCotMoneda.KeyPress
        NumConFrac(txtCotMoneda, e)
    End Sub

    Private Sub btnModificarSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarSE.Click
        If (_cdSeguimiento <> 0) Then
            If (rchObservacionMov.Text = "") Then
                rchObservacionMov.Text = " "
            End If
            WS.Update_Seguimiento(_cdSeguimiento, rchObservacionMov.Text)
            MessageBox.Show("El movimiento se ha modificado con exito")
            CargarEstadosSeguimiento()
            Me.pnlDatosMov.Visible = False
            Me.btnModificarSE.Visible = False
            Me.rchObservacionMov.Text = ""
            Me._cdSeguimiento = 0
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        RefrescarBusqueda()
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.txtRazonSocial.Enabled = True
        Me.txtCuit.Enabled = True
        Me.txtNroBeneficiario.Enabled = True
        Me.txtRazonSocial.Text = ""
        Me.txtCuit.Text = ""
        Me.txtNroBeneficiario.Text = ""
        Me.codproveedor = 0
        Me.chkExterior.Enabled = True
        Me.AutoCompletarProveedores_Organismo(-1)
    End Sub


    Private Sub txtNroExpedienteRel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroExpedienteRel.LostFocus

        If (txtNroExpedienteRel.Text <> "") Then
            CargarcodExpRel()
            If (Me.ValidarAnexado = True) Then
                Dim res As DialogResult = MsgBox("El expediente se anexará al Expediente Nro." + dsNroRel + " ¿Está seguro que desea continuar?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (dsNroRel <> Nothing) Then
                    Me.txtcdNroExpedienteRel.Text = dsNroRel
                    Me.txtNroExpediente.Text = Me._cdExpRel
                Else
                    Me.txtcdNroExpedienteRel.Text = ""
                    Me.txtNroExpediente.Text = ""
                End If
            End If
        Else
            If (dsNroRel <> Nothing And _cdExpRel <> 0) Then
                Me.txtcdNroExpedienteRel.Text = 0
                Me._cdExpRel = 0
                MessageBox.Show("Se eliminará la relación con el expediente anexado", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Me.txtcdNroExpedienteRel.Text = 0
                Me._cdExpRel = 0
            End If
        End If
    End Sub
    Private Sub RefrescarBusqueda()

        Try
            Dim i As Integer
            For i = My.Application.OpenForms.Count - 1 To 1 Step -1
                Dim form As Form = My.Application.OpenForms(i)
                If form.Name = "frmConsultayModificaciondeExpedientes" Then

                    Dim oform As frmConsultayModificaciondeExpedientes = form

                    oform.BUSCARCOMPROBANTES()
                    Exit For

                End If
                'MsgBox("El formulario " & form.Name.ToString & " está abierto")
            Next i

        Catch ex As Exception
            Throw ex

        End Try


    End Sub




    Private Sub dgvSolicitudes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudes.CellContentClick

    End Sub

    Private Sub gxpListObservaciones_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gxpListObservaciones.Enter

    End Sub

    Private Sub dgvlistado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvlistado.CellFormatting

    End Sub


End Class