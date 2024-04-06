Public Class Form1
    Dim NewChar As VnVChar

    Private Sub btnRollItAll_Click(sender As Object, e As EventArgs) Handles btnRollItAll.Click
        NewChar = VnVChar.RollANewOne
        TextBox1.Text = NewChar.ToString
    End Sub
End Class
