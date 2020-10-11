Public Class box
    Dim s1, s2, s3, s4, s5, s6, s7 As String
    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        GunaTextBox1.Text = "red"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        GunaTextBox1.Text = "black"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        GunaTextBox1.Text = "darkgray"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton6.Click
        GunaTextBox1.Text = "yellow"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton10.Click
        GunaTextBox1.Text = "purple"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton20_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton20.Click
        GunaTextBox1.Text = "white"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton19_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton19.Click
        GunaTextBox1.Text = "lightgray"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click
        GunaTextBox1.Text = "darkred"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton5.Click
        GunaTextBox1.Text = "orange"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton7.Click
        GunaTextBox1.Text = "green"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton8.Click
        GunaTextBox1.Text = "turquoise"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton9.Click
        GunaTextBox1.Text = "indigo"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton18_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton18.Click
        GunaTextBox1.Text = "brown"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton17_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton17.Click
        GunaTextBox1.Text = "rose"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton16_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton16.Click
        GunaTextBox1.Text = "gold"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton22_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton22.Click
        Me.Close()
    End Sub



    Private Sub GunaAdvenceTileButton15_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton15.Click
        GunaTextBox1.Text = "lightyellow"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton14_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton14.Click
        GunaTextBox1.Text = "lime"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton13_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton13.Click
        GunaTextBox1.Text = "lightturquoise"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton12.Click
        GunaTextBox1.Text = "bluegray"
        s3 = GunaTextBox1.Text
    End Sub



    Private Sub GunaAdvenceTileButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton11.Click
        GunaTextBox1.Text = "lavender"
        s3 = GunaTextBox1.Text
    End Sub

    Private Sub GunaAdvenceTileButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton21.Click
        If GunaRadioButton15.Checked = True Then
            s1 = GunaRadioButton15.Text
        ElseIf GunaRadioButton16.Checked = True Then
            s1 = GunaRadioButton16.Text
        ElseIf GunaRadioButton14.Checked = True Then
            s1 = GunaRadioButton14.Text
        ElseIf GunaRadioButton13.Checked = True Then
            s1 = GunaRadioButton13.Text
        ElseIf GunaRadioButton5.Checked = True Then
            s1 = GunaRadioButton5.Text
        ElseIf GunaRadioButton6.Checked = True Then
            s1 = GunaRadioButton6.Text
        ElseIf GunaRadioButton7.Checked = True Then
            s1 = GunaRadioButton7.Text
        Else
            s1 = GunaRadioButton8.Text
        End If
        If GunaRadioButton4.Checked = True Then
            s4 = GunaRadioButton4.Text
        ElseIf GunaRadioButton3.Checked = True Then
            s4 = GunaRadioButton3.Text
        ElseIf GunaRadioButton2.Checked = True Then
            s4 = GunaRadioButton2.Text
        Else
            s4 = GunaRadioButton1.Text
        End If
        s2 = boxh.Value
        s5 = boxw.Value
        s6 = bwidth.Value
        s7 = paddingpix.Value
        Mainform.RichTextBox1.SelectedText = "style='border:" & s1 & s6 & "px;" & "padding:" & s7 & "px;" & "border-color:" & s3 & "height:" & s2 & "px;" & "width:" & s5 & "px;'"
        Me.Hide()
    End Sub
End Class