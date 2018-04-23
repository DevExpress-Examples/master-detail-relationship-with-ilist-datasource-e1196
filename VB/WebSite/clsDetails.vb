Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic

Public Class clsDetails
	Inherits List(Of clsDetail)
	Public Sub New()
		Me.Add(New clsDetail("A", "M", "Mr", "Address1"))
		Me.Add(New clsDetail("B", "M", "Dr", "Address2"))
		Me.Add(New clsDetail("C", "M", "Mr", "Address3"))
		Me.Add(New clsDetail("D", "M", "Mr", "Address4"))
		Me.Add(New clsDetail("E", "F", "Mrs","Address5"))
		Me.Add(New clsDetail("F", "M", "Dr","Address6"))
		Me.Add(New clsDetail("G", "M", "Mr","Address7"))
		Me.Add(New clsDetail("H", "F", "Ms","Address8"))
		Me.Add(New clsDetail("I", "F", "Dr","Address9"))
		Me.Add(New clsDetail("J", "M", "Mr","Address10"))
		Me.Add(New clsDetail("K", "M", "Mr", "Address11"))
	End Sub

	Public Function GetDetails(ByVal code As String) As clsDetail
		Dim det As New clsDetail("undefined","undefined","undefined","undefined")
		For i As Integer = 0 To Me.Count - 1
			Dim currentCode As String = Me(i).Code
			If currentCode = code Then
				det = Me(i)
				Exit For
			End If

		Next i
		Return det
	End Function
End Class