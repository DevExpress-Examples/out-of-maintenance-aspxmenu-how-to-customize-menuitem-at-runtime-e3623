using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web;


public partial class _Default : System.Web.UI.Page {
    protected void Page_Load (object sender, EventArgs e) {

    }
    protected void ASPxMenu2_ItemDataBound (object source, DevExpress.Web.MenuItemEventArgs e) {
        SiteMapNode node = e.Item.DataItem as SiteMapNode;
        if (node != null) {
            e.Item.Text = "<div><b>" + e.Item.Text + "</b> <br />" + node["description"] + "</div>"; // or some another tags like <a href=''>
            e.Item.NavigateUrl = node["url"];
        }
    }
}
