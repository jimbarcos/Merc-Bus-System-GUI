<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rock_Paper_Scissor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rock_Paper_Scissor))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.music_on_logo = New System.Windows.Forms.PictureBox()
        Me.music_off_logo = New System.Windows.Forms.PictureBox()
        Me.dte_time = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.scissor_border2 = New System.Windows.Forms.PictureBox()
        Me.scissor_border4 = New System.Windows.Forms.PictureBox()
        Me.scissor_border1 = New System.Windows.Forms.PictureBox()
        Me.scissor_border3 = New System.Windows.Forms.PictureBox()
        Me.paper_border2 = New System.Windows.Forms.PictureBox()
        Me.paper_border4 = New System.Windows.Forms.PictureBox()
        Me.paper_border1 = New System.Windows.Forms.PictureBox()
        Me.paper_border3 = New System.Windows.Forms.PictureBox()
        Me.rock_border3 = New System.Windows.Forms.PictureBox()
        Me.rock_border1 = New System.Windows.Forms.PictureBox()
        Me.rock_border2 = New System.Windows.Forms.PictureBox()
        Me.rock_border4 = New System.Windows.Forms.PictureBox()
        Me.QSTMARK = New System.Windows.Forms.PictureBox()
        Me.ROCK_AI = New System.Windows.Forms.PictureBox()
        Me.SCISSOR_AI = New System.Windows.Forms.PictureBox()
        Me.PAPER_AI = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ROCK_PIC = New System.Windows.Forms.PictureBox()
        Me.SCISSOR_PIC = New System.Windows.Forms.PictureBox()
        Me.PAPER_PIC = New System.Windows.Forms.PictureBox()
        Me.submit_ans = New System.Windows.Forms.Button()
        Me.results_lbl = New System.Windows.Forms.Label()
        Me.resulta = New System.Windows.Forms.Label()
        Me.win_lbl = New System.Windows.Forms.Label()
        Me.lose_lbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.music_on_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.music_off_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.scissor_border2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissor_border4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissor_border1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissor_border3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paper_border2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paper_border4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paper_border1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paper_border3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rock_border3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rock_border1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rock_border2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rock_border4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QSTMARK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROCK_AI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCISSOR_AI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAPER_AI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROCK_PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCISSOR_PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAPER_PIC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(1100, 71)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ROCK PAPER SCISSOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(-42, -6)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(134, 69)
        Me.PictureBox12.TabIndex = 58
        Me.PictureBox12.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Super Legend Boy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(181, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 42)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Instructions: Choose your weapon against a Computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "DATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(1109, 451)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(125, 74)
        Me.PictureBox9.TabIndex = 61
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
        Me.music_on_logo.TabIndex = 62
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
        Me.music_off_logo.TabIndex = 63
        Me.music_off_logo.TabStop = False
        '
        'dte_time
        '
        Me.dte_time.Enabled = True
        Me.dte_time.Interval = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.scissor_border2)
        Me.GroupBox1.Controls.Add(Me.scissor_border4)
        Me.GroupBox1.Controls.Add(Me.scissor_border1)
        Me.GroupBox1.Controls.Add(Me.scissor_border3)
        Me.GroupBox1.Controls.Add(Me.paper_border2)
        Me.GroupBox1.Controls.Add(Me.paper_border4)
        Me.GroupBox1.Controls.Add(Me.paper_border1)
        Me.GroupBox1.Controls.Add(Me.paper_border3)
        Me.GroupBox1.Controls.Add(Me.rock_border3)
        Me.GroupBox1.Controls.Add(Me.rock_border1)
        Me.GroupBox1.Controls.Add(Me.rock_border2)
        Me.GroupBox1.Controls.Add(Me.rock_border4)
        Me.GroupBox1.Controls.Add(Me.QSTMARK)
        Me.GroupBox1.Controls.Add(Me.ROCK_AI)
        Me.GroupBox1.Controls.Add(Me.SCISSOR_AI)
        Me.GroupBox1.Controls.Add(Me.PAPER_AI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ROCK_PIC)
        Me.GroupBox1.Controls.Add(Me.submit_ans)
        Me.GroupBox1.Controls.Add(Me.PAPER_PIC)
        Me.GroupBox1.Controls.Add(Me.SCISSOR_PIC)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1030, 349)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'scissor_border2
        '
        Me.scissor_border2.BackColor = System.Drawing.Color.White
        Me.scissor_border2.Location = New System.Drawing.Point(788, 152)
        Me.scissor_border2.Name = "scissor_border2"
        Me.scissor_border2.Size = New System.Drawing.Size(191, 10)
        Me.scissor_border2.TabIndex = 90
        Me.scissor_border2.TabStop = False
        '
        'scissor_border4
        '
        Me.scissor_border4.BackColor = System.Drawing.Color.White
        Me.scissor_border4.Location = New System.Drawing.Point(788, 19)
        Me.scissor_border4.Name = "scissor_border4"
        Me.scissor_border4.Size = New System.Drawing.Size(189, 10)
        Me.scissor_border4.TabIndex = 89
        Me.scissor_border4.TabStop = False
        '
        'scissor_border1
        '
        Me.scissor_border1.BackColor = System.Drawing.Color.White
        Me.scissor_border1.Location = New System.Drawing.Point(967, 19)
        Me.scissor_border1.Name = "scissor_border1"
        Me.scissor_border1.Size = New System.Drawing.Size(10, 143)
        Me.scissor_border1.TabIndex = 88
        Me.scissor_border1.TabStop = False
        '
        'scissor_border3
        '
        Me.scissor_border3.BackColor = System.Drawing.Color.White
        Me.scissor_border3.Location = New System.Drawing.Point(788, 19)
        Me.scissor_border3.Name = "scissor_border3"
        Me.scissor_border3.Size = New System.Drawing.Size(10, 141)
        Me.scissor_border3.TabIndex = 87
        Me.scissor_border3.TabStop = False
        '
        'paper_border2
        '
        Me.paper_border2.BackColor = System.Drawing.Color.White
        Me.paper_border2.Location = New System.Drawing.Point(405, 143)
        Me.paper_border2.Name = "paper_border2"
        Me.paper_border2.Size = New System.Drawing.Size(188, 10)
        Me.paper_border2.TabIndex = 86
        Me.paper_border2.TabStop = False
        '
        'paper_border4
        '
        Me.paper_border4.BackColor = System.Drawing.Color.White
        Me.paper_border4.Location = New System.Drawing.Point(405, 11)
        Me.paper_border4.Name = "paper_border4"
        Me.paper_border4.Size = New System.Drawing.Size(188, 10)
        Me.paper_border4.TabIndex = 85
        Me.paper_border4.TabStop = False
        '
        'paper_border1
        '
        Me.paper_border1.BackColor = System.Drawing.Color.White
        Me.paper_border1.Location = New System.Drawing.Point(583, 11)
        Me.paper_border1.Name = "paper_border1"
        Me.paper_border1.Size = New System.Drawing.Size(10, 141)
        Me.paper_border1.TabIndex = 84
        Me.paper_border1.TabStop = False
        '
        'paper_border3
        '
        Me.paper_border3.BackColor = System.Drawing.Color.White
        Me.paper_border3.Location = New System.Drawing.Point(405, 11)
        Me.paper_border3.Name = "paper_border3"
        Me.paper_border3.Size = New System.Drawing.Size(10, 137)
        Me.paper_border3.TabIndex = 83
        Me.paper_border3.TabStop = False
        '
        'rock_border3
        '
        Me.rock_border3.BackColor = System.Drawing.Color.White
        Me.rock_border3.Location = New System.Drawing.Point(36, 140)
        Me.rock_border3.Name = "rock_border3"
        Me.rock_border3.Size = New System.Drawing.Size(188, 12)
        Me.rock_border3.TabIndex = 82
        Me.rock_border3.TabStop = False
        '
        'rock_border1
        '
        Me.rock_border1.BackColor = System.Drawing.Color.White
        Me.rock_border1.Location = New System.Drawing.Point(37, 9)
        Me.rock_border1.Name = "rock_border1"
        Me.rock_border1.Size = New System.Drawing.Size(180, 10)
        Me.rock_border1.TabIndex = 81
        Me.rock_border1.TabStop = False
        '
        'rock_border2
        '
        Me.rock_border2.BackColor = System.Drawing.Color.White
        Me.rock_border2.Location = New System.Drawing.Point(214, 9)
        Me.rock_border2.Name = "rock_border2"
        Me.rock_border2.Size = New System.Drawing.Size(10, 142)
        Me.rock_border2.TabIndex = 80
        Me.rock_border2.TabStop = False
        '
        'rock_border4
        '
        Me.rock_border4.BackColor = System.Drawing.Color.White
        Me.rock_border4.Location = New System.Drawing.Point(37, 9)
        Me.rock_border4.Name = "rock_border4"
        Me.rock_border4.Size = New System.Drawing.Size(10, 134)
        Me.rock_border4.TabIndex = 79
        Me.rock_border4.TabStop = False
        '
        'QSTMARK
        '
        Me.QSTMARK.BackColor = System.Drawing.Color.Transparent
        Me.QSTMARK.BackgroundImage = CType(resources.GetObject("QSTMARK.BackgroundImage"), System.Drawing.Image)
        Me.QSTMARK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QSTMARK.Location = New System.Drawing.Point(753, 166)
        Me.QSTMARK.Name = "QSTMARK"
        Me.QSTMARK.Size = New System.Drawing.Size(223, 159)
        Me.QSTMARK.TabIndex = 78
        Me.QSTMARK.TabStop = False
        '
        'ROCK_AI
        '
        Me.ROCK_AI.BackColor = System.Drawing.Color.Transparent
        Me.ROCK_AI.BackgroundImage = CType(resources.GetObject("ROCK_AI.BackgroundImage"), System.Drawing.Image)
        Me.ROCK_AI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ROCK_AI.Location = New System.Drawing.Point(753, 166)
        Me.ROCK_AI.Name = "ROCK_AI"
        Me.ROCK_AI.Size = New System.Drawing.Size(223, 159)
        Me.ROCK_AI.TabIndex = 77
        Me.ROCK_AI.TabStop = False
        '
        'SCISSOR_AI
        '
        Me.SCISSOR_AI.BackColor = System.Drawing.Color.Transparent
        Me.SCISSOR_AI.BackgroundImage = CType(resources.GetObject("SCISSOR_AI.BackgroundImage"), System.Drawing.Image)
        Me.SCISSOR_AI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SCISSOR_AI.Location = New System.Drawing.Point(753, 166)
        Me.SCISSOR_AI.Name = "SCISSOR_AI"
        Me.SCISSOR_AI.Size = New System.Drawing.Size(223, 159)
        Me.SCISSOR_AI.TabIndex = 76
        Me.SCISSOR_AI.TabStop = False
        '
        'PAPER_AI
        '
        Me.PAPER_AI.BackColor = System.Drawing.Color.Transparent
        Me.PAPER_AI.BackgroundImage = CType(resources.GetObject("PAPER_AI.BackgroundImage"), System.Drawing.Image)
        Me.PAPER_AI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PAPER_AI.Location = New System.Drawing.Point(753, 166)
        Me.PAPER_AI.Name = "PAPER_AI"
        Me.PAPER_AI.Size = New System.Drawing.Size(223, 159)
        Me.PAPER_AI.TabIndex = 74
        Me.PAPER_AI.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Super Legend Boy", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(6, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(679, 82)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "COMPUTER'S WEAPON ->" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ROCK_PIC
        '
        Me.ROCK_PIC.BackColor = System.Drawing.Color.Transparent
        Me.ROCK_PIC.BackgroundImage = CType(resources.GetObject("ROCK_PIC.BackgroundImage"), System.Drawing.Image)
        Me.ROCK_PIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ROCK_PIC.Location = New System.Drawing.Point(37, 0)
        Me.ROCK_PIC.Name = "ROCK_PIC"
        Me.ROCK_PIC.Size = New System.Drawing.Size(187, 152)
        Me.ROCK_PIC.TabIndex = 73
        Me.ROCK_PIC.TabStop = False
        '
        'SCISSOR_PIC
        '
        Me.SCISSOR_PIC.BackColor = System.Drawing.Color.Transparent
        Me.SCISSOR_PIC.BackgroundImage = CType(resources.GetObject("SCISSOR_PIC.BackgroundImage"), System.Drawing.Image)
        Me.SCISSOR_PIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SCISSOR_PIC.Location = New System.Drawing.Point(788, 19)
        Me.SCISSOR_PIC.Name = "SCISSOR_PIC"
        Me.SCISSOR_PIC.Size = New System.Drawing.Size(188, 142)
        Me.SCISSOR_PIC.TabIndex = 72
        Me.SCISSOR_PIC.TabStop = False
        '
        'PAPER_PIC
        '
        Me.PAPER_PIC.BackColor = System.Drawing.Color.Transparent
        Me.PAPER_PIC.BackgroundImage = CType(resources.GetObject("PAPER_PIC.BackgroundImage"), System.Drawing.Image)
        Me.PAPER_PIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PAPER_PIC.Location = New System.Drawing.Point(405, 11)
        Me.PAPER_PIC.Name = "PAPER_PIC"
        Me.PAPER_PIC.Size = New System.Drawing.Size(188, 142)
        Me.PAPER_PIC.TabIndex = 66
        Me.PAPER_PIC.TabStop = False
        '
        'submit_ans
        '
        Me.submit_ans.BackColor = System.Drawing.Color.Black
        Me.submit_ans.Font = New System.Drawing.Font("Super Legend Boy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_ans.ForeColor = System.Drawing.Color.LawnGreen
        Me.submit_ans.Location = New System.Drawing.Point(405, 181)
        Me.submit_ans.Name = "submit_ans"
        Me.submit_ans.Size = New System.Drawing.Size(188, 55)
        Me.submit_ans.TabIndex = 61
        Me.submit_ans.Text = "GAME"
        Me.submit_ans.UseVisualStyleBackColor = False
        '
        'results_lbl
        '
        Me.results_lbl.AutoSize = True
        Me.results_lbl.BackColor = System.Drawing.Color.Transparent
        Me.results_lbl.Font = New System.Drawing.Font("Super Legend Boy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.results_lbl.ForeColor = System.Drawing.Color.Snow
        Me.results_lbl.Location = New System.Drawing.Point(485, 469)
        Me.results_lbl.Name = "results_lbl"
        Me.results_lbl.Size = New System.Drawing.Size(274, 30)
        Me.results_lbl.TabIndex = 61
        Me.results_lbl.Text = "R E S U L T S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.results_lbl.Visible = False
        '
        'resulta
        '
        Me.resulta.AutoSize = True
        Me.resulta.BackColor = System.Drawing.Color.Transparent
        Me.resulta.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resulta.ForeColor = System.Drawing.Color.Orange
        Me.resulta.Location = New System.Drawing.Point(523, 520)
        Me.resulta.Name = "resulta"
        Me.resulta.Size = New System.Drawing.Size(197, 71)
        Me.resulta.TabIndex = 61
        Me.resulta.Text = "TIE"
        Me.resulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.resulta.Visible = False
        '
        'win_lbl
        '
        Me.win_lbl.AutoSize = True
        Me.win_lbl.BackColor = System.Drawing.Color.Transparent
        Me.win_lbl.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.win_lbl.ForeColor = System.Drawing.Color.Aqua
        Me.win_lbl.Location = New System.Drawing.Point(405, 523)
        Me.win_lbl.Name = "win_lbl"
        Me.win_lbl.Size = New System.Drawing.Size(421, 71)
        Me.win_lbl.TabIndex = 66
        Me.win_lbl.Text = "YOU WIN"
        Me.win_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.win_lbl.Visible = False
        '
        'lose_lbl
        '
        Me.lose_lbl.AutoSize = True
        Me.lose_lbl.BackColor = System.Drawing.Color.Transparent
        Me.lose_lbl.Font = New System.Drawing.Font("Super Legend Boy", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lose_lbl.ForeColor = System.Drawing.Color.Red
        Me.lose_lbl.Location = New System.Drawing.Point(364, 515)
        Me.lose_lbl.Name = "lose_lbl"
        Me.lose_lbl.Size = New System.Drawing.Size(514, 71)
        Me.lose_lbl.TabIndex = 91
        Me.lose_lbl.Text = "YOU LOSE"
        Me.lose_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lose_lbl.Visible = False
        '
        'Rock_Paper_Scissor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.lose_lbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.win_lbl)
        Me.Controls.Add(Me.music_on_logo)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.results_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.music_off_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "Rock_Paper_Scissor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock_Paper_Scissor"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.music_on_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.music_off_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.scissor_border2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissor_border4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissor_border1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissor_border3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paper_border2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paper_border4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paper_border1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paper_border3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rock_border3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rock_border1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rock_border2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rock_border4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QSTMARK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROCK_AI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCISSOR_AI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAPER_AI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROCK_PIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCISSOR_PIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAPER_PIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents music_on_logo As PictureBox
    Friend WithEvents music_off_logo As PictureBox
    Public WithEvents dte_time As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents submit_ans As Button
    Friend WithEvents results_lbl As Label
    Friend WithEvents resulta As Label
    Friend WithEvents QSTMARK As PictureBox
    Friend WithEvents ROCK_AI As PictureBox
    Friend WithEvents SCISSOR_AI As PictureBox
    Friend WithEvents PAPER_AI As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ROCK_PIC As PictureBox
    Friend WithEvents SCISSOR_PIC As PictureBox
    Friend WithEvents PAPER_PIC As PictureBox
    Friend WithEvents scissor_border2 As PictureBox
    Friend WithEvents scissor_border4 As PictureBox
    Friend WithEvents scissor_border1 As PictureBox
    Friend WithEvents scissor_border3 As PictureBox
    Friend WithEvents paper_border2 As PictureBox
    Friend WithEvents paper_border4 As PictureBox
    Friend WithEvents paper_border1 As PictureBox
    Friend WithEvents paper_border3 As PictureBox
    Friend WithEvents rock_border3 As PictureBox
    Friend WithEvents rock_border1 As PictureBox
    Friend WithEvents rock_border2 As PictureBox
    Friend WithEvents rock_border4 As PictureBox
    Friend WithEvents win_lbl As Label
    Friend WithEvents lose_lbl As Label
End Class
