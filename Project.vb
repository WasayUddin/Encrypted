Module Module1

    Sub Main()
        Dim Name As String
        Dim ID As Integer
        Dim more As Char
        Dim searchName As String
        Dim isFound As Boolean
        Dim Choice As Char
        Dim TelNo As Integer
        Dim MembershipDate As String
        TelNo = 0
        MembershipDate = ""
        Choice = "N"
        searchName = ""
        isFound = False
        Name = ""
        ID = 0
        more = "N"
        FileOpen(1, "Membership.txt", OpenMode.Output) 'Task1.1
        Do
            Console.WriteLine("Enter Name of Member: ") : Name = Console.ReadLine
            Console.WriteLine("Enter ID of Member: ") : ID = Console.ReadLine
            WriteLine(1, Name)
            WriteLine(1, ID)
            Console.WriteLine("Do you want to add another record? (Y/N)") : more = Console.ReadLine
        Loop Until UCase(more) = "N"
        FileClose(1)
        FileOpen(1, "Membership.txt", OpenMode.Input) 'Task1.2
        While Not EOF(1)
            Input(1, Name)
            Input(1, ID)
            Console.WriteLine("Memeber's Name = " & Name)
            Console.WriteLine("Memeber's ID = " & ID)
        End While
        FileClose(1)
        Console.WriteLine("Do you want to search for a member? (Y/N)") : more = Console.ReadLine
        While UCase(more) = "Y"
            If UCase(more) = "Y" Then
                Console.Write("Enter Member's Name to search for: ") : searchName = Console.ReadLine 'Task 1.3
                FileOpen(1, "Membership.txt", OpenMode.Input)
                While Not EOF(1) And isFound = False
                    Input(1, Name)
                    Input(1, ID)
                    If UCase(Name) = UCase(searchName) Then
                        Console.WriteLine("Member's ID number is: " & ID)
                        isFound = True
                    End If
                End While
                If isFound = False Then
                    Console.WriteLine("Name entered is not found")
                End If
                Console.WriteLine("Do you want to search for another member? (Y/N)") : more = Console.ReadLine
                FileClose(1)
            End If
        End While
        Console.WriteLine("Do you want to add data of new members? (Y/N)") : more = Console.ReadLine
        If UCase(more) = "Y" Then
            FileOpen(1, "Membership.txt", OpenMode.Append) 'Task 1.4
            Do
                Console.WriteLine("-------ADDING NEW MEMBER'S DATA--------")
                Console.WriteLine("Enter Name of Member: ") : Name = Console.ReadLine
                Console.WriteLine("Enter ID of Member: ") : ID = Console.ReadLine
                WriteLine(1, Name)
                WriteLine(1, ID)
                Console.Write("Do you want to add another record? (Y/N)") : more = Console.ReadLine
            Loop Until UCase(more) = "N"
            FileClose(1)
        End If
        FileOpen(1, "Membership.txt", OpenMode.Input) 'Task1.5
        FileOpen(2, "Membership_Edited.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, Name)
            Input(1, ID)
            Console.WriteLine("Memeber's Name = " & Name)
            Console.WriteLine("Memeber's ID = " & ID)
            Console.WriteLine("Enter Member's Telephone number : ") : TelNo = Console.ReadLine
            Console.WriteLine("Enter Mebmer's joining date : ") : MembershipDate = Console.ReadLine
            WriteLine(2, Name)
            WriteLine(2, ID)
            WriteLine(2, TelNo)
            WriteLine(2, MembershipDate)
        End While
        FileClose(1)
        FileClose(2)
        Console.ReadKey()
    End Sub

End Module
