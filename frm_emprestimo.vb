Imports System.Runtime.InteropServices

Public Class frm_emprestimo

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub frm_emprestimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_emprestimos()
        cmb_emprestimos()
        txt_devolucao.Text = Now.AddDays(15)
        txt_emprestimo.Text = Now.Date
    End Sub
    Private Sub txt_cod_LostFocus(sender As Object, e As EventArgs) Handles txt_cod.LostFocus


        Try
            SQL = "select * from tb_livros where cod='" & txt_cod.Text & "'"
            rs = db.Execute(SQL)
            aux_livro = rs.Fields(8).Value
            If aux_livro = "DISPONIVEL" Then
                If rs.EOF = False Then
                    txt_livro.Text = rs.Fields(1).Value
                    txt_autor.Text = rs.Fields(2).Value
                    img_livro.ImageLocation = rs.Fields(7).Value
                End If
            Else
                MsgBox("Ops, livro fora de estoque...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cod.Clear()
                txt_cod.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub btn_emprestar_Click(sender As Object, e As EventArgs) Handles btn_emprestar.Click
        'verificar se todos os campos estao completos
        If txt_cpf.Text = "" Or
                   txt_autor.Text = "" Or
                   txt_cod.Text = "" Or
                   txt_nome.Text = "" Or
                   txt_livro.Text = "" Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else

            SQL = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                resp = MsgBox("É preciso cadastrar o cliente para poder fazer empréstimo de livros." + vbNewLine &
                          "Deseja cadastrar nova cliente? ", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    Me.Finalize()
                End If
                frm_cad_clientes.ShowDialog()
            Else
                SQL = "select * from tb_emprestimo where cod='" & txt_cod.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = "insert into tb_emprestimo (cpf,nome_cliente,cod,nome_livro,nome_autor,data_emprestimo,data_devolucao,foto) values ('" & txt_cpf.Text & "', " &
                    "'" & txt_nome.Text & "', '" & txt_cod.Text & "', " &
                    "'" & txt_livro.Text & "', '" & txt_autor.Text & "', " &
                    "'" & txt_emprestimo.Value & "', '" & txt_devolucao.Value & "', '" & diretorio & "')"
                    rs = db.Execute(SQL)

                    SQL = "select * from tb_livros where cod='" & txt_cod.Text & "'"
                    'aux_cod = rs.Fields(0).Value
                    MsgBox("Dados enviados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    SQL = "update tb_livros set status='EMPRESTADO' where cod = '" & txt_cod.Text & "'"
                    rs = db.Execute(SQL)
                    carregar_livros()
                    carregar_emprestimos()
                Else
                    MsgBox("Ops, livro não encontrado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        End If
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_cod.Clear()
        img_livro.Load(Application.StartupPath & "\icones\Book-icon.png")
        txt_livro.Clear()
        txt_autor.Clear()
        txt_emprestimo.Value = Now.Date
        txt_devolucao.Value = Now.AddDays(15) ' "#" comparar datas
        txt_cpf.Focus()
        carregar_livros()
    End Sub

    Private Sub DGV_DADOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DADOS.CellContentClick
        'Try
        'por finalizar diretorio de imagem
        With DGV_DADOS
            If .CurrentRow.Cells(7).Selected = True Then
                aux_cpf = .CurrentRow.Cells(0).Value
                SQL = "select * from tb_emprestimo where cpf='" & aux_cpf & "'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    TabControl1.SelectTab(0) 'Explore aba dados pessoais
                    txt_cpf.Text = rs.Fields(1).Value
                    txt_nome.Text = rs.Fields(3).Value
                    txt_cod.Text = rs.Fields(2).Value
                    txt_livro.Text = rs.Fields(4).Value
                    txt_autor.Text = rs.Fields(5).Value
                    'img_livro.Load(rs.Fields(8).Value) 'como 
                    txt_emprestimo.Value = rs.Fields(6).Value
                    txt_devolucao.Value = rs.Fields(7).Value
                End If
            ElseIf .CurrentRow.Cells(8).Selected = True Then
                aux_usuario = .CurrentRow.Cells(1).Value
                aux_livro = .CurrentRow.Cells(3).Value
                aux_cpf = .CurrentRow.Cells(0).Value
                aux_cod = .CurrentRow.Cells(2).Value
                resp = MsgBox("O cliente: " & aux_usuario & "" + vbNewLine &
                                 "Devolveu o livro: " & aux_livro & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    SQL = "delete * from tb_emprestimo where cod='" & aux_cod & "'"
                    rs = db.Execute(SQL)
                    carregar_emprestimos()

                    SQL = "select * from tb_livros where cod='" & aux_cod & "'"
                    'aux_cod = rs.Fields(0).Value
                    MsgBox("Dados enviados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    SQL = "update tb_livros set status='DISPONIVEL' where cod='" & aux_cod & "'"
                    rs = db.Execute(SQL)
                    carregar_livros()

                    SQL = "select * from tb_clientes where cpf='" & aux_cpf & "'"
                    'aux_cod = rs.Fields(0).Value
                    MsgBox("Dados enviados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    SQL = "update tb_clientes set status_cliente='ATIVO' where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    carregar_livros()

                End If
            Else
                Exit Sub
            End If
        End With
        ' Catch ex As Exception
        ' MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ' End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            status_cliente = rs.Fields(11).Value
            If status_cliente = "ATIVO" Then

                If rs.EOF = False Then
                    txt_nome.Text = rs.Fields(1).Value
                End If
            Else
                MsgBox("Cliente Bloqueado!" + vbNewLine &
                            "Devolva o livro pendente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cpf.Clear()
                txt_cpf.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from tb_emprestimo where " & cmb_busca.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            cont = 1
            With DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False

                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class