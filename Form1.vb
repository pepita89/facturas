Imports System.Runtime.InteropServices
Imports System.Windows
Imports Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
Imports clsFacturas
Public Class frmMenu
    Private _buscar As Boolean

    Public Function Agregarexcepcion() As System.Net.WebProxy
        Try
            Dim prox As New System.Net.WebProxy
            prox = System.Net.WebProxy.GetDefaultProxy()
            Dim arrExc As New ArrayList()
            For i As Integer = 0 To prox.BypassList.Length - 1
                Dim nombreexc As String = prox.BypassList(i).ToString
                arrExc.Add(nombreexc)
            Next
            If ValidaExistenciadeExcepcionProxy() = False Then
                arrExc.Add("^(?:.*://)?sistemas\.secretariageneral\.gov\.ar(?::[0-9]{1,5})?$")
            End If

            Dim strArExc(arrExc.Count - 1) As String

            For i As Integer = 0 To strArExc.Length - 1
                strArExc.SetValue(arrExc(i), i)

            Next


            prox.BypassList = strArExc
            Return prox
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ValidaExistenciadeExcepcionProxy() As Boolean
        Try
            Dim prox As New System.Net.WebProxy
            prox = System.Net.WebProxy.GetDefaultProxy()
            Dim arrExc As New ArrayList()
            ValidaExistenciadeExcepcionProxy = False
            For i As Integer = 0 To prox.BypassList.Length - 1
                Dim nombreexc As String = prox.BypassList(i).ToString
                arrExc.Add(nombreexc)
                If nombreexc = "^(?:.*://)?sistemas\.secretariageneral\.gov\.ar(?::[0-9]{1,5})?$" Then
                    ValidaExistenciadeExcepcionProxy = True

                    Exit For
                End If
            Next
            Return ValidaExistenciadeExcepcionProxy
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Net.ServicePointManager.Expect100Continue = False
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            wsSeg.Credentials = System.Net.CredentialCache.DefaultCredentials
            WS.Credentials = System.Net.CredentialCache.DefaultCredentials
            wsSeg.Proxy = Agregarexcepcion()
            'Dim val As Boolean = ValidaExistenciadeExcepcionProxy()
            Dim ofm1 As New frmMenu
            'If val Then
            Dim strSistema As String
            strSistema = WS.NroSistema
            oLogin = wsSeg.InicioSessionporUsuarioWindows(WS.NroSistema)
            If oLogin.blLogged And oLogin.EsUsuarioNT Then
                Dim oMdiclient As MdiClient
                If oLogin.blLogged And oLogin.EsUsuarioNT Then
                    _UsuarioCompleto = oLogin.NombreCompleto
                End If
                For i As Integer = 0 To Me.Controls.Count - 1
                    If TypeName(Me.Controls(i)) = "MdiClient" Then
                        oMdiclient = Me.Controls(i)
                        oMdiclient.BackColor = Me.BackColor
                        Dim iStyle As Int16 = Win32.GetWindowLong(oMdiclient.Handle, Win32.GWL_EXSTYLE)
                        '/Suppression du style WS_EX_CLIENTEDGE des styles étendus du contrôle courant
                        'iStyle &= ~Win32.WS_EX_CLIENTEDGE;
                        iStyle = iStyle Xor Win32.WS_EX_CLIENTEDGE
                        '//Application du nouveau style
                        iStyle = Win32.SetWindowLong(oMdiclient.Handle, Win32.GWL_EXSTYLE, iStyle)

                    End If
                Next
                ofm1.Enabled = True
                Dim ofrm As frmInicio
                Me.AutoScroll = False
                ofrm = New frmInicio
                ofrm.MdiParent = Me
                ofrm.lblUsuario.Text = _UsuarioCompleto
                ofrm.WindowState = FormWindowState.Maximized
                ofrm.Show()
            Else
                Dim ofrm As frmLogin
                Me.AutoScroll = False
                ofrm = New frmLogin
                ofm1.Enabled = False
                ofrm.WindowState = FormWindowState.Normal
                ofrm.ShowDialog()
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub
   
   
    Sub AbrirPantalla()
        Dim oMdiclient As MdiClient
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeName(Me.Controls(i)) = "MdiClient" Then
                oMdiclient = Me.Controls(i)
                Dim iStyle As Int16 = Win32.GetWindowLong(oMdiclient.Handle, Win32.GWL_EXSTYLE)
                '/Suppression du style WS_EX_CLIENTEDGE des styles étendus du contrôle courant
                'iStyle &= ~Win32.WS_EX_CLIENTEDGE;
                iStyle = iStyle Xor Win32.WS_EX_CLIENTEDGE
                '//Application du nouveau style
                iStyle = Win32.SetWindowLong(oMdiclient.Handle, Win32.GWL_EXSTYLE, iStyle)
            End If
        Next


        Me.AutoScroll = False

        Dim Vs As String = My.Application.Info.Version.ToString()
        Me.Text = Me.Text & " (Version " & Vs.Trim() & " )"
    End Sub
    Private Function GetOpenForm(ByVal ofrm As Form, ByVal cdVolverAbrir As Integer) As Boolean
        GetOpenForm = False

        Try
            Dim i As Integer
            For i = My.Application.OpenForms.Count - 1 To 1 Step -1
                Dim form As Form = My.Application.OpenForms(i)
                If form.Name = ofrm.Name Then
                    GetOpenForm = True
                    '  oformulario = form
                    If (cdVolverAbrir = 0) Then
                        form.Close()
                    Else
                        form.BringToFront()
                    End If

                    Exit For

                End If
                'MsgBox("El formulario " & form.Name.ToString & " está abierto")
            Next i
            Return GetOpenForm
        Catch ex As Exception
            Throw ex

        End Try


    End Function
    Private Sub IngresarNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim ofrm As New frmIngresoComprobantes
        '    If Not GetOpenForm(ofrm, 1) Then
        '        'Dim frm As frmIngresoComprobantes
        '        Me.AutoScroll = False

        '        ofrm = New frmIngresoComprobantes
        '        ofrm.WindowState = FormWindowState.Maximized
        '        ofrm.MdiParent = Me
        '        ofrm.Show()

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
  
    Private Sub INGRESARNUEVOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESARNUEVOToolStripMenuItem1.Click
        Try
            Dim ofrm As New frmIngresarExpedientes
            If Not GetOpenForm(ofrm, 1) Then
                Me.AutoScroll = False
                ofrm = New frmIngresarExpedientes
                _Modo = 0
                ofrm.MdiParent = Me
                ofrm.WindowState = FormWindowState.Maximized
                ofrm.Show()
            Else
                Dim res As DialogResult = MsgBox("LOS DATOS DEL EXPEDIENTE SE BORRARAN, ¿DESEA VACIAR LOS CAMPOS DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
                If (res = Windows.Forms.DialogResult.Yes) Then
                    If GetOpenForm(ofrm, 0) Then
                        Me.AutoScroll = False
                        ofrm = New frmIngresarExpedientes
                        _Modo = 0
                        ofrm.MdiParent = Me
                        ofrm.WindowState = FormWindowState.Maximized
                        ofrm.Show()
                    End If
                End If
            End If


            'Else

            '    Dim frm As frmIngresarExpedientes
            '    Me.AutoScroll = False
            '    frm = New frmIngresarExpedientes

            '    Dim res As DialogResult = MsgBox("LOS DATOS DEL EXPEDIENTE SE BORRARAN, ¿DESEA VACIAR LOS CAMPOS DE TODAS FORMAS?", MsgBoxStyle.YesNo + 32, "Confirmación")
            '    If (res = Windows.Forms.DialogResult.Yes) Then

            '        GetOpenForm(ofrm, 0)
            '        Me.AutoScroll = False
            '        frm = New frmIngresarExpedientes
            '        ofrm.MdiParent = Me
            '        ofrm.WindowState = FormWindowState.Maximized
            '        frm.Show()
            '    End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    'Private Sub SeguimientoDeExpedientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoDeExpedientesToolStripMenuItem.Click
    '    Try
    '        Dim ofrm As New frmSeguimientodeExpedientes
    '        If Not GetOpenForm(ofrm, 1) Then
    '            Dim frm As frmSeguimientodeExpedientes
    '            Me.AutoScroll = False
    '            frm = New frmSeguimientodeExpedientes
    '            ofrm.MdiParent = Me
    '            ofrm.WindowState = FormWindowState.Maximized
    '            ofrm.Show()


    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub ConsultaYModificaciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaYModificaciónToolStripMenuItem1.Click
        Try
            Dim ofrm As New frmConsultayModificaciondeExpedientes
            If Not GetOpenForm(ofrm, 1) Then
                Dim frm As frmConsultayModificaciondeExpedientes
                Me.AutoScroll = False
                frm = New frmConsultayModificaciondeExpedientes
                ofrm.MdiParent = Me
                ofrm.WindowState = FormWindowState.Maximized
                ofrm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim ofrm As New frmIngresarExpedientes
        Dim ofrmC As New frmConsultayModificaciondeExpedientes
        Dim ofrmI As New frmInicio
        GetOpenForm(ofrm, 0)
        GetOpenForm(ofrmC, 0)
        GetOpenForm(ofrmI, 0)
        ofrmI = New frmInicio
        ofrmI.MdiParent = Me
        ofrmI.WindowState = FormWindowState.Maximized
        ofrmI.Show()
    End Sub
    Private Sub REPORTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTESToolStripMenuItem.Click
        Try
            Dim ofrm As New frmReportes_Varios
            If Not GetOpenForm(ofrm, 1) Then
                Dim frm As frmReportes_Varios
                Me.AutoScroll = False
                frm = New frmReportes_Varios
                ofrm.MdiParent = Me
                ofrm.WindowState = FormWindowState.Maximized
                ofrm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
Public Class Win32
    Public Const GWL_EXSTYLE As Integer = -20
    Public Const WS_EX_CLIENTEDGE As Integer = &H200

    <DllImport("user32.dll")> _
    Public Shared Function GetWindowLong(ByVal window As IntPtr, ByVal index As Integer) As Integer

    End Function
    <DllImport("user32.dll")> _
    Public Shared Function SetWindowLong(ByVal window As IntPtr, ByVal index As Integer, ByVal value As Integer) As Integer

    End Function

End Class
