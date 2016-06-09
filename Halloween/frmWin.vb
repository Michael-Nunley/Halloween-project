Public Class frmWin

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMainMenu.Click
        'Shows main screen.
        frmMain.Visible = True
        'Hides current form.
        Me.Visible = False
    End Sub
End Class