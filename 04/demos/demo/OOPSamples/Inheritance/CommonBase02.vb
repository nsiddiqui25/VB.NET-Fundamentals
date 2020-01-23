﻿Imports System.Text

Namespace InheritanceSample02
  Public Class CommonBase
    Sub New()
      IsActive = True
      ModifiedDate = DateTime.Now
      CreatedBy = Environment.UserName
    End Sub

    Public Property IsActive As Boolean
    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String

    Overridable Function GetClassData() As String
      Dim sb As New StringBuilder(1024)

      sb.AppendLine("Is Active: " + IsActive.ToString())
      sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
      sb.AppendLine("Created By: " + CreatedBy)

      Return sb.ToString()
    End Function
  End Class
End Namespace