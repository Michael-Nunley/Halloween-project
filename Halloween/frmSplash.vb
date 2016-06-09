Public NotInheritable Class frmSplash
    Dim X As Integer
    Private Sub tmrLoading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoading.Tick
        'Adds 1 to x to count one per second
        'this is essentially counting to 10
        'becuase the progress bar adds 10 per every one value, 100 value is 10 seconds.
        X += 1
        'sets the loading bar's value to what x is.
        progLoading.Value = X
        If progLoading.Value >= 100 Then
            'if the loading value is 100 or higher, set x to 0
            X = 0
            'hide this form
            Me.Visible = False
            'show the main screen
            frmMain.Visible = True
            'And disable the timer just incase. You never can be too safe.
            tmrLoading.Enabled = False
        End If
    End Sub
End Class
