Class MainWindow 

    Private Sub GGclick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn1.Click
        Dim a As Integer = TxtInput1.Text
        Dim b As Integer = TxtInput2.Text
        Dim c As Integer = TxtInput3.Text
        Dim d As Integer = TxtInput4.Text
        Dim f As Integer = TxtInput5.Text
        Dim g As Integer = TxtInput6.Text
        Dim h As Integer = TxtInput7.Text
        Dim i As Integer = TxtInput8.Text
        Dim j As Integer = TxtInput9.Text
        Dim k As Integer = TxtInput10.Text
        Dim l As Integer = TxtInput11.Text
        Dim m As Integer = TxtInput12.Text
        Dim sw, qZ, aveSw, aveQz, aveRet, aveEx, aveEx2, aveEx3, fG As Double



        Sw = ((a + b + c + d + f) / 5)
        Qz = ((g + h + i) / 3)
        AveSw = Sw * 0.15
        AveQz = Qz * 0.15
        AveRet = j * 0.1
        AveEx = k * 0.15
        AveEx2 = l * 0.2
        AveEx3 = m * 0.25
        fG = aveSw + aveQz + aveRet + aveEx + aveEx2 + aveEx3

        If fG <= 100 And fG >= 96 Then
            TxtOutput2.Text = "1.00"
            TxtOutput3.Text = "Excellent"
        ElseIf fG <= 95 And fG >= 94 Then
            TxtOutput2.Text = "1.25"
            TxtOutput3.Text = "Very Good"
        ElseIf fG <= 93 And fG >= 92 Then
            TxtOutput2.Text = "1.50"
            TxtOutput3.Text = "Very Good"
        ElseIf fG <= 91 And fG >= 89 Then
            TxtOutput2.Text = "1.75"
            TxtOutput3.Text = "Very Good"
        ElseIf fG <= 88 And fG >= 87 Then
            TxtOutput2.Text = "2.00"
            TxtOutput3.Text = "Good"
        ElseIf fG <= 86 And fG >= 84 Then
            TxtOutput2.Text = "2.25"
            TxtOutput3.Text = "Good"
        ElseIf fG <= 83 And fG >= 82 Then
            TxtOutput2.Text = "2.5"
            TxtOutput3.Text = "Fair"
        ElseIf fG <= 81 And fG >= 79 Then
            TxtOutput2.Text = "2.75"
            TxtOutput3.Text = "Fair"
        ElseIf fG <= 78 And fG >= 75 Then
            TxtOutput2.Text = "3.00"
            TxtOutput3.Text = "Pass"
        Else
            TxtOutput2.Text = "5.00"
            TxtOutput3.Text = "Failure"
        End If

        TxtOutput1.Text = fG


    End Sub
End Class
