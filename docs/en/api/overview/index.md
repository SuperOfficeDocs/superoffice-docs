---
uid: intro-to-superoffice-apis
title: SuperOffice API Overview
description: Comprehensive guide to SuperOffice APIs, NetServer architecture, and integration capabilities. Learn about extensibility levels, deployment options, and choose the right API for your needs.
author: Tony Yates
date: 12.02.2021
keywords: API, NetServer, getting started, integration, scripting, web services, entities, OSQL, extensibility, architecture
content_type: concept
deployment: online, onsite
platform: web, win, service
---

# SuperOffice API Overview

SuperOffice provides a comprehensive suite of APIs and integration capabilities that enable developers to build powerful solutions on top of the SuperOffice platform. This guide will help you understand the architecture, choose the right APIs for your needs, and get started with SuperOffice development.

## What is NetServer?

**NetServer** is the heart of SuperOffice's API ecosystem - a **multi-tiered database access layer** that bridges communications between client applications and the SuperOffice database. NetServer contains both low-level classes for managing data access in onsite domain environments as well as high-level web services for access from anywhere in the world.

![NetServer architecture][img3]

NetServer enables developers to perform lookups, create, read, update and delete (CRUD) operations towards SuperOffice. Whether deploying a solution in an onsite domain environment or accessing SuperOffice via web services, NetServer exposes an array of application programming interfaces (APIs) that enable virtually unlimited access to the data in SuperOffice.

SuperOffice Sales, SuperOffice Service and SuperOffice Mobile are examples of clients that use NetServer. All applications listed in the [SuperOffice Online AppStore][19] do too.

## NetServer Architecture and API Layers

At its core, NetServer contains database-independent abstractions, and has database-specific implementations that API consumers never have to think about. The only indication is during [configuration][12] when the target database server is set.

SuperOffice NetServer provides several **persistence layers**, each one allowing more fine-grain control the closer they get to the database. You can choose to work at the level that suits you best.

![NetServer architecture, detailed][img4]

### Domain-level APIs (NetServer Core)

The lowest layer of NetServer is only used by clients or an application server in an onsite domain environment. This level does the heavy lifting and is responsible for **serializing all model-based instructions into SQL**.

* **[SQL data objects (OSQL)][1]**: low-level, high-performance, database-independent objectified SQL.
* **[Row and Rows][2]**: medium-level data table and row-level access.
* **[Entities][3]**: high-level business model classes that abstract multiple table joins.
* **[Archive providers][4]** and **[MDO Providers][17]**: provide read-only search capabilities.

### Web service APIs

NetServer web service data access is provided by the following types of [web service endpoints][15]:

* **[RESTful][8]**: ASP.NET WebAPI with modern HTTP-based APIs
* **[SOAP][9]**: WCF-based IIS application for enterprise integrations

SuperOffice publishes [web service proxies][16] that can be used by clients to access the service endpoints.

An important aspect of NetServer web service development is its **deployment flexibility**. It's capable of being embedded in a domain-centric client, or used by a web application across the internet.

At the highest level, encapsulated in the **SuperOffice.Services namespace**, is an **agent** pattern-derived API that in terms of deployment is quite flexible. Access and modification to data in the database, using service objects, will always be coded the same, whether the application and database are located on the same server, or operating in a distributed environment.

> [!NOTE]
> The more control over the queries you have, the more responsibility you take on for handling ensuring that relationships and keys are maintained properly.

[Read more about web services.][5]

## SuperOffice Extensibility Levels

There are several levels of SuperOffice extensibility, and these are commonly defined as configuration settings, workflow and scripting, external APIs, and internal APIs.

![ExtensibilityStairs][img2]

### Configuration Level

The first level of extensibility is exposed inside the **admin UI pages** of SuperOffice. These are features commonly managed by system administrators and SuperOffice consultants and are used to tailor SuperOffice to individual customer needs.

### Scripting Level

The **scripting level** pertains to a few different features that provide similar functionality, albeit by different means:

* **[CRMScript][3]**: A SuperOffice scripting dialect similar to JavaScript, managed inside the administrative pages
* **[NetServer scripting][16]**: An Application Server capability that is accessible onsite only

### External APIs

**External APIs** provide complete data access for both SuperOffice clients and online applications. This level includes SuperOffice COM APIs and the NetServer API landscape.

### Internal APIs

**Internal APIs** are the nearly limitless amount of customization capabilities that most onsite installations leverage to provide everything from custom pages and dialogs, document and sentry plugins, and so much more.

## Online vs. Onsite Deployment

Since 2005, SuperOffice has heavily invested in building APIs that enable partners and customers to build integrations that encompass everything from the database schema changes up to modifying UI elements in the application interface.

![Onsite extensibility diagram][img1]

With this breadth of customization capability in onsite installations, it's sometimes hard for legacy partner applications to adapt to move their application to the cloud.

Online applications are much more strict, and only have a subset of extensible capabilities.

![Online APIs][img3]

### Onsite Installations

With onsite installation, there is one web server hosting SuperOffice sites, and the owners can do whatever they like with their installation.

### Online Tenants

Online tenants, on the other hand, share application file sets. Therefore, any compiled assemblies that are exposed to one installation would inadvertently expose those same customizations across all shared tenants.

> [!NOTE]
> Since compiled assemblies can't be securely and effectively isolated, **no one is permitted to deploy custom compiled assemblies to an online tenant**.

**Security and hosting restrictions** in Online force both standard and custom applications to adapt in ways that support the features and functions they can provide, and accept the limitations that restrict the things they can't.

SuperOffice will continue to invest in research and development to deliver equivalent onsite customization capabilities to SuperOffice CRM Online. However, a timeline for this is not available. This policy decision is related to security reasons, and SuperOffice is not willing to compromise tenant security.

## Programming with SuperOffice APIs

### Configuration Requirements

Every solution that uses NetServer packages directly needs a [SuperOffice section][12] in the application configuration file. This only pertains to the following nuget packages:

* [SuperOffice.NetServer.Core][22] (onsite clients and plugin development)
* [SuperOffice.NetServer.Services][23] (SOAP proxy and utility classes)
* [SuperOffice.WebApi][24] (HTTP RPC proxy and utility classes)
* [@SuperOffice/WebApi][25] (NPM package for JavaScript/TypeScript applications)

Configuration requirements:

* Windows applications must add a SuperOffice section to the *app.config* file.
* ASP.NET web applications must add a SuperOffice section to the *web.config* file.

The **SuperOffice section group** contains configuration details pertaining to NetServer operations, such as database connection details, logging, document handling and security. Everything you need to know about the SuperOffice configuration options is defined in the [NetServer configuration documentation][12].

### Multi-Platform Support

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services. Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer. SuperOffice supplies .NET proxy assemblies only. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

> [!TIP]
> Before you start coding, brush up on your knowledge about [SuperOffice authentication][13].

### NetServer Extensibility

NetServer has several extensibility points. Some extensibility points show up in clients, such as the [Document Plug-in][14], while others like the [Sentry Plug-in][18] do not. [Webhooks][9] are supported at both the low and high levels of NetServer.

## SuperOffice Platforms and Clients

SuperOffice Service (CS) supports scripting automation and extensive UI customizations and accounts for the majority of integrations.

SuperOffice CRM is available as the [Online Web client][7], the [Onsite Web client][6], and the [Windows client][5], each of which has its own extensibility characteristics.

The [mobile clients][31] SuperOffice Mobile and Pocket CRM support custom web panels that are configurable on each device. They expose few external integration points.

### API Compatibility Matrix

The list of available APIs for integrations decreases the closer they are to online. That is just the nature of the respective environment and not the limitations of the platforms or APIs.

| | NetServer Web Services | NetServer Core | COM |
|---|:-:|:-:|:-:|
| [Windows][5] | X | X | X |
| [Web][6] | X | X | |
| [Online][7] | X | | |

* From [NetServer Core][32], Web supports [NetServer script events][16] only.
* Using [NetServer web services][19], the [configuration][33] must be set to Local Mode for Windows and Local or Remote mode for Web.

There are virtually no limitations as to which API you leverage when building an integration that targets just the Windows client. If, however, your requirements include both the Windows client and the Web client, the available API options decrease. This is not necessarily a bad thing though. Sometimes it just makes technological sense to build an integration using only one of the available APIs. For example, it doesn't make sense to use the COM-based API in today's web service architectures.

SuperOffice CRM Online relies exclusively on the service-orientated APIs for data-access, and yet it has more functionality than the other clients.

> [!NOTE]
> The web service APIs are the preferred integration point for nearly all scenarios and should be considered first. Especially with sustainability in mind.
>
> Don't mix NetServer Core and web services. Although it sometimes can't be avoided, we generally discourage building integrations that leverage more than one of our APIs in the same solution.

### Recommended APIs for each platform

The list of available APIs for integrations decreases the closer they are to online. That is just the nature of the respective environment and not the limitations of the platforms or APIs.

| | NetServer Web Services | NetServer Core | COM |
|---|:-:|:-:|:-:|
| [Windows][5] | X | X | X |
| [Web][6] | X | X | |
| [Online][7] | X | | |

* From [NetServer Core][32], Web supports [NetServer script events][16] only.
* Using [NetServer web services][19], the [configuration][33] must be set to Local Mode for Windows and Local or Remote mode for Web.

There are virtually no limitations as to which API you leverage when building an integration that targets just the Windows client. If, however, your requirements include both the Windows client and the Web client, the available API options decrease. This is not necessarily a bad thing though. Sometimes it just makes technological sense to build an integration using only one of the available APIs. For example, it doesn't make sense to use the COM-based API in today's web service architectures.

SuperOffice CRM Online relies exclusively on the service-orientated APIs for data-access, and yet it has more functionality than the other clients.

> [!NOTE]
> The web service APIs are the preferred integration point for nearly all scenarios and should be considered first. Especially with sustainability in mind.
>
> Don't mix NetServer Core and web services. Although it sometimes can't be avoided, we generally discourage building integrations that leverage more than one of our APIs in the same solution.

## Automation vs. integration

The APIs that enable external integration with SuperOffice typically mean applications that are **compiled into executables** and run in their own process. However, there are also important internal integration points in SuperOffice that are just as important.

The difference between the two is that automation primarily deals with [scripting languages][14] while most integrations use a compiled program using .NET, Java, or Delphi.

[!include[What is automation?](../../automation/includes/automation-intro.md)]

**NetServer**, although used as an umbrella term that encapsulates a variety of data access capabilities, is just as much if not more extensible than the SuperOffice clients. With constructs such as [low-level database objects][17] to [high-level business objects][18], to [higher-level web services][19] and web service proxy libraries, NetServer is itself an extensible SuperOffice product.

SuperOffice has several partners and 3rd party vendors who have built tightly-coupled integrations with SuperOffice using external APIs. The different types of integrations built range from tiny edge-case security plugins to integrations with completely new document management systems. There are even complete enterprise resource planning systems that leverage SuperOffice CRM as the heart of its ecosystem.

## Comprehensive Integration Guide

![Integration points -screenshot][img5]

The following table compares some of the most common extensibility points and defines which capabilities are possible in both environments.

| Level | Extensibility | Client | Onsite | Online |
|---|---|---|:-:|:-:|
| Configuration | [Preferences][20]   | Sales, Service | X | X |
|               | [Lists][38]         | Sales, Service | X | X |
|               | [Custom Fields][23] | Sales, Service | X | X |
|               | SAINT               | Sales          | X | X |
|               | Sales Guide         | Sales          | X | X |
|               | Project Guide       | Sales          | X | X |
| UI Workflow   | Drive the application UI | Sales     | X | |
|               | [Triggers][21]      | Sales, Service | X | X |
|               | [SuperMacro][22]    | Sales, Service | X | X |
|               | [Extra Tables][30]  | Service        | X | X |
|               | [Custom Screens][25] | Service        | X | X |
|               | [Web panels][24]    | Sales, Service | X | X |
|               | [Zapier][40]              | Sales, Service | | X |
| Scripting     | [CRMScript][3]      | Service        | X | X |
|               | [NetServer Scripting][16] | Sales, Service | X | |
|               | Windows Client      | Sales          | X | |
| External APIs | [SOAP][9]           | Sales, Service | X | X |
|               | [Restful][8]        | Sales, Service | X | X |
|               | [Quote Connector][12]    | Sales | X | X |
|               | [ERP Sync Connector][11] | Sales | X | X |
|               | [Database Mirroring][13] | Sales, Service | | X |
|               | [Webhooks][34] | Sales | X | X |
| Internal APIs | [Custom Pages][26]  | Sales          | X | |
|               | [Custom Dialogs][26] | Sales          | X | |
|               | [DataHandlers][26]  | Sales          | X | |
|               | [Ajax Methods][27]  | Sales          | X | |
|               | [Archive Providers][28] | Sales          | X | |
|               | [MDO Providers][29] | Sales          | X | |
|               | [Document Plugins][35]    | Sales          | X | |
|               | [Sentry Plugins][36]      | Sales          | X | |
|               | [Batch Task Plugins][37]  | Sales          | X | |
| Database      | Database access API | Sales, Service | X | X |
|               | [Continuous Database][39] | Sales, Service | X | |
|               | SQL Scripts         | Sales, Service | X | |

Each platform has strengths and weaknesses that are dependent on the environment in which it is deployed.

## Summary and Next Steps

Whether constructing a small internal automation routine or building a complex integration, SuperOffice has many integration options. Once you get past the problem of knowing with which SuperOffice platforms you are integrating, it becomes a matter of just choosing the right API for your solution.

NetServer provides a robust, flexible foundation for all SuperOffice integrations. From low-level OSQL operations to high-level web services, you can choose the approach that best fits your technical requirements and deployment environment.

### Key Takeaways

* **NetServer** is the core of SuperOffice's API ecosystem, providing multiple layers of abstraction
* **Web services** are the preferred integration point for nearly all scenarios
* **Online deployments** have security restrictions that limit certain customization capabilities
* **Choose your API level** based on your needs: configuration, scripting, external APIs, or internal APIs

### Getting Help

With the understanding that each SuperOffice platform provides a lot of integrations points, and knowing that any problem can have multiple solutions, it's important to consider all options before you decide which approach to take.

Assistance and guidance are available:

* Use the [developer forums][1] to ask for recommendations
* Submit integration questions directly to SuperOffice at [sdk@SuperOffice.com][2]
* Read more about each platform API in the SDK documentation

### Related Documentation

* [NetServer Core APIs][32] - Low-level data access
* [Web Services][5] - RESTful and SOAP APIs
* [Authentication Overview][13] - Security and access patterns
* [Configuration Guide][12] - Setting up NetServer
* [Automation Overview][14] - Scripting and workflow automation

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/forums/api-forums/
[2]: mailto:sdk@superoffice.com
[3]: ../../automation/crmscript/overview/index.md
[4]: ../archive-providers/index.md
[5]: ../web-services/index.md
[6]: ../../onsite/integrate/web-client/index.md
[7]: ../../online/integrate/index.md
[8]: ../reference/restful/index.md
[9]: ../../automation/webhook/index.md
[11]: ../plugins/erp-connectors/index.md
[12]: ../plugins/quote-connectors/index.md
[13]: ../authentication/overview.md
[14]: ../../automation/overview.md#languages
[15]: ../web-services/endpoints/index.md
[16]: ../../automation/netserver-scripting/index.md
[17]: ../osql/index.md
[18]: ../entities/index.md
[19]: https://online.superoffice.com/appstore
[20]: ../../admin/user-preferences/index.md
[21]: ../../automation/trigger/create-trigger-script.md
[22]: ../../automation/trigger/create-trigger-macro.md
[23]: ../../custom-objects/overview.md
[24]: ../../customization/web-panels/admin/index.md
[25]: ../../ui/blogic/custom-screens/index.md
[26]: ../../ui/web-app/index.yml
[27]: ../../ui/web-app/custom-ajax-methods.md
[28]: ../archive-providers/index.md
[29]: ../mdo-providers/reference/index.md
[30]: ../../custom-objects/learn/extra-table.md
[31]: ../../mobile/index.yml
[32]: netserver.md#domain-level-apis-netserver-core
[33]: ../config/services.md
[34]: ../../automation/webhook/overview.md
[35]: ../plugins/document/soarc-document-plugin.md
[36]: ../plugins/sentry/index.md
[37]: ../tutorials/sem-batch-processing/index.md
[38]: ../lists/index.md
[39]: ../../database/dictionary/index.md
[40]: https://zapier.com/apps/superofficecrm/integrations

<!-- Referenced images -->
[img1]: media/web-client-custom-code.png
[img2]: media/extensibility-complexity.png
[img3]: media/netserver-components-overview.png
[img4]: media/superoffice-api-architecture.png
[img5]: media/integration-points.png
