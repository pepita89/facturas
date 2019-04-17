Imports clsFacturas
Public Class frmConceptoySubconcepto
    Public _nuev As Integer
    Public _intExp As Integer
    Public arr As New List(Of clsConceptos)
    Public arr1 As New List(Of clsConceptos)
    Public _tipo As Integer
    Public Function vlConcepto() As Boolean
        If (Me.cboConcepto.SelectedValue <> -1) Then
        Else
            MessageBox.Show("Debe ingresar el concepto")
            Return False
            Exit Function
        End If
        If (Me.cboSubConcepto.SelectedValue <> -1) Then
        Else
            MessageBox.Show("Debe ingresar el Subconcepto")
            Return False
            Exit Function
        End If
        Dim ds1 As New DataSet
        Dim ds As New DataSet
        ds = WS.TraerPantalla_ByConcepto(_intExp)
        ds1 = WS.Obtener_SuConcepto(Me.txtcdPadre.Text)
        Dim i As Integer
        Dim bl As Boolean
        For i = 0 To ds.Tables(0).Rows.Count - 1

            If (ds.Tables(0).Rows().Count > 0) Then
                If (Me.cboConcepto.Text = ds.Tables(0).Rows(i).Item("dsConcepto")) Then
                    If (Me.cboSubConcepto.Text = ds.Tables(0).Rows(i).Item("dsSubConcepto")) Then
                        MessageBox.Show("No se puede ingresar dos veces el mismo concepto")
                        Return False
                        Exit Function
                    End If
                End If
            End If
        Next
        'Dim i1 As Integer
        'If (bl = 1) Then
        '    For i1 = 0 To ds1.Tables(0).Rows.Count - 1
        '        If (Me.cboConcepto.SelectedValue = ds.Tables(0).Rows(0).Item("cdConcepto")) Then
        '            MessageBox.Show("No se puede ingresar dos veces el mismo concepto")
        '            Return False
        '            Exit Function
        '        End If

        '    Next
        'End If

        Return True
    End Function
    Public Sub CargarDatos()
        Try
            arr1 = New List(Of clsConceptos)
            Dim ds As New DataSet
            ds = WS.TraerPantalla_ByConcepto(_intExp)
            Dim i As Integer
            If (ds.Tables(0).Rows.Count > 0) Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim ocls As New clsConceptos
                    ocls.cdExp = _intExp
                    ocls.cdConcepto = ds.Tables(0).Rows(i).Item("cdSubConcepto")
                    ocls.dsObservaciones = ds.Tables(0).Rows(i).Item("sObservacion")
                    arr1.Add(ocls)
                Next
            End If
            Dim ocls1 As New clsConceptos
            ocls1.cdExp = Me._intExp
            ocls1.cdConcepto = Me.cboSubConcepto.SelectedValue
            ocls1.dsObservaciones = Me.txtObservacionesConceptos.Text
            arr1.Add(ocls1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarConceptos(ByVal intConcepto As Integer)
        Try
            Dim i As Integer
            Dim ds As New DataSet()
            ds = WS.Obtener_Conceptos(intConcepto)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.cboConcepto.DisplayMember = "dsConcepto"
                Me.cboConcepto.ValueMember = "cdConcepto"
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.txtcdPadre.Text = ds.Tables(0).Rows(i).Item("cdPadre")
                    Me.cboConcepto.DataSource = ds.Tables(0)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub CargarSubConceptos(ByVal cdConcep As Integer)
        Try
            Dim ds As New DataSet()
            ds = WS.Obtener_SuConcepto(cdConcep)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim i As Integer
                Me.cboSubConcepto.DisplayMember = "dsConcepto"
                Me.cboSubConcepto.ValueMember = "cdConcepto"
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.cboSubConcepto.DataSource = ds.Tables(0)
                Next
            Else
                Me.cboSubConcepto.SelectedValue = -1
                Me.cboSubConcepto.Text = ""
                Me.cboSubConcepto.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmConceptoySubconcepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarConceptos(-2)
        CargarSubConceptos(-2)
        _Modo = 0
        CargarDatos()

    End Sub
    Private Sub cboConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.SelectedIndexChanged
        Try
            CargarSubConceptos(cboConcepto.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdAgregarComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarComp.Click
        arr = New List(Of clsConceptos)
        Dim ocls As New clsConceptos
        If (vlConcepto() = True) Then
            _Modo = 1
            CargarDatos()
            Dim ds As New DataSet
            ocls.Array1 = Me.arr1
            ds = WS.ExpedientesConceptos_IU(ocls.ToXml)
            MessageBox.Show("El Concepto se ingreso correctamente al expediente")
            Me.Close()
            _Modo = 3
            Me.arr1 = New List(Of clsConceptos)
        Else
        End If
    End Sub
    Public Sub CargarDatosConcepto()
        Try
            If (Me.txtConcepto.Text <> "") Then
                Dim ocls As New clsConceptos
                Dim dt1 As New DataTable
                ocls.dsConcepto = Me.txtConcepto.Text
                ocls.cdNivel = 0
                ocls.cdConcepto = 0
                ocls.cdPadre = 0
                arr.Add(ocls)
                ocls.Array = arr
            End If
            If (Me.txtSubConcepto.Text <> "") Then
                Dim ocls As New clsConceptos
                Dim dt1 As New DataTable
                ocls.dsConcepto = Me.txtSubConcepto.Text
                ocls.cdNivel = 1
                ocls.cdConcepto = 0
                ocls.cdPadre = Me.cboConcepto.SelectedValue
                arr.Add(ocls)
                ocls.Array = arr
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmConceptoySubconcepto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If (_Modo = 4) Then
                Dim res As DialogResult = MsgBox("LOS DATOS DEL CONCEPTO SE BORRARAN, ¿DESEA SALIR DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (res = Windows.Forms.DialogResult.Yes) Then
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnNuevoConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoConcepto.Click
        Try
            Me.PnlConcepSubConcep.Visible = True
            Me.pnlConceptoF.Visible = False
            Me.cboConceptoV.Visible = False
            Me.txtConcepto.Text = ""
            Me.txtSubConcepto.Text = ""
            Me.txtConcepto.Visible = True
            Me.txtSubConcepto.Visible = False
            Me.lblSubConceptoNuevio.Visible = False
            Me.lblConceptoNuevo.Visible = True
            Me.lblConceptoNuevo.Text = "Ingresar Concepto"
            Me.gbxObservacion.Text = "Ingresar Conceptos y Subconceptos"
            _Modo = 1
            'Es para cARGAR CONCEPTO
            _tipo = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub cboConcepto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.Validated
    '    If (_Modo = 1) Then
    '        If (Me.cboConcepto.Text <> "") Then

    '            Dim ds As DataSet
    '            ds = WS.ValidarConcepto(cboConcepto.Text, 0)
    '            If (ds.Tables(0).Rows().Count > 0) Then
    '                Me.cboConcepto.Text = ""
    '            Else
    '                Me.CargarDatosConcepto(0)

    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub cboSubConcepto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubConcepto.Validated
    '    If (_Modo = 1) Then
    '        If (Me.cboSubConcepto.Text <> "") Then
    '            Dim ds As DataSet
    '            ds = WS.ValidarConcepto(cboSubConcepto.Text, 1)
    '            If (ds.Tables(0).Rows().Count > 0) Then

    '                Me.cboSubConcepto.Text = ""
    '            Else
    '                Me.CargarDatosConcepto(1)

    '            End If
    '        End If

    '    End If
    '    If (_Modo = 0) Then
    '        Dim ds As DataSet
    '        ds = WS.ValidarConcepto(cboConcepto.Text, 0)
    '        If (ds.Tables(0).Rows().Count > 0) Then
    '            Me.CargarDatosConcepto(1)
    '        End If
    '    End If
    'End Sub
    Private Sub toolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolNuevo.Click
        Me.txtConcepto.Text = ""
        Me.txtSubConcepto.Text = ""
        Me.arr = New List(Of clsConceptos)
        Me.arr1 = New List(Of clsConceptos)

    End Sub
    'Private Sub ToolAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (Me.txtSubConcepto.Text <> "") Then
    '        If (_Modo = 1) Then
    '            If (Me.txtSubConcepto.Text <> "") Then
    '                Dim ds As DataSet
    '                ds = WS.ValidarConcepto(txtSubConcepto.Text, 1)
    '                If (ds.Tables(0).Rows().Count > 0) Then

    '                    Me.cboSubConcepto.Text = ""
    '                Else
    '                    Me.CargarDatosConcepto(1)

    '                End If
    '            End If
    '        End If
    '        If (_Modo = 0) Then
    '            Dim ds As DataSet
    '            ds = WS.ValidarConcepto(txtSubConcepto.Text, 0)
    '            If (ds.Tables(0).Rows().Count > 0) Then
    '                Me.CargarDatosConcepto(1)
    '            End If
    '        End If
    '    End If
    '    Me.txtSubConcepto.Text = ""
    'End Sub
    Private Sub ToolGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGuardar.Click

        If (Me.txtConcepto.Text <> "" Or Me.txtSubConcepto.Text <> "") Then
            Me.CargarDatosConcepto()
            Dim ocls As New clsConceptos
            Dim ds As New DataSet
            ocls.Array = Me.arr
            If (Me.txtConcepto.Text <> "") Then
                ds = WS.ValidarConcepto(txtConcepto.Text, 0)
                If (ds.Tables(0).Rows().Count > 0) Then
                Else
                    ds = WS.CONCEPTOS_I(ocls.ToXmlConcepto)
                    If (ds.Tables(0).Rows.Count > 0) Then
                        MessageBox.Show("El Concepto se agrego correctamente")
                        Me.btnNuevoConcepto.Visible = True
                        lblAddConcepto.Text = "(Nuevo Concepto)"
                        Me.cboConcepto.Enabled = True
                        _Modo = 0
                        CargarConceptos(-2)
                        CargarSubConceptos(cboConcepto.SelectedValue)
                    End If

                End If
            End If
            If (Me.txtSubConcepto.Text <> "") Then
                Dim dss As DataSet
                dss = WS.ValidarConcepto(txtSubConcepto.Text, 0)
                If (dss.Tables(0).Rows().Count > 0) Then
                Else
                    ds = WS.CONCEPTOS_I(ocls.ToXmlConcepto)
                    If (ds.Tables(0).Rows.Count > 0) Then
                        MessageBox.Show("El SubConcepto se agrego correctamente")
                        Me.btnNuevoConcepto.Visible = True
                        lblAddConcepto.Text = "(Nuevo Concepto)"
                        Me.cboConcepto.Enabled = True
                        _Modo = 0
                        CargarSubConceptos(-2)
                        CargarSubConceptos(cboConcepto.SelectedValue)
                    End If
                End If
            End If

            'If (_tipo = 1) Then
            '    Dim dss As DataSet
            '    dss = WS.ValidarConcepto(txtSubConcepto.Text, 0)
            '    If (dss.Tables(0).Rows().Count > 0) Then
            '        Me.CargarDatosConcepto(1)

            '        Dim dsc As New DataSet
            '        ocls.Array = Me.arr
            '        ds = WS.CONCEPTOS_I(ocls.ToXmlConcepto)
            '        If (dsc.Tables(0).Rows.Count > 0) Then
            '            MessageBox.Show("El Subconcepto se agrego correctamente")
            '            Me.btnNuevoConcepto.Visible = True
            '            Me.cboConcepto.Enabled = True
            '            _Modo = 0
            '            CargarSubConceptos(-2)
            '        End If
            '    End If
            'End If
            Me.txtConcepto.Text = ""
            Me.txtSubConcepto.Text = ""
            Me.PnlConcepSubConcep.Visible = False
            Me.pnlConceptoF.Visible = True
            Me.gbxObservacion.Text = "Ingresar Conceptos Facturados"
            Me.arr = New List(Of clsConceptos)
            Me.arr1 = New List(Of clsConceptos)
        Else
            MessageBox.Show("No se puede ingresar un concepto vacio")
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.txtConcepto.Text = ""
        Me.txtSubConcepto.Text = ""
        Me.arr = New List(Of clsConceptos)
        Me.arr1 = New List(Of clsConceptos)
        Me.PnlConcepSubConcep.Visible = False
        Me.pnlConceptoF.Visible = True
    End Sub
    Private Sub txtConcepto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.Leave
        'If (_Modo = 1) Then
        '    If (Me.txtConcepto.Text <> "") Then
        '        If (Me.cboSubConcepto.Text = "") Then
        '  Dim ds As DataSet
        ' ds = WS.ValidarConcepto(txtConcepto.Text, 0)
        '            If (ds.Tables(0).Rows().Count > 0) Then

        '                Me.cboConcepto.Text = ""
        '            Else
        '                Me.CargarDatosConcepto(0)
        '            End If
        '        Else
        '            Me.CargarDatosConcepto(0)
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub txtSubConcepto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubConcepto.Leave
        'If (_Modo = 1) Then
        '    If (Me.txtSubConcepto.Text <> "") Then
        '        Dim ds As DataSet
        '        ds = WS.ValidarConcepto(txtSubConcepto.Text, 1)
        '        If (ds.Tables(0).Rows().Count > 0) Then

        '            Me.cboSubConcepto.Text = ""
        '        Else
        '            Me.CargarDatosConcepto(1)

        '        End If
        '    End If

        'End If
        'If (_Modo = 0) Then
        '    Dim ds As DataSet
        '    ds = WS.ValidarConcepto(txtSubConcepto.Text, 0)
        '    If (ds.Tables(0).Rows().Count > 0) Then
        '        Me.CargarDatosConcepto(1)
        '    End If
        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PnlConcepSubConcep.Visible = True
        Me.pnlConceptoF.Visible = False
        Me.txtSubConcepto.Text = ""
        Me.txtConcepto.Text = ""
        Me.lblSubConceptoNuevio.Visible = True
        Me.lblConceptoNuevo.Visible = True
        Dim ds As New DataSet()
        ds = WS.Obtener_Conceptos(Me.cboConcepto.SelectedValue)
        If ds.Tables(0).Rows.Count > 0 Then
            Me.cboConceptoV.DisplayMember = "dsConcepto"
            Me.cboConceptoV.ValueMember = "cdConcepto"
            Me.cboConceptoV.DataSource = ds.Tables(0)
        End If
        Me.lblConceptoNuevo.Text = "concepto"
        Me.cboConceptoV.Visible = True
        Me.cboConceptoV.Enabled = False
        Me.txtConcepto.Visible = False
        Me.txtSubConcepto.Visible = True
        Me.gbxObservacion.Text = "Ingresar Conceptos y Subconceptos"
    End Sub

End Class