Imports System.Web.Services.Protocols
Imports clsFacturas
Module VariablesGlobales
    Public WS As New Facturas.wsfacturas.wsFacturas()
    Public wsSeg As New wsSeguridad.Seguridad
    Public oLogin As New wsSeguridad.clsLogin

    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890,.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
End Module
