Public Class PossibleTime
    Public Sub New()
        Console.WriteLine("***** PossibleTime Start *****")

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please input 4 number with (,): ")
            Dim inputListOfNumber As String = Console.ReadLine()

            If inputListOfNumber.Trim.ToLower = "exit" Then
                Exit While
            End If

            Dim listOfInput As String() = inputListOfNumber.Split(",")
            Dim listOfNumber As New List(Of Integer)
            For Each num In listOfInput
                If Not IsNumeric(num) Or listOfInput.Length <> 4 Then
                    Console.WriteLine(IIf(listOfInput.Length <> 4, "Please enter 4 number with (,) !!!", "Please enter only number !!!"))
                    Continue While
                Else
                    listOfNumber.Add(num)
                End If
            Next
            Console.WriteLine("Result is " & GetPossibleTime(listOfNumber.Item(0), listOfNumber.Item(1), listOfNumber.Item(2), listOfNumber.Item(3)))
        End While

        Console.WriteLine("***** PossibleTime End *****")
    End Sub

    Function GetPossibleTime(A As Integer, B As Integer, C As Integer, D As Integer) As Integer
        Dim result As Integer = 0
        Dim t As String() = {A, B, C, D}
        Dim strTime As String = ""
        For x As Integer = 0 To t.Length - 1
            For y As Integer = 0 To t.Length - 1
                If x <> y Then
                    strTime += "," & t(x) & t(y)
                End If
            Next
        Next

        Dim possible As String = ""
        Dim list As String() = strTime.Substring(1).Split(",")
        For x As Integer = 0 To list.Length - 1
            For y As Integer = 0 To list.Length - 1
                If A + B + C + D <> CInt(list(x).Substring(0, 1)) + CInt(list(x).Substring(1)) + CInt(list(y).Substring(0, 1)) + CInt(list(y).Substring(1)) Then
                    Continue For
                End If
                Dim h As String = list(x)
                Dim m As String = list(y)
                If h > 0 And h < 24 And m > 0 And m < 60 Then
                    If possible.IndexOf(h & ":" & m) = -1 Then
                        possible += "," & h & ":" & m
                        Console.WriteLine(h & ":" & m)
                    End If
                End If
            Next
        Next

        If possible <> "" Then
            result = possible.Substring(1).Split(",").Length
        End If
        Return result
    End Function
End Class
