Public Class SortArray
    Public Sub New()
        Console.WriteLine("***** SortArray Start *****")

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
            Console.WriteLine(String.Join(",", SortArray(listOfNumber.ToArray)))
        End While

        Console.WriteLine("***** SortArray End *****")
    End Sub

    Function SortArray(listOfNumber As Integer()) As Integer()
        Dim result As Integer() = listOfNumber

        Dim repeat As Boolean = True
        While repeat
            Dim isSorted As Boolean = False
            For index As Integer = 0 To result.Length - 2
                If result(index) > result(index + 1) Then
                    Dim temp As Integer = result(index)
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
