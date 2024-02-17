Public Class bmi

    'Private pWeight As Decimal
    'Private pHeight As Decimal

    Public Property Weight As Decimal
    'Get
    '    Return pWeight
    'End Get
    'Set(value As Decimal)
    '    pWeight = value
    'End Set
    'End Property
    Public Property Height As Decimal
    '    Get
    '        Return pHeight
    '    End Get
    '    Set(value As Decimal)
    '        pHeight = value
    '    End Set
    'End Property


    Public Function BMI_Value()

        Return Weight / Height ^ 2

    End Function


End Class
