Module Module1
    Public diretorio, SQL, aux_cpf, resp, status_conta, aux_usuario, aux_livro, aux_cod, aux_senha, status_cliente, aux_cliente As String
    Public db As New ADODB.Connection 'Variável de BD
    Public rs As New ADODB.Recordset 'Variável de TB
    Public dirbanco = Application.StartupPath & "\banco_dados\cadastro.mdb"
    Public cont As Integer

    Sub conecta_banco()
        Try
            'String de Conexão com o Banco de Dados - MSAccess
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
            '  MsgBox("Conexão com o banco de dados OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from tb_clientes order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With frm_cad_clientes.DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(11).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_contas()
        Try
            SQL = "select * from tb_login order by id_conta asc"
            rs = db.Execute(SQL)
            With frm_cad_contas.DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_livros()
        Try
            SQL = "select * from tb_livros order by cod asc"
            rs = db.Execute(SQL)
            With frm_cad_livros.DGV_DADOS
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

    Sub carregar_emprestimos()
        Try
            SQL = "select * from tb_emprestimo order by cpf asc"
            rs = db.Execute(SQL)
            With frm_emprestimo.DGV_DADOS
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub cmb_clientes()
        Try
            With frm_cad_clientes.cmb_busca.Items
                .Add("cpf")
                .Add("nome")
            End With
            frm_cad_clientes.cmb_busca.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub cmb_livros()
        Try
            With frm_cad_livros.cmb_busca.Items
                .Add("cod")
                .Add("nome_livro")
            End With
            frm_cad_livros.cmb_busca.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub cmb_contas()
        Try
            With frm_cad_contas.cmb_busca.Items
                .Add("email")
                .Add("usuario")
            End With
            frm_cad_contas.cmb_busca.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub cmb_emprestimos()
        Try
            With frm_emprestimo.cmb_busca.Items
                .Add("cod")
                .Add("nome_cliente")
            End With
            frm_emprestimo.cmb_busca.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
