﻿Imports System.ComponentModel
Imports System.Text

Public Class CommonBase
  Implements INotifyPropertyChanged

  Sub New()
    IsActive = True
    ModifiedDate = DateTime.Now
    CreatedBy = Environment.UserName
  End Sub

  Public Property IsActive As Boolean
  Public Property ModifiedDate As DateTime
  Public Property CreatedBy As String

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Sub RaisePropertyChanged(ByVal propertyName As String)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Public Overrides Function ToString() As String
    Return GetClassData()
  End Function

  Protected Overridable Function GetClassData() As String
    Dim sb As New StringBuilder(1024)

    sb.AppendLine("Is Active: " + IsActive.ToString())
    sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
    sb.AppendLine("Created By: " + CreatedBy)

    Return sb.ToString()
  End Function
End Class