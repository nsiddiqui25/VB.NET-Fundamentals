Module ConstModule02
  Sub Sample01()
    Dim isActive As Boolean = ModuleConstants.DEFAULT_ACTIVE
    Dim Name As String
    Dim ListPrice As Decimal

    Name = "10 Speed Bike"
    ' Don't need to prefix with module name
    ListPrice = DEFAULT_LIST_PRICE
  End Sub
End Module
