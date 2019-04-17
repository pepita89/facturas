Imports clsFacturas
Public Class frmInicio
    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '   Me.lblVersion.Text = My.Application.Info.Version.ToString()
            Dim dtActual As Date = Me.dt.Value
            Dim dtMesAnterior As Date = Me.dthasta.Value.AddMonths(-1)
            Dim dsActual As New DataSet
            dsActual = WS.SelectIndicadoresGestion(dtActual.Year, Me.dthasta.Value.Month)
            If (dsActual.Tables.Count > 0) Then
                Dim vlPC, vlTC As Decimal
                Dim intPCC, intTCC, intPCE, intTCE As Integer

                For i As Integer = 0 To dsActual.Tables.Count - 1

                    For j As Integer = 0 To dsActual.Tables(i).Rows.Count - 1
                        If i = 0 Then
                            If (dsActual.Tables(i).Rows(j).Item("dsestado") = "PENDIENTE") Then
                                Me.lblTotalExpNoLiquidados.Text = dsActual.Tables(i).Rows(j).Item("vlcantexp")
                                intPCE = dsActual.Tables(i).Rows(j).Item("vlcantexp")
                            End If
                            If (dsActual.Tables(i).Rows(j).Item("dsestado") = "LIQUIDADO") Then
                                Me.lblTotalExpLiquidados.Text = dsActual.Tables(i).Rows(j).Item("vlcantexp")
                                intTCE = dsActual.Tables(i).Rows(j).Item("vlcantexp")
                            End If
                        Else
                            If (dsActual.Tables(i).Rows(j).Item("desctotal") = "PENDIENTE") Then
                                Label5.Text = Format(dsActual.Tables(i).Rows(j).Item("vltotal"), "$ #,##0.00")
                                lblCompLiquiImpagos.Text = dsActual.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                                intPCC = dsActual.Tables(i).Rows(j).Item("vlCantComprobantes")
                                vlPC = dsActual.Tables(i).Rows(j).Item("vltotal")
                            End If
                            If (dsActual.Tables(i).Rows(j).Item("desctotal") = "TOTLIQUIDADO") Then
                                Me.lblComprobantesLiqPag.Text = Format(dsActual.Tables(i).Rows(j).Item("vltotal"), "$ #,##0.00")
                                lblCompliquipagados.Text = dsActual.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                                vlTC = dsActual.Tables(i).Rows(j).Item("vltotal").ToString()
                                intTCC = dsActual.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                            End If
                        End If
                    Next
                Next

                'For i As Integer = 0 To dsActual.Tables(1).Rows.Count - 1
                '    If (dsActual.Tables(1).Rows(i).Item("desctotal") = "TOTLIQUIDADO") Then
                '        Me.lblComprobantesLiqPag.Text = dsActual.Tables(1).Rows(i).Item("vltotal")
                '        lblHayCI.Text = "Hay " + dsActual.Tables(1).Rows(i).Item("vlCantComprobantes") + " comprobantes liquidados(pagagos)"
                '        vlT = dsActual.Tables(1).Rows(i).Item("vltotal")
                '        intT = dsActual.Tables(1).Rows(i).Item("vlCantComprobantes")
                '    End If
                '    If (dsActual.Tables(1).Rows(i).Item("desctotal") = "PENDIENTES") Then
                '        Label5.Text = dsActual.Tables(1).Rows(i).Item("vltotal")
                '        lblHayCLiquidado.Text = "Hay " + dsActual.Tables(0).Rows(i).Item("vlCantComprobantes") + " comprobantes pendientes de liquidar(impagos)"
                '        intP = dsActual.Tables(1).Rows(i).Item("vlCantComprobantes")
                '        vlP = dsActual.Tables(1).Rows(i).Item("vltotal")
                '    End If
                'Next
                lblComprobantesIngresados.Text = Format(vlTC + vlPC, "$ #,##0.00")
                lblCompIngresados.Text = intTCC + intPCC
                Me.lblTotalExp.Text = intPCE + intTCE
            End If

            'Dim total As Integer
            'total = hasta.Month
            'If (total = 1) Then
            '    total = 12
            'Else
            '    total = total - 1
            'End If

            Me.lblMesActual.Text = Format$(dtActual, "MMMM")
            Me.lblMesAnterior.Text = Format$(dtMesAnterior, "MMMM")

            'If (hasta.Month = 1) Then
            '    Me.lblMesAnterior.Text = "Enero"
            'End If
            'If (hasta.Month = 2) Then
            '    Me.lblMesAnterior.Text = "Febrero"
            'End If
            'If (hasta.Month = 3) Then
            '    Me.lblMesAnterior.Text = "Marzo"
            'End If
            'If (hasta.Month = 4) Then
            '    Me.lblMesAnterior.Text = "Abril"
            'End If
            'If (hasta.Month = 5) Then
            '    Me.lblMesAnterior.Text = "Mayo"
            'End If
            'If (hasta.Month = 6) Then
            '    Me.lblMesAnterior.Text = "Junio"
            'End If
            'If (hasta.Month = 7) Then
            '    Me.lblMesAnterior.Text = "Julio"
            'End If
            'If (hasta.Month = 8) Then
            '    Me.lblMesAnterior.Text = "Agosto"
            'End If

            'If (hasta.Month = 9) Then
            '    Me.lblMesAnterior.Text = "Septiembre"
            'End If
            'If (hasta.Month = 9) Then
            '    Me.lblMesAnterior.Text = "Octubre"
            'End If
            'If (hasta.Month = 11) Then
            '    Me.lblMesAnterior.Text = "Noviembre"
            'End If
            'If (hasta.Month = 12) Then
            '    Me.lblMesAnterior.Text = "Diciembre"
            'End If
            Dim dsPasado As New DataSet
            dsPasado = WS.SelectIndicadoresGestion(dtMesAnterior.Year, dtMesAnterior.Month)
            If (dsPasado.Tables.Count > 0) Then
                Dim vlPC, vlTC As Decimal
                For i As Integer = 0 To dsPasado.Tables.Count - 1
                    For j As Integer = 0 To dsPasado.Tables(i).Rows.Count - 1
                        If i = 0 Then
                        Else
                            If (dsPasado.Tables(i).Rows(j).Item("desctotal") = "PENDIENTE") Then
                                lblPasadoCompPendientes.Text = Format(dsPasado.Tables(i).Rows(j).Item("vltotal"), "$ #,##0.00")
                                ' lblCompLiquiImpagos.Text = dsPasado.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                                vlPC = dsPasado.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                            End If
                            If (dsPasado.Tables(i).Rows(j).Item("desctotal") = "TOTLIQUIDADO") Then
                                lblPasadoComLiquidados.Text = Format(dsPasado.Tables(i).Rows(j).Item("vltotal"), " $ #,##0.00")
                                '  lblCompliquipagados.Text = dsPasado.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                                vlTC = dsPasado.Tables(i).Rows(j).Item("vlCantComprobantes").ToString()
                            End If
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pnlCabecera_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlCabecera.Paint

    End Sub
End Class