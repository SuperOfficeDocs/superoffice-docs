---
uid: what_is_netserver
title: NetServer Architecture Deep Dive
description: Detailed technical overview of NetServer's multi-tiered architecture, persistence layers, and extensibility points for SuperOffice development.
author: AnthonyYates
date: 12.10.2021
keywords: API, NetServer, HDB, RDB, entity, row, archive, OSQL, web service, services, architecture
content_type: concept
deployment: online, onsite
platform: web, win
---

# NetServer Architecture Deep Dive

> [!NOTE]
> This document provides detailed technical information about NetServer's internal architecture. For a general overview of SuperOffice APIs and how to choose the right one for your needs, see the [SuperOffice API Overview](index.md).

NetServer is a **multi-tiered database access layer** that bridges communications between client applications and the database. This document provides an in-depth look at NetServer's architecture, components, and extensibility points.

## NetServer Components and Architecture

![NetServer architecture][img3]

NetServer has several extensibility points. Some extensibility points show up in clients, such as the [Document Plug-in][14], while others like the [Sentry Plug-in][18] do not.

SuperOffice Sales, SuperOffice Service and SuperOffice Mobile are examples of clients that use NetServer. All applications listed in the [SuperOffice Online AppStore][19] do too.

![NetServer Functions][nsfunc]

At its core, NetServer contains database-independent abstractions, and has database-specific implementations that API consumers never have to think about. The only indication is during [configuration][12] when the target database server is set.

NetServer enables developers to perform lookups, create, read, update and delete (CRUD) operations towards SuperOffice. Whether deploying a solution in an onsite domain environment or accessing SuperOffice via web services, NetServer exposes an array of application programming interfaces (APIs) that enable virtually unlimited access to the data in SuperOffice.

Although the details can be somewhat intimidating at first, NetServer APIs accommodate a wide variety of developers. There are several facades to gain access, and the following section will help guide you through the various layers of NetServer.

## Persistence layers

SuperOffice NetServer provides several **persistence layers**, each one allowing more fine-grain control the closer they get to the database.

![NetServer architecture, detailed][img4]

You can choose to work at the level that suits you best. [**Webhooks**][9] are supported at both the low and high levels of NetServer.

### Domain-level APIs (NetServer Core)

The lowest layer of NetServer is only used by clients or an application server in an onsite domain environment. This level does the heavy lifting and is responsible for **serializing all model-based instructions into SQL**.

* [SQL data objects (OSQL)][1]: low-level, high-performance, database-independent objectified SQL.
* [Row and Rows][2]: medium-level data table and row-level access.
* [Entities][3]: high-level business model classes that abstract multiple table joins.
* [Archive providers][4] and [MDO Providers][17]: provide read-only search capabilities.

[Read more about to configure NetServer Core using dependency injection][26].

### Web service APIs

NetServer web service data access is provided by the following types of [web service endpoints][15]

* **REST**ful: ASP.NET WebAPI
* **SOAP**: WCF-based IIS application

SuperOffice publishes [web service proxies][16] that can be used by clients to access the service endpoints.

An important aspect of NetServer web service development is its **deployment flexibility**. It's capable of being embedded in a domain-centric client, or used by a web application across the internet.

The following sections present an overview of the NetServer API and the different aspects of NetServers service offerings. Each level is described briefly below and in detail in the linked sections.

## Web services layer

At the highest level, encapsulated in the **SuperOffice.Services namespace**, is an **agent** pattern-derived API that in terms of deployment is quite flexible. Access and modification to data in the database, using service objects, will always be coded the same, whether the application and database are located on the same server, or operating in a distributed environment. This flexibility does come at a performance price though.

[Read more about web services.][5]

## Programming with NetServer APIs

Every solution that uses NetServer packages directly needs a [SuperOffice section][12] in the application configuration file. This only pertains to the following nuget packages:

* [SuperOffice.NetServer.Core][22] (onsite clients and plugin development)
* [SuperOffice.NetServer.Services][23] (SOAP proxy and utility classes)
* [SuperOffice.WebApi][24] (HTTP RPC proxy and utility classes)
* [@SuperOffice/WebApi][25] (NPM package for JavaScript/TypeScript applications)

Configuration requirements:

* Windows applications must add a SuperOffice section to the *app.config* file.
* ASP.NET web applications must add a SuperOffice section to the *web.config* file.

The **SuperOffice section group** contains configuration details pertaining to NetServer operations, such as database connection details, logging, document handling and security. Everything you need to know about the SuperOffice configuration options is defined in the [NetServer configuration documentation][12].

> [!NOTE]
> The more control over the queries you have, the more responsibility you take on for handling ensuring that relationships and keys are maintained properly.

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services. Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer. SuperOffice supplies .NET proxy assemblies only. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

> [!TIP]
> Before you start coding, brush up on your knowledge about [SuperOffice authentication][13].

## Summary

This has been a high-level view of NetServer. As you can see, there is a vast difference between the different approaches. Be aware though that, just because one layer takes longer to complete than another, it does not imply that a layer should be ignored. It all depends on the needs of the application and its' environment.

<!-- Referenced links -->
[1]: ../osql/index.md
[2]: ../rows/index.md
[3]: ../entities/index.md
[4]: ../archive-providers/index.md
[5]: ../web-services/index.md
[9]: ../../automation/webhook/index.md
[12]: ../config/index.md
[13]: ../authentication/overview.md
[14]: ../plugins/document/soarc-document-plugin.md
[15]: ../web-services/endpoints/index.md
[16]: ../web-services/proxies/index.md
[17]: ../mdo-providers/reference/index.md
[18]: ../plugins/sentry/index.md
[19]: https://online.superoffice.com/appstore
[22]: https://www.nuget.org/packages/superoffice.netserver.core
[23]: https://www.nuget.org/packages/superoffice.netserver.services
[24]: https://www.nuget.org/packages/superoffice.webapi
[25]: https://www.npmjs.com/package/@superoffice/webapi
[26]: ../reference/netserver/core/index.md

<!-- Referenced images -->
[img3]: media/netserver-components-overview.png
[img4]: media/superoffice-api-architecture.png
[nsfunc]: media/netserver-main-components.png
