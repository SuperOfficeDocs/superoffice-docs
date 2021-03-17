---
title: web_application_specs
description: Web GUI .Net API technical details
author: {github-id}
so.date:
keywords:
so.topic: reference
so.client: web
so.envir: onsite
---

# Technical information

## Security

SuperOffice can be configured to run everything on the web server. This requires that the web server has direct access to the database, which can be dangerous. In a high-security setup, the web server is placed in a DMZ with direct access from the internet. The database server will then be placed inside your internal network, along with the application server - NetServer web services. The web server uses SOAP web-services to talk to the application server. The web server has no direct access to the database in this scenario.

## Development platform

* Microsoft .NET
* Code in C\#
* Web in ASP.NET 2.0
* Asynchronous calls via Ajax.NET

## Multiple browser support (client-side)

* Internet Explorer 6, 7, and 8 on Windows
* FireFox and Opera on Windows, Mac, and Linux

## Server-side

* Windows Server 2003 for production web and application servers
* We support database, application server, and web server on separate or the same machine
* Windows XP (for demo and test/single-machine setup supported)
* We support network load balancing

## Database

We support:

* SQL Server 2000, 2005
* Oracle 9, 10
* Sybase Anywhere 8, 9
* DB/2 on Windows, Linux, iSeries

The SuperOffice data model is NOT modified and hence requires no data conversion process. New tables and fields are however added to the existing data model.

## Architecture

* Service Oriented Architecture (SOA)
* Dynamic Client Foundation (DCF)

## Unicode

The CRM.web product is prepared for Unicode, but are depending on several other elements in the SuperOffice CRM concept to work properly. Hence, support for Unicode is not part of this release.
