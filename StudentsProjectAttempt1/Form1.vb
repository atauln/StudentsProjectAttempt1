Public Class Form1
    Dim CharacterX = Nothing
    Dim CharacterY = Nothing
    Dim Steps = 10

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

    Dim Mission3Enabled = False
    Dim Mission3Done = False

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
            Label1.Text = "MoveUp() - Moves the character " + Steps.ToString + " units up."
            RefreshTextBox("MoveUp()")
        ElseIf Value = 2 Then
            Label1.Text = "MoveDown() - Moves the character " + Steps.ToString + " units down."
            RefreshTextBox("MoveDown()")
        ElseIf Value = 3 Then
            Label1.Text = "MoveLeft() - Moves the character " + Steps.ToString + " units left."
            RefreshTextBox("MoveLeft()")
        ElseIf Value = 4 Then
            Label1.Text = "MoveRight() - Moves the character " + Steps.ToString + " units right."
            RefreshTextBox("MoveRight()")
        ElseIf Not (Pod2.Items.ToString() = "") And Value = 5 Then
            Label1.Text = NameofValue5
            RefreshTextBox(NameofValue5)
        ElseIf Not (Pod1.Items.ToString() = "") And Value = 6 Then
            Label1.Text = NameofValue6
            RefreshTextBox(NameofValue6)
        Else
            Label1.Text = ""
            RefreshTextBox("")
        End If
    End Sub

    Private Sub Command_Btn_Click(sender As Object, e As EventArgs) Handles Command_Btn.Click

        If TextBox1.Text = "MoveUp()" Then
            Character.Top -= Steps
            ListBox1.Items.Add("MoveUp()")
            RefreshCharacterLocation()
            MoveUpUsed = True
        ElseIf TextBox1.Text = "MoveDown()" Then
            Character.Top += Steps
            ListBox1.Items.Add("MoveDown()")
            RefreshCharacterLocation()
            MoveDownUsed = True
        ElseIf TextBox1.Text = "MoveLeft()" Then
            Character.Left -= Steps
            ListBox1.Items.Add("MoveLeft()")
            RefreshCharacterLocation()
            MoveLeftUsed = True
        ElseIf TextBox1.Text = "MoveRight()" Then
            Character.Left += Steps
            ListBox1.Items.Add("MoveRight()")
            RefreshCharacterLocation()
            MoveRightUsed = True
        ElseIf TextBox1.Text = NameofValue5 And Not (NameofValue5 = "") And Not (Pod2.Items.ToString() = "") Then
            Dim Numberfor5 = 0
            Dim Limitfor5 = Pod2.Items.Count - 1
            Pod2.SelectedIndex = Numberfor5
            While Numberfor5 <= Limitfor5
                Pod2.SelectedIndex = Numberfor5
                If Pod2.SelectedItem = "MoveUp()" Then
                    Character.Top -= Steps
                    RefreshCharacterLocation()
                    MoveUpUsed = True
                ElseIf Pod2.SelectedItem = "MoveDown()" Then
                    Character.Top += Steps
                    RefreshCharacterLocation()
                    MoveDownUsed = True
                ElseIf Pod2.SelectedItem = "MoveLeft()" Then
                    Character.Left -= Steps
                    RefreshCharacterLocation()
                    MoveLeftUsed = True
                ElseIf Pod2.SelectedItem = "MoveRight()" Then
                    Character.Left += Steps
                    RefreshCharacterLocation()
                    MoveRightUsed = True
                ElseIf Numberfor5 <= Limitfor5 Then
                    Exit While
                End If
                Numberfor5 += 1
            End While
            ListBox1.Items.Add(NameofValue5)
            MissionMakerPod1Used = True
        ElseIf TextBox1.Text = NameofValue6 And Not (NameofValue6 = "") And Not (Pod1.Items.ToString() = "") Then
            Dim Numberfor6 = 0
            Dim Limitfor6 = Pod1.Items.Count - 1
            Pod1.SelectedIndex = Numberfor6
            While Numberfor6 <= Limitfor6
                Pod1.SelectedIndex = Numberfor6
                If Pod1.SelectedItem = "MoveUp()" Then
                    Character.Top -= Steps
                    RefreshCharacterLocation()
                    MoveUpUsed = True
                ElseIf Pod1.SelectedItem = "MoveDown()" Then
                    Character.Top += Steps
                    RefreshCharacterLocation()
                    MoveDownUsed = True
                ElseIf Pod1.SelectedItem = "MoveLeft()" Then
                    Character.Left -= Steps
                    RefreshCharacterLocation()
                    MoveLeftUsed = True
                ElseIf Pod1.SelectedItem = "MoveRight()" Then
                    Character.Left += Steps
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
            Mission1Enabled = False
            Mission2Enabled = True
            Label4.Text = "Mission 2 - Use Pod 1 in the MissionMaker tab."
        End If

        If Mission2Done = False And MissionMakerPod1Used = True Then
            MissionComplete()
            Mission2Done = True
            Mission2Enabled = False
            Mission3Enabled = True
            Label4.Text = "Mission 3 - "
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddPod2.Click
        Pod2.Items.Add(TextPod2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles NamePod2.TextChanged
        NameofValue5 = NamePod2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddPod1.Click
        Pod1.Items.Add(TextPod1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pod1.SelectedItem.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles NamePod1.TextChanged
        NameofValue6 = NamePod1.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        fdPathLocationPicker.ShowDialog()
        Character.ImageLocation = System.IO.Path.GetFullPath(fdPathLocationPicker.FileName)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Character.Image = PictureBox2.Image
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Character.Image = PictureBox3.Image
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Character.Image = PictureBox4.Image
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Character.Image = PictureBox5.Image
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Character.Image = PictureBox6.Image
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Character.Image = PictureBox7.Image
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Character.Image = PictureBox8.Image
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Character.Image = PictureBox9.Image
    End Sub

    Private Sub PictureBoxSteps_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Character.Image = PictureBox10.Image
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Character.Image = PictureBox11.Image
    End Sub
End Class
