Public Class USER_PAYMENT

    'payment for user

    'music shared across forms
    Dim music_enabled As System.IO.StreamWriter

    'back btn
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("All progress in this form and before this will be deleted if you go back" + vbNewLine + "CONTINUE?", "READ CAREFULLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Hide()

            TYPE_LBL.Show()

            Close()

        End If
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    'default load and the information that the user chose by database txt file
    Private Sub USER_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim user_loc As New System.IO.StreamReader("LOCATION.txt")
        Dim string_loc As String = user_loc.ReadLine
        user_loc.Close()

        Dim user_class As New System.IO.StreamReader("CLASS.txt")
        Dim string_class As String = user_class.ReadLine
        user_class.Close()

        Dim user_type As New System.IO.StreamReader("TYPE.txt")
        Dim string_type As String = user_type.ReadLine
        user_type.Close()

        Dim user_cl_charge As New System.IO.StreamReader("CLASS_LOCATION_PRICE.txt")
        Dim string_cl As Double = user_cl_charge.ReadLine
        user_cl_charge.Close()

        Dim user_many_pas As New System.IO.StreamReader("MANY_PASSENGERS.txt")
        Dim string_many_pas As Double = user_many_pas.ReadLine
        user_many_pas.Close()

        Dim user_minor As New System.IO.StreamReader("MINOR.txt")
        Dim string_minor As Double = user_minor.ReadLine
        user_minor.Close()

        Dim user_adult As New System.IO.StreamReader("ADULT.txt")
        Dim string_adult As Double = user_adult.ReadLine
        user_adult.Close()

        Dim user_senior As New System.IO.StreamReader("SENIOR.txt")
        Dim string_senior As Double = user_senior.ReadLine
        user_senior.Close()



        If string_type = "ONE_WAY" Then
            string_type = "ONE WAY"
        End If

        If string_type = "ROUND_TRIP" Then
            string_type = "ROUND TRIP"
        End If


        LOCATION_LBL.Text = "LOCATION: " & string_loc
        CLASS_LBL.Text = "CLASS: " & string_class
        TOUR_TYPE_LBL.Text = "TOUR TYPE: " & string_type
        NUM_PASSENGERS_LBL.Text = "NUMBER OF PASSENGERS: " & string_many_pas
        Label1.Text = "CLASS AND LOC. CHARGE: " & string_cl
        MINOR_LBL.Text = "MINOR: " & string_minor
        ADULT_LBL.Text = "ADULT: " & string_adult
        SENIOR_LBL.Text = "SENIOR: " & string_senior

        Dim grp_dsc As Double = 0.0


        'group discount if 5 or more then 5% dsc acquired 
        If string_many_pas >= 5 Then
            grp_dsc = 0.05
        End If
        Dim init_total As New System.IO.StreamReader("INITIAL_TOTAL.txt")
        Dim string_init As Double = init_total.ReadLine
        init_total.Close()

        Dim grp_dsc_display As Double = string_init * grp_dsc
        Dim grp_dsc_fac_display As Double = grp_dsc * 100
        Dim FINAL_AMT As Double = string_init - grp_dsc_display

        GRP_DSC_LBL.Text = "GROUP DISCOUNT: " & grp_dsc_display
        GRP_DSC_FAC_LBL.Text = "GROUP DISCOUNT FACTOR: " & grp_dsc_fac_display & " %"
        AMOUNT_WO_GRP_LBL.Text = "TOTAL AMOUNT W/O GRP. DSC: " & String.Format("PHP {0:n2}", string_init)
        FINAL_AMOUNT_LBL.Text = "FINAL AMOUNT: " & String.Format("PHP {0:n2}", FINAL_AMT)

        Dim contain_grp_dsc As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("GROUP_DISCOUNT.txt", False)
        contain_grp_dsc.WriteLine(grp_dsc_display)
        contain_grp_dsc.Close()

        Dim contain_grp_fac_dsc As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("GROUP_DISCOUNT_FACTOR.txt", False)
        contain_grp_fac_dsc.WriteLine(grp_dsc_fac_display & " %")
        contain_grp_fac_dsc.Close()

        Dim contain_final_amount As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("FINAL_AMOUNT.txt", False)
        contain_final_amount.WriteLine(FINAL_AMT)
        contain_final_amount.Close()




    End Sub

    'music on logo click
    Public Sub PictureBox3_Click() Handles PictureBox3.Click
        music_off_logo.BringToFront()

        Dim enabled As String = Nothing
        music_enabled = My.Computer.FileSystem.OpenTextFileWriter("music_enabled.txt", False)

        music_enabled.WriteLine("F")
        music_enabled.Close()
        My.Computer.Audio.Stop()
        Form1.music_off_logo.BringToFront()
    End Sub

    'music off logo click
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

    'keyboard filter for age (0-9)
    Private Sub pas_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles transac_tb.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    ' submission buton of payment, validation and creation file of transaction history
    Private Sub PAY_BTN_Click(sender As Object, e As EventArgs) Handles PAY_BTN.Click
        If transac_tb.Text = Nothing Or Not IsNumeric(transac_tb.Text) Then
            MessageBox.Show("Please Enter a valid Amount", "PAYMENT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        Dim read_final_amt As New System.IO.StreamReader("FINAL_AMOUNT.txt", False)
        Dim var_final_amt As Double = read_final_amt.ReadLine
        read_final_amt.Close()

        If Val(transac_tb.Text) < var_final_amt Then
            MessageBox.Show("Please Enter a valid Amount", "PAYMENT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        CHANGE_LBL.Visible = True

        CHANGE_LBL.Text = "CHANGE: " & String.Format("{0:n2}", transac_tb.Text - var_final_amt)
        PAY_BTN.Enabled = False
        PAY_BTN.Visible = False
        transac_tb.Enabled = False


        Dim contain_change As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("CHANGE.txt", False)
        contain_change.WriteLine(Val(transac_tb.Text) - var_final_amt)
        contain_change.Close()

        YES_LBL.Enabled = True
        NO_LBL.Enabled = True
        YES_LBL.Visible = True
        NO_LBL.Visible = True
        AGAIN_LBL.Visible = True

        Dim payment As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("PAYMENT.txt", False)
        payment.WriteLine(transac_tb.Text)
        payment.Close()
        Dim status As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("STATUS.txt", False)
        status.WriteLine("PAID")
        status.Close()

        Dim get_date As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("DATE.txt", False)
        get_date.WriteLine(Label10.Text)
        get_date.Close()
    End Sub

    'color change effect yes (signifies of user's pick)
    Private Sub YES_LBL_Click(sender As Object, e As EventArgs) Handles YES_LBL.Click
        CONTINUE_BTN.Visible = True
        CONTINUE_BTN.Enabled = True
        YES_BORDER1.BackColor = Color.Turquoise
        YES_BORDER2.BackColor = Color.Turquoise
        YES_BORDER3.BackColor = Color.Turquoise
        YES_BORDER4.BackColor = Color.Turquoise
        YES_LBL.ForeColor = Color.DarkOrange

        NO_BORDER1.BackColor = Color.Transparent
        NO_BORDER2.BackColor = Color.Transparent
        NO_BORDER3.BackColor = Color.Transparent
        NO_BORDER4.BackColor = Color.Transparent
        NO_LBL.ForeColor = Color.Khaki
    End Sub

    'color change effect no (signifies of user's pick)
    Private Sub NO_LBL_Click(sender As Object, e As EventArgs) Handles NO_LBL.Click
        CONTINUE_BTN.Visible = True
        CONTINUE_BTN.Enabled = True

        NO_BORDER1.BackColor = Color.Turquoise
        NO_BORDER2.BackColor = Color.Turquoise
        NO_BORDER3.BackColor = Color.Turquoise
        NO_BORDER4.BackColor = Color.Turquoise
        NO_LBL.ForeColor = Color.DarkOrange

        YES_BORDER1.BackColor = Color.Transparent
        YES_BORDER2.BackColor = Color.Transparent
        YES_BORDER3.BackColor = Color.Transparent
        YES_BORDER4.BackColor = Color.Transparent
        YES_LBL.ForeColor = Color.Khaki

    End Sub

    'yes picked -> user location
    'no picked -> user history
    Private Sub CONTINUE_BTN_Click(sender As Object, e As EventArgs) Handles CONTINUE_BTN.Click
        If YES_LBL.ForeColor = Color.DarkOrange Then
            Hide()

            User_LOCATION.Show()
            Close()


        End If

        If NO_LBL.ForeColor = Color.DarkOrange Then
            Hide()

            USER_HISTORY.Show()
            Close()


        End If

    End Sub


End Class