<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.theNum = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TargetLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MSGPanel = New System.Windows.Forms.Panel()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Box = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSGPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(24, 92)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 252)
        Me.ListBox1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 542)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 42)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 542)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 42)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Score :"
        '
        'theNum
        '
        Me.theNum.AutoSize = True
        Me.theNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theNum.Location = New System.Drawing.Point(465, -65)
        Me.theNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.theNum.Name = "theNum"
        Me.theNum.Size = New System.Drawing.Size(0, 31)
        Me.theNum.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.TimeLabel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TargetLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 679)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PictureBox5.Image = Global.Digit_Drop.My.Resources.Resources._274_2746272_blue_curved_arrow_pointing_down_left_arrow_pointing
        Me.PictureBox5.Location = New System.Drawing.Point(32, 395)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(62, 45)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(125, 26)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(45, 42)
        Me.TimeLabel.TabIndex = 17
        Me.TimeLabel.Text = "20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 42)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Timer : "
        '
        'TargetLabel
        '
        Me.TargetLabel.AutoSize = True
        Me.TargetLabel.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetLabel.Location = New System.Drawing.Point(15, 457)
        Me.TargetLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(92, 42)
        Me.TargetLabel.TabIndex = 15
        Me.TargetLabel.Text = "40 : 50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 383)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Target "
        '
        'MSGPanel
        '
        Me.MSGPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MSGPanel.Controls.Add(Me.LevelLabel)
        Me.MSGPanel.Controls.Add(Me.Label8)
        Me.MSGPanel.Controls.Add(Me.Label7)
        Me.MSGPanel.Controls.Add(Me.StartButton)
        Me.MSGPanel.Location = New System.Drawing.Point(105, 164)
        Me.MSGPanel.Name = "MSGPanel"
        Me.MSGPanel.Size = New System.Drawing.Size(1019, 420)
        Me.MSGPanel.TabIndex = 24
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.Location = New System.Drawing.Point(438, 13)
        Me.LevelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(155, 83)
        Me.LevelLabel.TabIndex = 19
        Me.LevelLabel.Text = "Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 42)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "You have 20 seconds to do this"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(146, 120)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(761, 42)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "You have to collect numbers so that their sum is between 00 and 00"
        '
        'StartButton
        '
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!)
        Me.StartButton.Location = New System.Drawing.Point(369, 340)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(360, 58)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(250, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(347, 104)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "You Lost :("
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 377)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(248, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(360, 58)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Round 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Digit_Drop.My.Resources.Resources.agenturleben_hannover
        Me.PictureBox3.Location = New System.Drawing.Point(948, -138)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(401, 206)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Digit_Drop.My.Resources.Resources.agenturleben_hannover
        Me.PictureBox2.Location = New System.Drawing.Point(552, -138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(401, 206)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Digit_Drop.My.Resources.Resources.agenturleben_hannover
        Me.PictureBox1.Location = New System.Drawing.Point(152, -138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Box
        '
        Me.Box.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Box.Image = Global.Digit_Drop.My.Resources.Resources.OPENBOX
        Me.Box.Location = New System.Drawing.Point(560, 676)
        Me.Box.Margin = New System.Windows.Forms.Padding(2)
        Me.Box.Name = "Box"
        Me.Box.Size = New System.Drawing.Size(109, 76)
        Me.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Box.TabIndex = 10
        Me.Box.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Digit_Drop.My.Resources.Resources.agenturleben_hannover
        Me.PictureBox4.Location = New System.Drawing.Point(-248, -138)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(401, 206)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1201, 790)
        Me.Controls.Add(Me.MSGPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Box)
        Me.Controls.Add(Me.theNum)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digit Drop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSGPanel.ResumeLayout(False)
        Me.MSGPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents theNum As Label
    Friend WithEvents Box As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TargetLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MSGPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LevelLabel As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
