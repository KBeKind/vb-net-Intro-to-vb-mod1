Imports System

Module Program

    Sub Main(args As String())

        'Console.WriteLine("Welcome to Coursera " & Console.ReadLine())


        'Dim salary As String = Console.ReadLine()

        'salary = FormatNumber(salary, 2)

        'Console.WriteLine(salary)


        'Dim numberToDivide As String = Console.ReadLine()

        'Dim numberToDivideInt = CInt(numberToDivide)

        'Dim workingValue As Decimal = (numberToDivideInt / 3)

        'Dim formattedResult As Decimal = Math.Round(workingValue, 3)

        'Console.WriteLine(FormatNumber(formattedResult, 3))


        'Dim yourname As String

        'yourname = Console.ReadLine()

        'Console.Write("Hello ")

        'If (yourname = "Sally") Then
        '    Console.WriteLine("Sally my friend")
        'ElseIf (yourname = "Fred") Then
        '    Console.WriteLine("Fred my exfriend")
        'Else
        '    Console.WriteLine(yourname)
        'End If



        'Select Case yourname

        '    Case "Sally"
        '        Console.WriteLine("Sally my friend")

        '    Case "Fred"
        '        Console.WriteLine("Fred my exfriend")

        '    Case Else
        '        Console.WriteLine(yourname)

        'End Select



        'Dim userNumberString As String

        'userNumberString = Console.ReadLine()

        'Dim userNumberInteger As Integer = Integer.Parse(userNumberString)

        'If (userNumberInteger < 100) Then
        '    Console.WriteLine("Small")
        'ElseIf (userNumberInteger < 200) Then
        '    Console.WriteLine("Medium")
        'Else
        '    Console.WriteLine("Large")
        'End If

        'Select Case userNumberInteger
        '    Case Is < 100
        '        Console.WriteLine("Small")

        '    Case Is < 200
        '        Console.WriteLine("Medium")

        '    Case Else
        '        Console.WriteLine("Large")
        'End Select


        'Dim sum As Integer
        'Dim i As Integer


        'For i = 1 To 9 Step 2

        '    sum += i

        'Next


        'For i = 9 To 1 Step -2

        '    sum += i

        'Next

        'i = 0

        'Do While i <= 5
        '    sum += i
        '    i += 1
        'Loop

        'Do
        '    sum += i
        '    i += 1
        'Loop While i < 5


        'Dim sum As Integer
        'Dim i As Integer

        'For i = 1 To 5

        '    If (1 > 3) Then
        '        Exit For
        '    End If

        '    sum += i
        'Next


        'i = 0

        'For i = 1 To 5

        '    If (i = 3) Then
        '        Continue For
        '    End If

        '    sum += i
        'Next



        'Dim userNumberString As String = Console.ReadLine()
        'Dim userNumberInteger = Integer.Parse(userNumberString)

        'Dim endValueInteger As Integer = 0
        'Dim i As Integer

        'For i = 1 To userNumberInteger
        '    endValueInteger += i
        'Next

        'Console.WriteLine(endValueInteger)

        Dim userNumberInteger As Integer
        Dim userNumberString As String

        Dim endValueInteger As Integer = 0

        Do
            userNumberString = Console.ReadLine()
            userNumberInteger = Integer.Parse(userNumberString)

            If userNumberInteger = -1 Then
                Exit Do
            End If

            endValueInteger += userNumberInteger

        Loop Until userNumberInteger = -1

        Console.WriteLine(endValueInteger)

    End Sub



End Module
