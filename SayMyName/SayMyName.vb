'Tori Gomez
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/ToriGomez/SayMyName.git

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim userInput As String

        Console.WriteLine("Type Name and Press Enter")

        userInput = Console.ReadLine()

        If userInput = "Emily" Or userInput = "Joe" Or userInput = "emily" Or userInput = "joe" Then
            Console.WriteLine($"Welcome {userInput}!")
            Console.Read()
        Else
            Console.WriteLine("You're in Say my Name but you said the wrong name... Try again later?")
            Console.WriteLine("Thank You!")
        End If

        Console.ReadLine()

    End Sub

End Module
