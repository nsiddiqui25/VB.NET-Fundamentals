Module ConstModule03
  Sub Sample01()
    Dim isActive As Boolean = ClassConstants.DEFAULT_ACTIVE
    Dim Name As String
    Dim ListPrice As Decimal

    Name = "10 Speed Bike"
    ' Must use the class name
    ListPrice = ClassConstants.DEFAULT_LIST_PRICE
  End Sub
End Module
