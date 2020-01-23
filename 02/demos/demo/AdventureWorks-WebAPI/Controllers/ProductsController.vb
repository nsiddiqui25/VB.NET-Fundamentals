Imports System.Web.Http
Imports AdventureWorks.EntityLayer
Imports AdventureWorks.ViewModelLayer

Public Class ProductsController
  Inherits ApiController

  ' GET api/values
  Public Function GetProducts() As List(Of Product)
    Dim vm As New ProductViewModel()

    vm.LoadProducts(HttpContext.Current.Server.MapPath("/"))

    Return vm.Products.ToList()
  End Function
End Class
