---
title: Technical overview
uid: webtools_technical_overview
description: Technical overview of SuperOffice WebTools
author: Hans Oluf Waaler
keywords: WebTools
so.topic: concept
so.date: 10.13.2016
so.envir: onsite
---

# Technical overview

The interaction between SuperOffice WebTools and SuperOffice CRM depends heavily on the capabilities in the browser used.

We currently use SignalR-technology to communicate between SuperOffice in the browser and WebTools running on the user's desktop. The previous generation used NPAPI-based plugins, and before that protocol handlers.

WebTools consists of 3 components:

* The installed component on the user’s computer
* TrayApp2.svc (WCF)
* The SignalR endpoint

The 2 latter are installed server-side along with SuperOffice CRM and access the SuperOffice database through NetServer APIs. (Yes, the same APIs that are available to partners).

Check out the [system requirements][2].

## Starting up WebTools

![Starting up WebTools -screenshot][img3]

After WebTools have finished starting up, it will resume incomplete tasks.

The tasks files are stored in *%localappdata%SuperOffice\SuperOffice 7 Web Extensions\Tasks*. One task consists of a task file and a directory with the same name. This directory will contain the document during editing/reading.

## Document editing

![Opening up a document in CRM -screenshot][img4]

## Authentication

WebTools supports authenticating to 2 different layers to SuperOffice:

* The first layer is authenticating towards the Web Server (IIS) using Negotiate (Windows Authentication), NTLM, Digest, or Basic.

* The second layer is authenticating towards the SuperOffice installation.

Authenticating towards the SuperOffice installation can be handled by SuperOffice, Active Directory, or delegated to an identity provider such as Google or Microsoft 365 (only available in SuperOffice Online).

**Single sign-on** (SSO) is achieved when both authentication layers are compatible – for instance, Windows Authentication in IIS and Active Directory on the SuperOffice installation. SSO requires [configuration changes in IIS][1] and *web.config* file. Users must be configured to use Active Directory for authentication.

## SuperOffice Download Service

After version 8.1, WebTools and MacLink are no longer bundled with the actual installation. Instead, they are outsourced to and the responsibility of the SuperOffice Download Service, which:

* Hosts downloads like WebTools and MacLink
* Implements and applies rules concerning compatibility between WebTools/MacLink and Web
* Offers advice about WebTools and MacLink upgrades available to the Web users

<!-- Referenced links -->
[1]: ../onsite/install/iis/index.md
[2]: system-requirements.md

<!-- Referenced images -->
[img3]: media/11036-21654.jpg
[img4]: media/cdraw.png
