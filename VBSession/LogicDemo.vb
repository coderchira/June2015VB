Module LogicDemo
    'Logic
    '   Functions
    '       Return a value
    '   Subroutines
    '       Do not return a value

    'Lifecycle of the logic block
    '   Declare
    '       use keyword function 
    '       Name
    '       return type
    '   Implement / Body
    '       use data here / form logic
    '   Call
    '       from other block

    'Module level variable
    Dim myVar As Integer = 10

    'Declare a function
    Function FirstFunction() As Integer
        'Implementation
        'Local variable
        Dim myNum As Integer = 20


        myVar = 15
        Return 0
    End Function

    Function DoThis() As Boolean
        'Body
        'Call
        DoThisAll()
        myVar = 30
        Return True
    End Function

    Sub DoThisAll()
        'Body
        'Call
        Dim flag As Boolean = DoThis(12, 20.0, "Ruchira")
        Dim rtr As Integer = Calculation(15, 25.0, "Infy")
    End Sub

    'Parametreized Function with the same name as defined earlier
    'Signature
    '   Name
    '   No. of input parameters
    '   Sequence of parameters
    '   Type of parameters
    '   Return Type
    'Function overloading
    Function DoThis(num As Integer, weight As Single, name As String) As Integer
        'body

        'Dim number As Integer
        'number = 30
        Return num
    End Function

    Function Calculation(num As Integer, age As Single, name As String) As Integer
        'Implementation
        ' Conditional Statements
        If num > 10 Then
            'Do something
            Console.WriteLine("Value of the number is " & num)
        ElseIf num = 10 Then
            'Do something else
            Console.WriteLine("Value is now eual to 10")
        Else
            Console.WriteLine("Do something else if above conditions fails")
        End If

        'Nested ifs
        If name = "Ruchira" Then
            If num > 10 Then
                'Do something
                Console.WriteLine("Value of the number is " & num)
            ElseIf num = 10 Then
                'Do something else
                Console.WriteLine("Value is now eual to 10")
            Else
                Console.WriteLine("Do something else if above conditions fails")
            End If
        End If

        Dim val As Integer
        val = 15
        Select Case val
            Case 10
                'Do Something
                Console.WriteLine("No age is too young to learn coding!")
            Case val = 15
                Console.WriteLine("No age is old enough to learn more!")
            Case 20
                Console.WriteLine("Agse is 20")
            Case 13, 14, 16
                Console.WriteLine("Not applicable")
            Case Else
                Console.WriteLine("We are inside Else of select")
        End Select

        'iterations
        'loops
        For count = 1 To 5
            Console.WriteLine(count)
        Next

        For index = 1 To 10 Step 2
            Console.WriteLine(index)
        Next

        For counter = 10 To 1 Step -1
            Console.WriteLine(counter)
        Next
        Console.ReadLine()

        'While
        While age = 20
            'Do something
            Console.WriteLine(age)
            age = age + 1
        End While

        age = 25
        'Do While Loop
        Do
            Console.WriteLine("This will be run at least once")
        Loop While age = 20

        'for each
        Dim coll As New Collection
        For index = 1 To 5
            coll.Add(index)
        Next

        For Each item In coll
            Console.WriteLine(item)
        Next
        Return 0
    End Function

End Module
