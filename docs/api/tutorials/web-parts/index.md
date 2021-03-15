---
title: web_parts       
description: SuperOffice NetServer services and web parts in ASP.Net 2.0
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
---

# Web parts in ASP.net 2.0

The main purpose of using web parts (aka web widgets) is to develop a website that can be customized during runtime. It provides us with the option to drag and drop objects on a page, change titles, border style, and properties of objects at runtime.

> [!NOTE]
> Web parts are available in the SharePoint portal server as well as in ASP.net 2.0. Here, we focus only on the ones in ASP.Net 2.0.

There are 2 basic concepts in web-parts:

* Web-part manager – Acts as the manager of all the web parts behind the scenes.
* Web-part zones – Areas of the page that can contain the content.

## Web-part manager

The Web-part manager can behave in 5 different modes:

| Mode | Description |
|---|---|
| Browse display | The default mode. You can only minimize or close the web parts. Closing a web-part in browse mode will permanently remove it from the web page. To restore it, you need to be in Catalog mode. |
| Design display | You can drag and drop web parts between different zones. |
| Catalog display | You can add and remove web parts on runtime. |
| Edit display | You can edit web parts (appearance, behavior, property, and layout) on runtime. |
| Connect display | Allows web parts to communicate with each other. |

## Web-part zones

There are 4 different types of web-part zones:

* Web-part zone
* Editor zone
* Catalog zone
* Connection zone

Each of these zones makes the web-part manager behave in one of its 5 different modes. Zones are displayed like this:

![01][img1]

We can add web-part manager and any of the web-part zones to your application simply by dragging them from the WebParts section in your Toolbox.

> [!NOTE]
> You need to have Internet Explorer 5 or later version to observe all the above features of web parts.

## Build an ASP.Net 2.0 web part that uses the NetServer service API

We provide a tutorial detailing how everything in the services API fits into one application. In our example, we will set the web-part manager to the **catalog display mode** and use the web-part zone and catalog zone. It has 2 steps:

1. [Authenticate the user][1] (build log-in page)
2. [Display open sales for the user][2] (build Sales page)

<!-- Referenced links -->
[1]: authenticate-user.md
[2]: display-open-sales-for-user.md

<!-- Referenced images -->
[img1]: media/image001.jpg
