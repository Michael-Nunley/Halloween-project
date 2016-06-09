Public Class frmHelp

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        'To go back, we set this current form's visibility to false. (me) and set the main form's visibility to true (frmMain)
        Me.Visible = False
        frmMain.Visible = True
    End Sub
End Class