<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ITalk_Label4 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label6 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.ITalk_Label5 = New SecuredAttendance.iTalk.iTalk_Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New SecuredAttendance.iTalk.iTalk_Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ITalk_Label4
        '
        Me.ITalk_Label4.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label4.ForeColor = System.Drawing.Color.White
        Me.ITalk_Label4.Location = New System.Drawing.Point(12, -8)
        Me.ITalk_Label4.Name = "ITalk_Label4"
        Me.ITalk_Label4.Size = New System.Drawing.Size(837, 82)
        Me.ITalk_Label4.TabIndex = 9
        Me.ITalk_Label4.Text = "SECURED BIOMETRIC BASED  ATTENDANCE SYSTEM"
        Me.ITalk_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ITalk_Label6
        '
        Me.ITalk_Label6.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label6.ForeColor = System.Drawing.Color.White
        Me.ITalk_Label6.Location = New System.Drawing.Point(321, 454)
        Me.ITalk_Label6.Name = "ITalk_Label6"
        Me.ITalk_Label6.Size = New System.Drawing.Size(317, 27)
        Me.ITalk_Label6.TabIndex = 13
        Me.ITalk_Label6.Text = "(Supervised By :  Mr P.S Idoko)"
        Me.ITalk_Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ITalk_Label5
        '
        Me.ITalk_Label5.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Label5.ForeColor = System.Drawing.Color.White
        Me.ITalk_Label5.Location = New System.Drawing.Point(166, 424)
        Me.ITalk_Label5.Name = "ITalk_Label5"
        Me.ITalk_Label5.Size = New System.Drawing.Size(572, 30)
        Me.ITalk_Label5.TabIndex = 12
        Me.ITalk_Label5.Text = "Developed By : Puke David Sunday     (2014/HND/CPS/090)"
        Me.ITalk_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(795, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(806, 416)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(28, 23)
        Me.ProgressBar1.TabIndex = 99
        Me.ProgressBar1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 30)
        Me.Label1.TabIndex = 100
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ITalk_Label6)
        Me.Controls.Add(Me.ITalk_Label5)
        Me.Controls.Add(Me.ITalk_Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ITalk_Label4 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label6 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents ITalk_Label5 As SecuredAttendance.iTalk.iTalk_Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As SecuredAttendance.iTalk.iTalk_Label
End Class
