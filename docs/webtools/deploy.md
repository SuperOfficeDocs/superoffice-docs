---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: deploy_webtools       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Web Tools deployment # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Web Tools deployment

For technical overview of SuperOffice Web Tools please see this [blog post][1].

## How to deploy Web Tools in a restricted environment

Currently the best way of distributing Web Tools is by deploying the prerequisites and allowing users to install Web Tools themselves. The installation of Web Tools does not require administrative privileges (but the installation of prerequisites does). This method will utilize the built-in update functionality.

Nevertheless, there are companies where users are not allowed to install software on their devices at all. Deploymentwise they need to deploy the prerequisites and the msi files using their preferred deployment strategy. Furthermore, updates must be manually handled by the company and deployed through their solution.

## Install prerequisites

Please note the installation of the Web Tools does not require administrative privileges but the Prerequisites do.If you are not the administrator, you get Web Tools installed in *c:\\users\\\<yourname>\\appdata\\local\\SuperOffice*. To install on *C:/Program files*, you need to be the local administrator.

The following libraries need to be installed before any SuperOffice plugins are installed:

* Microsoft .NET framework 4.5.1 (Full) or higher
* VSTO 2010 runtime (32bit or 64bit) for Ribbons on Office 2007 and higher
* Visual C++ 2017 runtime for x86 (version 14.14.26429.4)

## Deploy SuperOffice Web Tools

We can divide the problem into two areas:

1. To distribute the MSI files to all machines that are going to use it.
2. Auto-configure the URL and Settings using a script.

The following MSIs need to be deployed to every SuperOffice user (AD group all SuperOffice users):

* SoCrossTableInstaller.msi (component for viewing cross-table reports)
* SuperOffice.MailLink.Setup.msi (Add-in for Microsoft Outlook)
* SuperOffice.Web.Extensions.msi (Document Handling plugin for SuperOffice)

These MSI files are pushed out using GPO or SCCM tools.

### Pre-requirements in SuperOffice

* Username in SuperOffice must be the same as in ActiveDirectory (sAMAccountName)
* SuperOffice needs to be configured to use Active Directory as authentication method for all users.
* SuperOffice WEB needs to be configured to use Windows Authentication on website.
* We also recommend to [disable the Web Tools upgrade dialog][2].

## SuperOffice 8.1 and later

Since SuperOffice 8.1 the Web Tools installer is no longer distributed with SuperOffice Web installation but is available on the [Download Service][3].

### How to extract required files from the Web Tools installer

* Download the Web Tools installer from the Download or from inside SuperOffice Web - Download menu.
* Extract Mail Link and Web Extensions installers out of Web Tools installer: `SuperOffice.Web.Tools.exe /k /d C:\Temp`
* Run `SuperOffice.MailLink.Setup.exe` and do not finish the installation. While keeping the installer on-screen, go to the *%temp%* folder, locate a folder where the installer unpacked the MailLink files and copy the *SuperOffice.MailLink.Setup.msi* out of it. After the installer is finished it will remove all of these files from the *%temp%* folder, including the msi, therefore it is important to copy the msi out of the temp folder.
* Do the same for `SuperOffice.Web.Extensions.exe` to obtain *SuperOffice.Web.Extensions.msi*.

Since SuperOffice 8.3 MailLink is now a separate downloadable installer (the latest version) available on the Download Service so customers wishing to upgrade or extract MSI only MailLink can do so.

* To get *SoCrossTableInstaller.msi*, download CrossTable viewer from inside SuperOffice Web - Download menu and follow the same procedure as with the MailLink to get the msi from the *%temp%* folder during CrossTable viewer installation.

## How to deploy and configure MSI files

1. Install all MSI packages with a help of the `InstallWebTools.cmd` script (see below). It also copies the SuperOfficeWebToolConfiguration.cmd script to the Start menu for all users and removes the default Web Extensions link.

2. Edit the script (see below) `SuperOfficeWebToolConfiguration.cmd` with correct settings:

```text
set SuperOfficeWebUrl=https://socrm.myorganization.com/sales
set SuperOfficeServiceURL=https://socrm.myorganization.com/service
set SuperOfficeOwnerContactName=Licence owner name
```

3. Restart target computer.

### Example Scripts

Save the below in Notepad or another text editor and save as *InstallWebTools.cmd*.

#### InstallWebTools.cmd

```text
@echo off
msiexec /i SoCrossTableInstaller.msi /qn /norestart
msiexec /i SuperOffice.MailLink.Setup.msi /qn /norestart
msiexec /i SuperOffice.Web.Extensions.msi /qn /norestart
xcopy SuperOfficeWebToolConfiguration.cmd "%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Startup" /Y
del "%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Startup\SuperOffice CRM.Web Extensions.lnk"
```

Save the below in Notepad or another text editor and save as *SuperOfficeWebToolConfiguration.cmd*.

#### SuperOfficeWebToolConfiguration.cmd

[!include[ALT](./includes/SuperOfficeWebToolConfiguration.md)]

## Blocking applications

There are several applications which need to be closed when MailLink and Web Extensions are being installed.

For the MailLink the blocking applications are:

* Outlook
* SuperOffice CRM Win client
* SoEventServer

For the Web Extensions the blocking applications is:

* SuperOffice TrayApp Client

Make sure all of these are switched off when you deploy Web Tools.

> [!WARNING]
> Do not run Outlook.exe as administrator (then you do not run it as "your own local user") and that will not work for MailLink.

<!-- Referenced links -->
[1]: index.md
[2]: upgrade.md
[3]: https://www3.superoffice.com/DownloadService/