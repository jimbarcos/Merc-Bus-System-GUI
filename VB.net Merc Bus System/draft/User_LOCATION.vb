Public Class User_LOCATION

    'USER PICKS THE LOCATION

    Dim music_enabled As System.IO.StreamWriter
    Dim choose_location As String = Nothing

    'date, responsible for instant changes of user chosen location
    Public Function dte_time_Tick() Handles dte_time.Tick
        Label10.Text = Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year & vbNewLine & TimeOfDay

        If border_ilocos1.BackColor = Color.Red Then
            choose_location = "ILOCOS"
        End If

        If border_pampanga1.BackColor = Color.Red Then
            choose_location = "PAMPANGA"
        End If

        If border_zambales1.BackColor = Color.Red Then
            choose_location = "ZAMBALES"
        End If

        If border_baguio1.BackColor = Color.Red Then
            choose_location = "BAGUIO"
        End If

        If border_apari1.BackColor = Color.Red Then
            choose_location = "APARI"
        End If

        If border_la_union1.BackColor = Color.Red Then
            choose_location = "LA_UNION"
        End If

        If border_nueva_ecija1.BackColor = Color.Red Then
            choose_location = "NUEVA_ECIJA"
        End If

        If border_tugegarao1.BackColor = Color.Red Then
            choose_location = "TUGEGARAO"
        End If

        If border_laog1.BackColor = Color.Red Then
            choose_location = "LAOG"
        End If

        If border_pangasinan1.BackColor = Color.Red Then
            choose_location = "PANGASINAN"
        End If

        If choose_location <> "ILOCOS" And choose_location <> "PAMPANGA" And choose_location <> "ZAMBALES" And choose_location <> "BAGUIO" And choose_location <> "APARI" And choose_location <> "LA_UNION" And choose_location <> "NUEVA_ECIJA" And choose_location <> "TUGEGARAO" And choose_location <> "LAOG" And choose_location <> "PANGASINAN" Then
            CONTINUE_BTN.Enabled = False
            CONTINUE_BTN.Visible = False
        Else
            CONTINUE_BTN.Enabled = True
            CONTINUE_BTN.Visible = True
        End If

        Return choose_location
    End Function


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

    'back btn
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Book_ui.Show()
        Hide()
        Close()
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


    'color change effect to ilocos label (signifies picked by the user)
    Public Sub ILOCOS_LBL_Click() Handles ILOCOS_LBL.Click
        ILOCOS_LBL.ForeColor = Color.DarkOrange
        border_ilocos1.BackColor = Color.Red
        border_ilocos2.BackColor = Color.Red
        border_ilocos3.BackColor = Color.Red
        border_ilocos4.BackColor = Color.Red

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent

    End Sub

    'color change effect to pampanga label (signifies picked by the user)
    Public Sub PAMPANGA_LBL_Click() Handles PAMPANGA_LBL.Click
        PAMPANGA_LBL.ForeColor = Color.DarkOrange
        border_pampanga1.BackColor = Color.Red
        border_pampanga2.BackColor = Color.Red
        border_pampanga3.BackColor = Color.Red
        border_pampanga4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub

    'color change effect to zambales label (signifies picked by the user)
    Public Sub ZAMBALES_LBL_Click() Handles ZAMBALES_LBL.Click
        ZAMBALES_LBL.ForeColor = Color.DarkOrange
        border_zambales1.BackColor = Color.Red
        border_zambales2.BackColor = Color.Red
        border_zambales3.BackColor = Color.Red
        border_zambales4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent


        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub


    'color change effect to baguio label (signifies picked by the user)
    Public Sub BAGUIO_LBL_Click() Handles BAGUIO_LBL.Click
        BAGUIO_LBL.ForeColor = Color.DarkOrange
        border_baguio1.BackColor = Color.Red
        border_baguio2.BackColor = Color.Red
        border_baguio3.BackColor = Color.Red
        border_baguio4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub

    'color change effect to apari label (signifies picked by the user)
    Public Sub APARI_LBL_Click() Handles APARI_LBL.Click
        APARI_LBL.ForeColor = Color.DarkOrange
        border_apari1.BackColor = Color.Red
        border_apari2.BackColor = Color.Red
        border_apari3.BackColor = Color.Red
        border_apari4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent

    End Sub

    'color change effect to la union label (signifies picked by the user)
    Public Sub LA_UNION_LBL_Click() Handles LA_UNION_LBL.Click
        LA_UNION_LBL.ForeColor = Color.DarkOrange
        border_la_union1.BackColor = Color.Red
        border_la_union2.BackColor = Color.Red
        border_la_union3.BackColor = Color.Red
        border_la_union4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub


    'color change effect to nueva ecija label (signifies picked by the user)
    Public Sub NUEVA_ECIJA_LBL_Click() Handles NUEVA_ECIJA_LBL.Click
        NUEVA_ECIJA_LBL.ForeColor = Color.DarkOrange
        border_nueva_ecija1.BackColor = Color.Red
        border_nueva_ecija2.BackColor = Color.Red
        border_nueva_ecija3.BackColor = Color.Red
        border_nueva_ecija4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub

    'color change effect to tugegarao label (signifies picked by the user)
    Public Sub TUGEGARAO_LBL_Click() Handles TUGEGARAO_LBL.Click

        TUGEGARAO_LBL.ForeColor = Color.DarkOrange
        border_tugegarao1.BackColor = Color.Red
        border_tugegarao2.BackColor = Color.Red
        border_tugegarao3.BackColor = Color.Red
        border_tugegarao4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub


    'color change effect to laog label (signifies picked by the user)
    Public Sub LAOG_LBL_Click() Handles LAOG_LBL.Click
        LAOG_LBL.ForeColor = Color.DarkOrange
        border_laog1.BackColor = Color.Red
        border_laog2.BackColor = Color.Red
        border_laog3.BackColor = Color.Red
        border_laog4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        PANGASINAN_LBL.ForeColor = Color.Yellow
        border_pangasinan1.BackColor = Color.Transparent
        border_pangasinan2.BackColor = Color.Transparent
        border_pangasinan3.BackColor = Color.Transparent
        border_pangasinan4.BackColor = Color.Transparent
    End Sub

    'color change effect to pangasinan label (signifies picked by the user)
    Public Sub PANGASINAN_LBL_Click() Handles PANGASINAN_LBL.Click
        PANGASINAN_LBL.ForeColor = Color.DarkOrange
        border_pangasinan1.BackColor = Color.Red
        border_pangasinan2.BackColor = Color.Red
        border_pangasinan3.BackColor = Color.Red
        border_pangasinan4.BackColor = Color.Red

        ILOCOS_LBL.ForeColor = Color.Yellow
        border_ilocos1.BackColor = Color.Transparent
        border_ilocos2.BackColor = Color.Transparent
        border_ilocos3.BackColor = Color.Transparent
        border_ilocos4.BackColor = Color.Transparent

        PAMPANGA_LBL.ForeColor = Color.Yellow
        border_pampanga1.BackColor = Color.Transparent
        border_pampanga2.BackColor = Color.Transparent
        border_pampanga3.BackColor = Color.Transparent
        border_pampanga4.BackColor = Color.Transparent

        ZAMBALES_LBL.ForeColor = Color.Yellow
        border_zambales1.BackColor = Color.Transparent
        border_zambales2.BackColor = Color.Transparent
        border_zambales3.BackColor = Color.Transparent
        border_zambales4.BackColor = Color.Transparent

        APARI_LBL.ForeColor = Color.Yellow
        border_apari1.BackColor = Color.Transparent
        border_apari2.BackColor = Color.Transparent
        border_apari3.BackColor = Color.Transparent
        border_apari4.BackColor = Color.Transparent

        BAGUIO_LBL.ForeColor = Color.Yellow
        border_baguio1.BackColor = Color.Transparent
        border_baguio2.BackColor = Color.Transparent
        border_baguio3.BackColor = Color.Transparent
        border_baguio4.BackColor = Color.Transparent

        LA_UNION_LBL.ForeColor = Color.Yellow
        border_la_union1.BackColor = Color.Transparent
        border_la_union2.BackColor = Color.Transparent
        border_la_union3.BackColor = Color.Transparent
        border_la_union4.BackColor = Color.Transparent

        NUEVA_ECIJA_LBL.ForeColor = Color.Yellow
        border_nueva_ecija1.BackColor = Color.Transparent
        border_nueva_ecija2.BackColor = Color.Transparent
        border_nueva_ecija3.BackColor = Color.Transparent
        border_nueva_ecija4.BackColor = Color.Transparent

        TUGEGARAO_LBL.ForeColor = Color.Yellow
        border_tugegarao1.BackColor = Color.Transparent
        border_tugegarao2.BackColor = Color.Transparent
        border_tugegarao3.BackColor = Color.Transparent
        border_tugegarao4.BackColor = Color.Transparent

        LAOG_LBL.ForeColor = Color.Yellow
        border_laog1.BackColor = Color.Transparent
        border_laog2.BackColor = Color.Transparent
        border_laog3.BackColor = Color.Transparent
        border_laog4.BackColor = Color.Transparent
    End Sub


    'writes the chosen location to a txt file, then directs to choose class
    Private Sub CONTINUE_BTN_Click(sender As Object, e As EventArgs) Handles CONTINUE_BTN.Click

        'reset of history
        Dim status As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("STATUS.txt", False)
        status.Close()

        Dim user_location As System.IO.StreamWriter


        user_location = My.Computer.FileSystem.OpenTextFileWriter("LOCATION.txt", False)
        user_location.WriteLine(choose_location)
        user_location.Close()

        Hide()
        USER_CLASS.Show()
        Close()
    End Sub

    Private Sub info_ui_btn_Click(sender As Object, e As EventArgs) Handles info_ui_btn.Click
        Form6.Show()
        Hide()
        Close()
    End Sub
End Class