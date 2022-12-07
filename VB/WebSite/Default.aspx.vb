Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web


Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxMenu2_ItemDataBound(ByVal source As Object, ByVal e As DevExpress.Web.MenuItemEventArgs)
		Dim node As SiteMapNode = TryCast(e.Item.DataItem, SiteMapNode)
		If node IsNot Nothing Then
			e.Item.Text = "<div><b>" & e.Item.Text & "</b> <br />" & node("description") & "</div>" ' or some another tags like <a href=''>
			e.Item.NavigateUrl = node("url")
		End If
	End Sub
End Class
