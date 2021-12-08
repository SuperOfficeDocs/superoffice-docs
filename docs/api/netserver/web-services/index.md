---
uid: netserver-web-services-overview
title: NetServer web services
description: The SuperOffice web services are the highest level for working with NetServer. This layer consists of endpoints based on WCF SOAP and RESTful WebAPI and web service proxies.
author: Bergfrid Dias
so.date: 12.02.2021
keywords: API, web services, endpoints, proxy, NetServer, SOAP, REST, Agent, SuperOffice.CRM.Services, DTO, carrier
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# SuperOffice NetServer web services

[NetServer exposes many layers][3] of its API to do the same functionality. The web services are the highest level for working with NetServer. This layer consists of [web service endpoints][2] based on WCF **SOAP** and **REST**ful WebAPI (IIS application) and [web service proxies][5].

Each installation and online tenant exposes NetServer web services for all clients, including SuperOffice Web, SuperOffice Mobile, and partner application clients.

> [!NOTE]
> The SuperOffice.NetServer.Services layer should not be confused with the web services available in the installation directory: [InstallBase]\Remote\ServicesXX. SuperOffice.NetServer.Services is a **consumer** of these web services, whereas the web services are hosted in IIS. The layer is a **client proxy** to the NetServer web services and greatly simplifies what is required to call them.

![SuperOffice.Services vs. web services diagram][img2]

## Why use web services?

When you are calling a web service, you usually **don’t have direct access to the database**.

The objective of the NetServer web services is to provide a simple yet powerful API to access SuperOffice CRM functionality.

The web services let you work with the database without having to know the details of how data is stored inside the database. The service layer presents a high-level API where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

All SuperOffice CRM Online applications depend on NetServer web services for database access. NetServer access in our online environment is achieved by using either REST or SOAP web services.

## What is a service?

A service is primarily **a method** exposed by the NetServer to manipulate the data or enhance the presentation of the data in the SuperOffice database.

![NetServer web services endpoint listing][img1]

A typical service call looks like this when using the NetServer helper classes:

```csharp
using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))
{
  SuperOffice.Services.ContactAgent contactAgent = new SuperOffice.Services.ContactAgent();

  ContactEntity contactEntity = contactAgent.CreateDefaultContactEntity();

// ... populate contact properties

  contactAgent.SaveContactEntity(contactEntity);
}
```

## <a name="agents"></a>Agent and carrier pattern

SuperOffice has created a set of objects based on the **Agent pattern** that will perform your work for you. The goal of the pattern is to make it clear when you are making potentially expensive service calls.

All services are called through an agent that is designed to handle a specific **business area**.

An **agent** is a class that exposes a set of methods. All agents live in the **SuperOffice.CRM.Services namespace**. A typical agent has methods for inserting, retrieving, updating, and deleting data. Each method on the agent corresponds to one service call.

```csharp
ContactAgent newConAgt = new ContactAgent();
```

The code segment above shows how we create a `ContactAgent`. Once the agent has been created, we can use it to access the different methods exposed by the agent. These methods would vary according to the agent created.

A **carrier** is a data transfer object **(DTO)** that carries data between the Agent and the NetServer services. There are two kinds of carriers: simple read-only carriers and complex entity carriers. The main difference is that entity carriers can be updated and sent back for saving to the database while read-only carriers cannot be saved back to the database.

### Read-only carriers

A read-only carrier is a **simple, slim object**. It exposes its properties primarily as string values or ID values correlating to the ID field in the corresponding table. For example:

* The `country` property is exposed as a country name and not as a country sub-object.
* The `Person.ContactId` property is of type integer and correlates to the `contact_id` field in the `Contact` table.

The advantages this DTO type are its **simplicity** and that you avoid the overhead that comes when working with full-blown entities.

Below is an example that shows how to load a read-only carrier using an Agent.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
Contact myContact = contactAgent.GetContact(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.CategoryName;
string myContactWebUrl = myContact.URL;
```

Here, the `ContactAgent` will return a `Contact` object through the `GetContact` method.

### Entity carriers

An entity carrier is an [entity][1] object. Unlike read-only carriers, these DTOs expose their properties as objects populated with more **detailed data**. For example, the `PersonEntity.Contact` contains all relational information about the corresponding contact - including name, address, contact ID, phone collection, and more.

The example below shows how to retrieve a `ContactEntity` object through the `GetContactEntity` method of the `ContactAgent`.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
ContactEntity myContact = contactAgent.GetContactEntity(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.Category.Value;
string myContactWebUrl = myContact.Urls.Length > 0 ? myContact.Urls[0].Value : "";
```

To summarize: **The agent presents the services and the carrier (such as Person and PersonEntity) represents the data passed back and forth to the server.** Agents are used to execute actions by calling methods.

Entity carriers resemble [NetServer Core Entities][1]. In contrast, read-only carrier are more similar to [NetServer Core Rows][10].

## Calling a web service

Access to the web services is included in your [Developer Tools][4] subscription.

You have the option to:

* Use NetServer Proxies ([NuGet packages][6])
* Generate a [custom proxy][5]
* Use the [WebAPI client][9]
* Use RESTful [WebAPI endpoints][7]
* Use RESTful [Agent endpoints][8]

<!-- Referenced links -->
[1]: ../entities/index.md
[2]: endpoints/index.md
[3]: ../index.md
[4]: ../../../../superoffice-docs/docs/license/expander-services/tool-box.md
[5]: proxies/index.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: ../../api-reference/restful/rest/index.md
[8]: ../../api-reference/restful/agent/index.md
[9]: ../../api-reference/webapi/index.md
[10]: ../rows/index.md

<!-- Referenced images -->
[img1]: media/netserver-web-services.png
[img2]: media/sm-serviceinterfaces.png
