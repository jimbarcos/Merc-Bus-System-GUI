Public Class Hisotry_ui

    'history ui 

    'music file shared between forms
    Dim music_enabled As System.IO.StreamWriter

    'color effect change when cursor in range
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox5.BackColor = Color.Turquoise
        PictureBox4.BackColor = Color.Turquoise
        PictureBox6.BackColor = Color.Turquoise
        PictureBox3.BackColor = Color.Turquoise
        Label1.ForeColor = Color.DarkOrange
    End Sub

    'color reset change when cursor leaves
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox5.BackColor = Color.White
        PictureBox4.BackColor = Color.White
        PictureBox6.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        Label1.ForeColor = Color.SandyBrown
    End Sub




    'exit
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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
            My.Computer.Audio.Play(My.Resources.前前前世君の名は_8bit, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()
        Form1.music_on_logo.BringToFront()

    End Sub






    'when user choose right arrow
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Book_ui.Show()
        Hide()
        Close()
    End Sub


    'when user choose left arrow
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Minigame_ui.Show()
        Hide()
        Close()
    End Sub


    'back button, resetting form 1 values
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form1.Timer1.Enabled = False

        Form1.close_form1.Enabled = False
        Form1.GroupBox2.Visible = True
        Form1.GroupBox2.Enabled = True
        Form1.Label3.Visible = True
        Form1.Label9.Visible = False
        Form1.grpInst.Visible = True
        Form1.lblnst.Visible = True
        Form1.Label6.Visible = True
        Form1.Label7.Visible = True
        Form1.Label6.Enabled = True
        Form1.Label7.Enabled = True
        Form1.PictureBox5.Left = -13
        Form1.Show()
        Hide()
        Close()

    End Sub

    'default load 
    Private Sub Hisotry_ui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()

        End If
        music_checker.Close()
    End Sub


    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'when the user click the picture of history ui, comes to the history
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        USER_HISTORY.Show()
        Close()
    End Sub
End Class