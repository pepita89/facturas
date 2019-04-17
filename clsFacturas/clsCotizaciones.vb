Public Class clsCotizaciones
    Public _dtFecha As DateTime
    Public _cdMoneda As Integer
    Public _vlCotizacion As Decimal
    Public Property dtFecha() As DateTime
        Get
            Return _dtFecha
        End Get
        Set(ByVal value As DateTime)
            value = _dtFecha
        End Set
    End Property
    Public Property cdMoneda() As Integer
        Get
            Return _cdMoneda
        End Get
        Set(ByVal value As Integer)
            value = _cdMoneda
        End Set
    End Property
    Public Property vlCotizacion()
        Get
            Return _vlCotizacion
        End Get
        Set(ByVal value)
            value = _vlCotizacion
        End Set
    End Property
    '
    Public Function SP_ValidaCotizacion_BycdMoneda_byFecha(ByVal cdMoneda As Integer, ByVal dtFecha As DateTime) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdMoneda", cdMoneda), _
                                                       New Data.SqlClient.SqlParameter("@dtFecha", dtFecha)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_ValidaCotizacion_BycdMoneda_byFecha", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ObtenerMoneda(ByVal cdMoneda As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdMoneda", cdMoneda)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_Moneda", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SELECT_TIPOCOTIZACION(ByVal pcdMoneda As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdMoneda", pcdMoneda)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_Tipo_Cotizacion", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ToXmlc() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            oXmlItem = oXml.CreateElement("row")
            oXmlItem.SetAttribute("cdMoneda", cdMoneda)
            oXmlItem.SetAttribute("dtFecha", dtFecha.ToString("yyyyMMdd"))
            oXmlItem.SetAttribute("vlCotizacion", vlCotizacion.ToString().Replace(",", "."))
            oXml.ChildNodes(1).AppendChild(oXmlItem)
        End With
        Return oXml.OuterXml
    End Function
    Public Function TbMonedaCotizaciones_IU(ByVal ToXml As String) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", ToXml)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "TbMonedaCotizaciones_IU", oParam)
        Return ds
    End Function
End Class
