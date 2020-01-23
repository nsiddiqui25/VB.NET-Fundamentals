Imports System.Net
Imports System.Web.Http
Imports AdventureWorks.EntityLayer
Imports AdventureWorks.ViewModelLayer

Public Class CustomersController
  Inherits ApiController

  ' GET api/values
  Public Function GetCustomers() As List(Of Customer)
    Dim vm As New CustomerViewModel()

    vm.LoadCustomers(HttpContext.Current.Server.MapPath("/"))

    Return vm.Customers.ToList()
  End Function
End Class
