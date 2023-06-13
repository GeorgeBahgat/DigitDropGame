
Public Class LevelsForm
    Sub Setlevel(MinTarget As Integer, MaxTarget As Integer, MinRandomNumber As Integer, MaxRandomNumber As Integer, LevelTime As Integer, SortingTime As Integer)
        GameForm.Label7.Text = "You have to collect numbers so that their sum is between " & MinTarget & " and " & MaxTarget  ' O(1)
        GameForm.TargetLabel.Text = MinTarget & " : " & MaxTarget               ' O(1)
        GameForm.MinTarget = MinTarget              ' O(1)
        GameForm.MaxTarget = MaxTarget              ' O(1)
        GameForm.Label8.Text = "You have " & LevelTime & " seconds to do this"      ' O(1)
        GameForm.TimeLabel.Text = LevelTime                 ' O(1)
        GameForm.MinRandomNumber = MinRandomNumber          ' O(1)
        GameForm.MaxRandomNumber = MaxRandomNumber          ' O(1)
        GameForm.ListBox1.Items.Clear()                     ' O(1)
        GameForm.MSGPanel.Show()                            ' O(1)
        SortingForm.SortingTime.Text = SortingTime          ' O(1)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setlevel(50, 60, 1, 12, 60, 12)      ' O(1)
        GameForm.LevelLabel.Text = "Level 1" ' O(1)
        GameForm.Show()                      ' O(1)
    End Sub

    Private Sub Level2Button_Click(sender As Object, e As EventArgs) Handles Level2Button.Click
        Setlevel(100, 115, 10, 30, 40, 12)     ' O(1)
        GameForm.LevelLabel.Text = "Level 2"   ' O(1)
        GameForm.Show()                        ' O(1)
    End Sub

    Private Sub Level3Button_Click(sender As Object, e As EventArgs) Handles Level3Button.Click
        Setlevel(115, 120, 10, 30, 35, 12)          ' O(1)
        GameForm.LevelLabel.Text = "Level 3"        ' O(1)
        GameForm.Show()                             ' O(1)
    End Sub

    Private Sub LevelsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class