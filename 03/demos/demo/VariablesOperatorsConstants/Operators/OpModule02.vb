Module OpModule02
  Sub RelationalOperators()
    Dim ListPrice As Decimal = 999.99D

    ' Less than, less than or equal to
    Console.WriteLine("Less than, less than or equal to")
    Console.WriteLine(ListPrice < 900)
    Console.WriteLine(ListPrice <= 999.99)

    ' Greater than, greater than or equal to
    Console.WriteLine("greater than, greater than or equal to")
    Console.WriteLine(ListPrice > 1000)
    Console.WriteLine(ListPrice >= 999.99)

    ' Equal to, not equal to
    Console.WriteLine("equal to, not equal to")
    Console.WriteLine(ListPrice = 1000)
    Console.WriteLine(ListPrice <> 1000)
  End Sub
End Module
