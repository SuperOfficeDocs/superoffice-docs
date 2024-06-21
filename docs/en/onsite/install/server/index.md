---
title: Install SuperOffice Win Server
uid: install_crm_server
description: Install SuperOffice Win Server
author: {github-id}
keywords:
topic: howto
envir: onsite
# client:
---

# Install CRM Server

## Prerequisites

Prerequisites are available in the installation package.

After you start the SuperOffice CRM Server installer you will find the **Install prerequisites**. Here you can click the Advanced button to see what will be installed and select or unselect if you want to do it another way.

To install the .NET Framework an internet connection is required. If the server where the installation is done doesn't have an internet connection, the [correct][1] .NET framework must be installed from another source.

A warning will be given when installing prerequisites if the installation of the .NET Framework fails, and ServerSetup will not start if .Net is not installed on the server.

The reason is the prerequisites installation program on the installation package contains only the boot-strapper for the .NET installation and not the entire setup program (approx 2.5 MB versus 250 MB).

The server where you install SuperOffice CRM Server needs to have an internet connection and access to our License server on [https://license.superoffice.com][4].

## Install

Choose one of:

* [Silent install][2]
* [Install on Citrix or Terminal server][3]

### Automatic update of clients (for SuperOffice Windows client only)

In the last screen of ServerSetup, **Installation is complete**, you can select to use an automated update for client installations.

The client setup file will be run from the location selected in ServerSetup, so this location must be available for the user and sufficient rights must have been granted.

If Active Directory is to be used for updates, the automatic update should not be selected in ServerSetup.

The automatic client update feature replaces the use of SoLoader in earlier versions.

Automated updates for client installations will ask the user if she wants to update SuperOffice CRM client if the client setup files have been updated by ServerSetup. The check is done by comparing the version of SuperOffice CRM client with the highest version of ServerSetup installation on this database.

The user can select to not update, the question will then be asked again next time she starts SuperOffice CRM client.

If the user selects to update, the SuperOffice CRM client will exit and the client setup file will be run. When the installation is finished, SuperOffice CRM client must be started again.

### Install with several languages

You can choose to install SuperOffice CRM  in one or more languages.

In a new installation, only the main language is used for most of the translated texts that are installed in the database. This will remain the same even if you install with several languages, and later select to run SuperOffice CRM in another language than the main language. This will cause some of the text in the application to be in the main language and most in the selected language. (Seen in dropdown lists for example.)

If you are upgrading from an earlier version of SuperOffice, make sure to select the same main language as in the last installation, or you risk getting a mix of languages in the database/program.

***

[Previous][11] | [Next (Web)][12] | [Next (Win)][14] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../requirements/crm-server.md
[2]: silent-serversetup.md
[3]: install-on-citrix.md
[4]: https://license.superoffice.com
[11]: ../../../service/install/prepare.md
[12]: ../../../service/install/index.md
[13]: ../guide.md
[14]: ../win-client/index.md
