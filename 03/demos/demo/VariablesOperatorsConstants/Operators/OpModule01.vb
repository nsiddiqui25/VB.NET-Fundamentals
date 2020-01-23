Module OpModule01
  Sub NormalMathOperators()
    Dim ListPrice As Decimal = 999.99D

    ListPrice = ListPrice + 200
    Console.WriteLine(ListPrice)

    ListPrice = ListPrice - 100
    Console.WriteLine(ListPrice)

    ListPrice = ListPrice * 2
    Console.WriteLine(ListPrice)

    ListPrice = ListPrice / 3
    Console.WriteLine(ListPrice)
  End Sub

  Sub ShortHandOperators()
    Dim ListPrice As Decimal = 999.99D

    ListPrice += 1
    Console.WriteLine(ListPrice)

    ListPrice -= 1
    Console.WriteLine(ListPrice)

    ListPrice *= 2
    Console.WriteLine(ListPrice)

    ListPrice /= 2
    Console.WriteLine(ListPrice)
  End Sub

  Sub OtherOperators()
    Dim ListPrice As Decimal = 999.99D
    Dim result As Double

    ' Integer Division
    Console.WriteLine(5 \ 2)

    ' Modulus
    ListPrice = ListPrice Mod 2
    Console.WriteLine(ListPrice)

    ' Exponentiation
    result = ListPrice ^ 2
    Console.WriteLine(result)
  End Sub
End Module
