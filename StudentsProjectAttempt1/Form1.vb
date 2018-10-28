Public Class Form1
    Dim CharacterX = Nothing
    Dim CharacterY = Nothing
    Sub RefreshCharacterLocation()
        CharacterX = Character.Location.X
        CharacterY = Character.Location.Y
        Label2.Text = CharacterX
        Label3.Text = 500 - CharacterY
    End Sub

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
            Character.Top -= 10
            ListBox1.Items.Add("MoveUp()")
            RefreshCharacterLocation()
        ElseIf TextBox1.Text = "MoveDown()" Then
            Character.Top += 10
            ListBox1.Items.Add("MoveDown()")
            RefreshCharacterLocation()
        ElseIf TextBox1.Text = "MoveLeft()" Then
            Character.Left -= 10
            ListBox1.Items.Add("MoveLeft()")
            RefreshCharacterLocation()
        ElseIf TextBox1.Text = "MoveRight()" Then
            Character.Left += 10
            ListBox1.Items.Add("MoveRight()")
            RefreshCharacterLocation()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem.ToString()
    End Sub
End Class
