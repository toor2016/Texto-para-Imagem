<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeArquivo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.btnFonte = New System.Windows.Forms.Button()
        Me.btnCorFonte = New System.Windows.Forms.Button()
        Me.btnCorFundo = New System.Windows.Forms.Button()
        Me.btnGerarImagem = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picIcone = New System.Windows.Forms.PictureBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNomeArquivo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnFonte)
        Me.GroupBox1.Controls.Add(Me.btnCorFonte)
        Me.GroupBox1.Controls.Add(Me.btnCorFundo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuração"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtY)
        Me.GroupBox3.Controls.Add(Me.txtX)
        Me.GroupBox3.Location = New System.Drawing.Point(265, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 88)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Posicionamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Y"
        '
        'TxtY
        '
        Me.TxtY.Location = New System.Drawing.Point(42, 53)
        Me.TxtY.Name = "TxtY"
        Me.TxtY.Size = New System.Drawing.Size(100, 20)
        Me.TxtY.TabIndex = 10
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(42, 27)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Local e Nome do Arquivo"
        '
        'txtNomeArquivo
        '
        Me.txtNomeArquivo.Location = New System.Drawing.Point(133, 127)
        Me.txtNomeArquivo.Name = "txtNomeArquivo"
        Me.txtNomeArquivo.Size = New System.Drawing.Size(313, 20)
        Me.txtNomeArquivo.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtAltura)
        Me.GroupBox2.Controls.Add(Me.txtLargura)
        Me.GroupBox2.Location = New System.Drawing.Point(88, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 88)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dimensões da Imagem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Largura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Altura"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(56, 53)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 10
        '
        'txtLargura
        '
        Me.txtLargura.Location = New System.Drawing.Point(56, 27)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(100, 20)
        Me.txtLargura.TabIndex = 9
        '
        'btnFonte
        '
        Me.btnFonte.Location = New System.Drawing.Point(7, 19)
        Me.btnFonte.Name = "btnFonte"
        Me.btnFonte.Size = New System.Drawing.Size(75, 23)
        Me.btnFonte.TabIndex = 2
        Me.btnFonte.Text = "Fonte"
        Me.btnFonte.UseVisualStyleBackColor = True
        '
        'btnCorFonte
        '
        Me.btnCorFonte.Location = New System.Drawing.Point(7, 49)
        Me.btnCorFonte.Name = "btnCorFonte"
        Me.btnCorFonte.Size = New System.Drawing.Size(75, 23)
        Me.btnCorFonte.TabIndex = 1
        Me.btnCorFonte.Text = "Cor Fonte"
        Me.btnCorFonte.UseVisualStyleBackColor = True
        '
        'btnCorFundo
        '
        Me.btnCorFundo.Location = New System.Drawing.Point(7, 78)
        Me.btnCorFundo.Name = "btnCorFundo"
        Me.btnCorFundo.Size = New System.Drawing.Size(75, 23)
        Me.btnCorFundo.TabIndex = 0
        Me.btnCorFundo.Text = "Cor Fundo"
        Me.btnCorFundo.UseVisualStyleBackColor = True
        '
        'btnGerarImagem
        '
        Me.btnGerarImagem.Location = New System.Drawing.Point(354, 159)
        Me.btnGerarImagem.Name = "btnGerarImagem"
        Me.btnGerarImagem.Size = New System.Drawing.Size(93, 23)
        Me.btnGerarImagem.TabIndex = 3
        Me.btnGerarImagem.Text = "Gerar Imagem"
        Me.btnGerarImagem.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(241, 300)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(93, 161)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(255, 20)
        Me.txtTexto.TabIndex = 5
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(93, 213)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(255, 77)
        Me.picImagem.TabIndex = 7
        Me.picImagem.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Texto Imagem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Imagem"
        '
        'picIcone
        '
        Me.picIcone.Image = CType(resources.GetObject("picIcone.Image"), System.Drawing.Image)
        Me.picIcone.Location = New System.Drawing.Point(21, 213)
        Me.picIcone.Name = "picIcone"
        Me.picIcone.Size = New System.Drawing.Size(16, 11)
        Me.picIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIcone.TabIndex = 15
        Me.picIcone.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(160, 300)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 16
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 335)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.picIcone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnGerarImagem)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Texto para Imagem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGerarImagem As System.Windows.Forms.Button
    Friend WithEvents btnFonte As System.Windows.Forms.Button
    Friend WithEvents btnCorFonte As System.Windows.Forms.Button
    Friend WithEvents btnCorFundo As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents picImagem As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtLargura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeArquivo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picIcone As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button

End Class
