Module OpModule03
  Sub LogicalOperators()
    Dim ListPrice As Decimal = 999.99D
    Dim isActive As Boolean = True

    ' And
    Console.WriteLine("And operator")
    Console.WriteLine(ListPrice < 900 And ListPrice <= 999.99)

    ' Or
    Console.WriteLine("Or operator")
    Console.WriteLine(ListPrice > 1000 Or ListPrice >= 999.99)

    ' Not
    Console.WriteLine("Not operator")
    Console.WriteLine(Not isActive)
  End Sub
End Module
