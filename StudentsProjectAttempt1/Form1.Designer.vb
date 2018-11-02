<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Command_Btn = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Character = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Mission1Check = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Pod1 = New System.Windows.Forms.ListBox()
        Me.NamePod1 = New System.Windows.Forms.TextBox()
        Me.Pod2 = New System.Windows.Forms.ListBox()
        Me.TextPod1 = New System.Windows.Forms.TextBox()
        Me.TextPod2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NamePod2 = New System.Windows.Forms.TextBox()
        Me.btnAddPod1 = New System.Windows.Forms.Button()
        Me.BtnAddPod2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Question1Response = New System.Windows.Forms.TextBox()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClearSurv = New System.Windows.Forms.Button()
        Me.fdPathLocationPicker = New System.Windows.Forms.OpenFileDialog()
        Me.Question2 = New System.Windows.Forms.Label()
        Me.txtQuestion2 = New System.Windows.Forms.TextBox()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.lblNameQ = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 301)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(570, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Command_Btn
        '
        Me.Command_Btn.Location = New System.Drawing.Point(494, 327)
        Me.Command_Btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Command_Btn.Name = "Command_Btn"
        Me.Command_Btn.Size = New System.Drawing.Size(80, 25)
        Me.Command_Btn.TabIndex = 1
        Me.Command_Btn.Text = "Command"
        Me.Command_Btn.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 332)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 332)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 19)
        Me.Label1.TabIndex = 3
        '
        'Character
        '
        Me.Character.Image = CType(resources.GetObject("Character.Image"), System.Drawing.Image)
        Me.Character.Location = New System.Drawing.Point(262, 122)
        Me.Character.Margin = New System.Windows.Forms.Padding(2)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(50, 50)
        Me.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character.TabIndex = 4
        Me.Character.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(497, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "350"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "350"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(484, 33)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(91, 251)
        Me.ListBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(478, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mission 1 - Try out all of the controls. Get arranged with the environment."
        '
        'Mission1Check
        '
        Me.Mission1Check.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(249, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 380)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Command_Btn)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.NumericUpDown1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Character)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(575, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Pod1)
        Me.TabPage2.Controls.Add(Me.NamePod1)
        Me.TabPage2.Controls.Add(Me.Pod2)
        Me.TabPage2.Controls.Add(Me.TextPod1)
        Me.TabPage2.Controls.Add(Me.TextPod2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.NamePod2)
        Me.TabPage2.Controls.Add(Me.btnAddPod1)
        Me.TabPage2.Controls.Add(Me.BtnAddPod2)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(575, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mixed Maker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Pod1
        '
        Me.Pod1.FormattingEnabled = True
        Me.Pod1.Location = New System.Drawing.Point(34, 76)
        Me.Pod1.Margin = New System.Windows.Forms.Padding(2)
        Me.Pod1.Name = "Pod1"
        Me.Pod1.Size = New System.Drawing.Size(120, 212)
        Me.Pod1.TabIndex = 5
        '
        'NamePod1
        '
        Me.NamePod1.Location = New System.Drawing.Point(34, 321)
        Me.NamePod1.Margin = New System.Windows.Forms.Padding(2)
        Me.NamePod1.Name = "NamePod1"
        Me.NamePod1.Size = New System.Drawing.Size(118, 20)
        Me.NamePod1.TabIndex = 9
        '
        'Pod2
        '
        Me.Pod2.FormattingEnabled = True
        Me.Pod2.Location = New System.Drawing.Point(186, 76)
        Me.Pod2.Margin = New System.Windows.Forms.Padding(2)
        Me.Pod2.Name = "Pod2"
        Me.Pod2.Size = New System.Drawing.Size(120, 212)
        Me.Pod2.TabIndex = 0
        '
        'TextPod1
        '
        Me.TextPod1.Location = New System.Drawing.Point(34, 19)
        Me.TextPod1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPod1.Name = "TextPod1"
        Me.TextPod1.Size = New System.Drawing.Size(120, 20)
        Me.TextPod1.TabIndex = 6
        '
        'TextPod2
        '
        Me.TextPod2.Location = New System.Drawing.Point(186, 19)
        Me.TextPod2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPod2.Name = "TextPod2"
        Me.TextPod2.Size = New System.Drawing.Size(120, 20)
        Me.TextPod2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 292)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NamePod2
        '
        Me.NamePod2.Location = New System.Drawing.Point(186, 321)
        Me.NamePod2.Margin = New System.Windows.Forms.Padding(2)
        Me.NamePod2.Name = "NamePod2"
        Me.NamePod2.Size = New System.Drawing.Size(118, 20)
        Me.NamePod2.TabIndex = 4
        '
        'btnAddPod1
        '
        Me.btnAddPod1.Location = New System.Drawing.Point(34, 45)
        Me.btnAddPod1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddPod1.Name = "btnAddPod1"
        Me.btnAddPod1.Size = New System.Drawing.Size(118, 24)
        Me.btnAddPod1.TabIndex = 7
        Me.btnAddPod1.Text = "Add"
        Me.btnAddPod1.UseVisualStyleBackColor = True
        '
        'BtnAddPod2
        '
        Me.BtnAddPod2.Location = New System.Drawing.Point(186, 45)
        Me.BtnAddPod2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddPod2.Name = "BtnAddPod2"
        Me.BtnAddPod2.Size = New System.Drawing.Size(118, 24)
        Me.BtnAddPod2.TabIndex = 2
        Me.BtnAddPod2.Text = "Add"
        Me.BtnAddPod2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 292)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtNameInput)
        Me.TabPage3.Controls.Add(Me.lblNameQ)
        Me.TabPage3.Controls.Add(Me.txtQuestion2)
        Me.TabPage3.Controls.Add(Me.Question2)
        Me.TabPage3.Controls.Add(Me.Question1Response)
        Me.TabPage3.Controls.Add(Me.lblQuestion1)
        Me.TabPage3.Controls.Add(Me.btnSubmit)
        Me.TabPage3.Controls.Add(Me.btnClearSurv)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(575, 354)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Survey"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Question1Response
        '
        Me.Question1Response.Location = New System.Drawing.Point(19, 73)
        Me.Question1Response.Name = "Question1Response"
        Me.Question1Response.Size = New System.Drawing.Size(100, 20)
        Me.Question1Response.TabIndex = 4
        '
        'lblQuestion1
        '
        Me.lblQuestion1.Location = New System.Drawing.Point(16, 51)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(546, 19)
        Me.lblQuestion1.TabIndex = 3
        Me.lblQuestion1.Text = "How well do you think that this program helped you?"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(284, 321)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 33)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClearSurv
        '
        Me.btnClearSurv.Location = New System.Drawing.Point(128, 321)
        Me.btnClearSurv.Name = "btnClearSurv"
        Me.btnClearSurv.Size = New System.Drawing.Size(150, 33)
        Me.btnClearSurv.TabIndex = 1
        Me.btnClearSurv.Text = "Clear Survey"
        Me.btnClearSurv.UseVisualStyleBackColor = True
        '
        'fdPathLocationPicker
        '
        Me.fdPathLocationPicker.FileName = "OpenFileDialog1"
        '
        'Question2
        '
        Me.Question2.Location = New System.Drawing.Point(16, 105)
        Me.Question2.Name = "Question2"
        Me.Question2.Size = New System.Drawing.Size(546, 19)
        Me.Question2.TabIndex = 5
        Me.Question2.Text = "How well do you think that this program helped you?"
        '
        'txtQuestion2
        '
        Me.txtQuestion2.Location = New System.Drawing.Point(19, 127)
        Me.txtQuestion2.Name = "txtQuestion2"
        Me.txtQuestion2.Size = New System.Drawing.Size(100, 20)
        Me.txtQuestion2.TabIndex = 6
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(19, 187)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNameInput.TabIndex = 8
        '
        'lblNameQ
        '
        Me.lblNameQ.Location = New System.Drawing.Point(16, 165)
        Me.lblNameQ.Name = "lblNameQ"
        Me.lblNameQ.Size = New System.Drawing.Size(546, 19)
        Me.lblNameQ.TabIndex = 7
        Me.lblNameQ.Text = "What is your full name?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 380)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Command_Btn As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Character As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Mission1Check As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnAddPod2 As Button
    Friend WithEvents TextPod2 As TextBox
    Friend WithEvents Pod2 As ListBox
    Friend WithEvents NamePod2 As TextBox
    Friend WithEvents NamePod1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAddPod1 As Button
    Friend WithEvents TextPod1 As TextBox
    Friend WithEvents Pod1 As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnClearSurv As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents Question1Response As TextBox
    Friend WithEvents fdPathLocationPicker As OpenFileDialog
    Friend WithEvents txtQuestion2 As TextBox
    Friend WithEvents Question2 As Label
    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents lblNameQ As Label
End Class
