Imports clsFacturas
'Imports Microsoft.Reporting.WinForms
Imports System.Web.Services.Protocols
Public Class frmReportes_Varios
    '  Dim _returnedItems As ReportParameterInfoCollection
    'Private lsParametros As List(Of clsParametro)

#Region "Metodos"
    Public Sub CargarComboProvedor()

        Dim dtProv As New DataTable()
        Dim dtColump As New DataColumn("cdProveedor")
        Dim dtColum2p As New DataColumn("dsProveedor")
        dtProv.Columns.Add(dtColump)
        dtProv.Columns.Add(dtColum2p)
        Dim dr As DataRow = dtProv.NewRow()
        dr("dsProveedor") = "Todos"
        dr("cdProveedor") = "-1"
        dtProv.Rows.Add(dr)

        Dim dsProv As New DataSet
        dsProv = WS.Obtener_Proveedores_Organismos(0, 0)
        For d As Integer = 0 To dsProv.Tables(0).Rows.Count - 1
            Dim dr2 As DataRow = dtProv.NewRow()
            dr2("dsProveedor") = dsProv.Tables(0).Rows(d).Item("dsProveedor").ToString()
            dr2("cdProveedor") = dsProv.Tables(0).Rows(d).Item("cdProveedor").ToString()
            dtProv.Rows.Add(dr2)
        Next d
        Me.cboRS.DisplayMember = "dsProveedor"
        Me.cboRS.ValueMember = "cdProveedor"
        Me.cboRS.DataSource = dtProv
        Me.cboRS.SelectedValue = -1

    End Sub
    Public Sub CargarTipoExpediente()
        Dim dtExp As New DataTable()
        Dim dtColum As New DataColumn("cdValor")
        Dim dtColum2 As New DataColumn("dsValor")
        dtExp.Columns.Add(dtColum)
        dtExp.Columns.Add(dtColum2)
        Dim drE As DataRow = dtExp.NewRow()
        drE("dsValor") = "Todos"
        drE("cdValor") = "-1"
        dtExp.Rows.Add(drE)
        Dim dsE As New DataSet
        dsE = WS.Obtener_TipoExpediente(1)
        For d As Integer = 0 To dsE.Tables(0).Rows.Count - 1
            Dim dr2E As DataRow = dtExp.NewRow()
            dr2E("dsValor") = dsE.Tables(0).Rows(d).Item("dsValor").ToString()
            dr2E("cdValor") = dsE.Tables(0).Rows(d).Item("cdValor").ToString()
            dtExp.Rows.Add(dr2E)
        Next d
        Me.cboTipoExp.DisplayMember = "dsValor"
        Me.cboTipoExp.ValueMember = "cdValor"
        Me.cboTipoExp.DataSource = dtExp
        Me.cboTipoExp.SelectedValue = -1
    End Sub
    Public Sub CargarClaseComprobante()
        Dim dtCC As New DataTable()
        Dim dtColumCC As New DataColumn("cdClaseComprobante")
        Dim dtColum2CC As New DataColumn("dsClaseComprobante")
        dtCC.Columns.Add(dtColumCC)
        dtCC.Columns.Add(dtColum2CC)
        Dim drCC As DataRow = dtCC.NewRow()
        drCC("dsClaseComprobante") = "Todos"
        drCC("cdClaseComprobante") = "-1"
        dtCC.Rows.Add(drCC)
        Dim dsClaseC As New DataSet()
        dsClaseC = WS.Obtener_ClaseComprobantes(-1)
        For dCC As Integer = 0 To dsClaseC.Tables(0).Rows.Count - 1
            Dim dr2CC As DataRow = dtCC.NewRow()
            dr2CC("dsClaseComprobante") = dsClaseC.Tables(0).Rows(dCC).Item("dsClaseComprobante").ToString()
            dr2CC("cdClaseComprobante") = dsClaseC.Tables(0).Rows(dCC).Item("cdClaseComprobante").ToString()
            dtCC.Rows.Add(dr2CC)
        Next dCC
        Me.cboClaseComp.DisplayMember = "dsClaseComprobante"
        Me.cboClaseComp.ValueMember = "cdClaseComprobante"
        Me.cboClaseComp.DataSource = dtCC
        Me.cboClaseComp.SelectedValue = -1
    End Sub
    Public Sub CargarArea()
        Dim dtArea As New DataTable()
        Dim dtColumA As New DataColumn("cdArea")
        Dim dtColum2A As New DataColumn("dsArea")
        dtArea.Columns.Add(dtColumA)
        dtArea.Columns.Add(dtColum2A)
        Dim drA As DataRow = dtArea.NewRow()
        drA("dsArea") = "Todos"
        drA("cdArea") = "-1"
        dtArea.Rows.Add(drA)
        Dim dsArea As New DataSet
        dsArea = WS.Obtener_Areas(-1, "")
        For dA As Integer = 0 To dsArea.Tables(0).Rows.Count - 1
            Dim dr2A As DataRow = dtArea.NewRow()
            dr2A("dsArea") = dsArea.Tables(0).Rows(dA).Item("dsArea").ToString()
            dr2A("cdArea") = dsArea.Tables(0).Rows(dA).Item("cdArea").ToString()
            dtArea.Rows.Add(dr2A)
        Next dA
        Me.cboArea.DisplayMember = "dsArea"
        Me.cboArea.ValueMember = "cdArea"
        Me.cboArea.DataSource = dtArea
        Me.cboArea.SelectedValue = -1
    End Sub

    Public Sub ArmarPantalla()
        Dim dt As New DataTable
        Dim sNombre As String = ""
        dt = WS.Obtener_Reportes(cboReporte.SelectedValue, -1).Tables(0)
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                sNombre = dr("dsNombre").ToString()
                Exit For
            Next
        End If
        Select Case sNombre
            Case "RptAntiguedadComprobantes"
                gxbDatosComprobantes.Visible = False
                Me.gbFiltros.Visible = True
                CargarComboProvedor()
                '-----------------------Cargo el tipo de Expediente
                CargarTipoExpediente()
                '--------------------------Cargo el Area
                Me.lblArea.Text = "Area que lo tiene"
                CargarArea()
                Me.lblTipoExp.Visible = True
                Me.cboTipoExp.Visible = True
                Me.lblExpediente.Location = New Point(144, 16)
                Me.txtExpediente.Location = New Point(147, 32)
            Case "Rptcomprobantestotalizados"

                gxbDatosComprobantes.Visible = True
                'Cargo proveedor
                CargarComboProvedor()

                'Cargo el tipo de Expediente
                CargarTipoExpediente()
                'Cargo el Area
                Me.lblArea.Text = "Area Ultimo Movimiento"
                CargarArea()

                '------------------------------------Cargar ClaseComprobante
                CargarClaseComprobante()
                Me.lblTipoExp.Visible = True
                Me.cboTipoExp.Visible = True
                Me.lblExpediente.Location = New Point(144, 16)
                Me.txtExpediente.Location = New Point(147, 32)

            Case "RptEvolucionEstadoExp"
                gxbDatosComprobantes.Visible = False
                '----------------------------------------Cargo proveedor
                Me.CargarComboProvedor()
                '-----------------------------------------------------Cargo el Area
                Me.lblArea.Text = "Area Ultimo Movimiento"
                CargarArea()
                Me.lblTipoExp.Visible = False
                Me.cboTipoExp.Visible = False
                Me.lblExpediente.Location = New Point(9, 16)
                Me.txtExpediente.Location = New Point(12, 32)

            Case "RptExpedientesIngresados"
                gxbDatosComprobantes.Visible = False
                '----------------------------------------Cargo proveedor
                Me.CargarComboProvedor()
                '----------------------------------------Cargo el Area
                Me.lblArea.Text = "Area Ultimo Movimiento"
                Me.CargarArea()
                Me.lblTipoExp.Visible = True
                Me.cboTipoExp.Visible = True
                Me.lblExpediente.Location = New Point(144, 16)
                Me.txtExpediente.Location = New Point(147, 32)

            Case "RptExpedientesporArea"
                gxbDatosComprobantes.Visible = True
                '---------------------------------------Cargo proveedor
                Me.CargarComboProvedor()

                '--------------------------------Cargo el tipo de Expediente
                Me.CargarTipoExpediente()

                '----------------Cargo el Area
                Me.lblArea.Text = "Unidad Requirente"
                Me.CargarArea()
                '-------------------------------------Cargar ClaseComprobante
                Me.CargarClaseComprobante()
                Me.lblTipoExp.Visible = True
                Me.cboTipoExp.Visible = True
                Me.lblExpediente.Location = New Point(144, 16)
                Me.txtExpediente.Location = New Point(147, 32)
            Case "RptExpedientesTotalizados"
                gxbDatosComprobantes.Visible = False
                '-----------------------------------Cargo proveedor
                Me.CargarComboProvedor()
                '---------------------------------Cargo el Area

                Me.lblArea.Text = "Area Ultimo Movimiento"
                Me.CargarArea()
                Me.lblTipoExp.Visible = True
                Me.cboTipoExp.Visible = True
                Me.lblExpediente.Location = New Point(144, 16)
                Me.txtExpediente.Location = New Point(147, 32)
            Case "RptReporteDiario"

                Me.gbFiltros.Visible = False

            Case "RptEvaluacionEc"

                Me.gbFiltros.Visible = False

        End Select


    End Sub
    'Public Function ArmarParametros(ByVal Parametros As ReportParameterInfoCollection) As List(Of clsParametro)
    '    Try
    '        ArmarParametros = New List(Of clsParametro)

    '        Dim dt As New DataTable
    '        Dim sNombre As String = ""
    '        dt = WS.Obtener_Reportes(cboReporte.SelectedValue, -1).Tables(0)
    '        If dt.Rows.Count > 0 Then
    '            For Each dr As DataRow In dt.Rows
    '                sNombre = dr("dsNombre").ToString()
    '                Exit For
    '            Next
    '        End If
    '        Select Case sNombre
    '            Case "RptAntiguedadComprobantes"
    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboTipoExp.SelectedValue, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(4).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtExpediente.Text, Parametros(5).Name))
    '                'Dim params(Parametros.Count - 1)  ' ReportParameter
    '                'params(0) = New ParameterValue
    '                'params(0).Name = Parametros(0).Name
    '                'params(0).Value = Me.dtDesde.Value 'IIf(Me.Me.dtDesde.Checked = true, -1, Me.txtcdArea.Text)
    '                ''----------------------------------
    '                'params(1) = New ParameterValue
    '                'params(1).Name = Parametros(1).Name
    '                'params(1).Value = Me.dtHasta.Value 'IIf(Me.txtAreasDestino.Text = "", -1, Me.txtcdAreaDest.Text)
    '                ''----------------------------------
    '                'params(2) = New ParameterValue
    '                'params(2).Name = Parametros(2).Name
    '                'params(2).Value = Me.cboTipoExp.SelectedValue
    '                ''----------------------------------
    '                'params(3) = New ParameterValue
    '                'params(3).Name = Parametros(3).Name
    '                'params(3).Value = Me.cboRS.SelectedValue 'IIf(Me.cboRS.Text, "", Me.cboRS.Text)
    '                ''----------------------------------
    '                'params(4) = New ParameterValue
    '                'params(4).Name = Parametros(4).Name
    '                'params(4).Value = cboArea.SelectedValue 'IIf(Me.cboArea.Text, "", Me.cboArea.Text)
    '                ''----------------------------------
    '                'params(5) = New ParameterValue
    '                'params(5).Name = Parametros(5).Name
    '                'params(5).Value = IIf(Me.txtExpediente.Text, "", Me.txtExpediente.Text)
    '            Case "Rptcomprobantestotalizados"

    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboTipoExp.SelectedValue, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(4).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtExpediente.Text, Parametros(5).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtNroComprobante.Text, Parametros(6).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboClaseComp.SelectedValue, Parametros(7).Name))



    '            Case "RptEvolucionEstadoExp"
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(txtExpediente.Text, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(4).Name))

    '            Case "RptExpedientesIngresados"

    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtExpediente.Text, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboTipoExp.SelectedValue, Parametros(4).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(5).Name))





    '            Case "RptExpedientesporArea"

    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboTipoExp.SelectedValue, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtExpediente.Text, Parametros(4).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtNroComprobante.Text, Parametros(5).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboClaseComp.SelectedValue, Parametros(6).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(7).Name))

    '            Case "RptExpedientesTotalizados"

    '                ArmarParametros.Add(New clsParametro(Me.dtDesde.Value, Parametros(0).Name))
    '                ArmarParametros.Add(New clsParametro(Me.dtHasta.Value, Parametros(1).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboTipoExp.SelectedValue, Parametros(2).Name))
    '                ArmarParametros.Add(New clsParametro(Me.cboRS.SelectedValue, Parametros(3).Name))
    '                ArmarParametros.Add(New clsParametro(cboArea.SelectedValue, Parametros(4).Name))
    '                ArmarParametros.Add(New clsParametro(Me.txtExpediente.Text, Parametros(5).Name))


    '            Case Else

    '                Mensajes(4)
    '                Return Nothing

    '        End Select
    '        Return ArmarParametros
    '    Catch ex As Exception

    '    End Try

    'End Function
    Public Sub cargarComboReportes(ByVal cdRepor As Integer, ByVal cdTipo As Integer)
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_Reportes(cdRepor, cdTipo)
            Me.cboReporte.DisplayMember = "dsDescripcion"
            Me.cboReporte.ValueMember = "cdReporte"
            Me.cboReporte.DataSource = ds.Tables(0)
            Me.cboReporte.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Parametros()
        Select Case Me.cboReporte.SelectedValue.ToString().ToLower()
            Case "RptAntiguedadComprobantes"

            Case "Rptcomprobantestotalizados"

            Case "RptEvolucionEstadoExp"

            Case "RptExpedientesIngresados"

            Case "RptExpedientesporArea"

            Case "RptExpedientesTotalizados"

        End Select
    End Sub
    Private Sub Mensajes(ByVal res As Integer)
        Select Case res
            Case 1 : MessageBox.Show("Error en el formato de la fecha desde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2 : MessageBox.Show("Error en el formato de la fecha hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 3 : MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 4 : MessageBox.Show("No se pudo localizar la ruta del reporte.", "Reporte no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5 : MessageBox.Show("Debe ingresar el rubro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 7 : MessageBox.Show("Debe seleccionar un rango de fecha para realizar la busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 8 : MessageBox.Show("Debe seleccionar al menos alguno de los siguiente parametros: RUBRO, N° INVENTARIO , FECHA  ó AREA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 9 : MessageBox.Show("Debe seleccionar AREA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 10 : MessageBox.Show("Debe seleccionar al menos alguno de los siguientes parametros: N° INVENTARIO(desde-hasta)  ó RUBRO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case Else
                MessageBox.Show("Error Desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub ItemsEnServidor()
        'Dim conditions() As SearchCondition
        'Dim condition As New SearchCondition
        Try
            '  _returnedItems = Me.ReportViewerDGI1.ServerReport.GetParameters()
        Catch ex As Exception
            '_returnedItems = Nothing
            MessageBox.Show("Error al localizar Items en el servidor.", "Reporte no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SP_LISTAR_REPORTES()
        Dim dt As New DataTable
        Try
            'Me.cboReportes.ComboBox.Items.Clear()
            'dt = ws.Obtener_Reportes(-1, intTipoReporte).Tables(0)
            'If dt.Rows.Count > 0 Then
            '    UI.Bind(Me.cboReportes.ComboBox, dt, "dsDescripcion", "cdReporte")
            '    Me.cboReportes.ComboBox.SelectedIndex = 0
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try
    End Sub
    Private Sub HandleException(ByVal exception As Exception)
        Dim exceptionText As String
        ' Busca si la salida de la excepcion es de tipo SOAP y crea 
        If TypeOf exception Is SoapException Then
            exceptionText = CType(exception, SoapException).Detail("Message").InnerXml
        Else
            exceptionText = exception.Message
        End If
        MessageBox.Show("A ocurrido una exepción : " + exceptionText, "Error de Aplicación")
    End Sub
    ''Private Function SetParameters(ByVal Parametros As ReportParameterInfoCollection) As ParameterValue() 'ByVal Parametros() As ReportParameter, ByVal Nombre As String
    '    Try

    '        Dim params(Parametros.Count - 1) As ParameterValue
    '        Dim lsparametros As New List(Of clsParametro)

    '        lsparametros = ArmarParametros(Parametros)
    '        For i As Integer = 0 To lsparametros.Count - 1
    '            params(i) = New ParameterValue
    '            params(i).Name = Parametros(i).Name
    '            params(i).Value = lsparametros(i).cdValor
    '        Next



    '        Return params
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    Private Function Ver_Reporte(ByVal Params As ParameterValue()) As Boolean
        Try

            Dim separador As String = ""
            Dim valor As String = ""
            For i As Integer = 0 To Params.Length - 1

                '        Dim rp As New ReportParameter()

                '        rp.Name = Params(i).Name
                '        rp.values

                '        ReportViewerDGI1.ServerReport.SetParameters(Params(i).Name, Params(i).Value)
            Next
            'ReportViewer1.RefreshReport()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub frmReportes_Varios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarComboReportes(-1, -1)
            gbFiltros.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReporte.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        Dim res As Integer = 0
        If Not res = 0 Then
            Mensajes(res)
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor
        '------- Define variables necesarias para el metodo render ----------
        Dim historyID As String = Nothing

        Dim credentials As DataSourceCredentials() = Nothing
        Dim reportHistoryParameters As ParameterValue() = Nothing
        Dim forRendering As Boolean = False
        Dim parameters As ReportParameter() = Nothing
        Dim noDefault As Boolean = False

        Dim Nombre As String = ""

        Dim dt As DataTable
        Try

            dt = WS.Obtener_Reportes(Me.cboReporte.SelectedValue, -1).Tables(0)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows

                    Nombre = dr("dsNombre").ToString()
                    Exit For
                Next
                Dim url As String = WS.SvrReportServer & "/" & "Pages/ReportViewer.aspx?%2f" & WS.SvrReportPath & "%2f" & Nombre.Replace("/", "") & "&rs:Command=Render"




                WebBrowser1.Navigate(url)

                'ReportViewer1.ServerReport.ReportPath = (WS.SvrReportPath & Nombre) & "Company Sales&rs:Command=Render"
                'ReportViewer1.ServerReport.ReportServerUrl = New System.Uri(WS.SvrReportServer())
                '_returnedItems = Me.ReportViewer1.ServerReport.GetParameters()
                'Me.SetParameters(_returnedItems)

                '''reportHistoryParameters = Me.SetParameters(_returnedItems)
                ''Me.Ver_Reporte(reportHistoryParameters)
            Else

                Mensajes(4)
            End If


            Cursor.Current = Cursors.Default

        Catch exception As Exception

            HandleException(exception)

        Finally
            Cursor.Current = Cursors.Default

        End Try
    End Sub

    'Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
    '    Cursor.Current = Cursors.WaitCursor
    '    Dim res As Integer = 0

    '    If Not res = 0 Then

    '        Mensajes(res)
    '        Exit Sub
    '    End If

    '    Cursor.Current = Cursors.WaitCursor
    '    '------- Define variables necesarias para el metodo render ----------
    '    Dim historyID As String = Nothing

    '    Dim credentials As DataSourceCredentials() = Nothing
    '    Dim reportHistoryParameters As ParameterValue() = Nothing
    '    Dim forRendering As Boolean = False
    '    Dim parameters As ReportParameter() = Nothing
    '    Dim noDefault As Boolean = False

    '    Dim Nombre As String = ""

    '    Dim dt As DataTable
    '    Try

    '        dt = WS.Obtener_Reportes(Me.cboReporte.SelectedValue, -1).Tables(0)
    '        If dt.Rows.Count > 0 Then
    '            For Each dr As DataRow In dt.Rows

    '                Nombre = dr("dsNombre").ToString()
    '                Exit For
    '            Next
    '            Dim url As String = WS.SvrReportServer & "/" & "Pages/ReportViewer.aspx?%2f" & WS.SvrReportPath & "%2f" & Nombre.Replace("/", "") & "&rs:Command=Render"




    '            WebBrowser1.Navigate(url)

    '            'ReportViewer1.ServerReport.ReportPath = (WS.SvrReportPath & Nombre) & "Company Sales&rs:Command=Render"
    '            'ReportViewer1.ServerReport.ReportServerUrl = New System.Uri(WS.SvrReportServer())
    '            '_returnedItems = Me.ReportViewer1.ServerReport.GetParameters()
    '            'Me.SetParameters(_returnedItems)

    '            '''reportHistoryParameters = Me.SetParameters(_returnedItems)
    '            ''Me.Ver_Reporte(reportHistoryParameters)
    '        Else

    '            Mensajes(4)
    '        End If


    '        Cursor.Current = Cursors.Default

    '    Catch exception As Exception

    '        HandleException(exception)

    '    Finally
    '        Cursor.Current = Cursors.Default

    '    End Try
    'End Sub

#End Region

End Class