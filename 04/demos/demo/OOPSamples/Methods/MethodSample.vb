Public Class MethodSample
  Sub Sample01()
    Dim prod As New MethodSample01.Product

    prod.SellStartDate = #1/1/2019#
    prod.CalculateSellEndDate(20)

    Console.Write(prod.SellEndDate)
  End Sub

  Sub Sample02()
    Dim prod As New MethodSample02.Product
    Dim sellDate As DateTime

    prod.SellStartDate = #1/1/2019#
    ' Pass sellDate by reference
    prod.CalculateSellEndDate(30, sellDate)

    Console.Write(sellDate)
  End Sub

  Sub Sample03()
    Dim prod As New MethodSample03.Product

    prod.ListPrice = 900
    prod.StandardCost = 500

    Console.WriteLine(prod.CalculateSellEndDate(30))
    Console.WriteLine(prod.CalculateSellEndDateOldSchool(20))
  End Sub

  Sub Sample04()
    Dim prod As New MethodSample04.Product

    prod.ListPrice = 900
    prod.StandardCost = 500

    Console.WriteLine(prod.CalculateProfit())
    Console.WriteLine(prod.CalculateProfit(700))
  End Sub

  Sub Sample05()
    Dim prod As New MethodSample05.Product

    prod.ListPrice = 1400
    prod.StandardCost = 500

    Console.WriteLine(prod.CalculateProfit())
    Console.WriteLine(prod.CalculateProfit(700))
  End Sub

  Sub Sample06()
    Dim prod As New MethodSample06.Product

    Console.WriteLine(prod.CalculateProfit())
  End Sub

  Sub Sample07()
    Console.WriteLine(MethodSample07.Product.CalculateProfit(900, 1400))
  End Sub
End Class