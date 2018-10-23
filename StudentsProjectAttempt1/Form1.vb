Public Class Form1

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim Value = NumericUpDown1.Value
        If Value = 1 Then
            Label1.Text = "MoveUp() - Moves the character one unit up."
        ElseIf Value = 0 Then
            Label1.Text = ""
        ElseIf Value = 2 Then
            Label1.Text = "MoveDown() - Moves the character one unit down."
        ElseIf Value = 3 Then
            Label1.Text = "MoveLeft() - Moves the character one unit left."
        ElseIf Value = 4 Then
            Label1.Text = "MoveRight() - Moves the character one unit right."
        End If
    End Sub

    Private Sub Command_Btn_Click(sender As Object, e As EventArgs) Handles Command_Btn.Click

        If TextBox1.Text = "MoveUp()" Then

        ElseIf TextBox1.Text = "MoveDown()" Then

        ElseIf TextBox1.Text = "MoveLeft()" Then

        ElseIf TextBox1.Text = "MoveRight()" Then


        End If
    End Sub
End Class
