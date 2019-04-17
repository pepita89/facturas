Public Class clsPeriodicidad
    Private _dsPeriodicidad As String
    Private _dtFechaInicio As DateTime
    Private _dtFechaFin As DateTime
    Public Property dsPeriodicidad() As String
        Get
            Return _dsPeriodicidad
        End Get
        Set(ByVal value As String)
            _dsPeriodicidad = value
        End Set
    End Property
    Public Property dtFechaInicio() As DateTime
        Get
            Return _dtFechaInicio
        End Get
        Set(ByVal value As DateTime)
            value = _dtFechaInicio
        End Set
    End Property
    Public Property dtFechaFin() As DateTime
        Get
            Return _dtFechaFin
        End Get
        Set(ByVal value As DateTime)
            value = _dtFechaFin
        End Set
    End Property
#Region "Metodos"

    Public Function ObtenerTipoPeriodicidad(ByVal cdValor As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdValor", cdValor)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_TIPO_PERIODICIDAD", oParam)
        Return ds

    End Function

    'SP_SELECT_PERIODICIDAD 
    Public Function SP_SELECT_PERIODICIDAD(ByVal cdTipo As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdTipoPeriodicidad", cdTipo)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_PERIODICIDAD", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        End If
        Return ds
    End Function
#End Region

End Class
