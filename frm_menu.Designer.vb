<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.btn_restaurar = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_cad_contas = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_formularios = New System.Windows.Forms.Button()
        Me.btn_emprestimo = New System.Windows.Forms.Button()
        Me.brn_cad_livros = New System.Windows.Forms.Button()
        Me.btn_cad_clientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_menu = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btn_gerenciar = New System.Windows.Forms.Button()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.BurlyWood
        Me.PanelCabecera.Controls.Add(Me.btn_restaurar)
        Me.PanelCabecera.Controls.Add(Me.btn_min)
        Me.PanelCabecera.Controls.Add(Me.btn_max)
        Me.PanelCabecera.Controls.Add(Me.btn_encerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1100, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restaurar.FlatAppearance.BorderSize = 0
        Me.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restaurar.Image = CType(resources.GetObject("btn_restaurar.Image"), System.Drawing.Image)
        Me.btn_restaurar.Location = New System.Drawing.Point(1011, 0)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_restaurar.TabIndex = 3
        Me.btn_restaurar.UseVisualStyleBackColor = True
        Me.btn_restaurar.Visible = False
        '
        'btn_min
        '
        Me.btn_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Image = CType(resources.GetObject("btn_min.Image"), System.Drawing.Image)
        Me.btn_min.Location = New System.Drawing.Point(965, 0)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(40, 40)
        Me.btn_min.TabIndex = 2
        Me.btn_min.UseVisualStyleBackColor = True
        '
        'btn_max
        '
        Me.btn_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_max.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_max.FlatAppearance.BorderSize = 0
        Me.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_max.Image = CType(resources.GetObject("btn_max.Image"), System.Drawing.Image)
        Me.btn_max.Location = New System.Drawing.Point(1011, 0)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(40, 40)
        Me.btn_max.TabIndex = 1
        Me.btn_max.UseVisualStyleBackColor = True
        '
        'btn_encerrar
        '
        Me.btn_encerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_encerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_encerrar.FlatAppearance.BorderSize = 0
        Me.btn_encerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encerrar.Image = CType(resources.GetObject("btn_encerrar.Image"), System.Drawing.Image)
        Me.btn_encerrar.Location = New System.Drawing.Point(1057, 0)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_encerrar.TabIndex = 0
        Me.btn_encerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Silver
        Me.PanelMenu.Controls.Add(Me.btn_cad_contas)
        Me.PanelMenu.Controls.Add(Me.btn_sair)
        Me.PanelMenu.Controls.Add(Me.btn_formularios)
        Me.PanelMenu.Controls.Add(Me.btn_emprestimo)
        Me.PanelMenu.Controls.Add(Me.brn_cad_livros)
        Me.PanelMenu.Controls.Add(Me.btn_cad_clientes)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btn_menu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 540)
        Me.PanelMenu.TabIndex = 1
        '
        'btn_cad_contas
        '
        Me.btn_cad_contas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cad_contas.FlatAppearance.BorderSize = 0
        Me.btn_cad_contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_cad_contas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_contas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_contas.ForeColor = System.Drawing.Color.White
        Me.btn_cad_contas.Image = CType(resources.GetObject("btn_cad_contas.Image"), System.Drawing.Image)
        Me.btn_cad_contas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_contas.Location = New System.Drawing.Point(0, 441)
        Me.btn_cad_contas.Name = "btn_cad_contas"
        Me.btn_cad_contas.Size = New System.Drawing.Size(220, 50)
        Me.btn_cad_contas.TabIndex = 8
        Me.btn_cad_contas.Text = "Cadastro de contas"
        Me.btn_cad_contas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_contas.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sair.Location = New System.Drawing.Point(0, 507)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(42, 33)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_formularios
        '
        Me.btn_formularios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_formularios.FlatAppearance.BorderSize = 0
        Me.btn_formularios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_formularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_formularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_formularios.ForeColor = System.Drawing.Color.White
        Me.btn_formularios.Image = CType(resources.GetObject("btn_formularios.Image"), System.Drawing.Image)
        Me.btn_formularios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_formularios.Location = New System.Drawing.Point(0, 372)
        Me.btn_formularios.Name = "btn_formularios"
        Me.btn_formularios.Size = New System.Drawing.Size(220, 50)
        Me.btn_formularios.TabIndex = 6
        Me.btn_formularios.Text = "Emitir Formulários"
        Me.btn_formularios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_formularios.UseVisualStyleBackColor = True
        '
        'btn_emprestimo
        '
        Me.btn_emprestimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_emprestimo.FlatAppearance.BorderSize = 0
        Me.btn_emprestimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_emprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emprestimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emprestimo.ForeColor = System.Drawing.Color.White
        Me.btn_emprestimo.Image = CType(resources.GetObject("btn_emprestimo.Image"), System.Drawing.Image)
        Me.btn_emprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_emprestimo.Location = New System.Drawing.Point(0, 289)
        Me.btn_emprestimo.Name = "btn_emprestimo"
        Me.btn_emprestimo.Size = New System.Drawing.Size(220, 50)
        Me.btn_emprestimo.TabIndex = 4
        Me.btn_emprestimo.Text = "Empréstimo de livros"
        Me.btn_emprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_emprestimo.UseVisualStyleBackColor = True
        '
        'brn_cad_livros
        '
        Me.brn_cad_livros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brn_cad_livros.FlatAppearance.BorderSize = 0
        Me.brn_cad_livros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.brn_cad_livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brn_cad_livros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brn_cad_livros.ForeColor = System.Drawing.Color.White
        Me.brn_cad_livros.Image = CType(resources.GetObject("brn_cad_livros.Image"), System.Drawing.Image)
        Me.brn_cad_livros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brn_cad_livros.Location = New System.Drawing.Point(0, 212)
        Me.brn_cad_livros.Name = "brn_cad_livros"
        Me.brn_cad_livros.Size = New System.Drawing.Size(220, 50)
        Me.brn_cad_livros.TabIndex = 3
        Me.brn_cad_livros.Text = "Cadastro de livros"
        Me.brn_cad_livros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brn_cad_livros.UseVisualStyleBackColor = True
        '
        'btn_cad_clientes
        '
        Me.btn_cad_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cad_clientes.FlatAppearance.BorderSize = 0
        Me.btn_cad_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btn_cad_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_cad_clientes.Image = CType(resources.GetObject("btn_cad_clientes.Image"), System.Drawing.Image)
        Me.btn_cad_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_clientes.Location = New System.Drawing.Point(0, 140)
        Me.btn_cad_clientes.Name = "btn_cad_clientes"
        Me.btn_cad_clientes.Size = New System.Drawing.Size(220, 50)
        Me.btn_cad_clientes.TabIndex = 2
        Me.btn_cad_clientes.Text = "Cadastro de clientes"
        Me.btn_cad_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cad_clientes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.Location = New System.Drawing.Point(176, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(44, 34)
        Me.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_menu.TabIndex = 0
        Me.btn_menu.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.OldLace
        Me.PanelContenedor.Controls.Add(Me.btn_gerenciar)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(880, 540)
        Me.PanelContenedor.TabIndex = 2
        '
        'btn_gerenciar
        '
        Me.btn_gerenciar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gerenciar.Location = New System.Drawing.Point(0, 530)
        Me.btn_gerenciar.Name = "btn_gerenciar"
        Me.btn_gerenciar.Size = New System.Drawing.Size(10, 10)
        Me.btn_gerenciar.TabIndex = 0
        Me.btn_gerenciar.UseVisualStyleBackColor = False
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_menu"
        Me.Text = "frm_menu"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_restaurar As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_menu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cad_clientes As Button
    Friend WithEvents btn_formularios As Button
    Friend WithEvents btn_emprestimo As Button
    Friend WithEvents brn_cad_livros As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_cad_contas As Button
End Class
