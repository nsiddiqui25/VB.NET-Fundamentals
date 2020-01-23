Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerManager
  Inherits DataManagerBase

  Function LoadCustomers(ByVal Optional startingFilePath As String = "") As ObservableCollection(Of Customer)
    ' Create a new instance of customers
    Dim ret = New ObservableCollection(Of Customer)()

    Try
      ' Attempt to read from XML file
      Dim doc = MyBase.LoadXElement(
        ConfigurationManager.AppSettings("CustomersFile"),
         startingFilePath)

      Dim customers = From cust In doc.<Customer>
                      Select New Customer With {
                        .CustomerID = cust.Element("CustomerID"),
                        .FirstName = cust.Element("FirstName"),
                        .LastName = cust.Element("LastName"),
                        .CompanyName = cust.Element("CompanyName")
                      }

      ret = New ObservableCollection(Of Customer)(customers.ToList())

    Catch ex As Exception
      System.Diagnostics.Debug.WriteLine(ex.ToString())
    End Try

    Return ret
  End Function

  Function LoadCustomer(ByVal customerId As Integer, ByVal Optional startingFilePath As String = "") As Customer
    ' Create a new instance of customers
    Dim ret = New Customer()

    Try
      ' Attempt to read from XML file
      Dim doc = MyBase.LoadXElement(
        ConfigurationManager.AppSettings("CustomersFile"),
         startingFilePath)

      Dim customers = From cust In doc.<Customer>
                      Where Convert.ToInt32(cust.Element("CustomerID").Value) = customerId
                      Select New Customer With {
                        .CustomerID = cust.Element("CustomerID"),
                        .FirstName = cust.Element("FirstName"),
                        .LastName = cust.Element("LastName"),
                        .CompanyName = cust.Element("CompanyName")
                      }

      Dim list = New ObservableCollection(Of Customer)(customers.ToList())
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