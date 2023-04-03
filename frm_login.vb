Imports System.Runtime.InteropServices

Public Class frm_login

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try

            If txt_usuario.Text = "" Or
                    txt_senha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then

                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()

                    'Me.Hide()
                    frm_menu.btn_cad_contas.Visible = True
                    frm_menu.ShowDialog()
                    Exit Sub

                End If

                SQL = "select * from tb_login where (usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "') and senha='" & txt_senha.Text & "'"
                    rs = db.Execute(SQL)
            status_conta = rs.Fields(4).Value


            If rs.EOF = False Then
                If status_conta = "ATIVA" Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()

                    Me.Hide()
                    frm_menu.btn_cad_contas.Visible = False
                    frm_menu.ShowDialog()
                Else
                    MsgBox("Conta Bloqueada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_usuario.Clear()
                        txt_senha.Clear()
                        txt_usuario.Focus()
                    End If

            Else
                MsgBox("Conta Inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If

            End If


        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_menu.Hide()
        conecta_banco()

        txt_usuario.Clear()
        txt_senha.Clear()
        txt_usuario.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            'Me.Hide()
            frm_recuperar.ShowDialog()
            ' Me.Finalize()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        btn_secreto.Visible = True
        btn_visualizar.Visible = False
        txt_senha.PasswordChar = "•"
        txt_senha.Focus()
    End Sub

    Private Sub btn_secreto_Click(sender As Object, e As EventArgs) Handles btn_secreto.Click
        btn_visualizar.Visible = True
        btn_secreto.Visible = False
        txt_senha.PasswordChar = ""
        txt_senha.Focus()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class