Module BuiltInModule
  Sub Sample01()
    Dim Name As String = "10 Speed Bike"

    Console.WriteLine("Built-in String Methods")
    Console.WriteLine(Name.Length)
    Console.WriteLine(Name.IndexOf(" "))
    Console.WriteLine(Name.LastIndexOf(" "))
    Console.WriteLine(Name.EndsWith("e"))
    Console.WriteLine(Name.Insert(9, "Mountain "))
    Console.WriteLine(Name.Remove(0, 9))
    Console.WriteLine(Name.Replace("10", "12"))
    Console.WriteLine(Name.ToUpper())
    Console.WriteLine(Name.ToLower())
  End Sub

  Sub Sample02()
    Dim ListPrice As Decimal = 999.99D

    Console.WriteLine("Built-in Numeric Methods")
    Console.WriteLine(ListPrice.Equals(999.99))
    Console.WriteLine(Decimal.MinValue)
    Console.WriteLine(Decimal.MaxValue)
    Console.WriteLine(Decimal.Ceiling(ListPrice))
    Console.WriteLine(Decimal.Floor(ListPrice))

    Decimal.TryParse("55.01", ListPrice)
    Console.WriteLine(ListPrice)

    Decimal.TryParse("Fifty-Five", ListPrice)
    Console.WriteLine(ListPrice)
  End Sub

  Sub Sample03()
    Dim SellDate As DateTime

    SellDate = #1/1/2019 12:05:01 PM#

    Console.WriteLine("Built-in DateTime Methods")
    Console.WriteLine(SellDate.AddDays(10))
    Console.WriteLine(SellDate.AddDays(-10))
    Console.WriteLine(SellDate.AddYears(2))
    Console.WriteLine(SellDate.AddYears(-2))

    Console.WriteLine(SellDate.Date)
    Console.WriteLine(SellDate.Day)
    Console.WriteLine(SellDate.DayOfWeek)
    Console.WriteLine(SellDate.Year)
    Console.WriteLine(SellDate.DayOfYear)

    Console.WriteLine(SellDate.Hour)
    Console.WriteLine(SellDate.Minute)
    Console.WriteLine(SellDate.Second)
  End Sub
End Module
