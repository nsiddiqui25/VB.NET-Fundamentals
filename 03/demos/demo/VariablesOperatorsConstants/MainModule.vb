Module MainModule
  Sub Main()
    OpSample05()
  End Sub

#Region "Variable Samples"
  Sub VarSample01()
    VarModule01.Sample01()
    VarModule01.Sample02()
    VarModule01.Sample03()

    Console.ReadKey()
  End Sub

  Sub VarSample02()
    VarModule02.Sample01()
    VarModule02.Sample02()
    Console.ReadKey()

    VarModule02.Sample03()
    Console.ReadKey()
  End Sub

  Sub VarSample03()
    VarModule03.IncrementListPrice()
    VarModule03.IncrementListPrice()
    VarModule03.IncrementListPrice()

    Console.ReadKey()
  End Sub

  Sub VarSample04()
    VarModule04.ObjectDataType()

    Console.ReadKey()
  End Sub

  Sub VarSample05()
    VarModule05.NumericStrings()

    Console.ReadKey()
  End Sub
#End Region

#Region "Constant Sample"
   Sub ConstantSample01()
      ConstModule01.Sample01()
   End Sub
#End Region

#Region "Operator Samples"
   Sub OpSample01()
    Console.WriteLine("Normal Math Operators")
    OpModule01.NormalMathOperators()

    Console.ReadKey()
  End Sub

  Sub OpSample02()
    Console.WriteLine("Short-Hand Math Operators")
    OpModule01.ShortHandOperators()
    Console.WriteLine("Other Math Operators")
    OpModule01.OtherOperators()

    Console.ReadKey()
  End Sub

  Sub OpSample03()
    OpModule02.RelationalOperators()

    Console.ReadKey()
  End Sub

  Sub OpSample04()
    OpModule03.LogicalOperators()

    Console.ReadKey()
  End Sub

  Sub OpSample05()
    Console.WriteLine("Order of Precedence")
    OpModule04.OrderOfPrecedence01()

    Console.ReadKey()
  End Sub
#End Region
End Module
