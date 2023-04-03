<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_emprestimo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emprestimo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.img_livro = New System.Windows.Forms.PictureBox()
        Me.txt_cod = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_livro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_autor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_devolucao = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_emprestar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_emprestimo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_busca = New System.Windows.Forms.ToolStripComboBox()
        Me.DGV_DADOS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(960, 495)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.OldLace
        Me.TabPage1.Controls.Add(Me.img_livro)
        Me.TabPage1.Controls.Add(Me.txt_cod)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_livro)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txt_autor)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_devolucao)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.btn_emprestar)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_emprestimo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(952, 469)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empréstimo de livros"
        '
        'img_livro
        '
        Me.img_livro.BackgroundImage = CType(resources.GetObject("img_livro.BackgroundImage"), System.Drawing.Image)
        Me.img_livro.Location = New System.Drawing.Point(702, 195)
        Me.img_livro.Name = "img_livro"
        Me.img_livro.Size = New System.Drawing.Size(129, 129)
        Me.img_livro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_livro.TabIndex = 32
        Me.img_livro.TabStop = False
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(144, 167)
        Me.txt_cod.Mask = "999-99-99999-99-9"
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(110, 20)
        Me.txt_cod.TabIndex = 2
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Cod.:"
        '
        'txt_livro
        '
        Me.txt_livro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_livro.Location = New System.Drawing.Point(420, 167)
        Me.txt_livro.Name = "txt_livro"
        Me.txt_livro.Size = New System.Drawing.Size(411, 22)
        Me.txt_livro.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(292, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 19)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Nome do livro:"
        '
        'txt_autor
        '
        Me.txt_autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_autor.Location = New System.Drawing.Point(214, 261)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(411, 22)
        Me.txt_autor.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(95, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Nome do autor:"
        '
        'txt_devolucao
        '
        Me.txt_devolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_devolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_devolucao.Location = New System.Drawing.Point(714, 362)
        Me.txt_devolucao.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txt_devolucao.Name = "txt_devolucao"
        Me.txt_devolucao.Size = New System.Drawing.Size(117, 22)
        Me.txt_devolucao.TabIndex = 6
        Me.txt_devolucao.Value = New Date(2022, 10, 25, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(573, 363)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Data de devoluçao:"
        '
        'btn_emprestar
        '
        Me.btn_emprestar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_emprestar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_emprestar.Location = New System.Drawing.Point(420, 407)
        Me.btn_emprestar.Name = "btn_emprestar"
        Me.btn_emprestar.Size = New System.Drawing.Size(131, 35)
        Me.btn_emprestar.TabIndex = 7
        Me.btn_emprestar.Text = "EMPRESTAR"
        Me.btn_emprestar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(356, 31)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "EMPRÉSTIMO DE LIVROS"
        '
        'txt_emprestimo
        '
        Me.txt_emprestimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emprestimo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_emprestimo.Location = New System.Drawing.Point(249, 360)
        Me.txt_emprestimo.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txt_emprestimo.Name = "txt_emprestimo"
        Me.txt_emprestimo.Size = New System.Drawing.Size(117, 22)
        Me.txt_emprestimo.TabIndex = 5
        Me.txt_emprestimo.Value = New Date(2022, 10, 25, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data de emprestimo:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(420, 104)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(411, 22)
        Me.txt_nome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do cliente:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(137, 102)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(120, 22)
        Me.txt_cpf.TabIndex = 0
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.OldLace
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.DGV_DADOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(952, 469)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de Empréstimos"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.BurlyWood
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca, Me.cmb_busca})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(946, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel1.Text = "Busca:"
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
        'DGV_DADOS
        '
        Me.DGV_DADOS.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DADOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DGV_DADOS.Location = New System.Drawing.Point(6, 35)
        Me.DGV_DADOS.Name = "DGV_DADOS"
        Me.DGV_DADOS.Size = New System.Drawing.Size(944, 438)
        Me.DGV_DADOS.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "CPF"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome do Cliente"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cod"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nome do Livro"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nome do autor"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Data de Emprestimo"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Data de Devoluçao"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Atualizar"
        Me.Column8.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.edit_icon
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column9
        '
        Me.Column9.HeaderText = "Devolver"
        Me.Column9.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon1
        Me.Column9.Name = "Column9"
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Atualizar"
        Me.DataGridViewImageColumn1.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.edit_icon
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Devolver"
        Me.DataGridViewImageColumn2.Image = Global.Biblioteca_LaLivros.My.Resources.Resources.cancel_icon1
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 28)
        Me.Panel1.TabIndex = 31
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(913, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(37, 22)
        Me.btn_close.TabIndex = 2
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'frm_emprestimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(960, 522)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_emprestimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_emprestimo"
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
    Friend WithEvents btn_emprestar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_emprestimo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_devolucao As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_livro As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_cod As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents img_livro As PictureBox
    Friend WithEvents DGV_DADOS As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents cmb_busca As ToolStripComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_close As Button
End Class
