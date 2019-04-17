Public Class clsComprobantes
#Region "Variables y Propiedades"
    Private _cdPadre As Integer
    Private _intExp As Integer
    Private _dsConcepto As String
    Private _dsObservaciones As String
    Private _dsSubconcepto As String
    Private _cdconcepto As Integer
    Private _cdAreaRequirente As Integer
    Private _cdComprobante As Integer
    Private _cdTipoComprobante As Integer
    Private _cdClaseComprobante As Integer
    Private _dsNroComprobante As String
    Private _cdProveedor As Integer
    Private _sObservacion As String
    Private _dtFecha As DateTime
    Private _vlImporte As Decimal
    Private _cdMoneda As Integer
    Private _vlCotizacion As Decimal
    Private _cdTipoPeriodicidad As Integer
    Private _dsPeriodicidad As String
    Private _dtFechaDesde As Nullable(Of Date)
    Private _dtFechaHasta As Nullable(Of Date)
    Private _dtFechaAlta As Date
    Private _cdUsuarioAlta As Integer
    Private _arrArea As New List(Of clsAreas)
    Private _arrConcepto As New List(Of clsConceptos)
    Public _cdExpediente As Integer
    Public _dsMoneda As String
    Private _ArrC As New List(Of clsComprobantes)
    Private _cdDesglose As Integer

    Public Property cdDesglose() As Integer
        Get
            Return _cdDesglose
        End Get
        Set(ByVal value As Integer)
            _cdDesglose = value
        End Set
    End Property
    Public Property ArraC() As List(Of clsComprobantes)
        Get
            Return _ArrC
        End Get
        Set(ByVal value As List(Of clsComprobantes))
            _ArrC = value
        End Set
    End Property
    Public Property arrConcepto() As List(Of clsConceptos)
        Get
            Return _arrConcepto
        End Get
        Set(ByVal value As List(Of clsConceptos))
            _arrConcepto = value
        End Set
    End Property
    Public Property arrArea() As List(Of clsAreas)
        Get
            Return _arrArea
        End Get
        Set(ByVal value As List(Of clsAreas))
            _arrArea = value
        End Set
    End Property
    Public Property intExp() As Integer
        Get
            Return _intExp
        End Get
        Set(ByVal value As Integer)
            _intExp = value
        End Set
    End Property
    Public Property cdAreaRequirente() As Integer
        Get
            Return _cdAreaRequirente
        End Get
        Set(ByVal value As Integer)
            _cdAreaRequirente = value
        End Set
    End Property
    Public Property cdUsuarioAlta() As Integer
        Get
            Return _cdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            _cdUsuarioAlta = value
        End Set
    End Property
    Public Property dtFechaAlta() As Date
        Get
            Return _dtFechaAlta
        End Get
        Set(ByVal value As Date)
            _dtFechaAlta = value
        End Set
    End Property
    Public Property dtFechaHasta() As Nullable(Of Date)
        Get
            Return _dtFechaHasta
        End Get
        Set(ByVal value As Nullable(Of Date))
            _dtFechaHasta = value
        End Set
    End Property
    Public Property dtFechaDesde() As Nullable(Of Date)
        Get
            Return _dtFechaDesde
        End Get
        Set(ByVal value As Nullable(Of Date))
            _dtFechaDesde = value
        End Set
    End Property
    Public Property dsPeriodicidad() As String
        Get
            Return _dsPeriodicidad
        End Get
        Set(ByVal value As String)
            _dsPeriodicidad = value
        End Set
    End Property
    Public Property cdTipoPeriodicidad() As Integer
        Get
            Return _cdTipoPeriodicidad
        End Get
        Set(ByVal value As Integer)
            _cdTipoPeriodicidad = value
        End Set
    End Property
    Public Property vlCotizacion() As Decimal
        Get
            Return _vlCotizacion
        End Get
        Set(ByVal value As Decimal)
            _vlCotizacion = value
        End Set
    End Property
    Public Property cdMoneda() As Integer
        Get
            Return _cdMoneda
        End Get
        Set(ByVal value As Integer)
            _cdMoneda = value
        End Set
    End Property
    Public Property vlImporte() As Decimal
        Get
            Return _vlImporte
        End Get
        Set(ByVal value As Decimal)
            _vlImporte = value
        End Set
    End Property
    Public Property dtFecha() As DateTime
        Get
            Return _dtFecha
        End Get
        Set(ByVal value As DateTime)
            _dtFecha = value
        End Set
    End Property
    Public Property sObservacion() As String
        Get
            Return _sObservacion
        End Get
        Set(ByVal value As String)
            _sObservacion = value
        End Set
    End Property
    Public Property cdProveedor() As Integer
        Get
            Return _cdProveedor
        End Get
        Set(ByVal value As Integer)
            _cdProveedor = value
        End Set
    End Property
    Public Property dsNroComprobante() As String
        Get
            Return _dsNroComprobante
        End Get
        Set(ByVal value As String)
            _dsNroComprobante = value
        End Set
    End Property
    Public Property cdClaseComprobante() As Integer
        Get
            Return _cdClaseComprobante
        End Get
        Set(ByVal value As Integer)
            _cdClaseComprobante = value
        End Set
    End Property
    Public Property cdTipoComprobante() As Integer
        Get
            Return _cdTipoComprobante
        End Get
        Set(ByVal value As Integer)
            _cdTipoComprobante = value
        End Set
    End Property
    Public Property cdComprobante() As Integer
        Get
            Return _cdComprobante
        End Get
        Set(ByVal value As Integer)
            _cdComprobante = value
        End Set
    End Property
 

#End Region
#Region "Metodos"
    Public Function XmlDesglose_SinExpediente() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            For Each obj As clsComprobantes In Me.ArraC
                oXmlItem = oXml.CreateElement("row")
                oXml.DocumentElement.SetAttribute("cdComprobante", obj.cdComprobante)
                oXml.DocumentElement.SetAttribute("cdTipoComprobante", obj.cdTipoComprobante)
                oXml.DocumentElement.SetAttribute("cdClaseComprobante", obj.cdClaseComprobante)
                oXml.DocumentElement.SetAttribute("dsNroComprobante", obj.dsNroComprobante)
                oXml.DocumentElement.SetAttribute("cdProveedor", obj.cdProveedor)
                oXml.DocumentElement.SetAttribute("dtFecha", obj.dtFecha.ToString("yyyyMMdd"))
                oXml.DocumentElement.SetAttribute("vlImporte", obj.vlImporte.ToString().Replace(",", "."))
                oXml.DocumentElement.SetAttribute("cdMoneda", obj.cdMoneda)
                oXml.DocumentElement.SetAttribute("vlCotizacion", obj.vlCotizacion.ToString().Replace(",", "."))
                oXml.DocumentElement.SetAttribute("cdTipoPeriodicidad", obj.cdTipoPeriodicidad)
                oXml.DocumentElement.SetAttribute("dsPeriodicidad", obj.dsPeriodicidad.ToString())
                If obj.dtFechaDesde.HasValue Then
                    oXml.DocumentElement.SetAttribute("dtFechaDesde", obj.dtFechaDesde.Value.ToString("yyyyMMdd"))
                End If
                If obj.dtFechaHasta.HasValue Then
                    oXml.DocumentElement.SetAttribute("dtFechaHasta", obj.dtFechaHasta.Value.ToString("yyyyMMdd"))
                End If
                oXml.DocumentElement.SetAttribute("sObservacion", obj.sObservacion)
                oXml.DocumentElement.SetAttribute("dtFechaAlta", obj.dtFechaAlta.ToString("yyyyMMdd"))
                oXml.DocumentElement.SetAttribute("cdUsuarioAlta", 0)
                oXml.DocumentElement.SetAttribute("cdAreaRequirente", obj.cdAreaRequirente)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function

    Public Function SP_TOOLTIP_COMPROBANTES(ByVal cdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TOOLTIP_COMPROBANTES", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function

    Public Function SP_SELECCIONAR_COMPROBANTES_BYEXPEDIENTE(ByVal cdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECCIONAR_COMPROBANTES_BYEXPEDIENTE", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function

    Public Function VALIDA_EXPEDIENTESCOMPROBANTES_(ByVal cdComp As Integer, ByVal cdDesglose As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComp), _
                                                       New Data.SqlClient.SqlParameter("@cddesglosado", cdDesglose)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "VALIDA_EXPEDIENTESCOMPROBANTES_", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_TRAER_EXPEDIENTE_DESGLOSE(ByVal cdComp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TRAER_EXPEDIENTE_DESGLOSE", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function Val_BycdCom_BycdProveedor(ByVal cdComp As Integer, ByVal cdProv As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComp), _
                                    New Data.SqlClient.SqlParameter("@cdProveedor", cdProv)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_ValidaComprobantes_BycdComprobante", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function

    Public Function ValidarComprobantes_BycdProv(ByVal pdsComp As String, ByVal cdProv As Integer, ByVal pcdClaseC As Integer, ByVal pcdTipoC As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdProveedor", cdProv), _
                                    New Data.SqlClient.SqlParameter("@dsComprobante", pdsComp), _
                                    New Data.SqlClient.SqlParameter("@cdClaseC", pcdClaseC), _
                                    New Data.SqlClient.SqlParameter("@cdTipoC", pcdTipoC)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_ValidaComprobantes_BycdProveedor", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    'Public Function SP_TRAER_EC(ByVal pcdComp As Integer) As DataSet

    '    Dim ds As New DataSet()
    '    Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", pcdComp)}
    '    ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_OBTENER_EC", oParam)
    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Return ds
    '    Else
    '        Return ds
    '    End If
    'End Function

    'Public Function CompletarPeriodicidad_BycdComprobante(ByVal pcdComp As Integer) As DataSet

    '    Dim ds As New DataSet()
    '    Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", pcdComp)}
    '    ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TRAERDATOS_ByPericidad", oParam)
    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Return ds
    '    Else
    '        Return ds
    '    End If
    'End Function
    'Public Function SP_TRAERDATOS_ByUnidad(ByVal pcdComp As Integer) As DataSet

    '    Dim ds As New DataSet()
    '    Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", pcdComp)}
    '    ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TRAERDATOS_ByUnidad", oParam)
    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Return ds
    '    Else
    '        Return ds
    '    End If
    ''End Function
    'Public Function BusquedaComprobantes_filtros(ByVal cdNroComp As Integer, ByVal pdsComp As String, ByVal pdsExpediente As String, ByVal pcdProveedor As Integer, ByVal dtDesde As DateTime, ByVal dthasta As DateTime, ByVal intFecha As Integer, ByVal intClaseC As Integer, ByVal intTipoC As Integer, ByVal intEstado As Integer, ByVal intSinExp As Integer) As DataSet

    '    Dim ds As New DataSet()
    '    Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdNroComp), _
    '                                                    New Data.SqlClient.SqlParameter("@dsNroComprobante", pdsComp), _
    '                                                   New Data.SqlClient.SqlParameter("@dsExpediente", pdsExpediente), _
    '                                                   New Data.SqlClient.SqlParameter("@cdProveedor", pcdProveedor), _
    '                                                   New Data.SqlClient.SqlParameter("@dtDesde", dtDesde), _
    '                                                   New Data.SqlClient.SqlParameter("@dtHasta", dthasta), _
    '                                                   New Data.SqlClient.SqlParameter("@intSinFecha", intFecha), _
    '                                                  New Data.SqlClient.SqlParameter("@cdClaseC", intClaseC), _
    '                                                  New Data.SqlClient.SqlParameter("@cdTipoC", intTipoC), _
    '                                                  New Data.SqlClient.SqlParameter("@cdEstado", intEstado), _
    '                                                  New Data.SqlClient.SqlParameter("@cdSinExp", intSinExp)}
    '    ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_COMPROBANTES", oParam)

    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Return ds
    '    Else
    '        Return ds
    '    End If
    'End Function
    Public Function ObtenerEstados(ByVal pcdEstado As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdEstado", pcdEstado)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_ESTADO", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ObtenerTipoComprobantes(ByVal cdGrupo As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdGrupoTipo", cdGrupo)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_TipoCOMPROBANTES", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    'Public Function Obtener_cdComprobante(ByVal dsComprobante As String) As DataSet
    '    Dim ds As New DataSet()
    '    Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dsNroComp", dsComprobante)}
    '    ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_OBTENER_CDCOMPROBANTE_BYdsNroComprobante", oParam)
    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Return ds
    '    Else
    '        Return ds
    '    End If
    'End Function
    Public Function ObtenerClasesComprobantes(ByVal cdClaseComprobantes As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdClase", cdClaseComprobantes)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_CLASECOMPROBANTES_Todos", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ToXml() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim strXML As String = "<?xml version='1.0' encoding='windows-1252'?><Comprobante/>"
        oXml.LoadXml(strXML)
        For Each obj As clsComprobantes In ArraC
            oXml.DocumentElement.SetAttribute("cdComprobante", obj.cdComprobante)
            oXml.DocumentElement.SetAttribute("cdTipoComprobante", obj.cdTipoComprobante)
            oXml.DocumentElement.SetAttribute("cdClaseComprobante", obj.cdClaseComprobante)
            oXml.DocumentElement.SetAttribute("dsNroComprobante", obj.dsNroComprobante)
            oXml.DocumentElement.SetAttribute("cdProveedor", obj.cdProveedor)
            oXml.DocumentElement.SetAttribute("dtFecha", obj.dtFecha.ToString("yyyyMMdd"))
            oXml.DocumentElement.SetAttribute("vlImporte", obj.vlImporte.ToString().Replace(",", "."))
            oXml.DocumentElement.SetAttribute("cdMoneda", obj.cdMoneda)
            oXml.DocumentElement.SetAttribute("vlCotizacion", obj.vlCotizacion.ToString().Replace(",", "."))
            oXml.DocumentElement.SetAttribute("cdTipoPeriodicidad", obj.cdTipoPeriodicidad)
            oXml.DocumentElement.SetAttribute("dsPeriodicidad", obj.dsPeriodicidad.ToString())
            If obj.dtFechaDesde.HasValue Then
                oXml.DocumentElement.SetAttribute("dtFechaDesde", obj.dtFechaDesde.Value.ToString("yyyyMMdd"))
            End If
            If obj.dtFechaHasta.HasValue Then
                oXml.DocumentElement.SetAttribute("dtFechaHasta", obj.dtFechaHasta.Value.ToString("yyyyMMdd"))
            End If
            oXml.DocumentElement.SetAttribute("sObservacion", obj.sObservacion)
            oXml.DocumentElement.SetAttribute("dtFechaAlta", obj.dtFechaAlta.ToString("yyyyMMdd"))
            oXml.DocumentElement.SetAttribute("cdUsuarioAlta", 0)
            oXml.DocumentElement.SetAttribute("cdAreaRequirente", obj.cdAreaRequirente)
        Next
        oXmlItem = oXml.CreateElement("ExpedientesComprobantes")
        oXmlItem.SetAttribute("cdExpediente", intExp)
        oXmlItem.SetAttribute("cdComprobante", cdComprobante)
        oXmlItem.SetAttribute("cdDesglosado", Me.cdDesglose)
        oXml.ChildNodes(1).AppendChild(oXmlItem)
        Return oXml.OuterXml
    End Function

    'Inserta Comprobantes y ExpedientesComprobantes
    'INSERT_COMPROBANTESDESGLOSE_SIN_EXPEDIENTE
    Public Function INSERT_COMPROBANTESDESGLOSE_SIN_EXPEDIENTE(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
                                                           New Data.SqlClient.SqlParameter("@LastError ", intError)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "INSERT_COMPROBANTESDESGLOSE_SIN_EXPEDIENTE", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function INSERT_COMPROBANTES_CE(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
                                                           New Data.SqlClient.SqlParameter("@LastError ", intError)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "INSERT_EXPEDIENTESCOMPROBANTES", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UPDATE_COMPROBANTES(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
                                                           New Data.SqlClient.SqlParameter("@LastError ", intError)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_UPDATE_EXPEDIENTESCOMPROBANTES", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(ByVal cdComprobante As Integer, ByVal cdExp As Integer, ByVal intError As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComprobante), _
                                                                    New Data.SqlClient.SqlParameter("@cdExpediente", cdExp), _
                                                                  New Data.SqlClient.SqlParameter("@lasterror", intError)}
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES", oParam)
        Return ds

    End Function
    Public Function ELIMINAR_RELACION_COMPROBANTES(ByVal cdComprobante As Integer, ByVal cdExp As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComprobante), _
                                                                    New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ELIMINAR_RELACION_COMPROBANTES", oParam)
        Return ds

    End Function
#End Region
End Class
Public Class clsComprobante

    Private _colExpediente As Integer
    Private _codComprobante As Integer
    Private _dsComprobante As String
    Private _dsComprobanteTipoClase As String
    Public _dtFecha As String
    Public _monto As Decimal
    Private _cdClaseComp As Integer
    Private _cdTipoC As Integer
    Public _dsObservacion As String
    Public _cdUnidad As Integer
    Private _dsUnidad As String
    Public _cdPerio As Integer
    Public _dsPerio As String
    Public _cdProveedor As Integer
    Private _cdMoneda As Integer
    Private _dsMoneda As String
    Public _vlCotizacion As Decimal
    Public _dtFechaAlta As DateTime
    Public _dtFechaDesde As DateTime
    Public _dtFechaHasta As DateTime
    Public _cdDesglose As Integer
    Private _dsClaseComprobante As String
    Private _dsTipoComprobante As String
    Private _vlImporteFinal As Decimal

    Public Property colExp() As Integer
        Get
            Return _colExpediente
        End Get
        Set(ByVal value As Integer)
            _colExpediente = value
        End Set
    End Property
    Public Property codComprobante() As Integer
        Get
            Return _codComprobante
        End Get
        Set(ByVal value As Integer)
            _codComprobante = value
        End Set
    End Property
    Public Property dsComprobante() As String
        Get
            Return _dsComprobante
        End Get
        Set(ByVal value As String)
            _dsComprobante = value
        End Set
    End Property
    Public Property dsComprobanteClaseTipo() As String
        Get
            Return _dsComprobanteTipoClase
        End Get
        Set(ByVal value As String)
            _dsComprobanteTipoClase = value
        End Set
    End Property
    Public Property dtFecha() As String
        Get
            Return _dtFecha
        End Get
        Set(ByVal value As String)
            _dtFecha = value
        End Set
    End Property
    Public Property cdMoneda() As Integer
        Get
            Return _cdMoneda
        End Get
        Set(ByVal value As Integer)
            _cdMoneda = value
        End Set
    End Property
    Public Property dsMoneda() As String
        Get
            Return _dsMoneda
        End Get
        Set(ByVal value As String)
            _dsMoneda = value
        End Set
    End Property
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Public Property cdClaseComp() As Integer
        Get
            Return _cdClaseComp
        End Get
        Set(ByVal value As Integer)
            _cdClaseComp = value
        End Set
    End Property
    Public Property cdTipoC() As Integer
        Get
            Return _cdTipoC
        End Get
        Set(ByVal value As Integer)
            _cdTipoC = value
        End Set
    End Property
    Public Property dsObservacion() As String
        Get
            Return _dsObservacion
        End Get
        Set(ByVal value As String)
            _dsObservacion = value
        End Set
    End Property
    Public Property cdUnidad() As Integer
        Get
            Return _cdUnidad
        End Get
        Set(ByVal value As Integer)
            _cdUnidad = value
        End Set
    End Property
    Public Property dsUnidad() As String
        Get
            Return _dsUnidad
        End Get
        Set(ByVal value As String)
            _dsUnidad = value
        End Set
    End Property
    Public Property cdPerio() As Integer
        Get
            Return _cdPerio
        End Get
        Set(ByVal value As Integer)
            _cdPerio = value
        End Set
    End Property
    Public Property dsPerio() As String
        Get
            Return _dsPerio
        End Get
        Set(ByVal value As String)
            _dsPerio = value
        End Set
    End Property
    Public Property cdProveedor() As Integer
        Get
            Return _cdProveedor
        End Get
        Set(ByVal value As Integer)
            _cdProveedor = value
        End Set
    End Property
    Public Property dtFechaAlta() As DateTime
        Get
            Return _dtFechaAlta
        End Get
        Set(ByVal value As DateTime)
            _dtFechaAlta = value
        End Set
    End Property

    Public Property coldtFechaHasta() As DateTime
        Get
            Return _dtFechaHasta
        End Get
        Set(ByVal value As DateTime)
            _dtFechaHasta = value
        End Set
    End Property
    Public Property coldtFechaDesde() As DateTime
        Get
            Return _dtFechaDesde
        End Get
        Set(ByVal value As DateTime)
            _dtFechaDesde = value
        End Set
    End Property
    Public Property EscdDesglose() As Integer
        Get
            Return _cdDesglose
        End Get
        Set(ByVal value As Integer)
            _cdDesglose = value
        End Set
    End Property

    Public Property dsClaseComprobante() As String
        Get
            Return _dsClaseComprobante
        End Get
        Set(ByVal value As String)
            _dsClaseComprobante = value
        End Set
    End Property
    Public Property dsTipoComprobante() As String
        Get
            Return _dsTipoComprobante
        End Get
        Set(ByVal value As String)
            _dsTipoComprobante = value
        End Set
    End Property
    Public Property vlImporteFinal() As Decimal
        Get
            Return _vlImporteFinal
        End Get
        Set(ByVal value As Decimal)
            _vlImporteFinal = value
        End Set
    End Property

    Public Property vlCotizacion() As Decimal
        Get
            Return _vlCotizacion
        End Get
        Set(ByVal value As Decimal)
            _vlCotizacion = value
        End Set
    End Property
    Private _dsAbreviatura As String
    Public Property dsAbreviatura() As String
        Get
            Return _dsAbreviatura
        End Get
        Set(ByVal value As String)
            _dsAbreviatura = value
        End Set
    End Property
End Class
