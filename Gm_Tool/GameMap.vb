Public Class GameMap
    Dim g As Graphics = Me.CreateGraphics
    Dim bmp As Bitmap
    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.001
    Private Sub GameMap_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove


        Dim xLoc As Integer = (MousePosition.X - Me.Location.X) * 200
        Dim yLoc As Integer = (MousePosition.Y - Me.Location.Y) * 200

        lbx.Text = xLoc
        lby.Text = (193600 - yLoc)
    End Sub

    Private Sub GameMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        piczoomBox.SizeMode = PictureBoxSizeMode.StretchImage

        If piczoomBox.Image IsNot Nothing Then
            piczoomBox.Size = Panel1.Size
            _originalSize = Panel1.Size
        End If
        Timer1.Start()
    End Sub

    Private Sub GameMap_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Map.txtX.Text = lbx.Text
        Map.txtY.Text = lby.Text
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        bmp = New Bitmap(50, 50)
        g = Graphics.FromImage(bmp)
        Dim x As Integer = MousePosition.X - 25
        Dim y As Integer = MousePosition.Y - 25
        g.CopyFromScreen(x, y, 0, 0, New Size(500, 500))
        piczoomBox.Image = bmp
    End Sub
End Class