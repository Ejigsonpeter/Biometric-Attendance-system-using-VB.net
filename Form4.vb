Public Class Form4

    Private Sub ITalk_Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Label5.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1

       
        End If

    End Sub

    Private Sub label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Initiazing software modules.........."
        ElseIf ProgressBar1.Value = 20 Then
            Label1.Text = "Loading Fngerprint  API modules........."
        ElseIf ProgressBar1.Value = 30 Then
            Label1.Text = "Initializing Sensor program modules"
        ElseIf ProgressBar1.Value = 40 Then
            Label1.Text = "Initializing Grandule Fingerprint SDK modules.........."
        ElseIf ProgressBar1.Value = 50 Then
            Label1.Text = "Loading.......10%"
        ElseIf ProgressBar1.Value = 60 Then
            Label1.Text = "Loading.......20%"
        ElseIf ProgressBar1.Value = 65 Then
            Label1.Text = "Loading.......35%"
        ElseIf ProgressBar1.Value = 70 Then
            Label1.Text = "Loading.......60%"
        ElseIf ProgressBar1.Value = 80 Then
            Label1.Text = "Loading.......80%"
        ElseIf ProgressBar1.Value = 90 Then
            Label1.Text = "laoding new modules......."
        ElseIf ProgressBar1.Value = 100 Then
            Label1.Text = "Loading complete.......100%"

            Me.Hide()
            Form1.Show()
            Timer1.Enabled = False
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
End Class