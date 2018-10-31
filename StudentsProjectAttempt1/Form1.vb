Public Class Form1
    Dim CharacterX = Nothing
    Dim CharacterY = Nothing

    Dim MoveUpUsed = False
    Dim MoveDownUsed = False
    Dim MoveLeftUsed = False
    Dim MoveRightUsed = False
    Dim Mission1Enabled = True
    Dim Mission1Done = False

    Dim MissionMakerPod1Used = False
    Dim MissionMakerPod2Used = False
    Dim Mission2Enabled = False
    Dim Mission2Done = False

    Dim NameofValue5 = ""
    Dim NameofValue6 = ""

    Sub RefreshCharacterLocation()
        CharacterX = Character.Location.X
        CharacterY = Character.Location.Y
        Label2.Text = CharacterX
        Label3.Text = 500 - CharacterY
    End Sub

    Sub MissionComplete()
        PictureBox1.Visible = True
        Mission1Check.Enabled = True
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
        ElseIf Not (ListBox3.Items.ToString() = "") And Value = 6 Then
            Label1.Text = NameofValue6
            RefreshTextBox(NameofValue6)
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
                    RefreshCharacterLocation()
                    MoveUpUsed = True
                ElseIf ListBox2.SelectedItem = "MoveDown()" Then
                    Character.Top += 10
                    RefreshCharacterLocation()
                    MoveDownUsed = True
                ElseIf ListBox2.SelectedItem = "MoveLeft()" Then
                    Character.Left -= 10
                    RefreshCharacterLocation()
                    MoveLeftUsed = True
                ElseIf ListBox2.SelectedItem = "MoveRight()" Then
                    Character.Left += 10
                    RefreshCharacterLocation()
                    MoveRightUsed = True
                ElseIf Numberfor5 <= Limitfor5 Then
                    Exit While
                End If
                Numberfor5 += 1
            End While
            ListBox1.Items.Add(NameofValue5)
            MissionMakerPod1Used = True
        ElseIf TextBox1.Text = NameofValue6 And Not (NameofValue6 = "") And Not (ListBox3.Items.ToString() = "") Then
            Dim Numberfor6 = 0
            Dim Limitfor6 = ListBox3.Items.Count - 1
            ListBox3.SelectedIndex = Numberfor6
            While Numberfor6 <= Limitfor6
                ListBox3.SelectedIndex = Numberfor6
                If ListBox3.SelectedItem = "MoveUp()" Then
                    Character.Top -= 10
                    RefreshCharacterLocation()
                    MoveUpUsed = True
                ElseIf ListBox3.SelectedItem = "MoveDown()" Then
                    Character.Top += 10
                    RefreshCharacterLocation()
                    MoveDownUsed = True
                ElseIf ListBox3.SelectedItem = "MoveLeft()" Then
                    Character.Left -= 10
                    RefreshCharacterLocation()
                    MoveLeftUsed = True
                ElseIf ListBox3.SelectedItem = "MoveRight()" Then
                    Character.Left += 10
                    RefreshCharacterLocation()
                    MoveRightUsed = True
                ElseIf Numberfor6 <= Limitfor6 Then
                    Exit While
                End If
                Numberfor6 += 1
            End While
            ListBox1.Items.Add(NameofValue6)
            MissionMakerPod2Used = True
        End If

        If MoveRightUsed = True And MoveLeftUsed = True And MoveUpUsed = True And MoveDownUsed = True And Mission1Enabled = True And Mission1Done = False Then
            MissionComplete()
            Mission1Done = True
            Label4.Text = "Mission 2 - Use Pod 1 in the MissionMaker tab."
        End If

        If Mission2Done = False And MissionMakerPod1Used = True Then
            MissionComplete()
            Mission2Done = True
            Label4.Text = "Mission 3 -"
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
        ListBox1.SelectedItem.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        NameofValue5 = TextBox3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox3.Items.Add(TextBox5.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox3.SelectedItem.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        NameofValue6 = TextBox4.Text
    End Sub

End Class
