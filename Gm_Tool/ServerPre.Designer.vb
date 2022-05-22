<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerPre
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerPre))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlbody2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewLang = New Guna.UI.WinForms.GunaTextBox()
        Me.addlang = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLang = New Guna.UI.WinForms.GunaButton()
        Me.ComboLang = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPre = New Guna.UI.WinForms.GunaButton()
        Me.comboPre = New Guna.UI.WinForms.GunaComboBox()
        Me.lbrate = New System.Windows.Forms.Label()
        Me.txtpre = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMini = New System.Windows.Forms.PictureBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnlBody.SuspendLayout()
        Me.pnlbody2.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.pnlbody2)
        Me.pnlBody.Controls.Add(Me.pnlTitle)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(1, 1)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(301, 349)
        Me.pnlBody.TabIndex = 1
        '
        'pnlbody2
        '
        Me.pnlbody2.Controls.Add(Me.Label3)
        Me.pnlbody2.Controls.Add(Me.txtNewLang)
        Me.pnlbody2.Controls.Add(Me.addlang)
        Me.pnlbody2.Controls.Add(Me.Label2)
        Me.pnlbody2.Controls.Add(Me.btnLang)
        Me.pnlbody2.Controls.Add(Me.ComboLang)
        Me.pnlbody2.Controls.Add(Me.Label1)
        Me.pnlbody2.Controls.Add(Me.btnPre)
        Me.pnlbody2.Controls.Add(Me.comboPre)
        Me.pnlbody2.Controls.Add(Me.lbrate)
        Me.pnlbody2.Controls.Add(Me.txtpre)
        Me.pnlbody2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbody2.Location = New System.Drawing.Point(0, 31)
        Me.pnlbody2.Name = "pnlbody2"
        Me.pnlbody2.Size = New System.Drawing.Size(301, 318)
        Me.pnlbody2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(234, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "* Use Ar or En ... etc For Program Language"
        '
        'txtNewLang
        '
        Me.txtNewLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtNewLang.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtNewLang.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNewLang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewLang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Gm_Tool.My.MySettings.Default, "LangSetting", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNewLang.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtNewLang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNewLang.FocusedForeColor = System.Drawing.Color.White
        Me.txtNewLang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewLang.ForeColor = System.Drawing.Color.White
        Me.txtNewLang.Location = New System.Drawing.Point(150, 217)
        Me.txtNewLang.Name = "txtNewLang"
        Me.txtNewLang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewLang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNewLang.Size = New System.Drawing.Size(141, 26)
        Me.txtNewLang.TabIndex = 33
        Me.txtNewLang.Text = Global.Gm_Tool.My.MySettings.Default.LangSetting
        '
        'addlang
        '
        Me.addlang.AnimationHoverSpeed = 0.07!
        Me.addlang.AnimationSpeed = 0.03!
        Me.addlang.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.addlang.BorderColor = System.Drawing.Color.Black
        Me.addlang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addlang.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addlang.FocusedColor = System.Drawing.Color.Empty
        Me.addlang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addlang.ForeColor = System.Drawing.Color.White
        Me.addlang.Image = Nothing
        Me.addlang.ImageSize = New System.Drawing.Size(20, 20)
        Me.addlang.Location = New System.Drawing.Point(150, 249)
        Me.addlang.Name = "addlang"
        Me.addlang.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.addlang.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addlang.OnHoverForeColor = System.Drawing.Color.White
        Me.addlang.OnHoverImage = Nothing
        Me.addlang.OnPressedColor = System.Drawing.Color.Black
        Me.addlang.Size = New System.Drawing.Size(141, 26)
        Me.addlang.TabIndex = 32
        Me.addlang.Text = "Save Language"
        Me.addlang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Program Language"
        '
        'btnLang
        '
        Me.btnLang.AnimationHoverSpeed = 0.07!
        Me.btnLang.AnimationSpeed = 0.03!
        Me.btnLang.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnLang.BorderColor = System.Drawing.Color.Black
        Me.btnLang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLang.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLang.FocusedColor = System.Drawing.Color.Empty
        Me.btnLang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLang.ForeColor = System.Drawing.Color.White
        Me.btnLang.Image = Nothing
        Me.btnLang.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLang.Location = New System.Drawing.Point(150, 159)
        Me.btnLang.Name = "btnLang"
        Me.btnLang.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnLang.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLang.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLang.OnHoverImage = Nothing
        Me.btnLang.OnPressedColor = System.Drawing.Color.Black
        Me.btnLang.Size = New System.Drawing.Size(141, 26)
        Me.btnLang.TabIndex = 29
        Me.btnLang.Text = "Save"
        Me.btnLang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboLang
        '
        Me.ComboLang.BackColor = System.Drawing.Color.Transparent
        Me.ComboLang.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ComboLang.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ComboLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboLang.FocusedColor = System.Drawing.Color.Empty
        Me.ComboLang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ComboLang.FormattingEnabled = True
        Me.ComboLang.Items.AddRange(New Object() {"Arabic", "English"})
        Me.ComboLang.Location = New System.Drawing.Point(150, 127)
        Me.ComboLang.Name = "ComboLang"
        Me.ComboLang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ComboLang.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ComboLang.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboLang.Size = New System.Drawing.Size(141, 26)
        Me.ComboLang.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Item Language"
        '
        'btnPre
        '
        Me.btnPre.AnimationHoverSpeed = 0.07!
        Me.btnPre.AnimationSpeed = 0.03!
        Me.btnPre.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnPre.BorderColor = System.Drawing.Color.Black
        Me.btnPre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPre.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPre.FocusedColor = System.Drawing.Color.Empty
        Me.btnPre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPre.ForeColor = System.Drawing.Color.White
        Me.btnPre.Image = Nothing
        Me.btnPre.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPre.Location = New System.Drawing.Point(150, 80)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnPre.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPre.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPre.OnHoverImage = Nothing
        Me.btnPre.OnPressedColor = System.Drawing.Color.Black
        Me.btnPre.Size = New System.Drawing.Size(141, 26)
        Me.btnPre.TabIndex = 26
        Me.btnPre.Text = "تعديل"
        Me.btnPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comboPre
        '
        Me.comboPre.BackColor = System.Drawing.Color.Transparent
        Me.comboPre.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboPre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboPre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboPre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPre.FocusedColor = System.Drawing.Color.Empty
        Me.comboPre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboPre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboPre.FormattingEnabled = True
        Me.comboPre.Items.AddRange(New Object() {"الذهب", "الخبرة", "نسبة سقوط الادوات"})
        Me.comboPre.Location = New System.Drawing.Point(150, 16)
        Me.comboPre.Name = "comboPre"
        Me.comboPre.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboPre.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboPre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.comboPre.Size = New System.Drawing.Size(141, 26)
        Me.comboPre.TabIndex = 25
        '
        'lbrate
        '
        Me.lbrate.AutoSize = True
        Me.lbrate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbrate.Location = New System.Drawing.Point(28, 21)
        Me.lbrate.Name = "lbrate"
        Me.lbrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbrate.Size = New System.Drawing.Size(113, 15)
        Me.lbrate.TabIndex = 13
        Me.lbrate.Tag = "150001"
        Me.lbrate.Text = "الخاصية المراد تعديلها"
        '
        'txtpre
        '
        Me.txtpre.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtpre.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtpre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtpre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpre.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtpre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtpre.FocusedForeColor = System.Drawing.Color.White
        Me.txtpre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpre.ForeColor = System.Drawing.Color.White
        Me.txtpre.Location = New System.Drawing.Point(150, 48)
        Me.txtpre.Name = "txtpre"
        Me.txtpre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpre.Size = New System.Drawing.Size(141, 26)
        Me.txtpre.TabIndex = 10
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTitle.Controls.Add(Me.PictureBox3)
        Me.pnlTitle.Controls.Add(Me.btnClose)
        Me.pnlTitle.Controls.Add(Me.btnMini)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(301, 31)
        Me.pnlTitle.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gm_Tool.My.Resources.Resources.common_mark_titanium_special
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(275, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'btnMini
        '
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.Location = New System.Drawing.Point(248, 7)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(16, 16)
        Me.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMini.TabIndex = 5
        Me.btnMini.TabStop = False
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.pnlTitle
        '
        'ServerPre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(303, 351)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServerPre"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServerPre"
        Me.pnlBody.ResumeLayout(False)
        Me.pnlbody2.ResumeLayout(False)
        Me.pnlbody2.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlbody2 As Panel
    Friend WithEvents btnPre As Guna.UI.WinForms.GunaButton
    Friend WithEvents comboPre As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lbrate As Label
    Friend WithEvents txtpre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnLang As Guna.UI.WinForms.GunaButton
    Friend WithEvents ComboLang As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewLang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents addlang As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
