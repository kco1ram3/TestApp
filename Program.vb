
Module Program
    Sub Main(args As String())
        Console.WriteLine("***** Lists of Program *****")
        Console.WriteLine("1. StrengthLastString")
        Console.WriteLine("2. TailSum")
        Console.WriteLine("3. BinaryGap")
        Console.WriteLine("4. RotateArray")
        Console.WriteLine("5. OddOccurrencesInArray")
        Console.WriteLine("6. FrogJump")
        Console.WriteLine("7. SortArray")
        Console.WriteLine("8. SortArrayWord")
        Console.WriteLine("9. CheckWordCaplockAndBackspace")
        Console.WriteLine("10. PossibleTime")
        Console.WriteLine("11. RemoveTrees")
        Console.WriteLine("0. Exit Program")
        Console.WriteLine("*************************")
        Console.WriteLine()

        Dim repeatInput As Boolean = True

        While repeatInput
            Console.Write("Please enter number of class: ")
            Dim input As String = Console.ReadLine().Trim.ToLower
            If input = "0" Then
                Exit While
            End If

            Select Case input
                Case "1"
                    Dim clsStrengthLastString As New StrengthLastString()
                Case "2"
                    Dim clsTailSum As New TailSum()
                Case "3"
                    Dim clsBinaryGap As New BinaryGap()
                Case "4"
                    Dim clsRotateArray As New RotateArray()
                Case "5"
                    Dim clsOddOccurrencesInArray As New OddOccurrencesInArray()
                Case "6"
                    Dim clsFrogJump As New FrogJump()
                Case "7"
                    Dim clsSortArray As New SortArray()
                Case "8"
                    Dim clsSortArrayWord As New SortArrayWord()
                Case "9"
                    Dim clsCheckWordCaplockAndBackspace As New CheckWordCaplockAndBackspace()
                Case "10"
                    Dim clsPossibleTime As New PossibleTime()
                Case "11"
                    Dim clsRemoveTrees As New RemoveTrees()
                Case Else
                    Console.WriteLine("Please enter valid number !!!")
            End Select
        End While
    End Sub
End Module
