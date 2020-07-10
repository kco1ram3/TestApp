Public Class RotateArray
    Public Sub New()
        Console.WriteLine("***** RotateArray Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input list of number (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Console.Write("Please input time of rotate: ")
            Dim inputRotateTime As String = Console.ReadLine()

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Dim listOfNumber As New List(Of Integer)
            For Each num In listOfInput
                If Not IsNumeric(num) Or Not IsNumeric(inputRotateTime) Then
                    Console.WriteLine("Please enter only number !!!")
                    Continue While
                Else
                    listOfNumber.Add(num)
                End If
            Next
            Console.WriteLine(String.Join(",", RotateArray(listOfNumber.ToArray, inputRotateTime)))
        End While

        Console.WriteLine("***** RotateArray End *****")
    End Sub

    Function RotateArray(listOfNumber As Integer(), timeRotate As Integer) As Integer()
        Try
            Dim result As Integer() = listOfNumber
            For time As Integer = 1 To timeRotate
                Dim rotate(result.Length - 1) As Integer
                rotate(0) = result(result.Length - 1)
                For index As Integer = 0 To result.Length - 2
                    rotate(index + 1) = result(index)
                Next
                result = rotate
            Next

            Return result
        Catch ex As Exception
            Return New Integer() {}
        End Try
    End Function
End Class
