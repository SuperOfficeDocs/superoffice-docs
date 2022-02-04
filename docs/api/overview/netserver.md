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

All SuperOffice clients, in one form or another, depend on NetServer for database access. While each client has its own extensibility points, NetServer also has extensibility points. Some of NetServer's extensibility options surface to the clients, such as the [Document Plug-in][14].

As a **multi-tiered database access layer** that bridges communications between clients and the SuperOffice database, NetServer uses database-independent database access code, as well as high-level web services for both the SuperOffice Web and mobile clients.

![NetServer architecture][img3]

In a nutshell, NetServer is a layered, **factory-driven** library that enables developers to conduct Create, Read, Update and Delete (CRUD) operations to the SuperOffice database, and more. Whether deploying a solution to a local SuperOffice database installation or operating in a distributed environment, NetServer exposes an array of application programming interface (API) approaches to facilitate a wide range of solution implementations.

Although the terrain is vast and complex and can be somewhat intimidating at first, the NetServer APIs accommodate a wide variety of developers by layering the architecture in various intuitive abstractions. The layered aspect of NetServer invites developers to tap into the database from several facets. In this article, we will guide you through the various regions of NetServer, show you the attractions, as well as point out the areas to avoid.

## Persistence layers

SuperOffice NetServer provides several **persistence layers**, each one allowing more fine-grain control than the next.

![NetServer architecture, detailed][img4] <!-- TODO update fig to drawIO simplified services -->

You can choose to work at the level that suits you best. **Webhooks** are supported at both the low and high levels of NetServer.

### Domain-level APIs (NetServer Core)

The lowest layer of NetServer, the domain-level development APIs, is generally used by a client or application server. This layer does the heavy lifting and is responsible for **marshaling all the model-based data into raw SQL**.

* [SQL data objects (OSQL)][1]: Low-level, high-performance, database-independent objectified SQL.
* [Row and Rows][2]: Medium-level data table and data row-level access.
* [Entities][3]: High-level business model classes that abstract multiple table joins.
* [Archive providers][4] and [MDO Providers][17]: provide complex search capabilities across the entire database.

### Service-orientated APIs

The highest level of NetServer data access is the [service-orientated architecture][5] and consists of:

* [Web service endpoints][15] based on **REST**ful WebAPI and WCF **SOAP**: IIS application used by SuperOffice Web and Mobile.
* [Web service proxies][16]: Service agent pattern .NET assemblies used by clients to access the service endpoints.

An important aspect of NetServer web service development is its **deployment flexibility**. It's capable of being embedded in a domain-centric fat client application, as well as a thin client deployed with NetServer service proxies for data access across the internet.

The following sections present an overview of the NetServer API and the different aspects of NetServers service offerings. Each level is described briefly below and in detail in the linked sections.

## Web services layer

At the highest level, encapsulated in the **SuperOffice.Services namespace**, is an **agent** pattern-derived API that in terms of deployment is quite flexible. Access and modification to data in the database, using service objects, will always be coded the same, whether the application and database are located on the same server, or operating in a distributed environment. This flexibility does come at a performance price though.

[Read more about web services.][5]

## Search

[Archive providers][4] are similar to database views and simplify **searching and retrieving** collections of related data efficiently. They let you execute complex queries while masking the join logic and handling the security.

Each provider describes a set of related **columns** from the database and supports a set of methods for finding out what columns are available.

[Read more about archive providers.][4]

## Relational database layer (entities)

The relational database (RDB) layer, conceptually the **business logic** layer, is encapsulated within the **SuperOffice.Entities namespace**. Relational database objects, such as `Contact`, `ContactCollection`, `Person`, and `PersonCollection`, are all found here. These objects abstract away the complexities required to access and present information from the database.

RDB objects expose the data as neat and logical objects commonly referred to as [entities][3]. Entities **represent real-world objects**, such as companies and people.

> [!TIP]
> This layer is great for **creating and saving** new entities, such as creating a new `Contact` or `Sale`, but is not as efficient as one of the lower layers when retrieving information.

[Read more about Entities.][3]

## High-level database layer (rows)

The high-level database (HDB) layer, found under the **SuperOffice.Rows namespace**, is a table-object view of the database. This layer exposes **database tables** and the information they contain as row objects, such as `ContactRow` and `ContactRows`.

Unlike RDB object properties, which are full-blown entities themselves, HDB object properties contain **ID values** that represent ID field values in a corresponding table.

> [!NOTE]
> The Row objects **do not contain any business logic**, so here you need to maintain the relationship between rows yourself.

[Read more about Row and Rows.][2]

## SuperOffice database interface layer (OSQL)

At the lowest levels of the framework is a database-independent objectified SQL library.

[OSQL][1] encompasses all **common SQL elements**, such as SELECT, JOIN, WHERE, AND, OR, and so forth. It exposes all of these elements as **class objects**, to be constructed and leveraged in an "object-orientated" manner.

OSQL has the **best performance** of all NetServer API layers. When using OSQL to create code, the code will be more responsive and efficient than when using the Services, RDB, or the HDB layers.

[Read more about OSQL.][1]

## Programming with NetServer APIs

When programming with the NetServer API, other than calling the web services directly, every solution needs a [SuperOffice-specific section group][12] in your application configuration file.

* For Windows Forms applications, add a SuperOffice-specific section group to an *app.config* file.
* For an ASP.NET web application, add a SuperOffice-specific section group to the *web.config* file.

The **SuperOffice section group** contains configuration options relevant NetServer operations, such as logging, document handling, security, database options, and so forth. Everything you need to know about the SuperOffice configuration options is well-defined in the [NetServer configuration documentation][12].

> [!NOTE]
> The more control over the queries you have, the more responsibility you take on for handling ensuring that relationships and keys are maintained properly.

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services. Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer. SuperOffice supplies .NET proxy assemblies only. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

> [!TIP]
> Before you start coding, brush up on your knowledge about [SuperOffice authentication][13].

## Summary

This has been a high-level view of NetServer. As you can see, there is a vast difference between the different approaches. Be aware though that, just because one layer takes longer to complete than another, it does not imply that a layer should be ignored. Each query type has its place in the development world when used judiciously.

<!-- Referenced links -->
[1]: osql/index.md
[2]: rows/index.md
[3]: entities/index.md
[4]: archive-providers/index.md
[5]: web-services/index.md
[6]: ../api-reference/soap/index.md
[7]: ../api-reference/netserver/services/index.md
[8]: ../api-reference/netserver/core/index.md
[9]: webhooks/index.md
[10]: ../api-reference/webapi/index.md
[11]: ../../../crmscript/docs/overview/index.md
[12]: config/index.md
[13]: ../authentication/overview.md
[14]: ../documents/plugins/soarc-document-plugin.md
[15]: web-services/endpoints/index.md
[16]: web-services/proxies/index.md
[17]: mdo-providers/reference/index.md

<!-- Referenced images -->
[img1]: media/netserverhilevelview.png
[img3]: media/netserver-components-overview.png
[img4]: media/netserverarchitecture-blue-650.png
