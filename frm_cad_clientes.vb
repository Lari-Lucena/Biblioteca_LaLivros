Imports System.Runtime.InteropServices

Public Class frm_cad_clientes

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub frm_cad_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_dados()
        cmb_clientes()
        txt_data.Value = Now.Date
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            If txt_nome.Text = "" Or
                txt_bairro.Text = "" Or
                txt_cep.Text = "" Or
                txt_endereco.Text = "" Or
                txt_comp.Text = "" Or
                txt_cidade.Text = "" Or
                txt_uf.Text = "" Or
                txt_celular.Text = "" Or
                txt_email.Text = "" Or
                txt_cpf.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else

                SQL = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = "insert into tb_clientes values ('" & txt_cpf.Text & "', " &
                    "'" & txt_nome.Text & "', '" & txt_data.Value & "', " &
                    "'" & txt_celular.Text & "', '" & txt_email.Text & "', " &
                    "'" & txt_cep.Text & "', '" & txt_endereco.Text & "', " &
                    "'" & txt_comp.Text & "', '" & txt_bairro.Text & "', " &
                    "'" & txt_cidade.Text & "', '" & txt_uf.Text & "', 'ATIVO')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados enviados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    SQL = "update tb_clientes Set nome='" & txt_nome.Text & "', " &
                     "data_nasciemnto='" & txt_data.Value & "', num_celular='" & txt_celular.Text & "', " &
                     "email='" & txt_email.Text & "', cep='" & txt_cep.Text & "', " &
                     "endereco='" & txt_endereco.Text & "', complemento='" & txt_comp.Text & "', " &
                     "bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & "', uf='" & txt_uf.Text & "' where cpf='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                txt_cpf.Clear()
                txt_data.Value = Now
                txt_nome.Clear()
                txt_cep.Clear()
                txt_endereco.Clear()
                txt_comp.Clear()
                txt_bairro.Clear()
                txt_cidade.Clear()
                txt_uf.Clear()
                txt_celular.Clear()
                txt_email.Clear()
                txt_nome.Focus()
                carregar_livros()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub DGV_DADOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DADOS.CellContentClick
        Try
            With DGV_DADOS
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_clientes where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Explore aba dados pessoais
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_data.Value = rs.Fields(2).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cep.Text = rs.Fields(5).Value
                        txt_endereco.Text = rs.Fields(6).Value
                        txt_bairro.Text = rs.Fields(8).Value
                        txt_cidade.Text = rs.Fields(9).Value
                        txt_uf.Text = rs.Fields(10).Value
                        txt_celular.Text = rs.Fields(3).Value
                        txt_email.Text = rs.Fields(4).Value
                        txt_comp.Text = rs.Fields(7).Value
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_clientes where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados()
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    aux_cliente = .CurrentRow.Cells(2).Value
                    status_cliente = .CurrentRow.Cells(3).Value
                    If status_cliente = "ATIVO" Then
                        resp = MsgBox("Deseja realmente bloquear" + vbNewLine &
                                  "Cliente: " & aux_cliente & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCAO")
                        If resp = MsgBoxResult.Yes Then

                            SQL = "update tb_clientes set status_cliente='BLOQUEADO' where cpf='" & aux_cpf & "'"
                            MsgBox("Conta Bloqueada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            rs = db.Execute(SQL)
                            carregar_dados()
                        End If
                    Else
                        resp = MsgBox("Deseja realmente desbloquear" + vbNewLine &
                                "O cliente: " & aux_cliente & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then

                            SQL = "update tb_clientes set status_cliente='ATIVO' where cpf='" & aux_cpf & "'"
                            MsgBox("Conta Desbloqueada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            rs = db.Execute(SQL)
                            carregar_dados()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            SQL = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_cidade.Text = rs.Fields(2).Value
            End If
        Catch ex As Exception
            MsgBox("Não foi possível encontrar o CEP", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from tb_clientes where " & cmb_busca.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            cont = cont + 1
            With DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(11).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class