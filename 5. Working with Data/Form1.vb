Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim BirthYear As Integer
        YourMessage = "Happy Birthday! How old are you now?"
        MsgBox(YourMessage,, "Happy Birthday")
        BirthYear = Val(InputBox("Enter the year of Birth"))
        MsgBox("You are now " & 2023 - BirthYear & " yearsold")
    End Sub
End Class
