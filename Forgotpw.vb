Imports System.Data.SqlClient
Public Class Forgotpw
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Dim dr1, dr2 As SqlDataReader
    Public Sub connect()
        cn = New SqlConnection("Server=LAPTOP-PKKTTSU2\SQLEXPRESS;Database=Webbuilder;Trusted_Connection=True;")
        cn.Open()
    End Sub
    Private Sub Forgotpw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaskedTextBox1.Mask = "00/00/0000"
        GunaGradient2Panel1.Width = Me.Width
        GunaGradient2Panel1.Location = New Point(GunaGradient2Panel1.Location.X + 153, GunaGradient2Panel1.Location.Y + 100)
        GunaGradient2Panel1.Height = 400
        GunaGradient2Panel1.Width = 800
        Label1.Location = New Point(Label1.Location.X + 230, Label1.Location.Y + 5)
        Label1.Height = 50
        Label1.Width = 250
        Label1.Font = New Font("Arial Rounded MT", 26, FontStyle.Bold)
        Label2.Location = New Point(Label2.Location.X + 85, Label2.Location.Y + 55)
        Label2.Height = 50
        Label2.Width = 250
        Label2.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        RichTextBox1.Location = New Point(RichTextBox1.Location.X + 165, RichTextBox1.Location.Y + 50)
        RichTextBox1.Width = 400
        RichTextBox1.Height = 40
        Label3.Location = New Point(Label3.Location.X + 55, Label3.Location.Y + 95)
        Label3.Height = 50
        Label3.Width = 250
        Label3.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        MaskedTextBox1.Location = New Point(MaskedTextBox1.Location.X + 147, MaskedTextBox1.Location.Y + 90)
        MaskedTextBox1.Width = 400
        MaskedTextBox1.Height = 40
        Label4.Location = New Point(Label4.Location.X + 1, Label4.Location.Y + 132)
        Label4.Height = 50
        Label4.Width = 250
        Label4.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        RichTextBox3.Location = New Point(RichTextBox3.Location.X + 130, RichTextBox3.Location.Y + 130)
        RichTextBox3.Width = 400
        RichTextBox3.Height = 40
        Label5.Location = New Point(Label5.Location.X + 118, Label5.Location.Y + 172)
        Label5.Height = 50
        Label5.Width = 250
        Label5.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        RichTextBox4.Location = New Point(RichTextBox4.Location.X + 175, RichTextBox4.Location.Y + 170)
        RichTextBox4.Width = 400
        RichTextBox4.Height = 40
        GunaTileButton1.Location = New Point(GunaTileButton1.Location.X + 530, GunaTileButton1.Location.Y + 42)
        GunaTileButton1.Height = 50
        GunaTileButton1.Width = 150
        GunaTileButton1.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        GunaTileButton2.Location = New Point(GunaTileButton2.Location.X + 400, GunaTileButton2.Location.Y + 190)
        GunaTileButton2.Height = 40
        GunaTileButton2.Width = 300
        GunaTileButton2.Font = New Font("Arial Rounded MT", 16S, FontStyle.Bold)
    End Sub

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click

        If (RichTextBox1.Text = Nothing And RichTextBox4.Text = Nothing) Then
            MsgBox("Please enter required details.", MsgBoxStyle.Information, "System Message")
        ElseIf RichTextBox4.Text = Nothing Then
            MsgBox("Answer can't be empty.", MsgBoxStyle.Information, "System Message")
        End If
        Try
            Dim sql As String
            connect()
            sql = "select * from newuser where username='" & RichTextBox1.Text & "'"
            cmd = New SqlCommand(sql, cn)
            dr1 = cmd.ExecuteReader
            dr1.Read()
            While dr1.Read
                If RichTextBox4.Text <> dr1.Item("Answer").ToString Then
                    MsgBox("Answer doen't match.Please try again!", MsgBoxStyle.Information, "System Message")
                End If
            End While
            dr1.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If Not (RichTextBox1.Text = Nothing And RichTextBox3.Text = Nothing And RichTextBox4.Text = Nothing) Then
            Me.Hide()
            Resetpw.Show()
        End If

    End Sub
    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        'If RichTextBox1.Text = Nothing Then
        '    MsgBox("Username can't be empty.", MsgBoxStyle.Information, "System Message")
        'End If
        Try
            Dim sql As String
            connect()
            sql = "select * from newuser where username='" & RichTextBox1.Text & "'"
            cmd = New SqlCommand(sql, cn)
            dr1 = cmd.ExecuteReader
            dr1.Read()
            If dr1.HasRows Then
                MsgBox("Username verified!Please enter further details.", MsgBoxStyle.Information, "System Message")
                MaskedTextBox1.ReadOnly = False
                RichTextBox3.ReadOnly = False
                RichTextBox4.ReadOnly = False
                MaskedTextBox1.Text = dr1.Item("DOB").ToString
                RichTextBox3.Text = dr1.Item("Security_Question").ToString
            Else
                MsgBox("This username is invalid!", MsgBoxStyle.Information, "System Message")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class