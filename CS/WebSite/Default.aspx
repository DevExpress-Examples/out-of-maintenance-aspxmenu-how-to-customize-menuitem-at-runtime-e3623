﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASPxMenu - How to customize MenuItem at runtime</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxMenu ID="ASPxMenu2" runat="server" EncodeHtml="false" DataSourceID="ASPxSiteMapDataSource1"
            OnItemDataBound="ASPxMenu2_ItemDataBound">
        </dx:ASPxMenu>
        <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/Web.sitemap">
        </dx:ASPxSiteMapDataSource>
    </div>
    </form>
</body>
</html>
