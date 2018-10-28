﻿Public Class Form1
    Dim CharacterX = Nothing
    Dim CharacterY = Nothing

    Dim MoveUpUsed = False
    Dim MoveDownUsed = False
    Dim MoveLeftUsed = False
    Dim MoveRightUsed = False
    Dim Mission1Enabled = True

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
            MoveUpUsed = True
        ElseIf TextBox1.Text = "MoveDown()" Then
            Character.Top += 10
            ListBox1.Items.Add("MoveDown()")
            RefreshCharacterLocation()
            MoveDownUsed = True
        ElseIf TextBox1.Text = "MoveLeft()" Then
            Character.Left -= 10
            ListBox1.Items.Add("MoveLeft()")
            RefreshCharacterLocation()
            MoveLeftUsed = True
        ElseIf TextBox1.Text = "MoveRight()" Then
            Character.Left += 10
            ListBox1.Items.Add("MoveRight()")
            RefreshCharacterLocation()
            MoveRightUsed = True
        End If

        If MoveRightUsed = True And MoveLeftUsed = True And MoveUpUsed = True And MoveDownUsed = True And Mission1Enabled = True Then
            PictureBox1.Visible = True
            Mission1Check.Enabled = True
            Label4.Text = "Mission 2 - "
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub Mission1Check_Tick(sender As Object, e As EventArgs) Handles Mission1Check.Tick
        Mission1Check.Enabled = False
        PictureBox1.Visible = False
    End Sub
End Class
