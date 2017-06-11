Public Class pass
    Dim Strt As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
    Dim token = 0


    Private Sub o_Click(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
        pw.Focus()
    End Sub


    Private Sub ok_Click(sender As Object, e As RoutedEventArgs) Handles ok.Click
        If pw.Password = My.Settings.pass Then
            Strt.Opacity = 1
            Strt.IsEnabled = True
            Strt.Activate()
            token = 1
            Me.Close()

        Else
            token = 0
            Me.Opacity = 0.4
            MessageBox.Show("Sorry, that's not the password! Try again", "Is this really you?", MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Me.Opacity = 1
            pw.Focus()
        End If
    End Sub


    Private Sub o_Click(sender As Object, e As EventArgs) Handles MyBase.Closed
        If token = 0 Then
            MessageBox.Show("Oh no you don't! You can't get access that easily" & vbNewLine & "Everything has been blacked out and disabled. Restart the app and try again", "You shall not advance further", MessageBoxButton.OK, MessageBoxImage.Stop)
        ElseIf token = 1 Then

        End If
    End Sub

    Private Sub ok_Copy_Click(sender As Object, e As RoutedEventArgs) Handles ok_Copy.Click

        End

    End Sub
End Class
