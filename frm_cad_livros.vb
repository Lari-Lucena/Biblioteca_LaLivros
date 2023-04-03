Imports System.Runtime.InteropServices

Public Class frm_cad_livros

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btn_cadastrar_Click_1(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_nome.Text = "" Or
               txt_autor.Text = "" Or
               txt_cod.Text = "" Or
               cmb_genero.Text = "" Or
               txt_pag.Text = "" Or
               txt_ano.Text = "" Or
               txt_editora.Text = "" Then
                MsgBox("Preencha todos os campos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = "select * from tb_livros where cod='" & txt_cod.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = True Then
                    SQL = "insert into tb_livros values ('" & txt_cod.Text & "', '" & txt_nome.Text & "', " &
                    "'" & txt_autor.Text & "', '" & cmb_genero.Text & "', " &
                    "'" & txt_pag.Text & "', '" & txt_ano.Text & "', " &
                    "'" & txt_editora.Text & "', '" & diretorio & "', 'DISPONIVEL')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados enviados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    SQL = "update tb_livros Set cod='" & txt_cod.Text & "', " &
                         "nome_livro='" & txt_nome.Text & "', nome_autor='" & txt_autor.Text & "', " &
                         "genero='" & cmb_genero.Text & "', num_paginas='" & txt_pag.Text & "', " &
                         "ano_publicacao='" & txt_ano.Text & "', editora='" & txt_editora.Text & "', " &
                         "foto='" & diretorio & "' where cod='" & txt_cod.Text & "'"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                txt_cod.Clear()
                txt_nome.Clear()
                txt_autor.Clear()
                'cmb_genero.??
                txt_pag.Clear()
                txt_ano.Clear()
                txt_editora.Clear()
                img_livro.Load(Application.StartupPath & "\icones\Book-icon.png")
                txt_nome.Focus()
                carregar_dados()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub img_livro_Click(sender As Object, e As EventArgs) Handles img_livro.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_livro.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro ao localizar imagem.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cad_livros_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        carregar_livros()
        cmb_livros()
    End Sub

    Private Sub DGV_DADOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DADOS.CellContentClick
        Try
            With DGV_DADOS
                If .CurrentRow.Cells(5).Selected = True Then
                    aux_livro = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_livros where nome_livro='" & aux_livro & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Explore aba dados pessoais
                        txt_nome.Text = rs.Fields(1).Value
                        txt_autor.Text = rs.Fields(2).Value
                        txt_cod.Text = rs.Fields(0).Value
                        cmb_genero.Text = rs.Fields(3).Value
                        txt_ano.Text = rs.Fields(5).Value
                        txt_pag.Text = rs.Fields(4).Value
                        txt_editora.Text = rs.Fields(6).Value
                        img_livro.Load(rs.Fields(7).Value)
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_livro = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "Livro: " & aux_livro & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_livros where nome_livro='" & aux_livro & "'"
                        rs = db.Execute(SQL)
                        carregar_livros()
                    End If
                    '  ElseIf .CurrentRow.Cells(4).Selected = True Then
                    ' aux_livro = .CurrentRow.Cells(1).Value
                    '  resp = MsgBox("Deseja realmente bloquear" + vbNewLine &
                    '            "Usuario: " & aux_livro & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCAO")
                    '  If resp = MsgBoxResult.Yes Then
                    '   SQL = "block * from tb_login where usuario='" & aux_livro & "'"
                    '   rs = db.Execute(SQL)
                    '   carregar_dados()
                    ' End If
                Else
                    Exit Sub
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

    Private Sub frm_cad_livros_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        conecta_banco()
        carregar_livros()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from tb_livros where " & cmb_busca.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            cont = 1
            With DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(8).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class