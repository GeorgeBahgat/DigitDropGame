<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SortingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SortingForm))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SortingTime = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.msgPanel = New System.Windows.Forms.Panel()
        Me.StartPicture = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ArrowPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msgPanel.SuspendLayout()
        CType(Me.StartPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 46
        Me.ListBox1.Items.AddRange(New Object() {"55", "16", "13", "120", "12", "11", "13", "50", "222", "320"})
        Me.ListBox1.Location = New System.Drawing.Point(685, 18)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(143, 556)
        Me.ListBox1.TabIndex = 2
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label0.Location = New System.Drawing.Point(35, 59)
        Me.Label0.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(191, 83)
        Me.Label0.TabIndex = 20
        Me.Label0.Text = "Timer :"
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 46
        Me.ListBox2.Items.AddRange(New Object() {"55", "16", "13", "120", "12", "11", "13", "50", "222", "100"})
        Me.ListBox2.Location = New System.Drawing.Point(933, 20)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(143, 556)
        Me.ListBox2.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 368)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Up and down arrows to move"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(99, 488)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 28)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Space bar to swap"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SortingTime)
        Me.Panel1.Controls.Add(Me.Label0)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(-13, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 623)
        Me.Panel1.TabIndex = 26
        '
        'SortingTime
        '
        Me.SortingTime.AutoSize = True
        Me.SortingTime.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortingTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SortingTime.Location = New System.Drawing.Point(204, 59)
        Me.SortingTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SortingTime.Name = "SortingTime"
        Me.SortingTime.Size = New System.Drawing.Size(62, 83)
        Me.SortingTime.TabIndex = 26
        Me.SortingTime.Text = "3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Digit_Drop.My.Resources.Resources.arrwo
        Me.PictureBox2.Location = New System.Drawing.Point(113, 294)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Digit_Drop.My.Resources.Resources.d52ee173147d4ef
        Me.PictureBox3.Location = New System.Drawing.Point(74, 436)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(194, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'msgPanel
        '
        Me.msgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.msgPanel.Controls.Add(Me.StartPicture)
        Me.msgPanel.Controls.Add(Me.Label4)
        Me.msgPanel.Controls.Add(Me.PictureBox4)
        Me.msgPanel.Controls.Add(Me.Label5)
        Me.msgPanel.Controls.Add(Me.PictureBox5)
        Me.msgPanel.Controls.Add(Me.Label3)
        Me.msgPanel.Location = New System.Drawing.Point(83, 105)
        Me.msgPanel.Name = "msgPanel"
        Me.msgPanel.Size = New System.Drawing.Size(725, 360)
        Me.msgPanel.TabIndex = 27
        '
        'StartPicture
        '
        Me.StartPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartPicture.Image = Global.Digit_Drop.My.Resources.Resources._54b5ab9b34da8a31
        Me.StartPicture.Location = New System.Drawing.Point(278, 287)
        Me.StartPicture.Name = "StartPicture"
        Me.StartPicture.Size = New System.Drawing.Size(159, 51)
        Me.StartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StartPicture.TabIndex = 30
        Me.StartPicture.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(123, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 28)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Space bar to swap"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Digit_Drop.My.Resources.Resources.arrwo
        Me.PictureBox4.Location = New System.Drawing.Point(475, 122)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(117, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(413, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 28)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Up and down arrows to move"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Digit_Drop.My.Resources.Resources.d52ee173147d4ef
        Me.PictureBox5.Location = New System.Drawing.Point(101, 152)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(194, 37)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(53, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 42)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Use the Bubble Sort to Sort these items in 12 seconds"
        '
        'ArrowPic
        '
        Me.ArrowPic.Image = Global.Digit_Drop.My.Resources.Resources.green_neon_arrow_4
        Me.ArrowPic.Location = New System.Drawing.Point(598, 18)
        Me.ArrowPic.Margin = New System.Windows.Forms.Padding(2)
        Me.ArrowPic.Name = "ArrowPic"
        Me.ArrowPic.Size = New System.Drawing.Size(76, 46)
        Me.ArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowPic.TabIndex = 3
        Me.ArrowPic.TabStop = False
        '
        'SortingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 592)
        Me.Controls.Add(Me.msgPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ArrowPic)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SortingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digit Drop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msgPanel.ResumeLayout(False)
        Me.msgPanel.PerformLayout()
        CType(Me.StartPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ArrowPic As PictureBox
    Friend WithEvents Label0 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SortingTime As Label
    Friend WithEvents msgPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StartPicture As PictureBox
End Class
