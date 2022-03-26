---
uid: what_is_netserver
title: What is Netserver / Understanding NetServer
description: NetServer is a multi-tiered database access layer that bridges communication between clients and the SuperOffice database.
author: AnthonyYates
so.date: 12.10.2021
keywords: API, NetServer, HDB, RDB, entity, row, archive, OSQL, web service, services
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# Understanding NetServer

NetServer is a **multi-tiered database access layer** that bridges communications between client applications and the database. NetServer contains both low-level classes for managing data access in onsite domain environments as well as high-level web services for access from anywhere in the world.

NetServer has several extensibility points. Some extensibility points show up in clients, such as the [Document Plug-in][14], while others like the [Sentry Plug-in][18] do not.

SuperOffice Sales, SuperOffice Service and SuperOffice Mobile are examples of clients that use NetServer. All applications listed in the [SuperOffice Online AppStore][19] do too.

At its core, NetServer contains database-independent abstractions, and has database-specific implementations that API consumers never have to think about. The only indication is during [configuration][12] when the target database server is set.

![NetServer architecture][img3]

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

## Search

[Archive providers][4] are similar to database views and simplify **searching and retrieving** collections of related data efficiently. They let you execute complex queries while masking the join logic and handling the security.

Each provider describes a set of related **columns** from the database and supports a set of methods for finding out what columns are available.

[Read more about archive providers.][4]

## Relational database layer (entities)

The relational database (RDB) layer, conceptually the **business logic** layer, is encapsulated within the [**SuperOffice.CRM.Entities namespace**][20]. Relational database objects, such as `Contact`, `ContactCollection`, `Person`, and `PersonCollection`, are all found here. These objects abstract away all of the complexities required to aggregate related data from the multiple tables in the database.

RDB objects expose the data as neat and logical classes commonly referred to as [entities][3]. Entities **represent real-world objects**, such as companies and contacts.

> [!TIP]
> This layer is great for **creating and saving** new entities, such as creating a new `Contact` or `Sale`, but may not be as performant as more lower layers when retrieving many entities at one time.

[Read more about Entities.][3]

## High-level database layer (rows)

The high-level database (HDB) classes, found under the [**SuperOffice.CRM.Rows namespace**][21], is a table-object view of the database. This layer exposes **database tables** and the information they contain as row objects, such as `ContactRow` and `ContactRows`.

Unlike RDB object properties, which are full-blown entities themselves, HDB object properties contain **ID values** that represent ID field values in a corresponding table.

> [!NOTE]
> The Row objects **do not contain any business logic**, so here you need to maintain the relationship between rows yourself.

[Read more about Row and Rows.][2]

## Objectified SQL (OSQL)

At the lowest levels of the framework are the Objectified-SQL (OSQL) classes.

[OSQL][1] encompasses all **common SQL elements**, such as SELECT, JOIN, WHERE, AND, OR, and more. It exposes all of these elements as **classes**, to be used in an "object-orientated" manner.

OSQL has the **best performance** of all NetServer API layers. When using OSQL, the code will be more responsive and efficient than when using the Services, RDB, or the HDB layers.

[Read more about OSQL.][1]

## Programming with NetServer APIs

Every solution that uses NetServer packages directly needs a [SuperOffice section][12] in the application configuration file. This only pertains to the following nuget packages:

* [SuperOffice.NetServer.Core][22] (onsite clients and plugin development)
* [SuperOffice.NetServer.Services][23] (SOAP proxy and utility classes)

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
[6]: ../reference/soap/index.md
[7]: ../reference/netserver/services/index.md
[8]: ../reference/netserver/core/index.md
[9]: ../../automation/webhook/index.md
[10]: ../reference/webapi/index.md
[11]: ../../automation/crmscript/overview/index.md
[12]: ../config/index.md
[13]: ../authentication/overview.md
[14]: ../plugins/document/soarc-document-plugin.md
[15]: ../web-services/endpoints/index.md
[16]: ../web-services/proxies/index.md
[17]: ../mdo-providers/reference/index.md
[18]: ../plugins/sentry/index.md
[19]: https://online.superoffice.com/appstore
[20]: <xref:SuperOffice.CRM.Entities>
[21]: <xref:SuperOffice.CRM.Rows>
[22]: https://www.nuget.org/packages/superoffice.netserver.core
[23]: https://www.nuget.org/packages/superoffice.netserver.services


<!-- Referenced images -->
[img1]: media/netserverhilevelview.png
[img3]: media/netserver-components-overview.png
[img4]: media/superoffice-api-architecture.png
