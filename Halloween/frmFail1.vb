Public Class frmFail1
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRetry.Click
        'Hides current form
        Me.Visible = False
        'shows level 1
        frmLevel1.Visible = True
        'hides and disables everything but the start button in the level 1 form.
        frmLevel1.cmdWin.Visible = False
        frmLevel1.cmdStart.Visible = True
        frmLevel1.recFail1.Visible = False
        frmLevel1.recFail2.Visible = False
        frmLevel1.recFail3.Visible = False
        frmLevel1.recFail4.Visible = False
        frmLevel1.recBorder1.Visible = False
        frmLevel1.recBorder2.Visible = False
        frmLevel1.recBorder3.Visible = False
        frmLevel1.recBorder4.Visible = False
    End Sub
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        'Hides current form
        Me.Visible = False
        'Shows the main screen.
        frmMain.Visible = True
    End Sub
End Class