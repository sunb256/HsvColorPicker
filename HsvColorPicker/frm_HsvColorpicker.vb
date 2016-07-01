
Public Class frm_HsvColorpicker

  Private _hsb As New Hsv
  Private _isCancel As Boolean = False

  Private h, s, v As Double

  Public Shadows Function Show() As Hsv
    MyBase.Show()

    If _isCancel Then
      Return Nothing
    Else
      Return _hsb
    End If
  End Function

  Public Shadows Function ShowDialog(Optional ByVal h As Double = 0, Optional ByVal s As Double = 0, Optional ByVal v As Double = 0) As Hsv

    Me.h = h
    Me.s = s
    Me.v = v
    Call PaintColorViewControl(h, s, v)

    MyBase.ShowDialog()

    If _isCancel Then
      Return Nothing
    Else
      Return _hsb
    End If

  End Function

  Private Sub frm_HsvColorpicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    _isCancel = False
  End Sub
  Private Sub frm_HsvColorpicker_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    lbl_H.Text = h
    lbl_S.Text = s
    lbl_V.Text = v
    sbar_H.Value = h
    sbar_S.Value = s
    sbar_V.Value = v

    Call PaintColorViewControl(Val(lbl_H.Text), Val(lbl_S.Text), Val(lbl_V.Text))
    Me.Update()
  End Sub


  Private Sub sbar_H_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbar_V.ValueChanged, sbar_S.ValueChanged, sbar_H.ValueChanged

    Select Case sender.name
      Case sbar_H.Name
        lbl_H.Text = sbar_H.Value
      Case sbar_S.Name
        lbl_S.Text = sbar_S.Value
      Case sbar_V.Name
        lbl_V.Text = sbar_V.Value
    End Select

    'Call DrawAllowScroll(Val(sbar_H.Value))

    'width->255->360 諧調変換
    Dim _8bit_val_h As Integer = CInt(Hsv.Unit(Val(lbl_H.Text), 255, 360))

    lblColor.BackColor = Hsv.HsvToColor(_8bit_val_h, Val(lbl_S.Text), Val(lbl_V.Text))
    Call PaintColorViewControl(Val(lbl_H.Text), Val(lbl_S.Text), Val(lbl_V.Text))

    lblRgbValue.Text = lblColor.BackColor.R.ToString("X2") & _
                       lblColor.BackColor.G.ToString("X2") & _
                       lblColor.BackColor.B.ToString("X2") & "(" & _
                       lblColor.BackColor.R.ToString.PadLeft(3) & "," & _
                       lblColor.BackColor.G.ToString.PadLeft(3) & "," & _
                       lblColor.BackColor.B.ToString.PadLeft(3) & ")"

  End Sub

  Sub DrawAllowScroll(ByVal offset As Double)

    offset = Hsv.Unit(offset, 255, sbar_H.Width - 40)

    Dim sendervalue_w As Integer = sbar_H.Location.X + 15 + offset
    Dim sendervalue_h As Integer = sbar_H.Location.Y - 10


    Dim g As Graphics = Me.GroupBox1.CreateGraphics
    Dim myBrush As Brush = System.Drawing.SystemBrushes.Control
    g.FillRectangle(myBrush, sendervalue_w - 8, sendervalue_h, sendervalue_h + 10, sendervalue_h + 10)       ' clear right hand slider

    Dim pencil As New Pen(Color.FromArgb(116, 114, 106))    ' Same gray Photoshop uses
    Dim WhiteBrush As Brush = Brushes.White

    Dim UpArrow As Point() = _
    { _
      New Point(0 + sendervalue_w, 0 + sendervalue_h), _
      New Point(0 + sendervalue_w, 1 + sendervalue_h), _
      New Point(0 + sendervalue_w, 5 + sendervalue_h), _
      New Point(4 + sendervalue_w, 9 + sendervalue_h), _
      New Point(8 + sendervalue_w, 5 + sendervalue_h), _
      New Point(8 + sendervalue_w, 0 + sendervalue_h), _
      New Point(0 + sendervalue_w, 0 + sendervalue_h) _
    }

    g.FillPolygon(WhiteBrush, UpArrow)  ' Fill left arrow with white
    g.DrawPolygon(pencil, UpArrow)    ' Draw left arrow border with gray

  End Sub

  Sub PaintColorViewControl(ByVal val_h As Integer, ByVal val_s As Integer, ByVal val_v As Integer)

    Dim h_bmp As New Bitmap(pic_h.Width, pic_h.Height)
    Dim s_bmp As New Bitmap(pic_s.Width, pic_s.Height)
    Dim v_bmp As New Bitmap(pic_v.Width, pic_v.Height)

    'width->255->360 諧調変換
    Dim _8bit_val_h As Integer = CInt(Hsv.Unit(val_h, 255, 360))


    'H:Hue 描画
    For i As Integer = 0 To pic_h.Width - 1

      'width->255->360 諧調変換
      Dim _8bit As Integer = CInt(Hsv.Unit(i, pic_h.Width, 255))
      Dim rad As Integer = CInt(Hsv.Unit(_8bit, 255, 360))

      Dim c As Color = Hsv.HsvToColor(rad, 255, 255)

      For h As Integer = 0 To h_bmp.Height - 1
        h_bmp.SetPixel(i, h, c)
      Next
    Next

    'S:Saturation 描画
    For i As Integer = 0 To pic_s.Width - 1

      Dim value As Integer = CInt(Hsv.Unit(i, pic_s.Width, 255))
      Dim c As Color = Hsv.HsvToColor(_8bit_val_h, value, 255)

      For h As Integer = 0 To s_bmp.Height - 1
        s_bmp.SetPixel(i, h, c)
      Next
    Next

    'V:Value 描画
    For i As Integer = 0 To pic_v.Width - 1

      Dim value As Integer = CInt(Hsv.Unit(i, pic_v.Width, 255))
      Dim c As Color = Hsv.HsvToColor(_8bit_val_h, val_s, value)

      For h As Integer = 0 To v_bmp.Height - 1
        v_bmp.SetPixel(i, h, c)
      Next
    Next

    pic_h.Image = h_bmp
    pic_s.Image = s_bmp
    pic_v.Image = v_bmp
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

    _hsb.H = CInt(Hsv.Unit(Val(lbl_H.Text), 255, 360))
    _hsb.S = lbl_S.Text
    _hsb.V = lbl_V.Text

    Me.Close()
  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    _isCancel = True
    Me.Close()
  End Sub


End Class


Public Class Hsv

  Private _H As Integer
  Private _S As Integer
  Private _V As Integer

#Region " property "

  '0～360
  Public Property H()
    Get
      Return _H
    End Get
    Set(ByVal value)
      _H = value
    End Set
  End Property

  '0～255
  Public ReadOnly Property H_8bit()
    Get
      Return CInt(Unit(_H, 360, 255))
    End Get
  End Property

  Public Property S()
    Get
      Return _S
    End Get
    Set(ByVal value)
      _S = value
    End Set
  End Property

  Public Property V()
    Get
      Return _V
    End Get
    Set(ByVal value)
      _V = value
    End Set
  End Property

  Public ReadOnly Property R()
    Get
      Return HsvToColor(_H, _S, _V).R
    End Get
  End Property

  Public ReadOnly Property G()
    Get
      Return HsvToColor(_H, _S, _V).G
    End Get
  End Property

  Public ReadOnly Property B()
    Get
      Return HsvToColor(_H, _S, _V).B
    End Get
  End Property

  Public ReadOnly Property RgbColor()
    Get
      Return HsvToColor(_H, _S, _V)
    End Get
  End Property


#End Region

  Shared Sub ColorToHsv(ByVal color As Color, _
                        ByRef h As Double, ByRef s As Double, ByRef v As Double)

    Dim max As Integer = Math.Max(color.R, Math.Max(color.G, color.B))
    Dim min As Integer = Math.Min(color.R, Math.Min(color.G, color.B))

    h = color.GetHue()

    If max = 0 Then
      s = 0
    Else
      s = 1 - (min / max)
    End If

    v = max / 255

  End Sub

  Shared Function HsvToColor(ByVal h As Double, ByVal s As Double, ByVal v As Double) As Color

    Dim hi As Integer = CInt(Math.Floor(h / 60)) Mod 6
    Dim f As Double = (h / 60) - Math.Floor(h / 60)

    Dim vv, pp, qq, tt As Integer
    vv = CInt(v)
    pp = CInt(v * (1 - (s / 255)))
    qq = CInt(v * (1 - (s / 255) * f))
    tt = CInt(v * (1 - (s / 255) * (1 - f)))

    'Debug.Print("vv : " & vv & ", pp : " & pp & ", qq : " & qq & ", tt : " & tt)

    Select Case hi
      Case 0
        Return Color.FromArgb(255, vv, tt, pp)
      Case 1
        Return Color.FromArgb(255, qq, vv, pp)
      Case 2
        Return Color.FromArgb(255, pp, vv, tt)
      Case 3
        Return Color.FromArgb(255, pp, qq, vv)
      Case 4
        Return Color.FromArgb(255, tt, pp, vv)
      Case Else
        Return Color.FromArgb(255, vv, pp, qq)
    End Select

  End Function

  ''' ------------------------------------------------------
  ''' <summary>単位変換</summary>
  ''' ------------------------------------------------------
  Shared Function Unit(ByVal value As Double, ByVal ValueMaxUnit As Double, ByVal ExchangeMaxUnit As Double) As Double
    Return (value / ValueMaxUnit) * ExchangeMaxUnit
  End Function

End Class