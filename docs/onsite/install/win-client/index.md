---
title: Install Windows client
uid: install_win_client
description: Install Windows client
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: win
---

# Install Windows client

From SuperOffice 8 the SuperOffice Windows Client is an app, which you need to be assigned rights to in the *Settings and Maintenance > user* section of SuperOffice Web.

Client installers are found on the SuperOffice CRM Server in the *Client* folder.

[!include[Warning legacy](../../includes/warn-win-client-discontinued.md)]

## MSI Installer

Contains SuperOffice Windows client, MailLink, Ribbons, Travel Gateway, Mail Gateway.

Performs: Copies installation files, adds registry settings, and program shortcuts.

## Installer

All installation tasks are performed by the installer found in the folder *SuperOffice Server\Client*

To install the client run the MSI Installer SuperOffice8.exe found in the *SuperOffice Server\Client* folder.

Note: If you want to use Oracle you need to install the Oracle client drivers on each client first. Oracle 10g may run on the Microsoft version of the Oracle driver.

It will default install to *C:\Program Files (x86)\SuperOffice*. The default location for SuperOffice temp (SoTemp) is Local.

![x][img1]

If you choose **Customize**, you may choose where you want to install it and also choose to install additional programs.

![x][img2]

An **Advanced** installation will give you the option to select additional features and will display the installation wizard for each component.

Both Mail Link and Windows client Advanced installation have Typical and Custom installation types. Custom installation for Windows client allows you to select which languages and additional features will be installed.

![x][img3]

After the installation is completed both Mail Link and Windows client are installed.

![x][img4]

## Related info

* [Prepare windows client computer][5]
* [Tested client OSes][1]
* [Tested browsers][2]
* [Tested Microsoft SQL Server versions][3]
* [Tested Oracle versions][4]

<!-- Referenced links -->
[1]: ../../compatibility/server-os.md
[2]: ../../compatibility/browser.md
[3]: ../../compatibility/ms-sql-server.md
[4]: ../../compatibility/oracle.md
[5]: prepare-client.md

<!-- Referenced images -->
[img1]: media/crm-8-win-install1.png
[img2]: media/crm-8-win-install2.png
[img3]: media/crm-8-win-install3.png
[img4]: media/crm-8-win-install4.png
