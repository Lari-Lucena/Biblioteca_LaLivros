Imports System.Runtime.InteropServices

Public Class frm_menu
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_max_Click(sender As Object, e As EventArgs) Handles btn_max.Click
        btn_max.Visible = False
        btn_restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        btn_restaurar.Visible = False
        btn_max.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub AbrirFomEnPanel(ByVal Fomhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(Fomhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
        End If
    End Sub

    Private Sub btn_cad_clientes_Click(sender As Object, e As EventArgs) Handles btn_cad_clientes.Click
        ' AbrirFomEnPanel(New frm_cad_clientes)
        frm_cad_clientes.ShowDialog()
    End Sub

    Private Sub btn_cad_contas_Click_1(sender As Object, e As EventArgs) Handles btn_cad_contas.Click
        'AbrirFomEnPanel(New frm_cad_contas)
        frm_cad_contas.ShowDialog()
    End Sub

    Private Sub brn_cad_livros_Click(sender As Object, e As EventArgs) Handles brn_cad_livros.Click
        ' AbrirFomEnPanel(New frm_cad_livros)
        frm_cad_livros.ShowDialog()
    End Sub

    Private Sub btn_emprestimo_Click(sender As Object, e As EventArgs) Handles btn_emprestimo.Click
        ' AbrirFomEnPanel(New frm_emprestimo)
        frm_emprestimo.ShowDialog()
    End Sub

    Private Sub btn_formularios_Click(sender As Object, e As EventArgs) Handles btn_formularios.Click
        Process.Start(Application.StartupPath & "\banco_dados\cadastro.mdb")
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        ' Me.Close()
        frm_login.ShowDialog()
    End Sub
End Class