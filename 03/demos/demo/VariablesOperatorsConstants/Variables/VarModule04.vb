Module VarModule04
  Sub ObjectDataType()
    Dim theData As Object

    theData = "10 Speed Bike"
    Console.WriteLine(theData)

    theData = 999.99
    Console.WriteLine(theData)

    theData = DateTime.Now
    Console.WriteLine(theData)

    theData = vbEmpty
    Console.WriteLine(theData)

    theData = DBNull.Value
    Console.WriteLine(theData)
  End Sub
End Module
