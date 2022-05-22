Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class StateResource


    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader
    Dim bs As New BindingSource
    Dim dt As New DataTable

    Private Sub StateResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buffs()
        comboChars.Items.AddRange(items.comboChars.Items.Cast(Of String).ToArray)
        comboChars.SelectedIndex = items.comboChars.SelectedIndex

        comboBuffTime.SelectedIndex = 0
        comboBufftype.SelectedIndex = 0
        translate()
    End Sub
    Sub Buffs()
        dt.Columns.Add("code", GetType(String))
        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("name_id", GetType(String))
        dt.Columns.Add("icon", GetType(Image))

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        If My.Settings.langString = "Ar" Then
            SQLitecmd.CommandText = "SELECT * FROM StringResource INNER JOIN StateResource on StateResource.name_id=StringResource.code WHERE StateResource.id;" 'limit 1000
        Else
            SQLitecmd.CommandText = "SELECT * FROM StringResource_EN INNER JOIN StateResource on StateResource.name_id=StringResource_EN.code WHERE StateResource.id;" 'limit 1000

        End If
        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            Dim location As String = Application.StartupPath & "\images\" & SQLiteReader("icon").ToString & ".jpg"
            If File.Exists(location) Then

                dt.Rows.Add(SQLiteReader("code").ToString, SQLiteReader("ID").ToString, SQLiteReader("name").ToString, SQLiteReader("name_id").ToString, Image.FromFile(location))
            Else

                dt.Rows.Add(SQLiteReader("code").ToString, SQLiteReader("ID").ToString, SQLiteReader("name").ToString, SQLiteReader("name_id").ToString, My.Resources.common_mark_icon_unknown_middle)
            End If

        End While


        SQLiteReader.Close()
        SQLiteConn.Close()
        bs.DataSource = dt
        DGV1.DataSource = dt


        DGV1.Columns("code").Visible = False
        DGV1.Columns("name_id").Visible = False
    End Sub

    Private Sub StateResource_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.lastchar = comboChars.SelectedIndex
        My.Settings.Save()
    End Sub

    Sub BuffAdd()
        If txtBuffLv.Text <> "" Then
            Dim BuffID As String = DGV1.CurrentRow.Cells("ID").Value
            Dim Player As String = comboChars.SelectedItem.ToString
            Dim BuffLV As String = txtBuffLv.Text
            Dim Time As Integer = 100


            If comboBuffTime.SelectedIndex = 0 Then
                Time = txtBuffTime.Text * Time
            ElseIf comboBuffTime.SelectedIndex = 1
                Time = (txtBuffTime.Text * Time * 60).ToString
            ElseIf comboBuffTime.SelectedIndex = 2
                Time = (txtBuffTime.Text * Time * 60 * 60).ToString
            ElseIf comboBuffTime.SelectedIndex = 3
                Time = (txtBuffTime.Text * Time * 60 * 60 * 24).ToString
            End If


            If comboBufftype.SelectedIndex = 0 Then
                Clipboard.SetText(String.Format("/run add_state({0},{1},{2},""{3}"")", BuffID, BuffLV, Time, Player))
            ElseIf comboBufftype.SelectedIndex = 1
                Clipboard.SetText(String.Format("/run remove_state({0},get_state_level({0}),""{1}"")", BuffID, Player))
            ElseIf comboBufftype.SelectedIndex = 2 Then
                Clipboard.SetText(String.Format("/run add_event_state({0},{1})", BuffID, BuffLV))
            ElseIf comboBufftype.SelectedIndex = 3 Then
                Clipboard.SetText(String.Format("/run remove_event_state({0})", BuffID))
            ElseIf comboBufftype.SelectedIndex = 4 Then
                Clipboard.SetText(String.Format("/run cast_world_state({0},{1},{2})", BuffID, BuffLV, Time))
            ElseIf comboBufftype.SelectedIndex = 5 Then
                Clipboard.SetText(String.Format("/run add_cstate({0},{1},{2},""{3}"")", BuffID, BuffLV, Time, Player))
            ElseIf comboBufftype.SelectedIndex = 6 Then
                Clipboard.SetText(String.Format("/run remove_cstate({0},get_state_level({0}),""{1}"")", BuffID, Player))
            End If

        End If
    End Sub

    Private Sub txtBuffSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBuffSearch.TextChanged
        bs.Filter = "[name] Like '%" & txtBuffSearch.Text & "%'"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick

        BuffAdd()

    End Sub

    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)

            lbBuffType.Text = LangString("Language")(0)("10024")
            lbBuffTime.Text = LangString("Language")(0)("10025")
            lbBufflvl.Text = LangString("Language")(0)("10026")
            lbBuff.Text = LangString("Language")(0)("10027")
            lbbufftitle.Text = LangString("Language")(0)("10028")
            comboBufftype.Items.Clear()
            comboBufftype.Items.Add(LangString("Language")(0)("10029"))
            comboBufftype.Items.Add(LangString("Language")(0)("10030"))
            comboBufftype.Items.Add(LangString("Language")(0)("10031"))
            comboBufftype.Items.Add(LangString("Language")(0)("10032"))
            comboBufftype.Items.Add(LangString("Language")(0)("10033"))
            comboBufftype.Items.Add(LangString("Language")(0)("10034"))
            comboBufftype.Items.Add(LangString("Language")(0)("10035"))
            comboBufftype.SelectedIndex = 0
            comboBuffTime.Items.Clear()
            comboBuffTime.Items.Add(LangString("Language")(0)("10036"))
            comboBuffTime.Items.Add(LangString("Language")(0)("10003"))
            comboBuffTime.Items.Add(LangString("Language")(0)("10004"))
            comboBuffTime.Items.Add(LangString("Language")(0)("10005"))
            comboBuffTime.SelectedIndex = 0
        End If
    End Sub

    Private Sub lbBuff_Click(sender As Object, e As EventArgs) Handles lbBuff.Click
        BuffAdd()
    End Sub
End Class