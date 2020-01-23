﻿Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel
  Inherits ViewModelBase

  Sub New()
    LoadProducts()
  End Sub

  Public Property Products As ObservableCollection(Of Product)
  Public Property Entity As Product

  Function LoadProducts() As ObservableCollection(Of Product)
    Return LoadProducts(Nothing)
  End Function

  Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
    ' Create a new instance of the product manager class
    Dim mgr = New ProductManager

    Products = mgr.LoadProducts(startingFilePath)

    Return Products
  End Function

  Function LoadProduct(ByVal productId As Integer) As Product
    Return LoadProduct(productId, Nothing)
  End Function

  Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
    ' Create a new instance of the product manager class
    Dim mgr = New ProductManager

    Entity = mgr.LoadProduct(productId, startingFilePath)

    ' Inform UI that the Entity property changed
    RaisePropertyChanged("Entity")

    Return Entity
  End Function
End Class
