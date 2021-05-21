---
title: Web GUI .Net API
uid: web_application
description: Web GUI .Net API
author: {github-id}
so.date:
keywords:
so.topic: generic
so.client: web
so.envir: onsite
---

# Expander SDK: Web GUI .Net API

The client is built using the **NetServer Services API layer**, which enables the web server to be run on a separate server from the business logic implemented in the web services. It also uses the **Dynamic Client Foundation** (DCF) on top of the web services to handle globalization and to define the page builder infrastructure.

After you have installed the SuperOffice web application, you will see that the application is an **ASP.NET web application** with standard elements like *App\_Data*, *App\_Themes*, and *web.config*.

## Components

The major components in the GUI are:

* The [page builder framework][4] used in CRM.web. This means the config files for the framework and the many components and interfaces that the **PageBuilder** uses.
* The [page, panel, card, and archive components][5] used to render the pages.
* The [AJAX libraries][6] that integrate the web front end with the web server.

## Background

* [Strategic goals][7]
* [Technical info][8]

## Customization

The SuperOffice Web client can be customized in many different ways. It is built using a reusable set of components and can be extended with new components and configured to use custom components.

The [SuperOffice Web Client NuGet package][1] adds the needed assemblies to extend the web client. This will also install the SuperOffice [web services package][2] and [Core package][3].
When creating your own controls and assemblies to be used by the application, you should also use the Service layer for all your Create, Read, Update, and Delete (CRUD) operations.

[Learn more][9]

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.Crm.Web/
[2]: https://www.nuget.org/packages/SuperOffice.NetServer.Services/
[3]: https://www.nuget.org/packages/SuperOffice.NetServer.Core/
[4]: pagebuilder/index.md
[5]: pagebuilder/config/index.md
[6]: custom-ajax-methods.md
[7]: strategic-goals.md
[8]: technical-info.md
[9]: getting-started/index.md
