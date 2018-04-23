Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Public Class clsNames
	Inherits List(Of clsName)
	Public Sub New()
		Me.Add(New clsName("A", "Arnold", "Apple"))
		Me.Add(New clsName("B", "Barney", "Bagle"))
		Me.Add(New clsName("C", "Charlie", "Chipman"))
		Me.Add(New clsName("D", "Doug", "Doggle"))
		Me.Add(New clsName("E", "Elizabeth", "Einstein"))
		Me.Add(New clsName("F", "Frank", "Flanery"))
		Me.Add(New clsName("G", "Gilbert", "Guzman"))
		Me.Add(New clsName("H", "Hillary", "Harvey"))
		Me.Add(New clsName("I", "Isadora", "Ingleman"))
		Me.Add(New clsName("J", "Jacob", "James"))
		Me.Add(New clsName("K", "Kevin", "Krantz"))
	End Sub
End Class
