<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication5._Default" %>

<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxTabControl"
	TagPrefix="dxtc" %>
<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxClasses"
	TagPrefix="dxw" %>

<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxGridView"
	TagPrefix="dxwgv" %>
<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxEditors"
	TagPrefix="dxe" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		&nbsp;</div>
		<dxwgv:ASPxGridView ID="grdNames" runat="server" AutoGenerateColumns="False" Width="271px" KeyFieldName="Code" OnHtmlRowCreated="grdNames_HtmlRowCreated">
			<Columns>
				<dxwgv:GridViewDataTextColumn Caption="Code" FieldName="Code" VisibleIndex="0">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn Caption="First Name" FieldName="FirstName" VisibleIndex="1">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn Caption="Last Name" FieldName="LastName" VisibleIndex="2">
				</dxwgv:GridViewDataTextColumn>
			</Columns>
			<SettingsPager PageSize="5">
			</SettingsPager>
			<templates>
				<detailrow>
					<dxtc:aspxpagecontrol ID="ASPxPageControl1" runat="server" ActiveTabIndex="0">
						<tabpages>
							<dxtc:tabpage Text="Details">
								<contentcollection>
									<dxw:contentcontrol runat="server">
									  <table>
										<tr>
										  <td><b>Gender:</b></td>
										  <td>
											  <dxe:aspxlabel ID="ASPxLabel1" runat="server" Text="ASPxLabel">
											  </dxe:aspxlabel>
										  </td>
										</tr>
										<tr>
										  <td>
											<b>Title of courtesy:</b>
										  </td>
										  <td>
											  <dxe:aspxlabel ID="ASPxLabel2" runat="server" Text="ASPxLabel">
											  </dxe:aspxlabel>
										  </td>
										</tr>
										<tr>
										  <td>
											<b>Address:</b>
										  </td>
										 <td>
											 <dxe:aspxlabel ID="ASPxLabel3" runat="server" Text="ASPxLabel">
											 </dxe:aspxlabel>
										 </td>
										</tr>
									  </table>
									</dxw:contentcontrol>
								</contentcollection>
							</dxtc:tabpage>
						</tabpages>
					</dxtc:aspxpagecontrol>
				</detailrow>
			</templates>
			<settingsdetail ShowDetailRow="True" />
		</dxwgv:ASPxGridView>
		&nbsp;<br />
	</form>
</body>
</html>