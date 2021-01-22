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
        Console.WriteLine($"Welcome! Thank you {userInput}!")

        Console.ReadLine()
    End Sub

End Module
