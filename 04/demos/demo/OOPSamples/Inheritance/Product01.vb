Imports System.Text

Namespace InheritanceSample01
  Public Class Product
    Inherits CommonBase

    Sub New()
      MyBase.New()

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

    Function GetClassData() As String
      Dim sb As New StringBuilder(1024)

      sb.AppendLine("ID: " + ProductID.ToString())
      sb.AppendLine("Name: " + Name)
      sb.AppendLine("Number: " + ProductNumber)
      sb.AppendLine("Is Active: " + IsActive.ToString())
      sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
      sb.AppendLine("Created By: " + CreatedBy)

      Return sb.ToString()
    End Function
  End Class
End Namespace
