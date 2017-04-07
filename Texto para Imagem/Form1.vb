Imports System.Drawing
Imports System.Drawing.Imaging
Imports System
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.TextBox

Public Class Form1
    Dim FontNome As String = "Segoe UI"
    Dim FontTamanho As Integer = 12
    Dim FontCor As Color = Color.Black
    Dim CorFundo As Color = Color.White
    Dim largura As Integer = 200
    Dim altura As Integer = 30

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtAltura.Text = 18
        txtLargura.Text = 84
        txtNomeArquivo.Text = "C:\"
    End Sub


    Private Sub btnFonte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFonte.Click
        Dim dlg As New FontDialog
        If dlg.ShowDialog = DialogResult.OK Then
            btnFonte.Font = dlg.Font
            FontNome = dlg.Font.Name
            FontTamanho = dlg.Font.Size
        End If
    End Sub

    Private Sub btnCorFonte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCorFonte.Click
        Dim dlg As New ColorDialog
        If dlg.ShowDialog() = DialogResult.OK Then
            FontCor = dlg.Color
            btnCorFonte.BackColor = dlg.Color
        End If
    End Sub

    Private Sub btnCorFundo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCorFundo.Click
        Dim dlg As New ColorDialog
        If dlg.ShowDialog() = DialogResult.OK Then
            CorFundo = dlg.Color
            btnCorFundo.BackColor = dlg.Color
        End If
    End Sub

    Private Sub btnGerarImagem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGerarImagem.Click

        Try
            largura = Convert.ToInt32(txtLargura.Text)
            altura = Convert.ToInt32(txtAltura.Text)
            'cria um bitmap usando a largura e altura definidas
            Dim objBitmap As New Bitmap(largura, altura)
            'cria um objeto Graphics usando o bitmap 
            Dim objGraphics As Graphics = Graphics.FromImage(objBitmap)

            ' cria os objetos Color , Font e PointF
            Dim objColor As Color = Nothing
            Dim objFont As New Font(FontNome, FontTamanho)
            ' define onde o texto será exibido na área da imagem
            'Dim objPoint As New PointF(0.0F, -3.0F)
            Dim objPoint As New PointF(txtX.Text, TxtY.Text)

            ' cria dois objetos SolidBrush
            Dim objBrushForeColor As New SolidBrush(FontCor)
            Dim objBrushBackColor As New SolidBrush(CorFundo)
            'Cria um retãngulo usando o objeto Graphics 
            objGraphics.FillRectangle(objBrushBackColor, 0, 0, 500, 500)
            'Desenha o texto no retângulo usando o objeto Graphics
            objGraphics.DrawString(txtTexto.Text, objFont, objBrushForeColor, objPoint)
            'salva e exibe a imagem gerada
            objBitmap.Save(txtNomeArquivo.Text & ".bmp", ImageFormat.Bmp)
            picImagem.Image = objBitmap
            'MessageBox.Show("Imagem criada com sucesso.")
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub txtNomeArquivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeArquivo.Leave
        'Dim messageBoxText As String = "Do you want to save changes?"
        Dim caption As String = "Word Processor"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNoCancel
        Dim icon As MessageBoxIcon = MessageBoxIcon.Warning
        'Dim result As MsgBoxResult = MessageBox.Show(messageBoxText, caption, button, icon)

        If txtNomeArquivo.Text = "" Then
            MessageBox.Show("O caminho não pode estar vazio!")
        End If
        If Not (My.Computer.FileSystem.DirectoryExists(txtNomeArquivo.Text)) Then
            MessageBox.Show("Diretório não existe!")
            Dim result = MessageBox.Show("O diretório" + txtNomeArquivo.Text + "pode ser criado?", caption, button, icon)
            Select Case result
                Case MsgBoxResult.Yes
                    ' User pressed Yes button
                    My.Computer.FileSystem.CreateDirectory(txtNomeArquivo.Text)
                Case MsgBoxResult.No
                    ' User pressed No button
                    ' ...
                Case MsgBoxResult.Cancel
                    ' User pressed Cancel button
                    ' ...
            End Select

        End If


    End Sub

    Private Sub txtLargura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLargura.Leave
        If (txtLargura.Text = "") Then
            MessageBox.Show("Largura deve ser definida!", "Validação", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub txtAltura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAltura.Leave
        If (txtAltura.Text = "") Then
            MessageBox.Show("Altura deve ser definida!", "Validação", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub txtX_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtX.Leave
        If (txtX.Text = "") Then
            MessageBox.Show("Posicionamento X deve ser definido!", "Validação", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub TxtY_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtY.Leave
        If (TxtY.Text = "") Then
            MessageBox.Show("Posicionamento X deve ser definido!", "Validação", MessageBoxButtons.OK)
        End If
    End Sub
End Class
