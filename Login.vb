Imports System.Data.SqlClient
Public Class Login
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Dim dr1, dr2 As SqlDataReader
    Public Sub connect()
        cn = New SqlConnection("Server=LAPTOP-PKKTTSU2\SQLEXPRESS;Database=Webbuilder;Trusted_Connection=True;")
        cn.Open()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GunaGradient2Panel1.Width = Me.Width
        GunaGradient2Panel1.Location = New Point(GunaGradient2Panel1.Location.X + 355, GunaGradient2Panel1.Location.Y + 100)
        GunaGradient2Panel1.Height = 400
        GunaGradient2Panel1.Width = 400
        GunaLabel1.Location = New Point(GunaLabel1.Location.X + 70, GunaLabel1.Location.Y + 15)
        GunaLabel1.Height = 50
        GunaLabel1.Width = 250
        GunaLabel1.Font = New Font("Arial Rounded MT", 26, FontStyle.Bold)
        GunaLineTextBox1.Location = New Point(GunaLineTextBox1.Location.X + 50, GunaLineTextBox1.Location.Y + 70)
        GunaLineTextBox1.Height = 50
        GunaLineTextBox1.Width = 250
        GunaLineTextBox1.Font = New Font("Arial Rounded MT", 14)
        GunaLineTextBox2.Location = New Point(GunaLineTextBox2.Location.X + 50, GunaLineTextBox2.Location.Y + 120)
        GunaLineTextBox2.Height = 50
        GunaLineTextBox2.Width = 250
        GunaLineTextBox2.Font = New Font("Arial Rounded MT", 14)
        GunaTileButton1.Location = New Point(GunaTileButton1.Location.X + 50, GunaTileButton1.Location.Y + 160)
        GunaTileButton1.Height = 40
        GunaTileButton1.Width = 250
        GunaTileButton1.Font = New Font("Arial Rounded MT", 20)
        GunaLinkLabel1.Location = New Point(GunaLinkLabel1.Location.X + 25, GunaLinkLabel1.Location.Y + 200)
        GunaLinkLabel1.Height = 80
        GunaLinkLabel1.Width = 700
        GunaLinkLabel1.Font = New Font("Arial Rounded MT", 12)
        GunaLinkLabel2.Location = New Point(GunaLinkLabel2.Location.X + 165, GunaLinkLabel2.Location.Y + 200)
        GunaLinkLabel2.Height = 80
        GunaLinkLabel2.Width = 700
        GunaLinkLabel2.Font = New Font("Arial Rounded MT", 12)
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        'Me.Hide()
        Forgotpw.Show()
    End Sub
    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        Dim s As String
        s = GunaLineTextBox1.Text

        Try
            Dim sql As String
            connect()
            sql = "select * from newuser where username='" & GunaLineTextBox1.Text & "'"
            cmd = New SqlCommand(sql, cn)
            dr1 = cmd.ExecuteReader
            dr1.Read()
            If Not dr1.HasRows Then
                MsgBox("This username is invalid!")
            End If
            'If Not dr1(3).HasRows Then
            '    MsgBox("This password is incorrect!")
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If GunaLineTextBox1.Text = Nothing Then
            ErrorProvider1.SetError(GunaLineTextBox1, "Username can't be left blank.")
        Else
            ErrorProvider1.SetError(GunaLineTextBox1, Nothing)
        End If
        If GunaLineTextBox2.Text = Nothing Then
            ErrorProvider1.SetError(GunaLineTextBox2, "Password can't be left blank.")
        Else
            ErrorProvider1.SetError(GunaLineTextBox2, Nothing)
        End If
        'Me.Hide()
        Mainform.Show()
        'homepage.Show()
    End Sub
    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        newuser.Show()
        'Me.Hide()
    End Sub

    Private Sub GunaLineTextBox1_Enter(sender As Object, e As EventArgs) Handles GunaLineTextBox1.Enter
        Dim VisibleTime As Integer = 1000
        ToolTip1.Show("Username", GunaLineTextBox1, 200, 0, VisibleTime)
    End Sub

    Private Sub GunaLineTextBox2_Enter(sender As Object, e As EventArgs) Handles GunaLineTextBox2.Enter
        Dim VisibleTime As Integer = 1000
        ToolTip1.Show("Password", GunaLineTextBox2, 200, 0, VisibleTime)
    End Sub

End Class