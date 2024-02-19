Public Class Circle : Implements CanCalculateArea, CanDisplayOnScreen

    Public Diameter As Double
    Public Function CanCalculateArea_area() As Double Implements CanCalculateArea.area
        Return Math.PI * Diameter
    End Function

    Public Sub draw() Implements CanDisplayOnScreen.draw
        Console.WriteLine("draws a circle")
    End Sub


    'Public Overrides Function area() As Double
    '    Return Math.PI * Diameter
    'End Function

End Class
