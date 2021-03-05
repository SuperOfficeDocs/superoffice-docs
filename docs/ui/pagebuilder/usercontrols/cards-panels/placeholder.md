---
title: pb_usercontrols_placeholder
description: UserControls - PlaceHolder
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# PlaceHolder

The **PlaceHolder** control is used to reserve space for controls added by code.

> [!NOTE]
> The PlaceHolder control **does not produce any visible output!** It only acts as a container for other controls on the webpage.

## Example MiniNotepadView.ascx file

The *MiniNotepadView.ascx* file shows the NotePad minicard on the left side

```XML
<%@ control language="C#" autoeventwireup="true" inherits="WebParts_MiniCards_MiniNotepadView, SoSixWeb" %>
<%@ Register TagPrefix="so2" Namespace="SuperOffice.CRM.Web.UI.Controls" Assembly="SuperOffice.CRMWeb" %>
<asp:PlaceHolder ID="notepadPlaceholder" runat="server" />
<div runat="server" id="buttonwrapper" style="position:absolute;bottom:0px;">
  <asp:HyperLink ID="prev" runat="server"><</asp:HyperLink>
  <asp:PlaceHolder ID="infoPlaceholder" runat="server" />
  <asp:HyperLink ID="next" runat="server">>sp:HyperLink>
</div>
```

Two placeholders are used in the above code and their IDs are *notepadPlaceholder*  and *infoPlaceholder*.

![03][img1]

Controls are dynamically added to the above placeholders in the coding of the *MiniNotepadView.ascx.cs* file.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image003.jpg
