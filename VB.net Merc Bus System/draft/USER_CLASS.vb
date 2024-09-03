Public Class USER_CLASS

    'music shared across forms
    Dim music_enabled As System.IO.StreamWriter

    'date, responsible for instant change to user's picks, displays the prices by default
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay

        If BT_BORDER.BackColor = Color.Red Then
            CONTINUE_BTN.Enabled = True
            CONTINUE_BTN.Visible = True
        Else
            CONTINUE_BTN.Enabled = False
            CONTINUE_BTN.Visible = False
        End If

        Dim choose_location As New System.IO.StreamReader("LOCATION.txt")
        Dim string_location As String


        string_location = choose_location.ReadLine
        If (string_location = "LA_UNION") Then
            string_location = "LA UNION"
        End If

        If (string_location = "NUEVA_ECIJA") Then
            string_location = "NUEVA ECIJA"
        End If

        Dim choice_A, choice_B, choice_C, choice_O As Double
        Dim price_location As Double

        If string_location = "ILOCOS" Then
            choice_A = 750
            choice_B = 450
            choice_C = 425
            choice_O = 375

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "PAMPANGA" Then
            choice_A = 500
            choice_B = 400
            choice_C = 375
            choice_O = 275

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "ZAMBALES" Then
            choice_A = 415
            choice_B = 390
            choice_C = 350
            choice_O = 335

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "BAGUIO" Then
            choice_A = 585
            choice_B = 485
            choice_C = 400
            choice_O = 350

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "APARI" Then
            choice_A = 1300
            choice_B = 975
            choice_C = 870
            choice_O = 900

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP 1,300"
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "LA UNION" Then
            choice_A = 850
            choice_B = 750
            choice_C = 650
            choice_O = 540

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "NUEVA ECIJA" Then
            choice_A = 900
            choice_B = 875
            choice_C = 735
            choice_O = 630

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "TUGEGARAO" Then
            choice_A = 850
            choice_B = 750
            choice_C = 690
            choice_O = 520

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "LAOG" Then
            choice_A = 900
            choice_B = 875
            choice_C = 735
            choice_O = 620

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If

        If string_location = "PANGASINAN" Then
            choice_A = 800
            choice_B = 700
            choice_C = 675
            choice_O = 550

            PRICE_A.Text = "PRICE" & vbNewLine & "PHP " & choice_A
            PRICE_B.Text = "PRICE" & vbNewLine & "PHP " & choice_B
            PRICE_C.Text = "PRICE" & vbNewLine & "PHP " & choice_C
            PRICE_O.Text = "PRICE" & vbNewLine & "PHP " & choice_O
        End If


        'display the chosen location previously 
        LOCATION_LBL.Text = "LOCATION: " & string_location
        choose_location.Close()

        'resets the class
        Dim user_class As System.IO.StreamWriter
        user_class = My.Computer.FileSystem.OpenTextFileWriter("CLASS.txt", False)

        'resets the tour type
        Dim user_type As System.IO.StreamWriter
        user_type = My.Computer.FileSystem.OpenTextFileWriter("TYPE.txt", False)


        'color change effect to A (signifies the pick by user)
        If A_BTN.ForeColor = Color.DarkOrange Then
            price_location = choice_A
            user_class.WriteLine("A")
        End If

        'color change effect to B (signifies the pick by user)
        If B_BTN.ForeColor = Color.DarkOrange Then
            price_location = choice_B
            user_class.WriteLine("B")
        End If

        'color change effect to C (signifies the pick by user)
        If C_BTN.ForeColor = Color.DarkOrange Then
            price_location = choice_C
            user_class.WriteLine("C")
        End If

        'color change effect to ORDINARY (signifies the pick by user)
        If O_BTN.ForeColor = Color.DarkOrange Then
            price_location = choice_O
            user_class.WriteLine("ORDINARY")
        End If
        'closes the file 
        user_class.Close()

        'color change effect to Round trip (signifies the pick by user)
        If TWO_WAY_LBL.ForeColor = Color.DarkOrange Then
            price_location = price_location * 2
            user_type.WriteLine("ROUND_TRIP")
        Else
            'color change effect to One Way (signifies the pick by user)
            user_type.WriteLine("ONE_WAY")
        End If
        'closes the file
        user_type.Close()

        'for the price chosen
        Dim class_location_price As System.IO.StreamWriter

        'writes the prices then closes it 
        class_location_price = My.Computer.FileSystem.OpenTextFileWriter("CLASS_LOCATION_PRICE.txt", False)
        class_location_price.WriteLine(price_location)
        class_location_price.Close()
    End Sub

    'back btn
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        User_LOCATION.Show()
        Close()
    End Sub

    'default load
    Private Sub USER_CLASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enabled As String = Nothing

        Dim music_checker As New System.IO.StreamReader("music_enabled.txt")
        enabled = music_checker.ReadLine

        If enabled = "F" Then
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        Else
            PictureBox3.BringToFront()


        End If
        music_checker.Close()



    End Sub

    'music on logo when click
    Public Sub PictureBox3_Click() Handles PictureBox3.Click
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

            PictureBox3.BringToFront()
            My.Computer.Audio.Play(My.Resources.SPARKLE, AudioPlayMode.BackgroundLoop)
        Else
            music_off_logo.BringToFront()
            My.Computer.Audio.Stop()
        End If
        music_checker.Close()
        Form1.music_on_logo.BringToFront()

    End Sub

    'exit btn
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Hide()
            Form1.Close()

            Close()

        End If
    End Sub

    'color change effect to A lbl (signifies being chosen by user)
    Private Sub A_BTN_Click(sender As Object, e As EventArgs) Handles A_BTN.Click
        GroupBox2.Enabled = True
        GroupBox2.Visible = True
        A_BTN.ForeColor = Color.DarkOrange
        A_border1.BackColor = Color.Red
        A_border2.BackColor = Color.Red
        A_border3.BackColor = Color.Red
        A_border4.BackColor = Color.Red


        B_BTN.ForeColor = Color.Turquoise
        B_border1.BackColor = Color.Transparent
        B_border2.BackColor = Color.Transparent
        B_border3.BackColor = Color.Transparent
        B_border4.BackColor = Color.Transparent

        C_BTN.ForeColor = Color.Turquoise
        C_border1.BackColor = Color.Transparent
        C_border2.BackColor = Color.Transparent
        C_border3.BackColor = Color.Transparent
        C_border4.BackColor = Color.Transparent

        O_BTN.ForeColor = Color.Turquoise
        O_border1.BackColor = Color.Transparent
        O_border2.BackColor = Color.Transparent
        O_border3.BackColor = Color.Transparent
        O_border4.BackColor = Color.Transparent

    End Sub

    'color change effect to B lbl (signifies being chosen by user)
    Private Sub B_BTN_Click(sender As Object, e As EventArgs) Handles B_BTN.Click
        GroupBox2.Enabled = True
        GroupBox2.Visible = True

        B_BTN.ForeColor = Color.DarkOrange
        B_border1.BackColor = Color.Red
        B_border2.BackColor = Color.Red
        B_border3.BackColor = Color.Red
        B_border4.BackColor = Color.Red

        A_BTN.ForeColor = Color.Turquoise
        A_border1.BackColor = Color.Transparent
        A_border2.BackColor = Color.Transparent
        A_border3.BackColor = Color.Transparent
        A_border4.BackColor = Color.Transparent

        C_BTN.ForeColor = Color.Turquoise
        C_border1.BackColor = Color.Transparent
        C_border2.BackColor = Color.Transparent
        C_border3.BackColor = Color.Transparent
        C_border4.BackColor = Color.Transparent

        O_BTN.ForeColor = Color.Turquoise
        O_border1.BackColor = Color.Transparent
        O_border2.BackColor = Color.Transparent
        O_border3.BackColor = Color.Transparent
        O_border4.BackColor = Color.Transparent
    End Sub

    'color change effect to C lbl (signifies being chosen by user)
    Private Sub C_BTN_Click(sender As Object, e As EventArgs) Handles C_BTN.Click
        GroupBox2.Enabled = True
        GroupBox2.Visible = True

        C_BTN.ForeColor = Color.DarkOrange
        C_border1.BackColor = Color.Red
        C_border2.BackColor = Color.Red
        C_border3.BackColor = Color.Red
        C_border4.BackColor = Color.Red

        A_BTN.ForeColor = Color.Turquoise
        A_border1.BackColor = Color.Transparent
        A_border2.BackColor = Color.Transparent
        A_border3.BackColor = Color.Transparent
        A_border4.BackColor = Color.Transparent

        B_BTN.ForeColor = Color.Turquoise
        B_border1.BackColor = Color.Transparent
        B_border2.BackColor = Color.Transparent
        B_border3.BackColor = Color.Transparent
        B_border4.BackColor = Color.Transparent

        O_BTN.ForeColor = Color.Turquoise
        O_border1.BackColor = Color.Transparent
        O_border2.BackColor = Color.Transparent
        O_border3.BackColor = Color.Transparent
        O_border4.BackColor = Color.Transparent
    End Sub

    'color change effect to ORDINARY lbl (signifies being chosen by user)
    Private Sub O_BTN_Click(sender As Object, e As EventArgs) Handles O_BTN.Click
        GroupBox2.Enabled = True
        GroupBox2.Visible = True

        O_BTN.ForeColor = Color.DarkOrange
        O_border1.BackColor = Color.Red
        O_border2.BackColor = Color.Red
        O_border3.BackColor = Color.Red
        O_border4.BackColor = Color.Red




        A_BTN.ForeColor = Color.Turquoise
        A_border1.BackColor = Color.Transparent
        A_border2.BackColor = Color.Transparent
        A_border3.BackColor = Color.Transparent
        A_border4.BackColor = Color.Transparent

        B_BTN.ForeColor = Color.Turquoise
        B_border1.BackColor = Color.Transparent
        B_border2.BackColor = Color.Transparent
        B_border3.BackColor = Color.Transparent
        B_border4.BackColor = Color.Transparent

        C_BTN.ForeColor = Color.Turquoise
        C_border1.BackColor = Color.Transparent
        C_border2.BackColor = Color.Transparent
        C_border3.BackColor = Color.Transparent
        C_border4.BackColor = Color.Transparent
    End Sub

    'color change effect to 1 WAY lbl (signifies being chosen by user)
    Private Sub ONE_WAY_LBL_Click(sender As Object, e As EventArgs) Handles ONE_WAY_LBL.Click
        ONE_WAY_LBL.ForeColor = Color.DarkOrange
        ONE_BORDER1.BackColor = Color.Red
        ONE_BORDER2.BackColor = Color.Red
        ONE_BORDER3.BackColor = Color.Red
        BT_BORDER.BackColor = Color.Red

        TWO_WAY_LBL.ForeColor = Color.Khaki
        TWO_BORDER1.BackColor = Color.Transparent
        TWO_BORDER2.BackColor = Color.Transparent
        TWO_BORDER3.BackColor = Color.Transparent

        Label2.Visible = False

    End Sub

    'color change effect to 2 WAY lbl (signifies being chosen by user)
    Private Sub TWO_WAY_LBL_Click(sender As Object, e As EventArgs) Handles TWO_WAY_LBL.Click
        TWO_WAY_LBL.ForeColor = Color.DarkOrange
        TWO_BORDER1.BackColor = Color.Red
        TWO_BORDER2.BackColor = Color.Red
        TWO_BORDER3.BackColor = Color.Red
        BT_BORDER.BackColor = Color.Red

        ONE_WAY_LBL.ForeColor = Color.Khaki
        ONE_BORDER1.BackColor = Color.Transparent
        ONE_BORDER2.BackColor = Color.Transparent
        ONE_BORDER3.BackColor = Color.Transparent

        Label2.Visible = True

    End Sub

    'continue btn to user many name
    Private Sub CONTINUE_BTN_Click(sender As Object, e As EventArgs) Handles CONTINUE_BTN.Click
        Hide()
        TYPE_LBL.Show()
        Close()
    End Sub


End Class