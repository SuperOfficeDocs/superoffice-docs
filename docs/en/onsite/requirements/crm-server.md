---
title: Requirements
uid: crm_server_requirements
description: System requirements for SuperOffice server
author: {github-id}
date: 09.12.2023
keywords:
topic: reference
envir: onsite
# client:
---

# System requirements for SuperOffice server hosting CRM server

The SuperOffice CRM server is used for hosting the client files and document archive.

See also requirements for [IIS][2].

## Server Operating System

* Microsoft Windows Server 2022
* Microsoft Windows Server 2019
* Microsoft Windows Server 2016

## Document Archive

* File share on a server to store documents and emails archived in SuperOffice

## Protocol

* File share uses standard SMB port 445

## Database

* Oracle or Microsoft SQL Server: [supported versions][1]

## Distribution

* All windows client files (MSI) are installed on the server along with the database configuration tool *dbsetup.exe*.

## Disk space

* 3,5 GB for SuperOffice Web, Server, and Service files with all languages
* 1 GB document archive

> [!NOTE]
> The size of the document archive will vary depending on the number of users and documents created from SuperOffice. Size the disk space according to your own business needs.

<!-- Referenced links -->
[1]: ../compatibility/database.md
[2]: iis.md
