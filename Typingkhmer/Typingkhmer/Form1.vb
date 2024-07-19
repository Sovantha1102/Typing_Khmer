Imports System.IO
Public Class frmtyping
    Dim lesson As Integer
    Dim lessonlen As Integer
    Dim file As System.IO.StreamWriter
    Private Sub frmtyping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lesson = 1
        Showlesson(lesson) 'call a sub showlesson
        Advice()
    End Sub
    Sub Showlesson(lesson As Integer)
        Dim reader As New StreamReader(Application.StartupPath & "\lesson\lesson" & lesson & ".txt")
        lblLesson.Text = reader.ReadToEnd
        'cut a charector one by one
        lbltypingchar.Text = Mid(lbltypingchar.Text, 1, 1)
    End Sub
    Sub Advice()
        Select Case lbltypingchar.Text
            Case "ក"
                lblAdvice.Text = "Press K"
            Case "ខ"
                lblAdvice.Text = "Press X"
            Case "គ"
                lblAdvice.Text = "Press Shift+K"
            Case "ឃ"
                lblAdvice.Text = "Press Shift+X"
            Case "ង"
                lblAdvice.Text = "Press G"
            Case "ច"
                lblAdvice.Text = "Press C"
            Case "ឆ"
                lblAdvice.Text = "Press Q"
            Case "ជ"
                lblAdvice.Text = "Press Shift+C"
            Case "ឈ"
                lblAdvice.Text = "Press Shift+Q"
            Case "ញ"
                lblAdvice.Text = "Press Shift+J"
            Case "ដ"
                lblAdvice.Text = "Press D"
            Case "ឋ"
                lblAdvice.Text = "Press Z"
            Case "ឌ"
                lblAdvice.Text = "Press Shift+D"
            Case "ឍ"
                lblAdvice.Text = "Press Shift+Z"
            Case "ណ"
                lblAdvice.Text = "Press Shift+N"
            Case "ត"
                lblAdvice.Text = "Press T"
            Case "ថ"
                lblAdvice.Text = "Press F"
            Case "ទ"
                lblAdvice.Text = "Press Shift+T"
            Case "ធ"
                lblAdvice.Text = "Press Shift+F"
            Case "ន"
                lblAdvice.Text = "Press N"
            Case "ប"
                lblAdvice.Text = "Press B"
            Case "ផ"
                lblAdvice.Text = "Press P"
            Case "ព"
                lblAdvice.Text = "Press Shift+B"
            Case "ភ"
                lblAdvice.Text = "Press Shift+P"
            Case "ម"
                lblAdvice.Text = "Press M"
            Case "យ"
                lblAdvice.Text = "Press Y"
            Case "រ"
                lblAdvice.Text = "Press R"
            Case "ល"
                lblAdvice.Text = "Press L"
            Case "វ"
                lblAdvice.Text = "Press V"
            Case "ស"
                lblAdvice.Text = "Press S"
            Case "ហ"
                lblAdvice.Text = "Press H"
            Case "ឡ"
                lblAdvice.Text = "Press Shift+L"
            Case "អ"
                lblAdvice.Text = "Press Shift+G"
            Case "០​ា"
                lblAdvice.Text = "Press+A"
            Case "០ាំ"
                lblAdvice.Text = "Press Shift+A"
       'Vowel Show===================================================
            Case "ា"
                lblAdvice.Text = "Press A"
            Case "ិ"
                lblAdvice.Text = "Press I"
            Case "ី"
                lblAdvice.Text = "Press Shift+I"
            Case "ឹ"
                lblAdvice.Text = "Press W"
            Case "ឺ"
                lblAdvice.Text = "Press Shift+W"
            Case "ុ"
                lblAdvice.Text = "Press U"
            Case "ូ"
                lblAdvice.Text = "Press Shift+U"
            Case "ួ"
                lblAdvice.Text = "Press Shift+Y"
            Case "ើ"
                lblAdvice.Text = "Press ;"
            Case "ឿ"
                lblAdvice.Text = "Press Shift+["
            Case "ៀ"
                lblAdvice.Text = "Press ["
            Case "េ"
                lblAdvice.Text = "Press E"
            Case "ែ"
                lblAdvice.Text = "Press Shift+E"
            Case "ៃ"
                lblAdvice.Text = "Press Shift+S"
            Case "ោ"
                lblAdvice.Text = "Press  O"
            Case "ៅ"
                lblAdvice.Text = "Press Shift+O"
            Case "ុំ"
                lblAdvice.Text = "Press  ,"
            Case "ំ"
                lblAdvice.Text = "Press Shift+M"
            Case "ាំ"
                lblAdvice.Text = "Press Shift+A"
            Case "ះ"
                lblAdvice.Text = "Press Shift+H"
            Case "ុះ"
                lblAdvice.Text = "Press  Shift+ , "
            Case "េះ"
                lblAdvice.Text = "Press V"
            Case "ោះ"
                lblAdvice.Text = "Press Shift+  "
            Case "្"
                lblAdvice.Text = "Press J"
     'main vowel==========================================
            Case "ឩ"
                lblAdvice.Text = "Press Alt+["
            Case "ឪ"
                lblAdvice.Text = "Press  ]"
            Case "ឧ"
                lblAdvice.Text = "Press Shift+]"
            Case "ឮ"
                lblAdvice.Text = "Press \"
            Case "ឭ"
                lblAdvice.Text = "Press Shift+\"
            Case "៖"
                lblAdvice.Text = "Press  Alt+ ; "
            Case "ឯ"
                lblAdvice.Text = "Press  Alt+ E "
            Case "ឬ"
                lblAdvice.Text = "Press Shift+R "
            Case "ឫ"
                lblAdvice.Text = "Press Alt+R"
            Case "ឱ"
                lblAdvice.Text = "Press Alt+O"
            Case "ឥ"
                lblAdvice.Text = "Press  _ "
            Case "ឲ"
                lblAdvice.Text = "Press Shift+ = "
   'Some Symbol ==========================================
            Case "៉"
                lblAdvice.Text = "Press Shift+ ' "
            Case "ៈ"
                lblAdvice.Text = "Press  Alt+' "
            Case " ៊"
                lblAdvice.Text = "Press / "
            Case "."
                lblAdvice.Text = "Press .>"
            Case ","
                lblAdvice.Text = "Press Alt+ <,"
            Case "៎"
                lblAdvice.Text = "Press Alt+ = "
            Case "៌"
                lblAdvice.Text = "Press Shift+ _ "
            Case "៏"
                lblAdvice.Text = "Press Shift+8"
            Case "័"
                lblAdvice.Text = "Press Shifr+7"
            Case "៍"
                lblAdvice.Text = "Press Shift+6"
            Case "៛"
                lblAdvice.Text = "Press Shift+4"
            Case "ៗ"
                lblAdvice.Text = "Press Shift+2"
            Case "!"
                lblAdvice.Text = "Press Shift+1"
            Case "។"
                lblAdvice.Text = "Press . "
            Case "៕"
                lblAdvice.Text = "Press Shift+ . "
            Case Else
                lblAdvice.Text = " "

        End Select
    End Sub
    Private Sub frmtyping_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim typingchar As String = e.KeyChar
        Dim lessonchar As String = Mid(lblLesson.Text, 1, 1)
        lessonlen = lblLesson.Text.Length
        If typingchar = lessonchar Then
            lessonlen = lessonlen - 1
            lblLesson.Text = Mid(lblLesson.Text, 2, lessonlen)
            lbltypingchar.Text = Mid(lblLesson.Text, 1, 1)
            If lblLesson.Text = "" Then
                lesson = lesson + 1
                If lesson > 15 Then
                    lesson = 1
                End If
                Showlesson(lesson) 'Call a sub procedure
            End If
        End If
        Advice()
    End Sub
    Private Sub frmtyping_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'MsgBox(e.KeyCode)
        Select Case e.KeyCode
            'keys middle===========================================================
            Case 65
                pbA.Top = 123
            Case 83
                pbS.Top = 123
            Case 68
                pbD.Top = 123
            Case 70
                pbF.Top = 123
            Case 71
                pbG.Top = 123
            Case 72
                pbH.Top = 123
            Case 74
                pbJ.Top = 123
            Case 75
                pbK.Top = 123
            Case 76
                pbL.Top = 123
            Case 186
                pb07.Top = 123
            Case 222
                pb08.Top = 123
            Case 13
                pbEnter.Top = 123
                   'keys The Top================================================
            Case 192
                pb01.Top = 1
            Case 49
                pb1.Top = 1
            Case 50
                pb2.Top = 1
            Case 51
                pb3.Top = 1
            Case 52
                pb4.Top = 1
            Case 53
                pb5.Top = 1
            Case 54
                pb6.Top = 1
            Case 55
                pb7.Top = 1
            Case 56
                pb8.Top = 1
            Case 57
                pb9.Top = 1
            Case 48
                pb0.Top = 1
            Case 189
                pb02.Top = 1
            Case 187
                pb03.Top = 1
            Case 8
                pbBackspace.Top = 1
                'keys top================================================
            Case 81
                pbQ.Top = 62
            Case 87
                pbW.Top = 62
            Case 69
                pbE.Top = 62
            Case 82
                pbR.Top = 62
            Case 84
                pbT.Top = 62
            Case 89
                pbY.Top = 62
            Case 85
                pbU.Top = 62
            Case 73
                pbI.Top = 62
            Case 79
                pbO.Top = 62
            Case 80
                pbP.Top = 62
            Case 219
                pb04.Top = 62
            Case 221
                pb05.Top = 62
            Case 220
                pb06.Top = 62
            Case 9
                pbTab.Top = 62
                'KEYS BELOW=============================================
            Case 90
                pbZ.Top = 184
            Case 88
                pbX.Top = 184
            Case 67
                pbC.Top = 184
            Case 86
                pbV.Top = 184
            Case 66
                pbB.Top = 184
            Case 78
                pbN.Top = 184
            Case 77
                pbM.Top = 184
            Case 188
                pb09.Top = 184
            Case 190
                pb010.Top = 184
            Case 191
                pb011.Top = 184
            Case 16
                PbShi.Top = 184
            Case 16
                pbShift.Top = 184
                   'KEYS LOW=============================================
            Case 17
                pbctrl.Top = 245
            Case 18
                pbAL.Top = 245
            Case 32
                pbSpace.Top = 245
            Case 18
                pbAlt.Top = 245
            Case 17
                pbCOn.Top = 245
            Case 91
                pbWin.Top = 245
            Case 91
                pbWindow.Top = 245
        End Select
    End Sub
    Private Sub frmtyping_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case 65
                pbA.Top = 125
            Case 83
                pbS.Top = 125
            Case 68
                pbD.Top = 125
            Case 70
                pbF.Top = 125
            Case 71
                pbG.Top = 125
            Case 72
                pbH.Top = 125
            Case 74
                pbJ.Top = 125
            Case 75
                pbK.Top = 125
            Case 76
                pbL.Top = 125
            Case 186
                pb07.Top = 125
            Case 222
                pb08.Top = 125
            Case 13
                pbEnter.Top = 125
                      'keys The Top================================================
            Case 192
                pb01.Top = 3
            Case 49
                pb1.Top = 3
            Case 50
                pb2.Top = 3
            Case 51
                pb3.Top = 3
            Case 52
                pb4.Top = 3
            Case 53
                pb5.Top = 3
            Case 54
                pb6.Top = 3
            Case 55
                pb7.Top = 3
            Case 56
                pb8.Top = 3
            Case 57
                pb9.Top = 3
            Case 48
                pb0.Top = 3
            Case 189
                pb02.Top = 3
            Case 187
                pb03.Top = 3
            Case 8
                pbBackspace.Top = 3
                   'keys top================================================
            Case 81
                pbQ.Top = 64
            Case 87
                pbW.Top = 64
            Case 69
                pbE.Top = 64
            Case 82
                pbR.Top = 64
            Case 84
                pbT.Top = 64
            Case 89
                pbY.Top = 64
            Case 85
                pbU.Top = 64
            Case 73
                pbI.Top = 64
            Case 79
                pbO.Top = 64
            Case 80
                pbP.Top = 64
            Case 219
                pb04.Top = 64
            Case 221
                pb05.Top = 64
            Case 220
                pb06.Top = 64
            Case 9
                pbTab.Top = 64
                    'KEYS BELOW=============================================
            Case 90
                pbZ.Top = 186
            Case 88
                pbX.Top = 186
            Case 67
                pbC.Top = 186
            Case 86
                pbV.Top = 186
            Case 66
                pbB.Top = 186
            Case 78
                pbN.Top = 186
            Case 77
                pbM.Top = 186
            Case 188
                pb09.Top = 186
            Case 190
                pb010.Top = 186
            Case 191
                pb011.Top = 186
            Case 16
                pbShift.Top = 186
            Case 16
                PbShi.Top = 186
                        'KEYS LOW=============================================
            Case 17
                pbctrl.Top = 247
            Case 18
                pbAL.Top = 247
            Case 32
                pbSpace.Top = 247
            Case 18
                pbAlt.Top = 247
            Case 17
                pbCOn.Top = 247
            Case 91
                pbWin.Top = 247
            Case 91
                pbWindow.Top = 247
        End Select
    End Sub
    Private Sub lblChooselessons_Click(sender As Object, e As EventArgs) Handles lblChooselesson.Click
        If lblChooselesson.Text = "ជ្រើសរើសមេរៀន" Then
            Panellesson.Visible = True
            Panel1.Visible = False
            PanelChoice.Visible = False
            lblChooselesson.Text = "បិទមេរៀន"
            lblChooselesson.ForeColor = Color.Red
        ElseIf lblChooselesson.Text = "បិទមេរៀន" Then
            Panel1.Visible = True
            Panellesson.Visible = False
            PanelChoice.Visible = False
            lblChooselesson.Text = "ជ្រើសរើសមេរៀន"
            lblChooselesson.ForeColor = Color.Green
        End If
    End Sub
    Sub HideChooseLesson()
        lblChooselesson.Text = "ជ្រើសរើសមេរៀន"
        lblChooselesson.ForeColor = Color.Green
        Panellesson.Visible = False
        Panel1.Visible = True
        PanelChoice.Visible = False
    End Sub
    Private Sub lbllesson1_Click(sender As Object, e As EventArgs) Handles lbllesson1.Click
        lesson = 1
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson2_Click(sender As Object, e As EventArgs) Handles lbllesson2.Click
        lesson = 2
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson3_Click(sender As Object, e As EventArgs) Handles lbllesson3.Click
        lesson = 3
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson4_Click(sender As Object, e As EventArgs) Handles lbllesson4.Click
        lesson = 4
        Showlesson(lesson)
        HideChooseLesson()
    End Sub
    Private Sub lbllesson5_Click(sender As Object, e As EventArgs) Handles lbllesson5.Click
        lesson = 5
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson6_Click(sender As Object, e As EventArgs) Handles lbllesson6.Click
        lesson = 6
        Showlesson(lesson)
        HideChooseLesson()
    End Sub
    Private Sub lbllesson7_Click(sender As Object, e As EventArgs) Handles lbllesson7.Click
        lesson = 7
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson8_Click(sender As Object, e As EventArgs) Handles lbllesson8.Click
        lesson = 8
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson9_Click(sender As Object, e As EventArgs) Handles lbllesson9.Click
        lesson = 9
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson10_Click(sender As Object, e As EventArgs) Handles lbllesson10.Click
        lesson = 10
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson11_Click(sender As Object, e As EventArgs) Handles lbllesson11.Click
        lesson = 11
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson12_Click(sender As Object, e As EventArgs) Handles lbllesson12.Click
        lesson = 12
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson13_Click(sender As Object, e As EventArgs) Handles lbllesson13.Click
        lesson = 13
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson14_Click(sender As Object, e As EventArgs) Handles lbllesson14.Click
        lesson = 14
        Showlesson(lesson)
        HideChooseLesson()
    End Sub

    Private Sub lbllesson15_Click(sender As Object, e As EventArgs) Handles lbllesson15.Click
        lesson = 15
        Showlesson(lesson)
        HideChooseLesson()
    End Sub


    Private Sub lblOpenlesson_Click(sender As Object, e As EventArgs) Handles lblOpenlesson.Click
        If OpenFileDialog1.ShowDialog Then
            lblOpenlesson.Text = Path.GetFileNameWithoutExtension(Application.StartupPath & "\FormKhmer\Typingkhmer\Typingkhmer\bin\Debug" & ".txt")
        End If
    End Sub

    Private Sub lblCreate_Click(sender As Object, e As EventArgs) Handles lblCreate.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("My lesson's file", True)
        MsgBox("My lesson's file successfully created", vbInformation)

    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        If lblHelp.Text = "ជំនួស" Then
            PanelChoice.Visible = True
            Panellesson.Visible = False
            Panel1.Visible = False
            lblHelp.Text = "បិទ"
            lblHelp.ForeColor = Color.Red
        ElseIf lblHelp.Text = "បិទ" Then
            PanelChoice.Visible = False
            Panellesson.Visible = True
            Panel1.Visible = False
            lblHelp.Text = "ជំនួស"
            lblHelp.ForeColor = Color.Green
        End If
    End Sub
    Sub HideHelp()
        lblHelp.Text = "ជំនួស"
        lblHelp.ForeColor = Color.Green
        Panellesson.Visible = True
        Panel1.Visible = False
        PanelChoice.Visible = False
    End Sub
End Class
