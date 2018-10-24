Public Class Form1
    Sub RefreshTextBox(f)
        TextBox1.Text = f
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim Value = NumericUpDown1.Value
        If Value = 1 Then
            Label1.Text = "MoveUp() - Moves the character a certain amount of units up."
            RefreshTextBox("MoveUp()")
        ElseIf Value = 2 Then
            Label1.Text = "MoveDown() - Moves the character a certain amount of units down."
            RefreshTextBox("MoveDown()")
        ElseIf Value = 3 Then
            Label1.Text = "MoveLeft() - Moves the character a certain amount of units left."
            RefreshTextBox("MoveLeft()")
        ElseIf Value = 4 Then
            Label1.Text = "MoveRight() - Moves the character a certain amount of units right."
            RefreshTextBox("MoveRight()")
        Else
            Label1.Text = ""
            RefreshTextBox("")
        End If
    End Sub

    Private Sub Command_Btn_Click(sender As Object, e As EventArgs) Handles Command_Btn.Click

        If TextBox1.Text = "MoveUp()" Then
            PictureBox1.Top -= 10
        ElseIf TextBox1.Text = "MoveDown()" Then
            PictureBox1.Top += 10
        ElseIf TextBox1.Text = "MoveLeft()" Then
            PictureBox1.Left -= 10
        ElseIf TextBox1.Text = "MoveRight()" Then
            PictureBox1.Left += 10

        End If
    End Sub

End Class
