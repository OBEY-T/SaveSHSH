Imports System.IO
Public Class Form1
    Dim boardConfig As String
    Dim specificBoardConfig As Boolean
    Dim specificApNonce As Boolean
    Dim specificiOS As Boolean

    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim exeDirectory As String = My.Application.Info.DirectoryPath

        If Not File.Exists(exeDirectory + "\tsschecker.exe") Then
            MsgBox("tsschecker.exe not found", vbCritical)
            Application.Exit()
            End
        End If

        Me.AcceptButton = ExecuteButton
            MyProcess = New Process
            With MyProcess.StartInfo
                .FileName = "CMD.EXE"
                .UseShellExecute = False
                .CreateNoWindow = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
            End With
            MyProcess.Start()

            MyProcess.BeginErrorReadLine()
            MyProcess.BeginOutputReadLine()
            AppendOutputText("Process Started at: " & MyProcess.StartTime.ToString)

            CheckBox2.Checked = True
            iOSTxt.Enabled = False

            ComboBox1.SelectedIndex = My.Settings.indexIdentifier1
            ComboBox2.SelectedIndex = My.Settings.indexIdentifier2
            ECIDTxt.Text = My.Settings.ECID
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
            MyProcess.StandardInput.Flush()
            MyProcess.Close()
        Catch ex3 As Exception
        End Try
    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        Dim deviceIdentifier As String = ""
        Dim command As String

        If ComboBox1.SelectedIndex = 0 Then
            deviceIdentifier = "iPhone"
            Select Case ComboBox2.SelectedIndex
                Case 0
                    deviceIdentifier = deviceIdentifier + "1,1"
                Case 1
                    deviceIdentifier = deviceIdentifier + "1,2"
                Case 2
                    deviceIdentifier = deviceIdentifier + "2,1"
                Case 3
                    deviceIdentifier = deviceIdentifier + "3,1"
                Case 4
                    deviceIdentifier = deviceIdentifier + "3,2"
                Case 5
                    deviceIdentifier = deviceIdentifier + "3,3"
                Case 6
                    deviceIdentifier = deviceIdentifier + "4,1"
                Case 7
                    deviceIdentifier = deviceIdentifier + "5,1"
                Case 8
                    deviceIdentifier = deviceIdentifier + "5,1"
                Case 9
                    deviceIdentifier = deviceIdentifier + "5,3"
                Case 10
                    deviceIdentifier = deviceIdentifier + "5,4"
                Case 11
                    deviceIdentifier = deviceIdentifier + "6,1"
                Case 12
                    deviceIdentifier = deviceIdentifier + "6,2"
                Case 13
                    deviceIdentifier = deviceIdentifier + "7,2"
                Case 14
                    deviceIdentifier = deviceIdentifier + "7,1"
                Case 15
                    deviceIdentifier = deviceIdentifier + "8,1"
                Case 16
                    deviceIdentifier = deviceIdentifier + "8,2"
                Case 17
                    deviceIdentifier = deviceIdentifier + "8,4"
                Case 18
                    deviceIdentifier = deviceIdentifier + "9,1"
                Case 19
                    deviceIdentifier = deviceIdentifier + "9,2"
                Case 20
                    deviceIdentifier = deviceIdentifier + "9,3"
                Case 21
                    deviceIdentifier = deviceIdentifier + "9,4"
                Case 22
                    deviceIdentifier = deviceIdentifier + "10,1"
                Case 23
                    deviceIdentifier = deviceIdentifier + "10,2"
                Case 24
                    deviceIdentifier = deviceIdentifier + "10,3"
                Case 25
                    deviceIdentifier = deviceIdentifier + "10,4"
                Case 26
                    deviceIdentifier = deviceIdentifier + "10,5"
                Case 27
                    deviceIdentifier = deviceIdentifier + "10,6"
            End Select
        ElseIf ComboBox1.SelectedIndex = 1 Then
            deviceIdentifier = "iPod"
            Select Case ComboBox2.SelectedIndex
                Case 0
                    deviceIdentifier = deviceIdentifier + "1,1"
                Case 1
                    deviceIdentifier = deviceIdentifier + "2,1"
                Case 2
                    deviceIdentifier = deviceIdentifier + "3,1"
                Case 3
                    deviceIdentifier = deviceIdentifier + "4,1"
                Case 4
                    deviceIdentifier = deviceIdentifier + "5,1"
                Case 5
                    deviceIdentifier = deviceIdentifier + "7,1"
            End Select
        ElseIf ComboBox1.SelectedIndex = 2 Then
            deviceIdentifier = "iPad"
            Select Case ComboBox2.SelectedIndex
                Case 0
                    deviceIdentifier = deviceIdentifier + "1,1"
                Case 1
                    deviceIdentifier = deviceIdentifier + "2,1"
                Case 2
                    deviceIdentifier = deviceIdentifier + "2,2"
                Case 3
                    deviceIdentifier = deviceIdentifier + "2,3"
                Case 4
                    deviceIdentifier = deviceIdentifier + "2,4"
                Case 5
                    deviceIdentifier = deviceIdentifier + "2,5"
                Case 6
                    deviceIdentifier = deviceIdentifier + "2,6"
                Case 7
                    deviceIdentifier = deviceIdentifier + "2,7"
                Case 8
                    deviceIdentifier = deviceIdentifier + "3,1"
                Case 9
                    deviceIdentifier = deviceIdentifier + "3,2"
                Case 10
                    deviceIdentifier = deviceIdentifier + "3,3"
                Case 11
                    deviceIdentifier = deviceIdentifier + "3,4"
                Case 12
                    deviceIdentifier = deviceIdentifier + "3,5"
                Case 13
                    deviceIdentifier = deviceIdentifier + "3,6"
                Case 14
                    deviceIdentifier = deviceIdentifier + "4,1"
                Case 15
                    deviceIdentifier = deviceIdentifier + "4,2"
                Case 16
                    deviceIdentifier = deviceIdentifier + "4,3"
                Case 17
                    deviceIdentifier = deviceIdentifier + "4,4"
                Case 18
                    deviceIdentifier = deviceIdentifier + "4,5"
                Case 19
                    deviceIdentifier = deviceIdentifier + "4,6"
                Case 20
                    deviceIdentifier = deviceIdentifier + "4,7"
                Case 21
                    deviceIdentifier = deviceIdentifier + "4,8"
                Case 22
                    deviceIdentifier = deviceIdentifier + "4,9"
                Case 23
                    deviceIdentifier = deviceIdentifier + "5,1"
                Case 24
                    deviceIdentifier = deviceIdentifier + "5,3"
                Case 25
                    deviceIdentifier = deviceIdentifier + "5,4"
                Case 26
                    deviceIdentifier = deviceIdentifier + "6,3"
                Case 27
                    deviceIdentifier = deviceIdentifier + "6,4"
                Case 28
                    deviceIdentifier = deviceIdentifier + "6,7"
                Case 29
                    deviceIdentifier = deviceIdentifier + "6,8"
                Case 30
                    deviceIdentifier = deviceIdentifier + "6,11"
                Case 31
                    deviceIdentifier = deviceIdentifier + "6,12"
                Case 32
                    deviceIdentifier = deviceIdentifier + "7,1"
                Case 33
                    deviceIdentifier = deviceIdentifier + "7,2"
                Case 34
                    deviceIdentifier = deviceIdentifier + "7,3"
                Case 35
                    deviceIdentifier = deviceIdentifier + "7,4"
                Case 36
                    deviceIdentifier = deviceIdentifier + "7,5"
                Case 37
                    deviceIdentifier = deviceIdentifier + "7,6"
            End Select
        ElseIf ComboBox1.SelectedIndex = 3 Then
            deviceIdentifier = "AppleTV"
            Select Case ComboBox2.SelectedIndex
                Case 0
                    deviceIdentifier = deviceIdentifier + "2,1"
                Case 1
                    deviceIdentifier = deviceIdentifier + "3,1"
                Case 2
                    deviceIdentifier = deviceIdentifier + "3,2"
                Case 3
                    deviceIdentifier = deviceIdentifier + "5,3"
            End Select
        End If

        command = "tsschecker.exe --save" & " --ecid " + ECIDTxt.Text

        If specificBoardConfig = True Then
            command = command + " --boardconfig " + boardConfig
        Else
            command = command + " --device " + deviceIdentifier
        End If

        If specificiOS = True Then
            command = command + " --ios " + iOSTxt.Text
        Else
            command = command + " --latest"
        End If

        If specificApNonce = True Then
            command = command + " --apnonce " + ApNonceTxt.Text
        End If


        MyProcess.StandardInput.WriteLine(command)
        MyProcess.StandardInput.Flush()

    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Try
                Me.Invoke(myDelegate, text)
            Catch ex2 As Exception
            End Try
        Else
            OutputTextBox.AppendText(text)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("iPhone 2G") '0
                ComboBox2.Items.Add("iPhone 3G") '1
                ComboBox2.Items.Add("iPhone 3G[S]") '2
                ComboBox2.Items.Add("iPhone 4 (GSM)") '3
                ComboBox2.Items.Add("iPhone 4 (GSM 2012)") '4
                ComboBox2.Items.Add("iPhone 4 (CDMA)") '5
                ComboBox2.Items.Add("iPhone 4[S]") '6
                ComboBox2.Items.Add("iPhone 5 (GSM)") '7
                ComboBox2.Items.Add("iPhone 5 (Global)") '8
                ComboBox2.Items.Add("iPhone 5c (GSM)") '9
                ComboBox2.Items.Add("iPhone 5c (Global)") '10
                ComboBox2.Items.Add("iPhone 5s (GSM)") '11
                ComboBox2.Items.Add("iPhone 5s (Global)") '12
                ComboBox2.Items.Add("iPhone 6") '13
                ComboBox2.Items.Add("iPhone 6+") '14
                ComboBox2.Items.Add("iPhone 6s") '15
                ComboBox2.Items.Add("iPhone 6s+") '16
                ComboBox2.Items.Add("iPhone SE") '17
                ComboBox2.Items.Add("iPhone 7 (Global) (iPhone9,1)") '18
                ComboBox2.Items.Add("iPhone 7+ (Global) (iPhone9,2)") '19
                ComboBox2.Items.Add("iPhone 7 (GSM) (iPhone9,3)") '20
                ComboBox2.Items.Add("iPhone 7+ (GSM) (iPhone9,4)") '21
                ComboBox2.Items.Add("iPhone 8 (iPhone10,1)") '22
                ComboBox2.Items.Add("iPhone 8+ (iPhone10,2)") '23
                ComboBox2.Items.Add("iPhone X (iPhone10,3)") '24
                ComboBox2.Items.Add("iPhone 8 (iPhone10,4)") '25
                ComboBox2.Items.Add("iPhone 8+ (iPhone10,5)") '26
                ComboBox2.Items.Add("iPhone X (iPhone10,6)") '27
                ComboBox2.SelectedIndex = 0
            Case 1
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("iPod Touch 1G") '0
                ComboBox2.Items.Add("iPod Touch 2G") '1
                ComboBox2.Items.Add("iPod Touch 3") '2
                ComboBox2.Items.Add("iPod Touch 4") '3
                ComboBox2.Items.Add("iPod Touch 5") '4
                ComboBox2.Items.Add("iPod Touch 6") '5
                ComboBox2.SelectedIndex = 0
            Case 2
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("iPad 1") '0
                ComboBox2.Items.Add("iPad 2 (WiFi)") '1
                ComboBox2.Items.Add("iPad 2 (GSM)") '2
                ComboBox2.Items.Add("iPad 2 (CDMA)") '3
                ComboBox2.Items.Add("iPad 2 (Mid 2012)") '4
                ComboBox2.Items.Add("iPad Mini (WiFi)") '5 
                ComboBox2.Items.Add("iPad Mini (GSM)") '6 
                ComboBox2.Items.Add("iPad Mini (Global)") '7
                ComboBox2.Items.Add("iPad 3 (WiFi)") '8
                ComboBox2.Items.Add("iPad 3 (CDMA)") '9
                ComboBox2.Items.Add("iPad 3 (GSM)") '10
                ComboBox2.Items.Add("iPad 4 (WiFi)") '11
                ComboBox2.Items.Add("iPad 4 (GSM)") '12
                ComboBox2.Items.Add("iPad 4 (Global)") '13
                ComboBox2.Items.Add("iPad Air (WiFi)") '14
                ComboBox2.Items.Add("iPad Air (Cellular)") '15
                ComboBox2.Items.Add("iPad Air (China)") '16
                ComboBox2.Items.Add("iPad Mini 2 (WiFi)") '17
                ComboBox2.Items.Add("iPad Mini 2 (Cellular)") '18
                ComboBox2.Items.Add("iPad Mini 2 (China)") '19
                ComboBox2.Items.Add("iPad Mini 3 (WiFi)") '20
                ComboBox2.Items.Add("iPad Mini 3 (Cellular)") '21
                ComboBox2.Items.Add("iPad Mini 3 (China)") '22
                ComboBox2.Items.Add("iPad Mini 4 (WiFi)") '23
                ComboBox2.Items.Add("iPad Air 2 (WiFi)") '24
                ComboBox2.Items.Add("iPad Air 2 (Cellular)") '25
                ComboBox2.Items.Add("iPad Pro 9.7 (WiFi)") '26
                ComboBox2.Items.Add("iPad Pro 9.7 (Cellular)") '27
                ComboBox2.Items.Add("iPad Pro 12.9 (WiFi)") '28
                ComboBox2.Items.Add("iPad Pro 12.9 (Cellular)") '29
                ComboBox2.Items.Add("iPad 5 (WiFi)") '30
                ComboBox2.Items.Add("iPad 5 (Cellular)") '31
                ComboBox2.Items.Add("iPad Pro 2 12.9 (iPad7,1)") '32
                ComboBox2.Items.Add("iPad Pro 2 12.9 (iPad7,2)") '33
                ComboBox2.Items.Add("iPad Pro 10.5 (iPad7,3)") '34
                ComboBox2.Items.Add("iPad Pro 10.5 (iPad7,4)") '35
                ComboBox2.Items.Add("iPad 6 (iPad7,5)") '36
                ComboBox2.Items.Add("iPad 6 (iPad7,6)") '37
                ComboBox2.SelectedIndex = 0
            Case 3
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Apple TV 2G") '0
                ComboBox2.Items.Add("Apple TV 3") '1
                ComboBox2.Items.Add("Apple TV 3 (2013)") '2
                ComboBox2.Items.Add("Apple TV 4 (2015)") '3
                ComboBox2.SelectedIndex = 0
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ApNonceTxt.Enabled = True
            specificApNonce = True
        Else
            ApNonceTxt.Enabled = False
            specificApNonce = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            If My.Settings.indexIdentifier2 <> 15 And My.Settings.indexIdentifier2 <> 16 And My.Settings.indexIdentifier2 <> 17 Then
                If ComboBox2.SelectedIndex = 15 Or ComboBox2.SelectedIndex = 16 Or ComboBox2.SelectedIndex = 17 Then
                    boardConfig = InputBox("Specify you board config")
                    If boardConfig = "" Then
                        MsgBox("No board config specified", vbCritical)
                        ComboBox2.SelectedIndex = 0
                    Else
                        specificBoardConfig = True
                    End If
                End If
            Else
                If ComboBox2.SelectedIndex = 15 Or ComboBox2.SelectedIndex = 16 Or ComboBox2.SelectedIndex = 17 Then
                    specificBoardConfig = True
                    boardConfig = My.Settings.boardConfig
                Else
                    specificBoardConfig = False
                End If
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            If My.Settings.indexIdentifier2 <> 30 And My.Settings.indexIdentifier2 <> 31 Then
                If ComboBox2.SelectedIndex = 30 Or ComboBox2.SelectedIndex = 31 Then
                    boardConfig = InputBox("Specify you board config")
                    If boardConfig = "" Then
                        MsgBox("No board config specified", vbCritical)
                        ComboBox2.SelectedIndex = 0
                    Else
                        specificBoardConfig = True
                    End If
                End If
            Else
                If ComboBox2.SelectedIndex = 15 Or ComboBox2.SelectedIndex = 16 Or ComboBox2.SelectedIndex = 17 Then
                    specificBoardConfig = True
                    boardConfig = My.Settings.boardConfig
                Else
                    specificBoardConfig = False
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            iOSTxt.Enabled = False
            specificiOS = False
        ElseIf CheckBox2.Checked = False Then
            iOSTxt.Enabled = True
            specificiOS = True
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        My.Settings.indexIdentifier1 = ComboBox1.SelectedIndex
        My.Settings.indexIdentifier2 = ComboBox2.SelectedIndex
        My.Settings.ECID = ECIDTxt.Text
        My.Settings.boardConfig = boardConfig
        My.Settings.Save()
        MsgBox("Settings saved", vbInformation)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("SaveSHSH v1 by OBEY", vbInformation)
    End Sub
End Class
