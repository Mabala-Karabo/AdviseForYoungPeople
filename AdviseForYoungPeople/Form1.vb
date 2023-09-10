Public Class Form1
    Private Sub txtAdvise_Click(sender As Object, e As EventArgs) Handles txtAdvise.Click
        Dim title As String
        Dim part1 As String
        Dim part2 As String
        Dim part3 As String

        title = txtTittle.Text
        part1 = txtPart1.Text
        part2 = txtPart2.Text
        part3 = txtPart3.Text

        Me.Text = title

        MsgBox("        " & title & vbCrLf & "1, " & part1 & vbCrLf & "2, " & part2 & vbCrLf & "3, " & part3)
    End Sub
End Class
