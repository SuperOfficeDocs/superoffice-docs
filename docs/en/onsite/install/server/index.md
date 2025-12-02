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

SuperOffice 11.6 Onsite has two tools to replace ServerSetup and DBSetup.

CRMSetup is for installation and maintenance of database and document templates. Installation, upgrade, inspect, import, export and transfer of database.
Document templates are installed when creating new and upgrading.

CRMTask is for scheduling regeneration of freetext index, Saint counters and Status monitors. And run ERP sync.

CRMSetup and CRMTask are commandline tools:  Argument files can be made and reused to make the work easier, copy them into the CRMSetup folder.

Run command prompt as administrator, --help gives possible options, and arguments for the different options:
...>crmsetup --help

...>crmsetup new-installation --help

```dos
D:\SO Onsite 11.6\CrmSetup>CrmSetup.exe --help
Usage: CrmSetup [command]

CrmSetup is a command-line utility designed to manage SuperOffice CRM installations. It is a replacement
for the traditional SuperOffice CRM Setup tool and it provides commands for creating new installations,
upgrading existing setups, and inspecting databases.

Commands:
  new-installation      Create a new installation
  upgrade-existing      Upgrade existing installation
  inspect-database      Inspect existing database
  kill-database         Kill existing superoffice database
  import-file           Import an IMP data file to the database.
  export-database       Export a database to a file
  import-database       Import a database from a file, overwriting any existing database
  transfer-database     Transfer data from a source to a destination database

Options:
  --arg-file            Use arguments from argument file
  -h, --help            Show help message
  --version             Show version
```

Example for new database:
...\CrmSetup>crmsetup --arg-file CRMSetup.txt
The first out-commented line have the full command for copy-paste into cmd.
Remember to change all necessary values.

The inspect option is useful for testing how to use CRMSetup without changing the database.

***

[Previous][11] | [Next (Web)][12] | [Next (Win)][14] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../requirements/crm-server.md
[4]: https://license.superoffice.com
[11]: ../service/prepare.md
[12]: ../service/index.md
[13]: ../guide.md
[14]: ../win-client/index.md
