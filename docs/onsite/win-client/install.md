---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: install_win_client       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Install Windows client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# Install Windows client

## MSI Installer

Contains SuperOffice Windows client, Mail Link, Ribbons, Travel Gateway, Mail Gateway.

Performs: Copies installation files, adds registry settings and program shortcuts.

## Installer

All installation tasks are performed by the installer found in the folder *SuperOffice Server\\Client*

To install the client run the MSI Installer SuperOffice8.exe found in the *SuperOffice Server\\Client* folder.

Note: If you want to use Oracle you need to install the Oracle client drivers on each client first. Oracle 10g may run on the Microsoft version of the Oracle driver.

It will default install to *C:\\Program Files (x86)\\SuperOffice*. Default location for SuperOffice temp (SoTemp) is Local

![x][5]

If you choose Customize you may choose where you want to install it and also choose to install additional programs.

 ![x][6]

Advanced installation will give you option to select additional features and will display installation wizard for each component.

Both Mail Link and Windows client Advanced installation have Typical and Custom installation types. Custom installation for Windows client allows you to select which languages and additional features will be installed.

 ![x][7]

After the installation is completed both Mail Link and Windows Client are installed.

![x][8]

## Related info

* [Prepare windows client computer](prepare-server.md)
* [Tested client OSes][1]
* [Tested browsers][2]
* [Tested Microsoft SQL Server versions][3]
* [Tested Oracle versions][4]

<!-- Referenced links -->
[1]: ../compatibility/server-os.md
[2]: ../compatibility/browser.md
[3]: ../compatibility/ms-sql-server.md
[4]: ../compatibility/oracle.md
[5]: media/crm-8-win-install1.png
[6]: media/crm-8-win-install2.png
[7]: media/crm-8-win-install3.png
[8]: media/crm-8-win-install4.png
