Public Class Cow : Inherits Animal


    Public spots As Integer

    Public Overrides Sub Walk(inDistance As Integer)
        Console.WriteLine(String.Format("Cow walks {0}", inDistance))
    End Sub



    Public Overrides Function Equals(ByVal inObj As Object) As Boolean

        If TypeOf inObj Is Cow Then

            Return CType(inObj, Cow).spots = spots

        Else

            Return inObj.GetHashCode = MyClass.GetHashCode

        End If

    End Function


    Public Overloads Function Equals(ByVal inCow As Cow) As Boolean
        Return inCow.spots = spots
    End Function



End Class
