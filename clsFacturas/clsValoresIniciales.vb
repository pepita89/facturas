Public Class clsValoresIniciales
#Region "Metodos"
    '
    Public Function SelectIndicadoresGestion(ByVal cdAnio As Integer, ByVal cdMes As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdAnio", cdAnio), _
                                                       New Data.SqlClient.SqlParameter("@cdMes", cdMes)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SelectIndicadoresGestion", oParam)
        Return ds
    End Function
#End Region
End Class
