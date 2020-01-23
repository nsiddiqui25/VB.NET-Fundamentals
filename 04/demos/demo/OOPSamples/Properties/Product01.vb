Namespace PropertySample01
  Public Class Product
    Private _IsActive As Boolean
    Private _Name As String
    Private _ProductNumber As String

    Public Property IsActive() As Boolean
      Get
        Return _IsActive
      End Get
      Set(ByVal value As Boolean)
        _IsActive = value
      End Set
    End Property

    Public Property Name() As String
      Get
        Return _Name
      End Get
      Set(ByVal value As String)
        _Name = value
      End Set
    End Property

    Public Property ProductNumber() As String
      Get
        Return _ProductNumber
      End Get
      Set(ByVal value As String)
        _ProductNumber = value
      End Set
    End Property
  End Class
End Namespace
