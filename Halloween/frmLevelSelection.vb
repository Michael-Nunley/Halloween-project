Public Class frmLevelSelection
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        'To go "back" I hide the current form, and put the visibility of the main form to true.
        Me.Visible = False
        frmMain.Visible = True
    End Sub
    Private Sub cmdLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevel1.Click
        'Hides current form
        Me.Visible = False
        'Shows level 1
        frmLevel1.Visible = True
        'hides everything but start button.
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
    Private Sub cmdLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevel2.Click
        'Hides current form
        Me.Visible = False
        'Shows level 2
        frmLevel2.Visible = True
        'hides everything but start button.
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
    Private Sub cmdLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevel3.Click
        'Shows level 3
        frmLevel3.Visible = True
        'Hides current form
        Me.Visible = False
        'hides everything but start button.
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ends program
        End
    End Sub
End Class