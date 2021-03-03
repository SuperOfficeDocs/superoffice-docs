---
title: pb_databinding_solabel
description: Databinding with SoLabel
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Databinding with SoLabel

HTML code segment to illustrate the SoLabel from ContactMainView.ascx file.

```html
<td width="1%">
  <so2:SoLabel ID="TelephoneLabel" Caption="SR_CC_PHONE" CaptionBinding="Resources" runat="server" ContextStyle="Important">
  </so2:SoLabel>
 </td>
```

The SoLabel is identified by its `ID`.

## Caption

`Caption` is another main property of the SoLabel. For example, `SR_CC_PHONE`.

The `CaptionBinding` property is set to *resources* since the actual caption is looked up using something similar to data-binding.

In run time to get the caption of "SR\_CC\_PHONE", the dynamic DLL call *SuperOffice.Web.Globalization.resources.dll* is used. This is generated in SuperOffice by using `SuperOffice.Web.Globalization`. Several culture-specific resource files are included in this.

For example, in *ResourceStrings.en-us.resx* it sets the caption of "SR\_CC\_PHONE" to “Telephone”, the XML element below shows the convention.

```XML
<data name="SR_CC_PHONE">
    <value>Telephone:</value>
</data>
```
