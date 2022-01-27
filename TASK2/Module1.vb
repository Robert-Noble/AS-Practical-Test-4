Module Module1
    Sub Main()
        Dim Menu_Option As Integer

        Do
            Show_Menu()
            Menu_Option = Get_Menu_Choice()

            Select Case Menu_Option
                Case 1
                    Console.Clear()
                    Add_New_Entrants()
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
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------------------")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("Enter Choice: ")
        Return Console.ReadLine
    End Function

    Sub Add_New_Entrants()
        Dim File_Name As String
        Dim Entrant_Name As String

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("----------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("What is the name of the file you want to write these entrants to?: ")
        File_Name = Console.ReadLine

        FileOpen(1, "S:\" & File_Name, OpenMode.Output)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("-----------------------------------------------------------------------------------------")
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("Enter next entrant name. (To end this session type (ZZZ) and you will return to the menu.): ")
            Entrant_Name = Console.ReadLine
            If Entrant_Name <> "ZZZ" Then
                PrintLine(1, Entrant_Name)
            End If
        Loop Until Entrant_Name = "ZZZ"

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("------------------------------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("All new entrants added to the file ----- Returning to menu ----- PRESS ENTER to continue")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("------------------------------------------------------------------------------------------")

        Console.ReadLine()
        FileClose(1)
    End Sub
End Module
