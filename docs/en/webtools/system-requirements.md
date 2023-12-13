---
title: Requirements
uid: webtools_system_requirements
description: System requirements for WebTools
author: {github-id}
keywords: WebTools
so.topic: reference
so.envir: onsite
# so.client:
---

# System requirements for WebTools

## Requisites

* [Microsoft .Net Framework 4.7.2][3] for WebTools 12.0 and newer.
* [Microsoft .Net Framework 4.5.1][1] for WebTools 11.7 and older.
* VSTO 2010 runtime (32bit or 64bit) for Ribbons
* Visual C++ 2017 runtime for x86 (version 14.14.26429.4)

## Folders on Citrix/Terminal server

### MailLink

MailLink stores its configuration in the *%appdata%* folder under *SuperOffice\MailLink*. This folder is part of a roaming profile so the MailLink configuration is not forgotten when the user signs out and back in again.

### Web Extensions

It is necessary to make sure Web Extensions is set to automatically start when a user signs in.

To store Web Extensions configuration, we use folder *%localappdata%\SuperOffice\SuperOffice Web Extensions*.

> [!NOTE]
> The installation of the WebTools does not require administrative privileges, but the prerequisites do. For more information, see the [WebTools installation documentation][2].

## Version compatibility

### SuperOffice 8.2 R06 (8.2.6689) and newer

* SuperOffice Windows users can install the latest WebTools from the [Download Service][4] without worrying about compatibility.
* Both Windows and Web installations use a new build of WebTools that ships **without** NetServer.

### SuperOffice 8.1 and SuperOffice 8.2 up to 8.2 R04 (8.2.6642)

SuperOffice Windows users are advised to stay on the same version of MailLink as shipped with the SuperOffice Windows installer (MailLink with NetServer). This applies also to Windows/Web client mixed environments. If they upgrade MailLink to the one without NetServer, Windows client support will be disabled.

**Pure SuperOffice Web 8.1 and 8.2 up to R04 environments:**

Normally they will be offered to download WebTools from the 8.1/8.2 release channel from the Download Service. If any are published, updates will also be provided from this channel.

But let’s say there is a problem/bug that is fixed in the 8.3 release. The customer can then install the latest WebTools (without NetServer) through manual download from the [Download Service][4]. When this is done a few things changes:

* Windows support will no longer be available (which is not an issue for pure Web users).
* The Download Service will NOT say this is an incompatible version for SuperOffice 8.1/8.2.
* The Download Service will now offer updates from the new WebTools 8.3 release channel.

<!-- Referenced links -->
[1]: https://www.microsoft.com/en-US/download/details.aspx?id=40779
[2]: deploy.md
[3]: https://support.microsoft.com/en-us/topic/microsoft-net-framework-4-7-2-offline-installer-for-windows-05a72734-2127-a15d-50cf-daf56d5faec2
[4]: https://www3.superoffice.com/DownloadService/
