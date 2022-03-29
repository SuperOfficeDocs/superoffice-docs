---
uid: netserver-web-services-overview
title: NetServer web services
description: "The SuperOffice web services are the highest level for working with NetServer."
author: Bergfrid Dias, AnthonyYates
so.date: 03.28.2022
keywords: API, web services, endpoints, proxy, NetServer, SOAP, REST, Agent, SuperOffice.CRM.Services, DTO, carrier
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# Web services

When you are calling a web service, you usually **don’t have direct access to the database**.

The objective of the NetServer web services is to provide a simple yet powerful API to access SuperOffice CRM functionality.

The web services let you work with the database without having to know the details of how data is stored inside the database. The service layer presents a high-level API where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

All SuperOffice CRM Online applications depend on NetServer web services for database access.

## NetServer web services

[NetServer][3] has many API layers to access SuperOffice data, with web services at the top of the API stack.

Each SuperOffice installation exposes web services for all clients, including SuperOffice Web, SuperOffice Mobile, and partner application clients.

Each web service 

![NetServer Architecture][netserver-architecture]

WSDL files for all versioned endpoints are [available for download][12] in the reference section, or as individual files on each endpoint reference page.

**Download All**
![Download all WSDLs][wsdl-all]

**Download Single**
![Download all WSDLs][wsdl-single]


## Endpoints concept

A service endpoint is primarily **a method** exposed by the NetServer to manipulate the data or enhance the presentation of the data in the SuperOffice database.

![SuperOffice.Services vs. web services diagram][img2]

NetServer has many service endpoints to support the entire SuperOffice platform.

![NetServer web services endpoint listing][img1]

## Supported protocols

SuperOffice supports two distinct forms of web services:

1. SOAP ([reference][12])
2. REST ([reference][13])
   * Two distinct flavors:
     * 1. RESTful ([reference][8])
     * 2. Agent ([reference][7])

### SOAP web service resources

NetServer SOAP web services implement the Service Agent pattern, exposing areas of SuperOffice as endpoints, i.e. Appointment and Project, and each endpoint has a list of methods that when invoked facilitate data transfer of Data Transfer Objects (DTOs). SuperOffice calls DTOs `Carriers`.

Read more about: [SOAP Services][2].

#### Nuget package

There is one nuget package for .NET developers:

[SuperOffice.NetServer.Services (SOAP)][6] 
  * View [API reference][16].

### REST web service resources

NetServer REST web services come in two _flavors_, Agent REST and [common] REST and are distinct in use. 

The primary difference is that, unlike most common REST APIs that use GET, PUT, POST, DELETE and PATCH methods, Agent endpoints are all POST requests. Agent endpoints are also named and used just like their SOAP web service endpoint counterparts, i.e. naming conventions similar to classes and methods.

1. Read more about: [RESTful API][15]
2. Read more about: [Agent API][14]

Here you can find OpenAPI / Swagger files for available for download for each REST flavor. They are also available for download at the bottom of each page link above, respectively.

* [Download RESTful API file][17]
* [Download Agent API file][18]

#### Nuget package

There is one nuget package for .NET developers. For it's initial release, this package exposes the same Agent API as the SOAP proxy, making it an easy transition for vendors currently using the [SOAP proxy][]:

[SuperOffice.WebApi (RESTful Agent)][11]

* [reference][9])

## Restricted agents

The following agents are not available in Online by default. Access must be requested specifically when an app is registered.

* CRMScriptAgent
* EMailAgent
* ErpSyncAgent
* MessagingAgent
* ReplicationAgent
* UserAgent
* WebhookAgent

## Required web service license

Access to the web services is included in your [Developer Tools][4] subscription.


<!-- Referenced links -->
[1]: ../entities/index.md
[2]: endpoints/soap/index.md
[3]: ../overview/netserver.md
[4]: ../../admin/license/expander-services/tool-box.md
[5]: proxies/index.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: ../reference/restful/rest/index.md
[8]: ../reference/restful/agent/index.md
[9]: ../reference/webapi/index.md
[10]: ../rows/index.md
[11]: https://www.nuget.org/packages/SuperOffice.WebApi
[12]: ../reference/soap/index.md
[13]: ../reference/restful/index.md
[14]: endpoints/agents-webapi/index.md
[15]: endpoints/rest-webapi/index.md
[16]: ../reference/netserver/services/index.md
[17]: ../../assets/downloads/api/Swagger-v1-REST.zip
[18]: ../../assets/downloads/api/Swagger-v1-Agents.zip

<!-- Referenced images -->
[img1]: media/netserver-web-services.png
[img2]: media/sm-serviceinterfaces.png
[netserver-architecture]: media/netserver-architecture.png