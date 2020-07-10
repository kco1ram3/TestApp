Public Class RemoveTrees
    Public Sub New()
        Console.WriteLine("***** RemoveTrees Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input number with (,): ")
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
            Console.WriteLine("Result is " & GetRemoveTrees(listOfNumber.ToArray))
        End While

        Console.WriteLine("***** RemoveTrees End *****")
    End Sub

    Function GetRemoveTrees(listOfNumber As Integer()) As Integer
        Dim result As Integer = 0
        Dim check(listOfNumber.Length - 2) As Integer
        Dim countBit As Integer = Nothing
        For index As Integer = 0 To listOfNumber.Length - 2
            check(index) = IIf(listOfNumber(index) < listOfNumber(index + 1), 1, 0)
            If index = 0 Or countBit = Nothing Or (index > 0 AndAlso check(index) = check(index - 1)) Then
                countBit = IIf(IsNothing(countBit), 1, countBit + 1)
            Else
                If countBit > 1 Then
                    result += countBit + 1
                End If
                countBit = Nothing
            End If
        Next
        If check.Length = countBit Then
            result = -1
        ElseIf countBit > 1 Then
            result += countBit + 1
        End If

        Console.WriteLine(String.Join(",", check))
        Return result
    End Function
End Class
