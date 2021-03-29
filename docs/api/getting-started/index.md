---
uid: into-to-superoffice-apis
title: Introduction to SuperOffice APIs
description: Introducing SuperOffice APIs
author: Tony Yates
so.date: 08.12.2015
keywords: api
so.topic: getting-started
so.envir: cloud, onsite           # cloud or onsite
so.client: win, web               # online, web, win, pocket, or mobile
---

# Introducing SuperOffice APIs

It can sometimes be daunting for people new to SuperOffice programming to know where to begin. With several platforms, for both Customer Relationship Management (CRM) and Customer Service (CS), it can be difficult to understand which application programming interface (API) is appropriate for which platform. This article explores the different platforms and explains what SuperOffice APIs are available for each one, as well as provides links to the corresponding API documentation.

## Internal automation API versus external integration API

The primary focus of this article is to discuss the APIs that enable external integration with SuperOffice. This typically means applications that are compiled into executables and run in their own process. However, there are also important internal integration points in SuperOffice that are just as important and are covered briefly.

Both SuperOffice CRM and SuperOffice Customer Service (CS) support different forms of scripting automation. SuperOffice CS, available in both on-site and online, supports scripting automation and accounts for a majority of CS integrations. SuperOffice CRM on the other hand, is available as four unique platforms, each of which has their own extensible characteristics:

* Windows client
* Onsite Web client
* Online Web client
* Mobile client: Pocket CRM

These first three CRM clients support many forms of integration, but the mobile client does not. The mobile client does support custom web panels that are configurable on each device, but that is all. Because the mobile client does not expose any external integration points, it will not be mentioned any further in this article.

The sections below discuss the capabilities of both internal automation and external integrations. The differences between the two are that internal automation primarily deals with scripting languages while most external integrations use a compiled program using .NET, Java, or Delphi.

## Internal automation APIs

Automation allows an application to execute code when an event occurs inside the client. These events occur when an action takes place: such as when a dialog is opened, or a person is created.

While automation code is usually defined by customer requirements, consultants often create routines that assist with common tasks. Automation code can perform just about any tasks imaginable, but generally involve validating, transforming and/or moving data. These types of routines are commonly discussed in the [Developer Forums][1].

**Script automation options by platform:**

![x][img1]

As seen, there are several scripting options available for each platform. The graph details which automation languages are supported by each platform.

SuperOffice CS leverages its own scripting engine and language, known as CRMScript. Primarily used to automate workflows around customer service scenarios involving tickets, mailings, and templates, it's been extended to include classes and methods that mirror NetServer web service APIs. The extended CRM Script API allows the platform to access and manipulate CRM data previously only available to CRM.

SuperOffice CRM is slightly more complicated than SuperOffice CS. The Windows client hosts a scripting environment made possible by the [MSScriptControl][2], a COM component that's built-in and made available on every Windows operating system.

The SuperOffice Web client relies exclusively on client-side javascript support. SuperOffice tests the Web client against all major browsers and versions to ensure a fully functional client no matter what the browser policy in an organization. On-site installations support including and running integration javascript to support customer needs, but it is up to the organization to ensure it works in their environment. Onsite Web installations also support server-side scripting by executing C# or VB.NET scripts on the application server.

The SuperOffice Windows client can load and execute both vbScript and JScript code. The scripting environment does enable some interaction with users by showing message boxes or displaying input boxes. The Windows client has the most complete automation engine of all the SuperOffice products. It is, for example, the only client that out of the box exposes events that can invoke script routines when users open and close dialogs. This presents an opportunity to either eliminate or augment other integrations.

Although the on-site Web client has the ability to detect when a user opens or closes a dialog, it requires custom javascript on the web server. This type of functionality is normally implemented by larger customers or partners who specialize in CRM Web client customizations and integrations.

Each platform has strengths and weaknesses that are dependent on the environment in which it is deployed:

**Automation capabilities by on-site platform:**

![x][img2]

For example, automation code in the CRM Windows client has complete access to all of the current user's contextual identity values. The following code snippet demonstrates how to access the current company's current identity value:

```http
Dim contactId
contactId = CurrentContact.Identity
```

While the same is possible on the Web client, it requires a round trip request to the web server using JavaScript, and is not considered an internal automation API.

```javascript
var contact = AjaxMethodDispatcher.CallSync(
 "SuperOffice.DCF.Web.AjaxMethods.SuperState.GetCurrent", "", "contact"
);
```

Internal automation APIs are very useful for managing predetermined routines based on customers' requirements and providing user interaction within the application. They can make complex multiple-step tasks easier by programmatically automating the mundane details, and let the user focus on the task at hand.

## External Integration APIs

The term external API refers to all SuperOffice client products, SuperOffice COM APIs, and the NetServer API landscape.

NetServer, although used as an umbrella term that encapsulates a variety of data access capabilities, is just as much if not more extensible than the SuperOffice clients. With constructs such as low-level database objects to high-level business objects, to higher-level web services and web service proxy libraries, NetServer is itself an extensible SuperOffice product.

SuperOffice has several partners and 3rd party vendors who have built tightly-coupled integrations with SuperOffice using external APIs. The different types of integrations built range from tiny edge-case security plugins to integrations with completely new document management systems. There are even complete enterprise resource planning systems that leverage SuperOffice CRM as the heart of its ecosystem.

Where to get started depends on your target SuperOffice platform and your preferred technology stack.

The list of available APIs for integrations decreases the closer they are to on-line. That is just the nature of the respective environment and not the limitations of the platforms or APIs.

**Recommended APIs for each platform:**

![x][img3]

There are virtually no limitations as to which API you leverage when building an integration that targets just the Windows client. If, however, your requirements include both the Windows client and the Web client together, the available API options decrease. This is not necessarily a bad thing though. Sometimes it just makes technological sense to build an integration using only one of the available APIs. It does not make sense, for example, to use the COM-based API in today's web service architectures. Although it sometimes can not be avoided, we generally discourage building integrations that leverage more than one of our APIs in the same solution.

Although integrations in SuperOffice CRM Online can display visual elements, such as partner applications through a web panel, the Web client in SuperOffice CRM Online only supports service-orientated integrations today. Meaning that all data access routines must use the web services APIs. Considering the SuperOffice Web client relies exclusively on these APIs, and has more functionality than the Windows user and administration clients, the capability of the web service APIs should never be considered inferior. The web service APIs should be given serious consideration for nearly all scenarios.

## Integration Scenarios by Platform

To gain a better understanding of what types of integrations are possible, the remainder of this article is going to discuss each SuperOffice client and NetServer to help clarify which integration approach is best for your specific needs.

### Window Client

A flagship CRM platform, the SuperOffice CRM client has been the leading SuperOffice CRM product since 1989. SuperOffice CRM was created to support the needs of the sales person by making his everyday life easier – and make it so user-friendly and elegant that the user would want to use it.

The Windows client exposes many hooks that make it easy for vendors to create a seamless experience with their applications. Integrations have full-duplex type communications, providing integrations the ability to receive notifications when users perform actions, immediately process the data concerned, and even switch the user's context and show important relevant information related to that action.

**Integration Points:**

* COM API
* Automation Engine (vbScript and JScript scripts)
* Event Subscriptions (internal scripts and external COM subscriptions)
* Web Panels
* Buttons to launch external applications
* Document Plugin (NetServer based since version 8)
* Sentry Plugin (COM)
* Email Plugin (COM)

**Related SDK**:

* [IApplicationCOM API][5]
* [IDatabaseCOM API][6]

### Web Client (On-Site)

Available since 2007, the SuperOffice Web client has enjoyed a wide-spread adoption by many on-site customer installations. The product has several advantages over the Windows client. For example, customers can install SuperOffice on a web server that is accessible both near and far without having to pay extra license fees for disconnected functionality such as Travel, or incure the extra maintenance costs for maintaining Travel Gateway and the processing of .up and .dwn files.

SuperOffice CRM Web also enjoys many integration capabilities. I would go so far as to say that it is the most extensible CRM platform available today! With the ability to modify and adapt the user's experience, manipulate the data processing and logic, nearly every component in the SuperOffice CRM Web stack is over-ridable and extensible for complementary functionality or control.

**Integration Points:**

* Add controls to existing pages
* Add custom dialogs
* Override default functionality and inject custom logic into
  * DataHandlers (create, update, delete of page data
  * Archive Providers (read-only search providers
  * Most buttons
* Add custom views (tabs or preview pane options)
* Add web panels

**Related SDK**:

* [Web Client SDK][5]

### Web Client (Online)

Both SuperOffice on-site installations and CRM Online applications use the same NetServer web service APIs. The only difference between the two environments is how integrations are authenticated. While on-site integrations have a more direct approach, supplying credentials, CRM Online integrations must use [federated authentication][8].

Federated authentication is a way SuperOffice can provide a single sign-in experience for multi-tenant users and applications that serve multi-tenant installations.

The SuperOffice CRM Online environment hosts an app store with several partner integrations. These integrations are comprised of Business to Consumer (B2C) applications. Most applications expose functionality inside SuperOffice by adding web panels in relevant areas, while others add a button that opens a web page to the application. All application vendors have their own cloud platforms to manage customers and tenant users.

You can find out more information about CRM Online integration points by reading the CRM Online SDK pages.

**Integration Points (Online)**:

* Custom Lists
* Custom List Items
* User-defined Fields
* Web Panels
* Custom buttons (navigator and button bar)
* Access to Web Services, including webhooks (see NetServer Architecture below).

**Related SDK**:

* [CRM Online SDK][9]

### Customer Service

There are several articles available that explain in detail many of the internal automation integration points provided by SuperOffice CS. There are not, however, too many external integration points to discuss. The ones that do exist are primarily the CS legacy [SOAP services][11]. It must be said that these services have not evolved for quite some time, and do not appear to be on any road map. That said, there are a few major installations that do leverage these endpoints, and therefore they are not likely to fade away any time soon either. Similar to the Windows client COM APIs, these APIs are in the future not likely to change.

There are no prebuilt SuperOffice proxies available for these APIs. You must use a proxy generator appropriate for your target technology platform, or use raw SOAP requests, to use these services.

**Integrations Points:**

* SOAP Services (**Not available in Online**) (available at `http://<domain>/scripts/SOAP.exe?action=<endpoint>`. Available action parameters:
  * customer
  * ticket
  * admin

**Related SDK**:

* [Customer Service][11]

### NetServer Architecture

All SuperOffice clients, in one form or another, depend on NetServer for database access. While each client has its own extensibility points, NetServer also has extensibility points. Some of NetServer extensibility options surface to the clients, such as the Document Plug-in.

As a multi-tiered database access layer that bridges communications between clients and the SuperOffice database, NetServer uses database-independent database access code, as well as high-level web services for both the SuperOffice Web and PocketCRM clients.

**NetServer conceptual overview:**

![x][img4]

[The lowest layer of NetServer][12], the domain-level development APIs, are generally used by a client or application server. This layer does the heavy lifting and is responsible for marshaling all the model-based data into raw SQL.

Listed below are the different aspects of NetServer core APIs.

* OSQL: Low-level, high-performance, database-independent objectified SQL.
* Rows and Rows: Medium-level data table and data row-level access
* Entities: High-level business model classes that abstract multiple table joins.
* Archive and MDO Providers: provide complex search capabilities across the entire database.

[The highest level of NetServer][13] data access is the service-orientated architecture and consists of:

* Web service endpoints based on WCF **SOAP** and **REST**ful WebAPI: IIS application used by SuperOffice Web and PocketCRM.
* Web service proxies: Service agent pattern .NET assemblies used by clients to access the service endpoints.

An important aspect of NetServer web service development is its deployment flexibility. It's capable of being embedded in a domain-centric fat client application, as well as a thin client deployed with NetServer service proxies for data access across the internet.

**Webhooks** are supported at both the low and high levels of NetServer.

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services. Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer. SuperOffice only supplies .NET proxy assemblies. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

**Integration Points (Low Level):**

1. Document Plugin.
2. Sentry Plugin.
3. Add or override archive providers.
4. Add or override resources providers.
5. Multiple levels of database access.

**Integration Points (High Level):**

* [Webhooks][15]
* [SOAP][11]
* [REST][17]

Related SDK:

* [NetServer Core SDK][18] (long loading time)
* [NetServer Web Services][19]

## Conclusion

Whether constructing a small internal automation routine or building a complex integration, SuperOffice has many integration options. Once you get past the problem of knowing with which SuperOffice platforms you are integrating, it becomes a matter of just choosing the right API for your solution.

With the understanding that each SuperOffice platform provides a lot of integrations points, and knowing that any problem can have multiple solutions, it's important to consider all options before you decide which approach to take. Assistance and guidance are available. Please use the [developer forums][20] to ask for recommendations, or you may submit integration questions directly to SuperOffice at [sdk@superoffice.com][21].

Read more about each platform API in the SDK documentation.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/forum/?clubId=3
[2]: https://msdn.microsoft.com/en-us/library/aa227633(v=vs.60).aspx
[5]: https://community.superoffice.com/documentation/SDK/SO.Application/html/top_home.htm
[6]: https://community.superoffice.com/documentation/SDK/SO.Database/html/top_home.htm
[8]: ../authentication/online/federated-auth.md
[11]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/soap/reference/index.md
[12]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/services/ns-web-services/what-is-netserver-part-2.md
[13]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/services/ns-web-services/what-is-netserver-part-1.md
[15]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/automation/webhook/index.md
[17]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/web-api/rest/reference/index.md
[18]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/index.md
[19]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/services/index.md
[20]: https://community.superoffice.com/en/developer/forum/
[21]: mailto:sdk@superoffice.com

<!-- Referenced images -->
[img1]: media/scriptingapibysuperofficeplatform.png
[img2]: media/automationcapabilitiesbyplatform.png
[img3]: media/targetapibysuperofficecrmplatform.png
[img4]: media/netserverarchitecture-blue-650.png
