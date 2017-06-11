Imports Microsoft.Win32.SaveFileDialog
Imports Microsoft.Win32.FileDialog
Imports System.Windows.Forms

Public Class ct
    Dim Strt As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)

    Private Sub Button1_lick(sender As Object, e As RoutedEventArgs) Handles can.Click

        If backup.IsChecked = True Then

            If path.Text = Nothing Then

                backup.IsChecked = False
                My.Settings.back = backup.IsChecked
                My.Settings.Save()

            Else
                My.Settings.back = True
                My.Settings.bu = path.Text
            End If
        Else

        End If


        Me.Close()
    End Sub


    Private Sub why_Click(sender As Object, e As RoutedEventArgs) Handles why.Click
        Me.Opacity = 0.3
        MessageBox.Show("Enabling this option will create a backup copy of your Billing Register in the form of a text file in your local hard disk, everytime you update your register. It may come in handy during any unfortunate event of data loss or corruption" & vbNewLine & "Enter the path of the folder where you'd like to backup the register", "Information : Backup register", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Opacity = 1
    End Sub



    Private Sub apply_Click(sender As Object, e As RoutedEventArgs) Handles apply.Click

        My.Settings.update = upd.IsChecked

        If upd.IsChecked = True Then
            Strt.inc.Visibility = Windows.Visibility.Hidden
            Strt.no.Width = 393

        Else

            Strt.inc.Visibility = Windows.Visibility.Visible
            Strt.no.Width = 359
        End If


        If backup.IsChecked = True Then

            If path.Text = Nothing Then
                MessageBox.Show("Please enter a location of the folder where you want the register backup to be stored; And make sure it's valid!", "Enter a path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                My.Settings.Save()
                path.Focus()
                Exit Sub
            Else
                My.Settings.back = True
                My.Settings.bu = path.Text
            End If
        Else

            My.Settings.back = False

        End If



        If old.Password = Nothing And _new.Password = Nothing Then

        Else

            If old.Password = My.Settings.pass Then

                If _new.Password = Nothing Then

                    MessageBox.Show("Please enter the new password you'd like to change to", "Enter new password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    My.Settings.Save()
                    _new.Focus()
                    Exit Sub
                Else

                    My.Settings.pass = _new.Password
                    MessageBox.Show("The password has been set" & vbNewLine & "Your new password is : " & My.Settings.pass.ToString(), "Password set!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Else

                MessageBox.Show("The Current password you entered was wrong. Try again", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                My.Settings.Save()
                old.Clear()
                old.Focus()
                Exit Sub

            End If

        End If






        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
        upd.IsChecked = My.Settings.update
        backup.IsChecked = My.Settings.back
        path.Text = My.Settings.bu
        If backup.IsChecked = True Then
            path.IsEnabled = True

        Else
            path.IsEnabled = False
        End If
    End Sub


    Private Sub backup_Checked(sender As Object, e As RoutedEventArgs) Handles backup.Checked, backup.Unchecked
        If backup.IsChecked = True Then
            path.IsEnabled = True

        Else
            path.IsEnabled = False
            path.Clear()
            My.Settings.bu = path.Text
        End If
    End Sub
End Class
