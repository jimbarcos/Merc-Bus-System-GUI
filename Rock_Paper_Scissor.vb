Public Class Rock_Paper_Scissor
    'music shared across forms
    Dim music_enabled As System.IO.StreamWriter

    'ready default values
    Dim user_weapon As String = Nothing
    Dim ai_weapon As String = Nothing
    Dim rnd As New Random
    Dim interpret As Integer
    Dim seeder As Integer = 0

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'exit
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Form1.Close()

            Close()
        End If
    End Sub

    'music on logo when click
    Private Sub music_on_logo_Click(sender As Object, e As EventArgs) Handles music_on_logo.Click
        music_off_logo.BringToFront()



        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)
        music_enabled.WriteLine("F")
        music_enabled.Close()


        My.Computer.Audio.Stop()
    End Sub

    'music off logo when click
    Public Sub music_off_logo_Click() Handles music_off_logo.Click
        Dim enabled As String = Nothing

        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("T")
        music_enabled.Close()

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "T" Then
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Onepunch_Man___The_Hero_FULL__8bit_mix_, AudioPlayMode.BackgroundLoop)

        End If
        music_checker.Close()

    End Sub

    ' back btn
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        mg.Show()
        Hide()
        Close()

    End Sub


    'default load
    Private Sub Rock_Paper_Scissor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        Else
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Onepunch_Man___The_Hero_FULL__8bit_mix_, AudioPlayMode.BackgroundLoop)

        End If
        music_checker.Close()
    End Sub



    'color change effect of rock (signifies picked by user)
    Private Sub ROCK_PIC_Click(sender As Object, e As EventArgs) Handles ROCK_PIC.Click
        rock_border1.BackColor = Color.Turquoise
        rock_border2.BackColor = Color.Turquoise
        rock_border3.BackColor = Color.Turquoise
        rock_border4.BackColor = Color.Turquoise

        paper_border1.BackColor = Color.White
        paper_border2.BackColor = Color.White
        paper_border3.BackColor = Color.White
        paper_border4.BackColor = Color.White

        scissor_border1.BackColor = Color.White
        scissor_border2.BackColor = Color.White
        scissor_border3.BackColor = Color.White
        scissor_border4.BackColor = Color.White
    End Sub

    'color change effect of paper (signifies picked by user)
    Private Sub PAPER_PIC_Click(sender As Object, e As EventArgs) Handles PAPER_PIC.Click
        paper_border1.BackColor = Color.Turquoise
        paper_border2.BackColor = Color.Turquoise
        paper_border3.BackColor = Color.Turquoise
        paper_border4.BackColor = Color.Turquoise

        rock_border1.BackColor = Color.White
        rock_border2.BackColor = Color.White
        rock_border3.BackColor = Color.White
        rock_border4.BackColor = Color.White

        scissor_border1.BackColor = Color.White
        scissor_border2.BackColor = Color.White
        scissor_border3.BackColor = Color.White
        scissor_border4.BackColor = Color.White
    End Sub

    'color change effect of scissor (signifies picked by user)
    Private Sub SCISSOR_PIC_Click(sender As Object, e As EventArgs) Handles SCISSOR_PIC.Click
        scissor_border1.BackColor = Color.Turquoise
        scissor_border2.BackColor = Color.Turquoise
        scissor_border3.BackColor = Color.Turquoise
        scissor_border4.BackColor = Color.Turquoise

        rock_border1.BackColor = Color.White
        rock_border2.BackColor = Color.White
        rock_border3.BackColor = Color.White
        rock_border4.BackColor = Color.White

        paper_border1.BackColor = Color.White
        paper_border2.BackColor = Color.White
        paper_border3.BackColor = Color.White
        paper_border4.BackColor = Color.White
    End Sub

    'answer of user, verification of win or lose or tie
    Private Sub submit_ans_Click(sender As Object, e As EventArgs) Handles submit_ans.Click


        interpret = rnd.Next(1, 4)
        While seeder = interpret
            interpret = rnd.Next(1, 4)
        End While


        If scissor_border1.BackColor = Color.Turquoise Then
            user_weapon = "SCISSOR"
        End If

        If paper_border1.BackColor = Color.Turquoise Then
            user_weapon = "PAPER"
        End If

        If rock_border1.BackColor = Color.Turquoise Then
            user_weapon = "ROCK"
        End If

        If user_weapon = Nothing Then

            MessageBox.Show("PLease Choose A Weapon to Proceed", "WEAPON ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        '1 MEANS ROCK
        '2 MEANS PAPER
        '3 MEAN SCISSOR
        If interpret = 1 Then
            ai_weapon = "ROCK"
            ROCK_AI.BringToFront()
        End If

        If interpret = 2 Then
            ai_weapon = "PAPER"
            PAPER_AI.BringToFront()
        End If

        If interpret = 3 Or interpret = 4 Then
            ai_weapon = "SCISSOR"
            SCISSOR_AI.BringToFront()
        End If






        results_lbl.Visible = True
        resulta.Visible = True
        lose_lbl.Visible = True
        win_lbl.Visible = True

        'ROCK
        If user_weapon = "ROCK" And ai_weapon = "ROCK" Then
            resulta.BringToFront()
            resulta.Visible = True
            lose_lbl.Visible = False
            win_lbl.Visible = False
        End If

        If user_weapon = "ROCK" And ai_weapon = "PAPER" Then
            lose_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = True
            win_lbl.Visible = False
        End If

        If user_weapon = "ROCK" And ai_weapon = "SCISSOR" Then
            win_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = False
            win_lbl.Visible = True
        End If


        'PAPER 
        If user_weapon = "PAPER" And ai_weapon = "ROCK" Then
            win_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = False
            win_lbl.Visible = True
        End If

        If user_weapon = "PAPER" And ai_weapon = "PAPER" Then
            resulta.BringToFront()
            resulta.BringToFront()
            resulta.Visible = True
            lose_lbl.Visible = False
            win_lbl.Visible = False
        End If

        If user_weapon = "PAPER" And ai_weapon = "SCISSOR" Then
            lose_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = True
            win_lbl.Visible = False
        End If

        'SCISSOR 
        If user_weapon = "SCISSOR" And ai_weapon = "ROCK" Then
            lose_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = True
            win_lbl.Visible = False
        End If

        If user_weapon = "SCISSOR" And ai_weapon = "PAPER" Then
            win_lbl.BringToFront()
            resulta.Visible = False
            lose_lbl.Visible = False
            win_lbl.Visible = True
        End If

        If user_weapon = "SCISSOR" And ai_weapon = "SCISSOR" Then
            resulta.BringToFront()
            resulta.BringToFront()
            resulta.Visible = True
            lose_lbl.Visible = False
            win_lbl.Visible = False
        End If

        seeder = interpret
    End Sub
End Class