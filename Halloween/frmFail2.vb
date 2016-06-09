Public Class frmFail2
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRetry.Click
        'Hides current form
        Me.Visible = False
        'shows level 1
        frmLevel2.Visible = True
        'hides and disables everything but the start button in the level 1 form.
        frmLevel2.cmdWin.Visible = False
        frmLevel2.cmdStart.Visible = True
        frmLevel2.recFail1.Visible = False
        frmLevel2.recFail2.Visible = False
        frmLevel2.recFail3.Visible = False
        frmLevel2.recFail4.Visible = False
        frmLevel2.recFail5.Visible = False
        frmLevel2.recFail6.Visible = False
        frmLevel2.recFail7.Visible = False
        frmLevel2.recFail8.Visible = False
        frmLevel2.recFail9.Visible = False
        frmLevel2.recFail10.Visible = False
        frmLevel2.recFail11.Visible = False
        frmLevel2.recBorder1.Visible = False
        frmLevel2.recBorder2.Visible = False
        frmLevel2.recBorder3.Visible = False
        frmLevel2.recBorder4.Visible = False
    End Sub
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        'Hides current form
        Me.Visible = False
        'Shows the main screen.
        frmMain.Visible = True
    End Sub
End Class