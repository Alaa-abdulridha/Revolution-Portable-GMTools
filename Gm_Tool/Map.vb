Imports System.Data.SQLite
Imports System.IO
Imports System.Web.Script.Serialization

Public Class Map

    Dim SQLiteConn As New SQLiteConnection
    Dim SQLitecmd As New SQLiteCommand
    Dim SQLitecnStr As String = "Data Source=" + Application.StartupPath + "\gmdb.db;Version=3;"
    Dim SQLiteReader As SQLiteDataReader
    Dim bs As New BindingSource
    Dim dt As New DataTable


    Private Sub Map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboChars.Items.AddRange(items.comboChars.Items.Cast(Of String).ToArray)
        comboChars.SelectedIndex = items.comboChars.SelectedIndex
        GetMap()
        translate()
    End Sub
    Sub GetMap()
        dt.Columns.Add("ar_place", GetType(String))
        dt.Columns.Add("X", GetType(String))
        dt.Columns.Add("Y", GetType(String))

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "SELECT * FROM Teleport;"

        SQLiteReader = SQLitecmd.ExecuteReader()
        While SQLiteReader.Read()
            If My.Settings.langString = "Ar" Then
                dt.Rows.Add(SQLiteReader("ar_place").ToString, SQLiteReader("x").ToString, SQLiteReader("y").ToString)
            End If
            dt.Rows.Add(SQLiteReader("En_place").ToString, SQLiteReader("x").ToString, SQLiteReader("y").ToString)
        End While

        SQLiteReader.Close()
        SQLiteConn.Close()
        bs.DataSource = dt
        DGV1.DataSource = dt

    End Sub

    Private Sub txtmob_TextChanged(sender As Object, e As EventArgs) Handles txtmob.TextChanged
        bs.Filter = "[ar_place] Like '%" & txtmob.Text & "%'"
    End Sub

    Private Sub btnGameMap_Click(sender As Object, e As EventArgs) Handles btnGameMap.Click
        GameMap.ShowDialog()
    End Sub

    Private Sub btnWarp_Click(sender As Object, e As EventArgs) Handles btnWarp.Click
        Dim Player As String = comboChars.SelectedItem.ToString
        Clipboard.SetText(String.Format("/run warp(gv('x',""{0}""),gv('y',""{0}""))", Player))
    End Sub

    Private Sub btnSommon_Click(sender As Object, e As EventArgs) Handles btnSommon.Click
        Dim Player As String = comboChars.SelectedItem.ToString
        Clipboard.SetText(String.Format("/run warp(gv('x'),gv('y'),""{0}""))", Player))
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick

        txtX.Text = DGV1.CurrentRow.Cells("X").Value
        txtY.Text = DGV1.CurrentRow.Cells("y").Value

    End Sub

    Private Sub comboMonster_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMob_Click(sender As Object, e As EventArgs) Handles btnMob.Click
        Dim Player As String = comboChars.SelectedItem.ToString
        Dim x As String = txtX.Text
        Dim y As String = txtY.Text
        Clipboard.SetText(String.Format("/run warp({0},{1},""{2}"")", x, y, Player))
    End Sub
    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)
            btnMob.Text = LangString("Language")(0)("10011")
            btnGameMap.Text = LangString("Language")(0)("10012")
            btnWarp.Text = LangString("Language")(0)("10013")
            btnSommon.Text = LangString("Language")(0)("10014")
            lbmaptitle.Text = LangString("Language")(0)("10015")
        End If
    End Sub
End Class