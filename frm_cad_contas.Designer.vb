<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_contas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_contas))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_secreto = New System.Windows.Forms.Button()
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.txt_palavra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_busca = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.DGV_DADOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DGV_DADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(733, 388)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.OldLace
        Me.TabPage1.Controls.Add(Me.btn_secreto)
        Me.TabPage1.Controls.Add(Me.btn_visualizar)
        Me.TabPage1.Controls.Add(Me.txt_palavra)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_rsenha)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_senha)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_cadastro)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_usuario)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(725, 362)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de contas"
        '
        'btn_secreto
        '
        Me.btn_secreto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_secreto.BackColor = System.Drawing.Color.Transparent
        Me.btn_secreto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_secreto.FlatAppearance.BorderSize = 0
        Me.btn_secreto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_secreto.Image = CType(resources.GetObject("btn_secreto.Image"), System.Drawing.Image)
        Me.btn_secreto.Location = New System.Drawing.Point(553, 241)
        Me.btn_secreto.Name = "btn_secreto"
        Me.btn_secreto.Size = New System.Drawing.Size(40, 22)
        Me.btn_secreto.TabIndex = 38
        Me.btn_secreto.UseVisualStyleBackColor = False
        '
        'btn_visualizar
        '
        Me.btn_visualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_visualizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_visualizar.FlatAppearance.BorderSize = 0
        Me.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_visualizar.Image = CType(resources.GetObject("btn_visualizar.Image"), System.Drawing.Image)
        Me.btn_visualizar.Location = New System.Drawing.Point(553, 239)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(40, 22)
        Me.btn_visualizar.TabIndex = 39
        Me.btn_visualizar.UseVisualStyleBackColor = False
        '
        'txt_palavra
        '
        Me.txt_palavra.Location = New System.Drawing.Point(228, 245)
        Me.txt_palavra.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_palavra.Name = "txt_palavra"
        Me.txt_palavra.Size = New System.Drawing.Size(159, 20)
        Me.txt_palavra.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(112, 244)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Palavra Chave:"
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha.Location = New System.Drawing.Point(462, 200)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rsenha.Size = New System.Drawing.Size(131, 22)
        Me.txt_rsenha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Confirmar Senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(168, 199)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(131, 22)
        Me.txt_senha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Senha:"
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_cadastro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastro.Location = New System.Drawing.Point(295, 298)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(131, 35)
        Me.btn_cadastro.TabIndex = 6
        Me.btn_cadastro.Text = "CRIAR CONTA"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(201, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(329, 31)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "CADASTRO DE CONTAS"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(182, 155)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(411, 22)
        Me.txt_email.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "E-mail:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(182, 110)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(411, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.OldLace
        Me.TabPage2.Controls.Add(Me.ToolStrip3)
        Me.TabPage2.Controls.Add(Me.DGV_DADOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(725, 362)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de contas"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.BurlyWood
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txt_busca, Me.cmb_busca, Me.ToolStripButton3})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(719, 25)
        Me.ToolStrip3.TabIndex = 4
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel2.Text = "Busca:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 25)
        '
        'cmb_busca
        '
        Me.cmb_busca.Name = "cmb_busca"
        Me.cmb_busca.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton2"
        '
        'DGV_DADOS
        '
        Me.DGV_DADOS.AllowUserToAddRows = False
        Me.DGV_DADOS.AllowUserToDeleteRows = False
        Me.DGV_DADOS.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DADOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.DGV_DADOS.GridColor = System.Drawing.Color.OldLace
        Me.DGV_DADOS.Location = New System.Drawing.Point(-4, 28)
        Me.DGV_DADOS.Name = "DGV_DADOS"
        Me.DGV_DADOS.ReadOnly = True
        Me.DGV_DADOS.Size = New System.Drawing.Size(725, 331)
        Me.DGV_DADOS.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Usuario"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Senha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        Me.Column7.HeaderText = "Bloquear"
        Me.Column7.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.block_icon
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column6
        '
        Me.Column6.HeaderText = "Excluir"
        Me.Column6.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Excluir"
        Me.DataGridViewImageColumn1.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 28)
        Me.Panel1.TabIndex = 29
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(688, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(41, 22)
        Me.btn_close.TabIndex = 2
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'frm_cad_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(732, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cad_contas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cad_contas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DGV_DADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents cmb_busca As ToolStripComboBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents DGV_DADOS As DataGridView
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_palavra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_secreto As Button
    Friend WithEvents btn_visualizar As Button
End Class
