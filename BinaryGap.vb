Public Class BinaryGap
    Public Sub New()
        Console.WriteLine("***** BinaryGap Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input number: ")
            Dim input As String = Console.ReadLine().Trim

            If input.ToLower = "exit" Then
                Exit While
            End If
            If Not IsNumeric(input) Then
                Console.WriteLine("Please enter only number !!!")
                Continue While
            End If
            Console.WriteLine("Result is " & CheckBinaryGap(input))

        End While

        Console.WriteLine("***** BinaryGap End *****")
    End Sub

    Function CheckBinaryGap(input As Integer) As Integer
        Dim binary As String = Convert.ToString(input, 2)
        Dim gap, count As Integer
        For index As Integer = 0 To binary.Length - 1
            If binary(index) = "1" Then
                If count > gap Then
                    gap = count
                End If
                count = 0
            Else
                count += 1
            End If
        Next

        Return gap
    End Function
End Class
