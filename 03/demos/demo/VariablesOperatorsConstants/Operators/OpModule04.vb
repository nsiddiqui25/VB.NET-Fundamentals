''' <summary>
''' ***************************
''' *** Order of Precedence ***
''' ***************************
''' Arithmetic (*,/, +, -)
'''   Multiplication and division in the order they occur from left to right
'''   Addition and subtraction in the order they occur from left to right
''' Comparison (less than, greater than, less than or equal to , greater than or equal to)
'''   In the order they occur from left to right
''' Logical (And, Or, Not)
'''   In this order: Not, And, Or
''' </summary>
Module OpModule04
  Sub OrderOfPrecedence01()
    Dim ListPrice As Decimal = 900D

    ' Evaluated as ListPrice + (1 * 2)
    Console.WriteLine(ListPrice + 1 * 2)
    ' Evaluated as 1 + (ListPrice * 2)
    Console.WriteLine(1 + ListPrice * 2)
    Console.WriteLine((ListPrice + 1) * 2)
  End Sub
End Module
