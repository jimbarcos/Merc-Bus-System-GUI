Public Class mg
    'minigame choose form

    'music shares across forms
    Dim music_enabled As System.IO.StreamWriter

    'back button
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        Minigame_ui.Show()
        Hide()
        Close()

    End Sub

    'exit btn
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Hide()
            Form1.Close()
            Close()

        End If
    End Sub

    'music on logo when click
    Public Sub music_on_logo_Click() Handles music_on_logo.Click
        music_off_logo.BringToFront()

        Dim enabled As String = Nothing
        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("F")
        music_enabled.Close()
        My.Computer.Audio.Stop()
        Form1.music_off_logo.BringToFront()
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
            My.Computer.Audio.Play(My.Resources.Dragon_ball_Super___Ultra_Instinct__8_bit_Cover_, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()
        Form1.music_on_logo.BringToFront()

    End Sub

    'default load
    Private Sub mg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        Else
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Dragon_ball_Super___Ultra_Instinct__8_bit_Cover_, AudioPlayMode.BackgroundLoop)

        End If
        music_checker.Close()
    End Sub

    'color change effect for the rng
    Private Sub PictureBox10_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox10.MouseEnter
        Label1.ForeColor = Color.DarkOrange
        PictureBox3.BackColor = Color.Turquoise
        PictureBox4.BackColor = Color.Turquoise
        PictureBox5.BackColor = Color.Turquoise
        PictureBox6.BackColor = Color.Turquoise
    End Sub

    'color reset effect for the rng
    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        PictureBox3.BackColor = Color.White
        PictureBox4.BackColor = Color.White
        PictureBox5.BackColor = Color.White
        PictureBox6.BackColor = Color.White
        Label1.ForeColor = Color.SandyBrown
    End Sub

    'color change effect for the rps
    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        Label3.ForeColor = Color.DarkOrange
        PictureBox1.BackColor = Color.Turquoise
        PictureBox2.BackColor = Color.Turquoise
        PictureBox7.BackColor = Color.Turquoise
        PictureBox8.BackColor = Color.Turquoise
    End Sub


    'color reset effect for the rps
    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        PictureBox1.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        PictureBox7.BackColor = Color.White
        PictureBox8.BackColor = Color.White
        Label3.ForeColor = Color.SandyBrown
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'when users cick the ui for rng
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Random_Number_Game.Show()
        Hide()
        Close()

    End Sub

    'when users cick the ui for rps
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Rock_Paper_Scissor.Show()
        Hide()
        Close()

    End Sub


End Class