---
title: Deploy
uid: deploy_webtools
description: WebTools deployment in a restricted environment
author: {github-id}
keywords: WebTools
so.topic: howto
so.envir: onsite
so.client:
---

# WebTools deployment in a restricted environment

Currently, the best way of distributing WebTools is by deploying the pre-requisites and allowing users to [install WebTools themselves][4]. This method will utilize the built-in update functionality.

However, there are companies where users are not allowed to install software on their devices at all. Those companies need to deploy the pre-requisites and the MSI files using their preferred deployment strategy. Updates must be manually handled by the company and deployed through their solution.

If WebTools are already installed, or if you for other reasons wish to configure it, it is possible to use **SoConfig** files for the initial setup:

![Example of a SoConfig file -screenshot][img1]

When deploying through GPO or other alternatives, executing the *SoConfig* file during the log-on process will set up WebTools for the user. The site will not be added again if it has already been added.

> [!NOTE]
> If you are not the administrator, you get WebTools installed in *c:\users\\\<yourname>\appdata\local\SuperOffice*. To install on *C:\Program files*, you need to be the local administrator.

## Overview

1. Extract required files from the WebTools installer.
2. Distribute the MSI files (using GPO or SCCM tools) to all machines that are going to use WebTools.
3. Auto-configure the URL and Settings using a script.

The following MSI files must be deployed to every SuperOffice user (AD group all SuperOffice users):

* SoCrossTableInstaller.msi (component for viewing cross-table reports)
* SuperOffice.MailLink.Setup.msi (add-in for Microsoft Outlook)
* SuperOffice.Web.Extensions.msi (document-handling plugin for SuperOffice)

## Pre-requisites

* Username in SuperOffice must be the same as in ActiveDirectory (sAMAccountName).
* SuperOffice needs to be configured to use Active Directory as the authentication method for all users.
* SuperOffice Web needs to be configured to use Windows Authentication on the website.
* We also recommend to [disable the WebTools upgrade dialog][2].
* Blocking applications must be closed.
* [Libraries][5] must be installed **before any SuperOffice plugins are installed**.

## Blocking applications

There are several applications that need to be closed when MailLink and Web Extensions are being installed. Make sure all of these are switched off when you deploy WebTools.

> [!WARNING]
> Do not run Outlook.exe as administrator (then you do not run it as "your own local user") and that will not work for MailLink.

**For MailLink, close:**

* Outlook
* SuperOffice CRM Win client
* SoEventServer

**For Web Extensions, close:**

* SuperOffice TrayApp Client

## Step 1: Extract required files from the WebTools installer

You need to extract *SoCrossTableInstaller.msi*, *SuperOffice.MailLink.Setup.msi*, and *SuperOffice.Web.Extensions.msi*.

1. Download the WebTools installer from the [Download Service][3] or from inside the SuperOffice CRM **Download** menu.

2. Extract Mail Link and Web Extensions installers out of WebTools installer:

    `SuperOffice.Web.Tools.exe /k /d C:\Temp`

3. Run `SuperOffice.MailLink.Setup.exe` but don't finish the installation. While keeping the installer on-screen:

    1. Go to the *%temp%* folder.
    2. Locate a folder where the installer unpacked the MailLink files.
    3. Copy the *SuperOffice.MailLink.Setup.msi* file out of it.

4. Run `SuperOffice.Web.Extensions.exe` as above to obtain *SuperOffice.Web.Extensions.msi*.

5. To get *SoCrossTableInstaller.msi*, download CrossTable viewer from inside the SuperOffice Web **Download** menu and follow the same procedure as with MailLink to get the MSI from the *%temp%* folder during CrossTable viewer installation.

> [!TIP]
> Because MailLink is a separate downloadable installer (the latest version) available on the Download Service, customers wishing to upgrade or extract MSI only MailLink can do so.

## Steps 2-3: Deploy and configure MSI files

1. Install all MSI packages with a help of the **InstallWebTools.cmd** script (see below). It also copies the **SuperOfficeWebToolConfiguration.cmd** script to the **Start** menu for all users and removes the default Web Extensions link.

2. Edit *SuperOfficeWebToolConfiguration.cmd* with correct settings:

    ```bat
    set SuperOfficeWebUrl=https://socrm.myorganization.com/sales
    set SuperOfficeServiceURL=https://socrm.myorganization.com/service
    set SuperOfficeOwnerContactName=Licence owner name
    ```

3. Restart the target computer.

### InstallWebTools.cmd

Copy the below code-lines to Notepad or another text editor and save as *InstallWebTools.cmd*.

[!code-batchfile[cmd](includes/InstallWebTools.cmd)]

### SuperOfficeWebToolConfiguration.cmd

Copy the below code-lines to Notepad or another text editor and save as *SuperOfficeWebToolConfiguration.cmd*.

[!code-batchfile[cmd](includes/SuperOfficeWebToolConfiguration.cmd)]

<!-- Referenced links -->
[2]: upgrade.md
[3]: https://www3.superoffice.com/DownloadService/
[4]: install.md
[5]: system-requirements.md

<!-- Referenced images -->
[img1]: media/11033-21660.jpg
