Imports System.IO

Public Class bmi



    Public Weight As Decimal
    Public Height As Decimal

    Public Function BMI_Value()

        Return Weight / Height ^ 2

    End Function


    Public Overrides Function Equals(ByVal inObj As Object) As Boolean

        If TypeOf inObj Is bmi Then

            Return CType(inObj, bmi).BMI_Value() = BMI_Value()

        Else

            Return inObj.GetHashCode = MyClass.GetHashCode

        End If

    End Function


    Public Overloads Function Equals(ByVal inBMI As bmi) As Boolean
        Return inBMI.BMI_Value() = BMI_Value()
    End Function


End Class
