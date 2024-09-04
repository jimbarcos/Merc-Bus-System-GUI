Public Class Form1
    ' Starting Page 
    ' music file to share across the forms

    Dim music_enabled As System.IO.StreamWriter

    'bus movement animation
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If PictureBox5.Left < Me.Width Then
            PictureBox5.Left = PictureBox5.Left + 15


        End If



    End Sub


    'Default load - on music everytime the application runs
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim enabled As String = Nothing




        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)
        music_enabled.WriteLine("T")
        music_enabled.Close()
        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "T" Then
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Steven_Universe_theme_in_8_bit, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()



    End Sub

    ' event where disables the music across the forms
    Private Sub music_on_logo_Click(sender As Object, e As EventArgs) Handles music_on_logo.Click
        music_off_logo.BringToFront()



        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)
        music_enabled.WriteLine("F")
        music_enabled.Close()


        My.Computer.Audio.Stop()
    End Sub


    ' event where enables the music across the forms
    Public Sub music_off_logo_Click() Handles music_off_logo.Click
        Dim enabled As String = Nothing

        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("T")
        music_enabled.Close()

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "T" Then
            music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.Steven_Universe_theme_in_8_bit, AudioPlayMode.BackgroundLoop)

        End If
        music_checker.Close()

    End Sub


    ' setting up for the loading of form 2
    Private Sub close_form1_Tick(sender As Object, e As EventArgs) Handles close_form1.Tick, close_form1.Tick
        Timer1.Enabled = False
        close_form1.Enabled = False
        Hide()
        Form2.Show()

        Label7.Visible = False
        Label6.Visible = False
        Label6.Enabled = False
        Label7.Enabled = False

    End Sub

    ' exit button even when clicked
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Close()
        Else
            PictureBox5.Enabled = True

        End If

    End Sub

    'when users clicked the register label, prompts them to the registration
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Hide()
        REGISTRATION.Show()
    End Sub


    'the log in button, and credentials checking
    Public Sub Button1_Click() Handles Button1.Click
        Dim username1 As System.IO.StreamWriter
        Dim password1 As System.IO.StreamWriter
        Dim pass_backup1 As System.IO.StreamWriter

        username1 = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username1.Close()

        password1 = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password1.Close()

        pass_backup1 = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup1.Close()

        Dim user_check, user_pass As String

        Dim password As New System.IO.StreamReader("password.txt")


        Dim username As New System.IO.StreamReader("username.txt")

        user_check = username.ReadLine
        user_pass = password.ReadLine
        username.Close()
        password.Close()

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("ACCOUNT CREDENTIALS NOT FOUND", "LOG IN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'TO CLEAR THE GOURPBOX TO PROCEED TO ANIMATION
        If user_check = TextBox1.Text And user_pass = TextBox2.Text Then
            Timer1.Enabled = True
            Timer1.Start()
            close_form1.Enabled = True
            GroupBox2.Visible = False
            GroupBox2.Enabled = False
            Label3.Visible = False
            Label9.Visible = True
            grpInst.Visible = False
            lblnst.Visible = False
            username.Close()
            password.Close()

        Else
            MessageBox.Show("ACCOUNT CREDENTIALS NOT FOUND", "LOG IN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Sub

    'when users clicked the forgot_pass label, prompts them to recover credentials
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Hide()
        FORGOTPASS.Show()
    End Sub



    'monitor value data of user's type value (user)
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'monitor value data of user's type value (pass)
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
            TextBox2.PasswordChar = "•"
        End If



    End Sub


    'show password
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim show_pass_container As String
        show_pass_container = TextBox2.Text


        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = Nothing

            TextBox2.Text = show_pass_container

        Else
            TextBox2.PasswordChar = "•"
        End If
    End Sub

    'date 
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'Know the developers
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox5.Enabled = False
        Dim cap As String = MessageBox.Show("Jim Barcos" + vbNewLine + vbNewLine + "Beverly Igat" + vbNewLine + vbNewLine + "Mark Tongo" + vbNewLine + vbNewLine + "Gabriel Camus", "CREATED BY", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If cap = DialogResult.OK Then
            PictureBox5.Enabled = True
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox5.Enabled = False
        Hide()
        Form5.Show()



    End Sub

    'redirect to enter log in btn
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click()
        End If
    End Sub


End Class
