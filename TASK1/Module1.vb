Module Module1
    Sub Main()
        Dim Menu_Option As Integer
        Do
            Show_Menu()
            Menu_Option = Get_Menu_Choice()

            Select Case Menu_Option
                Case 1
                Case 2
                Case 3
                Case 4
                Case Else
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("---------------------------------------")
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Invalid!")
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("---------------------------------------")
                    Console.ReadLine()
            End Select
        Loop Until Menu_Option = 4
        Console.ReadLine()
    End Sub

    Sub Show_Menu()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------------------")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("1. Add new entrants to a file.")
        Console.WriteLine("2. Pick a winner.")
        Console.WriteLine("3. Update the winners list.")
        Console.WriteLine("4. Exit program.")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------------------")

    End Sub

    Function Get_Menu_Choice()
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("Enter Choice: ")
        Return Console.ReadLine
    End Function
End Module
