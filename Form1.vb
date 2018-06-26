Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataReader
    Dim username As String = ""
    Dim password As String = ""

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = Now
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub ITalk_LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ITalk_LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ITalk_Button_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_21.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; user id=root; password=; database=bas;"

        If txtUsername.Text = "" Then
            MsgBox("Enter your username to login", vbCritical)
            txtUsername.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Enter your password to login", vbCritical)
            txtpassword.Focus()
        Else
            Try
                connection.Open()
                Dim reader As MySqlDataReader
                Dim query As String
                query = "select * from bas.users where username = '" & txtUsername.Text & "' and password = '" & txtpassword.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1

                End While
                If count = 1 Then
                    MsgBox("Access Granted......Click ok to continue", vbInformation)
                    Me.Hide()
                    Form3.Show()
                    ' ElseIf count > 1 Then
                    '    MessageBox.Show("Username and password are duplicate")
                Else
                    MsgBox("Access Denied", vbCritical)
                    txtpassword.Text = ""
                    txtUsername.Text = ""
                    txtUsername.Focus()
                End If

                connection.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub

  

    
    Private Sub ITalk_Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Panel1.Click

    End Sub

    Private Sub ITalk_Button_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_22.Click
        End
    End Sub
End Class
