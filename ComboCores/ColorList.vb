Imports System.Drawing
Imports System.Drawing.Imaging
Imports System
Imports System.Drawing.Text
Imports System.Windows
Public Class ComboCor
    Inherits ComboBox

    Dim oColors() As Color

    Public Sub New()
        Me.DoubleBuffered = True

        Dim oKnownColors() As KnownColor = CType([Enum].GetValues(GetType(KnownColor)), KnownColor())
        ' Temporary list of Colors
        Dim oTempList As New List(Of Color)

        ' Get list of Web Colors
        For Each oKnownColor As KnownColor In oKnownColors
            Dim oColor As Color = Color.FromKnownColor(oKnownColor)
            Dim OK As Boolean = True
            If oColor = Color.Empty Then OK = False
            If oColor = Color.Transparent Then OK = False
            If oColor.IsSystemColor Then OK = False
            If OK Then
                oTempList.Add(Color.FromKnownColor(oKnownColor))
            End If
        Next

        'Sort to match the run-time color list
        oColors = (From c In oTempList Order By c.GetHue, c.GetSaturation, c.GetBrightness).ToArray

        Me.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    'Protected Overrides Sub OnDrawItem(e As System.Windows.Forms.DrawItemEventArgs)
    '    MyBase.OnDrawItem(e)

    '    If e.Index <= oColors.Count - 1 Then
    '        With e.Graphics
    '            e.DrawBackground()
    '            .Clip = New Region(e.Bounds)
    '            Dim R As Rectangle = New Rectangle(e.Bounds.Left, e.Bounds.Top, 30, e.Bounds.Bottom)
    '            Dim C As Color = oColors(e.Index)
    '            Dim B As SolidBrush = New SolidBrush(C)

    '            .FillRectangle(B, R)
    '            e.DrawFocusRectangle()

    '            Dim TxtR As Rectangle = New Rectangle(e.Bounds.Left + 34, e.Bounds.Top, e.Bounds.Right - 34, e.Bounds.Bottom)

    '            .DrawString(oColors(e.Index).ToKnownColor.ToString, Me.Font, Brushes.Black, TxtR)

    '            e.DrawFocusRectangle()
    '        End With
    '    End If

    'End Sub

    Protected Overrides Sub OnDrawItem(e As System.Windows.Forms.DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        If e.Index <= oColors.Count - 1 Then
            e.DrawBackground()

            Dim colorBounds As Rectangle = New Rectangle(e.Bounds.Left, e.Bounds.Top, 30, e.Bounds.Height)
            Dim itemColor As Color = oColors(e.Index)
            Using colorBrush As SolidBrush = New SolidBrush(itemColor)
                e.Graphics.FillRectangle(colorBrush, colorBounds)
            End Using

            Dim textBounds As Rectangle = New Rectangle(e.Bounds.Left + 34, e.Bounds.Top, e.Bounds.Right - 34, e.Bounds.Bottom)
            e.Graphics.DrawString(oColors(e.Index).ToKnownColor.ToString, Me.Font, Brushes.Black, textBounds)

            e.DrawFocusRectangle()
        End If
    End Sub

    Protected Overrides Sub OnMouseWheel(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseWheel(e)
        Me.Invalidate()
    End Sub

End Class