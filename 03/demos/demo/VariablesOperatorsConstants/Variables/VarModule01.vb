Module VarModule01
  Sub Sample01()
    Dim ProductID As Integer
    Dim isActive As Boolean
    Dim Name As String
    Dim ListPrice As Decimal
    Dim SellStartDate As DateTime

    ProductID = 1
    isActive = True
    Name = "10 Speed Bike"
    ListPrice = 999.99D
    SellStartDate = #1/1/2019#
  End Sub

  Sub Sample02()
    Dim ProductID As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed Bike"
    Dim ListPrice As Decimal = 999.99D
    Dim SellStartDate As DateTime = #1/1/2019#
  End Sub

  Sub Sample03()
    Dim Name, ProductNumber As String

    Name = "10 Speed Bike"
    ProductNumber = "10-SP"
  End Sub

End Module
