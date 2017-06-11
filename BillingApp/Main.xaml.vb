Imports Word = Microsoft.Office.Interop.Word
Class MainWindow
    Dim ch(200) As String
    Private Sub strt_Loaded(sender As Object, e As EventArgs) Handles strt.Loaded


        'Applying User Settings.............


        If My.Settings.update = True Then
            strt.inc.Visibility = Windows.Visibility.Hidden
            strt.no.Width = 393

        Else

            strt.inc.Visibility = Windows.Visibility.Visible
            strt.no.Width = 359
        End If


        strt.Opacity = 0.2
        strt.IsEnabled = False
        Dim pass As New pass
        pass.ShowDialog()
        inst_name.Content = "Select the Institution"
        no.Text = My.Settings.Bill + 1
        name.Focus()
    End Sub

    Private Sub strt_Loed(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles strt.Closing

        e.Cancel = False
        Me.Opacity = 0.2
        If MessageBox.Show("Whoa! Quitting is never an option in life! You may lose everything!" & vbNewLine & "Are you REALLY sure that you want to quit?", "Exit Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then
            My.Settings.Save() '
            End
        Else
            Me.Opacity = 1
            e.Cancel = True

        End If

        My.Settings.Save()
    End Sub

    Private Sub inst_Cick(sender As Object, e As RoutedEventArgs) Handles inst_name.Click
        If inst.Visibility = Windows.Visibility.Hidden Then



            Dim lim As Integer
            lim = My.Settings.lim

            If lim = 0 Then
                inst_name.Content = "Select the Institution"
                inst.Items.Clear()
                Dim k As Integer

                For k = 0 To lim - 1

                    inst.Items.Add(My.Settings.Register.Item(k))

                Next
            Else

                inst.Items.Clear()
                Dim k As Integer

                For k = 0 To lim - 1

                    inst.Items.Add(My.Settings.Register.Item(k))

                Next

            End If


            inst.Visibility = Windows.Visibility.Visible

            My.Settings.Save()
        Else
            inst.Visibility = Windows.Visibility.Hidden

        End If
    End Sub






    Private Sub inst_Click(sender As Object, e As EventArgs) Handles inst.SelectionChanged
        Dim lim As Integer
        lim = inst.Items.Count

        If lim = 0 Then

        Else


            inst_name.Content = inst.Items.GetItemAt(inst.SelectedIndex)
            inst.Visibility = Windows.Visibility.Hidden
        End If



    End Sub

   


    Private Sub clr_Click(sender As Object, e As RoutedEventArgs) Handles clr.Click
        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to clear everything on this list?", "Clear confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then


            i1.Text = "1"
            i2.Clear()
            i3.Clear()
            i4.Clear()
            i5.Clear()
            i6.Clear()
            i7.Clear()
            i8.Clear()
            i9.Clear()


            n1.Clear()
            n2.Clear()
            n3.Clear()
            n4.Clear()
            n5.Clear()
            n6.Clear()
            n7.Clear()
            n8.Clear()
            n9.Clear()

            q1.Clear()
            q2.Clear()
            q3.Clear()
            q4.Clear()
            q5.Clear()
            q6.Clear()
            q7.Clear()
            q8.Clear()
            q9.Clear()


            p1.Clear()
            p2.Clear()
            p3.Clear()
            p4.Clear()
            p5.Clear()
            p6.Clear()
            p7.Clear()
            p8.Clear()
            p9.Clear()

            name.Clear()
            inst_name.Content = "Select the Institution"
            email.Clear()
            ph.Clear()
            add.Clear()



        Else

        End If
        Me.Opacity = 1
    End Sub

    Private Sub clr_Copy_Click(sender As Object, e As RoutedEventArgs) Handles save.Click

        If inst_name.Content = "Select the Institution" Or no.Text = Nothing Or name.Text = Nothing Or email.Text = Nothing Or ph.Text = Nothing Or add.Text = Nothing Then
            MessageBox.Show("One or more fields have been left blank! Re-check and try again", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Exclamation)
        Else



            'Saving Information to App Database

            Int32.TryParse(no.Text, My.Settings.Bill)
            My.Settings.Save()


            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            Dim tab As Word.Table
            Dim h0 As Word.Paragraph
            Dim h1 As Word.Paragraph
            Dim p1 As Word.Paragraph
            Dim p2 As Word.Paragraph
            Dim p3 As Word.Paragraph
            Dim p4 As Word.Paragraph
            Dim p5 As Word.Paragraph
            Dim p6 As Word.Paragraph


            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oWord.Activate()
            oDoc = oWord.Documents.Add

            Try
                h1 = oDoc.Content.Paragraphs.Add()
                h1.Range.Text = "Bill of " & name.Text & ": " & no.Text
                h1.Range.Font.Bold = True
                h1.Range.Font.Underline = True
                h1.Range.Font.Name = "Calibri"
                h1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                h1.Range.Font.Size = 20
                h1.Format.SpaceAfter = 12
                h1.Range.InsertParagraphAfter()

                h0 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                h0.Range.Text = "© 2014 Eos Incorporation"
                h0.Range.Font.Bold = True
                h0.Range.Font.Italic = True
                h1.Range.Font.Underline = False
                h0.Range.Font.Name = "Calibri"
                h0.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                h0.Range.Font.Size = 16
                h0.Format.SpaceAfter = 12
                h0.Range.InsertParagraphAfter()


                h0 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                h0.Range.Text = Today & ", " & TimeOfDay
                h0.Range.Font.Bold = True
                h0.Range.Font.Italic = True
                h1.Range.Font.Underline = False
                h0.Range.Font.Name = "Calibri"
                h0.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                h0.Range.Font.Size = 15
                h0.Format.SpaceAfter = 24
                h0.Range.InsertParagraphAfter()




                p1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p1.Range.Text = "Bill Number : " & no.Text
                p1.Range.Font.Bold = False
                p1.Range.Font.Underline = False
                p1.Range.Font.Name = "Calibri"
                p1.Range.Font.Size = 16
                p1.Format.SpaceAfter = 1
                p1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p1.Range.InsertParagraphAfter()


                p2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p2.Range.Text = "Name : " & name.Text
                p2.Range.Font.Bold = False
                p2.Range.Font.Underline = False
                p2.Range.Font.Name = "Calibri"
                p2.Range.Font.Size = 16
                p2.Format.SpaceAfter = 1
                p2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p2.Range.InsertParagraphAfter()

                p3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p3.Range.Text = "Institution : " & inst_name.Content
                p3.Range.Font.Bold = False
                p3.Range.Font.Underline = False
                p3.Range.Font.Name = "Calibri"
                p3.Range.Font.Size = 16
                p3.Format.SpaceAfter = 1
                p3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p3.Range.InsertParagraphAfter()


                p4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p4.Range.Text = "E-mail : " & email.Text
                p4.Range.Font.Bold = False
                p4.Range.Font.Underline = False
                p4.Range.Font.Name = "Calibri"
                p4.Range.Font.Size = 16
                p4.Format.SpaceAfter = 1
                p4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p4.Range.InsertParagraphAfter()

                p5 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p5.Range.Text = "Phone Number : " & ph.Text
                p5.Range.Font.Bold = False
                p5.Range.Font.Underline = False
                p5.Range.Font.Name = "Calibri"
                p5.Range.Font.Size = 16
                p5.Format.SpaceAfter = 3
                p5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p5.Range.InsertParagraphAfter()

                p6 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                p6.Range.Text = "Address : " & add.Text
                p6.Range.Font.Bold = False
                p6.Range.Font.Underline = False
                p6.Range.Font.Name = "Calibri"
                p6.Range.Font.Size = 16
                p6.Format.SpaceAfter = 16
                p6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                p6.Range.InsertParagraphAfter()




                'Inserting the table 9 x 4




                Dim last As Word.Paragraph


                last = oDoc.Content.Paragraphs.Add()
                last.Range.InsertParagraphBefore()
                last.Range.Text = "Total Cost : " & tot.Content
                last.Range.Font.Italic = True
                last.Range.Font.Bold = True
                last.Range.Font.Size = 20
                last.Format.SpaceAfter = 1
                last.Range.InsertParagraphAfter()


                tab = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 9, 4)
                tab.Range.ParagraphFormat.SpaceAfter = 7
                tab.Range.Font.Size = 16

                tab.Rows.Item(1).Range.Font.Bold = True
                tab.Cell(1, 1).Range.Text = "Item No."
                tab.Cell(1, 2).Range.Text = "Item Name"
                tab.Cell(1, 3).Range.Text = "Quantity"
                tab.Cell(1, 4).Range.Text = "Price"

                tab.Cell(2, 1).Range.Text = i1.Text
                tab.Cell(2, 2).Range.Text = n1.Text
                tab.Cell(2, 3).Range.Text = q1.Text
                tab.Cell(2, 4).Range.Text = Me.p1.Text


                tab.Cell(3, 1).Range.Text = i2.Text
                tab.Cell(3, 2).Range.Text = n2.Text
                tab.Cell(3, 3).Range.Text = q2.Text
                tab.Cell(3, 4).Range.Text = Me.p2.Text

                tab.Cell(4, 1).Range.Text = i3.Text
                tab.Cell(4, 2).Range.Text = n3.Text
                tab.Cell(4, 3).Range.Text = q3.Text
                tab.Cell(4, 4).Range.Text = Me.p3.Text

                tab.Cell(5, 1).Range.Text = i4.Text
                tab.Cell(5, 2).Range.Text = n4.Text
                tab.Cell(5, 3).Range.Text = q4.Text
                tab.Cell(5, 4).Range.Text = Me.p4.Text

                tab.Cell(6, 1).Range.Text = i5.Text
                tab.Cell(6, 2).Range.Text = n5.Text
                tab.Cell(6, 3).Range.Text = q5.Text
                tab.Cell(6, 4).Range.Text = Me.p5.Text

                tab.Cell(7, 1).Range.Text = i6.Text
                tab.Cell(7, 2).Range.Text = n6.Text
                tab.Cell(7, 3).Range.Text = q6.Text
                tab.Cell(7, 4).Range.Text = Me.p6.Text

                tab.Cell(8, 1).Range.Text = i7.Text
                tab.Cell(8, 2).Range.Text = n7.Text
                tab.Cell(8, 3).Range.Text = q7.Text
                tab.Cell(8, 4).Range.Text = Me.p7.Text

                tab.Cell(9, 1).Range.Text = i8.Text
                tab.Cell(9, 2).Range.Text = n8.Text
                tab.Cell(9, 3).Range.Text = q8.Text
                tab.Cell(9, 4).Range.Text = Me.p8.Text

                tab.Cell(10, 1).Range.Text = i9.Text
                tab.Cell(10, 2).Range.Text = n9.Text
                tab.Cell(10, 3).Range.Text = q9.Text
                tab.Cell(10, 4).Range.Text = Me.p9.Text

                tab.Rows.Item(1).Range.Font.Italic = True


                tab.Range.InsertParagraphAfter()




                'Preparing the Next Bill to be.... Billed :P


                no.Text = My.Settings.Bill + 1
                i1.Text = "1"
                i2.Clear()
                i3.Clear()
                i4.Clear()
                i5.Clear()
                i6.Clear()
                i7.Clear()
                i8.Clear()
                i9.Clear()


                n1.Clear()
                n2.Clear()
                n3.Clear()
                n4.Clear()
                n5.Clear()
                n6.Clear()
                n7.Clear()
                n8.Clear()
                n9.Clear()

                q1.Clear()
                q2.Clear()
                q3.Clear()
                q4.Clear()
                q5.Clear()
                q6.Clear()
                q7.Clear()
                q8.Clear()
                q9.Clear()


                Me.p1.Clear()
                Me.p2.Clear()
                Me.p3.Clear()
                Me.p4.Clear()
                Me.p5.Clear()
                Me.p6.Clear()
                Me.p7.Clear()
                Me.p8.Clear()
                Me.p9.Clear()

                name.Clear()
                inst_name.Content = "Select the Institution"
                email.Clear()
                ph.Clear()
                add.Clear()

            Catch
            End Try




        End If

    End Sub

    Private Sub p1_TextChanged(sender As Object, z As TextChangedEventArgs) Handles p1.TextChanged, p2.TextChanged, p3.TextChanged, p4.TextChanged, p5.TextChanged, p6.TextChanged, p7.TextChanged, p8.TextChanged, p9.TextChanged, q1.TextChanged, q2.TextChanged, q3.TextChanged, q4.TextChanged, q5.TextChanged, q6.TextChanged, q7.TextChanged, q8.TextChanged, q9.TextChanged

        Dim a, b, c, d, e, f, g, h, i As Integer
        Dim p, q, r, s, t, u, v, w, x As Integer


        Int32.TryParse(p1.Text, a)
        Int32.TryParse(p2.Text, b)
        Int32.TryParse(p3.Text, c)
        Int32.TryParse(p4.Text, d)
        Int32.TryParse(p5.Text, e)
        Int32.TryParse(p6.Text, f)
        Int32.TryParse(p7.Text, g)
        Int32.TryParse(p8.Text, h)
        Int32.TryParse(p9.Text, i)

        Int32.TryParse(q1.Text, p)
        Int32.TryParse(q2.Text, q)
        Int32.TryParse(q3.Text, r)
        Int32.TryParse(q4.Text, s)
        Int32.TryParse(q5.Text, t)
        Int32.TryParse(q6.Text, u)
        Int32.TryParse(q7.Text, v)
        Int32.TryParse(q8.Text, w)
        Int32.TryParse(q9.Text, x)



        tot.Content = "₹ " & ((a * p) + (b * q) + (c * r) + (d * s) + (e * t) + (f * u) + (g * v) + (h * w) + (i * x))

    End Sub

    Private Sub incr(sender As Object, e As MouseButtonEventArgs) Handles inc.MouseUp
        Dim i As Integer
        Int32.TryParse(no.Text, i)
        i = i + 1
        no.Text = i

    End Sub

    Private Sub set_ImageFailed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles sicon.MouseEnter

        nm.Text = "App Settings"
    End Sub


    Private Sub set_ImadgeFailed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles sicon.MouseLeave

        nm.Text = "My trunk!"
    End Sub


    Private Sub set_Imailed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles reg.MouseEnter

        nm.Text = "Registration"
    End Sub


    Private Sub set_ImadgFailed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles reg.MouseLeave

        nm.Text = "My trunk!"
    End Sub

    Private Sub se_Imaied(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles sicon.MouseUp

        Me.Opacity = 0.2
        Dim ct As New ct
        ct.ShowDialog()

        Me.Opacity = 1
    End Sub

    Private Sub set_Iaied(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles reg.MouseUp


        Dim reg As New regs
        reg.Show()

    End Sub

    Private Sub set_Imaied(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles abt.MouseEnter

        nm.Text = "About"
    End Sub


    Private Sub set_Imadgailed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles abt.MouseLeave

        nm.Text = "My trunk!"
    End Sub
    Private Sub se_Imed(ByVal sender As System.Object, ByVal e As RoutedEventArgs) Handles abt.MouseUp
        beg.Visibility = Windows.Visibility.Hidden
        'Me.Opacity = 0.8
        Dim abt As New abt
        abt.ShowDialog()
        beg.Visibility = Windows.Visibility.Visible
        ' Me.Opacity = 1
    End Sub
End Class
