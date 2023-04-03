<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_livros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_livros))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.img_livro = New System.Windows.Forms.PictureBox()
        Me.txt_cod = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pag = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_editora = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_autor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_busca = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.DGV_DADOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_livro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGV_DADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 452)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.OldLace
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.img_livro)
        Me.TabPage1.Controls.Add(Me.txt_cod)
        Me.TabPage1.Controls.Add(Me.cmb_genero)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_pag)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_ano)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_editora)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_autor)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de Livros"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_cadastrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.Location = New System.Drawing.Point(572, 320)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(131, 35)
        Me.btn_cadastrar.TabIndex = 31
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'img_livro
        '
        Me.img_livro.BackgroundImage = CType(resources.GetObject("img_livro.BackgroundImage"), System.Drawing.Image)
        Me.img_livro.Location = New System.Drawing.Point(585, 52)
        Me.img_livro.Name = "img_livro"
        Me.img_livro.Size = New System.Drawing.Size(118, 126)
        Me.img_livro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_livro.TabIndex = 30
        Me.img_livro.TabStop = False
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(595, 184)
        Me.txt_cod.Mask = "999-99-99999-99-9"
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(110, 20)
        Me.txt_cod.TabIndex = 2
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_genero
        '
        Me.cmb_genero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Items.AddRange(New Object() {"Suspense", "Ação", "Ficção", "Romance", "Terror", "Infantil"})
        Me.cmb_genero.Location = New System.Drawing.Point(125, 262)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(121, 27)
        Me.cmb_genero.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nome do Autor:"
        '
        'txt_pag
        '
        Me.txt_pag.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pag.Location = New System.Drawing.Point(427, 258)
        Me.txt_pag.Name = "txt_pag"
        Me.txt_pag.Size = New System.Drawing.Size(38, 26)
        Me.txt_pag.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(209, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 31)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "CADASTRO DE LIVROS"
        '
        'txt_ano
        '
        Me.txt_ano.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.Location = New System.Drawing.Point(660, 258)
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(45, 26)
        Me.txt_ano.TabIndex = 5
        Me.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(519, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Ano de publicação:"
        '
        'txt_editora
        '
        Me.txt_editora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_editora.Location = New System.Drawing.Point(124, 329)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(367, 26)
        Me.txt_editora.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Editora:"
        '
        'txt_autor
        '
        Me.txt_autor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_autor.Location = New System.Drawing.Point(169, 182)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(341, 26)
        Me.txt_autor.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gênero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "N° de páginas:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(169, 88)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(344, 26)
        Me.txt_nome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Livro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod.:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.OldLace
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.DGV_DADOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de Livros"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.BurlyWood
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txt_busca, Me.cmb_busca, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.DGV_DADOS.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DADOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGV_DADOS.Location = New System.Drawing.Point(3, 29)
        Me.DGV_DADOS.Name = "DGV_DADOS"
        Me.DGV_DADOS.Size = New System.Drawing.Size(786, 391)
        Me.DGV_DADOS.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cod"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome do Livro"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome do Autor"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gênero"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.HeaderText = "Editar"
        Me.Column6.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.edit_icon1
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Excluir"
        Me.Column7.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon2
        Me.Column7.Name = "Column7"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 31)
        Me.Panel1.TabIndex = 30
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(759, 6)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(36, 22)
        Me.btn_close.TabIndex = 2
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.edit_icon1
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Excluir"
        Me.DataGridViewImageColumn2.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon2
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'frm_cad_livros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(798, 481)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cad_livros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cad_livros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_livro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGV_DADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_cod As MaskedTextBox
    Friend WithEvents cmb_genero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pag As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DGV_DADOS As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents cmb_busca As ToolStripComboBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents img_livro As PictureBox
    Friend WithEvents btn_cadastrar As Button
End Class
