Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class AdvancedItem

    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader

    Dim bs As New BindingSource
    Dim dt As New DataTable



    Dim DataConnection As Boolean = False
    Sub loadDataToDGV1()


        dt.Columns.Add("code", GetType(String))
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

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        If My.Settings.langString = "Ar" Then
            SQLitecmd.CommandText = "SELECT * from StringResource INNER JOIN ItemResource on ItemResource.name_id=StringResource.code and ItemResource.id;"
        Else
            SQLitecmd.CommandText = "SELECT * from StringResource_EN  INNER JOIN ItemResource on ItemResource.name_id=StringResource_EN .code and ItemResource.id;"
        End If

        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            counter += 1
            Dim location As String = Application.StartupPath & "\images\" & SQLiteReader("icon").ToString & ".jpg"
            If File.Exists(location) Then
                'File.Copy(location, "\images\" & SQLiteReader("icon").ToString & ".jpg", True)
                dt.Rows.Add(SQLiteReader("code").ToString, SQLiteReader("ID").ToString, SQLiteReader("name").ToString, SQLiteReader("name_id").ToString, SQLiteReader("Rank").ToString, SQLiteReader("Type").ToString, SQLiteReader("Group").ToString, SQLiteReader("Wear").ToString, SQLiteReader("L_Deva").ToString, SQLiteReader("L_Gaia").ToString, SQLiteReader("L_Asura").ToString, SQLiteReader("L_F").ToString, SQLiteReader("L_H").ToString, SQLiteReader("L_M").ToString, SQLiteReader("L_S").ToString, Image.FromFile(location))
            Else
                'location = My.Resources.common_mark_icon_unknown_middle. '"C:\Users\sdark\Desktop\Grimoire_v4122\Output\JPG\common_mark_icon_unknown_middle.jpg"
                dt.Rows.Add(SQLiteReader("code").ToString, SQLiteReader("ID").ToString, SQLiteReader("name").ToString, SQLiteReader("name_id").ToString, SQLiteReader("Rank").ToString, SQLiteReader("Type").ToString, SQLiteReader("Group").ToString, SQLiteReader("Wear").ToString, SQLiteReader("L_Deva").ToString, SQLiteReader("L_Gaia").ToString, SQLiteReader("L_Asura").ToString, SQLiteReader("L_F").ToString, SQLiteReader("L_H").ToString, SQLiteReader("L_M").ToString, SQLiteReader("L_S").ToString, My.Resources.common_mark_icon_unknown_middle)
            End If
            'Splashloading.LbProg.Text = "Loading " & counter.ToString & "of 34564"
            'Splashloading.ProgBar.Value = counter

        End While


        SQLiteReader.Close()
        SQLiteConn.Close()


        bs.DataSource = dt
        DGV1.DataSource = dt


        DGV1.Columns("code").Visible = False
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


        DataConnection = True
    End Sub

    Public Sub AdvancedItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        comRace.SelectedIndex = 0
        comRank.SelectedIndex = 0
        comtype.SelectedIndex = 0
        comGear.SelectedIndex = 0
        getitemsNew()
        comboSearch.SelectedIndex = 0
        translate()

    End Sub
    Sub GearFilter()

        bs.RemoveFilter()

        Dim Rank As String

        Dim L_F, L_H, L_M, L_S As String

        Dim Gaia, Asura, Deva As String

        Dim Gear As String


        'Race
        If comRace.SelectedIndex = 0 Then
            Gaia = "1"
            Asura = "1"
            Deva = "1"
        ElseIf comRace.SelectedIndex = 1 Then
            Gaia = "1"
            Asura = "0"
            Deva = "0"
        ElseIf comRace.SelectedIndex = 2 Then
            Gaia = "0"
            Asura = "1"
            Deva = "0"
        ElseIf comRace.SelectedIndex = 3 Then
            Gaia = "0"
            Asura = "0"
            Deva = "1"
        End If

        'Rank
        If comRank.SelectedIndex = 0 Then
            Rank = "*"
        Else
            Rank = comRank.SelectedItem.ToString
        End If

        'Type
        If comtype.SelectedIndex = 0 Then
            L_F = "1"
            L_H = "1"
            L_M = "1"
            L_S = "1"
        ElseIf comtype.SelectedIndex = 1 Then
            L_F = "1"
            L_H = "0"
            L_M = "0"
            L_S = "0"
        ElseIf comtype.SelectedIndex = 2 Then
            L_F = "0"
            L_H = "1"
            L_M = "0"
            L_S = "0"
        ElseIf comtype.SelectedIndex = 3 Then
            L_F = "0"
            L_H = "0"
            L_M = "1"
            L_S = "0"
        ElseIf comtype.SelectedIndex = 4 Then
            L_F = "0"
            L_H = "0"
            L_M = "0"
            L_S = "1"
        End If

        'Gear
        If comGear.SelectedIndex = 0 Then
            Gear = "*"
        ElseIf comGear.SelectedIndex = 1 Then
            Gear = "0"
        ElseIf comGear.SelectedIndex = 2 Then
            Gear = "1"
        ElseIf comGear.SelectedIndex = 3 Then
            Gear = "3"
        ElseIf comGear.SelectedIndex = 4 Then
            Gear = "4"
        ElseIf comGear.SelectedIndex = 5 Then
            Gear = "5"
        ElseIf comGear.SelectedIndex = 6 Then
            Gear = "2"
        ElseIf comGear.SelectedIndex = 7 Then
            Gear = "6"
        ElseIf comGear.SelectedIndex = 8 Then
            Gear = "7"
        ElseIf comGear.SelectedIndex = 9 Then
            Gear = "8"
        ElseIf comGear.SelectedIndex = 10 Then
            Gear = "9"
        ElseIf comGear.SelectedIndex = 11 Then
            Gear = "11"
        ElseIf comGear.SelectedIndex = 12 Then
            Gear = "12"
        ElseIf comGear.SelectedIndex = 13 Then
            Gear = "13"
        ElseIf comGear.SelectedIndex = 14 Then
            Gear = "14"
        ElseIf comGear.SelectedIndex = 15 Then
            Gear = "15"
        ElseIf comGear.SelectedIndex = 16 Then
            Gear = "16"
        ElseIf comGear.SelectedIndex = 17 Then
            Gear = "17"
        ElseIf comGear.SelectedIndex = 18 Then
            Gear = "18"
        ElseIf comGear.SelectedIndex = 19 Then
            Gear = "19"
        ElseIf comGear.SelectedIndex = 20 Then
            Gear = "20"
        ElseIf comGear.SelectedIndex = 21 Then
            Gear = "21"
        ElseIf comGear.SelectedIndex = 22 Then
            Gear = "22"
        ElseIf comGear.SelectedIndex = 23 Then
            Gear = "23"
        ElseIf comGear.SelectedIndex = 24 Then
            Gear = "28"
        ElseIf comGear.SelectedIndex = 25 Then
            Gear = "25"
        ElseIf comGear.SelectedIndex = 26 Then
            Gear = "100"
        ElseIf comGear.SelectedIndex = 27 Then
            Gear = "198"
        ElseIf comGear.SelectedIndex = 28 Then
            Gear = "200"
        End If
        Dim gear2 As String
        If Gear = "0" Then
            gear2 = "99"
        Else
            gear2 = "0"
        End If
        bs.Filter = String.Format("[Rank] Like '%{0}%' and [L_Gaia] Like '%{1}%' and [L_Asura] Like '%{2}%' and [L_Deva] Like '%{3}%' and [L_F] Like '%{4}%' and [L_H] Like '%{5}%' and [L_M] Like '%{6}%' and [L_S] Like '%{7}%' and [Wear] Like '%{8}%'", Rank, Gaia, Asura, Deva, L_F, L_H, L_M, L_S, Gear) ', gear2     or [Gear] Like '%{0}%'
    End Sub

    Private Sub comRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comRace.SelectedIndexChanged, comRank.SelectedIndexChanged, comtype.SelectedIndexChanged, comGear.SelectedIndexChanged
        If DataConnection = True Then
            GearFilter()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If comboSearch.SelectedIndex = 0 Then
            bs.Filter = "[name] Like '%" & txtSearch.Text & "%'"
        Else
            bs.Filter = "[ID] Like '%" & txtSearch.Text & "%'"
        End If

    End Sub

    Sub Getitem()
        Dim itempet As String
        Dim RowAt As Integer = DGV1.CurrentRow.Index
        Dim Lv As Integer = txtitemLv.Text
        Dim enhance As Integer = txtitemEnh.Text
        Dim Qty As Integer = txtitemqty.Text

        If DGV1.Rows(RowAt).Cells("Group").Value = 13 Then
            If Not MsgBox("هل تريد المرافق مروض", vbYesNo) = MsgBoxResult.Yes Then
                txtitemEnh.Text = "0"
            End If
            itempet = "-2147483648"
            If enhance > 5 Then
                MsgBox("لقد قمت بوضع رقم اكبر من 5 في حقل التطوير للمرافق")
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
    Sub getitemsNew()
        bs.DataSource = items.DGV1.DataSource
        DGV1.DataSource = bs



        'DGV1.Columns("code").Visible = False
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

        DataConnection = True
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        Getitem()
    End Sub

    Private Sub AdvancedItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        bs.RemoveFilter()
    End Sub

    Private Sub lbAdd_Click(sender As Object, e As EventArgs) Handles lbAdd.Click
        Getitem()
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

            comRace.Items.Clear()
            comRace.Items.Add(LangString("Language")(0)("10037"))
            comRace.Items.Add(LangString("Language")(0)("10038"))
            comRace.Items.Add(LangString("Language")(0)("10039"))
            comRace.Items.Add(LangString("Language")(0)("10040"))
            comRace.SelectedIndex = 0

            comtype.Items.Clear()
            comtype.Items.Add(LangString("Language")(0)("10037"))
            comtype.Items.Add(LangString("Language")(0)("10041"))
            comtype.Items.Add(LangString("Language")(0)("10042"))
            comtype.Items.Add(LangString("Language")(0)("10043"))
            comtype.Items.Add(LangString("Language")(0)("10044"))
            comtype.SelectedIndex = 0

            comGear.Items.Clear()
            comGear.Items.Add(LangString("Language")(0)("10037"))
            For i As Integer = 10045 To 10072
                comGear.Items.Add(LangString("Language")(0)(i.ToString))
            Next
            comGear.SelectedIndex = 0
            For Each ctrl As Control In Panel2.Controls
                Dim lbl As Label = TryCast(ctrl, Label)
                If lbl IsNot Nothing Then
                    lbl.Text = LangString("Language")(0)(lbl.Tag)
                End If
            Next
        End If
    End Sub
End Class