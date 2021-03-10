---
title: ns_web_services       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# About NetServer web services

All SuperOffice CRM Online applications depend on NetServer web services for database access.

NetServer is a multi-tiered database access layer that bridges communication between clients and the SuperOffice database.

NetServer access in our online environment is achieved by using either REST or SOAP web services.

## Architecture

Each tenant exposes NetServer web services for all clients, including SuperOffice Web, PocketCRM, and partner application clients. The web services are bundled in your Expander Services subscription.

![OnlineArrangement.png][img1]

## Service-orientated data access

The highest level of NetServer data access consists of web service endpoints and web service proxies.

### WCF **SOAP** and **REST**ful WebAPI endpoints

This is where you find the IIS application used by SuperOffice Web and PocketCRM.

Which API is right for your situation? Read [Online Development - What API to Use][3] to understand the implications to determine which is best for you.

### Web service proxies

For SOAP-base clients, NetServer .NET assemblies use a service agent pattern to work with business entities used by clients to access the service endpoints. These are available as [NuGet packages][4]

## Calling web services

One call to the web services can hide or include multiple database queries, business logic, user-preference checks, and default handling. For SuperOffice CRM Online, you have the option to:

* use NetServer Proxies ([NuGet packages][4])
* generate a custom proxy by adding a web service
* use RESTful [WebAPI endpoints][5]
* use RESTful [Agent endpoints][6]

Your application is not allowed to place .net assemblies in a tenant web application and must use the web services for all interactions.

<!-- Referenced links -->
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/what-api-to-use.md
[4]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[5]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-REST-REST.htm
[6]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-WebAPI-Agents-Agents.htm

<!-- Referenced images -->
[img1]: media/onlinearrangement.png
