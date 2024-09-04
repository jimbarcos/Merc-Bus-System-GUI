Public Class REGISTRATION

    'registration site

    'readying deployement of values
    Dim username As System.IO.StreamWriter
    Dim password As System.IO.StreamWriter
    Dim pass_backup As System.IO.StreamWriter

    'music share between forms
    Dim music_enabled As System.IO.StreamWriter

    'exit
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Form1.Close()
            Close()
            FORGOTPASS.Close()
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
            My.Computer.Audio.Play(My.Resources.Come_Along_With_Me__Island_Song___8_Bit_Tribute_to_Adventure_Time___Ashley_Eriksson_, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()
        Form1.music_on_logo.BringToFront()

    End Sub

    'verification music and reseting values of form 
    Private Sub REGISTRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Come_Along_With_Me__Island_Song___8_Bit_Tribute_to_Adventure_Time___Ashley_Eriksson_, AudioPlayMode.BackgroundLoop)
        Form1.CheckBox1.Checked = False
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""

        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()

        End If
        music_checker.Close()



    End Sub

    ' back button
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Hide()
        Close()
    End Sub


    'keyboard filter
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'verfication and account creation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Enter a valid USERNAME", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TextBox2.Text = Nothing Then
            MessageBox.Show("Please Enter a valid PASSWORD", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TextBox3.Text = Nothing Or Not IsNumeric(TextBox3.Text) Then
            MessageBox.Show("Please Enter a valid BACKUP CODE" + vbNewLine + "(This will help you recover your account)", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        username = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username.Close()

        password = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password.Close()

        pass_backup = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup.Close()



        Dim chk_pass As New System.IO.StreamReader("password.txt")
        Dim chk_user As New System.IO.StreamReader("username.txt")

        Dim copy_pass, copy_user As String

        copy_pass = chk_pass.ReadLine
        copy_user = chk_user.ReadLine

        If copy_user = TextBox1.Text And copy_pass = TextBox2.Text Then
            MessageBox.Show("DUPLICATE CREDENTIALS HAVE FOUND " + vbNewLine + "No need to Register", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            chk_pass.Close()
            chk_user.Close()
            Exit Sub
        End If
        chk_pass.Close()
        chk_user.Close()



        username = My.Computer.FileSystem.OpenTextFileWriter("username.txt", False)

        username.WriteLine(TextBox1.Text)
        username.Close()

        password = My.Computer.FileSystem.OpenTextFileWriter("password.txt", False)
        password.WriteLine(TextBox2.Text)
        password.Close()

        pass_backup = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", False)
        pass_backup.WriteLine(TextBox3.Text)
        pass_backup.Close()
        Dim status As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("STATUS.txt", False)
        status.Close()
        MessageBox.Show("Please Remember your credentials", "REGISTRATION COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub






    'notif restrict
    Private Sub txtInst1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInst1.KeyPress
        e.KeyChar = Nothing
    End Sub


    'keyboard filter values (username)
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    'keyboard filter values (pass)
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'show type value of entered password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim show_pass_container As String
        show_pass_container = TextBox2.Text


        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = Nothing

            TextBox2.Text = show_pass_container

        Else
            TextBox2.PasswordChar = "•"
        End If
    End Sub

    'show type value of entered back up code
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

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub


End Class