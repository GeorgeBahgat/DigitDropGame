Public Class GameForm
    Private Sub GameForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Box.Location = New Point(e.X - Box.Width / 2, Box.Location.Y)  ' O(1)
    End Sub
    Dim score As Integer = 0
    Public Property MaxTarget As Integer    ' O(1)
    Public Property MinTarget As Integer    ' O(1)
    Public Property MinRandomNumber As Integer  ' O(1)
    Public Property MaxRandomNumber As Integer   ' O(1)
    Sub NEWNUMBER() 'O(1)
        Dim random As New Random()                            ' O(1)
        Dim randomlocation As Integer = random.Next(260, 941) ' O(1)
        Dim randomvaluo As Integer = random.Next(MinRandomNumber, MaxRandomNumber)  ' O(1)
        theNum.Location = New Point(randomlocation, 0)        ' O(1)
        theNum.Text = randomvaluo                             ' O(1)
    End Sub
    Sub MoveItemsToSortForm()                                   ' O(1)
        SortingForm.ListBox1.Items.Clear()                      ' O(1)
        SortingForm.ListBox2.Items.Clear()                      ' O(1)
        For Each item As Object In ListBox1.Items               ' O(1)
            ' Add the item to ListBox1 on SortingForm
            SortingForm.ListBox1.Items.Add(item)                ' O(1)
            SortingForm.ListBox2.Items.Add(item)                ' O(1)
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' O(n^3)
        theNum.Location = New Point(theNum.Location.X, theNum.Location.Y + 10)   ' O(1)
        Dim XstartpointBox As Integer = Box.Location.X                           ' O(1)
        Dim XendpointBox As Integer = Box.Location.X + Box.Width                 ' O(1)
        Dim YstartpointBox As Integer = Box.Location.Y                           ' O(1)
        Dim YendpointBox As Integer = Box.Location.Y + Box.Height                ' O(1)
        If theNum.Location.Y >= YstartpointBox Then                              ' O(1)
            If XstartpointBox <= theNum.Location.X And theNum.Location.X <= XendpointBox Then
                score += theNum.Text                                             ' O(1)
                Label5.Text = score                                              ' O(1)
                ListBox1.Items.Add(theNum.Text)                                  ' O(1)
                NEWNUMBER()                                                      ' O(1)
            End If
        End If
        If theNum.Location.Y > YendpointBox Then                                 ' O(1)
            NEWNUMBER()                                                          ' O(1)
        End If

        If score > MinTarget And score < MaxTarget Then                          ' O(1)
            Label9.Text = "You Win :)"                                           ' O(1)
            Label9.ForeColor = Color.Green                                       ' O(1)
            Button2.Text = "Round 2"                                             ' O(1)
            Timer1.Stop()                                                        ' O(1)
            Timer2.Stop()                                                        ' O(1)
            GroupBox2.Show()                                                     ' O(1)
            NEWNUMBER()                                                          ' O(1)
            MoveItemsToSortForm()                                                ' O(1)
            SortingForm.BubbleSort()                                             ' O(n^2)
            SortingForm.ListBox1.SelectedIndex = 0                               ' O(1)
        End If

        If score > MaxTarget Then                                                ' O(1)
            Label9.Text = "You Lost :("                                          ' O(1)
            Label9.ForeColor = Color.Red                                         ' O(1)
            Button2.Text = "Try again"                                           ' O(1)
            Timer1.Stop()                                                        ' O(1)
            Timer2.Stop()                                                        ' O(1)
            GroupBox2.Show()                                                     ' O(1)
            NEWNUMBER()                                                          ' O(1)
        End If
        If ListBox1.Items.Count > 0 Then                                         ' O(1)
            Dim lastItem As String = ListBox1.Items(ListBox1.Items.Count - 1).ToString()  ' O(1)
            If theNum.Text = lastItem Then                                        ' O(1)
                NEWNUMBER()                                                      ' O(1)
            End If
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TimeLabel.Text -= 1                ' O(1)
        If TimeLabel.Text = 0 Then         ' O(1)
            Timer1.Stop()                  ' O(1)
            Timer2.Stop()                  ' O(1)
            Button2.Text = "Try again"     ' O(1)
            GroupBox2.Show()               ' O(1)
            NEWNUMBER()                    ' O(1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Try again" Then   ' O(1)
            GroupBox2.Hide()                 ' O(1)
            Me.Hide()                        ' O(1)
            LevelsForm.Show()                ' O(1)
        End If
        If Button2.Text = "Round 2" Then      ' O(1)
            GroupBox2.Hide()                  ' O(1)
            Me.Hide()                         ' O(1)
            SortingForm.Show()                ' O(1)
            SortingForm.msgPanel.Show()       ' O(1)
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer1.Start()          ' O(1)
        Timer2.Start()          ' O(1)
        MSGPanel.Hide()         ' O(1)
        score = 0               ' O(1)
        Label5.Text = 0         ' O(1)
        NEWNUMBER()             ' O(1)
    End Sub

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
