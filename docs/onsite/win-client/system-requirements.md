---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: win_client_system_requirements # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for SuperOffice Win client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: win                  # online, web, win, pocket, or mobile
---

# System requirements for SuperOffice Win client

These apply to computers running the Sales, Marketing, and Service clients.

[!include[Warning legacy](../includes/warn-win-client-discontinued.md)]

## Processor

* Intel ® 1.8Ghz (x86) or (x64)
* AMD™ 1.8 Ghz (x86) or (x64)

## Memory

* 2 GB

## Operation system

* Microsoft Windows 10, minimum Anniversary update
* Microsoft Windows 8.1 (32bit) or (64bit)

## Network

* TCP/IP-network with less than 10 ms response time

## Screen

* Minimum screen resolution 1280 x 960

## Database - Travel (offline)

* Microsoft SQL Server 2014 Express
* Microsoft SQL Server 2008/2008 R2 Express
* Sybase 12 (Built-in or Standalone)

> [!NOTE]
> For Microsoft SQL Server, the computer generating the prototype must support the client's version of SQL Express.

## Browsers - Web panels

* Microsoft Edge
* Internet Explorer 11
* Chrome Win
* Firefox 20+ Win
* Chrome Mac
* FireFox Mac
* Safari Mac

## Microsoft Office (x86 and x64)

* Microsoft 365 for Business
* Microsoft Office 2019
* Microsoft Office 2016
* Microsoft Office 2013
* Microsoft Office 2010

## SuperOffice MailLink

Windows operating system only.

* Outlook 365 Click-to-run
* Outlook 2019
* Outlook 2016
* Outlook 2013
* Outlook 2010
* Lotus Notes 10
* Lotus Notes 9

## SuperOffice Ribbons

* Microsoft Office 2019
* Microsoft Office 2016
* Microsoft Office 2013
* Microsoft Office 2010

## WebTools

To run WebTools with Web Extensions and MailLink, the client is required to have Microsoft .Net Framework 4.5.1 (full).

### TSL

If you are running SuperOffice WebTools and SSL, please upgrade to SuperOffice 8.0 SR1 to avoid using TLS 1.0. NetServer used by Pocket CRM still needs TLS 1.0 up till version 8.0.32 (R14) client, released August 15th, 2016.

## Requisites installed by client installer

* **Microsoft .NET v 4.8 from 8.5 R05**
* Microsoft .NET v 4.7.1 from 8.3 R04
* Microsoft .NET v 4.5.1 (as a web download)

* VSTO 2010 runtime (32bit or 64bit) for Ribbons on MS Office 2010 / 2013 / 2016 / 2019
* Visual C++ 2017 runtime for x86 (version 14.14.26429.4)
* Reporter runtime (version 9.0.30729.17)

> [!NOTE]
> When running SuperOffice in a Citrix and Terminal server environments where users share the memory, actual requirements and product functionality may vary based on your system configuration.

> [!TIP]
> Enable Clear Type Text on all clients running the CRM Win app for the best user experience.

### Microsoft .NET v 4.8 from SuperOffice 8.5 R05 and 9

[!include[.NET v 4.8 required](../includes/req-dotnet-4-8.md)]

### Microsoft .NET v 4.7.1 required from SuperOffice 8.3 R04

[!include[.NET v 4.8 required](../includes/req-dotnet-4-7-1.md)]
