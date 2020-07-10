Public Class CheckWordCaplockAndBackspace
    Public Sub New()
        Console.WriteLine("***** CheckWordCaplockAndBackspace Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please enter some word with C (Caplock) or B (Backspace): ")
            Dim input As String = Console.ReadLine().Trim
            If input.ToLower = "exit" Then
                Exit While
            End If
            If input = "" Then
                Console.WriteLine("Please enter some word with C (Caplock) or B (Backspace) !!!")
                Continue While
            End If

            Console.WriteLine("Result is " & CheckWordCaplockAndBackspace(input))
        End While

        Console.WriteLine("***** CheckWordCaplockAndBackspace End *****")
    End Sub

    Function CheckWordCaplockAndBackspace(someWord As String) As String
        Dim activateCaplock = False
        Dim result As String = ""
        For index As Integer = 0 To someWord.Length - 1
            If someWord(index) = "C" Then
                activateCaplock = Not activateCaplock
                Continue For
            ElseIf someWord(index) = "B" Then
                If result.Length > 0 Then
                    result = result.Substring(0, result.Length - 1)
                End If
                Continue For
            End If
            If activateCaplock Then
                result += someWord(index).ToString.ToUpper
            Else
                result += someWord(index).ToString.ToLower
            End If
        Next
        Return result
    End Function
End Class
