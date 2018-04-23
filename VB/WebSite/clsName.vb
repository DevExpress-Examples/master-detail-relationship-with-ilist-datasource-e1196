Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text


	Public Class clsName
		Private _Code As String = ""
		Private _FirstName As String = ""
		Private _LastName As String = ""

		Public Sub New(ByVal code As String, ByVal firstName As String, ByVal lastName As String)
			_Code = code
			_FirstName = firstName
			_LastName = lastName
		End Sub

		Public ReadOnly Property Code() As String
			Get
				Return _Code
			End Get
		End Property

		Public ReadOnly Property FirstName() As String
			Get
				Return _FirstName
			End Get
		End Property

		Public ReadOnly Property LastName() As String
			Get
				Return _LastName
			End Get
		End Property
	End Class
