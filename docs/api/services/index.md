---
title: services       
description: SuperOffice NetServer services
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
---

# SuperOffice NetServer services

A service is primarily a method exposed by the NetServer to manipulate the data or enhance the presentation of the data in the SuperOffice database. In the NetServer the services infrastructure has been built using the [agent][1] and [carrier][2] software patterns. **The agent object presents the services and the carrier object represents the data passed back and forth to the server by the agent, depending on the configuration.**

All SuperOffice CRM Online applications depend on NetServer web services for database access. NetServer is a multi-tiered database access layer that bridges communication between clients and the SuperOffice database. NetServer access in our online environment is achieved by using either REST or SOAP web services.

All the services are called through an agent that is designed to handle a specific business area, for example, there will be a dedicated agent to handle the services intended for the sales area. All the agents live in the `SuperOffice.CRM.Services` namespace.

## Objective

The objective of the NetServer services is to provide a simple yet powerful API to access SuperOffice CRM functionality. The service API lets you work with the database without having to know the details of how data is stored inside the database. It presents a high-level API where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

## SoSession

A session retrieves data regarding the currently logged-in user and keeps them in the cache. Session Cache holds authentication information about the logged-in user, associate of the user, business ID of the company that the user belongs to, reference data, and many more. Each time a new user logs in a session is created.

* [Create session][3]
* [Suspend session][4]

## Architecture

Each tenant exposes NetServer web services for all clients, including SuperOffice Web, PocketCRM, and partner application clients. The web services are bundled in your Expander Services subscription.

![OnlineArrangement.png][img1]

## Service-orientated data access

The highest level of NetServer data access consists of web service endpoints and web service proxies.

### WCF SOAP and RESTful WebAPI endpoints

This is where you find the IIS application used by SuperOffice Web and PocketCRM.

Which API is right for your situation? Read [Online Development - What API to Use][5] to understand the implications to determine which is best for you.

### Web service proxies

For SOAP-based clients, NetServer .NET assemblies use a service agent pattern to work with business entities used by clients to access the service endpoints. These are available as [NuGet packages][4]

## Calling web services

One call to the web services can hide or include multiple database queries, business logic, user-preference checks, and default handling. For SuperOffice CRM Online, you have the option to:

* use NetServer Proxies ([NuGet packages][6])
* generate a custom proxy by adding a web service
* use RESTful [WebAPI endpoints][7]
* use RESTful [Agent endpoints][8]

Your application is not allowed to place .net assemblies in a tenant web application and must use the web services for all interactions.

<!-- Referenced links -->
[1]: agents/index.md
[2]: carriers/index.md
[3]: ../authentication/session-handling/create-session.md
[4]: ../authentication/session-handling/suspend-session.md
[5]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/what-api-to-use.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-REST-REST.htm
[8]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-Agents-Agents.htm

<!-- Referenced images -->
[img1]: media/onlinearrangement.png
