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
End Class
