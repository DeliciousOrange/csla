﻿''' <summary>
''' A single-value criteria used to retrieve business
''' objects that only require one criteria value.
''' </summary>
''' <typeparam name="B">
''' Type of business object to retrieve.
''' </typeparam>
''' <typeparam name="C">
''' Type of the criteria value.
''' </typeparam>
''' <remarks></remarks>
<Serializable()> _
Public Class SingleCriteria(Of B, C)
  Inherits CriteriaBase

  Private _value As C

  ''' <summary>
  ''' Gets the criteria value provided by the caller.
  ''' </summary>
  Public ReadOnly Property Value() As C
    Get
      Return _value
    End Get
  End Property

  ''' <summary>
  ''' Creates an instance of the type,
  ''' initializing it with the criteria
  ''' value.
  ''' </summary>
  ''' <param name="value">
  ''' The criteria value.
  ''' </param>
  Public Sub New(ByVal value As C)
    MyBase.New(GetType(B))
    _value = value
  End Sub

  ''' <summary>
  ''' Creates an instance of the type.
  ''' This is for use by the MobileFormatter,
  ''' you must provide a criteria value
  ''' parameter.
  ''' </summary>
#If SILVERLIGHT Then
  Public Sub New()
  End Sub
#Else
  Protected Sub New()

  End Sub

#End If
End Class
