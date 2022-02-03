---
uid: intro-to-superoffice-apis
title: Introduction to SuperOffice APIs
description: Introducing SuperOffice APIs. The levels of SuperOffice extensibility are configuration, UI workflow, scripting, external APIs, and internal APIs.
author: Tony Yates
so.date: 12.02.2021
keywords: API, getting started, integration point, scripting, Jscript, Javascript, VB.NET, C#, NetServer, extensibility
so.topic: concept
so.envir: cloud, onsite
so.client: win, web, service
---

# Introducing SuperOffice APIs

It can sometimes be daunting for people new to SuperOffice programming to know where to begin. With several platforms, for both customer relationship management (CRM) and customer service (CS), it can be difficult to understand which application programming interface (API) is appropriate for which platform.

## Extensibility levels

There are several levels of SuperOffice extensibility, and these are commonly defined as configuration, UI workflow, scripting, external APIs, and internal APIs.

![ExtensibilityStairs][img2]

The first two levels of extensibility are exposed inside the **admin UI pages** of SuperOffice. These are features commonly managed by system administrators and SuperOffice consultants and are used to tailor SuperOffice to individual customer needs.

The **scripting level** pertains to a few different features that provide similar functionality, albeit by different means. [CRMScript][3] is a SuperOffice scripting dialect similar to JavaScript and is managed inside the administrative pages of SuperOffice. [NetServer scripting][16] is an Application Server capability that is accessible onsite only.

**External APIs** provide complete data access for both SuperOffice clients and online applications. This level includes SuperOffice COM APIs and the [NetServer API landscape][15].

**Internal APIs** are the nearly limitless amount of customization capabilities that most onsite installations leverage to provide everything from custom pages and dialogs, document and sentry plugins, and so much more.

## Online vs. onsite extensibility

Since 2005, SuperOffice has heavily invested in building APIs that enable partners and customers to build integrations that encompass everything from the database schema changes up to modifying UI elements in the application interface.

![Onsite extensibility diagram][img1]

With this breadth of customization capability in onsite installations, it's sometimes hard for legacy partner applications to adapt to move their application to the cloud.

Online applications are much more strict, and only have a subset of extensible capabilities.

![Online APIs][img3]

With onsite installation, there is one web server hosting SuperOffice sites, and the owners can do whatever they like with their installation.

Online tenants, on the other hand, share application file sets. Therefore, any compiled assemblies that are exposed to one installation would inadvertently expose those same customizations across all shared tenants.

> [!NOTE]
> Since compiled assemblies can't be securely and effectively isolated, **no one is permitted to deploy custom compiled assemblies to an online tenant**.

**Security and hosting restrictions** in Online force both standard and custom applications to adapt in ways that support the features and functions they can provide, and accept the limitations that restrict the things they can't.

SuperOffice will continue to invest in research and development to deliver equivalent onsite customization capabilities to SuperOffice CRM Online. However, a timeline for this is not available. This policy decision is related to security reasons, and SuperOffice is not willing to compromise tenant security.

## Platforms (SuperOffice clients)

[SuperOffice Service][4] (CS) supports scripting automation and extensive UI customizations and accounts for the majority of integrations.

SuperOffice CRM is available as the [Online Web client][7], the [Onsite Web client][6], and the [Windows client][5], each of which has its own extensibility characteristics.

The [mobile clients][31] SuperOffice Mobile and Pocket CRM support custom web panels that are configurable on each device. They expose few external integration points.

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

[!include[What is automation?](../../../superoffice-docs/docs/automation/includes/automation-intro.md)]

**NetServer**, although used as an umbrella term that encapsulates a variety of data access capabilities, is just as much if not more extensible than the SuperOffice clients. With constructs such as [low-level database objects][17] to [high-level business objects][18], to [higher-level web services][19] and web service proxy libraries, NetServer is itself an extensible SuperOffice product.

SuperOffice has several partners and 3rd party vendors who have built tightly-coupled integrations with SuperOffice using external APIs. The different types of integrations built range from tiny edge-case security plugins to integrations with completely new document management systems. There are even complete enterprise resource planning systems that leverage SuperOffice CRM as the heart of its ecosystem.

## At a glance

![Integration points -screenshot][img5]

The following table compares some of the most common extensibility points and defines which capabilities are possible in both environments.

| Level | Extensibility | Client | Onsite | Online |
|---|---|---|:-:|:-:|
| Configuration | [Preferences][20]   | Sales, Service | X | X |
|               | Lists               | Sales, Service | X | X |
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
|               | Zapier              | Sales, Service | | X |
| Scripting     | [CRMScript][3]      | Service        | X | X |
|               | [NetServer Scripting][16] | Sales, Service | X | |
|               | Windows Client      | Sales          | X | |
| External APIs | [SOAP][9]           | Sales, Service | X | X |
|               | [Restful][8]        | Sales, Service | X | X |
|               | [Quote Connector][12]    | Sales | X | X |
|               | [ERP Sync Connector][11] | Sales | X | X |
|               | [Database Mirroring][13] | Sales, Service | | X |
| Internal APIs | [Custom Pages][26]  | Sales          | X | |
|               | [Custom Dialogs][26] | Sales          | X | |
|               | [DataHandlers][26]  | Sales          | X | |
|               | [Ajax Methods][27]  | Sales          | X | |
|               | [Archive Providers][28] | Sales          | X | |
|               | [MDO Providers][29] | Sales          | X | |
|               | Document Plugins    | Sales          | X | |
|               | Sentry Plugins      | Sales          | X | |
|               | Batch Task Plugins  | Sales          | X | |
| Database      | Database access API | Sales, Service | X | X |
|               | Continuous Database | Sales, Service | X | |
|               | SQL Scripts         | Sales, Service | X | |

Each platform has strengths and weaknesses that are dependent on the environment in which it is deployed.

## Conclusion

Whether constructing a small internal automation routine or building a complex integration, SuperOffice has many integration options. Once you get past the problem of knowing with which SuperOffice platforms you are integrating, it becomes a matter of just choosing the right API for your solution.

With the understanding that each SuperOffice platform provides a lot of integrations points, and knowing that any problem can have multiple solutions, it's important to consider all options before you decide which approach to take. Assistance and guidance are available. Please use the [developer forums][1] to ask for recommendations, or you may submit integration questions directly to SuperOffice at [sdk@superoffice.com][2].

Read more about each platform API in the SDK documentation.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/forums/api-forums/
[2]: mailto:sdk@superoffice.com
[3]: ../../../crmscript/docs/overview/index.md
[4]: ../../../superoffice-docs/docs/service/integrate/index.md
[5]: ../../../superoffice-docs/docs/onsite/integrate/win-client/index.md
[6]: ../../../superoffice-docs/docs/onsite/integrate/web-client/index.md
[7]: ../../../superoffice-docs/docs/online/integrate/index.md
[8]: ../api-reference/restful/index.md
[9]: ../api-reference/soap/index.md
[10]: ../netserver/webhooks/index.md
[11]: ../netserver/erp-connectors/index.md
[12]: ../netserver/quote-connectors/index.md
[13]: ../../../superoffice-docs/docs/mirroring/overview.md
[14]: ../../../superoffice-docs/docs/automation/overview.md#languages
[15]: ../netserver/index.md
[16]: ../../../superoffice-docs/docs/automation/netserver-scripting/index.md
[17]: ../netserver/osql/index.md
[18]: ../netserver/entities/index.md
[19]: ../netserver/web-services/index.md
[20]: ../../../superoffice-docs/docs/admin/user-preferences/index.md
[21]: ../../../superoffice-docs/docs/automation/trigger/create-trigger-script.md
[22]: ../../../superoffice-docs/docs/automation/trigger/create-trigger-macro.md
[23]: ../custom-fields/overview.md
[24]: ../../../user-interface/docs/web-panels/index.md
[25]: ../../../user-interface/docs/service-ui/custom-screens/index.md
[26]: ../../../user-interface/docs/web-application/index.yml
[27]: ../../../user-interface/docs/web-application/custom-ajax-methods.md
[28]: ../netserver/archive-providers/index.md
[29]: ../netserver/mdo-providers/reference/index.md
[30]: ../../../crmscript/docs/custom-database/extra-tables.md
[31]: ../../../superoffice-docs/docs/mobile/index.yml
[32]: ../netserver/index.md#domain-level-apis-netserver-core
[33]: ../netserver/config/services.md

<!-- Referenced images -->
[img1]: media/web-client-custom-code.png
[img2]: media/extensibilitystairs.png
[img3]: media/onlineapis.png
[img5]: media/integration-points.png
