Public Class SortArrayWord
    Public Sub New()
        Console.WriteLine("***** SortArrayWord Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input list of word (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Console.WriteLine(String.Join(",", SortArrayWord(listOfInput.ToArray)))
        End While

        Console.WriteLine("***** SortArrayWord End *****")
    End Sub

    Function SortArrayWord(listOfWord As String()) As String()
        Dim result As String() = listOfWord

        Dim repeat As Boolean = True
        While repeat
            Dim isSorted As Boolean = False
            For index As Integer = 0 To result.Length - 2
                If result(index) > result(index + 1) Then
                    Dim temp As String = result(index)
                    result(index) = result(index + 1)
                    result(index + 1) = temp
                    isSorted = True
                End If
            Next
            If Not isSorted Then
                repeat = False
            End If
        End While

        Return result
    End Function
End Class
