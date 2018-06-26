<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ITalk_ThemeContainer1 = New SecuredAttendance.iTalk.iTalk_ThemeContainer()
        Me.ITalk_Panel1 = New SecuredAttendance.iTalk.iTalk_Panel()
        Me.cbopermission = New SecuredAttendance.iTalk.iTalk_ComboBox()
        Me.ITalk_Button_23 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.ITalk_Label6 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label3 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.txtemail = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.txtfullname = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.ITalk_Label4 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label5 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ITalk_Button_22 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.ITalk_Button_21 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.txtpassword = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.txtUsername = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.ITalk_Label2 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label1 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_ThemeContainer1.SuspendLayout()
        Me.ITalk_Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ITalk_ThemeContainer1
        '
        Me.ITalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Panel1)
        Me.ITalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITalk_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ITalk_ThemeContainer1.Name = "ITalk_ThemeContainer1"
        Me.ITalk_ThemeContainer1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 28)
        Me.ITalk_ThemeContainer1.Sizable = True
        Me.ITalk_ThemeContainer1.Size = New System.Drawing.Size(789, 532)
        Me.ITalk_ThemeContainer1.SmartBounds = False
        Me.ITalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ITalk_ThemeContainer1.TabIndex = 0
        '
        'ITalk_Panel1
        '
        Me.ITalk_Panel1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Panel1.Controls.Add(Me.cbopermission)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Button_23)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label6)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label3)
        Me.ITalk_Panel1.Controls.Add(Me.txtemail)
        Me.ITalk_Panel1.Controls.Add(Me.txtfullname)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label4)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label5)
        Me.ITalk_Panel1.Controls.Add(Me.PictureBox2)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Button_22)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Button_21)
        Me.ITalk_Panel1.Controls.Add(Me.txtpassword)
        Me.ITalk_Panel1.Controls.Add(Me.txtUsername)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label2)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label1)
        Me.ITalk_Panel1.Location = New System.Drawing.Point(87, 82)
        Me.ITalk_Panel1.Name = "ITalk_Panel1"
        Me.ITalk_Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.ITalk_Panel1.Size = New System.Drawing.Size(602, 365)
        Me.ITalk_Panel1.TabIndex = 12
        Me.ITalk_Panel1.Text = "Upload"
        '
        'cbopermission
        '
        Me.cbopermission.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cbopermission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbopermission.DropDownHeight = 100
        Me.cbopermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopermission.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbopermission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbopermission.FormattingEnabled = True
        Me.cbopermission.HoverSelectionColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cbopermission.IntegralHeight = False
        Me.cbopermission.ItemHeight = 20
        Me.cbopermission.Items.AddRange(New Object() {"", "Administrator", "Staff"})
        Me.cbopermission.Location = New System.Drawing.Point(137, 243)
        Me.cbopermission.Name = "cbopermission"
        Me.cbopermission.Size = New System.Drawing.Size(226, 26)
        Me.cbopermission.StartIndex = 0
        Me.cbopermission.TabIndex = 16
        '
        'ITalk_Button_23
        '
        Me.ITalk_Button_23.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_23.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_23.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_23.Image = Nothing
        Me.ITalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_23.Location = New System.Drawing.Point(429, 225)
        Me.ITalk_Button_23.Name = "ITalk_Button_23"
        Me.ITalk_Button_23.Size = New System.Drawing.Size(132, 27)
        Me.ITalk_Button_23.TabIndex = 15
        Me.ITalk_Button_23.Text = "Upload"
        Me.ITalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Label6
        '
        Me.ITalk_Label6.AutoSize = True
        Me.ITalk_Label6.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label6.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label6.Location = New System.Drawing.Point(20, 245)
        Me.ITalk_Label6.Name = "ITalk_Label6"
        Me.ITalk_Label6.Size = New System.Drawing.Size(76, 18)
        Me.ITalk_Label6.TabIndex = 13
        Me.ITalk_Label6.Text = "Permission"
        '
        'ITalk_Label3
        '
        Me.ITalk_Label3.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label3.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label3.Location = New System.Drawing.Point(161, 23)
        Me.ITalk_Label3.Name = "ITalk_Label3"
        Me.ITalk_Label3.Size = New System.Drawing.Size(275, 40)
        Me.ITalk_Label3.TabIndex = 7
        Me.ITalk_Label3.Text = "Registration Panel"
        Me.ITalk_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.Transparent
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(137, 200)
        Me.txtemail.MaxLength = 30
        Me.txtemail.Multiline = False
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = False
        Me.txtemail.Size = New System.Drawing.Size(226, 28)
        Me.txtemail.TabIndex = 12
        Me.txtemail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtemail.UseSystemPasswordChar = False
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtfullname.ForeColor = System.Drawing.Color.Black
        Me.txtfullname.Location = New System.Drawing.Point(137, 159)
        Me.txtfullname.MaxLength = 30
        Me.txtfullname.Multiline = False
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.ReadOnly = False
        Me.txtfullname.Size = New System.Drawing.Size(226, 28)
        Me.txtfullname.TabIndex = 11
        Me.txtfullname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtfullname.UseSystemPasswordChar = False
        '
        'ITalk_Label4
        '
        Me.ITalk_Label4.AutoSize = True
        Me.ITalk_Label4.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label4.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label4.Location = New System.Drawing.Point(24, 200)
        Me.ITalk_Label4.Name = "ITalk_Label4"
        Me.ITalk_Label4.Size = New System.Drawing.Size(41, 18)
        Me.ITalk_Label4.TabIndex = 10
        Me.ITalk_Label4.Text = "Email"
        '
        'ITalk_Label5
        '
        Me.ITalk_Label5.AutoSize = True
        Me.ITalk_Label5.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label5.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label5.Location = New System.Drawing.Point(24, 159)
        Me.ITalk_Label5.Name = "ITalk_Label5"
        Me.ITalk_Label5.Size = New System.Drawing.Size(72, 18)
        Me.ITalk_Label5.TabIndex = 9
        Me.ITalk_Label5.Text = "Full Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(429, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(261, 307)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(102, 27)
        Me.ITalk_Button_22.TabIndex = 6
        Me.ITalk_Button_22.Text = "Close"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(137, 307)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(102, 27)
        Me.ITalk_Button_21.TabIndex = 5
        Me.ITalk_Button_21.Text = "Submit"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(137, 125)
        Me.txtpassword.MaxLength = 30
        Me.txtpassword.Multiline = False
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.ReadOnly = False
        Me.txtpassword.Size = New System.Drawing.Size(226, 28)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpassword.UseSystemPasswordChar = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(137, 84)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(226, 28)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'ITalk_Label2
        '
        Me.ITalk_Label2.AutoSize = True
        Me.ITalk_Label2.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label2.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label2.Location = New System.Drawing.Point(24, 125)
        Me.ITalk_Label2.Name = "ITalk_Label2"
        Me.ITalk_Label2.Size = New System.Drawing.Size(69, 18)
        Me.ITalk_Label2.TabIndex = 1
        Me.ITalk_Label2.Text = "Password"
        '
        'ITalk_Label1
        '
        Me.ITalk_Label1.AutoSize = True
        Me.ITalk_Label1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label1.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label1.Location = New System.Drawing.Point(24, 84)
        Me.ITalk_Label1.Name = "ITalk_Label1"
        Me.ITalk_Label1.Size = New System.Drawing.Size(80, 18)
        Me.ITalk_Label1.TabIndex = 0
        Me.ITalk_Label1.Text = "Username "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 532)
        Me.Controls.Add(Me.ITalk_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ITalk_ThemeContainer1.ResumeLayout(False)
        Me.ITalk_Panel1.ResumeLayout(False)
        Me.ITalk_Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ITalk_ThemeContainer1 As SecuredAttendance.iTalk.iTalk_ThemeContainer
    Friend WithEvents ITalk_Panel1 As SecuredAttendance.iTalk.iTalk_Panel
    Friend WithEvents ITalk_Label6 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents txtemail As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtfullname As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents ITalk_Label4 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label5 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ITalk_Label3 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Button_22 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_21 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents txtpassword As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtUsername As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents ITalk_Label2 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label1 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Button_23 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents cbopermission As SecuredAttendance.iTalk.iTalk_ComboBox
End Class




