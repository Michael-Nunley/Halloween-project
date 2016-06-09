Public Class frmMain
    'These are the variables that are shared for the entire program to set to either true or false
    'They represent if they have completed that level.
    Shared Property Level1 As Boolean = False
    Shared Property Level2 As Boolean = False
    Shared Property Level3 As Boolean = False
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdLevelSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevelSelection.Click
        'Hides current form
        Me.Visible = False
        'Shows the level selection form
        frmLevelSelection.Visible = True
    End Sub
    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click
        'Hides the main form
        Me.Visible = False
        'Shows help form
        frmHelp.Visible = True
    End Sub
    Private Sub tmrLevelProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLevelProgress.Tick
        'If level one is completed, 
        If Level1 = True Then
            'Have the first candy visibile
            picCandy1.Visible = True
            'Add to the progress bar
            progLevelProgress.Value = 1
        ElseIf Level2 = True Then
            picCandy2.Visible = True
            progLevelProgress.Value = 2
        ElseIf Level3 = True Then
            picCandy3.Visible = True
            'Show the winnder label
            lblWinner.Visible = True
            progLevelProgress.Value = 3
        End If
        'To enable the rest of the levels, they have to complete the level before.
        If progLevelProgress.Value = 1 Then
            'If level one is done, enable the button to start level 2
            frmLevelSelection.cmdLevel2.Enabled = True
        ElseIf progLevelProgress.Value = 2 Then
            'If level two is done, enable the button to start level 3
            frmLevelSelection.cmdLevel3.Enabled = True
        End If
    End Sub
End Class
