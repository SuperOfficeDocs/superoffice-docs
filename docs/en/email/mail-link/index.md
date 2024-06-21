---
title: MailLink
uid: maillink
description: MailLink
author: {github-id}
keywords:
topic: concept
---

# MailLink

SuperOffice MailLink (part of SuperOffice WebTools) supports 2 main modes of operation:

* Against a Web installation
* Against a Windows installation

## Components

![x -screenshot][img2]

The picture was different before 8.3:

![x -screenshot][img1]

## Compatibility

One version of WebTools should now be compatible with all versions of SuperOffice: Online, Onsite Web, (future releases of) Onsite Windows.

**MailLink (and WebTools) will only exist in one version: The latest version.**

In older WebTools versions (before 8.3), MailLink shipped with its own copy of NetServer and ran its own database layer directly. In this case, if you have a SuperOffice Windows installation and download the latest WebTools from the [SuperOffice Download Service][1], you may end up in a situation where your MailLink runs a newer version of NetServer and expects a different database schema than the one you have.

The Windows client installer will also install *one* extra file into the client folder: *SuperOffice.MailLink.WinClient.dll*. **This file must be present for this new MailLink to enable "Windows mode"** (which means it will not work with older versions of the Windows client). If this file is not found, only web support is available.

## How to install only MailLink part of WebTools

MailLink is now a separate downloadable installer (the latest version) available on the Download Service so customers wishing to upgrade only MailLink can do so.

<!-- Referenced links -->
[1]: https://www3.superoffice.com/DownloadService/

<!-- Referenced images -->
[img1]: media/webtools-old-schema.png
[img2]: media/webtools-new-schema.png
