---
title: webtools       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# SuperOffice Web Tools

## Overview of SuperOffice Web Tools v8

SuperOffice MailLink (part of SuperOffice WebTools) supports 2 main modes of operation:

* Against a Web installation
* Against a Windows installation

In the first case MailLink accesses web service hosted by SuperOffice Web to access NetServer and SuperOffice data.

In the latter case MailLink has shipped with its own copy of NetServer and runs its own database layer directly.

This means that if you have a SuperOffice Windows installation and download the latest WebTools from the [SuperOffice Download Service][1] you may end up in a situation where your MailLink runs a newer version of NetServer and expects a different database schema than the one you actually have.

### Technical overview over SuperOffice Web Tools

This is a technical blog post written by one of the developers to describe the inner workings of SuperOffice Web Tools. The intended audience is technicians, developers and other special interested.

[Blog by developer Hans Oluf Waaler][2]

## The solution

If MailLink “borrows” NetServer from the Windows client installation instead of shipping its own the whole compatibility problem goes away. Having the Windows client installed is a prerequisite anyway so it’s not like we’re imposing any new demands.

MailLink component overview prior to 8.3:

![x][img1]

MailLink component overview from 8.3:

![x][img2]

Basically, whatever client we work against (Web or Windows), that client should be the one who “owns” NetServer and _thus the database schema._ This way there’s no overlap or redundancy in components or responsibilities. MailLink doesn’t bring along its own NetServer and avoids causing compatibility issues.

## The consequences for MailLink

Because it doesn’t ship its own NetServer fewer files should be copied to the MailLink installation folder.

The Windows client installer will also install *one* extra file into the client folder: SuperOffice.MailLink.WinClient.dll. **This file must be present for this new MailLink to enable “Windows mode”** (which means it will not work with older versions of the Windows client). If this file is not found, only web support is available.

## The consequences for WebTools

With the size of the installed MailLink folder considerably smaller the combined size of the entire WebTools install is much smaller too.

Having WebTools shipped without NetServer causes quite a chain of events:

* One version of WebTools should now be compatible with all versions of SuperOffice: Online, Onsite Web, (future releases of) Onsite Windows.
* **MailLink (and WebTools) will only exist in one version: The latest version.**

## Version compatibility

### SuperOffice 8.1 and SuperOffice 8.2 up to 8.2 R04** (8.2.6642)

* SuperOffice Windows users are advised to stay on the same version of MailLink as shipped with the SuperOffice Windows installer (MailLink with NetServer). This applies also to Windows / Web client mixed environments. If they upgrade MailLink to the one without NetServer, Windows client support will be disabled.

* Pure SuperOffice Web 8.1 and 8.2 up to R04 environments. Normally they will be offered to download WebTools from the 8.1/8.2 release channel from the Download Service. If any are published, updates will also be provided from this channel. But let’s say there is a problem/bug which is fixed in 8.3 release.<br>The customer can then install the latest WebTools (without NetServer) through manual download from the Download Service.<br>When this is done a few things changes:

  * Windows support will no longer be available (which is not an issue for pure Web users).
  * The Download Service will NOT say this is an incompatible version for SuperOffice 8.1/8.2.
  * The Download Service will now offer updates from the new WebTools 8.3 release channel.

### SuperOffice 8.2 R06 (8.2.6689) and into the future (which includes 8.3, 8.4, etc)

* SuperOffice Windows users can install the latest WebTools from the Download Service without worrying about compatibility.  
* Both Windows and Web installations use a new build of WebTools which ships **without** NetServer.

## Distribution of WebTools since 8.1

* SuperOffice Web will automatically detect new versions of WebTools and will offer the user to update. WebTools can also be downloaded manually from the Download menu inside SuperOffice.
* SuperOffice Win users will receive new versions upon upgrading the Windows client or by manually downloading and installing from the [Download Service][1].

### SuperOffice Download Service

Since version 8.1, SuperOffice Web stopped bundling WebTools and MacLink with the actual installation and outsourced this responsibility to a new cloud component: The SuperOffice Download Service.

This service has a limited set of responsibilities:

* Hosting downloads like WebTools and MacLink.
* Implement and apply rules concerning compatibility between WebTools/MacLink and Web.
* Offering SuperOffice Web advice about WebTools and MacLink upgrades available to the user.

## How to install only MailLink part of WebTools

MailLink is now a separate downloadable installer (the latest version) available on the Download Service so customers wishing to upgrade only MailLink can do so.

<!-- Referenced links -->
[1]: https://www3.superoffice.com/DownloadService/
[2]: https://community.superoffice.com/en/blog/technical-overview-over-superoffice-web-tools/

<!-- Referenced images -->
[img1]: media/webtools-old-schema.png
[img2]: media/webtools-new-schema.png