Imports System.IO
Imports System.Web.Script.Serialization

Public Class chat
    Private Sub chklock_CheckedChanged(sender As Object, e As EventArgs) Handles chklock.CheckedChanged
        If chklock.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub


    Private Sub chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboMute.SelectedIndex = 0
        comboplayercount.SelectedIndex = 0
        translate()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        sendChats()
    End Sub
    Sub sendChats()
        If txtAd.Text <> "" Then
            If chkAd.Checked = True Then
                Clipboard.SetText("/run announce(""" + txtAd.Text + """)")
            ElseIf chkNote.Checked = True Then
                Clipboard.SetText("/run notice(""" + txtAd.Text + """)")
            End If
            txtAd.Text = ""
        Else
            MsgBox("يرجى كتابة رسالة في حقل النص")
            txtAd.Focus()
        End If
    End Sub

    Private Sub txtAd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAd.KeyDown
        If e.KeyCode = Keys.Enter Then
            sendChats()
        End If
    End Sub

    Private Sub btnKilltarget_Click(sender As Object, e As EventArgs) Handles btnKilltarget.Click
        Clipboard.SetText("/run kill_target()")
    End Sub

    Private Sub btnPicKill_Click(sender As Object, e As EventArgs) Handles btnPicKill.Click
        Clipboard.SetText("/run kill_target()")
    End Sub

    Private Sub btnShowplayer_Click(sender As Object, e As EventArgs) Handles btnShowplayer.Click, lbShowplayer.Click
        Clipboard.SetText("/invisible 2")
    End Sub

    Private Sub btnHideplayer_Click(sender As Object, e As EventArgs) Handles btnHideplayer.Click, lbHideplayer.Click
        Clipboard.SetText("/invisible 1")
    End Sub

    Private Sub lbMute_Click(sender As Object, e As EventArgs) Handles lbMute.Click
        If txtTimemute.Text <> "" And txtnameMute.Text <> "" Then
            Dim time As Integer = txtTimemute.Text
            If ComboMute.SelectedIndex = 0 Then
                Clipboard.SetText("/block_chat " + txtnameMute.Text + " " + time)
            ElseIf ComboMute.SelectedIndex = 1
                Clipboard.SetText("/block_chat " + txtnameMute.Text + " " + (time * 60).ToString)
            ElseIf ComboMute.SelectedIndex = 2
                Clipboard.SetText("/block_chat " + txtnameMute.Text + " " + (time * 60 * 24).ToString)
            ElseIf ComboMute.SelectedIndex = 3
                Clipboard.SetText("/block_chat " + txtnameMute.Text + " " + (time * 60 * 24 * 7).ToString)
            End If
        Else
            MsgBox("يرجى التاكد من مدة كتم اللاعب واسم اللاعب")
        End If
    End Sub

    Private Sub lbKick_Click(sender As Object, e As EventArgs) Handles lbKick.Click
        If txtnameMute.Text <> "" Then
            Clipboard.SetText("/run kick(""" + txtnameMute.Text + """)")
        Else
            MsgBox("يرجى كتابة اسم الشخص المراد طرده من السيرفر")
            txtnameMute.Focus()
        End If
    End Sub

    Private Sub lbCount_Click(sender As Object, e As EventArgs) Handles lbCount.Click
        If comboplayercount.SelectedIndex = 0 Then
            'اعلان
            Clipboard.SetText("/run announce(""Player Online""..get_env(""game.user_count"").."" Only"")")
        ElseIf comboplayercount.SelectedIndex = 1
            'ملاحظة
            Clipboard.SetText("/run notice(""Player Online""..get_env(""game.user_count"").."" Only"")")
        ElseIf comboplayercount.SelectedIndex = 2
            'رسالة في الشات
            Clipboard.SetText("/run cprint(""Player Online""..get_env(""game.user_count"").."" Only"")")
        ElseIf comboplayercount.SelectedIndex = 3
            'ملاحظة خاصة
            Clipboard.SetText("/run private_notice(""Player Online""..get_env(""game.user_count"").."" Only"")")
        Else
            MsgBox("يرجى اختيار طريقة اعلان عدد اللاعبين في اللعبة")
        End If
    End Sub
    Sub translate()
        Dim path As String = Application.StartupPath + "\lang\" + My.Settings.LangSetting + ".json"
        If File.Exists(path) Then
            Dim json As String = File.ReadAllText(path)
            Dim LangString As Object = New JavaScriptSerializer().Deserialize(Of Object)(json)
            ComboMute.Items.Clear()
            ComboMute.Items.Add(LangString("Language")(0)("10003"))
            ComboMute.Items.Add(LangString("Language")(0)("10004"))
            ComboMute.Items.Add(LangString("Language")(0)("10005"))
            ComboMute.Items.Add(LangString("Language")(0)("10006"))
            ComboMute.SelectedIndex = 0
            comboplayercount.Items.Clear()
            comboplayercount.Items.Add(LangString("Language")(0)("10007"))
            comboplayercount.Items.Add(LangString("Language")(0)("10008"))
            comboplayercount.Items.Add(LangString("Language")(0)("10009"))
            comboplayercount.Items.Add(LangString("Language")(0)("10010"))
            comboplayercount.SelectedIndex = 0
            For Each ctrl As Control In pnlcontent.Controls
                Dim lbl As Label = TryCast(ctrl, Label)
                If lbl IsNot Nothing Then
                    lbl.Text = LangString("Language")(0)(lbl.Tag)
                    ToolTip1.SetToolTip(lbl, LangString("Language")(0)("T" & lbl.Tag))
                End If
            Next
        End If
    End Sub

    Private Sub lbAd_Click(sender As Object, e As EventArgs) Handles lbAd.Click
        chkAd.Checked = True
        If chkAd.Checked = True Then
            chkNote.Checked = False
            btnSend.Image = My.Resources.paper_plane_30pxAd
        End If
    End Sub
    Private Sub LbNote_Click(sender As Object, e As EventArgs) Handles LbNote.Click
        chkNote.Checked = True
        If chkNote.Checked = True Then
            chkAd.Checked = False
            btnSend.Image = My.Resources.paper_plane_30pxnote
        End If
    End Sub
End Class