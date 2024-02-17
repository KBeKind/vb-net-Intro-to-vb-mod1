Public Class mySampleClass


    Private myCode As String

    Public Property Code As String
        Get
            Return myCode
        End Get
        Set(value As String)
            myCode = value
        End Set
    End Property

    Public Sub New()
        myCode = "1111"
    End Sub

    Public Sub New(inCode As String)
        myCode = inCode
    End Sub


    Public Function ReverseCode() As String
        Return myCode.Reverse()
    End Function

    Public Sub AppendCode(inSuffix As String)
        myCode = myCode & inSuffix
    End Sub

End Class
