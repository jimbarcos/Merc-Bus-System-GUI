Public Class FORGOTPASS

    'recover credentials site

    Dim music_enabled As System.IO.StreamWriter

    'EXIT
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Form1.Close()
            REGISTRATION.Close()
            Close()
        End If
    End Sub

    'MUSIC LOGO WHEN CLICK
    Public Sub music_on_logo_Click() Handles music_on_logo.Click
        music_off_logo.BringToFront()

        Dim enabled As String = Nothing
        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("F")
        music_enabled.Close()
        My.Computer.Audio.Stop()
        Form1.music_off_logo.BringToFront()
    End Sub

    'MUSIC OFF LOGO WHEN CLICK
    Public Sub music_off_logo_Click() Handles music_off_logo.Click

        Dim enabled As String = Nothing


        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("T")
        music_enabled.Close()

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "T" Then
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Come_Along_With_Me__Island_Song___8_Bit_Tribute_to_Adventure_Time___Ashley_Eriksson_, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()
        Form1.music_on_logo.BringToFront()

    End Sub

    'default load of music, reset form 1 textboxes
    Private Sub FORGOTPASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Prayer_In_C__8_Bit_Remix_Cover_Version____Koi_Dance_Touhou_8_Bit_Universe, AudioPlayMode.BackgroundLoop)


        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()

        End If
        music_checker.Close()

        Form1.CheckBox1.Checked = False
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
    End Sub

    'go back button
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Hide()
        Close()
    End Sub

    'submit retrieve button when click
    'verification checking
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username1 As System.IO.StreamWriter
        Dim password1 As System.IO.StreamWriter
        Dim pass_backup1 As System.IO.StreamWriter

        If TextBox3.Text = Nothing Or Not IsNumeric(TextBox3.Text) Then
            MessageBox.Show("Please Enter a valid BACKUP CODE" + vbNewLine + "(This will help you recover your account)", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        username1 = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username1.Close()

        password1 = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password1.Close()

        pass_backup1 = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup1.Close()


        Dim pass_backup As New System.IO.StreamReader("pass_backup.txt")
        Dim password As New System.IO.StreamReader("password.txt")
        Dim username As New System.IO.StreamReader("username.txt")
        Dim pass_backup_checker As String
        Dim user_disp, pass_disp As String

        user_disp = username.ReadLine
        pass_disp = password.ReadLine
        pass_backup_checker = pass_backup.ReadLine



        If TextBox3.Text = pass_backup_checker Then
            Label5.Text = "Username: " & user_disp
            Label6.Text = "Password: " & pass_disp

        Else
            Label5.Text = "Username: "
            Label6.Text = "Password: "
            MessageBox.Show("INCORRECT BACKUP CODE", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        password.Close()
        username.Close()

        pass_backup.Close()
    End Sub

    'keyboard press of notif
    Private Sub txtInst1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Nothing
    End Sub


    'keyboard filter values
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'show code entered by user
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim show_code_container As String
        show_code_container = TextBox3.Text


        If CheckBox2.Checked = True Then
            TextBox3.PasswordChar = Nothing

            TextBox3.Text = show_code_container

        Else
            TextBox3.PasswordChar = "•"
        End If
    End Sub


End Class