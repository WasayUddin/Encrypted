Module Module1

    Sub Main()
        Dim STR As String
        Dim Alphabets As String
        Dim Count As Integer
        Dim Y As String
        Dim Find As Integer
        Dim Pangram As Boolean
        Pangram = True
        Find = 0
        Y = ""
        STR = ""
        Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Count = 0
        Console.Write("Enter your sentence: ")
        STR = Console.ReadLine
        STR = UCase(STR)
        For Count = 1 To Len(Alphabets)
            Y = Mid(Alphabets, Count, 1)
            Find = InStr(STR, Y)
            If Find = 0 Then
                Pangram = False
                Exit For
            End If
            If Len(STR) < Len(Alphabets) Then
                Pangram = False
                Exit For
            End If
        Next
        If Pangram = True Then
            Console.WriteLine("It is a Pangram")
        Else
            Console.WriteLine("It is not a Pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
