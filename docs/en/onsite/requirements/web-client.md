---
title: Client requirements
uid: client_requirements
description: Client requirements for SuperOffice Web and Win
author: {github-id}
date: 09.12.2023
keywords:
topic: reference
envir: onsite
client: web
---

# Client requirements for SuperOffice Web and Win

These apply to computers running the Sales, Marketing, and Service clients.

[!include[Warning legacy](../includes/warn-win-client-discontinued.md)]

## Processor

* Intel 1.8 GHz (x86) or (x64)
* AMD 1.8 GHz (x86) or (x64)

## Memory

* 2 GB

## Operating system

* Microsoft Windows 11
* Microsoft Windows 10, minimum Anniversary Update (version 1607)
* Mac - Web client only

> [!NOTE]
> SuperOffice CRM Web will run on Mac, though with some limitations: cross table reports not supported.

## Network

* TCP/IP-network with less than 10 ms response time

## Screen

* Minimum screen resolution 1280 x 960

## Browsers - Web panels

* Microsoft Edge
* Chrome Win
* Firefox Win
* Chrome Mac
* FireFox Mac
* Safari Mac

## Microsoft Office (x86 and x64)

* Microsoft 365 for Business
* Microsoft Office 2021
* Microsoft Office 2019
* Microsoft Office 2016

## SuperOffice MailLink

Windows operating system only

* Outlook 365 Click-to-run
* Outlook 2021
* Outlook 2019
* Outlook 2016

## SuperOffice Ribbons

SuperOffice Win client only

* Microsoft Office 2021
* Microsoft Office 2019
* Microsoft Office 2016

## WebTools

* [System requirements][2]

### TSL

If you are running SuperOffice WebTools and SSL, please upgrade to SuperOffice 8.0 SR1 to avoid using TLS 1.0. NetServer used by Pocket CRM still needs TLS 1.0 up until version 8.0.32 (R14) client, released August 15th, 2016.

## Database - Travel (Win only)

* Microsoft SQL Server Express
* Sybase 12 (Built-in or Standalone)

> [!NOTE]
> For Microsoft SQL Server, the computer generating the prototype must support the client's version of SQL Express.

## Requisites installed by the client installer

[!include[.NET Requirements](../includes/dotnet-requirements.md)]

* VSTO 2010 runtime (32bit or 64bit) for Ribbons on Microsoft Office 2010 / 2013 / 2016 / 2019
* Visual C++ 2017 runtime for x86 (version 14.14.26429.4)
* Reporter runtime (version 9.0.30729.17)

> [!NOTE]
> When running SuperOffice in Citrix and Terminal-server environments where users share the memory, actual requirements, and product functionality may vary based on your system configuration.

[Read more about Microsoft .NET requirements][1]

> [!TIP]
> Enable Clear Type Text on all clients running the CRM Win app for the best user experience.

<!-- Referenced links -->
[1]: index.md
[2]: ../../webtools/system-requirements.md
