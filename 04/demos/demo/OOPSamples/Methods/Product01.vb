Namespace MethodSample01
  Public Class Product
    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Sub CalculateSellEndDate(ByVal days As Integer)
      SellEndDate = SellStartDate.AddDays(days)
    End Sub
  End Class
End Namespace
