Imports System

Module Program
    Sub Main(args As String())


        'Dim x As mySampleClass = New mySampleClass()

        'x.Code = "12345"
        'x.AppendCode("6")

        'Console.WriteLine(x.Code)


        'Dim myBMI As bmi = New bmi()

        'myBMI.Weight = 30
        'myBMI.Height = 2.3

        'Console.WriteLine(myBMI.BMI_Value())



        'Dim friends() As String = {"Fred", "Sally", "Bill"}

        'Dim arrayLength As Integer = friends.Length

        'Dim lineNumber = 1

        ' MULTIDIMENSIONAL ARRAY
        'Dim myGrades(1, 9) As Integer
        'myGrades(1, 2) = 100

        'For row As Integer = 0 To myGrades.GetLength(0) - 1
        '    For column As Integer = 0 To myGrades.GetLength(1) - 1
        '        myGrades(row, column) = 100
        '        Console.WriteLine(String.Format("Line: {0}  Value: {1}", lineNumber, myGrades(row, column)))
        '        lineNumber += 1
        '    Next
        'Next

        'JAGGED ARRAY
        'Dim newGrades(1)() As Integer
        'newGrades(0) = New Integer(4) {}
        'newGrades(1) = New Integer(9) {}


        'LISTS
        'Dim moreGrades As New List(Of Integer)
        ''moreGrades(0) = 100
        'moreGrades.Add(95)
        'Console.WriteLine(moreGrades.Count)


        'QUEUES
        'Dim extraGrades As New Queue(Of Integer)
        'extraGrades.Enqueue(100)
        'extraGrades.Enqueue(95)
        'Console.WriteLine(extraGrades.Count)
        'Console.WriteLine(extraGrades.Dequeue())


        'STACK
        'Dim otherGrades As New Stack(Of Integer)
        'otherGrades.Push(95)
        'otherGrades.Push(100)
        'Console.WriteLine(otherGrades.Count)
        'Console.WriteLine(otherGrades.Pop())





        'Dim grades As New Queue(Of Integer)
        'Dim userNumberInteger As Integer
        'Dim endValueInteger As Integer = 0

        'Do
        '    userNumberInteger = Console.ReadLine()

        '    If userNumberInteger = -1 Then
        '        Exit Do
        '    End If
        '    grades.Enqueue(userNumberInteger)

        '    endValueInteger += userNumberInteger

        'Loop Until userNumberInteger = -1

        'Dim average As Integer = endValueInteger / grades.Count

        'Console.WriteLine(average)

        'For i = 0 To grades.Count - 1
        '    Console.WriteLine(grades.Dequeue())
        'Next



    End Sub
End Module
