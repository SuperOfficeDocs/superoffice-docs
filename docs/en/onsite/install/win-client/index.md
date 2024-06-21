---
title: Install SuperOffice 9 or 10 Windows client
uid: install_win9_client
description: Install SuperOffice 9 or 10 Windows client
author: {github-id}
keywords: install, win, client
topic: howto
envir: onsite
client: win
---

# Install SuperOffice 9 or 10 Windows client

From SuperOffice 9 the SuperOffice Windows client is not available. The *SuperOffice9.exe* (or *SuperOffice10.exe* for SuperOffice 10) installer contains SuperOffice Admin client, Reporter Studio and Travel Gateway.

The installer is found on the SuperOffice CRM Server in the *Client* folder.

## Installer

All installation tasks are performed by the installer found in the folder *SuperOffice Server\Client*.

To install the client run the MSI Installer SuperOffice9.exe found in the *SuperOffice Server\Client* folder.

Note: If you want to use Oracle you need to install the Oracle client drivers on each client first. Oracle 10g may run on the Microsoft version of the Oracle driver.

It will default install to *C:\Program Files (x86)\SuperOffice*. The default location for SuperOffice temp (SoTemp) is Local.

![x -screenshot][img1]

If you choose **Customize**, you may choose where you want to install it and also choose to install additional options.

![x -screenshot][img2]

An **Advanced** installation will give you the option to select additional features and will display the installation wizard for each component.

SuperOffice Admin client installation has Typical and Custom installation types. Custom installation allows you to select which languages will be installed.

![x -screenshot][img3]

After the installation is completed all components are installed.

![x -screenshot][img4]

> [!TIP]
> If you want to run Travel Gateway as a service, you need to install the service manually.

## Related info

* [Prepare Windows client computer][5]
* [Tested client OSes][1]
* [Tested browsers][2]
* [Tested Microsoft SQL Server versions][3]
* [Tested Oracle versions][4]

***

[Previous][11] | [Next][12] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../compatibility/server-os.md
[2]: ../../compatibility/browser.md
[3]: ../../compatibility/ms-sql-server.md
[4]: ../../compatibility/oracle.md
[5]: prepare-client.md
[11]: ../server/index.md
[12]: ../../../service/install/index.md
[13]: ../guide.md

<!-- Referenced images -->
[img1]: media/crm-9-win-install1.png
[img2]: media/crm-9-win-install2.png
[img3]: media/crm-9-win-install3.png
[img4]: media/crm-9-win-install4.png
