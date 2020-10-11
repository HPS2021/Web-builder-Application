Public Class showmargin
    Dim s1, s2, s3, s4, s5 As String
    Private Sub GunaAdvenceTileButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton21.Click
        s1 = GunaNumeric1.Value
        s2 = GunaNumeric1.Value
        s3 = GunaNumeric1.Value
        s4 = GunaNumeric1.Value
        s5 = GunaNumeric1.Value
        If GunaRadioButton9.Checked = True Then
            Mainform.RichTextBox1.SelectedText = "style='margin:" & s1 & "px; width:" & s1 & "px;'"
        ElseIf GunaRadioButton10.Checked = True Then
            Mainform.RichTextBox1.SelectedText = "style='margin-right:" & s2 & "px; width:" & s2 & "px;'"
        ElseIf GunaRadioButton11.Checked = True Then
            Mainform.RichTextBox1.SelectedText = "style='margin-left:" & s3 & "px; width:" & s3 & "px;'"
        ElseIf GunaRadioButton12.Checked = True Then
            Mainform.RichTextBox1.SelectedText = "style='margin-top:" & s4 & "px; width:" & s4 & "px;'"
        Else
            Mainform.RichTextBox1.SelectedText = "style='margin-bottom:" & s5 & "px; width:" & s5 & "px;'"
        End If
    End Sub
End Class