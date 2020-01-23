Namespace MethodSample07
  Public Class Product
    Sub New()
      StandardCost = 500
      ListPrice = 900
      SellStartDate = DateTime.Now
    End Sub

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

    Shared Function CalculateProfit(ByVal cost As Decimal, ByVal price As Decimal) As Decimal
      Return price - cost
    End Function
  End Class
End Namespace
