Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductManager
  Inherits DataManagerBase

  Function LoadProducts(ByVal Optional startingFilePath As String = "") As ObservableCollection(Of Product)
    ' Create a new instance of products
    Dim ret = New ObservableCollection(Of Product)()
    Dim sb As New System.Text.StringBuilder(1024)

    Try
      ' Attempt to read from XML file
      Dim doc = MyBase.LoadXElement(
          ConfigurationManager.AppSettings("ProductsFile"),
          startingFilePath)

      Dim products = From prod In doc.<Product>
                     Select New Product With {
                       .ProductID = prod.Element("ProductID"),
                       .Name = prod.Element("Name"),
                       .ProductNumber = prod.Element("ProductNumber"),
                       .Color = prod.Element("Color"),
                       .Size = prod.Element("Size"),
                       .Weight = prod.Element("Weight"),
                       .StandardCost = prod.Element("StandardCost"),
                       .ListPrice = prod.Element("ListPrice"),
                       .SellStartDate = prod.Element("SellStartDate"),
                       .SellEndDate = prod.Element("SellEndDate")
                     }

      ret = New ObservableCollection(Of Product)(products.ToList())

    Catch ex As Exception
      System.Diagnostics.Debug.WriteLine(ex.ToString())
    End Try

    Return ret
  End Function

  Function LoadProduct(ByVal productId As Integer, ByVal Optional startingFilePath As String = "") As Product
    ' Create a new instance of products
    Dim ret = New Product()
    Dim sb As New System.Text.StringBuilder(1024)

    Try
      ' Attempt to read from XML file
      Dim doc = MyBase.LoadXElement(
          ConfigurationManager.AppSettings("ProductsFile"),
          startingFilePath)

      Dim products = From prod In doc.<Product>
                     Where Convert.ToInt32(prod.Element("ProductID").Value) = productId
                     Select New Product With {
                       .ProductID = prod.Element("ProductID"),
                       .Name = prod.Element("Name"),
                       .ProductNumber = prod.Element("ProductNumber"),
                       .Color = prod.Element("Color"),
                       .Size = prod.Element("Size"),
                       .Weight = prod.Element("Weight"),
                       .StandardCost = prod.Element("StandardCost"),
                       .ListPrice = prod.Element("ListPrice"),
                       .SellStartDate = prod.Element("SellStartDate"),
                       .SellEndDate = prod.Element("SellEndDate")
                     }

      Dim list = New ObservableCollection(Of Product)(products.ToList())
      If list IsNot Nothing Then
        If list.Count > 0 Then
          ret = list(0)
        End If
      End If

    Catch ex As Exception
      System.Diagnostics.Debug.WriteLine(ex.ToString())
    End Try

    Return ret
  End Function
End Class