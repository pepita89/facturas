Imports System.Text.RegularExpressions

Imports clsFacturas
Public Class frmMovimientosdelExpediente
    Public ocls As New clsSeguimientoExpedientes
    Public _cdExp As Integer
    Public codAreaE As Integer
    Public _cdSeg As Integer
    Private ArrAreas As New ArrayList
    Public strArea As String = ""
    Public _Modo As Integer
    Public _cbocdEstado As Integer
    Public _cbocdEtapa As Integer
    Public _cbodsEstado As String
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
    Public Sub CargarAreasNombre()
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
    Public Sub CargarMovimiento()
        Try
            Dim arr As New List(Of clsSeguimientoExpedientes)
            If (_cdSeg <> 0) Then
                ocls.codSeguimiento = _cdSeg
            Else
                ocls.codSeguimiento = 0
            End If
            ocls.codExpediente = Me._cdExp
            ocls.cdEstado = Me.cboEstado.SelectedValue
            ocls.dtFecha = Me.dtFechaN.Value
            ocls.cdArea = Me.codAreaE
            ocls.cdBaja = 0
            ocls.sObservaciones = Me.txtObservacion.Text
            ocls.cdEtapa = Me.cboEtapa.SelectedValue
            arr.Add(ocls)
            ocls.ArraS = arr
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CargarModificacion()
        '      Me.cboEstado.SelectedValue = _Modo
        CargarEstado()
        CargarEtapa()
        cboEtapa.SelectedValue = _cbocdEtapa
        ' Me.cboEstado.SelectedValue = _Modo
        CargarAreasNombre()
    End Sub
    'Obtener_Etapa
    Public Sub CargarEtapa()
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_Etapa(-1)
            If (ds.Tables(0).Rows().Count > 0) Then
                Me.cboEtapa.DisplayMember = "dsValor"
                Me.cboEtapa.ValueMember = "cdValor"
                cboEtapa.DataSource = ds.Tables(0)
                cboEtapa.SelectedValue = _cbocdEtapa
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CargarEstado()
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_Estados(-1)
            If (ds.Tables(0).Rows().Count > 0) Then
                Me.cboEstado.DisplayMember = "dsEstado"
                Me.cboEstado.ValueMember = "cdEstado"
                cboEstado.DataSource = ds.Tables(0)
                cboEstado.SelectedValue = _cbocdEstado
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CargarUltimaEtapa()
        Try
            Dim ds As New DataSet
            ds = WS.Obtener_UltimaEtapa(_cdExp)
            If (ds.Tables(0).Rows.Count > 0) Then
                If (ds.Tables(0).Rows(0).Item("cdEtapa") <> 0) Then
                    Me.cboEtapa.SelectedValue = ds.Tables(0).Rows(0).Item("cdEtapa")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmMovimientosdelExpediente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (_Modo = 0) Then

                CargarEstado()
                CargarAreasNombre()
                CargarEtapa()
                CargarUltimaEtapa()
            ElseIf (_Modo <> 0) Then
                CargarModificacion()
                CargarEstado()
                CargarEtapa()
                CargarUltimaEtapa()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdAgregarComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarComp.Click
        Try
            If (Me.mtxtArea.Text <> "" Or Me.codAreaE <> 0) Then
                CargarMovimiento()
                Dim ds As New DataSet
                ds = WS.Insert_SEGUIMIENTO_ESTADO(ocls.ToXml)
                Me.Close()
            Else
                MessageBox.Show("Debe Ingresar el Area")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dtFechaN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaN.ValueChanged

    End Sub
    Private Sub mtxtArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtArea.Leave
        Me.codAreaE = getCodArea(mtxtArea.Text)
    End Sub
End Class