Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class SKILLS


    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader
    Dim bs As New BindingSource
    Dim dt As New DataTable


    Private Sub SKILLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboChars.Items.AddRange(items.comboChars.Items.Cast(Of String).ToArray)
        comboChars.SelectedIndex = items.comboChars.SelectedIndex
        getAllSkills()
        translate()
    End Sub
    Sub getAllSkills()

        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("icon", GetType(Image))

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        If My.Settings.langString = "Ar" Then
            SQLitecmd.CommandText = "SELECT SkillResource.ID, StringResource.name, SkillResource.icon FROM StringResource INNER JOIN SkillResource on SkillResource.name_id=StringResource.code;" 'limit 1000
        Else
            SQLitecmd.CommandText = "SELECT SkillResource.ID, StringResource_EN.name, SkillResource.icon FROM StringResource_EN INNER JOIN SkillResource on SkillResource.name_id=StringResource_EN.code;" 'limit 1000
        End If
        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            Dim location As String = Application.StartupPath & "\Skills\" & SQLiteReader("icon").ToString & ".jpg"
            If File.Exists(location) Then

                dt.Rows.Add(SQLiteReader("ID").ToString, SQLiteReader("name").ToString, Image.FromFile(location))
            Else
                dt.Rows.Add(SQLiteReader("ID").ToString, SQLiteReader("name").ToString, My.Resources.common_mark_icon_unknown_middle)
            End If

        End While


        SQLiteReader.Close()
        SQLiteConn.Close()
        bs.DataSource = dt
        DGV1.DataSource = dt

    End Sub



    Private Sub txtSkillSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSkillSearch.TextChanged
        bs.Filter = "[name] Like '%" & txtSkillSearch.Text & "%'"
    End Sub

    Private Sub btnSkill_Click(sender As Object, e As EventArgs) Handles btnSkill.Click
        Dim rowAt As Integer = DGV1.CurrentRow.Index
        Clipboard.SetText("/run learn_skill(""" & DGV1.Rows(rowAt).Cells("ID").Value.ToString & """)")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)
            btnSkill.Text = LangString("Language")(0)("10022")
            lbskilltitle.Text = LangString("Language")(0)("10023")
        End If
    End Sub
End Class