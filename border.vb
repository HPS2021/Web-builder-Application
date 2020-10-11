Public Class border
    Dim s3 As String
    'Private Sub GunaRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton1.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton1.Checked = True Then
    '        MsgBox(GunaRadioButton1.Text)
    '    End If
    'End Sub

    'Private Sub GunaRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton2.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton2.Checked = True Then
    '        MsgBox(GunaRadioButton2.Text)
    '    End If
    'End Sub

    'Private Sub GunaRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton3.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton3.Checked = True Then
    '        MsgBox(GunaRadioButton3.Text)
    '    End If
    'End Sub
    'Private Sub GunaRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton4.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton4.Checked = True Then
    '        MsgBox(GunaRadioButton4.Text)
    '    End If
    'End Sub
    'Private Sub GunaRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton5.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton5.Checked = True Then
    '        MsgBox(GunaRadioButton5.Text)
    '    End If
    'End Sub
    'Private Sub GunaRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton6.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton6.Checked = True Then
    '        MsgBox(GunaRadioButton6.Text)
    '    End If
    'End Sub
    'Private Sub GunaRadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton7.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton7.Checked = True Then
    '        MsgBox(GunaRadioButton7.Text)
    '    End If
    'End Sub
    'Private Sub GunaRadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton8.CheckedChanged
    '    'str = sender.text
    '    'MsgBox(str)
    '    If GunaRadioButton8.Checked = True Then
    '        MsgBox(GunaRadioButton8.Text)
    '    End If
    'End Sub

    Private Sub GunaAdvenceTileButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton21.Click
        Dim s1, s2, s4, s5 As String
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
        ElseIf GunaRadioButton11.Checked = True Then
            s4 = GunaRadioButton11.Text
        Else
            s4 = GunaRadioButton12.Text
            'Else
            '    s4 = GunaRadioButton13.Text
        End If
        s2 = GunaNumeric1.Value
        s5 = GunaNumeric2.Value
        Mainform.RichTextBox1.SelectedText = "style='border:" & s1 & ";" & "width:" & s2 & "px" & ";" & "border-color:" & s3 & ";" & "padding-" & s4 & ":" & s5 & "px" & ";" & "'"
        Me.Hide()
    End Sub

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

    Private Sub GunaAdvenceTileButton22_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton22.Click
        Me.Close()
    End Sub


End Class