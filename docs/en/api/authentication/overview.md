---
title: SuperOffice Authentication
uid: authentication_overview
description: Overview of SuperOffice API authentication.
author: AnthonyYates
date: 05.08.2018
keywords: security, identity
content_type: concept
deployment: online, onsite
redirect_from:
  - /en/authentication/index
  - /en/authentication/overview
# Including redirect_from the subcategory since we can't set redirect_from in index.yml
---

# SuperOffice Authentication

SuperOffice supports several different access points to SuperOffice APIs. Without knowing where to begin, it makes it almost impossible to successfully build an integration. The first place most applications must begin with is authentication, Once authentication is understood, and understanding at what data access level your application will integrate with SuperOffice, the remaining tasks should just be learning about the various entity and service APIs for reading and writing data to the SuperOffice database.

## Introduction

One of the hardest things about getting started with new technologies is knowing where to begin. When it comes to application development and integrations, the obvious place is authentication.

SuperOffice has multiple data access layers, so let's start with an overview of what the SuperOffice APIs have to offer.

## Overview of common SuperOffice API surface

![auth][img1]

SuperOffice **COM APIs** have been around the longest. The 2 main interfaces, **IApplication** and **IDatabase**, facilitate access to the Windows client application and the database. While `IApplication` exposes the capabilities to drive the application, `IDatabase` provides the capability to read and write to and from the SuperOffice database without having the Windows client running.

SuperOffice **Customer Service** (CS) capabilities are vast, but most functionality revolves around processing support tickets and in-product automation tools. External API access is very limited, and what is there is considered legacy and obsolete. We recommend NetServer web services, which has a much larger API footprint that provides complete SuperOffice access. Therefore, CS is not mentioned in this article, but if interested read up on [automation tools][11] to learn more about CS and other in-product automation features.

SuperOffice **NetServer SOAP web services** are a complete set of service endpoints that support 100% of the SuperOffice web-client functionality. Both the CS and Windows client depend on NetServer web services as well.

At NetServers' core are business entity and table row collections. They provide easy intuitive APIs for data access which most of web services depend on. What services don't use entity and row collections leverage NetServer's [Objectified SQL (OSQL)][2] classes for fast DB access, and is responsible for generating the database-vendor-specific SQL.

### Reading advice

The objective here is to introduce you to the APIs and help get you past the first hurdle, authentication. All of the following sections assume you have access to an onsite SuperOffice database or online tenant. Each section defines the dependencies required to successfully authenticate with the corresponding API.

## Options

* [About SuperOffice Online Identity Provider][3]
  * [How to authenticate using OAuth 2.0 / OpenID Connect][16]
* [SuperOffice REST / WebAPI web services][8]
* [NetServer web service custom proxies][9]
* [NetServer Core & Service proxy authentication using SoSession][7]
* [COM][6]

## NetServer configuration

All integrations that use one of the following nuget packages require an [application configuration file][10], *app.config* or *web.config*.

* SuperOffice.NetServer.Core
* SuperOffice.NetServer.Services

This is not the case for integrations that use the [SuperOffice.WebApi][8] nuget package, or generate their own web service proxies from [SOAP WSDL][13] or [REST Swagger][14] files.

> [!WARNING]
> The database connection settings are defined in the [Data element][1] of the application configuration. This is often the cause of connectivity issue, so if necessary consult the [NetServer configuration docs][15] to better understand those settings.

You might also be interested in:

* [Configuring the anonymous user][4] (deprecated in version 9)
* [Configuring the external user][5]

<!-- Referenced links -->
[1]: ../config/data.md
[2]: ../osql/index.md
[3]: ../../online/identity/federated-auth.md
[4]: onsite/config-anonymous-user.md
[5]: onsite/config-external-user.md
[6]: onsite/com/index.md
[7]: onsite/sosession/index.md
[8]: ../web-services/webapi/index.md
[9]: onsite/custom-proxies/index.md
[10]: ../config/index.md
[11]: ../../automation/overview.md
[13]: ../reference/soap/index.md
[14]: ../web-services/endpoints/index.md
[15]: ../config/index.md
[16]: ../authentication/online/index.md

<!-- Referenced images -->
[img1]: media/authenticate-overview.png
