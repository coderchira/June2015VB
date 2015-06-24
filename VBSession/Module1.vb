Module Module1

    Sub Main()
        'Comments
        'What is Program?
        ' Data <---> Logic
        '   Data 
        '     Variables -- Which change their value
        '       Native Type
        '           fixed size
        '           Stack(memory management)
        '           faster
        '           dispose on their own
        '       Reference Type
        '           they vary in size
        '           heap(memory management)
        '           slower
        '           dispose explicitly
        '     Constants -- Do not change value
        '       Pi etc.

        LogicDemo.Calculation(1, 25.0, "Ruchira")
        'Lifecycle of a variable
        '  Declaration
        '  Assign a value /use 
        '  Dispose

        'Declaring a variable
        'Dim ~ Dimension
        'name
        'type of variable
        Dim num As Integer '4 byte
        Dim flag As Boolean '2 byte
        Dim precision As Single ' 4 byte '7 digits
        Dim precisionDouble As Double ' 8 byte ' 15-16 digits
        Dim accuracy As Decimal '16 bytes
        Dim name As String ' depending on the value

        num = 10
        flag = True
        precision = 1.010101
        precisionDouble = 1.2535212
        accuracy = 12.5
        name = "Ruchira"

        'Print values
        Console.WriteLine("The value of num is: " & num)
        Console.WriteLine("The value of flag is: " & flag)
        Console.WriteLine("The value of precision is: " & precision)
        Console.ReadLine()

        'Integer operations
        Dim leftNum As Integer
        Dim rightNum As Integer
        Dim addNum As Integer
        Dim subtNum As Integer
        Dim prodNum As Integer
        Dim remainder As Integer
        Dim quotient As Integer

        leftNum = 20
        rightNum = 30
        addNum = leftNum + rightNum
        subtNum = rightNum - leftNum
        prodNum = leftNum * rightNum
        quotient = Math.DivRem(rightNum, leftNum, remainder)
        Console.WriteLine("The value of the quotient is " & quotient)
        Console.ReadLine()
        'Control + K + C comment the complete selection
        'Console.WriteLine("The value of addNum is: " & addNum)
        'Console.WriteLine("The value of subtNum is: " & subtNum)
        'Console.WriteLine("The value of prodNum is:" & prodNum)

        'string operations
        Dim message1 As String
        Dim message2 As String
        message1 = "This is VB SESSION day 1"
        message2 = " and we are confident of learning in the SESSION !"

        'Concatenate two strings
        Dim resultMsg As String
        resultMsg = message1 & message2 'this is safest
        'resultMsg = message1 + message2 'might give unexpected results sometimes
        Console.WriteLine(resultMsg)

        'Left/right portion of the string
        Dim leftPortion As String
        Dim rightPortion As String
        leftPortion = Left(resultMsg, 10)
        rightPortion = Right(resultMsg, 20)
        Console.WriteLine(leftPortion)
        Console.WriteLine(rightPortion)
        Console.ReadLine()

        'position /Instr
        Dim position As Integer
        Dim position2 As Integer
        position = InStr(resultMsg.ToLower, "session")
        position2 = InStr(position + 1, resultMsg.ToLower, "session")
        Console.WriteLine("The position of 'session' word is: " & position)
        Console.WriteLine("The position of second occurence of 'session' word is: " & position2)
        Console.ReadLine()

        'Conversion of data types
        Dim newNum As Integer
        newNum = 20
        Dim newNumAsString As String
        newNumAsString = newNum.ToString()
        newNumAsString = CStr(newNum)

        Dim str As String
        Dim strAsNum As Integer
        str = "20"
        strAsNum = CInt(str)

        'reference type variable
        Dim coll As New Collection 'no. of different items
        'it can hold native type variable
        coll.Add("Ruchira") ' 1th position
        coll.Add(20)    '2nd position and so on
        coll.Add(True)
        coll.Add("Day 2")
        Console.WriteLine("The items in collection are {0}, {1},{2},{3}", coll.Item(1), coll.Item(2), coll.Item(3), coll.Item(4))
        Console.ReadLine()

        coll.Remove(2)
        Console.WriteLine("The items in collection are {0}, {1},{2}", coll.Item(1), coll.Item(2), coll.Item(3))
        Console.ReadLine()
    End Sub

End Module
