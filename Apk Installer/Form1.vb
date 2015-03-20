Imports System.IO

Public Class Form1
    Dim xcmd, path, textline As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        path = Application.StartupPath & "\sys\loga.txt"
        xcmd = "cmd.exe /c adb devices 1> sys/loga.txt"
        Label1.Text = runat(path, xcmd)


    End Sub
    Sub install()
        Dim test As String
        Dim appa As String = ListBox1.SelectedItem.ToString
        path = Application.StartupPath & "\sys\status.txt"
        Dim reado As New System.IO.StreamReader(path)
        Dim con As String = "cmd.exe /c adb install " & appa & " 1> sys/status.txt"
        Shell(con)
        MsgBox(con)
        ' adb install %filename%
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim test As String
        path = Application.StartupPath & "\sys\installoc.txt"
        Dim reado As New System.IO.StreamReader(path)
        Dim con As String = "cmd.exe /c adb shell pm get-install-location 1> sys/installoc.txt"
        Shell(con)

        test = reado.ReadToEnd
        If test.Contains("2") Or test.Contains("[external]") Then
            Label2.Text = "External memory"
        End If
        'Label2.Text = runat(path, con)
    End Sub
    Public Function runat(ByVal path As String, ByVal command As String) As String
        Dim final As String
        Dim startme As New Diagnostics.ProcessStartInfo()
        'Make the CMD process exit when it has finished processing the command which is the param called 'Command'.
        startme.Arguments = command
        'Here we make sure we open CMD.
        startme.FileName = "cmd.exe"
        'We set the process's window-style to hidden, so the user doesn't see the cmd window.
        startme.WindowStyle = Diagnostics.ProcessWindowStyle.Hidden
        'And we start the process.
        Process.Start(startme)





        Dim reado As New System.IO.StreamReader(path)




        final = reado.ReadToEnd()
        Return final
    End Function
    Private Sub installoction()

        Dim test As String
        path = Application.StartupPath & "\sys\installoc.txt"
        Dim reado As New System.IO.StreamReader(path)
        Dim con As String = "cmd.exe /c adb shell pm get-install-location 1> sys/installoc.txt"
        Shell(con)

        test = reado.ReadToEnd
        If test.Contains("2") Or test.Contains("[external]") Then
            Label2.Text = "External memory"
        End If
        'Label2.Text = runat(path, con)
        reado.Close()
    End Sub
    Private Sub properties()
        Try

       
        Dim path As String = Application.StartupPath & "\sys\props.txt"
            Dim con As String = "cmd.exe /c adb shell getprop> sys/prop.txt"
        Shell(con)
        Dim returne As String = ""
            Dim fileReader As StreamReader = New StreamReader(Application.StartupPath & "\sys\prop.txt")
        Dim fileWriter As StreamWriter = New StreamWriter(Application.StartupPath & "\sys\props1.txt")
        Dim theData As String, WriteCount As Byte
        '
        Do While fileReader.Peek() >= 0
            theData = fileReader.ReadLine 'reads line by line
            If InStr(theData, "[ro.product.model]") Then
                fileWriter.WriteLine(theData) 'write this line
                ' WriteCount = 2 'automatically write the following next 2 lines
            ElseIf WriteCount > 0 Then
                fileWriter.WriteLine(theData)
                WriteCount -= 1
            End If
        Loop
        fileReader.Close() 'cleanup
        fileWriter.Close()
        Dim oss As New System.IO.StreamReader(Application.StartupPath & "\sys\props1.txt")
        returne = oss.ReadToEnd


        ' Split string based on spaces
        Dim words As String() = returne.Split(New Char() {"["c})
        returne = words(2)

        Label5.Text = returne

        oss.Close()

        Catch ex As Exception
            MsgBox("Connection lost" & vbNewLine & "Please Check if phone is sill Connected", MsgBoxStyle.Critical)
            Timer1.Stop()
            Exit Sub
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        properties()
    End Sub
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    Private Sub getapps()
        Dim con As String = "cmd.exe /c adb shell pm list packages 1>" + TextBox1.Text
        Shell(con)
        Dim test As String
        'path = Application.StartupPath & "\sys\apps.txt"
        'Dim reado As New System.IO.StreamReader(path)


        'test = reado.ReadToEnd
        'Dim pqr As String() = test.Split(vbNewLine)

        'ListBox1.Items.AddRange(pqr)

        'Label2.Text = runat(path, con)
        ' reado.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        properties()
    End Sub
    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        getapps()
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each filePath As String In filePaths

                ' Dim chkExt As String = _
                'My.Computer.FileSystem.GetFileInfo(filePath).Extension

                'THIS IS THE ONLY METHOD THAT I KNOW HOW TO CALCULATE THE FILE SIZE....
                ' Dim chkSize As String = _
                'My.Computer.FileSystem.GetFileInfo(filePath).Length
                ' chkSize = chkSize / 1024

                'THIS IS WHAT I USED TO ROUND THE SIZE TO 2 DECIMAL POINTS...
                ' Dim d As Decimal
                'd = Decimal.Round(chkSize, 2, MidpointRounding.AwayFromZero)

                'THIS WILL ADD THE FILEPATHS AND THE FILES SIZE TO THE LIST VIEW
                ListBox1.Items.Add(filePath)
                ListBox1.SelectedIndex = 0


            Next filePath

        End If
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListBox1_LostFocus(sender As Object, e As EventArgs) Handles ListBox1.LostFocus

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub YtButton1_Click(sender As Object, e As EventArgs) Handles YtButton1.Click
        install()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        getapps()
    End Sub
End Class
