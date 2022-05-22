Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class Monsters

    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader
    Dim bs As New BindingSource
    Dim dt As New DataTable


    Private Sub Monsters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboChars.Items.AddRange(items.comboChars.Items.Cast(Of String).ToArray)
        comboChars.SelectedIndex = items.comboChars.SelectedIndex
        loadMonsters()
        comboMonster.SelectedIndex = 0
        translate()
    End Sub
    Sub loadMonsters()
        dt.Columns.Add("code", GetType(String))
        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("name_id", GetType(String))


        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        If My.Settings.langString = "Ar" Then
            SQLitecmd.CommandText = "SELECT * FROM StringResource INNER JOIN MonsterResource on MonsterResource.name_id=StringResource.code;" 'limit 1000
        Else
            SQLitecmd.CommandText = "SELECT * FROM StringResource_EN INNER JOIN MonsterResource on MonsterResource.name_id=StringResource_EN.code;" 'limit 1000
        End If

        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            dt.Rows.Add(SQLiteReader("code").ToString, SQLiteReader("ID").ToString, SQLiteReader("name").ToString, SQLiteReader("name_id").ToString)
        End While

        SQLiteReader.Close()
        SQLiteConn.Close()
        bs.DataSource = dt
        DGV1.DataSource = dt


        DGV1.Columns("code").Visible = False
        DGV1.Columns("name_id").Visible = False

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

    Private Sub txtmob_TextChanged(sender As Object, e As EventArgs) Handles txtmob.TextChanged
        bs.Filter = "[name] Like '%" & txtmob.Text & "%'"
    End Sub


    Private Sub comboMonster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMonster.SelectedIndexChanged
        If comboMonster.SelectedIndex = 0 Then
            comboChars.Enabled = False
            txtX.Enabled = False
            txtY.Enabled = False
        ElseIf comboMonster.SelectedIndex = 1 Then
            comboChars.Enabled = True
            txtX.Enabled = False
            txtY.Enabled = False
        ElseIf comboMonster.SelectedIndex = 2 Then
            comboChars.Enabled = False
            txtX.Enabled = True
            txtY.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbMobs_Click(sender As Object, e As EventArgs) Handles lbMobs.Click
        Dim MobID As String = DGV1.CurrentRow.Cells("ID").Value
        Dim Player As String = comboChars.SelectedItem.ToString
        Dim X As String = txtX.Text
        Dim y As String = txtY.Text
        Dim Num As String = txtMobNum.Text
        If comboMonster.SelectedIndex = 0 Then
            Clipboard.SetText(String.Format("//regenerate {0} {1}", MobID, Num))
        ElseIf comboMonster.SelectedIndex = 1 Then
            Clipboard.SetText(String.Format("/run add_npc(gv(x,""{0}""),gv(y,""{0}""),{1},{2})", Player, MobID, Num))
        ElseIf comboMonster.SelectedIndex = 2 Then
            Clipboard.SetText(String.Format("/run add_npc({0},{1},{2},{3})", X, y, MobID, Num))
        End If
    End Sub

    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)
            lbmobto.Text = LangString("Language")(0)("10016")
            lbMobs.Text = LangString("Language")(0)("10017")
            lbMobTitle.Text = LangString("Language")(0)("10018")
            mobQty.Text = LangString("Language")(0)("120002")
            comboMonster.Items.Clear()
            comboMonster.Items.Add(LangString("Language")(0)("10019"))
            comboMonster.Items.Add(LangString("Language")(0)("10020"))
            comboMonster.Items.Add(LangString("Language")(0)("10021"))
            comboMonster.SelectedIndex = 0
        End If
    End Sub
End Class