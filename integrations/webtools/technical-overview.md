---
uid: webtools-technical-overview
title: Technical overview
description: Technical overview of SuperOffice WebTools
keywords: WebTools
author: Jostein, Bergfrid, H.O. Waaler
date: 01.23.2024
content_type: concept
category: integration
topic: WebTools
language: en
redirect_from: /en/document/webtools/technical-overview
---

# Technical overview

The interaction between SuperOffice WebTools and SuperOffice CRM depends heavily on the capabilities in the browser used.

We currently use a custom protocol to communicate between SuperOffice in the browser and WebTools running on the user's desktop. The previous generation used SignalR-technology.

WebTools consists of 3 components installed server-side along with SuperOffice CRM and access the SuperOffice database through NetServer APIs. (Yes, the same APIs that are available to partners).

* The installed component on the user's computer
* TrayApp2.svc (WCF)
* MailLinkService.svc (WCF)

Check out the [system requirements][2].

## Starting up WebTools

### SuperOffice 10.2.11 and later

![Starting up WebTools 10.2.11 and later][img3]

### SuperOffice 10.2.10 and earlier

![Starting up WebTools 10.2.10 and earlier][img4]

After starting, WebTools will resume incomplete tasks.

The tasks files are stored in *%localappdata%SuperOffice\SuperOffice 7 Web Extensions\Tasks*. One task consists of a task file and a directory with the same name. This directory will contain the document during editing/reading.

## Document editing

### SuperOffice 10.2.11 and later

![Opening up a document in CRM 10.2.11 -diagram][img1]

### SuperOffice 10.2.10 and earlier

![Opening up a document in CRM 10.2.10 -diagram][img2]

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
[1]: ../../docs/en/onsite/install/iis/index.md
[2]: system-requirements.md

<!-- Referenced images -->
[img1]: ../../docs/media/loc/en/webtools/diagram-open-document-10.2.11.png
[img2]: ../../docs/media/loc/en/webtools/diagram-open-document-10.2.10.png
[img3]: ../../docs/media/loc/en/webtools/diagram-start-webtools-10.2.11.png
[img4]: ../../docs/media/loc/en/webtools/diagram-start-webtools-10.2.10.png
