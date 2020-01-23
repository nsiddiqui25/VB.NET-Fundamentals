Module VarModule03
  Sub IncrementListPrice()
    Static ListPrice As Decimal = 0D

    ListPrice = ListPrice + 1

    Console.WriteLine(ListPrice)
  End Sub
End Module
