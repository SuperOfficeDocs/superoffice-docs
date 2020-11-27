---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: crm_server_system_requirements # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for SuperOffice 8 and 9 server # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# System requirements for SuperOffice 8 and 9 server

## Server hosting SuperOffice CRM server

The SuperOffice CRM server is used for hosting the client files and document archive.

### Server Operating System

* Microsoft Windows Server 2019
* Microsoft Windows Server 2016
* Microsoft Windows Server 2012 R2
* Microsoft Windows Server 2012

### Document Archive

* File share on a server to store documents and e-mails archived in SuperOffice

### Protocol

* File share uses standard SMB port 445

### Database

* Oracle or Microsoft SQL Server: [supported versions][1]

### Distribution

* All windows client files (MSI) are installed on the server along with the database configuration tool *dbsetup.exe*.

### Disk space

* 3,5 GB for SuperOffice Web, Server, and Service files with all languages
* 1 GB document archive

> [!NOTE]
> The size of the document archive will vary depending on the number of users and documents created from SuperOffice. Size the disk space according to your own business needs.

## Server hosting IIS

This server is used for SuperOffice S&M Web client, SuperOffice Service, SuperOffice Mailings, and SuperOffice Audience.

### Processor

* Intel ® 3.0Ghz Dual or Quad Core (x86) or (x64)
* AMD™3.0Ghz Dual or Quad Core (x86) or (x64)

### Memory

* 3 GB

### Operating system

* Microsoft Windows Server 2019
* Microsoft Windows Server 2016
* Microsoft Windows Server 2012 R2
* Microsoft Windows Server 2012

### Internet Information Server

* Microsoft IIS 10
* Microsoft IIS 8.5
* Microsoft IIS 8.0

### Network/Bandwidth

The preferred bandwidth for the web servers is 1 Mbit/sec for all installations up to 50 users. We estimate the individual user’s bandwidth consumption to add up to an average of 20 Kbit/sec.

### Mail servers

* Exchange Server 2010 64bit and newer
* Domino Server 10.0
* Domino Server 9.0
* MAPI/SoMaGate (Win client only)

### IMAP

* Port 143 or 993 (SSL) must be open between the Sales & Marketing web server and the mail server

### SMTP

* Port 25 or 465 (SSL) must be open between the Sales & Marketing web server and the mail server

### Requisites

* **Microsoft .NET v 4.8 from 8.5 R05 and 9**
* Microsoft .NET v 4.7.1 from 8.3 R04
* Microsoft .NET v 4.5.1 (as a web download)
* Windows communication foundation (on both the server running Sales & Marketing web and the server running NetServer web services)
* Local administrator rights (installation)

> [!Note]
> Audience does not support remote web services and must use the web services installed with the product.

#### Microsoft .NET v 4.8 from SuperOffice 8.5 R05 and 9

[!include[.NET v 4.8 required](../includes/req-dotnet-4-8.md)]

#### Microsoft .NET v 4.7.1 required from SuperOffice 8.3 R04

[!include[.NET v 4.8 required](../includes/req-dotnet-4-7-1.md)]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/prepare/system-requirement/tested-databases/