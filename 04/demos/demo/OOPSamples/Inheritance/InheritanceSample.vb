Public Class InheritanceSample
  Sub Sample01()
    ' Product Object
    Dim prod As New InheritanceSample01.Product With {
         .ProductID = 1,
         .Name = "10 Speed Bike",
         .ProductNumber = "10-SP"
      }
    Console.Write(prod.GetClassData())
    Console.WriteLine("")

    ' Company Object
    Dim cust As New InheritanceSample01.Customer With {
         .CustomerID = 999,
         .CompanyName = "A Bike Store",
         .FirstName = "Bruce",
         .LastName = "Jones"
      }
    Console.Write(cust.GetClassData())
  End Sub

  Sub Sample02()
    ' Product Object
    Dim prod As New InheritanceSample02.Product With {
       .ProductID = 1,
       .Name = "10 Speed Bike",
       .ProductNumber = "10-SP"
    }
    Console.Write(prod.GetClassData())
    Console.WriteLine("")

    ' Company Object
    Dim cust As New InheritanceSample02.Customer With {
       .CustomerID = 999,
       .CompanyName = "A Bike Store",
       .FirstName = "Bruce",
       .LastName = "Jones"
    }
    Console.Write(cust.GetClassData())
  End Sub

  Sub Sample03()
    ' Product Object
    Dim prod As New InheritanceSample03.Product With {
       .ProductID = 1,
       .Name = "10 Speed Bike",
       .ProductNumber = "10-SP"
    }
    Console.Write(prod.ToString())
    Console.WriteLine("")

    ' Company Object
    Dim cust As New InheritanceSample03.Customer With {
       .CustomerID = 999,
       .CompanyName = "A Bike Store",
       .FirstName = "Bruce",
       .LastName = "Jones"
    }
    Console.Write(cust.ToString())
  End Sub
End Class
