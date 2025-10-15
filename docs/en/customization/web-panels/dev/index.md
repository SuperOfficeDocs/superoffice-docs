---
uid: web-panels-dev
title: Building web panels
description: How to build and develop web panels with links and template variables
keywords: web panel, target, pass data
author: digitaldiina
date: 10.14.2025
version: 11.5
content_type: howto
audience: api
audience_tooltip: Consultants and developers
category: customization
topic: web panel
language: en
redirect_from:
  - /en/ui/web-panels/create-link-to
  - /en/ui/web-panels/passing-data
  - /en/ui/web-panels/detect-superoffice
---

# Building web panels

> [!NOTE]
> After adding a web panel it is good practice to [flush caches][7] in the application.

## Link to a web panel

You can **add a link** in your web panel that will load another panel when pressed.

The HTML `<a>` tag has multiple attributes. In addition to the **href** attribute, we can set the **target** attribute to specify *where* to open the link.

Syntax:

```html
<a target="_blank|_self|_parent|_top|framename">
```

* To open a link in a new browser window, set `target="_blank`
* To open a link **in your panel**, set `target=<window name>`

For example, `target="project.pdetails"` with link text *Show project info*.

## <a id="variables"></a>Pass data with template variables

You can use template variables to pass data to the destination page to tailor it to the client context. This could be information about the current contact, person, or project.

For example, instead of `http://www.search.com/search?q=SuperOffice`, we can use the template variable for *company name* - which is `<name>` - and type `http://www.search.com/search?q=<name>`

### Steps

1. Append the template variables to the URL when editing the [web panel properties][1].
    * Type the URL without padding (no extra spaces). SuperOffice handles the [URL encoding][2].
    * Separate the parameters with an ampersand `&`.

1. Write the code of the target webpage so that it does something useful with the template variables.

### Available variables

* [For CRM][4]
* [For Service][5]

### Hidden variables

You can also pass template variables as **hidden variables** in your [custom screens][6]. And then do something like this in the suitable load or creation script:

```crmscript
User u;
u.load(getVariable("activeUser").toInteger());
```

<!-- Referenced links -->
[1]: ../admin/add-web-panel.md#fields
[2]: ../admin/url-encoding.md
[4]: ../../../document/templates/index.md
[5]: ../../../knowledge-base/learn/reply-templates/template-variables.md
[6]: ../../../ui/blogic/custom-screens/index.md
[7]: ../../../api/caching/flush-cache.md

<!-- Referenced images -->