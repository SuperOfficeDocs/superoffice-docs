---
title: Install SuperOffice Win Server
uid: install_crm_server
description: Install SuperOffice Win Server
author: SuperOffice Product and Engineering
date: 12.01.2025
keywords: install, server
content_type: howto
deployment: onsite
version: 11
---

# Install CRM Server 11 and newer

## Prerequisites

Prerequisites are available in the installation package.

After you start the SuperOffice CRM Server installer you will find the **Install prerequisites**. Here you can click the Advanced button to see what will be installed and select or unselect if you want to do it another way.

To install the .NET Framework an internet connection is required. If the server where the installation is done doesn't have an internet connection, the [correct][1] .NET framework must be installed from another source.

A warning will be given when installing prerequisites if the installation of the .NET Framework fails, and ServerSetup will not start if .Net is not installed on the server.

The reason is the prerequisites installation program on the installation package contains only the boot-strapper for the .NET installation and not the entire setup program (approx 2.5 MB versus 250 MB).

The server where you install SuperOffice CRM Server needs to have an internet connection and access to our License server on [https://license.superoffice.com][4].

## Install

FILL IN INSTALL PRODECURE

***

[Previous][11] | [Next (Web)][12] | [Next (Win)][14] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../requirements/crm-server.md
[4]: https://license.superoffice.com
[11]: ../service/prepare.md
[12]: ../service/index.md
[13]: ../guide.md
[14]: ../win-client/index.md
