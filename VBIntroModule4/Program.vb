Imports System
Imports System.IO

Module Program
    Sub Main(args As String())


        'FileStream

        'StreamReader

        'StreamWriter

        'BinaryReader

        'BinaryWriter



        'Append open file if it exists and goes to the end of the file

        'Create create a new file override if the file exists

        'CreateNew will throw exception if the file exists

        'Open open and existing file and start at the top

        'OpenOrCreate open or create a new file if it doesnt exist

        'Truncate open existing file and empty the file so it is zero bytes


        'None

        'Read

        'ReadWrite

        'Write


        'Dim path As String = "C:\temp\test.txt"

        'Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write)


        'StreamWriter:
        'Write()
        'WriteLine()
        'Close()


        'StreamReader:
        'Read()
        'ReadLine()
        'ReadToEnd()
        'Peek()
        'Close()

        Dim path As String = "C:\temp\test.txt"

        Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write)

        Dim myOutput = New StreamWriter(fs)

        myOutput.WriteLine("Hello")

        myOutput.Close()

        Dim fs2 As New FileStream(path, FileMode.Open, FileAccess.Read)

        Dim myInput = New StreamReader(fs2)

        Dim x = myInput.ReadLine()

        myInput.Close()

        Console.WriteLine(x.ToString)





    End Sub
End Module
