
Public Class Splashloading
    Private Sub Splashloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgBar.Value += 1
    End Sub
End Class