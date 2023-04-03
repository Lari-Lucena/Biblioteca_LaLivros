<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.btn_secreto = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(31, 174)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(216, 22)
        Me.txt_senha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Senha:"
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_cadastro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastro.Location = New System.Drawing.Point(114, 240)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(98, 33)
        Me.btn_cadastro.TabIndex = 4
        Me.btn_cadastro.Text = "ENTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(111, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 31)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "LOGIN"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(31, 109)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(254, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario ou e-mail:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.Location = New System.Drawing.Point(28, 209)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(108, 15)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Esqueceu a Senha?"
        '
        'btn_visualizar
        '
        Me.btn_visualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_visualizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_visualizar.FlatAppearance.BorderSize = 0
        Me.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_visualizar.Image = CType(resources.GetObject("btn_visualizar.Image"), System.Drawing.Image)
        Me.btn_visualizar.Location = New System.Drawing.Point(245, 174)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(40, 22)
        Me.btn_visualizar.TabIndex = 36
        Me.btn_visualizar.UseVisualStyleBackColor = False
        '
        'btn_secreto
        '
        Me.btn_secreto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_secreto.BackColor = System.Drawing.Color.Transparent
        Me.btn_secreto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_secreto.FlatAppearance.BorderSize = 0
        Me.btn_secreto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_secreto.Image = CType(resources.GetObject("btn_secreto.Image"), System.Drawing.Image)
        Me.btn_secreto.Location = New System.Drawing.Point(245, 174)
        Me.btn_secreto.Name = "btn_secreto"
        Me.btn_secreto.Size = New System.Drawing.Size(40, 22)
        Me.btn_secreto.TabIndex = 37
        Me.btn_secreto.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(278, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 24)
        Me.btn_close.TabIndex = 1
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 24)
        Me.Panel1.TabIndex = 38
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(313, 307)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_secreto)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_visualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btn_visualizar As Button
    Friend WithEvents btn_secreto As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel1 As Panel
End Class
