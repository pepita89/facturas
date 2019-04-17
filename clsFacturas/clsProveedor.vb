Public Class clsProveedor
    Private _cdProveedor As Integer
    Private _dsProveedor As String
    Private _dsCuit As String
    Public _cdGrupo As Integer
    Private _dsNroBeneficiario As String
    Private _cdEsExterior As Integer

#Region "Propiedades"
   
    Public Property cdProveedor() As Integer
        Get
            Return _cdProveedor
        End Get
        Set(ByVal value As Integer)
            _cdProveedor = value
        End Set
    End Property
    Public Property dsProveedor() As String
        Get
            Return _dsProveedor
        End Get
        Set(ByVal value As String)
            _dsProveedor = value
        End Set
    End Property
    Public Property dsCuit() As String
        Get
            Return _dsCuit
        End Get
        Set(ByVal value As String)
            _dsCuit = value
        End Set
    End Property
    Public Property dsNroBeneficiario() As String
        Get
            Return _dsNroBeneficiario
        End Get
        Set(ByVal value As String)
            _dsNroBeneficiario = value
        End Set
    End Property
    Public Property cdEsExterior() As Integer
        Get
            Return _cdEsExterior
        End Get
        Set(ByVal value As Integer)
            _cdEsExterior = value
        End Set
    End Property
#End Region

    
End Class
Public Class clsProveedores
    Public _cdGrupo As Integer
    Public dsRazonSocial As String
    Public dsNroDocumento As String
    Public cdProveedor As Integer
    Public cdExterior As Integer
    Public dsNroBeneficiario As String
#Region "METODOS"


    Public Function ToXml() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            oXmlItem = oXml.CreateElement("row")
            oXmlItem.SetAttribute("cdProveedor", cdProveedor)
            oXmlItem.SetAttribute("dsRazonSocial", dsRazonSocial)
            oXmlItem.SetAttribute("dsNroDocumento", dsNroDocumento)
            oXmlItem.SetAttribute("cdEsExterior", cdExterior)
            oXmlItem.SetAttribute("dsNroBeneficiario", dsNroBeneficiario)
            oXmlItem.SetAttribute("cdBaja", intBaja)
            oXml.ChildNodes(1).AppendChild(oXmlItem)
        End With
        Return oXml.OuterXml
    End Function
    'Select_Proveedor_Bycuit
    Public Function Obtener_Proveedores_Bycuit(ByVal pdsCuit As String, ByVal pdsBene As String) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dscuit ", pdsCuit), _
                                                       New Data.SqlClient.SqlParameter("@dsbeneficio", pdsBene)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "Select_Proveedor_Bycuit", oParam)

        Return ds
    End Function
    Public Sub PROVEEDOR_IU(ByVal ToXml As String)

        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", ToXml)}
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "PROVEEDORES_IU", oParam)

    End Sub

    Public Function Obtener_Proveedores_Organismos(ByVal Exterior As Integer, ByVal cdbaja As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExterior ", Exterior), _
                                       New Data.SqlClient.SqlParameter("@cdBaja", cdbaja)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_PROVEEDORES_ORGANISMOS_SELECT", oParam)
       
        Return ds
    End Function
    Public Function ObtenerProveedor_por_codigo(ByVal pcodProv As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdprov", pcodProv)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_PROVEEDORES_CODPROVEEDOR", oParam)
        Return ds
    End Function
#End Region
End Class
