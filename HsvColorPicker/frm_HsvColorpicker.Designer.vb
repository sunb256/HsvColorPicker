<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HsvColorpicker
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HsvColorpicker))
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.pic_v = New System.Windows.Forms.PictureBox
    Me.pic_s = New System.Windows.Forms.PictureBox
    Me.pic_h = New System.Windows.Forms.PictureBox
    Me.lblColor = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblRgbValue = New System.Windows.Forms.Label
    Me.lbl_V = New System.Windows.Forms.Label
    Me.lbl_S = New System.Windows.Forms.Label
    Me.lbl_H = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.sbar_V = New System.Windows.Forms.HScrollBar
    Me.sbar_S = New System.Windows.Forms.HScrollBar
    Me.sbar_H = New System.Windows.Forms.HScrollBar
    Me.btnClose = New System.Windows.Forms.Button
    Me.btnOk = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    CType(Me.pic_v, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pic_s, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pic_h, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.pic_v)
    Me.GroupBox1.Controls.Add(Me.pic_s)
    Me.GroupBox1.Controls.Add(Me.pic_h)
    Me.GroupBox1.Controls.Add(Me.lblColor)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.lblRgbValue)
    Me.GroupBox1.Controls.Add(Me.lbl_V)
    Me.GroupBox1.Controls.Add(Me.lbl_S)
    Me.GroupBox1.Controls.Add(Me.lbl_H)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.sbar_V)
    Me.GroupBox1.Controls.Add(Me.sbar_S)
    Me.GroupBox1.Controls.Add(Me.sbar_H)
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'pic_v
    '
    resources.ApplyResources(Me.pic_v, "pic_v")
    Me.pic_v.Name = "pic_v"
    Me.pic_v.TabStop = False
    '
    'pic_s
    '
    resources.ApplyResources(Me.pic_s, "pic_s")
    Me.pic_s.Name = "pic_s"
    Me.pic_s.TabStop = False
    '
    'pic_h
    '
    resources.ApplyResources(Me.pic_h, "pic_h")
    Me.pic_h.Name = "pic_h"
    Me.pic_h.TabStop = False
    '
    'lblColor
    '
    Me.lblColor.BackColor = System.Drawing.Color.White
    Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    resources.ApplyResources(Me.lblColor, "lblColor")
    Me.lblColor.Name = "lblColor"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'lblRgbValue
    '
    resources.ApplyResources(Me.lblRgbValue, "lblRgbValue")
    Me.lblRgbValue.Name = "lblRgbValue"
    '
    'lbl_V
    '
    resources.ApplyResources(Me.lbl_V, "lbl_V")
    Me.lbl_V.Name = "lbl_V"
    '
    'lbl_S
    '
    resources.ApplyResources(Me.lbl_S, "lbl_S")
    Me.lbl_S.Name = "lbl_S"
    '
    'lbl_H
    '
    resources.ApplyResources(Me.lbl_H, "lbl_H")
    Me.lbl_H.Name = "lbl_H"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'sbar_V
    '
    resources.ApplyResources(Me.sbar_V, "sbar_V")
    Me.sbar_V.Maximum = 264
    Me.sbar_V.Name = "sbar_V"
    Me.sbar_V.Value = 1
    '
    'sbar_S
    '
    resources.ApplyResources(Me.sbar_S, "sbar_S")
    Me.sbar_S.Maximum = 264
    Me.sbar_S.Name = "sbar_S"
    Me.sbar_S.Value = 1
    '
    'sbar_H
    '
    resources.ApplyResources(Me.sbar_H, "sbar_H")
    Me.sbar_H.Maximum = 264
    Me.sbar_H.Name = "sbar_H"
    Me.sbar_H.Value = 1
    '
    'btnClose
    '
    resources.ApplyResources(Me.btnClose, "btnClose")
    Me.btnClose.Name = "btnClose"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'btnOk
    '
    resources.ApplyResources(Me.btnOk, "btnOk")
    Me.btnOk.Name = "btnOk"
    Me.btnOk.UseVisualStyleBackColor = True
    '
    'frm_HsvColorpicker
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ControlBox = False
    Me.Controls.Add(Me.btnOk)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frm_HsvColorpicker"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.pic_v, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pic_s, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pic_h, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents lblColor As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lbl_V As System.Windows.Forms.Label
  Friend WithEvents lbl_S As System.Windows.Forms.Label
  Friend WithEvents lbl_H As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents sbar_V As System.Windows.Forms.HScrollBar
  Friend WithEvents sbar_S As System.Windows.Forms.HScrollBar
  Friend WithEvents sbar_H As System.Windows.Forms.HScrollBar
  Friend WithEvents pic_h As System.Windows.Forms.PictureBox
  Friend WithEvents pic_s As System.Windows.Forms.PictureBox
  Friend WithEvents pic_v As System.Windows.Forms.PictureBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblRgbValue As System.Windows.Forms.Label
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
