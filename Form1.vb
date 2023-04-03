Public Class Form1
    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Try
            frm_cad_livros.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        Try
            frm_cad_clientes.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub EmpréstimoDeLivrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpréstimoDeLivrosToolStripMenuItem.Click
        'Try
        frm_emprestimo.ShowDialog()
        'Catch ex As Exception
        'MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub CadastrarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarContasToolStripMenuItem.Click
        Try
            frm_cad_contas.ShowDialog()
        Catch
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frm_login.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
