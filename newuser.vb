Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class newuser
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Dim dr1 As SqlDataReader
    Dim str As String
    Dim gen_type As String
    Dim path As String
    Public Sub connect()
        Try
            cn = New SqlConnection("Server=LAPTOP-PKKTTSU2\SQLEXPRESS;Database=Webbuilder;Trusted_Connection=True;")
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Dim od As New OpenFileDialog
        od.ShowDialog()
        GunaImageButton1.Image = Image.FromFile(od.FileName)
        path = od.FileName
    End Sub

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click
        Try
            If GunaRadioButton1.Checked = True Then
                gen_type = GunaRadioButton1.Text

            End If
            If GunaRadioButton2.Checked = True Then
                gen_type = GunaRadioButton2.Text
            End If
            connect()
            str = "insert into newuser(First_Name,Last_Name,Username,Password,Confirm_Password,DOB,Gender,Contact,Email,Security_Question,Answer,Image) values ('" & txtfname.Text & "','" & txtlname.Text & "','" & tbun.Text & "', '" & tbpw.Text & "','" & txtcpw.Text & "','" & MaskedTextBox1.Text & "','" & gen_type & "','" & tbcon.Text & "','" & tbemail.Text & "','" & GunaComboBox1.Text & "','" & tbans.Text & "','" & "(" & path & "')"
            cmd = New SqlCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Added ")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaskedTextBox1.Text = "00/00/0000"
        GunaImageButton1.Location = New Point(GunaImageButton1.Location.X + 750, GunaImageButton1.Location.Y + 30)
        GunaImageButton1.Height = 200
        GunaImageButton1.Width = 200
        GunaTileButton2.Location = New Point(GunaTileButton2.Location.X + 380, GunaTileButton2.Location.Y + 200)
        GunaTileButton2.Height = 50
        GunaTileButton2.Width = 200
        lbllname.Location = New Point(lbllname.Location.X + 580, lbllname.Location.Y + 50)
        lbllname.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblname.Location = New Point(lblname.Location.X + 140, lblname.Location.Y + 40)
        lblname.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblfname.Location = New Point(lblfname.Location.X + 250, lblfname.Location.Y + 50)
        lblfname.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblun.Location = New Point(lblun.Location.X + 100, lblun.Location.Y + 50)
        lblun.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        txtfname.Location = New Point(txtfname.Location.X + 200, txtfname.Location.Y + 40)
        txtfname.Width = 300
        txtfname.Height = 40
        txtlname.Location = New Point(txtlname.Location.X + 530, txtlname.Location.Y + 40)
        txtlname.Width = 300
        txtlname.Height = 40
        lblemail.Location = New Point(lblemail.Location.X + 140, lblemail.Location.Y + 75)
        lblemail.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        tbemail.Location = New Point(tbemail.Location.X + 200, tbemail.Location.Y + 90)
        tbemail.Width = 300
        tbemail.Height = 40
        tbun.Location = New Point(tbun.Location.X + 200, tbun.Location.Y + 60)
        tbun.Width = 300
        tbun.Height = 40
        tbpw.Location = New Point(tbpw.Location.X + 200, tbpw.Location.Y + 65)
        tbpw.Width = 300
        tbpw.Height = 40
        txtcpw.Location = New Point(txtcpw.Location.X + 530, txtcpw.Location.Y + 65)
        txtcpw.Width = 300
        txtcpw.Height = 40
        lblpw.Location = New Point(lblpw.Location.X + 100, lblpw.Location.Y + 65)
        lblpw.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblcpw.Location = New Point(lblcpw.Location.X + 370, lblcpw.Location.Y + 65)
        lblcpw.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lbldb.Location = New Point(lbldb.Location.X + 145, lbldb.Location.Y + 65)
        lbldb.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblgen.Location = New Point(lblgen.Location.X + 460, lblgen.Location.Y + 65)
        lblgen.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        GunaRadioButton1.Location = New Point(GunaRadioButton1.Location.X + 530, GunaRadioButton1.Location.Y + 70)
        GunaRadioButton1.Width = 200
        GunaRadioButton1.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        GunaRadioButton2.Location = New Point(GunaRadioButton2.Location.X + 570, GunaRadioButton2.Location.Y + 70)
        GunaRadioButton2.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        lblcon.Location = New Point(lblcon.Location.X + 124, lblcon.Location.Y + 100)
        lblcon.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        tbcon.Location = New Point(tbcon.Location.X + 200, tbcon.Location.Y + 110)
        tbcon.Width = 300
        tbcon.Height = 40
        lblques.Location = New Point(lblques.Location.X + 45, lblques.Location.Y + 120)
        lblques.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        GunaComboBox1.Location = New Point(GunaComboBox1.Location.X + 200, GunaComboBox1.Location.Y + 140)
        GunaComboBox1.Width = 500
        GunaComboBox1.Height = 50
        lblans.Location = New Point(lblans.Location.X + 130, lblans.Location.Y + 160)
        lblans.Font = New Font("Arial rounded black mt", 20, FontStyle.Bold)
        tbans.Location = New Point(tbans.Location.X + 200, tbans.Location.Y + 160)
        tbans.Width = 300
        tbans.Height = 40
        MaskedTextBox1.Location = New Point(MaskedTextBox1.Location.X + 205, MaskedTextBox1.Location.Y + 90)
        MaskedTextBox1.Width = 280
        MaskedTextBox1.Height = 70
        Try
            Dim sql As String
            connect()
            sql = "select * from sques2020"
            cmd = New SqlCommand(sql, cn)
            dr1 = cmd.ExecuteReader
            While dr1.Read
                GunaComboBox1.Items.Add(dr1.Item(0))
            End While
            dr1.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub tbemail_Validating(sender As Object, e As CancelEventArgs) Handles tbemail.Validating
        Dim email As String = tbemail.Text
        If EmailAddressCheck(email) = False Then
            Dim result As DialogResult = MessageBox.Show("The email you entered is not valid.Do you want to re-enter it?", "Invalid Email Address", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function
End Class