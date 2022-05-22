<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monsters
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monsters))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlbody2 = New System.Windows.Forms.Panel()
        Me.DGV1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbMobs = New System.Windows.Forms.Label()
        Me.txtY = New Guna.UI.WinForms.GunaTextBox()
        Me.txtMobNum = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtmob = New Guna.UI.WinForms.GunaTextBox()
        Me.mobQty = New System.Windows.Forms.Label()
        Me.lbmobto = New System.Windows.Forms.Label()
        Me.comboMonster = New Guna.UI.WinForms.GunaComboBox()
        Me.comboChars = New Guna.UI.WinForms.GunaComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtX = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lbMobTitle = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMini = New System.Windows.Forms.PictureBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnlBody.SuspendLayout()
        Me.pnlbody2.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlBody.Size = New System.Drawing.Size(352, 600)
        Me.pnlBody.TabIndex = 3
        '
        'pnlbody2
        '
        Me.pnlbody2.Controls.Add(Me.DGV1)
        Me.pnlbody2.Controls.Add(Me.Panel1)
        Me.pnlbody2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbody2.Location = New System.Drawing.Point(0, 31)
        Me.pnlbody2.Name = "pnlbody2"
        Me.pnlbody2.Size = New System.Drawing.Size(352, 569)
        Me.pnlbody2.TabIndex = 1
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV1.ColumnHeadersHeight = 32
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGV1.EnableHeadersVisualStyles = False
        Me.DGV1.GridColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.RowTemplate.Height = 35
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(328, 343)
        Me.DGV1.TabIndex = 28
        Me.DGV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV1.ThemeStyle.HeaderStyle.Height = 32
        Me.DGV1.ThemeStyle.ReadOnly = True
        Me.DGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGV1.ThemeStyle.RowsStyle.Height = 35
        Me.DGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.lbMobs)
        Me.Panel1.Controls.Add(Me.txtY)
        Me.Panel1.Controls.Add(Me.txtMobNum)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.mobQty)
        Me.Panel1.Controls.Add(Me.lbmobto)
        Me.Panel1.Controls.Add(Me.comboMonster)
        Me.Panel1.Controls.Add(Me.comboChars)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.txtX)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 226)
        Me.Panel1.TabIndex = 27
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(131, 153)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(17, 15)
        Me.GunaLabel2.TabIndex = 65
        Me.GunaLabel2.Text = "Y:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 153)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(17, 15)
        Me.GunaLabel1.TabIndex = 64
        Me.GunaLabel1.Text = "X:"
        '
        'lbMobs
        '
        Me.lbMobs.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMobs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMobs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbMobs.ForeColor = System.Drawing.Color.White
        Me.lbMobs.Location = New System.Drawing.Point(37, 185)
        Me.lbMobs.Name = "lbMobs"
        Me.lbMobs.Size = New System.Drawing.Size(183, 26)
        Me.lbMobs.TabIndex = 63
        Me.lbMobs.Tag = "120003"
        Me.lbMobs.Text = "اضافة الوحوش"
        Me.lbMobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtY
        '
        Me.txtY.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtY.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtY.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtY.Enabled = False
        Me.txtY.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtY.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtY.FocusedForeColor = System.Drawing.Color.White
        Me.txtY.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtY.ForeColor = System.Drawing.Color.White
        Me.txtY.Location = New System.Drawing.Point(154, 147)
        Me.txtY.Name = "txtY"
        Me.txtY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtY.Size = New System.Drawing.Size(66, 26)
        Me.txtY.TabIndex = 36
        '
        'txtMobNum
        '
        Me.txtMobNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtMobNum.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtMobNum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtMobNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMobNum.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtMobNum.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtMobNum.FocusedForeColor = System.Drawing.Color.White
        Me.txtMobNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMobNum.ForeColor = System.Drawing.Color.White
        Me.txtMobNum.Location = New System.Drawing.Point(37, 115)
        Me.txtMobNum.Name = "txtMobNum"
        Me.txtMobNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMobNum.Size = New System.Drawing.Size(183, 26)
        Me.txtMobNum.TabIndex = 35
        Me.txtMobNum.Text = "1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtmob)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 2, 4, 2)
        Me.Panel2.Size = New System.Drawing.Size(352, 36)
        Me.Panel2.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtmob
        '
        Me.txtmob.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtmob.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtmob.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtmob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmob.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtmob.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtmob.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtmob.FocusedForeColor = System.Drawing.Color.White
        Me.txtmob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmob.ForeColor = System.Drawing.Color.White
        Me.txtmob.Location = New System.Drawing.Point(38, 2)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmob.Size = New System.Drawing.Size(310, 32)
        Me.txtmob.TabIndex = 28
        '
        'mobQty
        '
        Me.mobQty.AutoSize = True
        Me.mobQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.mobQty.Location = New System.Drawing.Point(226, 121)
        Me.mobQty.Name = "mobQty"
        Me.mobQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mobQty.Size = New System.Drawing.Size(36, 15)
        Me.mobQty.TabIndex = 33
        Me.mobQty.Tag = "120002"
        Me.mobQty.Text = "العدد:"
        '
        'lbmobto
        '
        Me.lbmobto.AutoSize = True
        Me.lbmobto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmobto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbmobto.Location = New System.Drawing.Point(226, 55)
        Me.lbmobto.Name = "lbmobto"
        Me.lbmobto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbmobto.Size = New System.Drawing.Size(105, 15)
        Me.lbmobto.TabIndex = 32
        Me.lbmobto.Tag = "120001"
        Me.lbmobto.Text = "استدعاء الوحش الى:"
        '
        'comboMonster
        '
        Me.comboMonster.BackColor = System.Drawing.Color.Transparent
        Me.comboMonster.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboMonster.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboMonster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboMonster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMonster.FocusedColor = System.Drawing.Color.Empty
        Me.comboMonster.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboMonster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboMonster.FormattingEnabled = True
        Me.comboMonster.Items.AddRange(New Object() {"مكانك", "مكان شخصية", "مكان محدد"})
        Me.comboMonster.Location = New System.Drawing.Point(37, 50)
        Me.comboMonster.Name = "comboMonster"
        Me.comboMonster.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboMonster.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboMonster.Size = New System.Drawing.Size(183, 26)
        Me.comboMonster.TabIndex = 31
        '
        'comboChars
        '
        Me.comboChars.BackColor = System.Drawing.Color.Transparent
        Me.comboChars.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboChars.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboChars.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboChars.Enabled = False
        Me.comboChars.FocusedColor = System.Drawing.Color.Empty
        Me.comboChars.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboChars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboChars.FormattingEnabled = True
        Me.comboChars.Location = New System.Drawing.Point(37, 82)
        Me.comboChars.Name = "comboChars"
        Me.comboChars.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboChars.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboChars.Size = New System.Drawing.Size(183, 26)
        Me.comboChars.TabIndex = 30
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(226, 82)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'txtX
        '
        Me.txtX.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtX.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtX.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtX.Enabled = False
        Me.txtX.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtX.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtX.FocusedForeColor = System.Drawing.Color.White
        Me.txtX.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtX.ForeColor = System.Drawing.Color.White
        Me.txtX.Location = New System.Drawing.Point(37, 147)
        Me.txtX.Name = "txtX"
        Me.txtX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtX.Size = New System.Drawing.Size(66, 26)
        Me.txtX.TabIndex = 10
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTitle.Controls.Add(Me.lbMobTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox3)
        Me.pnlTitle.Controls.Add(Me.btnClose)
        Me.pnlTitle.Controls.Add(Me.btnMini)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(352, 31)
        Me.pnlTitle.TabIndex = 0
        '
        'lbMobTitle
        '
        Me.lbMobTitle.AutoSize = True
        Me.lbMobTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbMobTitle.Location = New System.Drawing.Point(34, 9)
        Me.lbMobTitle.Name = "lbMobTitle"
        Me.lbMobTitle.Size = New System.Drawing.Size(45, 13)
        Me.lbMobTitle.TabIndex = 27
        Me.lbMobTitle.Text = "الوحوش"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gm_Tool.My.Resources.Resources.common_mark_monster_type_use_15_devil
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(323, 7)
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
        Me.btnMini.Location = New System.Drawing.Point(296, 7)
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
        'Monsters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 602)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Monsters"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monsters"
        Me.pnlBody.ResumeLayout(False)
        Me.pnlbody2.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlbody2 As Panel
    Friend WithEvents DGV1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMobNum As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtmob As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents mobQty As Label
    Friend WithEvents lbmobto As Label
    Friend WithEvents comboMonster As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents comboChars As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtX As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lbMobTitle As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents txtY As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lbMobs As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
