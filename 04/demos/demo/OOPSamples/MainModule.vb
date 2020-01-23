Module MainModule
  Sub Main()
    BuiltInSample02()
  End Sub

#Region "Built-In Methods"
  Sub BuiltInSample01()
    BuiltInModule.Sample01()

    Console.ReadKey()
  End Sub

  Sub BuiltInSample02()
    BuiltInModule.Sample02()

    Console.ReadKey()
  End Sub

  Sub BuiltInSample03()
    BuiltInModule.Sample03()

    Console.ReadKey()
  End Sub
#End Region

#Region "Property Methods"
  Sub PropertySample01()
    Dim sample As New PropertySample()

    sample.Sample01()

    Console.ReadKey()
  End Sub

  Sub PropertySample02()
    Dim sample As New PropertySample()

    sample.Sample02()

    Console.ReadKey()
  End Sub

  Sub PropertySample03()
    Dim sample As New PropertySample()

    sample.Sample03()

    Console.ReadKey()
  End Sub
#End Region

#Region "Method Methods"
  Sub MethodSample01()
    Dim sample As New MethodSample()

    sample.Sample01()

    Console.ReadKey()
  End Sub

  Sub MethodSample02()
    Dim sample As New MethodSample()

    sample.Sample02()

    Console.ReadKey()
  End Sub

  Sub MethodSample03()
    Dim sample As New MethodSample()

    sample.Sample03()

    Console.ReadKey()
  End Sub

  Sub MethodSample04()
    Dim sample As New MethodSample()

    sample.Sample04()

    Console.ReadKey()
  End Sub

  Sub MethodSample05()
    Dim sample As New MethodSample()

    sample.Sample05()

    Console.ReadKey()
  End Sub

  Sub MethodSample06()
    Dim sample As New MethodSample()

    sample.Sample06()

    Console.ReadKey()
  End Sub

  Sub MethodSample07()
    Dim sample As New MethodSample()

    sample.Sample07()

    Console.ReadKey()
  End Sub
#End Region

#Region "Inheritance Methods"
  Sub InheritanceSample01()
    Dim sample As New InheritanceSample

    sample.Sample01()

    Console.ReadKey()
  End Sub

  Sub InheritanceSample02()
    Dim sample As New InheritanceSample

    sample.Sample02()

    Console.ReadKey()
  End Sub

  Sub InheritanceSample03()
    Dim sample As New InheritanceSample

    sample.Sample03()

    Console.ReadKey()
  End Sub
#End Region
End Module
