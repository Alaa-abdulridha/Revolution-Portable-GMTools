<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvancedItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedItem))
        Me.DGV1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtclip = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.comboSearch = New Guna.UI.WinForms.GunaComboBox()
        Me.txtSearch = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbAdd = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtitemLv = New Guna.UI.WinForms.GunaTextBox()
        Me.txtitemEnh = New Guna.UI.WinForms.GunaTextBox()
        Me.txtitemqty = New Guna.UI.WinForms.GunaTextBox()
        Me.comGear = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comtype = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comRank = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comRace = New Guna.UI.WinForms.GunaComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.EnableHeadersVisualStyles = False
        Me.DGV1.GridColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.RowTemplate.Height = 35
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(405, 590)
        Me.DGV1.TabIndex = 1
        Me.DGV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
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
        Me.DGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtclip)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 590)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 88)
        Me.Panel1.TabIndex = 2
        '
        'txtclip
        '
        Me.txtclip.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtclip.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtclip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtclip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclip.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtclip.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtclip.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtclip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtclip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtclip.Location = New System.Drawing.Point(12, 50)
        Me.txtclip.Name = "txtclip"
        Me.txtclip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtclip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclip.Size = New System.Drawing.Size(510, 26)
        Me.txtclip.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.comboSearch)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(534, 41)
        Me.Panel3.TabIndex = 0
        '
        'comboSearch
        '
        Me.comboSearch.BackColor = System.Drawing.Color.Transparent
        Me.comboSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comboSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSearch.FocusedColor = System.Drawing.Color.Empty
        Me.comboSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comboSearch.FormattingEnabled = True
        Me.comboSearch.Items.AddRange(New Object() {"بالاسم", "بالكود"})
        Me.comboSearch.Location = New System.Drawing.Point(113, 9)
        Me.comboSearch.Name = "comboSearch"
        Me.comboSearch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboSearch.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboSearch.Size = New System.Drawing.Size(97, 26)
        Me.comboSearch.TabIndex = 59
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtSearch.FocusedForeColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(246, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(276, 26)
        Me.txtSearch.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(216, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbAdd)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtitemLv)
        Me.Panel2.Controls.Add(Me.txtitemEnh)
        Me.Panel2.Controls.Add(Me.txtitemqty)
        Me.Panel2.Controls.Add(Me.comGear)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.comtype)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.comRank)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.comRace)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(405, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 590)
        Me.Panel2.TabIndex = 3
        '
        'lbAdd
        '
        Me.lbAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbAdd.ForeColor = System.Drawing.Color.White
        Me.lbAdd.Location = New System.Drawing.Point(17, 526)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(100, 42)
        Me.lbAdd.TabIndex = 63
        Me.lbAdd.Tag = "140008"
        Me.lbAdd.Text = "عدد اللاعبين"
        Me.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(82, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Tag = "140006"
        Me.Label10.Text = "العدد:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(71, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Tag = "140007"
        Me.Label4.Text = "التطوير:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(83, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Tag = "140005"
        Me.Label7.Text = "اللفل:"
        '
        'txtitemLv
        '
        Me.txtitemLv.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemLv.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtitemLv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtitemLv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtitemLv.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemLv.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtitemLv.FocusedForeColor = System.Drawing.Color.White
        Me.txtitemLv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtitemLv.ForeColor = System.Drawing.Color.White
        Me.txtitemLv.Location = New System.Drawing.Point(17, 330)
        Me.txtitemLv.Name = "txtitemLv"
        Me.txtitemLv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitemLv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtitemLv.Size = New System.Drawing.Size(100, 26)
        Me.txtitemLv.TabIndex = 34
        Me.txtitemLv.Text = "1"
        '
        'txtitemEnh
        '
        Me.txtitemEnh.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemEnh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtitemEnh.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtitemEnh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtitemEnh.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemEnh.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtitemEnh.FocusedForeColor = System.Drawing.Color.White
        Me.txtitemEnh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtitemEnh.ForeColor = System.Drawing.Color.White
        Me.txtitemEnh.Location = New System.Drawing.Point(17, 469)
        Me.txtitemEnh.Name = "txtitemEnh"
        Me.txtitemEnh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitemEnh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtitemEnh.Size = New System.Drawing.Size(100, 26)
        Me.txtitemEnh.TabIndex = 33
        Me.txtitemEnh.Text = "0"
        '
        'txtitemqty
        '
        Me.txtitemqty.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemqty.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtitemqty.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtitemqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtitemqty.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtitemqty.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtitemqty.FocusedForeColor = System.Drawing.Color.White
        Me.txtitemqty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtitemqty.ForeColor = System.Drawing.Color.White
        Me.txtitemqty.Location = New System.Drawing.Point(17, 398)
        Me.txtitemqty.Name = "txtitemqty"
        Me.txtitemqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitemqty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtitemqty.Size = New System.Drawing.Size(100, 26)
        Me.txtitemqty.TabIndex = 32
        Me.txtitemqty.Text = "1"
        '
        'comGear
        '
        Me.comGear.BackColor = System.Drawing.Color.Transparent
        Me.comGear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comGear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comGear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comGear.FocusedColor = System.Drawing.Color.Empty
        Me.comGear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comGear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comGear.FormattingEnabled = True
        Me.comGear.Items.AddRange(New Object() {"كل", "سلاح", "ترس", "خوذة", "قفازات", "حذاء", "درع", "حزام", "عباءة", "قلادة", "خاتم", "اقراط", "قناع", "حقيبة زينة", "زينة اسلحة", "زينة ترس", "زينة درع", "زينة خوذة", "زينة قفازات", "زينة حذاء", "عباءة زينة", "اجنحة زينة", "مرافق ركوب", "حقيبة", "مهارة الوميض", "شعار", "بطاقة مهارة", "بطاقة زعيم", "زمردة"})
        Me.comGear.Location = New System.Drawing.Point(17, 255)
        Me.comGear.Name = "comGear"
        Me.comGear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comGear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comGear.Size = New System.Drawing.Size(100, 26)
        Me.comGear.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(57, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Tag = "140004"
        Me.Label3.Text = "نوع الدروب:"
        '
        'comtype
        '
        Me.comtype.BackColor = System.Drawing.Color.Transparent
        Me.comtype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comtype.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comtype.FocusedColor = System.Drawing.Color.Empty
        Me.comtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comtype.FormattingEnabled = True
        Me.comtype.Items.AddRange(New Object() {"كل", "الحربي", "الصياد", "السحري", "البراري"})
        Me.comtype.Location = New System.Drawing.Point(17, 183)
        Me.comtype.Name = "comtype"
        Me.comtype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comtype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comtype.Size = New System.Drawing.Size(100, 26)
        Me.comtype.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(84, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Tag = "140003"
        Me.Label2.Text = "النمط:"
        '
        'comRank
        '
        Me.comRank.BackColor = System.Drawing.Color.Transparent
        Me.comRank.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comRank.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comRank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comRank.FocusedColor = System.Drawing.Color.Empty
        Me.comRank.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comRank.FormattingEnabled = True
        Me.comRank.Items.AddRange(New Object() {"All", "1", "2", "3", "4", "5", "6", "7"})
        Me.comRank.Location = New System.Drawing.Point(17, 111)
        Me.comRank.Name = "comRank"
        Me.comRank.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comRank.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comRank.Size = New System.Drawing.Size(100, 26)
        Me.comRank.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Tag = "140002"
        Me.Label1.Text = "الرتبة:"
        '
        'comRace
        '
        Me.comRace.BackColor = System.Drawing.Color.Transparent
        Me.comRace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.comRace.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.comRace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comRace.FocusedColor = System.Drawing.Color.Empty
        Me.comRace.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comRace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.comRace.FormattingEnabled = True
        Me.comRace.Items.AddRange(New Object() {"كل", "اجوريا", "ارماد", "امانيس"})
        Me.comRace.Location = New System.Drawing.Point(17, 39)
        Me.comRace.Name = "comRace"
        Me.comRace.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comRace.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comRace.Size = New System.Drawing.Size(100, 26)
        Me.comRace.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(78, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Tag = "140001"
        Me.Label9.Text = "الشعب:"
        '
        'AdvancedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 678)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AdvancedItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvancedItem"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents comGear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents comtype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comRank As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comRace As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtitemLv As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtitemEnh As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtitemqty As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtclip As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtSearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents comboSearch As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lbAdd As Label
End Class
