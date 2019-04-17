Imports System.Windows.Forms
Imports clsFacturas
Public Class frmLogin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        wsSeg.Credentials = System.Net.CredentialCache.DefaultCredentials
        WS.Credentials = System.Net.CredentialCache.DefaultCredentials
        oLogin = wsSeg.InicioSessionsinUsuarioWindows(Me.TextBox1.Text, Me.TextBox2.Text, WS.NroSistema())
        If oLogin.blLogged And oLogin.EsUsuarioNT Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Dim ofrm As frmMenu
            Me.AutoScroll = False
            ofrm = New frmMenu
            ofrm.MdiParent = Me
            ofrm.WindowState = FormWindowState.Maximized

            Me.Close()

            ofrm.Show()
        Else
            MessageBox.Show(oLogin.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        End
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Select Case e.CloseReason
            Case CloseReason.UserClosing, CloseReason.WindowsShutDown
                End
        End Select
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
  
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class