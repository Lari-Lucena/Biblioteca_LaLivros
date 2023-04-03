Imports System.Runtime.InteropServices

Public Class frm_cad_contas

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            If txt_usuario.Text = "" Or
                   txt_email.Text = "" Or
                   txt_senha.Text = "" Or
                    txt_palavra.Text = "" Or
                   txt_rsenha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                SQL = "select * from tb_login where usuario='" & txt_usuario.Text & "' or email='" & txt_email.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    MsgBox("Conta já cadastrada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    SQL = "insert into tb_login (usuario,email,senha,status_conta,palavra_chave) values ('" & txt_usuario.Text & "', " &
                        "'" & txt_email.Text & "', '" & txt_senha.Text & "','ATIVA','" & txt_palavra.Text & "')"
                    rs = db.Execute(SQL)
                    MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                txt_usuario.Clear()
                txt_email.Clear()
                txt_senha.Clear()
                txt_palavra.Clear()
                txt_rsenha.Clear()
                txt_usuario.Focus()
                carregar_contas()
            End If
        Catch ex As Exception
            MsgBox("Nao foi possivel executar.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_cad_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_contas()
        cmb_contas()
    End Sub

    Private Sub DGV_DADOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DADOS.CellContentClick
        Try
            With DGV_DADOS
                If .CurrentRow.Cells(6).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "Usuario: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_login where usuario='" & aux_usuario & "'"
                        rs = db.Execute(SQL)
                        carregar_contas()
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    status_conta = .CurrentRow.Cells(4).Value
                    If status_conta = "ATIVA" Then
                        resp = MsgBox("Deseja realmente bloquear" + vbNewLine &
                                  "Usuario: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCAO")
                        If resp = MsgBoxResult.Yes Then

                            SQL = "update tb_login set status_conta='BLOQUEADA' where usuario='" & aux_usuario & "'"
                            MsgBox("Conta Bloqueada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            rs = db.Execute(SQL)
                            carregar_contas()
                        End If
                    Else
                        resp = MsgBox("Deseja realmente desbloquear" + vbNewLine &
                                "O usuario: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then

                            SQL = "update tb_login set status_conta='ATIVA' where usuario='" & aux_usuario & "'"
                            MsgBox("Conta Desbloqueada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            rs = db.Execute(SQL)
                            carregar_contas()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        btn_secreto.Visible = True
        btn_visualizar.Visible = False
        txt_senha.PasswordChar = "•"
        txt_rsenha.PasswordChar = "•"
        txt_senha.Focus()
    End Sub

    Private Sub btn_secreto_Click(sender As Object, e As EventArgs) Handles btn_secreto.Click
        btn_visualizar.Visible = True
        btn_secreto.Visible = False
        txt_senha.PasswordChar = ""
        txt_rsenha.PasswordChar = ""
        txt_senha.Focus()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from tb_login where " & cmb_busca.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            cont = 1
            With DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
