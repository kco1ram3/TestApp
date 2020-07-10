Public Class FrogJump
    Public Sub New()
        Console.WriteLine("***** FrogJump Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input 3 number with (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Dim listOfNumber As New List(Of Integer)
            For Each num In listOfInput
                If Not IsNumeric(num) Or listOfInput.Length <> 3 Then
                    Console.WriteLine(IIf(listOfInput.Length <> 3, "Please enter 3 number with (,) !!!", "Please enter only number !!!"))
                    Continue While
                Else
                    listOfNumber.Add(num)
                End If
            Next
            Console.WriteLine("Result is " & GetFrogJumpTime(listOfNumber.Item(0), listOfNumber.Item(1), listOfNumber.Item(2)))
        End While

        Console.WriteLine("***** FrogJump End *****")
    End Sub

    Function GetFrogJumpTime(start As Integer, finish As Integer, jump As Integer) As Integer
        Dim result As Integer = 0
        Dim currentPosition As Integer = 0
        While currentPosition < finish
            result += 1
            currentPosition = IIf(currentPosition = 0, start, currentPosition) + jump
        End While

        Return result
    End Function
End Class
