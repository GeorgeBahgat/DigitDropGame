<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LevelsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelsForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Level2Button = New System.Windows.Forms.Button()
        Me.Level3Button = New System.Windows.Forms.Button()
        Me.LockPicture2 = New System.Windows.Forms.PictureBox()
        Me.LockPicture1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LockPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LockPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(280, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(370, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Level 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Level2Button
        '
        Me.Level2Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Level2Button.Enabled = False
        Me.Level2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Level2Button.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level2Button.ForeColor = System.Drawing.Color.Cyan
        Me.Level2Button.Location = New System.Drawing.Point(280, 342)
        Me.Level2Button.Name = "Level2Button"
        Me.Level2Button.Size = New System.Drawing.Size(370, 64)
        Me.Level2Button.TabIndex = 2
        Me.Level2Button.Text = "Level 2"
        Me.Level2Button.UseVisualStyleBackColor = True
        '
        'Level3Button
        '
        Me.Level3Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Level3Button.Enabled = False
        Me.Level3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Level3Button.Font = New System.Drawing.Font(" Abdoullah Ashgar EL-kharef", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level3Button.ForeColor = System.Drawing.Color.Cyan
        Me.Level3Button.Location = New System.Drawing.Point(280, 464)
        Me.Level3Button.Name = "Level3Button"
        Me.Level3Button.Size = New System.Drawing.Size(370, 64)
        Me.Level3Button.TabIndex = 3
        Me.Level3Button.Text = "Level 3"
        Me.Level3Button.UseVisualStyleBackColor = True
        '
        'LockPicture2
        '
        Me.LockPicture2.Image = Global.Digit_Drop.My.Resources.Resources.Capture
        Me.LockPicture2.Location = New System.Drawing.Point(181, 464)
        Me.LockPicture2.Name = "LockPicture2"
        Me.LockPicture2.Size = New System.Drawing.Size(55, 64)
        Me.LockPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LockPicture2.TabIndex = 5
        Me.LockPicture2.TabStop = False
        '
        'LockPicture1
        '
        Me.LockPicture1.Image = Global.Digit_Drop.My.Resources.Resources.Capture
        Me.LockPicture1.Location = New System.Drawing.Point(181, 337)
        Me.LockPicture1.Name = "LockPicture1"
        Me.LockPicture1.Size = New System.Drawing.Size(55, 64)
        Me.LockPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LockPicture1.TabIndex = 4
        Me.LockPicture1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Digit_Drop.My.Resources.Resources.levels
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(914, 614)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LevelsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 607)
        Me.Controls.Add(Me.LockPicture2)
        Me.Controls.Add(Me.LockPicture1)
        Me.Controls.Add(Me.Level3Button)
        Me.Controls.Add(Me.Level2Button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LevelsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digit Drop"
        CType(Me.LockPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LockPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Level2Button As Button
    Friend WithEvents Level3Button As Button
    Friend WithEvents LockPicture1 As PictureBox
    Friend WithEvents LockPicture2 As PictureBox
End Class
