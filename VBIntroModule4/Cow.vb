Public Class Cow : Implements Animal, IComparable

    Private _height As Double
    Private _weight As Double

    Public Property Height As Double Implements Animal.Height
        Get
            Return _height
        End Get
        Set(value As Double)
            _height = value
        End Set
    End Property

    Public Property Weight As Double Implements Animal.Weight
        Get
            Return _weight
        End Get
        Set(value As Double)
            _weight = value
        End Set
    End Property

    Public Function Speed() As Double Implements Animal.Speed
        Return 11
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

        If TypeOf obj Is Cow Then

            If CType(obj, Cow).Height = Height And CType(obj, Cow).Weight = Weight And CType(obj, Cow).Speed() = Speed() Then

                Return 0

            ElseIf CType(obj, Cow).Speed() >= Speed() Then

                Return -1

            Else
                Return 1

            End If

            Return -1

        End If

    End Function


    'Public spots As Integer

    'Public Overrides Sub Walk(inDistance As Integer)
    '    Console.WriteLine(String.Format("Cow walks {0}", inDistance))
    'End Sub



    'Public Overrides Function Equals(ByVal inObj As Object) As Boolean

    '    If TypeOf inObj Is Cow Then

    '        Return CType(inObj, Cow).spots = spots

    '    Else

    '        Return inObj.GetHashCode = MyClass.GetHashCode

    '    End If

    'End Function


    'Public Overloads Function Equals(ByVal inCow As Cow) As Boolean
    '    Return inCow.spots = spots
    'End Function



End Class
