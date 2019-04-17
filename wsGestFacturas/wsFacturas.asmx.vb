Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports clsFacturas
Imports Microsoft.VisualBasic
Imports System.Xml

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class wsFacturas
    Inherits System.Web.Services.WebService
    Dim CONN_STRING As String = ConfigurationManager.AppSettings("ConnectionString")
    Public ReadOnly Property cdSistema() As Integer
        Get
            Return ConfigurationManager.AppSettings("cdSistema")
        End Get
        'Set(ByVal value As Integer)

        'End Set
    End Property

    Public Sub New()
        Try
            clsFacturas.CONN_STRING = Me.CONN_STRING

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    <WebMethod()> _
    Public Function NroSistema() As Integer
        Try
            Return cdSistema
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#Region "Select"
    <WebMethod()> _
Public Function SP_OBTENERPROVEEDOR_PORCODIGO(ByVal pcdprov As Integer) As DataSet
        Dim obj As New clsProveedores
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerProveedor_por_codigo(pcdprov)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function SP_SELECCIONAR_COMPROBANTES_BYEXPEDIENTE(ByVal pcdExp As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_SELECCIONAR_COMPROBANTES_BYEXPEDIENTE(pcdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
 Public Function Obtener_Reportes(ByVal cdReporte As Integer, ByVal cdTipoReporte As Integer) As DataSet

        Dim obj As New clsReportes
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerReportes(cdReporte, cdTipoReporte)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    <WebMethod()> _
Public Function OBTENER_ULTIMO_ESTADO(ByVal cdExp As Integer) As DataSet
        Dim cls As New clsSeguimientoExpedientes
        Try
            Dim ds As New DataSet()
            ds = cls.SP_OBTENER_ULTIMO_ESTADO(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function VALIDA_EXPEDIENTESCOMPROBANTES_(ByVal cdComp As Integer, ByVal cdDesglose As Integer) As DataSet
        Dim cls As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = cls.VALIDA_EXPEDIENTESCOMPROBANTES_(cdComp, cdDesglose)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_TipoExpediente(ByVal int As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.Obtener_TipoExpedientes(int)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
 Public Function Obtener_Proveedores_Bycuit(ByVal pdscuit As String, ByVal pdsBene As String) As DataSet
        Dim obj As New clsProveedores
        Try
            Dim ds As New DataSet()
            ds = obj.Obtener_Proveedores_Bycuit(pdscuit, pdsBene)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
  Public Function Obtener_SuConcepto(ByVal pcdPadre As Integer) As DataSet
        Dim obj As New clsConceptos
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerSubConceptos(pcdPadre)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <WebMethod()> _
Public Function OBTENER_ESTADOS_ByEXPEDIENTE(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_ESTADOS_ByEXPEDIENTE(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Val_BycdCom_BycdProveedor(ByVal cdComp As Integer, ByVal cdProv As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.Val_BycdCom_BycdProveedor(cdComp, cdProv)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function ValidarComprobantes_BycdProv(ByVal dsComp As String, ByVal cdProv As Integer, ByVal pcdClaseC As Integer, ByVal pcdTipoC As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.ValidarComprobantes_BycdProv(dsComp, cdProv, pcdClaseC, pcdTipoC)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '    <WebMethod()> _
    'Public Function SP_Obtener_EC(ByVal cdComp As Integer) As DataSet
    '        Dim obj As New clsComprobantes
    '        Try
    '            Dim ds As New DataSet()
    '            ds = obj.SP_TRAER_EC(cdComp)
    '            Return ds
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Function
    <WebMethod()> _
Public Function SP_ValidaCotizacion_BycdMoneda_byFecha(ByVal intMoneda As Integer, ByVal dtFecha As DateTime) As DataSet
        Dim obj As New clsCotizaciones
        Try
            Dim ds As New DataSet()
            ds = obj.SP_ValidaCotizacion_BycdMoneda_byFecha(intMoneda, dtFecha)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function TraerPantalla_ByConcepto(ByVal pcdExp As Integer) As DataSet
        Dim obj As New clsConceptos
        Try
            Dim ds As New DataSet()
            ds = obj.SP_TRAERDATOS_ByConceptos(pcdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '    <WebMethod()> _
    'Public Function TraerPantalla_ByuNIDAD(ByVal pcdComp As Integer) As DataSet
    '        Dim obj As New clsComprobantes
    '        Try
    '            Dim ds As New DataSet()
    '            ds = obj.SP_TRAERDATOS_ByUnidad(pcdComp)
    '            Return ds
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Function
    '    <WebMethod()> _
    'Public Function TraerPantalla_BycdComprobante(ByVal pcdComp As Integer) As DataSet
    '        Dim obj As New clsComprobantes
    '        Try
    '            Dim ds As New DataSet()
    '            ds = obj.CompletarPeriodicidad_BycdComprobante(pcdComp)
    '            Return ds
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Function
    '   <WebMethod()> _
    'Public Function BusquedaFiltradaComprobantes(ByVal cdNroComp As Integer, ByVal pdsComp As String, ByVal pdsExpediente As String, ByVal pcdProveedor As Integer, ByVal dtDesde As DateTime, ByVal dthasta As DateTime, ByVal intFecha As Integer, ByVal intClaseC As Integer, ByVal intTipoC As Integer, ByVal intEstado As Integer, ByVal intSinExp As Integer) As DataSet
    '       Dim obj As New clsComprobantes
    '       Try
    '           Dim ds As New DataSet()
    '           ds = obj.BusquedaComprobantes_filtros(cdNroComp, pdsComp, pdsExpediente, pcdProveedor, dtDesde, dthasta, intFecha, intClaseC, intTipoC, intEstado, intSinExp)
    '           Return ds
    '       Catch ex As Exception
    '           Throw ex
    '       End Try
    '   End Function
    <WebMethod()> _
Public Function BusquedaFiltradaExpedientes(ByVal pdsExp As String, ByVal pcdProveedor As Integer, ByVal dtDesde As DateTime, ByVal dthasta As DateTime, ByVal intEstado As Integer, ByVal cdClaseC As Integer, ByVal cdTipoC As Integer, ByVal dsNroComp As String, ByVal dsObservacion As String, ByVal pcdTipoExpediente As Integer, ByVal pcdNoLiq As Integer, ByVal pcdArea As Integer, ByVal pcdAreaMov As Integer, ByVal pcdSinRel As Integer, ByVal pcdEtapa As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.BusquedaExpedientes_filtros(pdsExp, pcdProveedor, dtDesde, dthasta, intEstado, cdClaseC, cdTipoC, dsNroComp, dsObservacion, pcdTipoExpediente, pcdNoLiq, pcdArea, pcdAreaMov, pcdSinRel, pcdEtapa)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
  Public Function Obtener_codExpediente(ByVal pdsExp As String) As DataSet ', ByVal cdProv As Integer) 
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.Obtener_cdExtediente(pdsExp) ', cdProv)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
 Public Function Obtener_ComprobantesAsociados(ByVal cdExp As Integer, ByVal cdAgrupado As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_BusquedaComprobantes_Asociados(cdExp, cdAgrupado)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
    Public Function SP_Busqueda_ConvenioOtros(ByVal cdExp As Integer, ByVal cdAgrupado As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_Busqueda_ConvenioOtros(cdExp, cdAgrupado)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    <WebMethod()> _
     Public Function Obtener_Estados(ByVal pcdEstado As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerEstados(pcdEstado)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
    Public Function Obtener_Etapa(ByVal pcdValor As Integer) As DataSet
        Dim obj As New clsSeguimientoExpedientes()
        Try
            Dim ds As New DataSet()
            ds = obj.OBTENER_ETAPA(pcdValor)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
      Public Function Obtener_Proveedores_Organismos(ByVal EsExterior As Integer, ByVal cdBaja As Integer) As DataSet
        Dim obj As New clsProveedores()

        Try
            Dim ds As New DataSet()
            ds = obj.Obtener_Proveedores_Organismos(EsExterior, cdBaja)

            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_ClaseComprobantes(ByVal cdClaseComp As Integer) As DataSet
        Dim obj As New clsComprobantes()
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerClasesComprobantes(cdClaseComp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            Else
                Return ds
            End If
        Catch ex As Exception
            Throw ex

        End Try


    End Function
    <WebMethod()> _
  Public Function Obtener_TipoComprobantes(ByVal cdGrupo As Integer) As DataSet
        Dim obj As New clsComprobantes()
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerTipoComprobantes(cdGrupo)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            Else
                Return ds
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <WebMethod()> _
  Public Function Obtener_Monedas(ByVal cdMoneda As Integer) As DataSet
        Dim obj As New clsCotizaciones
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerMoneda(cdMoneda)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            Else
                Return ds
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
    Public Function Obtener_TipoPeriodicidad(ByVal cdValor As Integer) As DataSet
        Dim obj As New clsPeriodicidad
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerTipoPeriodicidad(cdValor)

            Return ds

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
    Public Function Obtener_Periodicidad(ByVal cdTipo As Integer) As DataSet
        Dim obj As New clsPeriodicidad
        Try
            Dim ds As New DataSet()
            ds = obj.SP_SELECT_PERIODICIDAD(cdTipo)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_Conceptos(ByVal cdconcepto As Integer) As DataSet
        Dim obj As New clsConceptos
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerConceptos(cdconcepto)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_Areas(ByVal intArea As Integer, ByVal dsNombre As String) As DataSet
        Dim obj As New clsAreas
        Try
            Dim ds As New DataSet()
            ds = obj.ObtenerAreas(intArea, dsNombre)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_Cotizaciones(ByVal intMoneda As Integer) As DataSet
        Dim obj As New clsCotizaciones
        Try
            Dim ds As New DataSet()
            ds = obj.SELECT_TIPOCOTIZACION(intMoneda)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'ValidarConcepto 
    <WebMethod()> _
Public Function ValidarDesglose(ByVal dsNroExp As String) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.VALIDAR_DESGLOSE(dsNroExp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function ValidarConcepto(ByVal dsConcepto As String, ByVal cdNivel As Integer) As DataSet
        Dim obj As New clsConceptos
        Try
            Dim ds As New DataSet()
            ds = obj.ValidarConcepto(dsConcepto, cdNivel)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds


        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function TRAER_EXPEDIENTE_DESGLOSADO(ByVal cdComp As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_TRAER_EXPEDIENTE_DESGLOSE(cdComp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function SelectIndicadoresGestion(ByVal pcdAnio As Integer, ByVal pcdMes As Integer) As DataSet
        Dim obj As New clsValoresIniciales
        Try
            Dim ds As New DataSet()
            ds = obj.SelectIndicadoresGestion(pcdAnio, pcdMes)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'SP_TOOLTIP_COMPROBANTES(ByVal cdExp As Integer) As DataSet
    <WebMethod()> _
Public Function SP_TOOLTIP_COMPROBANTES(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_TOOLTIP_COMPROBANTES(cdExp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function SP_TOOLTIP_MovimientosDelExpediente(ByVal cdSeg As Integer) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_ToolTip_MovimientoDelExpediente(cdSeg)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function SP_TOOLTIP_OBSERVACION(ByVal pcdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_TOOLTIP_OBSERVACION(pcdExp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Obtener_dsExtedienteRel
    <WebMethod()> _
Public Function SP_SELECT_NroExpedienteRel(ByVal pcdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.Obtener_dsExtedienteRel(pcdExp)
            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds
            End If
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_ComprobantesRel(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_BusquedaComprobantes_Rel(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_ComprobantesTodos(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_BusquedaComprobantes_Todos(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Obtener_UltimaEtapa(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.SP_UltimaEtapa(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function VALIDAR_ANEXADO(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.VALIDAR_ANEXADO(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '
    <WebMethod()> _
Public Function VALIDAR_INFORMANDOEXPEDIENTEANEXADO(ByVal cdExp As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Dim ds As New DataSet()
            ds = obj.VALIDAR_INFORMANDOEXPEDIENTEANEXADO(cdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "INSERT"
    <WebMethod()> _
  Public Function INSERT_DESGLOSE(ByVal strXml As String) As DataSet
        Dim obj As New clsExpedientes
        Dim ds As New DataSet
        Try
            ds = obj.INSERT_DESGLOSE(strXml)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
  Public Function ExpedientesConceptos_IU(ByVal strXml As String) As DataSet
        Dim obj As New clsConceptos
        Dim ds As New DataSet
        Try
            ds = obj.ExpedientesConceptos_IU(strXml)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
 Public Function CONCEPTOS_I(ByVal strXml As String) As DataSet
        Dim obj As New clsConceptos
        Dim ds As New DataSet
        Try
            ds = obj.Conceptos_I(strXml)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
   Public Function Insert_COMPROBANTES_EC(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Dim obj As New clsComprobantes
        Dim ds As New DataSet
        Try
            ds = obj.INSERT_COMPROBANTES_CE(strXml, intError)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
  Public Function Insert_E(ByVal strXml As String) As DataSet
        Dim obj As New clsExpedientes
        Dim ds As New DataSet
        Try
            ds = obj.INSERT_EXPEDIENTES(strXml)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
  Public Function Insert_SEGUIMIENTO_ESTADO(ByVal strXml As String) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Dim ds As New DataSet
        Try
            ds = obj.INSERT_SEGUIMIENTO_ESTADO(strXml)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
Public Function Insert_DESGLOSECOMPROBANTES_SIN_EXPEDIENTES(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Dim obj As New clsComprobantes
        Dim ds As New DataSet
        Try
            ds = obj.INSERT_COMPROBANTESDESGLOSE_SIN_EXPEDIENTE(strXml, intError)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
   Public Sub Proveedor_IU(ByVal TOXML As String)
        Dim obj As New clsProveedores
        Try
            obj.PROVEEDOR_IU(TOXML)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    <WebMethod()> _
 Public Function CotizacionMoneda_IU(ByVal TOXML As String) As DataSet
        Dim obj As New clsCotizaciones
        Dim ds As New DataSet
        ds = obj.TbMonedaCotizaciones_IU(TOXML)
        Return ds
    End Function
    <WebMethod()> _
Public Function ExpedientesConveniosOtros_IU(ByVal TOXML As String) As DataSet
        Dim obj As New clsExpedientesConvenioOtros
        Dim ds As New DataSet
        ds = obj.ExpedientesConveniosOtros_IU(TOXML)
        Return ds
    End Function
#End Region
#Region "UPDATE"
    'UPDATE_COMPROBANTES
    <WebMethod()> _
      Public Function Update_C(ByVal strXml As String, ByVal intError As Integer) As DataSet
        Dim obj As New clsComprobantes
        Dim ds As New DataSet
        Try
            ds = obj.UPDATE_COMPROBANTES(strXml, intError)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
   Public Function Update_Seguimiento(ByVal pcdSeg As Integer, ByVal sObs As String) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Dim ds As New DataSet
        Try
            ds = obj.UpdateSeguimiento(pcdSeg, sObs)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '<WebMethod()> _
    '  Public Function Update_E(ByVal strXml As String, ByVal intError As Integer) As DataSet
    '    Dim obj As New clsExpedientes
    '    Dim ds As New DataSet
    '    Try
    '        ds = obj.UPDATE_EXPEDIENTES(strXml, intError)
    '        Return ds
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
#End Region
#Region "DELETE"
    'ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES
    <WebMethod()> _
       Public Function ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(ByVal cdComprobante As Integer, ByVal cdExp As Integer, ByVal intError As Integer) As DataSet
        Dim obj As New clsExpedientes
        Try
            Return obj.ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(cdComprobante, cdExp, intError)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
      Public Function ELIMINAR_RELACION_COMPROBANTES(ByVal cdComprobante As Integer, ByVal cdExp As Integer) As DataSet
        Dim obj As New clsComprobantes
        Try
            Return obj.ELIMINAR_RELACION_COMPROBANTES(cdComprobante, cdExp)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
         Public Function Delete_Conceptos(ByVal pcdExp As String, ByVal pcdConcepto As Integer) As DataSet
        Dim obj As New clsConceptos
        Try
            Return obj.DELETE_Conceptos(pcdExp, pcdConcepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
         Public Function Delete_Movimientos(ByVal pcdSeg As Integer, ByVal pcdExp As String) As DataSet
        Dim obj As New clsSeguimientoExpedientes
        Try
            Return obj.DELETE_MOVIMIENTOS(pcdSeg, pcdExp)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'DELETE_EXPEDIENTE_RELACIONES
    <WebMethod()> _
         Public Function DELETE_EXPEDIENTE_RELACIONES(ByVal pcdExp As String) As DataSet
        Dim obj As New clsExpedientes
        Dim ds As New DataSet
        Try
            ds = obj.DELETE_EXPEDIENTE_RELACIONES(pcdExp)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

    <WebMethod()> _
   Public Function SvrReportPath() As String
        Try
            Return ConfigurationManager.AppSettings("REPORT_PATH")

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <WebMethod()> _
 Public Function SvrReportServer() As String
        Try
            Return ConfigurationManager.AppSettings("REPORT_SERVER")

        Catch ex As Exception
            Throw ex
        End Try
    End Function



 
End Class