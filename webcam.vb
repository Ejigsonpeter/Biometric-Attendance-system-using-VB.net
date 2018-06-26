Public Class webcam

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = Me.PicStaff.Height
        Dim iWidth As Integer = Me.PicStaff.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PicStaff.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PicStaff.Width, PicStaff.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub
    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub B_Ok_Or_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Ok_Or_Cancel.Click
        
        Call OpenPreviewWindow()
    End Sub

    Private Sub BCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcapture.Click

        Dim Data As IDataObject
        Dim Bmap As Image
        SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
        Data = Clipboard.GetDataObject()
        If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
            Picstaff.Image = Bmap
            ClosePreviewWindow()
            MsgBox("Captured...", MsgBoxStyle.Information, "Captured...")
        End If

    End Sub
    Private Sub webcam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenPreviewWindow()
        Bcapture.Focus()
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub ITalk_Button_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_Button_22.Click
        
        Form3.PictureBox2.Image = Me.Picstaff.Image
        MsgBox("Picture Uploaded Successfully.....click ok to continue", vbInformation)



    End Sub

    Private Sub ITalk_ThemeContainer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITalk_ThemeContainer1.Click

    End Sub
End Class