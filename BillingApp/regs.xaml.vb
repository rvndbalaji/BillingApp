Imports System.IO

Public Class regs

    Dim Strt As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
    Dim i = 1

    Private Sub add_Click(sender As Object, e As RoutedEventArgs) Handles add.Click

        If inst.Items.Contains(nme.Text) Then

            MessageBox.Show("This instituition has already been registered. Please check the list", "Already Registered", MessageBoxButton.OK, MessageBoxImage.Information)

        ElseIf nme.Text = Nothing Then
            MessageBox.Show("Please enter the name of the instituition. A blank entry is invalid", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            inst.Items.Add(nme.Text)

            Dim i As Integer

            For i = 0 To i = inst.Items.Count - 1

                ' If 

            Next i

            nme.Clear()
        End If

        no.Text = inst.Items.Count
        nme.Focus()
    End Sub

    Private Sub remove_Click(sender As Object, e As RoutedEventArgs) Handles remove.Click


        If MessageBox.Show("The selected Insituition(s) will be removed. Are you sure about the removal?", "Remove/Unregister Insituitions", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) = vbYes Then

            Dim j As Integer

            For j = inst.SelectedItems.Count - 1 To 0 Step -1
                inst.Items.Remove(inst.SelectedItems(j))
            Next


        Else

        End If
        no.Text = inst.Items.Count
    End Sub

    Private Sub save_Click(sender As Object, e As RoutedEventArgs) Handles save.Click
        Dim lim As Integer
        lim = inst.Items.Count
        My.Settings.lim = lim



        My.Settings.Register.Clear()
        Dim k As Integer

        For k = 0 To lim - 1

            My.Settings.Register.Add(inst.Items.GetItemAt(k))

        Next

        My.Settings.Save()
        MessageBox.Show("The Register has been updated and saved", "Updated & Saved", MessageBoxButton.OK, MessageBoxImage.Information)

        If My.Settings.back = True Then

            Dim loc As String
            loc = My.Settings.bu

            Try

                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(loc & "\InstReg_Backup.txt", False)
                For k = 0 To lim - 1
                    file.WriteLine(inst.Items.GetItemAt(k))
                Next
                file.Close()
            Catch ex As Exception
                MessageBox.Show("The updating and saving was done but the Register Back-Up didn't go on well. Make sure you : " & vbNewLine & "" & vbNewLine & "> Check if the location of the BACKUP FOLDER is correct " & vbNewLine & " ( App Settings => 'Backup register...')" & vbNewLine & "" & vbNewLine & "> Specify the FOLDER address and not the location of a FILE" & vbNewLine & "" & vbNewLine & "> Check the folder actually exists in your hard drive" & vbNewLine & "" & vbNewLine & "If none of the above solves your problem, please contact Aravind", "Somethin's Fishy", MessageBoxButton.OK, MessageBoxImage.Warning)
            End Try

        End If

        no.Text = inst.Items.Count
        My.Settings.timestamp = Today & " at " & TimeOfDay
        time.Text = My.Settings.timestamp
        My.Settings.Save()
    End Sub

    Private Sub reg_Loaded(sender As Object, e As RoutedEventArgs) Handles reg.Loaded
        Dim lim As Integer
        lim = My.Settings.lim

        Dim k As Integer

        For k = 0 To lim - 1

            inst.Items.Add(My.Settings.Register.Item(k))

        Next

        no.Text = inst.Items.Count
        time.Text = My.Settings.timestamp
        bill.Text = My.Settings.Bill
    End Sub

End Class