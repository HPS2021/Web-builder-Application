Public Class homepage
    Private Sub Frontpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaButton1.Location = New Point(GunaButton1.Location.X + 560, GunaButton1.Location.Y + 5)
        GunaButton1.Height = 30
        GunaButton1.Width = 110
        GunaButton2.Location = New Point(GunaButton2.Location.X + 570, GunaButton2.Location.Y + 5)
        GunaButton2.Height = 30
        GunaButton2.Width = 110
        GunaButton3.Location = New Point(GunaButton3.Location.X + 580, GunaButton3.Location.Y + 5)
        GunaButton3.Height = 30
        GunaButton3.Width = 130
        GunaButton4.Location = New Point(GunaButton4.Location.X + 600, GunaButton4.Location.Y + 5)
        GunaButton4.Height = 30
        GunaButton4.Width = 110
        GunaButton5.Location = New Point(GunaButton5.Location.X + 10, GunaButton5.Location.Y + 5)
        GunaButton5.Height = 30
        GunaButton5.Width = 110
        Label1.Location = New Point(Label1.Location.X + 320, Label1.Location.Y + 100)
        Label1.Height = 200
        Label1.Width = 300
        Label2.Location = New Point(Label2.Location.X + 330, Label2.Location.Y + 100)
        Label2.Height = 200
        Label2.Width = 300
        PictureBox1.Location = New Point(PictureBox1.Location.X + 330, PictureBox1.Location.Y + 100)
        PictureBox1.Height = 50
        PictureBox1.Width = 50
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Mainform.Show()
    End Sub
End Class