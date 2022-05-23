<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateResource
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StateResource))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlbody2 = New System.Windows.Forms.Panel()
        Me.DGV1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbBuff = New System.Windows.Forms.Label()
        Me.txtBuffTime = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBuffSearch = New Guna.UI.WinForms.GunaTextBox()
        Me.lbBuffTime = New System.Windows.Forms.Label()
        Me.lbBuffType = New System.Windows.Forms.Label()
        Me.comboBufftype = New Guna.UI.WinForms.GunaComboBox()
        Me.comboChars = New Guna.UI.WinForms.GunaComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbBufflvl = New System.Windows.Forms.Label()
        Me.comboBuffTime = New Guna.UI.WinForms.GunaComboBox()
        Me.txtBuffLv = New Guna.UI.WinForms.GunaTextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lbbufftitle = New System.Windows.Forms.Label()
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
        Me.pnlBody.Size = New System.Drawing.Size(479, 633)
        Me.pnlBody.TabIndex = 2
        '
        'pnlbody2
        '
        Me.pnlbody2.Controls.Add(Me.DGV1)
        Me.pnlbody2.Controls.Add(Me.Panel1)
        Me.pnlbody2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbody2.Location = New System.Drawing.Point(0, 31)
        Me.pnlbody2.Name = "pnlbody2"
        Me.pnlbody2.Size = New System.Drawing.Size(479, 602)
        Me.pnlbody2.TabIndex = 1
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV1.ColumnHeadersHeight = 32
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGV1.EnableHeadersVisualStyles = False
        Me.DGV1.GridColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.RowTemplate.Height = 35
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(466, 376)
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
        Me.Panel1.Controls.Add(Me.lbBuff)
        Me.Panel1.Controls.Add(Me.txtBuffTime)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbBuffTime)
        Me.Panel1.Controls.Add(Me.lbBuffType)
        Me.Panel1.Controls.Add(Me.comboBufftype)
        Me.Panel1.Controls.Add(Me.comboChars)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.lbBufflvl)
        Me.Panel1.Controls.Add(Me.comboBuffTime)
        Me.Panel1.Controls.Add(Me.txtBuffLv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 226)
        Me.Panel1.TabIndex = 27
        '
        'lbBuff
        '
        Me.lbBuff.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbBuff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbBuff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbBuff.ForeColor = System.Drawing.Color.White
        Me.lbBuff.Location = New System.Drawing.Point(40, 184)
        Me.lbBuff.Name = "lbBuff"
        Me.lbBuff.Size = New System.Drawing.Size(230, 26)
        Me.lbBuff.TabIndex = 63
        Me.lbBuff.Tag = "130004"
        Me.lbBuff.Text = "اضافة البف"
        Me.lbBuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuffTime
        '
        Me.txtBuffTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtBuffTime.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuffTime.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffTime.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffTime.FocusedForeColor = System.Drawing.Color.White
        Me.txtBuffTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuffTime.ForeColor = System.Drawing.Color.White
        Me.txtBuffTime.Location = New System.Drawing.Point(40, 117)
        Me.txtBuffTime.Name = "txtBuffTime"
        Me.txtBuffTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuffTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBuffTime.Size = New System.Drawing.Size(113, 26)
        Me.txtBuffTime.TabIndex = 35
        Me.txtBuffTime.Text = "100"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtBuffSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 2, 4, 2)
        Me.Panel2.Size = New System.Drawing.Size(479, 36)
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
        'txtBuffSearch
        '
        Me.txtBuffSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtBuffSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuffSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtBuffSearch.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffSearch.FocusedForeColor = System.Drawing.Color.White
        Me.txtBuffSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuffSearch.ForeColor = System.Drawing.Color.White
        Me.txtBuffSearch.Location = New System.Drawing.Point(40, 2)
        Me.txtBuffSearch.Name = "txtBuffSearch"
        Me.txtBuffSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuffSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBuffSearch.Size = New System.Drawing.Size(435, 32)
        Me.txtBuffSearch.TabIndex = 28
        '
        'lbBuffTime
        '
        Me.lbBuffTime.AutoSize = True
        Me.lbBuffTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuffTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbBuffTime.Location = New System.Drawing.Point(275, 123)
        Me.lbBuffTime.Name = "lbBuffTime"
        Me.lbBuffTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbBuffTime.Size = New System.Drawing.Size(59, 15)
        Me.lbBuffTime.TabIndex = 33
        Me.lbBuffTime.Tag = "130002"
        Me.lbBuffTime.Text = "وقت البف:"
        '
        'lbBuffType
        '
        Me.lbBuffType.AutoSize = True
        Me.lbBuffType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuffType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbBuffType.Location = New System.Drawing.Point(275, 57)
        Me.lbBuffType.Name = "lbBuffType"
        Me.lbBuffType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbBuffType.Size = New System.Drawing.Size(53, 15)
        Me.lbBuffType.TabIndex = 32
        Me.lbBuffType.Tag = "130001"
        Me.lbBuffType.Text = "نوع البف:"
        '
        'comboBufftype
        '
        Me.comboBufftype.BackColor = System.Drawing.Color.Transparent
        Me.comboBufftype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboBufftype.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboBufftype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboBufftype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBufftype.FocusedColor = System.Drawing.Color.Empty
        Me.comboBufftype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboBufftype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboBufftype.FormattingEnabled = True
        Me.comboBufftype.Items.AddRange(New Object() {"اضافة بف للشخصية", "حذف بف للشخصية", "اضافة بف احتفالية", "حذف بف احتفالية", "اضافة بف احتفالية مؤقت", "اضافة بف للمرافق", "حذف بف للمرافق"})
        Me.comboBufftype.Location = New System.Drawing.Point(40, 52)
        Me.comboBufftype.Name = "comboBufftype"
        Me.comboBufftype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboBufftype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboBufftype.Size = New System.Drawing.Size(230, 26)
        Me.comboBufftype.TabIndex = 31
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
        Me.comboChars.Location = New System.Drawing.Point(40, 84)
        Me.comboChars.Name = "comboChars"
        Me.comboChars.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboChars.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboChars.Size = New System.Drawing.Size(230, 26)
        Me.comboChars.TabIndex = 30
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(276, 86)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'lbBufflvl
        '
        Me.lbBufflvl.AutoSize = True
        Me.lbBufflvl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBufflvl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbBufflvl.Location = New System.Drawing.Point(275, 158)
        Me.lbBufflvl.Name = "lbBufflvl"
        Me.lbBufflvl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbBufflvl.Size = New System.Drawing.Size(54, 15)
        Me.lbBufflvl.TabIndex = 13
        Me.lbBufflvl.Tag = "130003"
        Me.lbBufflvl.Text = "قوة البف:"
        '
        'comboBuffTime
        '
        Me.comboBuffTime.BackColor = System.Drawing.Color.Transparent
        Me.comboBuffTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboBuffTime.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comboBuffTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboBuffTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBuffTime.FocusedColor = System.Drawing.Color.Empty
        Me.comboBuffTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboBuffTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboBuffTime.FormattingEnabled = True
        Me.comboBuffTime.Items.AddRange(New Object() {"ثواني", "دقائق", "ساعات", "ايام"})
        Me.comboBuffTime.Location = New System.Drawing.Point(157, 117)
        Me.comboBuffTime.Name = "comboBuffTime"
        Me.comboBuffTime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboBuffTime.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboBuffTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.comboBuffTime.Size = New System.Drawing.Size(113, 26)
        Me.comboBuffTime.TabIndex = 25
        '
        'txtBuffLv
        '
        Me.txtBuffLv.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffLv.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtBuffLv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffLv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuffLv.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBuffLv.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtBuffLv.FocusedForeColor = System.Drawing.Color.White
        Me.txtBuffLv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuffLv.ForeColor = System.Drawing.Color.White
        Me.txtBuffLv.Location = New System.Drawing.Point(40, 152)
        Me.txtBuffLv.Name = "txtBuffLv"
        Me.txtBuffLv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuffLv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBuffLv.Size = New System.Drawing.Size(230, 26)
        Me.txtBuffLv.TabIndex = 10
        Me.txtBuffLv.Text = "10"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTitle.Controls.Add(Me.lbbufftitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox3)
        Me.pnlTitle.Controls.Add(Me.btnClose)
        Me.pnlTitle.Controls.Add(Me.btnMini)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(479, 31)
        Me.pnlTitle.TabIndex = 0
        '
        'lbbufftitle
        '
        Me.lbbufftitle.AutoSize = True
        Me.lbbufftitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lbbufftitle.Location = New System.Drawing.Point(34, 9)
        Me.lbbufftitle.Name = "lbbufftitle"
        Me.lbbufftitle.Size = New System.Drawing.Size(26, 13)
        Me.lbbufftitle.TabIndex = 27
        Me.lbbufftitle.Text = "Buff"
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
        Me.btnClose.Location = New System.Drawing.Point(450, 6)
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
        Me.btnMini.Location = New System.Drawing.Point(423, 6)
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
        'StateResource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 635)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StateResource"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StateResource"
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
    Friend WithEvents comboBuffTime As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lbBufflvl As Label
    Friend WithEvents txtBuffLv As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMini As PictureBox
    Friend WithEvents lbbufftitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuffSearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents comboChars As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents comboBufftype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbBuffTime As Label
    Friend WithEvents lbBuffType As Label
    Friend WithEvents txtBuffTime As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lbBuff As Label
End Class
