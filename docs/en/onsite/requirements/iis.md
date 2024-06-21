---
title: Requirements
uid: iis_server_requirements
description: System requirements for SuperOffice server
author: {github-id}
date: 09.12.2023
keywords:
topic: reference
envir: onsite
# client:
---

# System requirements for SuperOffice server hosting IIS

This server is used for SuperOffice S&M Web client, SuperOffice Service, SuperOffice Mailings, and SuperOffice Audience.

## Processor

* Intel 3.0 GHz Dual or Quad Core (x86) or (x64)
* AMD 3.0 GHz Dual or Quad Core (x86) or (x64)

## Memory

* 3 GB

## Operating system

* Microsoft Windows Server 2022
* Microsoft Windows Server 2019
* Microsoft Windows Server 2016

## Internet Information Server

* Microsoft IIS 10
* Microsoft IIS 8.5

## Network/Bandwidth

The preferred bandwidth for the web servers is 1 Mbit/sec for all installations up to 50 users. We estimate the individual user’s bandwidth consumption to add up to an average of 20 Kbit/sec.

## Mail servers

* Exchange Server 2010 64bit and newer
* Domino Server 10.0
* Domino Server 9.0
* MAPI/SoMaGate (Win client only)

## Built-in mail client

For the built-in mail client, the following ports must be opened between the Sales & Marketing web server and the mail server:

[!include[Mail client ports](../includes/mail-client-ports.md)]

## Requisites

[!include[.NET Requirements](../includes/dotnet-requirements.md)]

* Windows communication foundation (on both the server running Sales & Marketing web and the server running NetServer web services)
* Local administrator rights (installation)

> [!NOTE]
> Audience does not support remote web services and must use the web services installed with the product.

[Read more about Microsoft .NET requirements][1]

<!-- Referenced links -->
[1]: index.md
