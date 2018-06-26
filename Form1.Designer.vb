<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ITalk_ThemeContainer1 = New SecuredAttendance.iTalk.iTalk_ThemeContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ITalk_Label6 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label5 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label4 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Panel1 = New SecuredAttendance.iTalk.iTalk_Panel()
        Me.ITalk_LinkLabel1 = New SecuredAttendance.iTalk.iTalk_LinkLabel()
        Me.ITalk_Label3 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Button_22 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.ITalk_Button_21 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.txtpassword = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.txtUsername = New SecuredAttendance.iTalk.iTalk_TextBox_Small()
        Me.ITalk_Label2 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label1 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ITalk_ThemeContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ITalk_Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ITalk_ThemeContainer1
        '
        Me.ITalk_ThemeContainer1.BackColor = System.Drawing.Color.White
        Me.ITalk_ThemeContainer1.Controls.Add(Me.StatusStrip1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Label6)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Label5)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Label4)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Panel1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ITalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITalk_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ITalk_ThemeContainer1.Name = "ITalk_ThemeContainer1"
        Me.ITalk_ThemeContainer1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 28)
        Me.ITalk_ThemeContainer1.Sizable = True
        Me.ITalk_ThemeContainer1.Size = New System.Drawing.Size(633, 598)
        Me.ITalk_ThemeContainer1.SmartBounds = False
        Me.ITalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ITalk_ThemeContainer1.TabIndex = 0
        Me.ITalk_ThemeContainer1.Text = "Welcome"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(627, 25)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 20)
        Me.ToolStripStatusLabel1.Text = "Date  and Time"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ITalk_Label6
        '
        Me.ITalk_Label6.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label6.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label6.Location = New System.Drawing.Point(144, 461)
        Me.ITalk_Label6.Name = "ITalk_Label6"
        Me.ITalk_Label6.Size = New System.Drawing.Size(361, 29)
        Me.ITalk_Label6.TabIndex = 11
        Me.ITalk_Label6.Text = "(Supervised By :  Mr P.S Idoko)"
        '
        'ITalk_Label5
        '
        Me.ITalk_Label5.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label5.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label5.Location = New System.Drawing.Point(23, 500)
        Me.ITalk_Label5.Name = "ITalk_Label5"
        Me.ITalk_Label5.Size = New System.Drawing.Size(572, 30)
        Me.ITalk_Label5.TabIndex = 10
        Me.ITalk_Label5.Text = "Developed By : Puke David Sunday     (2014/HND/CPS/090)"
        '
        'ITalk_Label4
        '
        Me.ITalk_Label4.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label4.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label4.Location = New System.Drawing.Point(3, 133)
        Me.ITalk_Label4.Name = "ITalk_Label4"
        Me.ITalk_Label4.Size = New System.Drawing.Size(630, 68)
        Me.ITalk_Label4.TabIndex = 8
        Me.ITalk_Label4.Text = "SECURED BIOMETRIC BASED SECUREDATTENDANCE SYSTEM"
        Me.ITalk_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ITalk_Panel1
        '
        Me.ITalk_Panel1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_LinkLabel1)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label3)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Button_22)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Button_21)
        Me.ITalk_Panel1.Controls.Add(Me.txtpassword)
        Me.ITalk_Panel1.Controls.Add(Me.txtUsername)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label2)
        Me.ITalk_Panel1.Controls.Add(Me.ITalk_Label1)
        Me.ITalk_Panel1.Location = New System.Drawing.Point(98, 214)
        Me.ITalk_Panel1.Name = "ITalk_Panel1"
        Me.ITalk_Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.ITalk_Panel1.Size = New System.Drawing.Size(442, 244)
        Me.ITalk_Panel1.TabIndex = 3
        Me.ITalk_Panel1.Text = "ITalk_Panel1"
        '
        'ITalk_LinkLabel1
        '
        Me.ITalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ITalk_LinkLabel1.AutoSize = True
        Me.ITalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ITalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ITalk_LinkLabel1.Location = New System.Drawing.Point(189, 214)
        Me.ITalk_LinkLabel1.Name = "ITalk_LinkLabel1"
        Me.ITalk_LinkLabel1.Size = New System.Drawing.Size(142, 17)
        Me.ITalk_LinkLabel1.TabIndex = 8
        Me.ITalk_LinkLabel1.TabStop = True
        Me.ITalk_LinkLabel1.Text = "Click here To  Register"
        Me.ITalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(202, Byte), Integer))
        '
        'ITalk_Label3
        '
        Me.ITalk_Label3.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label3.ForeColor = System.Drawing.Color.Black
        Me.ITalk_Label3.Location = New System.Drawing.Point(103, 24)
        Me.ITalk_Label3.Name = "ITalk_Label3"
        Me.ITalk_Label3.Size = New System.Drawing.Size(275, 40)
        Me.ITalk_Label3.TabIndex = 7
        Me.ITalk_Label3.Text = "Login Panel"
        Me.ITalk_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(261, 168)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(102, 27)
        Me.ITalk_Button_22.TabIndex = 6
        Me.ITalk_Button_22.Text = "Cancel"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(137, 168)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(102, 27)
        Me.ITalk_Button_21.TabIndex = 5
        Me.ITalk_Button_21.Text = "Login"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(137, 125)
        Me.txtpassword.MaxLength = 20
        Me.txtpassword.Multiline = False
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.ReadOnly = False
        Me.txtpassword.Size = New System.Drawing.Size(226, 28)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(137, 84)
        Me.txtUsername.MaxLength = 20
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(627, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 598)
        Me.Controls.Add(Me.ITalk_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "Form1"
        Me.Text = "Welcome"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ITalk_ThemeContainer1.ResumeLayout(False)
        Me.ITalk_ThemeContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ITalk_Panel1.ResumeLayout(False)
        Me.ITalk_Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ITalk_ThemeContainer1 As SecuredAttendance.iTalk.iTalk_ThemeContainer
    Friend WithEvents ITalk_Panel1 As SecuredAttendance.iTalk.iTalk_Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ITalk_Button_22 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_21 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents txtpassword As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents txtUsername As SecuredAttendance.iTalk.iTalk_TextBox_Small
    Friend WithEvents ITalk_Label2 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label1 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label3 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label4 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label6 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label5 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ITalk_LinkLabel1 As SecuredAttendance.iTalk.iTalk_LinkLabel

End Class




