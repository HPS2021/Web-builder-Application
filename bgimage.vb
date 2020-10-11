Public Class bgimage
    Dim s1, s2, s3, s4, s5, s6 As String

    Private Sub GunaAdvenceTileButton22_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton22.Click
        Me.Close()
    End Sub
    Private Sub GunaAdvenceTileButton24_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton24.Click
        Dim od As New OpenFileDialog
        od.ShowDialog()
        GunaPictureBox9.Image = Image.FromFile(od.FileName)
        GunaTextBox2.Text = od.FileName

    End Sub
    Private Sub GunaAdvenceTileButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton21.Click
        If GunaRadioButton1.Checked = True Then
            s1 = GunaRadioButton1.Text
        ElseIf GunaRadioButton2.Checked = True Then
            s1 = GunaRadioButton2.Text
        ElseIf GunaRadioButton3.Checked = True Then
            s1 = GunaRadioButton3.Text
        ElseIf GunaRadioButton4.Checked = True Then
            s1 = GunaRadioButton4.Text
        ElseIf GunaRadioButton5.Checked = True Then
            s1 = GunaRadioButton5.Text
        ElseIf GunaRadioButton6.Checked = True Then
            s1 = GunaRadioButton6.Text
        ElseIf GunaRadioButton7.Checked = True Then
            s1 = GunaRadioButton7.Text
        Else
            s1 = GunaRadioButton8.Text
        End If
        If GunaRadioButton9.Checked = True Then
            s4 = GunaRadioButton9.Text
        ElseIf GunaRadioButton10.Checked = True Then
            s4 = GunaRadioButton10.Text
        ElseIf GunaRadioButton10.Checked = True Then
            s4 = GunaRadioButton10.Text
        ElseIf GunaRadioButton13.Checked = True Then
            s4 = GunaRadioButton13.Text
        ElseIf GunaRadioButton14.Checked = True Then
            s4 = GunaRadioButton14.Text
        ElseIf GunaRadioButton16.Checked = True Then
            s4 = GunaRadioButton16.Text
        Else
            s4 = GunaRadioButton15.Text
        End If
        s2 = GunaTextBox2.Text
        s6 = GunaNumeric1.Value
        s3 = GunaNumeric3.Value
        s5 = GunaNumeric2.Value
        Mainform.RichTextBox1.SelectedText = "<img src=" & "'" & s2 & "'" & "height=" & "'" & s6 & "'" & "width=" & "'" & s3 & "'" & "align=" & "'" & s4 & "'" & "border=" & "'" & s1 & "'" & ">"
        Me.Close()
    End Sub
End Class