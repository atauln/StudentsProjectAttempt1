Public Class Form1
    Dim CharacterX = Nothing
    Dim CharacterY = Nothing

    Dim MoveUpUsed = False
    Dim MoveDownUsed = False
    Dim MoveLeftUsed = False
    Dim MoveRightUsed = False
    Dim Mission1Enabled = True

    Dim NameofValue5 = ""

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
        ElseIf Not (ListBox2.Items.ToString() = "") And Value = 5 Then
            Label1.Text = NameofValue5
            RefreshTextBox(NameofValue5)
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
        ElseIf TextBox1.Text = NameofValue5 And Not (NameofValue5 = "") And Not (ListBox2.Items.ToString() = "") Then
            Dim Numberfor5 = 0
            Dim Limitfor5 = ListBox2.Items.Count - 1
            ListBox2.SelectedIndex = Numberfor5
            While Numberfor5 <= Limitfor5
                ListBox2.SelectedIndex = Numberfor5
                If ListBox2.SelectedItem = "MoveUp()" Then
                    Character.Top -= 10
                    ListBox1.Items.Add("MoveUp()")
                    RefreshCharacterLocation()
                    MoveUpUsed = True
                ElseIf ListBox2.SelectedItem = "MoveDown()" Then
                    Character.Top += 10
                    ListBox1.Items.Add("MoveDown()")
                    RefreshCharacterLocation()
                    MoveDownUsed = True
                ElseIf ListBox2.SelectedItem = "MoveLeft()" Then
                    Character.Left -= 10
                    ListBox1.Items.Add("MoveLeft()")
                    RefreshCharacterLocation()
                    MoveLeftUsed = True
                ElseIf ListBox2.SelectedItem = "MoveRight()" Then
                    Character.Left += 10
                    ListBox1.Items.Add("MoveRight()")
                    RefreshCharacterLocation()
                    MoveRightUsed = True
                ElseIf Numberfor5 <= Limitfor5 Then
                    Exit While
                End If
                Numberfor5 += 1
            End While
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        NameofValue5 = TextBox3.Text
    End Sub
End Class
