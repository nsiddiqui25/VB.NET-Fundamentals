﻿Namespace PropertySample03
  Public Class Product
    Public Property IsActive As Boolean
    Public Property Name As String
    Public Property ProductNumber As String

    Public ReadOnly Property NameAndNumber() As String
      Get
        Return Name + "-" + ProductNumber
      End Get
    End Property
  End Class
End Namespace
