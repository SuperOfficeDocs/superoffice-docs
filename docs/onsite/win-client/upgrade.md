---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: upgrade_win_client       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Upgrade Windows Client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# How to upgrade SuperOffice 7 Windows Clients / SuperOffice 8 Windows App

## Step 1 - Check the System requirements for the SuperOffice 8 Windows App

In SuperOffice 8 the user needs a "Windows App" license to be able to log in to the Windows client. Read more in the [Help-file][1].

The "Maintenance and settings" is only accessible from the [Admin client web][2].

Some settings for Travel / Remote Travel (Replication), Windows client scripting is configured from the [Admin client windows][3]. Here you also find a section called "Options" where you can set automatic update of SuperOffice client. Check this option if you want the SuperOffice client to be updated automatically when a new version becomes available. Read more in the [Help-file][4].

Make sure the system requirements for the computer is met, read more information about this below and in the section ["System requirements" under "Preparations"](system-requirements.md)

Prerequisites are installed during the upgrade of the client. Read more in [Prerequisites][5].

## Step 2 - Install correct ODBC driver if needed

### Oracle ODBC driver, Microsoft Native Client or Microsoft **SQL Server driver

**Oracle:** If you want to use Oracles 11g, you need to install the Oracle client drivers on each client first. Oracle 10g may run on the Microsoft version of the Oracle driver.

**Microsoft Native Client:** Since we're now using the MSI installer - you may not run one client with SQL Server driver and another one with Native client. You need to install the Native client on the client if it's not installed already.

**Microsoft SQL Server driver:** Most current Windows operating systems have SQL Server driver pre-installed and is ready to use.

## Step 3 - Run SuperOffice8.exe to start the installation

To install the client - run the MSI Installer "SuperOffice8.exe" found in the *Server\\Client* folder.

Read more about running the installer and installing the client under "[Install Windows client][6]".

### How to find "Server\\Client folder" on server

Since you are upgrading the client on a computer, there is information you can use to find the location for the installer program - by navigating through the current files you already have.
(if this is changed by your administartor or IT - you need to ask them where to fin it).

1. Open SuperOffice.ini to find centralpath (where the server installation is):
    1. [Locate and open SuperOffice.ini](find-superoffice-ini-file.md)
    2. Copy the address after `"Centralpath="`

![superoffice-ini_centralpath][7]

2. Open the file path to where the server installation is - in file explorer

    1. Open the Run dialog (open it either from the Windows start-menu, choose "Run" or press [Windows-key + R][8].
    2. Paste or write the address for CentralPath and click **OK**.

![run_centralpath][9]

3. Find the folder *Client* on server and run **SuperOffice8.exe**

## Step 4 - Start SuperOffice

You may now start SuperOffice by clicking *START > All Programs > SuperOffice*

<!-- Referenced links -->
[1]: https://community.superoffice.com/Documentation/Help/EN/CRM/8.0/WebHelpAdmin/index.htm#t=chap07%2FAssociates.htm
[2]: https://community.superoffice.com/en/technical/documentation/administration/admin-client-web/
[3]: https://community.superoffice.com/en/technical/documentation/administration/admin-client-windows-app/
[4]: https://community.superoffice.com/Documentation/Help/EN/CRM/8.0/WebHelpAdmin/index.htm#t=chap06%2FSOLoader.htm
[5]: https://community.superoffice.com/en/technical/documentation/install-upgrade/crm-server/Installation-of-prrequisites/
[6]: https://community.superoffice.com/en/technical/documentation/install-upgrade/windows/sales/
[7]: media/superoffice-ini_centralpath.png
[8]: media/keyboard_windows_run.png
[9]: media/run_centralpath.png
