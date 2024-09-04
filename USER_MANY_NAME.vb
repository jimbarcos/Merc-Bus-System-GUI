Public Class TYPE_LBL
    'Most information written here
    'all process in text files


    'default value needed for validation across functions
    Dim Minor As Integer = 0
    Dim Adult As Integer = 0
    Dim Senior As Integer = 0

    Dim initial As Double = 0

    Dim Counter As Integer = 1
    Dim Counter_age As Integer = 1


    'TXT FILES FOR DATABASE
    Dim user_name As System.IO.StreamWriter
    Dim user_age As System.IO.StreamWriter

    Dim user_insurance As System.IO.StreamWriter
    Dim user_compartment As System.IO.StreamWriter

    Dim user_discount As System.IO.StreamWriter
    Dim user_discount_factor As System.IO.StreamWriter

    Dim user_vat As System.IO.StreamWriter
    Dim user_vat_factor As System.IO.StreamWriter

    Dim ind_total As System.IO.StreamWriter

    Dim all_total As System.IO.StreamWriter
    Dim how_many As System.IO.StreamWriter


    ' music shared across forms
    Dim music_enabled As System.IO.StreamWriter

    ' date
    Private Sub dte_time_Tick(sender As Object, e As EventArgs) Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay
    End Sub

    ' back btn
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim will_exit As String
        will_exit = MessageBox.Show("All progress in this form will be deleted if you go back" + vbNewLine + "CONTINUE?", "READ CAREFULLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If will_exit = DialogResult.Yes Then
            Hide()
            USER_CLASS.Show()
            Close()

        End If


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

    'validation and submitting how many passengers
    Private Sub submit_ans_Click(sender As Object, e As EventArgs) Handles submit_ans.Click
        If Not IsNumeric(input_many.Text) Then
            input_many.Text = Nothing
        End If

        If input_many.Text = Nothing Then
            MessageBox.Show("INPUT INVALID", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim user_class As New System.IO.StreamReader("CLASS.txt")
        Dim string_class As String
        Dim maximum As Integer = Nothing
        string_class = user_class.ReadLine

        If string_class = "A" Then
            maximum = 27
        End If

        If string_class = "B" Then
            maximum = 35
        End If

        If string_class = "C" Then
            maximum = 35
        End If

        If string_class = "ORDINARY" Then
            maximum = 56
        End If

        user_class.Close()

        If input_many.Text > maximum Or input_many.Text <= 0 Then
            MessageBox.Show("EXCEEDING PASSENGER CAPACITY", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        GroupBox1.Enabled = False
        GroupBox1.Visible = False

        PASSENGER_NUM.BringToFront()
        PASSENGER_NUM.Enabled = True
        PASSENGER_NUM.Visible = True
        NOTE_LBL.Visible = True

        Dim how_many As System.IO.StreamWriter
        how_many = My.Computer.FileSystem.OpenTextFileWriter("MANY_PASSENGERS.txt", False)

        how_many.WriteLine(input_many.Text)
        how_many.Close()







    End Sub


    'keyboard filter for input how many passengers
    Private Sub input_ans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input_many.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    ' default load, displays the information in text files to the user
    Public Sub USER_MANY_NAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        Dim user_class As New System.IO.StreamReader("CLASS.txt")
        Dim string_class As String

        Dim user_location As New System.IO.StreamReader("LOCATION.txt")
        Dim string_location As String

        Dim user_type As New System.IO.StreamReader("TYPE.txt")
        Dim string_type As String

        string_class = user_class.ReadLine()
        string_location = user_location.ReadLine()
        string_type = user_type.ReadLine()




        If string_location = "NUEVA_ECIJA" Then
            string_location = "NUEVA ECIJA"
        End If

        If string_location = "LA_UNION" Then
            string_location = "LA UNION"
        End If


        If string_type = "ROUND_TRIP" Then
            string_type = "ROUND TRIP"
        End If

        If string_type = "ONE_WAY" Then
            string_type = "ONE WAY"
        End If


        Dim maximum As Integer = Nothing
        Dim insurance As Double = Nothing
        Dim compartment As Double = Nothing

        If string_class = "A" Then
            maximum = 27
            compartment = 300
            insurance = 450
        End If

        If string_class = "B" Then
            maximum = 35
            compartment = 250
            insurance = 350
        End If

        If string_class = "C" Then
            maximum = 35
            compartment = 200
            insurance = 250
        End If

        If string_class = "ORDINARY" Then
            maximum = 56
            compartment = 150
            insurance = 175
        End If



        CLASS_LBL.Text = "CLASS: " & string_class
        LOCATION_LBL.Text = "LOCATION: " & string_location
        Label2.Text = "TYPE: " & string_type
        LIMIT_LBL.Text = "PASSENGER LIMIT: " & maximum
        cmp_price_lbl.Text = "PRICE: PHP " & compartment
        ins_price_lbl.Text = "PRICE: PHP " & insurance
        user_class.Close()
        user_location.Close()
        user_type.Close()

        user_name = My.Computer.FileSystem.OpenTextFileWriter("NAME.txt", False)
        user_name.Close()

        user_age = My.Computer.FileSystem.OpenTextFileWriter("AGE.txt", False)
        user_age.Close()


        user_insurance = My.Computer.FileSystem.OpenTextFileWriter("INSURANCE.txt", False)
        user_insurance.Close()

        user_compartment = My.Computer.FileSystem.OpenTextFileWriter("COMPARTMENT.txt", False)
        user_compartment.Close()

        user_discount = My.Computer.FileSystem.OpenTextFileWriter("DISCOUNT.txt", False)
        user_discount.Close()


        user_discount_factor = My.Computer.FileSystem.OpenTextFileWriter("DISCOUNT_FACTOR.txt", False)
        user_discount_factor.Close()

        user_vat_factor = My.Computer.FileSystem.OpenTextFileWriter("VAT_FACTOR.txt", False)
        user_vat_factor.Close()

        user_vat = My.Computer.FileSystem.OpenTextFileWriter("VAT.txt", False)
        user_vat.Close()

        ind_total = My.Computer.FileSystem.OpenTextFileWriter("INDIVIDUAL_CHARGE.txt", False)
        ind_total.Close()

        all_total = My.Computer.FileSystem.OpenTextFileWriter("INITIAL_TOTAL.txt", False)
        all_total.Close()


        how_many = My.Computer.FileSystem.OpenTextFileWriter("MANY_PASSENGERS.txt", False)
        how_many.Close()

        Dim many_minor As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("MINOR.txt", False)
        Dim many_adult As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("ADULT.txt", False)
        Dim many_senior As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("SENIOR.txt", False)

        many_minor.Close()
        many_adult.Close()
        many_senior.Close()

    End Sub

    Private Sub pas_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pas_name.KeyPress



        If (pas_name.TextLength <= 0) Then
            If Asc(e.KeyChar) = 32 Then
                e.KeyChar = Nothing
            End If
        End If
        If Not (e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32) Then
            e.KeyChar = Nothing
        End If
    End Sub


    'keyboard filter for age textbox input
    Private Sub pas_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pas_age.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    ' validation and the submission of data to text files until it repeats
    ' all computation process
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(pas_name.Text) Then
            pas_name.Text = Nothing
        End If

        If (pas_name.Text = Nothing) Then
            MessageBox.Show("Please Input Passenger Name", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(pas_age.Text) Then
            pas_age.Text = Nothing
        End If

        If (pas_age.Text = Nothing) Then
            MessageBox.Show("Please Input A Valid Age", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If (pas_age.Text < 0 Or pas_age.Text > 120) Then
            MessageBox.Show("Please Input A Valid Age", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'confirmation box
        If (confirm_cb.Checked = False) Then
            Dim confirm As String = MessageBox.Show("Are you sure the informations are correct?", "CONFIRMATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.No Then
                Exit Sub
            End If
        End If

        Dim Discount As Double
        Dim VAT As Double = 0.12

        If pas_age.Text <= 10 Then
            Discount = 0.05
        End If

        If pas_age.Text >= 65 Then
            Discount = 0.2
        End If

        If pas_age.Text >= 65 Then
            VAT = 0.0
        End If

        Dim dsc_disp As Double = Discount * 100
        Dim vat_disp As Double = VAT * 100

        Dim class_charge As New System.IO.StreamReader("CLASS_LOCATION_PRICE.txt")
        Dim class_cmpt As Double
        class_cmpt = class_charge.ReadLine
        class_charge.Close()




        Dim CLASS_DEFINE As New System.IO.StreamReader("CLASS.txt")
        Dim string_class As String
        Dim insurance, compartment As Double
        string_class = CLASS_DEFINE.ReadLine

        If string_class = "A" Then

            compartment = 300
            insurance = 450
        End If

        If string_class = "B" Then

            compartment = 250
            insurance = 350
        End If

        If string_class = "C" Then

            compartment = 200
            insurance = 250
        End If

        If string_class = "ORDINARY" Then

            compartment = 150
            insurance = 175
        End If

        If ins_cb.Checked = False Then
            insurance = 0
        End If

        If cmp_cb.Checked = False Then
            compartment = 0
        End If
        CLASS_DEFINE.Close()

        Dim TEMP_TOTAL As Double
        Dim print_vat As Double = VAT * ((class_cmpt - (class_cmpt * Discount) + (+insurance + compartment)))
        Dim print_disc As Double = class_cmpt * Discount
        TEMP_TOTAL = class_cmpt


        C_L_CHARGE.Text = "CLASS AND LOCATION CHARGE: " & class_cmpt
        DSC_LBL.Text = "DISCOUNT: " & print_disc
        DSC_FACTOR_LBL.Text = "DISCOUNT FACTOR: " & dsc_disp & " %"
        VAT_FACTOR_LBL.Text = "VAT FACTOR: " & vat_disp & " %"
        VAT_LBL.Text = "VAT: " & print_vat
        INS_LBL.Text = "INSURANCE: " & insurance
        CMP_LBL.Text = "COMPARTMENT: " & compartment
        TEMP_TOTAL = TEMP_TOTAL + print_vat - print_disc + insurance + compartment
        TTL_LBL.Text = "TOTAL: PHP " & TEMP_TOTAL

        initial = initial + TEMP_TOTAL


        If Val(pas_age.Text) <= 17 Then
            Minor = Minor + 1
        End If

        If Val(pas_age.Text) >= 18 And Val(pas_age.Text) <= 64 Then
            Adult = Adult + 1
        End If

        If Val(pas_age.Text) >= 65 Then
            Senior = Senior + 1
        End If

        Dim many_minor As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("MINOR.txt", False)
        Dim many_adult As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("ADULT.txt", False)
        Dim many_senior As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("SENIOR.txt", False)

        many_minor.WriteLine(Minor)
        many_adult.WriteLine(Adult)
        many_senior.WriteLine(Senior)

        many_minor.Close()
        many_adult.Close()
        many_senior.Close()



        GroupBox2.Enabled = True
        GroupBox2.Visible = True
        CONTINUE_BTN.Enabled = True
        CONTINUE_BTN.Visible = True
        pas_name.Enabled = False
        pas_age.Enabled = False
        cmp_cb.Enabled = False
        ins_cb.Enabled = False
        Button1.Enabled = False



        If Counter_age = input_many.Text Then
            If Adult <= 0 And Senior <= 0 Then
                MessageBox.Show("No Minors are allowed without an attending guardian that is 18 years old and above.", "PASSENGER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Hide()
                USER_CLASS.Show()
                Close()
                Exit Sub
            End If
        End If




        user_name = My.Computer.FileSystem.OpenTextFileWriter("NAME.txt", True)
        user_name.WriteLine(Counter & ". " & pas_name.Text.ToUpper & vbNewLine)
        user_name.Close()

        user_age = My.Computer.FileSystem.OpenTextFileWriter("AGE.txt", True)
        user_age.WriteLine(Counter & ". " & pas_age.Text & vbNewLine)
        user_age.Close()

        user_insurance = My.Computer.FileSystem.OpenTextFileWriter("INSURANCE.txt", True)
        user_insurance.WriteLine(Counter & ". " & insurance & vbNewLine)
        user_insurance.Close()

        user_compartment = My.Computer.FileSystem.OpenTextFileWriter("COMPARTMENT.txt", True)
        user_compartment.WriteLine(Counter & ". " & compartment & vbNewLine)
        user_compartment.Close()

        user_discount = My.Computer.FileSystem.OpenTextFileWriter("DISCOUNT.txt", True)
        user_discount.WriteLine(Counter & ". " & print_disc & vbNewLine)
        user_discount.Close()


        user_discount_factor = My.Computer.FileSystem.OpenTextFileWriter("DISCOUNT_FACTOR.txt", True)
        user_discount_factor.WriteLine(Counter & ". " & dsc_disp & " %" & vbNewLine)
        user_discount_factor.Close()

        user_vat_factor = My.Computer.FileSystem.OpenTextFileWriter("VAT_FACTOR.txt", True)
        user_vat_factor.WriteLine(Counter & ". " & vat_disp & " %" & vbNewLine)
        user_vat_factor.Close()

        user_vat = My.Computer.FileSystem.OpenTextFileWriter("VAT.txt", True)
        user_vat.WriteLine(Counter & ". " & print_vat & vbNewLine)
        user_vat.Close()


        ind_total = My.Computer.FileSystem.OpenTextFileWriter("INDIVIDUAL_CHARGE.txt", True)
        ind_total.WriteLine(Counter & ". " & TEMP_TOTAL & vbNewLine)
        ind_total.Close()

        all_total = My.Computer.FileSystem.OpenTextFileWriter("INITIAL_TOTAL.txt", False)
        all_total.WriteLine(initial)
        all_total.Close()

        Counter_age = Counter_age + 1
    End Sub

    'continue to next until it reaches needed passenger number
    Public Sub CONTINUE_BTN_Click(sender As Object, e As EventArgs) Handles CONTINUE_BTN.Click
        Counter = Counter + 1
        Label5.Text = "PASSENGER # " & Counter


        GroupBox2.Visible = False
        GroupBox2.Enabled = False
        pas_name.Enabled = True
        pas_age.Enabled = True
        cmp_cb.Enabled = True
        ins_cb.Enabled = True
        Button1.Enabled = True


        pas_name.Text = ""
        pas_age.Text = ""
        cmp_cb.Checked = False
        ins_cb.Checked = False

        If Counter - 1 = input_many.Text Then
            Hide()
            USER_PAYMENT.Show()
            Close()

        End If

    End Sub


End Class