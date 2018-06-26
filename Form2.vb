Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    Dim imgName1 As String
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub ITalk_Button_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_21.Click
        If txtUsername.Text = "" Then
            MsgBox("Please specify a username in the given field", vbCritical)
            txtUsername.Focus()
        ElseIf Len(txtUsername.Text) < 6 Then
            MsgBox("username must be atleast six characters", vbCritical)
            txtUsername.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please specify a password in the given field", vbCritical)
            txtpassword.Focus()
        ElseIf Len(txtpassword.Text) < 6 Then
            MsgBox("password must be atleast six characters", vbCritical)
            txtpassword.Focus()
        ElseIf txtfullname.Text = "" Then
            MsgBox("full name field cannot be empty ,please enter your full name ", vbCritical)
            txtfullname.Focus()
        ElseIf Len(txtfullname.Text) < 4 Then
            MsgBox("full name field must be at least four characters", vbCritical)
            txtfullname.Focus()
        ElseIf txtemail.Text = "" Then
            MsgBox("email field cannot be empty ,please enter your email address ", vbCritical)
            txtemail.Focus()
        ElseIf Len(txtemail.Text) < 9 Then
            MsgBox("email field must be at least 9 characters", vbCritical)
            txtemail.Focus()
        ElseIf cbopermission.SelectedIndex = 0 Then
            MsgBox("Please select permission, this will determine access level", vbCritical)
            cbopermission.Focus()
        ElseIf cbdept.SelectedIndex = 0 Then
            MsgBox("please select your department", vbCritical)
        ElseIf cbogender.SelectedIndex = 0 Then
            MsgBox("please select your gender", vbCritical)
        ElseIf txtcc.Text = "" Then
            MsgBox("please enter your course code", vbCritical)
            txtcc.Focus()
        ElseIf Len(txtcc.Text) < 6 Then
            MsgBox("length too short", vbCritical)
            txtcc.Focus()
        ElseIf txtct.Text = "" Then
            MsgBox("please enter your course title", vbCritical)
            txtct.Focus()
        ElseIf Len(txtct.Text) < 7 Then
            MsgBox("length too short", vbCritical)
            txtct.Focus()


        Else
            Try
                connection = New MySqlConnection
                connection.ConnectionString = "server=localhost; user id=root; password=; database=bas;"
                If imgName1 <> "" Then
                    Dim fs As FileStream
                    fs = New FileStream(imgName1, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()
                    connection.Open()
                    Dim query As String
                    query = "insert into users (fullname,username,password,email,permission,picture,Gender,Department,Course_Title,Course_Code)  VALUES('" & txtfullname.Text & "','" & txtUsername.Text & "','" & txtpassword.Text & "', '" & txtemail.Text & "','" & cbopermission.Text & "',@picture,'" & cbogender.Text & "','" & cbdept.Text & "','" & txtct.Text & "','" & txtcc.Text & "')"
                    Dim imgParam As New MySqlParameter()
                    imgParam.MySqlDbType = MySqlDbType.Binary
                    imgParam.ParameterName = "picture"
                    imgParam.Value = picByte
                    Dim cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.Add(imgParam)
                    cmd.ExecuteNonQuery()
                    MsgBox("Information Saved Successfully", vbInformation)
                    clear()
                    connection.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub ITalk_ThemeContainer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_ThemeContainer1.Click

    End Sub

    Private Sub ITalk_Button_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_23.Click
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

    Private Sub ITalk_Button_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_22.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Public Sub clear()
        txtemail.Text = "'"
        txtUsername.Text = ""
        txtfullname.Text = ""
        txtpassword.Text = ""
        cbopermission.SelectedIndex = 0
        PictureBox2.Image = BackgroundImage
        cbdept.SelectedIndex = 0
        cbogender.SelectedIndex = 0
        txtcc.Text = ""
        txtct.Text = ""

    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ToolStripStatusLabel2.Text = Now
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class