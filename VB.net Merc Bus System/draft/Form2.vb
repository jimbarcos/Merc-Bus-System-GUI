Public Class Form2
    'loading form

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

    'bus animation
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If bus_ui.Left < Me.Width Then
            bus_ui.Left = bus_ui.Left + 5


        End If
    End Sub

    ' UI greeting
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label5.Visible = True
        Dim username As New System.IO.StreamReader("username.txt")
        Dim user_disp As String

        user_disp = username.ReadLine
        Label5.Text = "Welcome To Merc Bus System" + vbNewLine + user_disp + "!"

        Button1.Enabled = True
        Button1.Visible = True
        Label1.Visible = False
        Label3.Visible = False
    End Sub


    'LOADING LABEL GOES TO FRONT 
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label1.BringToFront()
    End Sub

    'resetting the value of form1 incase of undo button is triggered
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
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


    ' press to continue part, bridge to the book_ui
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Book_ui.Show()
        Dim enabled As String = Nothing
        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "T" Then
            Book_ui.music_on_logo.BringToFront()
            My.Computer.Audio.Play(My.Resources.前前前世君の名は_8bit, AudioPlayMode.BackgroundLoop)

        Else
            Book_ui.music_off_logo.BringToFront()
            My.Computer.Audio.Stop()

        End If
        music_checker.Close()
        Close()


    End Sub

    'reset value of form 1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.CheckBox1.Checked = False
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub


End Class