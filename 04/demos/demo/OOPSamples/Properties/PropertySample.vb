Public Class PropertySample
  Sub Sample01()
    Dim prod As New PropertySample01.Product

    prod.IsActive = True
    prod.Name = "10 Speed Bike"
    prod.ProductNumber = "10-SP"

    Console.WriteLine(prod.ProductNumber)
  End Sub

  Sub Sample02()
    Dim prod As New PropertySample02.Product

    prod.IsActive = True
    prod.Name = "10 Speed Bike"
    prod.ProductNumber = "10-SP"

    Console.WriteLine(prod.ProductNumber)
  End Sub

  Sub Sample03()
    Dim prod As New PropertySample03.Product

    prod.IsActive = True
    prod.Name = "10 Speed Bike"
    prod.ProductNumber = "10-SP"

    Console.WriteLine(prod.NameAndNumber)
  End Sub
End Class
