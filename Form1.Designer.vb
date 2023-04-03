<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpréstimoDeLivrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.EmpréstimoDeLivrosToolStripMenuItem, Me.GerenciarContasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro de &Livros"
        '
        'EmpréstimoDeLivrosToolStripMenuItem
        '
        Me.EmpréstimoDeLivrosToolStripMenuItem.Name = "EmpréstimoDeLivrosToolStripMenuItem"
        Me.EmpréstimoDeLivrosToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.EmpréstimoDeLivrosToolStripMenuItem.Text = "&Empréstimo de Livros"
        '
        'GerenciarContasToolStripMenuItem
        '
        Me.GerenciarContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarContasToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.GerenciarContasToolStripMenuItem.Name = "GerenciarContasToolStripMenuItem"
        Me.GerenciarContasToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.GerenciarContasToolStripMenuItem.Text = "&Gerenciar Contas"
        '
        'CadastrarContasToolStripMenuItem
        '
        Me.CadastrarContasToolStripMenuItem.Name = "CadastrarContasToolStripMenuItem"
        Me.CadastrarContasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CadastrarContasToolStripMenuItem.Text = "Cadastrar Contas"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LoginToolStripMenuItem.Text = "Login ***"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpréstimoDeLivrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
End Class
