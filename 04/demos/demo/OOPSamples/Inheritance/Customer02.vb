﻿Imports System.Text

Namespace InheritanceSample02
  Public Class Customer
    Inherits CommonBase

    Sub New()
      MyBase.New()

      CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Overrides Function GetClassData() As String
      Dim sb As New StringBuilder(1024)

      sb.AppendLine("Customer ID: " + CustomerID.ToString())
      sb.AppendLine("Company Name: " + CompanyName)
      sb.AppendLine("First Name: " + FirstName)
      sb.AppendLine("Last Name: " + LastName)
      sb.Append(MyBase.GetClassData())

      Return sb.ToString()
    End Function
  End Class
End Namespace
