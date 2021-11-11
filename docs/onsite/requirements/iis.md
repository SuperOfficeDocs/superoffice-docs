---
title: Requirements
uid: iis_server_requirements
description: System requirements for SuperOffice 8, 9 and 10 server
author: {github-id}
keywords:
so.topic: reference
so.envir: onsite
# so.client:
---

# System requirements for SuperOffice 8, 9 and 10 server hosting IIS

This server is used for SuperOffice S&M Web client, SuperOffice Service, SuperOffice Mailings, and SuperOffice Audience.

## Processor

* Intel ® 3.0Ghz Dual or Quad Core (x86) or (x64)
* AMD™3.0Ghz Dual or Quad Core (x86) or (x64)

## Memory

* 3 GB

## Operating system

* Microsoft Windows Server 2019
* Microsoft Windows Server 2016
* Microsoft Windows Server 2012 R2
* Microsoft Windows Server 2012

## Internet Information Server

* Microsoft IIS 10
* Microsoft IIS 8.5
* Microsoft IIS 8.0

## Network/Bandwidth

The preferred bandwidth for the web servers is 1 Mbit/sec for all installations up to 50 users. We estimate the individual user’s bandwidth consumption to add up to an average of 20 Kbit/sec.

## Mail servers

* Exchange Server 2010 64bit and newer
* Domino Server 10.0
* Domino Server 9.0
* MAPI/SoMaGate (Win client only)

## IMAP

* Port 143 or 993 (SSL) must be opened between the Sales & Marketing web server and the mail server

## SMTP

* Port 25 or 465 (SSL) must be opened between the Sales & Marketing web server and the mail server

## Requisites

* **Microsoft .NET v 4.8 from SuperOffice 8.5 R05 and newer**
* Microsoft .NET v 4.7.1 from SuperOffice 8.3 R04
* Microsoft .NET v 4.5.1 (as a web download)
* Windows communication foundation (on both the server running Sales & Marketing web and the server running NetServer web services)
* Local administrator rights (installation)

> [!Note]
> Audience does not support remote web services and must use the web services installed with the product.

[Read more about Microsoft .NET requirements][1]

<!-- Referenced links -->
[1]: index.md
