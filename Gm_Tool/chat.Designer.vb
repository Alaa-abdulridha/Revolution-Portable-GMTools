<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chat))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlcontent = New System.Windows.Forms.Panel()
        Me.LbNote = New System.Windows.Forms.Label()
        Me.lbAd = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.lbKick = New System.Windows.Forms.Label()
        Me.lbMute = New System.Windows.Forms.Label()
        Me.lbHideplayer = New System.Windows.Forms.Label()
        Me.btnShowplayer = New System.Windows.Forms.PictureBox()
        Me.btnHideplayer = New System.Windows.Forms.PictureBox()
        Me.lbShowplayer = New System.Windows.Forms.Label()
        Me.btnPicKill = New System.Windows.Forms.PictureBox()
        Me.comboplayercount = New Guna.UI.WinForms.GunaComboBox()
        Me.ComboMute = New Guna.UI.WinForms.GunaComboBox()
        Me.txtTimemute = New Guna.UI.WinForms.GunaTextBox()
        Me.btnKilltarget = New System.Windows.Forms.Label()
        Me.txtnameMute = New Guna.UI.WinForms.GunaTextBox()
        Me.btnSend = New System.Windows.Forms.PictureBox()
        Me.chkNote = New System.Windows.Forms.CheckBox()
        Me.chkAd = New System.Windows.Forms.CheckBox()
        Me.lb_playerName = New System.Windows.Forms.Label()
        Me.txtAd = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.chklock = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.btnMini = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlBody.SuspendLayout()
        Me.pnlcontent.SuspendLayout()
        CType(Me.btnShowplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHideplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPicKill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.pnlcontent)
        Me.pnlBody.Controls.Add(Me.pnlTitle)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(1, 1)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(371, 230)
        Me.pnlBody.TabIndex = 0
        '
        'pnlcontent
        '
        Me.pnlcontent.Controls.Add(Me.LbNote)
        Me.pnlcontent.Controls.Add(Me.lbAd)
        Me.pnlcontent.Controls.Add(Me.lbCount)
        Me.pnlcontent.Controls.Add(Me.lbKick)
        Me.pnlcontent.Controls.Add(Me.lbMute)
        Me.pnlcontent.Controls.Add(Me.lbHideplayer)
        Me.pnlcontent.Controls.Add(Me.btnShowplayer)
        Me.pnlcontent.Controls.Add(Me.btnHideplayer)
        Me.pnlcontent.Controls.Add(Me.lbShowplayer)
        Me.pnlcontent.Controls.Add(Me.btnPicKill)
        Me.pnlcontent.Controls.Add(Me.comboplayercount)
        Me.pnlcontent.Controls.Add(Me.ComboMute)
        Me.pnlcontent.Controls.Add(Me.txtTimemute)
        Me.pnlcontent.Controls.Add(Me.btnKilltarget)
        Me.pnlcontent.Controls.Add(Me.txtnameMute)
        Me.pnlcontent.Controls.Add(Me.btnSend)
        Me.pnlcontent.Controls.Add(Me.chkNote)
        Me.pnlcontent.Controls.Add(Me.chkAd)
        Me.pnlcontent.Controls.Add(Me.lb_playerName)
        Me.pnlcontent.Controls.Add(Me.txtAd)
        Me.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlcontent.Location = New System.Drawing.Point(0, 31)
        Me.pnlcontent.Name = "pnlcontent"
        Me.pnlcontent.Size = New System.Drawing.Size(371, 199)
        Me.pnlcontent.TabIndex = 1
        '
        'LbNote
        '
        Me.LbNote.AutoSize = True
        Me.LbNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LbNote.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbNote.Location = New System.Drawing.Point(255, 74)
        Me.LbNote.Name = "LbNote"
        Me.LbNote.Size = New System.Drawing.Size(83, 17)
        Me.LbNote.TabIndex = 64
        Me.LbNote.Tag = "110006"
        Me.LbNote.Text = "ارسال ملاحظة"
        Me.ToolTip1.SetToolTip(Me.LbNote, "ارسال رسالة لجميع اللاعبين باللون الاصفر")
        '
        'lbAd
        '
        Me.lbAd.AutoSize = True
        Me.lbAd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbAd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.lbAd.Location = New System.Drawing.Point(255, 48)
        Me.lbAd.Name = "lbAd"
        Me.lbAd.Size = New System.Drawing.Size(69, 17)
        Me.lbAd.TabIndex = 63
        Me.lbAd.Tag = "110005"
        Me.lbAd.Text = "ارسال اعلان"
        Me.ToolTip1.SetToolTip(Me.lbAd, "ارسال رسالة لجميع اللاعبين باللون الاخضر")
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbCount.ForeColor = System.Drawing.Color.White
        Me.lbCount.Location = New System.Drawing.Point(9, 160)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(95, 26)
        Me.lbCount.TabIndex = 62
        Me.lbCount.Tag = "110004"
        Me.lbCount.Text = "عدد اللاعبين"
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbCount, "اظهار اعلان باعداد الاشخاص المتواجدين في اللعبة")
        '
        'lbKick
        '
        Me.lbKick.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbKick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbKick.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbKick.ForeColor = System.Drawing.Color.White
        Me.lbKick.Location = New System.Drawing.Point(10, 92)
        Me.lbKick.Name = "lbKick"
        Me.lbKick.Size = New System.Drawing.Size(62, 26)
        Me.lbKick.TabIndex = 61
        Me.lbKick.Tag = "110003"
        Me.lbKick.Text = "طرد"
        Me.lbKick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbKick, "طرد اللاعب")
        '
        'lbMute
        '
        Me.lbMute.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMute.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbMute.ForeColor = System.Drawing.Color.White
        Me.lbMute.Location = New System.Drawing.Point(10, 60)
        Me.lbMute.Name = "lbMute"
        Me.lbMute.Size = New System.Drawing.Size(62, 26)
        Me.lbMute.TabIndex = 60
        Me.lbMute.Tag = "110002"
        Me.lbMute.Text = "كتم"
        Me.lbMute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbMute, "كتم اسم اللاعب")
        '
        'lbHideplayer
        '
        Me.lbHideplayer.AutoSize = True
        Me.lbHideplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbHideplayer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHideplayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbHideplayer.Location = New System.Drawing.Point(264, 164)
        Me.lbHideplayer.Name = "lbHideplayer"
        Me.lbHideplayer.Size = New System.Drawing.Size(88, 17)
        Me.lbHideplayer.TabIndex = 32
        Me.lbHideplayer.Tag = "110009"
        Me.lbHideplayer.Text = "اخفاء الشخصية"
        Me.ToolTip1.SetToolTip(Me.lbHideplayer, "اخفاء شخصية اللاعب في اللعبة")
        '
        'btnShowplayer
        '
        Me.btnShowplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowplayer.Image = Global.Gm_Tool.My.Resources.Resources.game_button_titanium_player_character_01
        Me.btnShowplayer.Location = New System.Drawing.Point(234, 133)
        Me.btnShowplayer.Name = "btnShowplayer"
        Me.btnShowplayer.Size = New System.Drawing.Size(22, 22)
        Me.btnShowplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnShowplayer.TabIndex = 31
        Me.btnShowplayer.TabStop = False
        '
        'btnHideplayer
        '
        Me.btnHideplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideplayer.Image = Global.Gm_Tool.My.Resources.Resources.game_button_titanium_player_character_04
        Me.btnHideplayer.Location = New System.Drawing.Point(234, 161)
        Me.btnHideplayer.Name = "btnHideplayer"
        Me.btnHideplayer.Size = New System.Drawing.Size(22, 22)
        Me.btnHideplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHideplayer.TabIndex = 30
        Me.btnHideplayer.TabStop = False
        '
        'lbShowplayer
        '
        Me.lbShowplayer.AutoSize = True
        Me.lbShowplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbShowplayer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowplayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbShowplayer.Location = New System.Drawing.Point(264, 136)
        Me.lbShowplayer.Name = "lbShowplayer"
        Me.lbShowplayer.Size = New System.Drawing.Size(91, 17)
        Me.lbShowplayer.TabIndex = 29
        Me.lbShowplayer.Tag = "110008"
        Me.lbShowplayer.Text = "اظهار الشخصية"
        Me.ToolTip1.SetToolTip(Me.lbShowplayer, "اظهار شخصية اللاعب في اللعبة")
        '
        'btnPicKill
        '
        Me.btnPicKill.Image = Global.Gm_Tool.My.Resources.Resources.common_mark_state_pk_normal
        Me.btnPicKill.Location = New System.Drawing.Point(234, 105)
        Me.btnPicKill.Name = "btnPicKill"
        Me.btnPicKill.Size = New System.Drawing.Size(22, 22)
        Me.btnPicKill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPicKill.TabIndex = 27
        Me.btnPicKill.TabStop = False
        '
        'comboplayercount
        '
        Me.comboplayercount.BackColor = System.Drawing.Color.Transparent
        Me.comboplayercount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboplayercount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboplayercount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboplayercount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboplayercount.FocusedColor = System.Drawing.Color.Empty
        Me.comboplayercount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboplayercount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboplayercount.FormattingEnabled = True
        Me.comboplayercount.Items.AddRange(New Object() {"اعلان", "ملاحظة", "رسالة شات", "ملاحظة خاصة"})
        Me.comboplayercount.Location = New System.Drawing.Point(110, 161)
        Me.comboplayercount.Name = "comboplayercount"
        Me.comboplayercount.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboplayercount.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboplayercount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.comboplayercount.Size = New System.Drawing.Size(89, 26)
        Me.comboplayercount.TabIndex = 25
        '
        'ComboMute
        '
        Me.ComboMute.BackColor = System.Drawing.Color.Transparent
        Me.ComboMute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ComboMute.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ComboMute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboMute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMute.FocusedColor = System.Drawing.Color.Empty
        Me.ComboMute.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboMute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ComboMute.FormattingEnabled = True
        Me.ComboMute.Items.AddRange(New Object() {"دقيقة", "ساعة", "يوم", "اسبوع"})
        Me.ComboMute.Location = New System.Drawing.Point(78, 92)
        Me.ComboMute.Name = "ComboMute"
        Me.ComboMute.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ComboMute.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ComboMute.Size = New System.Drawing.Size(71, 26)
        Me.ComboMute.TabIndex = 23
        '
        'txtTimemute
        '
        Me.txtTimemute.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtTimemute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtTimemute.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtTimemute.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimemute.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtTimemute.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtTimemute.FocusedForeColor = System.Drawing.Color.White
        Me.txtTimemute.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTimemute.ForeColor = System.Drawing.Color.White
        Me.txtTimemute.Location = New System.Drawing.Point(155, 92)
        Me.txtTimemute.Name = "txtTimemute"
        Me.txtTimemute.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimemute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimemute.Size = New System.Drawing.Size(44, 26)
        Me.txtTimemute.TabIndex = 22
        Me.txtTimemute.Text = "100"
        '
        'btnKilltarget
        '
        Me.btnKilltarget.AutoSize = True
        Me.btnKilltarget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKilltarget.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKilltarget.ForeColor = System.Drawing.Color.Red
        Me.btnKilltarget.Location = New System.Drawing.Point(264, 106)
        Me.btnKilltarget.Name = "btnKilltarget"
        Me.btnKilltarget.Size = New System.Drawing.Size(66, 17)
        Me.btnKilltarget.TabIndex = 21
        Me.btnKilltarget.Tag = "110007"
        Me.btnKilltarget.Text = "قتل الهدف"
        Me.ToolTip1.SetToolTip(Me.btnKilltarget, "قتل الهدف المحدد باللعبة")
        '
        'txtnameMute
        '
        Me.txtnameMute.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtnameMute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtnameMute.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtnameMute.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnameMute.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtnameMute.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtnameMute.FocusedForeColor = System.Drawing.Color.White
        Me.txtnameMute.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnameMute.ForeColor = System.Drawing.Color.White
        Me.txtnameMute.Location = New System.Drawing.Point(78, 60)
        Me.txtnameMute.Name = "txtnameMute"
        Me.txtnameMute.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnameMute.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnameMute.Size = New System.Drawing.Size(121, 26)
        Me.txtnameMute.TabIndex = 20
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Image = Global.Gm_Tool.My.Resources.Resources.paper_plane_30pxAd
        Me.btnSend.Location = New System.Drawing.Point(331, 17)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(24, 24)
        Me.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSend.TabIndex = 18
        Me.btnSend.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSend, "ارسال الاعلان او الملاحظة")
        '
        'chkNote
        '
        Me.chkNote.AutoSize = True
        Me.chkNote.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNote.Location = New System.Drawing.Point(234, 76)
        Me.chkNote.Name = "chkNote"
        Me.chkNote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNote.Size = New System.Drawing.Size(15, 14)
        Me.chkNote.TabIndex = 17
        Me.chkNote.Tag = ""
        Me.chkNote.UseVisualStyleBackColor = True
        '
        'chkAd
        '
        Me.chkAd.AutoSize = True
        Me.chkAd.Checked = True
        Me.chkAd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.chkAd.Location = New System.Drawing.Point(234, 50)
        Me.chkAd.Name = "chkAd"
        Me.chkAd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAd.Size = New System.Drawing.Size(15, 14)
        Me.chkAd.TabIndex = 16
        Me.chkAd.Tag = ""
        Me.chkAd.UseVisualStyleBackColor = True
        '
        'lb_playerName
        '
        Me.lb_playerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_playerName.AutoSize = True
        Me.lb_playerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_playerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lb_playerName.Location = New System.Drawing.Point(22, 21)
        Me.lb_playerName.Name = "lb_playerName"
        Me.lb_playerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lb_playerName.Size = New System.Drawing.Size(34, 15)
        Me.lb_playerName.TabIndex = 13
        Me.lb_playerName.Tag = "110001"
        Me.lb_playerName.Text = "النص"
        Me.ToolTip1.SetToolTip(Me.lb_playerName, "اضغط على زر الانتر لنسخ النص وافراغ المحتويات")
        '
        'txtAd
        '
        Me.txtAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtAd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtAd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAd.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtAd.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtAd.FocusedForeColor = System.Drawing.Color.White
        Me.txtAd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAd.ForeColor = System.Drawing.Color.White
        Me.txtAd.Location = New System.Drawing.Point(65, 15)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAd.Size = New System.Drawing.Size(257, 26)
        Me.txtAd.TabIndex = 10
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTitle.Controls.Add(Me.PictureBox3)
        Me.pnlTitle.Controls.Add(Me.chklock)
        Me.pnlTitle.Controls.Add(Me.btnMini)
        Me.pnlTitle.Controls.Add(Me.btnClose)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(371, 31)
        Me.pnlTitle.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gm_Tool.My.Resources.Resources.common_mark_menu_chatting_whisper
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'chklock
        '
        Me.chklock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chklock.ImageCheckedOff = Global.Gm_Tool.My.Resources.Resources.common_button_titanium_lock_04
        Me.chklock.ImageCheckedOn = Global.Gm_Tool.My.Resources.Resources.common_button_titanium_lock_01
        Me.chklock.ImageSize = New System.Drawing.Size(20, 20)
        Me.chklock.Location = New System.Drawing.Point(297, 7)
        Me.chklock.Name = "chklock"
        Me.chklock.Size = New System.Drawing.Size(23, 16)
        Me.chklock.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.chklock, "قفل النافذة وابقائها فوق جميع البرامج")
        '
        'btnMini
        '
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.Location = New System.Drawing.Point(319, 7)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(23, 16)
        Me.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMini.TabIndex = 5
        Me.btnMini.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMini, "تصغير النافذة")
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(341, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "اغلاق النافذة")
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.pnlTitle
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 40
        '
        'chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 232)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "chat"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "chat"
        Me.pnlBody.ResumeLayout(False)
        Me.pnlcontent.ResumeLayout(False)
        Me.pnlcontent.PerformLayout()
        CType(Me.btnShowplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHideplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPicKill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlcontent As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents chklock As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtAd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents lb_playerName As Label
    Friend WithEvents btnSend As PictureBox
    Friend WithEvents chkNote As CheckBox
    Friend WithEvents chkAd As CheckBox
    Friend WithEvents txtTimemute As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnKilltarget As Label
    Friend WithEvents txtnameMute As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ComboMute As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents comboplayercount As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnPicKill As PictureBox
    Friend WithEvents lbShowplayer As Label
    Friend WithEvents lbHideplayer As Label
    Friend WithEvents btnShowplayer As PictureBox
    Friend WithEvents btnHideplayer As PictureBox
    Friend WithEvents lbCount As Label
    Friend WithEvents lbKick As Label
    Friend WithEvents lbMute As Label
    Friend WithEvents LbNote As Label
    Friend WithEvents lbAd As Label
End Class
