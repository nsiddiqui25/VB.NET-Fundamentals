Module VarModule02
  ' Create a field
  Private Name As String = "Mountain Bike"

  Sub Sample01()
    ' Use the field
    Console.WriteLine(Name)
  End Sub

  Sub Sample02()
    ' Use a local-scoped variable to shadow field
    Dim Name As String = "10 Speed Bike"

    Console.WriteLine(Name)
  End Sub

  Sub Sample03()
    If True Then
      ' Use a block-scoped variable to shadow field
      Dim Name As String = "Tricycle"
      ' Create a block-level scoped variable
      Dim ListPrice As Decimal = 59.99D
    End If

    Console.WriteLine(Name)
    ' ListPrice is only usable within the If statement
    ' Console.WriteLine(ListPrice)
  End Sub
End Module
