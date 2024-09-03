Public Class Random_Number_Game

    'music shared across forms
    Dim music_enabled As System.IO.StreamWriter

    'ready default values
    Dim counter As Integer = 0
    Dim rnd_value As Integer
    Dim Random_Gen As New Random

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


    'default values
    Private Sub Random_Number_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    'back button
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        mg.Show()
        Hide()
        Close()
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub


    'play button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Visible = False
        Again_btn.Enabled = False
        Again_btn.Visible = False
        GroupBox1.Visible = True
        GroupBox1.Enabled = True


        rnd_value = Random_Gen.Next(1, 1000)

    End Sub

    'keyboard filter only acceps 0-9 values per digit
    Private Sub input_ans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input_ans.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    'submit ans, verification
    Private Sub submit_ans_Click(sender As Object, e As EventArgs) Handles submit_ans.Click

        If Not IsNumeric(input_ans.Text) Then
            input_ans.Text = Nothing
        End If

        If input_ans.Text = Nothing Then
            MessageBox.Show("INPUT EXCEEDED WITHIN RANGE " + vbNewLine + "Range : 1 - 1000", "INVALID ANSWER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If input_ans.Text <= 0 Or input_ans.Text >= 1001 Then
            MessageBox.Show("INPUT EXCEEDED WITHIN RANGE " + vbNewLine + "Range : 1 - 1000", "INVALID ANSWER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        counter = counter + 1

        If input_ans.Text = rnd_value Then
            Win_lbl.Visible = True
            results_lbl.Visible = True
            reveal_lbl.Visible = True
            reveal_lbl.Text = "Random Number is: " + vbNewLine & rnd_value
            input_ans.Enabled = False
            submit_ans.Enabled = False
            Again_btn.Enabled = True
            Again_btn.Visible = True
            Exit Sub
        End If

        If input_ans.Text > rnd_value Then
            Label3.Visible = True
            Label3.Text = "LOWER THAN " & input_ans.Text
        End If
        If input_ans.Text < rnd_value Then
            Label3.Visible = True
            Label3.Text = "HIGHER THAN " & input_ans.Text
        End If

        If counter = 1 Then
            hrt10.Visible = False
        End If
        If counter = 2 Then
            hrt9.Visible = False
        End If
        If counter = 3 Then
            hrt8.Visible = False
        End If
        If counter = 4 Then
            hrt7.Visible = False
        End If
        If counter = 5 Then
            hrt6.Visible = False
        End If
        If counter = 6 Then
            hrt5.Visible = False
        End If
        If counter = 7 Then
            hrt4.Visible = False
        End If
        If counter = 8 Then
            hrt3.Visible = False
        End If
        If counter = 9 Then
            hrt2.Visible = False
        End If
        If counter = 10 Then
            hrt1.Visible = False
            Lose_lbl.Visible = True
            results_lbl.Visible = True
            reveal_lbl.Visible = True
            reveal_lbl.Text = "Random Number is: " + vbNewLine & rnd_value
            input_ans.Enabled = False
            submit_ans.Enabled = False
            Again_btn.Enabled = True
            Again_btn.Visible = True

        End If
    End Sub


    'again btn like play btn
    Private Sub Again_btn_Click(sender As Object, e As EventArgs) Handles Again_btn.Click
        counter = 0
        input_ans.Enabled = True
        submit_ans.Enabled = True
        hrt10.Visible = True
        hrt9.Visible = True
        hrt8.Visible = True
        hrt7.Visible = True
        hrt6.Visible = True
        hrt5.Visible = True
        hrt4.Visible = True
        hrt3.Visible = True
        hrt2.Visible = True
        hrt1.Visible = True

        Win_lbl.Visible = False
        Lose_lbl.Visible = False
        results_lbl.Visible = False
        reveal_lbl.Visible = False
        reveal_lbl.Text = "Random Number is: "
        Label3.Visible = False

        Again_btn.Visible = False
        Again_btn.Enabled = False
        rnd_value = Random_Gen.Next(1, 1000)
        input_ans.Text = Nothing
    End Sub
End Class