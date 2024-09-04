Public Class USER_HISTORY
    'USER HISTORY (TEXT FILES)

    ' music share across forms
    Dim music_enabled As System.IO.StreamWriter

    'back btn
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Hisotry_ui.Show()
        Close()
    End Sub

    'date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        GroupBox1.BringToFront()

    End Sub

    ' music on logo when click
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

    ' exit btn 
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("Are you sure you want to exit?", "EXIT APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Hide()
            Form1.Close()
            Close()

        End If
    End Sub

    'default load history
    Private Sub USER_HISTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        Dim get_username As New System.IO.StreamReader("USERNAME.txt")
        Dim string_username As String = get_username.ReadLine
        get_username.Close()
        USERNAME_LBL.Text = "This Record is from the Registered User: " & string_username

        Dim get_status As New System.IO.StreamReader("STATUS.txt")
        Dim string_status As String = get_status.ReadLine
        get_status.Close()

        ' if the status paid is attined the information details about the booking will be shown
        If string_status = "PAID" Then
            'TRANSACTION'
            Dim get_name As New System.IO.StreamReader("NAME.txt")
            Dim string_name As String = get_name.ReadToEnd
            get_name.Close()


            Dim get_age As New System.IO.StreamReader("AGE.txt")
            Dim string_age As String = get_age.ReadToEnd
            get_age.Close()

            Dim get_cmp As New System.IO.StreamReader("COMPARTMENT.txt")
            Dim string_cmp As String = get_cmp.ReadToEnd
            get_cmp.Close()

            Dim get_ins As New System.IO.StreamReader("INSURANCE.txt")
            Dim string_ins As String = get_ins.ReadToEnd
            get_ins.Close()

            Dim get_dsc As New System.IO.StreamReader("DISCOUNT.txt")
            Dim string_dsc As String = get_dsc.ReadToEnd
            get_dsc.Close()

            Dim get_dsc_factor As New System.IO.StreamReader("DISCOUNT_FACTOR.txt")
            Dim string_dsc_factor As String = get_dsc_factor.ReadToEnd
            get_dsc_factor.Close()

            Dim get_vat As New System.IO.StreamReader("VAT.txt")
            Dim string_vat As String = get_vat.ReadToEnd
            get_vat.Close()

            Dim get_vat_factor As New System.IO.StreamReader("VAT_FACTOR.txt")
            Dim string_vat_factor As String = get_vat_factor.ReadToEnd
            get_vat_factor.Close()

            Dim get_ind_ttl As New System.IO.StreamReader("INDIVIDUAL_CHARGE.txt")
            Dim string_ind_ttl As String = get_ind_ttl.ReadToEnd
            get_ind_ttl.Close()

            RichTextBox1.Text = string_name
            RichTextBox2.Text = string_age
            RichTextBox3.Text = string_cmp
            RichTextBox4.Text = string_ins
            RichTextBox5.Text = string_dsc
            RichTextBox6.Text = string_dsc_factor
            RichTextBox7.Text = string_vat
            RichTextBox8.Text = string_vat_factor
            RichTextBox9.Text = string_ind_ttl

            'BELOW LBL TRANSACTION

            Dim get_minor As New System.IO.StreamReader("MINOR.txt")
            Dim string_minor As String = get_minor.ReadLine
            get_minor.Close()

            Dim get_adult As New System.IO.StreamReader("ADULT.txt")
            Dim string_adult As String = get_adult.ReadLine
            get_adult.Close()

            Dim get_senior As New System.IO.StreamReader("SENIOR.txt")
            Dim string_senior As String = get_senior.ReadLine
            get_senior.Close()

            Dim get_cl_charge As New System.IO.StreamReader("CLASS_LOCATION_PRICE.txt")
            Dim string_cl_charge As String = get_cl_charge.ReadLine
            get_cl_charge.Close()

            Dim get_payment As New System.IO.StreamReader("PAYMENT.txt")
            Dim string_payment As Double = get_payment.ReadLine
            get_payment.Close()

            Dim get_charge As New System.IO.StreamReader("FINAL_AMOUNT.txt")
            Dim string_charge As Double = get_charge.ReadLine
            get_charge.Close()

            Dim get_change As New System.IO.StreamReader("CHANGE.txt")
            Dim string_change As Double = get_change.ReadLine
            get_change.Close()


            Dim get_passengers As New System.IO.StreamReader("MANY_PASSENGERS.txt")
            Dim string_passengers As String = get_passengers.ReadLine
            get_passengers.Close()

            Dim get_grp_fac As New System.IO.StreamReader("GROUP_DISCOUNT_FACTOR.txt")
            Dim string_grp_fac As String = get_grp_fac.ReadLine
            get_grp_fac.Close()

            Dim get_grp_dsc As New System.IO.StreamReader("GROUP_DISCOUNT.txt")
            Dim string_grp_dsc As String = get_grp_dsc.ReadLine
            get_grp_dsc.Close()

            Dim get_loc As New System.IO.StreamReader("LOCATION.txt")
            Dim string_loc As String = get_loc.ReadLine
            get_loc.Close()

            Dim get_class As New System.IO.StreamReader("CLASS.txt")
            Dim string_class As String = get_class.ReadLine
            get_class.Close()

            Dim get_type As New System.IO.StreamReader("TYPE.txt")
            Dim string_type As String = get_type.ReadLine
            get_type.Close()

            Dim get_date As New System.IO.StreamReader("DATE.txt")
            Dim string_date As String = get_date.ReadLine
            Dim string_time As String = get_date.ReadLine
            get_date.Close()

            If string_loc = "LA_UNION" Then
                string_loc = "LA UNION"
            End If

            If string_loc = "NUEVA_ECIJA" Then
                string_loc = "NUEVA ECIJA"
            End If

            If string_type = "ROUND_TRIP" Then
                string_type = "ROUND TRIP"
            End If

            If string_type = "ONE_WAY" Then
                string_type = "ONE WAY"
            End If



            MINOR_LBL.Text = "MINOR: " & string_minor
            ADULT_LBL.Text = "ADULT: " & string_adult
            SENIOR_LBL.Text = "SENIOR: " & string_senior
            status_lbl.Text = "STATUS: " & string_status
            CLASS_LOC_LBL.Text = "CLASS AND " + vbNewLine + "LOCATION" + vbNewLine + "CHARGE" + vbNewLine + "(PER PERSON)" & vbNewLine & "= " & string_cl_charge & " ="
            Label16.Text = "Amount Paid: PHP " & String.Format("{0:n2}", string_payment)
            Label17.Text = "Total Charge: PHP " & String.Format("{0:n2}", string_charge)
            Label18.Text = "Change PHP " & String.Format("{0:n2}", string_change)
            NUM_PASSENGERS_LBL.Text = "# OF PASSENGERS: " & string_passengers
            Label10.Text = "GRP. DSC. FAC: " & string_grp_fac
            Label15.Text = "GRP. DSC: " & string_grp_dsc
            LOCATION_LBL.Text = "LOCATION: " & string_loc
            CLASS_LBL.Text = "CLASS: " & string_class
            TOUR_TYPE_LBL.Text = "TOUR TYPE: " & string_type

            DATE_LBL.Text = "DATE BOOKED: " & string_date
            TIME_LBL.Visible = True
            TIME_LBL.Text = string_time

        End If



    End Sub



    'keyboard filter 
    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox2.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox3.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox4.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox5.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox6.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox7.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox8.KeyPress
        e.KeyChar = Nothing
    End Sub

    'keyboard filter 
    Private Sub RichTextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox9.KeyPress
        e.KeyChar = Nothing
    End Sub

    'info as what is the abbreviation is
    Private Sub info_ui_btn_Click(sender As Object, e As EventArgs) Handles info_ui_btn.Click
        MessageBox.Show("CMP - COMPARTMENT" + vbNewLine + vbNewLine + "INS - INSURANCE" + vbNewLine + vbNewLine + "DSC - DISCOUNT" + vbNewLine + vbNewLine + "% AFTER DSC - DISCOUNT PERCENT" + vbNewLine + vbNewLine + "VAT - VALUE ADDED TAX" + vbNewLine + vbNewLine + "% AFTER VAT - VAT PERCENT" + vbNewLine + vbNewLine + "IND. TTL. - INDIVIDUAL TOTAL", "TERMS INFORMATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class