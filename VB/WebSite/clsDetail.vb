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

''' <summary>
''' Summary description for clsDetail
''' </summary>
Public Class clsDetail
	Private _code As String = ""
	Private _gender As String = ""
	Private _titleOfCourt As String = ""
	Private _address As String = ""

	Public Sub New(ByVal code As String, ByVal gender As String, ByVal titleOfCourt As String, ByVal address As String)
		_code = code
		_gender = gender
		_titleOfCourt = titleOfCourt
		_address = address
	End Sub

	Public ReadOnly Property Code() As String
		Get
			Return _code
		End Get
	End Property

	Public ReadOnly Property Gender() As String
		Get
			Return _gender
		End Get
	End Property

	Public ReadOnly Property TitleOfCourt() As String
		Get
			Return _titleOfCourt
		End Get
	End Property
	Public ReadOnly Property Address() As String
		Get
			Return _address
		End Get
	End Property
End Class
