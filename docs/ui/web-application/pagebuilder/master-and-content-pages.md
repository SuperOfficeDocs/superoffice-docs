---
title: pb_masterpage
description: Master and content pages
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Master and content pages

## MasterPage

Defining a MasterPage is just like defining a normal page. **MasterPages** can contain markup, controls, or code, or any combination of these elements. However, they can contain a special type of control called a `ContentPlaceHolder` control. A **ContentPlaceHolder** defines a region of the master page rendering that can be substituted with content from a page that derives from the master.

**Syntax of ContentPlaceHolder:**

```XML
<div id="container" style="width:100%;height:100%;visibility:hidden">
  <asp:ContentPlaceHolder ID="WebClientPlaceHolder" Runat="server">
  </asp:ContentPlaceHolder>
</div>
```

To differentiate a MasterPage from a normal page, we use the *.master* file extension.

## ContentPage

A page can derive from a MasterPage by defining a `MasterPageFile` attribute on its `Page` directive, as demonstrated below. A page that derives from a MasterPage is called a **ContentPage**.

```html
<%@ Page Language="C#" MasterPageFile="~/Masterpages/Master.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" Title="SuperOffice CRM.web" %>
```

It can declare **Content controls** that specifically override content placeholder sections in the MasterPage. A Content control is associated to a particular ContentPlaceHolder control through its `ContentPlaceHolderID` property. A ContentPage may only contain markup and controls inside Content controls. It cannot have any top-level content of its own. It can, however, have directives or code.

```html
<%@ Page Language="C#" MasterPageFile="~/Masterpages/Master.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" Title="SuperOffice CRM.web" %>

<%@ Register TagPrefix="so2" Namespace="SuperOffice.CRM.Web.UI.Controls"  Assembly="SuperOffice.CRMWeb" %>

<asp:Content ContentPlaceHolderID="WebClientHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="WebClientPlaceHolder" Runat="Server">

<!--ClientScripts-->
<div id="scripts"></div>

<!--Initialize scripts are added here-->
<div id="InitializeScripts" visible="false"></div>

<!--Dialog Scripts are added here-->
<div id="DialogScripts" visible="false"></div>

<!-- This is the placeholder for the pagebuilder, do not remove -->
<so2:PageBuilder ID="PageContent" runat="server">

</so2:PageBuilder>

<input type="text" style="display:none" id="dummyinput" />
  TEST<!--StartupScripts-->

</asp:Content>
```

The above example demonstrates the relationship between master and content page. The MasterPage in this case defines `ContentPlaceHolder` regions, named WebClientHeadPlaceHolder and WebClientPlaceHolder, along with some default content for this region. Individual content pages in SuperOffice inherit the common site layout and look-and-feel from the MasterPage.
