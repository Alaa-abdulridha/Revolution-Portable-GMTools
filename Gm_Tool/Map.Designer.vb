<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Map
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Map))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlbody2 = New System.Windows.Forms.Panel()
        Me.DGV1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGameMap = New Guna.UI.WinForms.GunaButton()
        Me.btnSommon = New Guna.UI.WinForms.GunaButton()
        Me.btnWarp = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtY = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtmob = New Guna.UI.WinForms.GunaTextBox()
        Me.comboChars = New Guna.UI.WinForms.GunaComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnMob = New Guna.UI.WinForms.GunaButton()
        Me.lb_playerName = New System.Windows.Forms.Label()
        Me.txtX = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lbmaptitle = New System.Windows.Forms.Label()
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
        Me.pnlBody.Size = New System.Drawing.Size(349, 612)
        Me.pnlBody.TabIndex = 4
        '
        'pnlbody2
        '
        Me.pnlbody2.Controls.Add(Me.DGV1)
        Me.pnlbody2.Controls.Add(Me.Panel1)
        Me.pnlbody2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbody2.Location = New System.Drawing.Point(0, 31)
        Me.pnlbody2.Name = "pnlbody2"
        Me.pnlbody2.Size = New System.Drawing.Size(349, 581)
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
        Me.DGV1.Size = New System.Drawing.Size(339, 386)
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
        Me.Panel1.Controls.Add(Me.btnGameMap)
        Me.Panel1.Controls.Add(Me.btnSommon)
        Me.Panel1.Controls.Add(Me.btnWarp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtY)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.comboChars)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.btnMob)
        Me.Panel1.Controls.Add(Me.lb_playerName)
        Me.Panel1.Controls.Add(Me.txtX)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 195)
        Me.Panel1.TabIndex = 27
        '
        'btnGameMap
        '
        Me.btnGameMap.AnimationHoverSpeed = 0.07!
        Me.btnGameMap.AnimationSpeed = 0.03!
        Me.btnGameMap.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnGameMap.BorderColor = System.Drawing.Color.Black
        Me.btnGameMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGameMap.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGameMap.FocusedColor = System.Drawing.Color.Empty
        Me.btnGameMap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGameMap.ForeColor = System.Drawing.Color.White
        Me.btnGameMap.Image = Nothing
        Me.btnGameMap.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGameMap.Location = New System.Drawing.Point(224, 118)
        Me.btnGameMap.Name = "btnGameMap"
        Me.btnGameMap.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnGameMap.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGameMap.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGameMap.OnHoverImage = Nothing
        Me.btnGameMap.OnPressedColor = System.Drawing.Color.Black
        Me.btnGameMap.Size = New System.Drawing.Size(86, 59)
        Me.btnGameMap.TabIndex = 40
        Me.btnGameMap.Text = "فتح الخارطة"
        Me.btnGameMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSommon
        '
        Me.btnSommon.AnimationHoverSpeed = 0.07!
        Me.btnSommon.AnimationSpeed = 0.03!
        Me.btnSommon.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnSommon.BorderColor = System.Drawing.Color.Black
        Me.btnSommon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSommon.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSommon.FocusedColor = System.Drawing.Color.Empty
        Me.btnSommon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSommon.ForeColor = System.Drawing.Color.White
        Me.btnSommon.Image = Nothing
        Me.btnSommon.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSommon.Location = New System.Drawing.Point(35, 151)
        Me.btnSommon.Name = "btnSommon"
        Me.btnSommon.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnSommon.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSommon.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSommon.OnHoverImage = Nothing
        Me.btnSommon.OnPressedColor = System.Drawing.Color.Black
        Me.btnSommon.Size = New System.Drawing.Size(162, 26)
        Me.btnSommon.TabIndex = 39
        Me.btnSommon.Text = "سحب شخصية"
        Me.btnSommon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnWarp
        '
        Me.btnWarp.AnimationHoverSpeed = 0.07!
        Me.btnWarp.AnimationSpeed = 0.03!
        Me.btnWarp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnWarp.BorderColor = System.Drawing.Color.Black
        Me.btnWarp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWarp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnWarp.FocusedColor = System.Drawing.Color.Empty
        Me.btnWarp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnWarp.ForeColor = System.Drawing.Color.White
        Me.btnWarp.Image = Nothing
        Me.btnWarp.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnWarp.Location = New System.Drawing.Point(35, 118)
        Me.btnWarp.Name = "btnWarp"
        Me.btnWarp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnWarp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnWarp.OnHoverForeColor = System.Drawing.Color.White
        Me.btnWarp.OnHoverImage = Nothing
        Me.btnWarp.OnPressedColor = System.Drawing.Color.Black
        Me.btnWarp.Size = New System.Drawing.Size(162, 26)
        Me.btnWarp.TabIndex = 38
        Me.btnWarp.Text = "الانتقال الى شخصية"
        Me.btnWarp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(17, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "X:"
        '
        'txtY
        '
        Me.txtY.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtY.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtY.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtY.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtY.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtY.FocusedForeColor = System.Drawing.Color.White
        Me.txtY.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtY.ForeColor = System.Drawing.Color.White
        Me.txtY.Location = New System.Drawing.Point(152, 78)
        Me.txtY.Name = "txtY"
        Me.txtY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtY.Size = New System.Drawing.Size(66, 26)
        Me.txtY.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtmob)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 2, 4, 2)
        Me.Panel2.Size = New System.Drawing.Size(349, 36)
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
        Me.txtmob.Location = New System.Drawing.Point(35, 2)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmob.Size = New System.Drawing.Size(310, 32)
        Me.txtmob.TabIndex = 28
        '
        'comboChars
        '
        Me.comboChars.BackColor = System.Drawing.Color.Transparent
        Me.comboChars.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboChars.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboChars.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboChars.FocusedColor = System.Drawing.Color.Empty
        Me.comboChars.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboChars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboChars.FormattingEnabled = True
        Me.comboChars.Location = New System.Drawing.Point(35, 42)
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
        Me.PictureBox4.Location = New System.Drawing.Point(224, 42)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'btnMob
        '
        Me.btnMob.AnimationHoverSpeed = 0.07!
        Me.btnMob.AnimationSpeed = 0.03!
        Me.btnMob.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnMob.BorderColor = System.Drawing.Color.Black
        Me.btnMob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMob.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMob.FocusedColor = System.Drawing.Color.Empty
        Me.btnMob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMob.ForeColor = System.Drawing.Color.White
        Me.btnMob.Image = Nothing
        Me.btnMob.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMob.Location = New System.Drawing.Point(224, 78)
        Me.btnMob.Name = "btnMob"
        Me.btnMob.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMob.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMob.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMob.OnHoverImage = Nothing
        Me.btnMob.OnPressedColor = System.Drawing.Color.Black
        Me.btnMob.Size = New System.Drawing.Size(86, 26)
        Me.btnMob.TabIndex = 26
        Me.btnMob.Text = "الانتقال"
        Me.btnMob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_playerName
        '
        Me.lb_playerName.AutoSize = True
        Me.lb_playerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_playerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lb_playerName.Location = New System.Drawing.Point(129, 84)
        Me.lb_playerName.Name = "lb_playerName"
        Me.lb_playerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lb_playerName.Size = New System.Drawing.Size(17, 15)
        Me.lb_playerName.TabIndex = 13
        Me.lb_playerName.Text = "Y:"
        '
        'txtX
        '
        Me.txtX.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtX.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtX.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtX.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtX.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtX.FocusedForeColor = System.Drawing.Color.White
        Me.txtX.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtX.ForeColor = System.Drawing.Color.White
        Me.txtX.Location = New System.Drawing.Point(35, 78)
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
        Me.pnlTitle.Controls.Add(Me.lbmaptitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox3)
        Me.pnlTitle.Controls.Add(Me.btnClose)
        Me.pnlTitle.Controls.Add(Me.btnMini)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(349, 31)
        Me.pnlTitle.TabIndex = 0
        '
        'lbmaptitle
        '
        Me.lbmaptitle.AutoSize = True
        Me.lbmaptitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmaptitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbmaptitle.Location = New System.Drawing.Point(34, 9)
        Me.lbmaptitle.Name = "lbmaptitle"
        Me.lbmaptitle.Size = New System.Drawing.Size(42, 13)
        Me.lbmaptitle.TabIndex = 27
        Me.lbmaptitle.Text = "الخارطة"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gm_Tool.My.Resources.Resources.treasure_map_30px
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
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
        'Map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 614)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Map"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtY As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtmob As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents comboChars As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnMob As Guna.UI.WinForms.GunaButton
    Friend WithEvents lb_playerName As Label
    Friend WithEvents txtX As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lbmaptitle As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnGameMap As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSommon As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnWarp As Guna.UI.WinForms.GunaButton
End Class
