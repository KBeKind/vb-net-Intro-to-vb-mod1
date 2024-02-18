Imports System
Imports System.IO
Imports System.Reflection

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

        'Dim path As String = "C:\temp\test.txt"

        'Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write)

        'Dim myOutput = New StreamWriter(fs)

        'myOutput.WriteLine("Hello")

        'myOutput.Close()

        'Dim fs2 As New FileStream(path, FileMode.Open, FileAccess.Read)

        'Dim myInput = New StreamReader(fs2)

        'Dim x = myInput.ReadLine()

        'myInput.Close()

        'Console.WriteLine(x.ToString)



        'BINARY DATA

        'BINARY OUTPUT
        'Write(data)
        'Close()


        'Dim path As String = "C:\temp\test.bin"

        'Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write)

        'Dim myOutput = New BinaryWriter(fs)

        'Dim x As Decimal = 12.4

        'myOutput.Write(x)

        'myOutput.Close()


        'BINARY READER
        'PeekChar()
        'Read()
        'ReadBoolean()
        'ReadByte
        'ReadChar()
        'ReadDecimal()
        'ReadInt32()
        'ReadString()
        'Close()

        'Dim fs2 As New FileStream(path, FileMode.Open, FileAccess.Read)

        'Dim myInput = New BinaryReader(fs2)

        'Dim y As Decimal = myInput.ReadDecimal()

        'myInput.Close()

        'Console.WriteLine(y)

        'Dim exeDirectory As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)

        'Dim completePath = exeDirectory & "\" & "indata.txt"

        'Dim fs As New FileStream("indata.txt", FileMode.Open, FileAccess.Read)

        'Dim intList As List(Of Integer) = New List(Of Integer)

        'Dim incomingIntString As String = ""

        'Dim total As Integer = 0

        'Dim myInput = New StreamReader(fs)

        'Do
        '    incomingIntString = myInput.ReadLine()

        '    If incomingIntString Is Nothing Then
        '        Exit Do
        '    End If

        '    total += incomingIntString

        'Loop Until incomingIntString Is Nothing

        'myInput.Close()

        'Console.WriteLine(String.Format("{0:n2}", total))




        'System.Object METHODS

        'ToString()
        'Equals(object)
        'Equals(object1, object2)
        'ReferenceEquals(object1, object2)
        'GetType()
        'GetHashCode()
        'Finalize()
        'MemberwiseClone()



        'MyBase refers to the base class of the current instance of a class
        'Me keyword provides a reference to the specific instance of a class





    End Sub
End Module
