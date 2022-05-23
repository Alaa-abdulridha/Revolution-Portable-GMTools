Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class items
    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLitecnStriTEMS As String = "Data Source=" + Application.StartupPath + "\ItemResource.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader

    Dim bs As New BindingSource
    Dim dt As New DataTable


    Dim Gaia() As String = {"متدرب اجوريا", "مقاتل", "جلمود", "وحشي", "الفولاذي", "القناص", "مغوار", "صنديد", "سيد الوحوش", "المدجج", "امير النبال", "الامبراطور", "الباسل", "سيد الكواسر"}
    Dim Asura() As String = {"متدرب ارماد", "المناور", "الساحر", "كابوس", "سفاح", "سيد الاظلام", "ساحر ظلامي", "المحطم", "سيد البراري", "الشبح", "محارب الغسق", "امير الظلال", "المتربص", "سيد الادغال"}
    Dim Deva() As String = {"متدرب امانيس", "مدافع", "مسعف", "مروض", "متراس", "فارس", "طبيب", "حكيم", "مخلب", "مدرع", "نبيل", "سيد حكماء", "مستشار", "الجارح"}

    Dim msg1 As String = "حدث خطأ - اسم اللاعب او القيمة المراد اضافتها فارغة"
    Dim msg2 As String = "هل تريد المرافق مروض"
    Dim msg3 As String = "هل تريد فتح مهارات المرافق للشخصية المحددة؟"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtR.TextChanged
        If Val(txtR.Text) < 9999999 Then
            txtR.ForeColor = Color.FromArgb(2, 236, 2)
            txtR.FocusedForeColor = Color.FromArgb(2, 236, 2)
        ElseIf Val(txtR.Text) < 99999999
            txtR.ForeColor = Color.FromArgb(254, 245, 60)
            txtR.FocusedForeColor = Color.FromArgb(254, 245, 60)
        ElseIf Val(txtR.Text) < 999999999
            txtR.ForeColor = Color.FromArgb(255, 181, 0)
            txtR.FocusedForeColor = Color.FromArgb(255, 181, 0)
        ElseIf Val(txtR.Text) < 99999999999
            txtR.ForeColor = Color.FromArgb(241, 177, 246)
            txtR.FocusedForeColor = Color.FromArgb(241, 177, 246)
        ElseIf Val(txtR.Text) >= 1000000000000
            txtR.ForeColor = Color.FromArgb(175, 74, 201)
            txtR.FocusedForeColor = Color.FromArgb(175, 74, 201)
        End If
    End Sub

    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles ch1.CheckedChanged
        If sender.Checked = True Then
            'ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.RemoveFilter()
        End If

    End Sub

    Private Sub ch2_CheckedChanged(sender As Object, e As EventArgs) Handles ch2.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            'ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 2 and [Group] = 10"
        End If

    End Sub

    Private Sub ch3_CheckedChanged(sender As Object, e As EventArgs) Handles ch3.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            'ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 2 and [Group] = 13"
        End If

    End Sub

    Private Sub ch4_CheckedChanged(sender As Object, e As EventArgs) Handles ch4.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            'ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 1"
        End If

    End Sub

    Private Sub ch5_CheckedChanged(sender As Object, e As EventArgs) Handles ch5.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            'ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 3"
        End If

    End Sub

    Private Sub ch6_CheckedChanged(sender As Object, e As EventArgs) Handles ch6.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            'ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 4"
        End If

    End Sub

    Private Sub ch7_CheckedChanged(sender As Object, e As EventArgs) Handles ch7.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            'ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 0"
        End If

    End Sub

    Private Sub ch8_CheckedChanged(sender As Object, e As EventArgs) Handles ch8.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            'ch8.Checked = False
            ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 6"
        End If

    End Sub

    Private Sub ch9_CheckedChanged(sender As Object, e As EventArgs) Handles ch9.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            'ch9.Checked = False
            ch10.Checked = False
            bs.Filter = "[Type] = 5"
        End If

    End Sub

    Private Sub ch10_CheckedChanged(sender As Object, e As EventArgs) Handles ch10.CheckedChanged
        If sender.Checked = True Then
            ch1.Checked = False
            ch2.Checked = False
            ch3.Checked = False
            ch4.Checked = False
            ch5.Checked = False
            ch6.Checked = False
            ch7.Checked = False
            ch8.Checked = False
            ch9.Checked = False
            'ch10.Checked = False
            bs.Filter = "[Type] = 9"
        End If

    End Sub

    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataToDGV1()
        loadDatafromChars()
        comboSearch.SelectedIndex = 0
        translate()
    End Sub


    Sub loadDatafromChars()
        comboChars.Items.Clear()
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "SELECT * FROM Characters;"
        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            comboChars.Items.Add(SQLiteReader("Chara_Name").ToString)
        End While
        comboChars.SelectedIndex = My.Settings.lastchar
        SQLiteReader.Close()
        SQLiteConn.Close()
    End Sub
    Sub newChar(ByVal chara As String)
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "INSERT INTO Characters (Chara_Name) VALUES ('" + chara + "');"
        SQLiteReader = SQLitecmd.ExecuteReader()
        SQLiteReader.Close()
        SQLiteConn.Close()
        loadDatafromChars()
        comboChars.SelectedIndex = comboChars.Items.Count - 1
    End Sub
    Sub DeleteChar(ByVal chara As String)
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "DELETE FROM Characters WHERE Chara_Name='" + chara + "';"
        SQLiteReader = SQLitecmd.ExecuteReader()
        SQLiteReader.Close()
        SQLiteConn.Close()


        comboChars.Items.Clear()
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "SELECT * FROM Characters;"
        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            comboChars.Items.Add(SQLiteReader("Chara_Name").ToString)
        End While
        SQLiteReader.Close()
        SQLiteConn.Close()
        comboChars.SelectedIndex = comboChars.Items.Count - 1

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If comboSearch.SelectedIndex = 0 Then
            bs.Filter = "[name] Like '%" & txtSearch.Text & "%'"
        Else
            bs.Filter = "[ID] Like '%" & txtSearch.Text & "%'"
        End If

    End Sub

    Private Sub BtnAddchara_Click(sender As Object, e As EventArgs) Handles BtnAddchara.Click
        If comboNewChar.Text <> "" Then
            newChar(comboNewChar.Text)
            comboNewChar.Text = ""
        End If
    End Sub

    Private Sub btnDelChar_Click(sender As Object, e As EventArgs) Handles btnDelChar.Click
        DeleteChar(comboChars.SelectedItem.ToString)
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnChatForm_Click(sender As Object, e As EventArgs) Handles btnChatForm.Click
        chat.Show()
    End Sub

    Private Sub btnAllSkills_Click(sender As Object, e As EventArgs) Handles btnAllSkills.Click, lbAllSkills.Click
        Clipboard.SetText("/run learn_all_skill(""" & comboChars.SelectedItem.ToString & """)")
        txtclip.Text = Clipboard.GetText()
    End Sub

    Private Sub btnWearhouse_Click(sender As Object, e As EventArgs) Handles btnWearhouse.Click, lbWearhouse.Click
        Clipboard.SetText("/run open_storage(""" & comboChars.SelectedItem.ToString & """)")
        txtclip.Text = Clipboard.GetText()
    End Sub

    Private Sub btnAucction_Click(sender As Object, e As EventArgs) Handles btnAucction.Click, lbAucction.Click
        Clipboard.SetText("/run show_auction_window(""" & comboChars.SelectedItem.ToString & """)")
        txtclip.Text = Clipboard.GetText()
    End Sub

    Private Sub lbLv_Click(sender As Object, e As EventArgs) Handles lbLv.Click
        If comboChars.SelectedIndex <> -1 And txtLV.Text <> "" Then
            Clipboard.SetText("/run sv(""lv""," & txtLV.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbJLV_Click(sender As Object, e As EventArgs) Handles lbJLV.Click
        If comboChars.SelectedIndex <> -1 And txtJLV.Text <> "" Then
            Clipboard.SetText("/run sv(""jlv""," & txtJLV.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbTP_Click(sender As Object, e As EventArgs) Handles lbTP.Click
        If comboChars.SelectedIndex <> -1 And txtTP.Text <> "" Then
            Clipboard.SetText("/run sv(""tp""," & txtTP.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbJP_Click(sender As Object, e As EventArgs) Handles lbJP.Click
        If comboChars.SelectedIndex <> -1 And txtJP.Text <> "" Then
            Clipboard.SetText("/run sv(""jp""," & txtJP.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbAP_Click(sender As Object, e As EventArgs) Handles lbAP.Click
        If comboChars.SelectedIndex <> -1 And txtAP.Text <> "" Then
            Clipboard.SetText("/run sv(""ap""," & txtAP.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbBP_Click(sender As Object, e As EventArgs) Handles lbBP.Click
        If comboChars.SelectedIndex <> -1 And txtBP.Text <> "" Then
            Clipboard.SetText("/run sv(""p""," & txtBP.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub lbR_Click(sender As Object, e As EventArgs) Handles lbR.Click
        If comboChars.SelectedIndex <> -1 And txtR.Text <> "" Then
            Clipboard.SetText("/run insert_gold(" & txtR.Text & ",""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            MsgBox(msg1)
        End If
    End Sub

    Private Sub items_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.lastchar = comboChars.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        Dim itempet As String
        Dim emptyPet As Boolean = False
        Dim RowAt As Integer = DGV1.CurrentRow.Index
        Dim Lv As Integer = txtitemLv.Text
        Dim enhance As Integer = txtitemEnh.Text
        Dim Qty As Integer = txtitemqty.Text

        If DGV1.Rows(RowAt).Cells("Group").Value = 13 Then
            If Not MsgBox(msg2, vbYesNo) = MsgBoxResult.Yes Then
                emptyPet = True
            End If
            itempet = "-2147483648"
            If emptyPet = True Then
                Clipboard.SetText(String.Format("//item {0} {1}", DGV1.Rows(RowAt).Cells("ID").Value.ToString, Qty))
            Else
                Clipboard.SetText(String.Format("/run insert_item({0},{1},{2},{3},{4})", DGV1.Rows(RowAt).Cells("ID").Value.ToString, Qty, enhance, Lv, itempet))
            End If
        ElseIf DGV1.Rows(RowAt).Cells("Group").Value = 10 Then
            itempet = "3"
            Clipboard.SetText(String.Format("/run insert_item({0},{1},{2},{3},{4})", DGV1.Rows(RowAt).Cells("ID").Value.ToString, Qty, enhance, Lv, itempet))
        ElseIf DGV1.Rows(RowAt).Cells("Type").Value = 1 Then
            itempet = "2"
            Clipboard.SetText(String.Format("/run insert_item({0},{1},{2},{3},{4})", DGV1.Rows(RowAt).Cells("ID").Value.ToString, Qty, enhance, Lv, itempet))
        Else
            Clipboard.SetText(String.Format("//item {0} {1}", DGV1.Rows(RowAt).Cells("ID").Value.ToString, Qty))
        End If
        txtclip.Text = Clipboard.GetText()
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ServerPre.Show()
    End Sub

    Private Sub btnGmOn_Click(sender As Object, e As EventArgs) Handles btnGmOn.Click
        Clipboard.SetText(String.Format("/run sv(""permission"",1,""{0}"")", comboChars.SelectedItem.ToString))
    End Sub

    Private Sub btnGmOff_Click(sender As Object, e As EventArgs) Handles btnGmOff.Click
        Clipboard.SetText(String.Format("/run sv(""permission"",0,""{0}"")", comboChars.SelectedItem.ToString))
    End Sub

    Private Sub btnBuff_Click(sender As Object, e As EventArgs) Handles btnBuff.Click, lbBuff.Click
        StateResource.Show()
    End Sub

    Private Sub btnMob_Click(sender As Object, e As EventArgs) Handles btnMob.Click, lbMob.Click
        Monsters.Show()
    End Sub

    Private Sub btnmap_Click(sender As Object, e As EventArgs) Handles btnmap.Click, lbmap.Click
        Map.Show()
    End Sub

    Private Sub btnSkills_Click(sender As Object, e As EventArgs) Handles btnSkills.Click, lbSkills.Click
        SKILLS.Show()
    End Sub

    Private Sub comboRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboRace.SelectedIndexChanged

        If comboRace.SelectedIndex = 0 Then
            comboJob.Items.Clear()
            comboJob.Items.AddRange(Gaia)
            comboJob.SelectedIndex = 0
        ElseIf comboRace.SelectedIndex = 1 Then
            comboJob.Items.Clear()
            comboJob.Items.AddRange(Asura)
            comboJob.SelectedIndex = 0
        ElseIf comboRace.SelectedIndex = 2 Then
            comboJob.Items.Clear()
            comboJob.Items.AddRange(Deva)
            comboJob.SelectedIndex = 0
        End If
    End Sub


    Sub loadDataToDGV1()


        'dt.Columns.Add("code", GetType(String))
        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("name_id", GetType(String))
        dt.Columns.Add("Rank", GetType(String))
        dt.Columns.Add("Type", GetType(String))
        dt.Columns.Add("Group", GetType(String))
        dt.Columns.Add("Wear", GetType(String))
        dt.Columns.Add("L_Deva", GetType(String))
        dt.Columns.Add("L_Gaia", GetType(String))
        dt.Columns.Add("L_Asura", GetType(String))
        dt.Columns.Add("L_F", GetType(String))
        dt.Columns.Add("L_H", GetType(String))
        dt.Columns.Add("L_M", GetType(String))
        dt.Columns.Add("L_S", GetType(String))
        dt.Columns.Add("icon", GetType(Image))



        Dim counter As Integer = 0

        SQLiteConn.ConnectionString = SQLitecnStriTEMS
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        If My.Settings.langString = "Ar" Then
            SQLitecmd.CommandText = "SELECT * FROM Items;"
        Else
            SQLitecmd.CommandText = "SELECT * FROM Items_en;"
        End If

        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            counter += 1
            Dim location As String = Application.StartupPath & "\images\" & SQLiteReader("ICON").ToString & ".jpg"
            If File.Exists(location) Then
                Dim name As String = SQLiteReader("name").ToString
                For tt As Integer = 0 To ServerPre.txtremove.Lines.Length - 1
                    name = name.Replace(ServerPre.txtremove.Lines(tt), "")
                Next
                dt.Rows.Add(SQLiteReader("id").ToString, name, SQLiteReader("name_id").ToString, SQLiteReader("rank").ToString, SQLiteReader("type").ToString, SQLiteReader("group").ToString, SQLiteReader("wear").ToString, SQLiteReader("L_Deva").ToString, SQLiteReader("L_Gaia").ToString, SQLiteReader("L_Asura").ToString, SQLiteReader("L_F").ToString, SQLiteReader("L_H").ToString, SQLiteReader("L_M").ToString, SQLiteReader("L_S").ToString, Image.FromFile(location))
            Else
                Dim name As String = SQLiteReader("name").ToString
                For tt As Integer = 0 To ServerPre.txtremove.Lines.Length - 1
                    name = name.Replace(ServerPre.txtremove.Lines(tt), "")
                Next
                dt.Rows.Add(SQLiteReader("id").ToString, name, SQLiteReader("name_id").ToString, SQLiteReader("rank").ToString, SQLiteReader("type").ToString, SQLiteReader("group").ToString, SQLiteReader("wear").ToString, SQLiteReader("L_Deva").ToString, SQLiteReader("L_Gaia").ToString, SQLiteReader("L_Asura").ToString, SQLiteReader("L_F").ToString, SQLiteReader("L_H").ToString, SQLiteReader("L_M").ToString, SQLiteReader("L_S").ToString, My.Resources.common_mark_icon_unknown_middle)
            End If
        End While


        SQLiteReader.Close()
        SQLiteConn.Close()


        bs.DataSource = dt
        DGV1.DataSource = dt



        DGV1.Columns("name_id").Visible = False
        DGV1.Columns("Rank").Visible = False
        DGV1.Columns("Type").Visible = False
        DGV1.Columns("Group").Visible = False
        DGV1.Columns("Wear").Visible = False
        DGV1.Columns("L_Deva").Visible = False
        DGV1.Columns("L_Gaia").Visible = False
        DGV1.Columns("L_Asura").Visible = False
        DGV1.Columns("L_F").Visible = False
        DGV1.Columns("L_H").Visible = False
        DGV1.Columns("L_M").Visible = False
        DGV1.Columns("L_S").Visible = False

        DGV1.Columns("ID").Width = 60
        DGV1.Columns("ICON").Width = 55

    End Sub

    Private Sub btnBagFilter_Click(sender As Object, e As EventArgs) Handles btnBagFilter.Click, lbBagFilter.Click
        AdvancedItem.Show()
    End Sub

    Private Sub btnPetSkills_Click(sender As Object, e As EventArgs) Handles btnPetSkills.Click
        If MsgBox(msg3, vbYesNo) = MsgBoxResult.Yes Then
            Clipboard.SetText("/run learn_creature_all_skill(""" & comboChars.SelectedItem.ToString & """)")
            txtclip.Text = Clipboard.GetText()
        Else
            Clipboard.SetText("/run learn_creature_all_skill()")
            txtclip.Text = Clipboard.GetText()
        End If
    End Sub
    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)
            comboSearch.Items.Clear()
            comboSearch.Items.Add(LangString("Language")(0)("10001"))
            comboSearch.Items.Add(LangString("Language")(0)("10002"))
            comboSearch.SelectedIndex = 0
            For Each ctrl As Control In Panel3.Controls
                Dim lbl As Label = TryCast(ctrl, Label)
                If lbl IsNot Nothing Then
                    lbl.Text = LangString("Language")(0)(lbl.Tag)
                    ToolTip1.SetToolTip(lbl, LangString("Language")(0)("T" & lbl.Tag))
                End If
            Next
            For Each ctrl As Control In pnlSide.Controls
                Dim lbl As Guna.UI.WinForms.GunaImageCheckBox = TryCast(ctrl, Guna.UI.WinForms.GunaImageCheckBox)
                If lbl IsNot Nothing Then
                    'lbl.Text = LangString("Language")(0)(lbl.Tag)
                    ToolTip1.SetToolTip(lbl, LangString("Language")(0)(lbl.Tag))
                End If
            Next
            'classes

            Dim newGaia, newAsura, newDeva As New List(Of String)
            For newtxt As Integer = 10078 To 10119
                If newtxt < 10092 Then
                    newGaia.Add(LangString("Language")(0)(newtxt))
                ElseIf newtxt < 10106
                    newAsura.Add(LangString("Language")(0)(newtxt))
                Else
                    newDeva.Add(LangString("Language")(0)(newtxt))
                End If
            Next
            Gaia = newGaia.ToArray
            Asura = newAsura.ToArray
            Deva = newDeva.ToArray
            comboRace.Items.Clear()
            comboRace.Items.Add(LangString("Language")(0)("10038"))
            comboRace.Items.Add(LangString("Language")(0)("10039"))
            comboRace.Items.Add(LangString("Language")(0)("10040"))
            comboRace.SelectedIndex = 0

            'msg
            msg1 = LangString("Language")(0)("10120")
            msg2 = LangString("Language")(0)("10121")
            msg3 = LangString("Language")(0)("10122")
        End If
    End Sub
    Private Sub lbClass_Click(sender As Object, e As EventArgs) Handles lbClass.Click
        Dim player As String = comboChars.SelectedItem.ToString
        Dim Job As Integer
        If comboRace.SelectedIndex = 0 Then
            If comboJob.SelectedIndex = 0 Then
                Job = 100
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 1 Then
                Job = 101
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 2 Then
                Job = 102
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 3 Then
                Job = 103
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 4 Then
                Job = 110
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 5 Then
                Job = 111
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 6 Then
                Job = 112
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 7 Then
                Job = 113
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 8 Then
                Job = 114
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 9 Then
                Job = 120
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 10 Then
                Job = 121
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 11 Then
                Job = 122
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 12 Then
                Job = 123
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 13 Then
                Job = 124
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            End If
        ElseIf comboRace.SelectedIndex = 1 Then
            If comboJob.SelectedIndex = 0 Then
                Job = 300
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 1 Then
                Job = 301
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 2 Then
                Job = 302
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 3 Then
                Job = 303
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 4 Then
                Job = 310
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 5 Then
                Job = 311
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 6 Then
                Job = 312
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 7 Then
                Job = 313
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 8 Then
                Job = 314
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 9 Then
                Job = 320
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 10 Then
                Job = 321
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 11 Then
                Job = 322
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 12 Then
                Job = 323
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 13 Then
                Job = 324
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            End If
        ElseIf comboRace.SelectedIndex = 2 Then
            If comboJob.SelectedIndex = 0 Then
                Job = 200
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 1 Then
                Job = 201
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 2 Then
                Job = 202
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 3 Then
                Job = 203
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 4 Then
                Job = 210
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 5 Then
                Job = 211
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 6 Then
                Job = 212
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 7 Then
                Job = 213
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 8 Then
                Job = 214
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 9 Then
                Job = 220
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 10 Then
                Job = 221
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 11 Then
                Job = 222
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 12 Then
                Job = 223
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            ElseIf comboJob.SelectedIndex = 13 Then
                Job = 224
                Clipboard.SetText(String.Format("/run sv(""job"",{0},""{1}"")", Job, player))
            End If
        End If
    End Sub
End Class