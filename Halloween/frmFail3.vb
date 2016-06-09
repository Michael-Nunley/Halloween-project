Public Class frmFail3
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRetry.Click
        'Hides current form
        Me.Visible = False
        'shows level 1
        frmLevel3.Visible = True
        'hides and disables everything but the start button in the level 1 form.
        frmLevel3.cmdWin.Visible = False
        frmLevel3.cmdStart.Visible = True
        frmLevel3.recFail1.Visible = False
        frmLevel3.recFail2.Visible = False
        frmLevel3.recFail3.Visible = False
        frmLevel3.recFail4.Visible = False
        frmLevel3.recFail5.Visible = False
        frmLevel3.recFail6.Visible = False
        frmLevel3.recFail7.Visible = False
        frmLevel3.recFail8.Visible = False
        frmLevel3.recBorder1.Visible = False
        frmLevel3.recBorder2.Visible = False
        frmLevel3.recBorder3.Visible = False
        frmLevel3.recBorder4.Visible = False
    End Sub
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        'Hides current form
        Me.Visible = False
        'Shows the main screen.
        frmMain.Visible = True
    End Sub
End Class