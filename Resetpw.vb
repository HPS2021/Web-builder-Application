Imports System.Data.SqlClient

Public Class Resetpw
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Dim dr1, dr2 As SqlDataReader
    Dim p, q As String
    Public Sub connect()
        cn = New SqlConnection("Server=LAPTOP-PKKTTSU2\SQLEXPRESS;Database=Webbuilder;Trusted_Connection=True;")
        cn.Open()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaGradient2Panel1.Width = Me.Width
        GunaGradient2Panel1.Location = New Point(GunaGradient2Panel1.Location.X + 230, GunaGradient2Panel1.Location.Y + 60)
        GunaGradient2Panel1.Height = 450
        GunaGradient2Panel1.Width = 450
        Label1.Location = New Point(Label1.Location.X + 25, Label1.Location.Y + 5)
        Label1.Height = 50
        Label1.Width = 250
        Label1.Font = New Font("Arial Rounded MT", 26, FontStyle.Bold)
        Label2.Location = New Point(Label2.Location.X + 20, Label2.Location.Y + 35)
        Label2.Height = 50
        Label2.Width = 250
        Label2.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        RichTextBox1.Location = New Point(RichTextBox1.Location.X + 25, RichTextBox1.Location.Y + 50)
        RichTextBox1.Width = 350
        RichTextBox1.Height = 40
        Label3.Location = New Point(Label3.Location.X + 20, Label3.Location.Y + 75)
        Label3.Height = 50
        Label3.Width = 250
        Label3.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        TextBox1.Location = New Point(TextBox1.Location.X + 25, TextBox1.Location.Y + 90)
        TextBox1.Width = 350
        TextBox1.Height = 40
        Label4.Location = New Point(Label4.Location.X + 20, Label4.Location.Y + 110)
        Label4.Height = 50
        Label4.Width = 250
        Label4.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        TextBox2.Location = New Point(TextBox2.Location.X + 25, TextBox2.Location.Y + 125)
        TextBox2.Width = 350
        TextBox2.Height = 40
        GunaTileButton1.Height = 45
        GunaTileButton1.Width = 350
        GunaTileButton1.Font = New Font("Arial Rounded MT", 18, FontStyle.Bold)
        GunaTileButton1.Location = New Point(GunaTileButton1.Location.X + 25, GunaTileButton1.Location.Y + 160)
    End Sub

    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        If (RichTextBox1.Text = Nothing And RichTextBox1.Text = Nothing And RichTextBox1.Text = Nothing) Then
            MsgBox("Please enter required details!", MsgBoxStyle.Information, "System Message")
        Else

            Try
                Dim sql As String
                connect()
                sql = "select * from newuser where username='" & RichTextBox1.Text & "'"
                cmd = New SqlCommand(sql, cn)
                dr1 = cmd.ExecuteReader
                dr1.Read()
                If Not dr1.HasRows Then
                    MsgBox("This username is invalid!", MsgBoxStyle.Information, "System Message")
                ElseIf TextBox1.Text <> TextBox2.Text Then
                    MsgBox("Password and Confirm password doesn't match.", MsgBoxStyle.Information, "System Message")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            Try
                connect()
                p = "update newuser set Password='" & TextBox1.Text & "'" & "," & "Confirm_Password='" & TextBox2.Text & "'" & " where Username='" & RichTextBox1.Text & "'"
                cmd = New SqlCommand(p, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Password has been changed!", MsgBoxStyle.Information, "System Message")
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        'Me.Hide()
        'Login.Show()
    End Sub
End Class