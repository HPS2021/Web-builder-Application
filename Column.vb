Public Class Column
    Dim s1, s2, s3, s4, s5, s6, s7 As String
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

    Private Sub GunaAdvenceTileButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton21.Click
        s1 = colcount.Value
        s2 = colgap.Value
        s4 = colwidth.Value
        s6 = stylewidth.Value
        If GunaRadioButton1.Checked = True Then
            s5 = GunaRadioButton1.Text
        ElseIf GunaRadioButton2.Checked = True Then
            s5 = GunaRadioButton2.Text
        ElseIf GunaRadioButton3.Checked = True Then
            s5 = GunaRadioButton3.Text
        ElseIf GunaRadioButton4.Checked = True Then
            s5 = GunaRadioButton4.Text
        ElseIf GunaRadioButton5.Checked = True Then
            s5 = GunaRadioButton5.Text
        ElseIf GunaRadioButton6.Checked = True Then
            s5 = GunaRadioButton6.Text
        ElseIf GunaRadioButton7.Checked = True Then
            s5 = GunaRadioButton7.Text
        Else
            s5 = GunaRadioButton8.Text
        End If
        If GunaRadioButton15.Checked = True Then
            s7 = GunaRadioButton15.Text
        ElseIf GunaRadioButton16.Checked = True Then
            s7 = GunaRadioButton16.Text
        ElseIf GunaRadioButton14.Checked = True Then
            s7 = GunaRadioButton14.Text
        Else
            s7 = GunaRadioButton13.Text
        End If
        Mainform.RichTextBox1.SelectedText = "style='column-count:" & s1 & ";" & "column-gap:" & s2 & ";" & "column-rule-color:" & s3 &
            ";" & "column-width:" & s4 & "px;" & "column-rule-style:" & s5 & ";" & "column-rule-width:" & s6 & "px;" & "column-span:" & s7 & ";'"
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

End Class