Public Class frontpage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaProgressBar1.Location = New Point(GunaProgressBar1.Location.X + 370, GunaProgressBar1.Location.Y + 400)
        GunaProgressBar1.Height = 40
        GunaProgressBar1.Width = 400
        GunaProgressBar1.Minimum = 1
        GunaProgressBar1.Maximum = 200
        GunaPictureBox1.Image = Image.FromFile("C:\Users\HIMANI SONEWANE\Pictures\Saved Pictures\WEB BUILDER2.gif")
        Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If GunaProgressBar1.Value >= 200 Then
            Timer2.Stop()
            Me.Hide()
            Login.Show()
        Else
            GunaProgressBar1.Value = GunaProgressBar1.Value + 1
        End If
    End Sub
    'Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    Dim SAPI As Object
    '    SAPI = CreateObject("SAPI.spvoice")
    '    SAPI.speak("WELCOME TO WEB BUILDER")
    'End Sub
End Class