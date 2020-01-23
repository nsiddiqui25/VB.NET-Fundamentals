Public Class DataManagerBase
  Public Function LoadXElement(ByVal partialFileName As String, ByVal Optional startingFileName As String = "") As XElement
    Dim path = IIf(String.IsNullOrEmpty(startingFileName), Environment.CurrentDirectory, startingFileName)
    Dim doc As XElement

    path += partialFileName
    path = path.Replace("bin\Debug\", "")

    doc = XElement.Load(path)

    Return doc
  End Function
End Class
