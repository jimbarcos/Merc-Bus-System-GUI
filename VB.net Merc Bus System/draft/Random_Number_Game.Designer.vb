<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Number_Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Random_Number_Game))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.music_on_logo = New System.Windows.Forms.PictureBox()
        Me.music_off_logo = New System.Windows.Forms.PictureBox()
        Me.dte_time = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.submit_ans = New System.Windows.Forms.Button()
        Me.reveal_lbl = New System.Windows.Forms.Label()
        Me.Lose_lbl = New System.Windows.Forms.Label()
        Me.results_lbl = New System.Windows.Forms.Label()
        Me.clue_lbl = New System.Windows.Forms.Label()
        Me.input_ans = New System.Windows.Forms.TextBox()
        Me.hrt8 = New System.Windows.Forms.PictureBox()
        Me.hrt10 = New System.Windows.Forms.PictureBox()
        Me.hrt9 = New System.Windows.Forms.PictureBox()
        Me.hrt7 = New System.Windows.Forms.PictureBox()
        Me.hrt5 = New System.Windows.Forms.PictureBox()
        Me.hrt4 = New System.Windows.Forms.PictureBox()
        Me.hrt6 = New System.Windows.Forms.PictureBox()
        Me.hrt3 = New System.Windows.Forms.PictureBox()
        Me.hrt2 = New System.Windows.Forms.PictureBox()
        Me.hrt1 = New System.Windows.Forms.PictureBox()
        Me.Win_lbl = New System.Windows.Forms.Label()
        Me.Again_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.music_on_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.music_off_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.hrt8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSalmon
        Me.Label2.Location = New System.Drawing.Point(48, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1128, 71)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "RANDOM NUMBER GAME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(1109, 451)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(125, 74)
        Me.PictureBox9.TabIndex = 44
        Me.PictureBox9.TabStop = False
        '
        'music_on_logo
        '
        Me.music_on_logo.BackColor = System.Drawing.Color.Transparent
        Me.music_on_logo.BackgroundImage = CType(resources.GetObject("music_on_logo.BackgroundImage"), System.Drawing.Image)
        Me.music_on_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.music_on_logo.Location = New System.Drawing.Point(1112, 523)
        Me.music_on_logo.MaximumSize = New System.Drawing.Size(900, 450)
        Me.music_on_logo.Name = "music_on_logo"
        Me.music_on_logo.Size = New System.Drawing.Size(122, 82)
        Me.music_on_logo.TabIndex = 45
        Me.music_on_logo.TabStop = False
        '
        'music_off_logo
        '
        Me.music_off_logo.BackColor = System.Drawing.Color.Transparent
        Me.music_off_logo.BackgroundImage = CType(resources.GetObject("music_off_logo.BackgroundImage"), System.Drawing.Image)
        Me.music_off_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.music_off_logo.Location = New System.Drawing.Point(1112, 526)
        Me.music_off_logo.Name = "music_off_logo"
        Me.music_off_logo.Size = New System.Drawing.Size(122, 82)
        Me.music_off_logo.TabIndex = 46
        Me.music_off_logo.TabStop = False
        '
        'dte_time
        '
        Me.dte_time.Enabled = True
        Me.dte_time.Interval = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Super Legend Boy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 559)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 32)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "DATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(-42, -6)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(134, 69)
        Me.PictureBox12.TabIndex = 57
        Me.PictureBox12.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Super Legend Boy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(166, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(872, 63)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Instructions: You will have 10 lives to guess the random number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{RANGE 1 - 1000}" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Super Legend Boy", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Button1.Location = New System.Drawing.Point(429, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(352, 62)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Lose_lbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.submit_ans)
        Me.GroupBox1.Controls.Add(Me.reveal_lbl)
        Me.GroupBox1.Controls.Add(Me.results_lbl)
        Me.GroupBox1.Controls.Add(Me.clue_lbl)
        Me.GroupBox1.Controls.Add(Me.input_ans)
        Me.GroupBox1.Controls.Add(Me.hrt8)
        Me.GroupBox1.Controls.Add(Me.hrt10)
        Me.GroupBox1.Controls.Add(Me.hrt9)
        Me.GroupBox1.Controls.Add(Me.hrt7)
        Me.GroupBox1.Controls.Add(Me.hrt5)
        Me.GroupBox1.Controls.Add(Me.hrt4)
        Me.GroupBox1.Controls.Add(Me.hrt6)
        Me.GroupBox1.Controls.Add(Me.hrt3)
        Me.GroupBox1.Controls.Add(Me.hrt2)
        Me.GroupBox1.Controls.Add(Me.hrt1)
        Me.GroupBox1.Controls.Add(Me.Win_lbl)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(77, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 418)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Super Legend Boy", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(466, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 41)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "-"
        Me.Label3.Visible = False
        '
        'submit_ans
        '
        Me.submit_ans.BackColor = System.Drawing.Color.Black
        Me.submit_ans.Font = New System.Drawing.Font("Super Legend Boy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_ans.ForeColor = System.Drawing.Color.LawnGreen
        Me.submit_ans.Location = New System.Drawing.Point(100, 143)
        Me.submit_ans.Name = "submit_ans"
        Me.submit_ans.Size = New System.Drawing.Size(251, 56)
        Me.submit_ans.TabIndex = 61
        Me.submit_ans.Text = "SUBMIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GUESS"
        Me.submit_ans.UseVisualStyleBackColor = False
        '
        'reveal_lbl
        '
        Me.reveal_lbl.AutoSize = True
        Me.reveal_lbl.BackColor = System.Drawing.Color.Transparent
        Me.reveal_lbl.Font = New System.Drawing.Font("Super Legend Boy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reveal_lbl.ForeColor = System.Drawing.Color.Snow
        Me.reveal_lbl.Location = New System.Drawing.Point(37, 240)
        Me.reveal_lbl.Name = "reveal_lbl"
        Me.reveal_lbl.Size = New System.Drawing.Size(349, 30)
        Me.reveal_lbl.TabIndex = 72
        Me.reveal_lbl.Text = "Random Number is"
        Me.reveal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.reveal_lbl.Visible = False
        '
        'Lose_lbl
        '
        Me.Lose_lbl.AutoSize = True
        Me.Lose_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Lose_lbl.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lose_lbl.ForeColor = System.Drawing.Color.Red
        Me.Lose_lbl.Location = New System.Drawing.Point(490, 263)
        Me.Lose_lbl.Name = "Lose_lbl"
        Me.Lose_lbl.Size = New System.Drawing.Size(536, 71)
        Me.Lose_lbl.TabIndex = 71
        Me.Lose_lbl.Text = "YOU LOSE!"
        Me.Lose_lbl.Visible = False
        '
        'results_lbl
        '
        Me.results_lbl.AutoSize = True
        Me.results_lbl.BackColor = System.Drawing.Color.Transparent
        Me.results_lbl.Font = New System.Drawing.Font("Super Legend Boy", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.results_lbl.ForeColor = System.Drawing.Color.Snow
        Me.results_lbl.Location = New System.Drawing.Point(621, 205)
        Me.results_lbl.Name = "results_lbl"
        Me.results_lbl.Size = New System.Drawing.Size(262, 39)
        Me.results_lbl.TabIndex = 61
        Me.results_lbl.Text = "RESULTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.results_lbl.Visible = False
        '
        'clue_lbl
        '
        Me.clue_lbl.AutoSize = True
        Me.clue_lbl.BackColor = System.Drawing.Color.Transparent
        Me.clue_lbl.Font = New System.Drawing.Font("Super Legend Boy", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clue_lbl.ForeColor = System.Drawing.Color.Snow
        Me.clue_lbl.Location = New System.Drawing.Point(467, 19)
        Me.clue_lbl.Name = "clue_lbl"
        Me.clue_lbl.Size = New System.Drawing.Size(169, 39)
        Me.clue_lbl.TabIndex = 61
        Me.clue_lbl.Text = "CLUE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'input_ans
        '
        Me.input_ans.AllowDrop = True
        Me.input_ans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input_ans.BackColor = System.Drawing.Color.Black
        Me.input_ans.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_ans.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.input_ans.Location = New System.Drawing.Point(19, 19)
        Me.input_ans.MaxLength = 4
        Me.input_ans.Name = "input_ans"
        Me.input_ans.Size = New System.Drawing.Size(427, 79)
        Me.input_ans.TabIndex = 70
        Me.input_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hrt8
        '
        Me.hrt8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt8.BackColor = System.Drawing.Color.Transparent
        Me.hrt8.BackgroundImage = CType(resources.GetObject("hrt8.BackgroundImage"), System.Drawing.Image)
        Me.hrt8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt8.Location = New System.Drawing.Point(729, 342)
        Me.hrt8.Name = "hrt8"
        Me.hrt8.Size = New System.Drawing.Size(95, 82)
        Me.hrt8.TabIndex = 69
        Me.hrt8.TabStop = False
        '
        'hrt10
        '
        Me.hrt10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt10.BackColor = System.Drawing.Color.Transparent
        Me.hrt10.BackgroundImage = CType(resources.GetObject("hrt10.BackgroundImage"), System.Drawing.Image)
        Me.hrt10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt10.Location = New System.Drawing.Point(931, 337)
        Me.hrt10.Name = "hrt10"
        Me.hrt10.Size = New System.Drawing.Size(95, 82)
        Me.hrt10.TabIndex = 68
        Me.hrt10.TabStop = False
        '
        'hrt9
        '
        Me.hrt9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt9.BackColor = System.Drawing.Color.Transparent
        Me.hrt9.BackgroundImage = CType(resources.GetObject("hrt9.BackgroundImage"), System.Drawing.Image)
        Me.hrt9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt9.Location = New System.Drawing.Point(830, 336)
        Me.hrt9.Name = "hrt9"
        Me.hrt9.Size = New System.Drawing.Size(95, 82)
        Me.hrt9.TabIndex = 67
        Me.hrt9.TabStop = False
        '
        'hrt7
        '
        Me.hrt7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt7.BackColor = System.Drawing.Color.Transparent
        Me.hrt7.BackgroundImage = CType(resources.GetObject("hrt7.BackgroundImage"), System.Drawing.Image)
        Me.hrt7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt7.Location = New System.Drawing.Point(628, 336)
        Me.hrt7.Name = "hrt7"
        Me.hrt7.Size = New System.Drawing.Size(95, 82)
        Me.hrt7.TabIndex = 66
        Me.hrt7.TabStop = False
        '
        'hrt5
        '
        Me.hrt5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt5.BackColor = System.Drawing.Color.Transparent
        Me.hrt5.BackgroundImage = CType(resources.GetObject("hrt5.BackgroundImage"), System.Drawing.Image)
        Me.hrt5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt5.Location = New System.Drawing.Point(426, 337)
        Me.hrt5.Name = "hrt5"
        Me.hrt5.Size = New System.Drawing.Size(95, 82)
        Me.hrt5.TabIndex = 65
        Me.hrt5.TabStop = False
        '
        'hrt4
        '
        Me.hrt4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt4.BackColor = System.Drawing.Color.Transparent
        Me.hrt4.BackgroundImage = CType(resources.GetObject("hrt4.BackgroundImage"), System.Drawing.Image)
        Me.hrt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt4.Location = New System.Drawing.Point(312, 337)
        Me.hrt4.Name = "hrt4"
        Me.hrt4.Size = New System.Drawing.Size(95, 82)
        Me.hrt4.TabIndex = 64
        Me.hrt4.TabStop = False
        '
        'hrt6
        '
        Me.hrt6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt6.BackColor = System.Drawing.Color.Transparent
        Me.hrt6.BackgroundImage = CType(resources.GetObject("hrt6.BackgroundImage"), System.Drawing.Image)
        Me.hrt6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt6.Location = New System.Drawing.Point(527, 336)
        Me.hrt6.Name = "hrt6"
        Me.hrt6.Size = New System.Drawing.Size(95, 82)
        Me.hrt6.TabIndex = 64
        Me.hrt6.TabStop = False
        '
        'hrt3
        '
        Me.hrt3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt3.BackColor = System.Drawing.Color.Transparent
        Me.hrt3.BackgroundImage = CType(resources.GetObject("hrt3.BackgroundImage"), System.Drawing.Image)
        Me.hrt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt3.Location = New System.Drawing.Point(211, 336)
        Me.hrt3.Name = "hrt3"
        Me.hrt3.Size = New System.Drawing.Size(95, 82)
        Me.hrt3.TabIndex = 63
        Me.hrt3.TabStop = False
        '
        'hrt2
        '
        Me.hrt2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt2.BackColor = System.Drawing.Color.Transparent
        Me.hrt2.BackgroundImage = CType(resources.GetObject("hrt2.BackgroundImage"), System.Drawing.Image)
        Me.hrt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt2.Location = New System.Drawing.Point(110, 336)
        Me.hrt2.Name = "hrt2"
        Me.hrt2.Size = New System.Drawing.Size(95, 82)
        Me.hrt2.TabIndex = 62
        Me.hrt2.TabStop = False
        '
        'hrt1
        '
        Me.hrt1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.hrt1.BackColor = System.Drawing.Color.Transparent
        Me.hrt1.BackgroundImage = CType(resources.GetObject("hrt1.BackgroundImage"), System.Drawing.Image)
        Me.hrt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hrt1.Location = New System.Drawing.Point(9, 336)
        Me.hrt1.Name = "hrt1"
        Me.hrt1.Size = New System.Drawing.Size(95, 82)
        Me.hrt1.TabIndex = 61
        Me.hrt1.TabStop = False
        '
        'Win_lbl
        '
        Me.Win_lbl.AutoSize = True
        Me.Win_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Win_lbl.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Win_lbl.ForeColor = System.Drawing.Color.Orange
        Me.Win_lbl.Location = New System.Drawing.Point(540, 268)
        Me.Win_lbl.Name = "Win_lbl"
        Me.Win_lbl.Size = New System.Drawing.Size(443, 71)
        Me.Win_lbl.TabIndex = 61
        Me.Win_lbl.Text = "YOU WIN!"
        Me.Win_lbl.Visible = False
        '
        'Again_btn
        '
        Me.Again_btn.BackColor = System.Drawing.Color.Black
        Me.Again_btn.Font = New System.Drawing.Font("Super Legend Boy", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Again_btn.ForeColor = System.Drawing.Color.LawnGreen
        Me.Again_btn.Location = New System.Drawing.Point(429, 526)
        Me.Again_btn.Name = "Again_btn"
        Me.Again_btn.Size = New System.Drawing.Size(352, 61)
        Me.Again_btn.TabIndex = 61
        Me.Again_btn.Text = "RETRY"
        Me.Again_btn.UseVisualStyleBackColor = False
        '
        'Random_Number_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.music_on_logo)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.music_off_logo)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Again_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "Random_Number_Game"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random_Number_Game"
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.music_on_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.music_off_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.hrt8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents music_on_logo As PictureBox
    Friend WithEvents music_off_logo As PictureBox
    Public WithEvents dte_time As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents hrt8 As PictureBox
    Friend WithEvents hrt10 As PictureBox
    Friend WithEvents hrt9 As PictureBox
    Friend WithEvents hrt7 As PictureBox
    Friend WithEvents hrt5 As PictureBox
    Friend WithEvents hrt4 As PictureBox
    Friend WithEvents hrt6 As PictureBox
    Friend WithEvents hrt3 As PictureBox
    Friend WithEvents hrt2 As PictureBox
    Friend WithEvents hrt1 As PictureBox
    Friend WithEvents reveal_lbl As Label
    Friend WithEvents Lose_lbl As Label
    Friend WithEvents results_lbl As Label
    Friend WithEvents clue_lbl As Label
    Friend WithEvents input_ans As TextBox
    Friend WithEvents Win_lbl As Label
    Friend WithEvents submit_ans As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Again_btn As Button
End Class
