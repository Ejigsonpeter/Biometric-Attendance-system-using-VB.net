Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports GrFingerXLib

Public Class Form3
    Dim DB As New mysqlconnet
    Dim ds As New DataSet
    Dim imgName1 As String
    Public dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim connection As New MySqlConnection With {.ConnectionString = "server =localhost; userid=root; password = ; database = bas; "}
    Dim myUtil As Util
    Private _UserID As Integer
    Dim cmd As MySqlCommand

    Sub count()

        connection.Close()
    End Sub
    Sub grid()

        Try
            connection.Open()

            Dim selectQuery As String = "select ID,First_Name,Last_Name,DOB,Email_Address,Matric_Number,Department,Gender,Phone_Number,State,LGA from student "
            cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, connection)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            Dim selectQuery1 As String = "select * from attendance "
            cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery1, connection)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)

            Dim sql As String = "select COUNT(*) FROM student"
            Dim cmde As New MySqlCommand(sql, connection)
            dr = cmde.ExecuteReader()
            While (dr.Read())
                ibltotal.Text = (dr(0).ToString())
            End While
            connection.Close()
            connection.Open()
            Dim sql1 As String = "select COUNT(*) FROM attendance"
            Dim cmdee As New MySqlCommand(sql1, connection)
            dr = cmdee.ExecuteReader()
            While (dr.Read())
                Label1.Text = (dr(0).ToString())
            End While

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = Now
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        txtdate.Text = Now.Date
        grid()







        Dim err As Integer
        '---initialize Util class---
        myUtil = New Util(Listbox1, Pic1, AxGrFingerXCtrl1)
        '---Initialize GrFingerX Library---
        err = myUtil.InitializeGrFinger()
        '---Print result in log---
        If err < 0 Then
            myUtil.WriteError(err)
            Exit Sub
        Else
            myUtil.WriteLog( _
            "****GrFingerX Initialized Successfully****")
        End If
        '---create a log file---
        'If Not System.IO.File.Exists(Logfile) Then
        '    System.IO.File.Create(Logfile)
        'End If
    End Sub

    '---Extract a template from a fingerprint image---
    Private Function ExtractTemplate() As Integer
        Dim ret As Integer
        '---extract template---
        ret = myUtil.ExtractTemplate()
        '---write template quality to log---
        If ret = GRConstants.GR_BAD_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & _
            "Bad quality.")
        ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & _
            "Medium quality.")
        ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & _
            "High quality.")
        End If
        If ret >= 0 Then
            '---if no error, display minutiae/segments/directions
            ' into the image---
            myUtil.PrintBiometricDisplay(True, _
            GRConstants.GR_NO_CONTEXT)
        Else
            '---write error to log---
            myUtil.WriteError(ret)
        End If
        Return ret
    End Function

    Private Function EnrollFingerprint() As Integer
        Dim id As Integer
        '---add fingerprint---
        id = myUtil.Enroll()
        '---write result to log---
        If id >= 0 Then
            myUtil.WriteLog("Fingerprint enrolled with id = " & id)
        Else
            myUtil.WriteLog("Error: Fingerprint not enrolled")
        End If
        Return id
    End Function



    Private Sub AxGrFingerXCtrl1_FingerDown(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) Handles AxGrFingerXCtrl1.FingerDown
        myUtil.WriteLog("Sensor: " & e.idSensor & _
                ". Event: Finger Placed.")
    End Sub

    Private Sub AxGrFingerXCtrl1_FingerUp(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) Handles AxGrFingerXCtrl1.FingerUp
        myUtil.WriteLog("Sensor: " & e.idSensor & _
                ". Event: Finger removed.")
    End Sub

    Private Sub AxGrFingerXCtrl1_ImageAcquired(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) Handles AxGrFingerXCtrl1.ImageAcquired
        '---Copying acquired image---
        myUtil.raw.height = e.height
        myUtil.raw.width = e.width
        myUtil.raw.res = e.res
        myUtil.raw.img = e.rawImage
        '---Signaling that an Image Event occurred.---
        myUtil.WriteLog("Sensor: " & e.idSensor & _
        ". Event: Image captured.")
        '---display fingerprint image---
        myUtil.PrintBiometricDisplay(False, _
        GRConstants.GR_DEFAULT_CONTEXT)
        PictureBox3.Image = Pic1.Image
        '---extract the template from the fingerprint scanned---
        ExtractTemplate()
    End Sub


    Private Sub AxGrFingerXCtrl1_SensorPlug(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) Handles AxGrFingerXCtrl1.SensorPlug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Plugged.")
        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    End Sub

    Private Sub AxGrFingerXCtrl1_SensorUnplug(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) Handles AxGrFingerXCtrl1.SensorUnplug
        myUtil.WriteLog("Sensor: " & e.idSensor & _
               ". Event: Unplugged.")
        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    End Sub


    




    Private Sub cbostate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbostate.SelectedIndexChanged
        With Me.cboLGA
            If cbostate.SelectedIndex = 0 Then
                .Items.Clear()
                .Items.Add("Select")
            ElseIf Me.cbostate.SelectedIndex = 1 Then
                .Items.Clear()
                .Items.Add("Aba North")
                .Items.Add("Aba South")
                .Items.Add("Arochukwu")
                .Items.Add("Bende")
                .Items.Add("Ikwuano")
                .Items.Add("Isiala-Ngwa North")
                .Items.Add("Isiala-Ngwa South")
                .Items.Add("Isuikwuato")
                .Items.Add("Obi Ngwa")
                .Items.Add("Ohafia")
                .Items.Add("Osisioma Ngwa")
                .Items.Add("Ugwunagbo")
                .Items.Add("Ukwa East")
                .Items.Add("Ukwa West")
                .Items.Add("Umuahia North")
                .Items.Add("Umuahia South")
                .Items.Add("Umu-Nneochi")

            ElseIf Me.cbostate.SelectedIndex = 2 Then
                .Items.Clear()
                .Items.Add("Demsa")
                .Items.Add("Fufore")
                .Items.Add("Ganye")
                .Items.Add("Girei")
                .Items.Add("Guyuk")
                .Items.Add("Hong")
                .Items.Add("Jada")
                .Items.Add("Lumurde")
                .Items.Add("Madagali")
                .Items.Add("Maiha")
                .Items.Add("Mayo-Belwa")
                .Items.Add("Michika")
                .Items.Add("Mubi North")
                .Items.Add("Mubi South")
                .Items.Add("Numan")
                .Items.Add("Shelleng")
                .Items.Add("Song")
                .Items.Add("Toungo")
                .Items.Add("Yola North")
                .Items.Add("Yola South")
            ElseIf Me.cbostate.SelectedIndex = 3 Then
                .Items.Clear()
                .Items.Add("Abak")
                .Items.Add("Eastern Obolo")
                .Items.Add("Eket")
                .Items.Add("Esit Eket")
                .Items.Add("Essien Udim")
                .Items.Add("Etim Ekpo")
                .Items.Add("Etinan")
                .Items.Add("Ibeno")
                .Items.Add("Ibesikpo Asutan")
                .Items.Add("Ibiono Ibom")
                .Items.Add("Ika")
                .Items.Add("Ikono")
                .Items.Add("Ikot Abasi")
                .Items.Add("Ikot Ekpene")
                .Items.Add("Ini")
                .Items.Add("Itu")
                .Items.Add("Mbo")
                .Items.Add("Mkpat Enin")
                .Items.Add("Nsit Atai")
                .Items.Add("NSit Ubium")
                .Items.Add("Obot Akara")
                .Items.Add("Okobo")
                .Items.Add("Onna")
                .Items.Add("Oron")
                .Items.Add("Oruk Anam")
                .Items.Add("Udung Uko")
                .Items.Add("Ukanafun")
                .Items.Add("Uruan")
                .Items.Add("Urue-Offong/Oruko")
                .Items.Add("Uyo")
            ElseIf Me.cbostate.SelectedIndex = 4 Then
                .Items.Clear()
                .Items.Add("Aguata")
                .Items.Add("Anambra East")
                .Items.Add("Anambra West")
                .Items.Add("Anaocha")
                .Items.Add("Awka North")
                .Items.Add("Awka South")
                .Items.Add("Ayamelum")
                .Items.Add("Dunukofia")
                .Items.Add("Ekwusigo")
                .Items.Add("Idemili North")
                .Items.Add("Idemili South")
                .Items.Add("Ihiala")
                .Items.Add("Njikoka")
                .Items.Add("Nnewi North")
                .Items.Add("Nnewi South")
                .Items.Add("Ogbaru")
                .Items.Add("Onitsha North")
                .Items.Add("Onitsha South")
                .Items.Add("Orumba North")
                .Items.Add("Orumba South")
                .Items.Add("Oyi")
            ElseIf Me.cbostate.SelectedIndex = 5 Then
                .Items.Clear()
                .Items.Add("Alkaleri")
                .Items.Add("Bauchi")
                .Items.Add("Bogoro")
                .Items.Add("Damban")
                .Items.Add("Darazo")
                .Items.Add("Dass")
                .Items.Add("Gamawa")
                .Items.Add("Ganjuwa")
                .Items.Add("Giade")
                .Items.Add("Itas/Gadau")
                .Items.Add("Jama'are")
                .Items.Add("Katagum")
                .Items.Add("Kirfi")
                .Items.Add("Misau")
                .Items.Add("Ningi")
                .Items.Add("Shira")
                .Items.Add("Tafawa-Balewa")
                .Items.Add("Toro")
                .Items.Add("Warji")
                .Items.Add("Zaki")
            ElseIf Me.cbostate.SelectedIndex = 6 Then
                .Items.Clear()
                .Items.Add("Brass")
                .Items.Add("Ekeremor")
                .Items.Add("Kolokuma/Opokuma")
                .Items.Add("Nembe")
                .Items.Add("Ogbia")
                .Items.Add("Sagbama")
                .Items.Add("Southern Ijaw")
                .Items.Add("Yenogoa")
            ElseIf Me.cbostate.SelectedIndex = 7 Then
                .Items.Clear()
                .Items.Add("Ado")
                .Items.Add("Agatu")
                .Items.Add("Apa")
                .Items.Add("Buruku")
                .Items.Add("Gboko")
                .Items.Add("Guma")
                .Items.Add("Gwer East")
                .Items.Add("Gwer West")
                .Items.Add("Katsina-Ala")
                .Items.Add("Konshisha")
                .Items.Add("Okpokwu")
                .Items.Add("Ohimini")
                .Items.Add("Oturkpo")
                .Items.Add("Tarka")
                .Items.Add("Ukum")
                .Items.Add("Ushongo")
                .Items.Add("Vandeikya")
            ElseIf Me.cbostate.SelectedIndex = 8 Then
                .Items.Clear()
                .Items.Add("Abadam")
                .Items.Add("Askira/Uba")
                .Items.Add("Bama")
                .Items.Add("Bayo")
                .Items.Add("Biu")
                .Items.Add("Chibok")
                .Items.Add("Damboa")
                .Items.Add("Dikwa")
                .Items.Add("Gubio")
                .Items.Add("Guzamala")
                .Items.Add("Gwoza")
                .Items.Add("Hawul")
                .Items.Add("Jere")
                .Items.Add("Kaga")
                .Items.Add("Kala/Balge")
                .Items.Add("Konduga")
                .Items.Add("Kukama")
                .Items.Add("Kwaya Kusar")
                .Items.Add("Mafa")
                .Items.Add("Magumeri")
                .Items.Add("Maiduguri")
                .Items.Add("Marte")
                .Items.Add("Mobbar")
                .Items.Add("Monguno")
                .Items.Add("Ngala")
                .Items.Add("Nganzai")
                .Items.Add("Shani")
            ElseIf Me.cbostate.SelectedIndex = 9 Then
                .Items.Clear()
                .Items.Add("Abi")
                .Items.Add("Akamkpa")
                .Items.Add("Akpabuyo")
                .Items.Add("Bakassi")
                .Items.Add("Bekwara")
                .Items.Add("Biase")
                .Items.Add("Boki")
                .Items.Add("Calabar-Municipal")
                .Items.Add("Calabar South")
                .Items.Add("Etung")
                .Items.Add("Ikom")
                .Items.Add("Obanliku")
                .Items.Add("Obubra")
                .Items.Add("Obudu")
                .Items.Add("Odukpani")
                .Items.Add("Ogoja")
                .Items.Add("Yakurr")
                .Items.Add("Yala")
            ElseIf Me.cbostate.SelectedIndex = 10 Then
                .Items.Clear()
                .Items.Add("Aniocha North")
                .Items.Add("Aniocha SOuth")
                .Items.Add("Asaba")
                .Items.Add("Bomadi")
                .Items.Add("Burutu")
                .Items.Add("Ethiope East")
                .Items.Add("Ethiope West")
                .Items.Add("Ika North East")
                .Items.Add("Ika South")
                .Items.Add("Isoko North")
                .Items.Add("Isoko South")
                .Items.Add("Ndokwa East")
                .Items.Add("Ndolwa West")
                .Items.Add("Okpe")
                .Items.Add("Oshimili North")
                .Items.Add("Oshimili South")
                .Items.Add("Patani")
                .Items.Add("Sapele")
                .Items.Add("Udu")
                .Items.Add("Ughelli North")
                .Items.Add("Ughelli South")
                .Items.Add("Ukwuani")
                .Items.Add("Uvwie")
                .Items.Add("Warri North")
                .Items.Add("Warri South")
                .Items.Add("Warri South West")
            ElseIf Me.cbostate.SelectedIndex = 11 Then
                .Items.Clear()
                .Items.Add("Abakaliki")
                .Items.Add("Afikpo North")
                .Items.Add("Afikpo South")
                .Items.Add("Ebonyi State")
                .Items.Add("Ezza North")
                .Items.Add("Ezza South")
                .Items.Add("Ikwo")
                .Items.Add("Ishielu")
                .Items.Add("Ivo")
                .Items.Add("Izzi")
                .Items.Add("Ohaozara")
                .Items.Add("Ohaukwu")
                .Items.Add("Onicha")
            ElseIf Me.cbostate.SelectedIndex = 12 Then
                .Items.Clear()
                .Items.Add("Akoko-Edo")
                .Items.Add("Egor")
                .Items.Add("Esan Central")
                .Items.Add("Esan North East")
                .Items.Add("Esan South East")
                .Items.Add("Esan West")
                .Items.Add("Etsako Central")
                .Items.Add("Etsako East")
                .Items.Add("Etsako West")
                .Items.Add("Igueben")
                .Items.Add("Ikpoba-Okha")
                .Items.Add("Oredo")
                .Items.Add("Orhionmwon")
                .Items.Add("Ovia North East")
                .Items.Add("Ovia SOuth West")
                .Items.Add("Owan East")
                .Items.Add("Owan West")
                .Items.Add("Uhunmwonde")
            ElseIf Me.cbostate.SelectedIndex = 13 Then
                .Items.Clear()
                .Items.Add("Ado Ekiti")
                .Items.Add("Aiyekire")
                .Items.Add("Efon")
                .Items.Add("EKiti East")
                .Items.Add("Ekiti South West")
                .Items.Add("Ekiti West")
                .Items.Add("Emure")
                .Items.Add("Ido-Osi")
                .Items.Add("Ijero")
                .Items.Add("Ikere")
                .Items.Add("Ikole")
                .Items.Add("Ilejemeji")
                .Items.Add("Irepodun/Ifelodun")
                .Items.Add("Ise/Orun")
                .Items.Add("Moba")
                .Items.Add("Oye")
            ElseIf Me.cbostate.SelectedIndex = 14 Then
                .Items.Clear()
                .Items.Add("Aninri")
                .Items.Add("Agwu")
                .Items.Add("Enugu East")
                .Items.Add("Enugu North")
                .Items.Add("Enugu South")
                .Items.Add("Ezeagu")
                .Items.Add("Igbo-Etiti")
                .Items.Add("Igbo-Eze North")
                .Items.Add("Igbo-Eze South")
                .Items.Add("Isi-Uzo")
                .Items.Add("Nkanu East")
                .Items.Add("Nkanu West")
                .Items.Add("Nsukka")
                .Items.Add("Oji-River")
                .Items.Add("Udenu")
                .Items.Add("Udi")
                .Items.Add("Uzo-Uwani")
            ElseIf Me.cbostate.SelectedIndex = 15 Then
                .Items.Clear()
                .Items.Add("Abaji")
                .Items.Add("Abuja Municipal")
                .Items.Add("Bwari")
                .Items.Add("Gwagwalada")
                .Items.Add("Kuje")
                .Items.Add("Kwali")
            ElseIf Me.cbostate.SelectedIndex = 16 Then
                .Items.Clear()
                .Items.Add("Balanga")
                .Items.Add("Billiri")
                .Items.Add("Dukka")
                .Items.Add("Funakaye")
                .Items.Add("Gombe")
                .Items.Add("Kaltunago")
                .Items.Add("Kwami")
                .Items.Add("Nafada")
                .Items.Add("Shomgom")
                .Items.Add("Yamaltu/Deba")
            ElseIf Me.cbostate.SelectedIndex = 17 Then
                .Items.Clear()
                .Items.Add("Aboh-Mbaise")
                .Items.Add("Ahiazu-Mbaise")
                .Items.Add("Ehime-Mbano")
                .Items.Add("Ezinihitte")
                .Items.Add("Ideato North")
                .Items.Add("Ideato South")
                .Items.Add("Ihitte/Uboma")
                .Items.Add("Ikeduru")
                .Items.Add("Isiala Mbano")
                .Items.Add("Isu")
                .Items.Add("Mbaitoli")
                .Items.Add("Ngor-Okpala")
                .Items.Add("Njaba")
                .Items.Add("Nwangele")
                .Items.Add("Nkwerre")
                .Items.Add("Obowo")
                .Items.Add("Oguta")
                .Items.Add("Ohaji/Egbema")
                .Items.Add("Okigwe")
                .Items.Add("Orlu")
                .Items.Add("Orsu")
                .Items.Add("Oru East")
                .Items.Add("Oru West")
                .Items.Add("Owerri-Municipal")
                .Items.Add("Owerri North")
                .Items.Add("Owrri West")
                .Items.Add("Unuimo")
            ElseIf Me.cbostate.SelectedIndex = 18 Then
                .Items.Clear()
                .Items.Add("Auyo")
                .Items.Add("Babura")
                .Items.Add("Birnin Kudu")
                .Items.Add("Biriniwa ")
                .Items.Add("Buji")
                .Items.Add("Dutse")
                .Items.Add("Gagarawa")
                .Items.Add("Garki")
                .Items.Add("Gumei")
                .Items.Add("Guri")
                .Items.Add("Gwaram")
                .Items.Add("Gwiwa")
                .Items.Add("Hadejia")
                .Items.Add("Jahun")
                .Items.Add("Kafin Hausa")
                .Items.Add("Kaugama")
                .Items.Add("Kazaura")
                .Items.Add("Kiri Kasamma")
                .Items.Add("Kiyawa")
                .Items.Add("Maigatari")
                .Items.Add("Malam Madori")
                .Items.Add("Miga")
                .Items.Add("Ringim")
                .Items.Add("Roni")
                .Items.Add("Sule-Tankarkar")
                .Items.Add("Taura")
                .Items.Add("Yankwashi")
            ElseIf Me.cbostate.SelectedIndex = 19 Then
                .Items.Clear()
                .Items.Add("Birnim-Gwari")
                .Items.Add("Chikun")
                .Items.Add("Giwa")
                .Items.Add("Igabi")
                .Items.Add("Ikara")
                .Items.Add("Jaba")
                .Items.Add("Jema'a")
                .Items.Add("Kachia")
                .Items.Add("Kaduna North")
                .Items.Add("Kaduna South")
                .Items.Add("Kagarko")
                .Items.Add("Kajuru")
                .Items.Add("Kaura")
                .Items.Add("Kubau")
                .Items.Add("Kudan")
                .Items.Add("Lere")
                .Items.Add("Makarfi")
                .Items.Add("Sabon-Gari")
                .Items.Add("Sanga")
                .Items.Add("Soba")
                .Items.Add("Zangon-Kataf")
                .Items.Add("Zaria")
            ElseIf Me.cbostate.SelectedIndex = 20 Then
                .Items.Clear()
                .Items.Add("Ajingi")
                .Items.Add("Albasu")
                .Items.Add("Bagwai")
                .Items.Add("Bebeji")
                .Items.Add("Bichi")
                .Items.Add("Bunkure")
                .Items.Add("Dala")
                .Items.Add("Dambatta")
                .Items.Add("Dawakin Kudu")
                .Items.Add("Dawakin Tofa")
                .Items.Add("Doguwa ")
                .Items.Add("Fagge")
                .Items.Add("Gabasawa")
                .Items.Add("Garko")
                .Items.Add("Garum Mallam")
                .Items.Add("Gaya")
                .Items.Add("Gezewa")
                .Items.Add("Gwale")
                .Items.Add("Gwarzo")
                .Items.Add("Kabo")
                .Items.Add("Kano Municipal")
                .Items.Add("Karaye")
                .Items.Add("Kibiya")
                .Items.Add("Kiru")
                .Items.Add("Kumbotso")
                .Items.Add("Kunchi")
                .Items.Add("Kura")
                .Items.Add("Madobi")
                .Items.Add("Makoda")
                .Items.Add("Minjibir")
                .Items.Add("Nasarawa")
                .Items.Add("Rano")
                .Items.Add("Rinim")
                .Items.Add("Gado")
                .Items.Add("Rogo")
                .Items.Add("Shanono")
                .Items.Add("Sumaila")
                .Items.Add("Takai")
                .Items.Add("Tarauni")
                .Items.Add("Tofa")
                .Items.Add("Tsanyawa")
                .Items.Add("Tudun Wada")
                .Items.Add("Ungogo")
                .Items.Add("Warawa")
                .Items.Add("Wudil")
            ElseIf Me.cbostate.SelectedIndex = 21 Then
                .Items.Clear()
                .Items.Add("Bakori")
                .Items.Add("Batagarawa")
                .Items.Add("Batsari")
                .Items.Add("Baure")
                .Items.Add("Bindawa")
                .Items.Add("Charanchi")
                .Items.Add("Dandume")
                .Items.Add("Danja")
                .Items.Add("Dan Musa")
                .Items.Add("Daura")
                .Items.Add("Dutse")
                .Items.Add("Dutsin-Ma")
                .Items.Add("Faskari")
                .Items.Add("Funtua")
                .Items.Add("Ingawa")
                .Items.Add("Jibia")
                .Items.Add("Kafor")
                .Items.Add("Kaita")
                .Items.Add("Kankara")
                .Items.Add("Kankia")
                .Items.Add("Katsina")
                .Items.Add("Kurfi")
                .Items.Add("Kusada")
                .Items.Add("Mai'Adua")
                .Items.Add("Malumfashi")
                .Items.Add("Mani")
                .Items.Add("Mashi")
                .Items.Add("Matazu")
                .Items.Add("Musawa")
                .Items.Add("Rimi")
                .Items.Add("Sabuwa")
                .Items.Add("Safana")
                .Items.Add("Sandamu")
                .Items.Add("Zango")
            ElseIf Me.cbostate.SelectedIndex = 22 Then
                .Items.Clear()
                .Items.Add("Aleiro")
                .Items.Add("Arewa-Dandi")
                .Items.Add("Argungu")
                .Items.Add("Augie")
                .Items.Add("Bagudo")
                .Items.Add("Birnin Kebbi")
                .Items.Add("Bunza")
                .Items.Add("Dandi")
                .Items.Add("Fakai")
                .Items.Add("Gwandu")
                .Items.Add("Jega")
                .Items.Add("Kalgo")
                .Items.Add("Koko/Besse")
                .Items.Add("Maiyama")
                .Items.Add("Ngaski")
                .Items.Add("Sakaba")
                .Items.Add("Shanga")
                .Items.Add("Suru")
                .Items.Add("Wasagu/Danko")
                .Items.Add("Yauri")
                .Items.Add("Zuru")
            ElseIf Me.cbostate.SelectedIndex = 23 Then
                .Items.Clear()
                .Items.Add("Adavi")
                .Items.Add("Ajaokuta")
                .Items.Add("Ankpa")
                .Items.Add("Bassa")
                .Items.Add("Dekina")
                .Items.Add("Ibaji")
                .Items.Add("Idah")
                .Items.Add("Igalamela-Odolu")
                .Items.Add("Ijumu")
                .Items.Add("Kabba/Bunu")
                .Items.Add("Kogi")
                .Items.Add("Lokoja")
                .Items.Add("Mopa-Muro")
                .Items.Add("Ofu")
                .Items.Add("Ogori/Magongo")
                .Items.Add("Okehi")
                .Items.Add("Okene")
                .Items.Add("Olamaboro")
                .Items.Add("omala")
                .Items.Add("Yagba East")
                .Items.Add("Yagba West")
            ElseIf Me.cbostate.SelectedIndex = 24 Then
                .Items.Clear()
                .Items.Add("Asa")
                .Items.Add("Baruten")
                .Items.Add("Edu")
                .Items.Add("Ekiti")
                .Items.Add("Ifelodun")
                .Items.Add("Ilorin East")
                .Items.Add("Ilorin South")
                .Items.Add("Ilorin West")
                .Items.Add("Irepodun")
                .Items.Add("Isin")
                .Items.Add("Kaiama")
                .Items.Add("Moro")
                .Items.Add("Offa")
                .Items.Add("Oke-Ero")
                .Items.Add("Oyun")
                .Items.Add("Pategi")
            ElseIf Me.cbostate.SelectedIndex = 25 Then
                .Items.Clear()
                .Items.Add("Agege")
                .Items.Add("Ajeromi-Ifelodun")
                .Items.Add("Alimosho")
                .Items.Add("Amuwo-Odofin")
                .Items.Add("Apapa")
                .Items.Add("Badagry")
                .Items.Add("Epe")
                .Items.Add("Eti-Osa")
                .Items.Add("Ibeju/Lekki")
                .Items.Add("Ifako-Ijaye")
                .Items.Add("Ikeja")
                .Items.Add("Ikorodu")
                .Items.Add("Kosofe")
                .Items.Add("Lagos Island")
                .Items.Add("Lagos Mainland")
                .Items.Add("Mushin")
                .Items.Add("Ojo")
                .Items.Add("OShodi-Isolo")
                .Items.Add("Shomolu")
                .Items.Add("Surelere")
            ElseIf Me.cbostate.SelectedIndex = 26 Then
                .Items.Clear()
                .Items.Add("Akwanga")
                .Items.Add("Awe")
                .Items.Add("Doma")
                .Items.Add("Karu")
                .Items.Add("Keana")
                .Items.Add("Keffi")
                .Items.Add("Kokona")
                .Items.Add("Lafia")
                .Items.Add("Nasarawa")
                .Items.Add("Nasarawa-Eggon")
                .Items.Add("Obi")
                .Items.Add("Toto")
                .Items.Add("Wamba")
            ElseIf Me.cbostate.SelectedIndex = 27 Then
                .Items.Clear()
                .Items.Add("Agaie")
                .Items.Add("Agwara")
                .Items.Add("Bida")
                .Items.Add("Borgu")
                .Items.Add("Bosso")
                .Items.Add("Chanchaga")
                .Items.Add("Edati")
                .Items.Add("Gbako")
                .Items.Add("Gurara")
                .Items.Add("Katcha")
                .Items.Add("Kontagora")
                .Items.Add("Lapai")
                .Items.Add("Lavun")
                .Items.Add("Magama")
                .Items.Add("Mariga")
                .Items.Add("Mashegu")
                .Items.Add("Minna")
                .Items.Add("Mokwa")
                .Items.Add("Muya")
                .Items.Add("Paikoro")
                .Items.Add("Rafi")
                .Items.Add("Rijau")
                .Items.Add("Shiroro")
                .Items.Add("Suleja")
                .Items.Add("Tafa")
                .Items.Add("Wushishi")
            ElseIf Me.cbostate.SelectedIndex = 28 Then
                .Items.Clear()
                .Items.Add("Abeokuta North")
                .Items.Add("Abeokuta South")
                .Items.Add("Ado-Odo/Ota")
                .Items.Add("Egbado North")
                .Items.Add("Egbado South")
                .Items.Add("Ewekoro")
                .Items.Add("Ifo")
                .Items.Add("Ijebu East")
                .Items.Add("Ijebu Noreth")
                .Items.Add("Ijebu North East")
                .Items.Add("Ijebu Ode")
                .Items.Add("Ikenne")
                .Items.Add("Imeko-Afon")
                .Items.Add("Ipokia")
                .Items.Add("Obafemi-Owode")
                .Items.Add("Ogun Waterside")
                .Items.Add("Odeda")
                .Items.Add("Odogbolu")
                .Items.Add("Remo North")
                .Items.Add("Shagamu")
            ElseIf Me.cbostate.SelectedIndex = 29 Then
                .Items.Clear()
                .Items.Add("Akoko North East")
                .Items.Add("Akoko North West")
                .Items.Add("Akoko South East")
                .Items.Add("Akoko South West")
                .Items.Add("Akure North")
                .Items.Add("Akure South")
                .Items.Add("Ese-Odo")
                .Items.Add("Idanre")
                .Items.Add("Ifedore")
                .Items.Add("Ilaje")
                .Items.Add("Ile-Oluji-Okeigbo")
                .Items.Add("Irele")
                .Items.Add("Odigbo")
                .Items.Add("Okitipupa")
                .Items.Add("Ondo East")
                .Items.Add("Ondo West")
                .Items.Add("Ose")
                .Items.Add("Owo")
            ElseIf Me.cbostate.SelectedIndex = 30 Then
                .Items.Clear()
                .Items.Add("Aiyedade")
                .Items.Add("Aiyedire")
                .Items.Add("Atakumosa East")
                .Items.Add("Atakumosa West")
                .Items.Add("Bolawaduro")
                .Items.Add("Boripe")
                .Items.Add("Ede North")
                .Items.Add("Ede South")
                .Items.Add("Egbedore")
                .Items.Add("Ejigbo")
                .Items.Add("Ife Central")
                .Items.Add("Ife East")
                .Items.Add("Ife North")
                .Items.Add("Ife South")
                .Items.Add("Ifedayo")
                .Items.Add("Ifelodun")
                .Items.Add("Ila")
                .Items.Add("Ilesha East")
                .Items.Add("Ilesha West")
                .Items.Add("Irepodun")
                .Items.Add("Irewole")
                .Items.Add("Isokan")
                .Items.Add("Iwo")
                .Items.Add("Obokun")
                .Items.Add("Odo-Otin")
                .Items.Add("Ola-Oluwa")
                .Items.Add("Olorunda")
                .Items.Add("Oriade")
                .Items.Add("Orolu")
                .Items.Add("Osogbo")
            ElseIf Me.cbostate.SelectedIndex = 31 Then
                .Items.Clear()
                .Items.Add("Afijio")
                .Items.Add("Akinyele")
                .Items.Add("Atiba")
                .Items.Add("Atigbo")
                .Items.Add("Egbeda")
                .Items.Add("Ibadan Central")
                .Items.Add("Ibadan North")
                .Items.Add("Ibadan North West")
                .Items.Add("Ibadan South East")
                .Items.Add("Ibadan South West")
                .Items.Add("Ibarapa Central")
                .Items.Add("Ibarapa East")
                .Items.Add("Ibarakpa North")
                .Items.Add("Ido")
                .Items.Add("Irepo")
                .Items.Add("Iseyin")
                .Items.Add("Itesiwaju")
                .Items.Add("Iwajowa")
                .Items.Add("Kajola")
                .Items.Add("Lagelu")
                .Items.Add("Ogbomoso North")
                .Items.Add("Ogbomoso South")
                .Items.Add("Ogo Oluwa")
                .Items.Add("Olorunsogo")
                .Items.Add("Oluyole")
                .Items.Add("Ona-Ara")
                .Items.Add("Orelope")
                .Items.Add("Ori Ire")
                .Items.Add("Oyo East")
                .Items.Add("Oyo West")
                .Items.Add("Saki East")
                .Items.Add("Saki West")
                .Items.Add("Surulere")
            ElseIf Me.cbostate.SelectedIndex = 32 Then
                .Items.Clear()
                .Items.Add("Barikan Ladi")
                .Items.Add("Bassa")
                .Items.Add("Bokkos")
                .Items.Add("Jos East")
                .Items.Add("Jos North")
                .Items.Add("Jos South")
                .Items.Add("Kanam")
                .Items.Add("Kanke")
                .Items.Add("Langtang North")
                .Items.Add("Langtang South")
                .Items.Add("Mangu")
                .Items.Add("Mikang")
                .Items.Add("Pankshin")
                .Items.Add("Qua'an Pan")
                .Items.Add("Riyom")
                .Items.Add("Shendam")
                .Items.Add("Wase")
            ElseIf Me.cbostate.SelectedIndex = 33 Then
                .Items.Clear()
                .Items.Add("Abua/Odual")
                .Items.Add("Ahoada East")
                .Items.Add("Ahoada West")
                .Items.Add("Akuku")
                .Items.Add("Toru")
                .Items.Add("Andoni")
                .Items.Add("Asari-Toru")
                .Items.Add("Bonny")
                .Items.Add("Degema")
                .Items.Add("Emohua")
                .Items.Add("Eleme")
                .Items.Add("Etche")
                .Items.Add("Gokana")
                .Items.Add("Ikwerre")
                .Items.Add("Khana")
                .Items.Add("Obio/Akpor")
                .Items.Add("Ogba/Egbeme/Ndoni")
                .Items.Add("Ogu/Bolo")
                .Items.Add("Okrika")
                .Items.Add("Omumma")
                .Items.Add("Opobo/Nkoro")
                .Items.Add("Oyigbo")
                .Items.Add("Port-Harcourt")
                .Items.Add("Tai")
            ElseIf Me.cbostate.SelectedIndex = 34 Then
                .Items.Clear()
                .Items.Add("Binji")
                .Items.Add("Bodinga")
                .Items.Add("Dange-Shuni")
                .Items.Add("Gada")
                .Items.Add("Goronyo")
                .Items.Add("Gudu")
                .Items.Add("Gwadabawa")
                .Items.Add("illela")
                .Items.Add("Isa")
                .Items.Add("Kware")
                .Items.Add("Kebbe")
                .Items.Add("Rabah")
                .Items.Add("Sabon Birni")
                .Items.Add("Shagari")
                .Items.Add("Silame")
                .Items.Add("Sokoto North")
                .Items.Add("Sokoto South")
                .Items.Add("Tambuwal")
                .Items.Add("Tangaza")
                .Items.Add("Tureta")
                .Items.Add("Wamakko")
                .Items.Add("Wurno")
                .Items.Add("Yabo")
            ElseIf Me.cbostate.SelectedIndex = 35 Then
                .Items.Clear()
                .Items.Add("Ardo-Kola")
                .Items.Add("Bali")
                .Items.Add("Donga")
                .Items.Add("Gashaka")
                .Items.Add("Gassol")
                .Items.Add("Ibi")
                .Items.Add("Jalingo")
                .Items.Add("Karim-Lamido")
                .Items.Add("Kurmi")
                .Items.Add("Lau")
                .Items.Add("Sardauna")
                .Items.Add("Takum")
                .Items.Add("Ussa")
                .Items.Add("Wukari")
                .Items.Add("Yorro")
                .Items.Add("Zing")
            ElseIf Me.cbostate.SelectedIndex = 36 Then
                .Items.Clear()
                .Items.Add("Bade")
                .Items.Add("Bursari")
                .Items.Add("Damaturu")
                .Items.Add("Fike")
                .Items.Add("Fune")
                .Items.Add("Geidam")
                .Items.Add("Gujba")
                .Items.Add("Gulani")
                .Items.Add("Jakusko")
                .Items.Add("Karasuwa")
                .Items.Add("Machina")
                .Items.Add("Nangere")
                .Items.Add("Nguru")
                .Items.Add("Potiskum")
                .Items.Add("Tarmua")
                .Items.Add("Yunusari")
                .Items.Add("Yusafari")
            ElseIf Me.cbostate.SelectedIndex = 37 Then
                .Items.Clear()
                .Items.Add("Anka")
                .Items.Add("Bakura")
                .Items.Add("Birnin Magaji")
                .Items.Add("Bukkuyum")
                .Items.Add("Bungudu")
                .Items.Add("Gummi")
                .Items.Add("Gusau")
                .Items.Add("Kaura Namoda")
                .Items.Add("Maradun")
                .Items.Add("Maru")
                .Items.Add("Shinkafi")
                .Items.Add("Talata Mafara")
                .Items.Add("Tsafe")
                .Items.Add("Zurmi")

            End If
        End With

    End Sub




    Sub reset()
        txtdate.Text = Now.Date
        txtemail.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtmatric.Text = ""
        txtphone.Text = ""
        txtstat.Text = ""
        txtsearch.Text = ""
        cbostate.SelectedIndex = 0
        cbocode.SelectedIndex = 0
        cboLGA.SelectedIndex = 0
        cbdept.SelectedIndex = 0
        cbogender.SelectedIndex = 0
        Pic1.Image = BackgroundImage
        PictureBox2.Image = BackgroundImage
        PictureBox3.Image = BackgroundImage
        PictureBox4.Image = BackgroundImage
        lblmessage.Text = ""
        Label2.Text = ""
        txtdepartment.Text = ""
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtmatricnum.Text = ""
        Listbox1.Text = ""
        count()


    End Sub
    Sub verify()
        If txtfname.Text = "" Then
            chat1.Visible = True
            chat1.Text = "enter your first name"
            txtfname.Focus()
        ElseIf Len(txtfname.Text) < 2 Then
            chat1.Visible = True
            chat1.Text = "name is too short"
            txtfname.Focus()
        ElseIf Len(txtlname.Text) < 2 Then
            chat2.Visible = True
            chat2.Text = "name is too short"
            txtlname.Focus()
        ElseIf txtlname.Text = "" Then
            chat2.Visible = True
            chat2.Text = "Enter your Last Name"
            txtlname.Focus()

        ElseIf txtemail.Text = "" Then
            chat3.Visible = True
            chat3.Text = "Enter your email"
            txtemail.Focus()
        ElseIf Len(txtemail.Text) < 9 Then
            chat3.Visible = True
            chat3.Text = "email is too short"
            txtemail.Focus()
        ElseIf cbostate.SelectedIndex = 0 Then
            chat4.Visible = True
            chat4.Text = "select your state"
        ElseIf cboLGA.SelectedIndex = 0 Then
            Chat5.Visible = True
            Chat5.Text = "select your LGA"
        ElseIf cbdept.SelectedIndex = 0 Then
            chat6.Visible = True
            chat6.Text = "select your Department"
        ElseIf Len(txtmatric.Text) < 9 Then
            chat7.Visible = True
            chat7.Text = "inavlid mathric number"
            txtmatric.Focus()
        ElseIf txtmatric.Text = "" Then
            chat7.Visible = True
            chat7.Text = "Enter you matric number"
            txtmatric.Focus()
        ElseIf Len(txtphone.Text) < 11 Or Len(txtphone.Text) > 11 Then
            chat8.Visible = True
            chat8.Text = "inavlid phone number"
            txtphone.Focus()
        ElseIf txtphone.Text = "" Then
            chat8.Visible = True
            chat8.Text = "Enter you matric number"
            txtphone.Focus()
        ElseIf cbogender.SelectedIndex = 0 Then
            chat9.Visible = True
            chat9.Text = "select your Gender"


        End If
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim query As String
            query = "select * from bas.student where Matric_Number = '" & txtmatric.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While
            If count = 1 Then
                MsgBox("sorry matric number already exist", vbInformation)
                txtmatric.Focus()
            ElseIf count > 1 Then
                MsgBox("sorry matric number already exist", vbInformation)
                txtmatric.Focus()
            Else
                connection.Close()
                verify()
                _UserID = EnrollFingerprint()
                dbImage()
                AddNewUser1()

            End If

            connection.Close()

        Catch ex As Exception

        End Try



        


    End Sub

    Private Sub txtfname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Leave
        If Not Regex.Match(txtfname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Invalid Name")
            txtfname.Text = ""
        Else

        End If
    End Sub

    Private Sub txtfname_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Validated
        chat1.Visible = False
    End Sub

    Private Sub txtlname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.Leave
        If Not Regex.Match(txtlname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Invalid Name")
            txtlname.Text = ""
        Else

        End If
    End Sub


    Private Sub txtlname_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.Validated
        chat2.Visible = False
    End Sub

    Private Sub txtemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Validated
        chat3.Visible = False
    End Sub

    Private Sub cbostate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbostate.Validated
        chat4.Visible = False
    End Sub

    Private Sub cboLGA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLGA.Validated
        Chat5.Visible = False
    End Sub

    Private Sub cbdept_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdept.Validated
        chat6.Visible = False
    End Sub


   

    Private Sub txtmatric_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmatric.Validated
        chat7.Visible = False
        If Regex.Match(txtmatric.Text, "^[0-9]{4}[/][a-z]{2}[/][a-z]{3}[/][0-9]{3}$", RegexOptions.IgnoreCase).Success Or Regex.Match(txtmatric.Text, "^[0-9]{4}[/][a-z]{3}[/][a-z]{3}[/][0-9]{3}$", RegexOptions.IgnoreCase).Success Then
        Else
            MsgBox("Invalid Matric Number", vbCritical)
            txtmatric.Focus()
            txtmatric.Focus()
        End If
    End Sub

    Private Sub txtphone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtphone.Leave
        If Not Regex.Match(txtphone.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Invalid Number")
            txtphone.Text = ""

        Else

        End If
    End Sub

    Private Sub txtphone_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtphone.Validated
        chat8.Visible = False
    End Sub


    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()

            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                imgName1 = dlgImage.FileName

                Dim newimg As New Bitmap(imgName1)

                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox2.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ae As System.ArgumentException
            imgName1 = " "

            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapture.Click
        webcam.ShowDialog()
    End Sub


    Public Sub dbImage1()
        Try
            If imgName1 <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgName1, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()

                '        Dim CN As New OleDb.OleDbConnection(ConnectionString _
                '& filePath)
                '==============================================================================================
                connection.Open()

                Dim strSQL As String

                strSQL = " UPDATE student set picture=@Img WHERE Matric_Number = '" & txtmatric.Text & "'"

                Dim imgParam As New MySqlParameter()
                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte
                Dim cmd As New MySqlCommand(strSQL, connection)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()

                'MessageBox.Show("Image successfully saved.")

                cmd.Dispose()
                connection.Close()
                connection.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub AddNewUser2()

        Try

            connection.Open()
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = connection
            '---set the user's particulars in the table---
            Dim sql As String = "UPDATE student SET First_Name='" & txtfname.Text & "', " & "Last_Name='" & txtlname.Text & "', " & "Email_Address='" & txtemail.Text & "'," & "DOB='" & txtdob.Text & "', " & "gender='" & cbogender.Text & "', " & "Department='" & cbdept.Text & "', " & "State ='" & cbostate.Text & "', " & "LGA ='" & cboLGA.Text & "', " & "Matric_Number ='" & txtmatric.Text & "', " & "Phone_Number='" & txtphone.Text & "', " & "Status ='" & txtstatus.Text & "'  WHERE Matric_Number= '" & txtmatric.Text & "'"
            command.CommandText = sql
            command.ExecuteNonQuery()
            MsgBox("User added successfully!")
            reset()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            connection.Close()
        End Try
    End Sub


    Public Sub dbImage()
        Try
            If imgName1 <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgName1, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()

                '        Dim CN As New OleDb.OleDbConnection(ConnectionString _
                '& filePath)
                '==============================================================================================
                connection.Open()

                Dim strSQL As String

                strSQL = " UPDATE student set picture=@Img WHERE ID=" & _UserID

                Dim imgParam As New MySqlParameter()
                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte
                Dim cmd As New MySqlCommand(strSQL, connection)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()

                'MessageBox.Show("Image successfully saved.")

                cmd.Dispose()
                connection.Close()
                connection.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddNewUser1()

        Try

            connection.Open()
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = connection
            '---set the user's particulars in the table---
            Dim sql As String = "UPDATE student SET First_Name='" & txtfname.Text & "', " & "Last_Name='" & txtlname.Text & "', " & "Email_Address='" & txtemail.Text & "'," & "DOB='" & txtdob.Text & "', " & "gender='" & cbogender.Text & "', " & "Department='" & cbdept.Text & "', " & "State ='" & cbostate.Text & "', " & "LGA ='" & cboLGA.Text & "', " & "Matric_Number ='" & txtmatric.Text & "', " & "Phone_Number='" & txtphone.Text & "', " & "Status ='" & txtstatus.Text & "'  WHERE ID=" & _UserID
            command.CommandText = sql
            command.ExecuteNonQuery()
            MsgBox("User added successfully!")
            reset()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub cbogender_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles cbogender.Validated
        chat8.Visible = False
    End Sub


    Private Sub btnsearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsearch.Click

        Try

            connection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = connection

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM student WHERE Matric_Number = '" & txtsearch.Text & "'"
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()
            txtfname.Text = reader.Item("First_Name").ToString
            txtlname.Text = reader.Item("Last_Name").ToString
            txtemail.Text = reader.Item("Email_Address").ToString
            txtdob.Text = reader.Item("DOB").ToString
            cbdept.Text = reader.Item("Department").ToString
            cbostate.Text = reader.Item("State").ToString
            cboLGA.Text = reader.Item("LGA").ToString
            cbogender.Text = reader.Item("Gender").ToString
            txtmatric.Text = reader.Item("Matric_Number").ToString
            txtphone.Text = reader.Item("Phone_Number").ToString


            Dim imagepic As Byte() = CType(reader("picture"), Byte())
            Dim ms As New System.IO.MemoryStream(imagepic)
            Dim img As Image = Image.FromStream(ms)

            Me.PictureBox2.Image = img
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Refresh()

           
            'picturebox2.Image = image.FromFile("image.jpg")
            
           
        Catch ex As Exception
            MsgBox("Not found", vbCritical)
            txtsearch.Text = ""
            txtsearch.Focus()
        End Try
        connection.Close()

    End Sub

    Private Sub txtsearch_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.Validated
        If Regex.Match(txtsearch.Text, "^[0-9]{4}[/][a-z]{2}[/][a-z]{3}[/][0-9]{3}$", RegexOptions.IgnoreCase).Success Or Regex.Match(txtsearch.Text, "^[0-9]{4}[/][a-z]{3}[/][a-z]{3}[/][0-9]{3}$", RegexOptions.IgnoreCase).Success Then
        Else
            MsgBox("Invalid Matric Number", vbCritical)
            txtsearch.Focus()

        End If
    End Sub

    


  

   

    Private Sub Extractbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extract.Click
        ExtractTemplate()
    End Sub

    Private Function IdentifyFingerprint() As Integer
        Dim ret As Integer, score As Integer
        score = 0
        '---identify it---
        ret = myUtil.Identify(score)
        '---write result to log---
        If ret > 0 Then
            myUtil.WriteLog("Fingerprint identified. ID = " & ret & _
            ". Score = " & score & ".")
            Label2.Text = Val(ret)
            GetUserInfo()
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
        ElseIf ret = 0 Then
            myUtil.WriteLog("Fingerprint not Found.")
        Else
            myUtil.WriteError(ret)
        End If
        Return ret
    End Function
    Sub getuserinfo()
        Try
            Connection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Connection

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM student WHERE ID = '" & Label2.Text & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()

            txtmatricnum.Text = reader.Item("Matric_Number").ToString
            txtfirstname.Text = reader.Item("First_Name").ToString
            txtlastname.Text = reader.Item("Last_Name").ToString
            txtdepartment.Text = reader.Item("Department").ToString

            'txtlevel.Text = .Item("level").ToString
            'txtdept.Text = reader.Item("department").ToString

            Dim imagepic As Byte() = CType(reader("picture"), Byte())
            Dim ms As New System.IO.MemoryStream(imagepic)
            Dim img As Image = Image.FromStream(ms)
            Me.PictureBox4.Image = img
            'studPic.Image = image.FromFile("image.jpg")
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox4.Refresh()

            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ITalk_Button_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_24.Click
        _UserID = IdentifyFingerprint()
        If _UserID > 0 Then
            '---user found---
            Beep()
            lblmessage.Text = "Student found! Please check information above"

            'btnRegister.Enabled = False
            '---display user's information---
            txtstat.Text = "present"
            getuserinfo()
            '---writes to log file---
            'WriteToLog(_UserID)
        Else
            '---user not found---

            'btnRegister.Enabled = True
            Beep()
            lblmessage.Text = "Student not verified! Please register student"
            ' Register.Show()
        End If
    End Sub

    
    Private Sub ITalk_Button_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_21.Click
        reset()
    End Sub

    Private Sub ITalk_Button_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_22.Click
        attend()
    End Sub

    Sub attend()
        If cbocode.SelectedIndex = 0 Then
            MsgBox("PLease enter a valid information")
        ElseIf txtstat.Text = "Not verified.....please verify" Then
            MsgBox("PLease enter a valid information")
        Else
            Try
                connection = New MySqlConnection
                connection.ConnectionString = "server=localhost; user id=root; password=; database=bas;"

                connection.Open()
                Dim query As String
                query = "insert into attendance (First_Name,Last_Name,Matric_Number,Department,Course_Code,Status,Date)  VALUES('" & txtfirstname.Text & "','" & txtlastname.Text & "','" & txtmatricnum.Text & "', '" & txtdepartment.Text & "','" & cbocode.Text & "','" & txtstat.Text & "','" & txtdate.Text & "')"

                Dim cmd As New MySqlCommand(query, connection)

                cmd.ExecuteNonQuery()
                MsgBox("Attendance  Saved Successfully", vbInformation)
                reset()

                connection.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ITalk_Button_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_23.Click
        Try


            Dim selectQuery As String = "select * from attendance"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, connection)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Sub search()
        connection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("Select  * from attendance  ", connection)

        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        DataGridView2.DataSource = view1
        DataGridView2.Refresh()
        source1.Filter = "[Matric_Number] = '" & label4.Text & "'"
        dr = cmd.ExecuteReader()

        connection.Close()

    End Sub

    Sub count1()
        connection.Open()
        Dim sql As String = "select COUNT(*) FROM attendance"
        Dim cmde As New MySqlCommand(sql, connection)
        dr = cmde.ExecuteReader()
        While (dr.Read())
            Label1.Text = (dr(0).ToString())
        End While
        connection.Close()
    End Sub
   



  
    Sub search1()
        connection.Open()
        Dim ds As DataSet = New DataSet
        Dim da As MySqlDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim source1 As New BindingSource()
        da = New MySqlDataAdapter("Select  * from attendance", connection)
        da.Fill(ds, "Items")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        DataGridView2.DataSource = view1
        DataGridView2.Refresh()
        source1.Filter = "[Date] = '" & lbldate.Text & "'"
        DataGridView2.Refresh()
       
        connection.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        search()
        count1()



    End Sub



    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        search1()
        count1()


    End Sub

    Private Sub removedoctor()
        Try
            connection.Open()
            Dim SQL As String = "DELETE FROM student WHERE Matric_Number = '" & txtmatric.Text & "'"
            cmd = New MySqlCommand(SQL, connection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("deleted successfully", vbInformation)
            reset()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            connection.Close()
        End Try
    End Sub


    Private Sub remove()

        Try
            connection.Open()
            Dim SQL As String = "DELETE FROM attendance WHERE Matric_Number = '" & txtmat.Text & "'"
            cmd = New MySqlCommand(SQL, connection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("deleted successfully", vbInformation)
            reset()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            connection.Close()
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If txtmatric.Text = "" Then
            MsgBox("please enter a matric number", vbCritical)
            txtmatric.Focus()
        Else
            removedoctor()

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtmatric.Text = "" Then
            MsgBox("enter the matric number of a student whose record is to be updated", vbCritical)
        Else
            dbImage1()
            AddNewUser2()
        End If
        
    End Sub

 
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If txtmat.Text = "" Then
            MsgBox("enter a matric number", vbCritical)
        Else
            remove()

        End If
    End Sub

    Private Sub ITalk_Button_25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_25.Click
        End
    End Sub
End Class