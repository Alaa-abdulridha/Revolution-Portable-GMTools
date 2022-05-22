Imports System.IO
Imports System.Web.Script.Serialization

Public Class ServerPre
    Private Sub ServerPre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        If My.Settings.langString = "Ar" Then
            ComboLang.SelectedIndex = 0
        Else
            ComboLang.SelectedIndex = 1
        End If
        comboPre.SelectedIndex = 1
        translate()
    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        If txtpre.Text <> "" Then
            If comboPre.SelectedIndex = 0 Then
                Clipboard.SetText("/run set_env(""gold_drop_rate""," & txtpre.Text & ")")
            ElseIf comboPre.SelectedIndex = 1 Then
                Clipboard.SetText("/run set_env(""game.exp_rate""," & txtpre.Text & ")")
            ElseIf comboPre.SelectedIndex = 2 Then
                Clipboard.SetText("/run set_env(""game.item_drop_rate""," & txtpre.Text & ")")
            End If
        Else
            MsgBox("يرجى كتابة قيمة للتعديل")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLang_Click(sender As Object, e As EventArgs) Handles btnLang.Click
        If ComboLang.SelectedIndex = 0 Then
            My.Settings.langString = "Ar"
            Threading.Thread.Sleep(50)
            My.Settings.langString = "Ar"
            Threading.Thread.Sleep(50)
            My.Settings.langString = "Ar"
            Threading.Thread.Sleep(50)
            My.Settings.Save()
        Else
            My.Settings.langString = "En"
            Threading.Thread.Sleep(50)
            My.Settings.langString = "En"
            Threading.Thread.Sleep(50)
            My.Settings.langString = "En"
            Threading.Thread.Sleep(50)
            My.Settings.Save()
        End If
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub addlang_Click(sender As Object, e As EventArgs) Handles addlang.Click
        My.Settings.Save()
    End Sub
    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)


            comboPre.Items.Clear()
            comboPre.Items.Add(LangString("Language")(0)("10073"))
            comboPre.Items.Add(LangString("Language")(0)("10074"))
            comboPre.Items.Add(LangString("Language")(0)("10075"))
            comboPre.SelectedIndex = 0

            lbrate.Text = LangString("Language")(0)("10076")
            btnPre.Text = LangString("Language")(0)("10077")
        End If
    End Sub
End Class