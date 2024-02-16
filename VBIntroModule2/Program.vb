Imports System
Imports System.Reflection.Metadata
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())

        'Dim variableName As Date = #YYYY-MM-DD#

        'Dim variableName2 As DateTime

        'Dim variableName3 As Date = DateTime.Parse("a date string")

        'Dim variableName4 As New DateTime(Year, Month, Day, Hour, Minute, Second, millisecond)

        'Dim currentDateTime As Date = DateTime.Now

        'Dim currentDate As Date = DateTime.Today

        'ToLongDateString()
        'ToShortDateString()
        'ToLongTimeString()
        'ToShortTimeString()

        'Dim thisDateTime As Date = DateTime.Now
        'thisDateTime.Month
        'thisDateTime.Hour
        'thisDateTime.DayOfYear
        'thisDateTime.DayOfWeek

        'Dim daysInMonth As Integer DateTime.DaysInMonth(2024, 2)
        'Dim isLeapYear As Boolean DateTime.IsLeapYear(2024)

        'Dim nextWeekDate = thisDateTime.AddDays(7)
        'Dim nextYearDate = thisDateTime.AddYears(1)


        'FOR STRINGS:
        'Chars(Index)
        'Length

        'METHODS ON STRING OBJECTS:
        'StartsWith(aString)
        'EndsWith(aString)
        'IndexOf(aString, startIndex)
        'LastIndexOf(aString, startIndex)
        'Insert(startindex, aString)
        'PadLeft(totalwidth)
        'PadRight(totalwidth)
        'Remove(startindex, count)
        'Replace(oldstring, newstring)
        'Substring(startindex, length)
        'ToLower
        'ToUpper
        'Trim()
        'Split(splitcharacters)

        'Dim myName As String = "Duder man"
        'Dim firstChar As Char = myName(0)
        'Dim firstSpace As Integer = myName.IndexOf(" ")
        'Dim firstName As String = ""
        'If firstSpace = -1 Then
        '    firstName = myName
        'Else
        '    firstName = myName.Substring(0, firstSpace)
        'End If
        'Console.WriteLine(firstName)


        'Format(aString, value1, value2)
        'value[theWidth][: formatString]
        'C c currency
        'D d number of digits
        'E e exponential(scientific) notation
        'F f Formats the number as a decimal with specified decimal places
        'G g Formats the number as a decimal Or in scientific notation depending on which Is more compact
        'N n Formats the number with thousands separators And the specified number of decimal places
        'P p Formats the number as a percent with the specified number of decimal places


        'CUSTOM NUMERIC FORMATTING CODES
        '0 Zero placeholder
        '# Digit placeholder
        '.Decimal point
        ', Thousands separator
        '% Percentage placeholder
        '; Section separator


        'STANDARD DATE/TIME FORMATTING CODES:
        'd short date
        'D long date
        't short time
        'T long time
        'f Long date, short time
        'F Long date, long time
        'g Short date, short time
        'G short date, long time


        'd day of month without leading zero
        'dd day of month with leading zero
        'ddd abbreviated day name
        'dddd full day name
        'M month without leading zero
        'MM month with leading zero
        'MMM abbreviated month name
        'MMMM full month name
        'y two digit year without leading zero
        'yy two digit year with leading zero
        'yyyy four digit year
        '/ date separator


        'Dim thisDate As Date = DateTime.Now
        'Dim fString As String

        'fString = String.Format("{0:d}", thisDate)
        'Console.WriteLine(fString)

        'fString = String.Format("{0:D}", thisDate)
        'Console.WriteLine(fString)

        'fString = String.Format("{0:M/d/yy}", thisDate)
        'Console.WriteLine(fString)

        'fString = String.Format("{0:HH:mm:ss}", thisDate)
        'Console.WriteLine(fString)

        'Dim mySavings As Decimal = 1054D

        'fString = String.Format("I saved {0:c}", mySavings)
        'Console.WriteLine(fString)

    End Sub
End Module
