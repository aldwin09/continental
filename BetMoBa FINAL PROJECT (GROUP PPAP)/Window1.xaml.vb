Class Window1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click

        txtInputYOU.Text = String.Empty
        txtInputComp.Text = String.Empty
        txtInputRes.Text = String.Empty
        txtScore1.Text = 0
        txtScore2.Text = 0
        txtInputYOU.Focus()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click

        Dim Round As New Random
        Dim Input As Integer
        Dim Computer As Integer
        Dim Output As Integer
        Dim Score1 As Integer
        Dim Score2 As Integer

        Output = Round.Next(1, 10)
        txtInputYOU.Text = Output

        If Output > Computer Then
            txtInputRes.Text = "You Win!"
            Score1 = Val(txtScore1.Text) + 1
            txtScore1.Text = Score1

        ElseIf Output > Computer Then
            txtInputRes.Text = "You Lose!"
            Score1 = Val(txtScore2.Text) + 1
            txtScore2.Text = Score2

        Else
            txtInputRes.Text = "Draw"

        End If

        If txtScore1.Text = 3 Then
            MessageBox.Show("Congrats, You Win!", txtInputYOU.Text, MessageBoxButton.OK, MessageBoxImage.Information)
            txtInputYOU.Text = 1
            txtInputComp.Text = 1
            txtInputRes.Text = String.Empty
            txtScore1.Text = 0
            txtScore2.Text = 0
        End If

        Computer = Round.Next(1, 10)
        txtInputComp.Text = Computer
        If Computer > Input Then
            txtInputComp.Text = Computer
            txtInputRes.Text = "You Win!"
            Score2 = Val(txtScore2.Text) + 1
            txtScore2.Text = Score2

        ElseIf Output > Computer Then
            txtInputComp.Text = Computer
            txtInputRes.Text = "You Lose!"
            Score1 = Val(txtScore1.Text) + 1
            txtScore1.Text = Score1
        End If

        If txtScore2.Text = 3 Then
            MessageBox.Show("Sorry, You Lose!")
            txtInputYOU.Text = 1
            txtInputComp.Text = 1
            txtInputRes.Text = String.Empty
            txtScore1.Text = 0
            txtScore2.Text = 0
            txtInputComp.Text = Computer
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click

        Me.Close()

    End Sub
End Class
