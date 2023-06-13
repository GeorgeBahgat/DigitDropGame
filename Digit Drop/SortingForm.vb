Public Class SortingForm
    Sub BubbleSort()  ' O(n^2)
        Dim itemCount As Integer = ListBox2.Items.Count         ' O(1)
        For i As Integer = 0 To itemCount - 2                   ' O(n)
            For j As Integer = 0 To itemCount - i - 2           ' O(n)
                Dim currentItem As Integer = CInt(ListBox2.Items(j))         ' O(1)
                Dim nextItem As Integer = CInt(ListBox2.Items(j + 1))        ' O(1)
                ' قم بتبديل المواضع بين العنصر الحالي والعنصر التالي

                If currentItem > nextItem Then                               ' O(1)
                    ListBox2.Items(j) = nextItem                             ' O(1)
                    ListBox2.Items(j + 1) = currentItem                      ' O(1)
                End If
            Next j
        Next i
    End Sub
    Private Sub GameForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Down Then
            If ListBox1.SelectedIndex <> ListBox1.Items.Count - 1 Then
                ListBox1.SelectedIndex += 1                           ' O(1)
                ArrowPic.Location = New Point(ArrowPic.Location.X, ArrowPic.Location.Y + 48)  ' O(1)
            End If
        End If

        If e.KeyCode = Keys.Up Then
            If ListBox1.SelectedIndex = 0 Or ListBox1.SelectedIndex = -1 Then
                ListBox1.SelectedIndex = 0                           ' O(1)
            Else
                ArrowPic.Location = New Point(ArrowPic.Location.X, ArrowPic.Location.Y - 48)  ' O(1)
                ListBox1.SelectedIndex -= 1                          ' O(1)
            End If
        End If

        If e.KeyCode = Keys.Space Then
            If ListBox1.SelectedIndex <> ListBox1.Items.Count - 1 Then
                Dim index1 As Integer = ListBox1.SelectedIndex       ' O(1)
                Dim index2 As Integer = ListBox1.SelectedIndex + 1   ' O(1)

                ' Get the values at the selected indices
                Dim value1 As Integer = ListBox1.Items(index1)        ' O(1)
                Dim value2 As Integer = ListBox1.Items(index2)        ' O(1)

                If value2 < value1 Then
                    ListBox1.Items(index1) = value2                   ' O(1)
                    ListBox1.Items(index2) = value1                   ' O(1)
                End If
            End If
        End If

    End Sub
    Sub checkmatching()   ' O(n)
        Dim match As Boolean = True   ' O(1)

        For i As Integer = 0 To ListBox1.Items.Count - 1           ' O(n)
            If ListBox1.Items(i).ToString() <> ListBox2.Items(i).ToString() Then  ' O(1)
                match = False                                      ' O(1)
                Exit For                                           ' O(1)
            End If
        Next i


        If match Then                                              ' O(1)
            Timer1.Stop()                                          ' O(1)
            MsgBox("You Win :)", vbInformation)                    ' O(1)
            Me.Hide()                                              ' O(1)

            ArrowPic.Location = New Point(ArrowPic.Location.X, 18)  ' O(1)
            ListBox1.SelectedIndex = 0                              ' O(1)
            LevelsForm.Show()                                       ' O(1)
            If GameForm.LevelLabel.Text = "Level 1" Then            ' O(1)
                LevelsForm.LockPicture1.Hide()                      ' O(1)
                LevelsForm.Level2Button.Enabled = True              ' O(1)
            End If
            If GameForm.LevelLabel.Text = "Level 2" Then            ' O(1)
                LevelsForm.LockPicture2.Hide()                      ' O(1)
                LevelsForm.Level3Button.Enabled = True              ' O(1)
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' O(n^2)
        checkmatching()                          ' O(n)

        If SortingTime.Text = 0 Then             ' O(1)
            Timer1.Stop()                        ' O(1)
            MsgBox("You Lost :(", vbCritical)    ' O(1)
            Me.Hide()                            ' O(1)

            ArrowPic.Location = New Point(ArrowPic.Location.X, 18)  ' O(1)
            ListBox1.SelectedIndex = 0           ' O(1)
            LevelsForm.Show()                    ' O(1)
        End If
        SortingTime.Text -= 1                    ' O(1)
    End Sub
    Private Sub StartPicture_Click(sender As Object, e As EventArgs) Handles StartPicture.Click
        msgPanel.Hide()  ' O(1)
        Timer1.Start()   ' O(1)
    End Sub

    Private Sub SortingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class