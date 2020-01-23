Namespace MethodSample03
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

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
      SellEndDate = SellStartDate.AddDays(days)

      Return SellEndDate
    End Function

    Function CalculateSellEndDateOldSchool(ByVal days As Integer) As DateTime
      SellEndDate = SellStartDate.AddDays(days)

      ' Assign return value to name of function
      CalculateSellEndDateOldSchool = SellEndDate
    End Function
  End Class
End Namespace
