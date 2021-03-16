---
title: web_application       
description: Web GUI .Net API
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
so.client: web
---

# Expander SDK: Web GUI .Net API

The SuperOffice Web client can be customized in many different ways. It is built using a reusable set of components and can be extended with new components and configured to use custom components.

The [SuperOffice Web Client NuGet package][1] adds the needed assemblies to extend the web client. This will also install the SuperOffice [web services package][2] and [Core package][3].

The client is built using the **NetServer Services API layer**, which enables the web server to be run on a separate server from the business logic implemented in the web services.

It also uses the **Dynamic Client Foundation** (DCF) on top of the web services to handle globalization and to define the page builder infrastructure.

The major components in the Web GUI are:

* The [page builder framework][4] used in CRM.web. This means the config files for the framework and the many components and interfaces that the **PageBuilder** uses.
* The [page, panel, card, and archive components][5] used to render the pages.
* The [AJAX libraries][6] that integrate the web front end with the web server.

## Technical information

### Development platform

* Microsoft .NET
* Code in C\#
* Web in ASP.NET 2.0
* Asynchronous calls via Ajax.NET

### Multiple browser support (client-side)

* Internet Explorer 6, 7, and 8 on Windows
* FireFox + Opera on Windows, Mac, and Linux

### Server side

* Windows Server 2003 for production Web & Application servers
* We support Database, Application Server and Web Server on separate or the same machine
* Windows XP (for demo and test/single-machine setup supported)
* We support Network Load Balancing

### Database

* We support SQL Server 2000, 2005; Oracle 9, 10; Sybase Anywhere 8, 9; DB/2 on Windows, Linux, iSeries.
* The SuperOffice data model is NOT modified and hence requires no data conversion process. New tables and fields are however added to the existing data model.

### Architecture

* Service Oriented Architecture (SOA)
* Dynamic Client Foundation (DCF)

### Unicode

The CRM.web product is prepared for Unicode, but are depending on several other elements in the SuperOffice CRM concept to work properly. Hence, support for Unicode is not part of this release.

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.Crm.Web/
[2]: https://www.nuget.org/packages/SuperOffice.NetServer.Services/
[3]: https://www.nuget.org/packages/SuperOffice.NetServer.Core/
[4]: pagebuilder/index.md
[5]: pagebuilder/config/index.md
[6]: tutorials/customize/custom-ajax-methods.md
