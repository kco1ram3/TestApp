Public Class OddOccurrencesInArray
    Public Sub New()
        Console.WriteLine("***** OddOccurrencesInArray Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input list of number (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Dim listOfNumber As New List(Of Integer)
            For Each num In listOfInput
                If Not IsNumeric(num) Then
                    Console.WriteLine("Please enter only number !!!")
                    Continue While
                Else
                    listOfNumber.Add(num)
                End If
            Next
            Console.WriteLine("Result is " & GetOddNumberInArray(listOfNumber.ToArray))
        End While

        Console.WriteLine("***** OddOccurrencesInArray End *****")
    End Sub

    Function GetOddNumberInArray(listOfNumber As Integer()) As Integer
        Try
            Dim result As Integer = 0
            Dim listExist As New List(Of Integer)
            For index As Integer = 0 To listOfNumber.Length - 1
                'If Array.IndexOf(listOfNumber, listOfNumber(index)) = Array.LastIndexOf(listOfNumber, listOfNumber(index)) Then
                '    result = listOfNumber(index)
                '    Exit For
                'End If

                If Array.IndexOf(listOfNumber, listOfNumber(index), index + 1) = -1 And listExist.IndexOf(listOfNumber(index)) = -1 Then
                    result = listOfNumber(index)
                    Exit For
                End If
                If listExist.IndexOf(listOfNumber(index)) = -1 Then
                    listExist.Add(listOfNumber(index))
                End If
            Next

            'listOfNumber.Distinct().ToList().ForEach(Sub(digit)
            '                                             If listOfNumber.Count(Function(s) s = digit) = 1 Then
            '                                                 result = digit
            '                                                 Exit Sub
            '                                             End If
            '                                         End Sub)

            Return result
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
