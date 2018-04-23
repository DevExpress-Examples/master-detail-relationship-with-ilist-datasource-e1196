Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxTabControl
Imports DevExpress.Web.ASPxEditors

Namespace WebApplication5
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Private currentDetails As New clsDetails()
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			grdNames.DataSource = New clsNames()
			grdNames.DataBind()
		End Sub

		Protected Sub grdNames_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs)
			If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Detail Then
				Dim code As String = e.GetValue("Code").ToString()
				Dim det As clsDetail = currentDetails.GetDetails(code)

				Dim cntrl As ASPxPageControl = TryCast((CType(sender, ASPxGridView)).FindDetailRowTemplateControl(e.VisibleIndex, "ASPxPageControl1"), ASPxPageControl)

				Dim genLab As ASPxLabel = TryCast(cntrl.FindControl("ASPxLabel1"), ASPxLabel)
				If genLab IsNot Nothing Then
					genLab.Text = det.Gender
				End If

				Dim courtLab As ASPxLabel = TryCast(cntrl.FindControl("ASPxLabel2"), ASPxLabel)
				If courtLab IsNot Nothing Then
					courtLab.Text = det.TitleOfCourt
				End If

				Dim addrLab As ASPxLabel = TryCast(cntrl.FindControl("ASPxLabel3"), ASPxLabel)
				If addrLab IsNot Nothing Then
					addrLab.Text = det.Address
				End If

			End If
		End Sub
	End Class
End Namespace
