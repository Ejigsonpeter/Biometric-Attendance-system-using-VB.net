<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class webcam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(webcam))
        Me.ITalk_ThemeContainer1 = New SecuredAttendance.iTalk.iTalk_ThemeContainer()
        Me.ITalk_GroupBox2 = New SecuredAttendance.iTalk.iTalk_GroupBox()
        Me.ITalk_Button_22 = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.B_Ok_Or_Cancel = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.Bcapture = New SecuredAttendance.iTalk.iTalk_Button_2()
        Me.ITalk_GroupBox1 = New SecuredAttendance.iTalk.iTalk_GroupBox()
        Me.Picstaff = New System.Windows.Forms.PictureBox()
        Me.ITalk_ThemeContainer1.SuspendLayout()
        Me.ITalk_GroupBox2.SuspendLayout()
        Me.ITalk_GroupBox1.SuspendLayout()
        CType(Me.Picstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ITalk_ThemeContainer1
        '
        Me.ITalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_GroupBox2)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_GroupBox1)
        Me.ITalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITalk_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ITalk_ThemeContainer1.Name = "ITalk_ThemeContainer1"
        Me.ITalk_ThemeContainer1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 28)
        Me.ITalk_ThemeContainer1.Sizable = True
        Me.ITalk_ThemeContainer1.Size = New System.Drawing.Size(556, 385)
        Me.ITalk_ThemeContainer1.SmartBounds = False
        Me.ITalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ITalk_ThemeContainer1.TabIndex = 0
        Me.ITalk_ThemeContainer1.Text = "Photo Capture"
        '
        'ITalk_GroupBox2
        '
        Me.ITalk_GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_GroupBox2.Controls.Add(Me.ITalk_Button_22)
        Me.ITalk_GroupBox2.Controls.Add(Me.B_Ok_Or_Cancel)
        Me.ITalk_GroupBox2.Controls.Add(Me.Bcapture)
        Me.ITalk_GroupBox2.Location = New System.Drawing.Point(93, 283)
        Me.ITalk_GroupBox2.MinimumSize = New System.Drawing.Size(136, 50)
        Me.ITalk_GroupBox2.Name = "ITalk_GroupBox2"
        Me.ITalk_GroupBox2.Padding = New System.Windows.Forms.Padding(5, 28, 5, 5)
        Me.ITalk_GroupBox2.Size = New System.Drawing.Size(379, 71)
        Me.ITalk_GroupBox2.TabIndex = 1
        Me.ITalk_GroupBox2.Text = "Control"
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(121, 31)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(103, 27)
        Me.ITalk_Button_22.TabIndex = 19
        Me.ITalk_Button_22.Text = "Upload"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'B_Ok_Or_Cancel
        '
        Me.B_Ok_Or_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.B_Ok_Or_Cancel.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.B_Ok_Or_Cancel.ForeColor = System.Drawing.Color.White
        Me.B_Ok_Or_Cancel.Image = Nothing
        Me.B_Ok_Or_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Ok_Or_Cancel.Location = New System.Drawing.Point(230, 31)
        Me.B_Ok_Or_Cancel.Name = "B_Ok_Or_Cancel"
        Me.B_Ok_Or_Cancel.Size = New System.Drawing.Size(141, 27)
        Me.B_Ok_Or_Cancel.TabIndex = 18
        Me.B_Ok_Or_Cancel.Text = "Cancel Capture"
        Me.B_Ok_Or_Cancel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Bcapture
        '
        Me.Bcapture.BackColor = System.Drawing.Color.Transparent
        Me.Bcapture.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Bcapture.ForeColor = System.Drawing.Color.White
        Me.Bcapture.Image = Nothing
        Me.Bcapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bcapture.Location = New System.Drawing.Point(8, 31)
        Me.Bcapture.Name = "Bcapture"
        Me.Bcapture.Size = New System.Drawing.Size(107, 27)
        Me.Bcapture.TabIndex = 17
        Me.Bcapture.Text = "Capture"
        Me.Bcapture.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_GroupBox1
        '
        Me.ITalk_GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_GroupBox1.Controls.Add(Me.Picstaff)
        Me.ITalk_GroupBox1.Location = New System.Drawing.Point(93, 31)
        Me.ITalk_GroupBox1.MinimumSize = New System.Drawing.Size(136, 50)
        Me.ITalk_GroupBox1.Name = "ITalk_GroupBox1"
        Me.ITalk_GroupBox1.Padding = New System.Windows.Forms.Padding(5, 28, 5, 5)
        Me.ITalk_GroupBox1.Size = New System.Drawing.Size(379, 245)
        Me.ITalk_GroupBox1.TabIndex = 0
        Me.ITalk_GroupBox1.Text = "Capture"
        '
        'Picstaff
        '
        Me.Picstaff.BackgroundImage = CType(resources.GetObject("Picstaff.BackgroundImage"), System.Drawing.Image)
        Me.Picstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picstaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picstaff.Location = New System.Drawing.Point(105, 40)
        Me.Picstaff.Name = "Picstaff"
        Me.Picstaff.Size = New System.Drawing.Size(189, 187)
        Me.Picstaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picstaff.TabIndex = 16
        Me.Picstaff.TabStop = False
        '
        'webcam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 385)
        Me.Controls.Add(Me.ITalk_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "webcam"
        Me.Text = "Photo Capture"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ITalk_ThemeContainer1.ResumeLayout(False)
        Me.ITalk_GroupBox2.ResumeLayout(False)
        Me.ITalk_GroupBox1.ResumeLayout(False)
        CType(Me.Picstaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ITalk_ThemeContainer1 As SecuredAttendance.iTalk.iTalk_ThemeContainer
    Friend WithEvents ITalk_GroupBox2 As SecuredAttendance.iTalk.iTalk_GroupBox
    Friend WithEvents ITalk_GroupBox1 As SecuredAttendance.iTalk.iTalk_GroupBox
    Friend WithEvents Bcapture As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents Picstaff As System.Windows.Forms.PictureBox
    Friend WithEvents ITalk_Button_22 As SecuredAttendance.iTalk.iTalk_Button_2
    Friend WithEvents B_Ok_Or_Cancel As SecuredAttendance.iTalk.iTalk_Button_2
End Class


