Public Class TailSum
    Public Sub New()
        Console.WriteLine("***** TailSum Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input list of number (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Console.Write("Please input summary: ")
            Dim inputSummary As String = Console.ReadLine()

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Dim listOfNumber As New List(Of Integer)
            For Each num In listOfInput
                If Not IsNumeric(num) Or Not IsNumeric(inputSummary) Then
                    Console.WriteLine("Please enter only number !!!")
                    Continue While
                Else
                    listOfNumber.Add(num)
                End If
            Next
            Console.WriteLine(CheckTailSum(listOfNumber.ToArray, inputSummary))
        End While

        Console.WriteLine("***** TailSum End *****")
    End Sub

    Function CheckTailSum(listOfNumber As Integer(), summary As Integer) As String
        If listOfNumber.Length = 0 Then
            Return "List of number is empty"
        End If

        Dim num, sum As Integer
        For index As Integer = listOfNumber.Length - 1 To 0 Step -1
            num += 1
            sum += listOfNumber(index)
            If sum = summary Then
                Exit For
            End If
        Next

        Return "List of number is " & String.Join(",", listOfNumber) & " / summary is " & summary & " and answer is " & IIf(sum = summary, num, "cannot find the answer from this list")
    End Function
End Class
