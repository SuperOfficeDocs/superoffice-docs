---
title: SuperOffice Authentication
uid: authentication_overview
description: Overview of SuperOffice API authentication.
author: AnthonyYates
so.date: 05.08.2018
keywords: security, identity
so.topic: concept
so.envir: onsite, online
# so.client:
---

# SuperOffice Authentication

SuperOffice supports several different access points to SuperOffice APIs. Without knowing where to begin, it makes it almost impossible to successfully build an integration. The first place most applications must begin with is authentication, Once authentication is understood, and understanding at what data access level your application will integrate with SuperOffice, the remaining tasks should just be learning about the various entity and service APIs for reading and writing data to the SuperOffice database.

## Introduction

One of the hardest things about getting started with new technologies is knowing where to begin. When it comes to application development and integrations, the obvious place is authentication.

SuperOffice has multiple data access layers, so let's start with an overview of what the SuperOffice APIs have to offer.

## Overview of common SuperOffice API surface

![auth][img1]

SuperOffice **COM APIs** have been around the longest. The 2 main interfaces, **IApplication** and **IDatabase**, facilitate access to the Windows client application and the database. While `IApplication` exposes the capabilities to drive the application, `IDatabase` provides the capability to read and write to and from the SuperOffice database without having the Windows client running.

While SuperOffice Customer Service (CS) capabilities are vast, most of the functionality revolves around processing support tickets and internal processes using script automation. The CS SOAP services are limited, whereas the NetServer web services surface is much larger and the primary target for interacting with SuperOffice business entities. This article will not cover any more information about CS.

SuperOffice **NetServer SOAP web services** are a complete set of service endpoints that support 100% of the SuperOffice web-client functionality - which is more than the Windows client and COM could ever claim. CS depends on NetServer web services, as well as all the quote functionality in the Window client!

NetServer code, comprised of business entity classes as well as row & row collections, supports the entire web services stack. All of this functionality gets pushed through NetServer's [Objectified SQL (OSQL)][2] classes for database-vendor-specific SQL generation.

### Reading advice

The objective of the below is to introduce you to how to get past the first hurdle, authentication. All of the following sections assume you have access to a correctly configured SuperOffice database. Each section will define all of the dependencies required to be in place for you to be able to successfully authenticate with the corresponding API.

> [!NOTE]
> The development environment used in these examples is Visual Studio and the language used C#.
>
> If you don't have one of the SuperOffice clients installed (Windows or Web), you will want to **download the Expander SDK** to have the necessary DLLs and COM interop libraries to complete the code examples below. The latest available for download at the time of this article was SuperOffice 7.5.

## Options

* [SuperOffice Online][3]
* [COM][6]
* [NetServer Core & Service proxy authentication using SoSession][7]
* [SuperOffice REST / WebAPI web services][8]
* [NetServer web service custom proxies][9]

## NetServer configuration

All NetServer integrations **that use SuperOffice assemblies** require settings in an application's configuration file, *app.config* or *web.config*.

Having connection issues? Check the [Data element][1].

You might also be interested in:

* [Configuring the anonymous user][4] (deprecated in version 9)
* [Configuring the external user][5]

<!-- Referenced links -->
[1]: onsite/netserver-config.md
[2]: ../netserver/osql/index.md
[3]: ../../../superoffice-docs/docs/identity-management/federated-auth.md
[4]: onsite/config-anonymous-user.md
[5]: onsite/config-external-user.md
[6]: onsite/com/index.md
[7]: onsite/sosession/index.md
[8]: webapi/index.md
[9]: onsite/custom-proxies/index.md

<!-- Referenced images -->
[img1]: media/authenticate-overview.png
