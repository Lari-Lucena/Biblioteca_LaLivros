Imports System.Runtime.InteropServices

Public Class frm_recuperar

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub frm_recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Clear()
        txt_palavra.Clear()
        txt_usuario.Focus()


        ' frm_login.Close()
        conecta_banco()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_entrar_Click_1(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_palavra.Text = "" Or
                    txt_usuario.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                SQL = "select * from tb_login where (usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "') and palavra_chave='" & txt_palavra.Text & "'"
                rs = db.Execute(SQL)
                aux_senha = rs.Fields(3).Value
                If rs.EOF = False Then
                    MsgBox("Senha recuperada com sucesso!" + vbNewLine &
                                "Senha: " & aux_senha & "", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()

                Else
                    MsgBox("Palavra chave invalida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_palavra.Clear()
                    txt_usuario.Focus()


                End If

            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class