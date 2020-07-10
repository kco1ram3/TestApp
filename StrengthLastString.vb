Public Class StrengthLastString
    Public Sub New()
        Console.WriteLine("***** StrengthLastString Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input number: ")
            Dim input As String = Console.ReadLine()

            If input.Trim.ToLower = "exit" Then
                Exit While
            End If
            If Not IsNumeric(input.Trim) Then
                Console.WriteLine("Please enter only number !!!")
                Continue While
            End If
            Console.WriteLine(CheckLastDigit(input))

        End While

        Console.WriteLine("***** StrengthLastString End *****")
    End Sub

    Function CheckLastDigit(num As Long) As String
        Dim strengthResult As Long = num * num
        Dim getLast As String = strengthResult.ToString.Substring(IIf(strengthResult.ToString.Length = 1,
                                                                      0,
                                                                      strengthResult.ToString.Length - num.ToString.Length))
        Return num & " : " & strengthResult & " result is " & IIf(num.ToString.Equals(getLast), 1, 0)
    End Function
End Class
