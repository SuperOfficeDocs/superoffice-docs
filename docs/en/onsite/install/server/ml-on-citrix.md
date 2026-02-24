---
uid: deploy-maillink-webextensions-citrix
title: Deploy WebTools
description: Deploy WebTools in a Citrix or Terminal Server environment
keywords: maillink deploy citrix terminal webtools
author: SuperOffice Product and Engineering
date: 02.24.2026
content_type: howto
deployment: onsite
---

# Deployment of WebTools in a Citrix or Terminal Server environment

When installing SuperOffice in a Citrix or Terminal Server environment, review this information to prevent issues after deployment.

Before you continue, clarify the following: Will WebTools be deployed to all users in the Citrix or Terminal Server environment?

* If WebTools will be deployed to all users, no additional configuration is required.
* If WebTools will be deployed to selected users only, follow the guidance below.

> [!NOTE]
> We're not using the Shadow key system in the registry anymore.

## MailLink deployment

When deploying MailLink in a Terminal Server/Citrix environment, we use a registry mechanism called Registry propagation built into Microsoft Office.

[!include[Registry propagation](includes/registry-propagation.md)]

### Supporting groups that should (not) have MailLink

The correct way to support a scenario where some users/groups should NOT get the MailLink in Outlook is to remove the following registry keys:

[!include[Registry keys](includes/registry-keys.md)]

### Registry scripts to import

Use the following Registry script to deploy MailLink to those users/groups that should receive these components.
**Remember to substitute the paths with correct filenames for your installation!**

The following file is to get MailLink deployed on SuperOffice 8.0 and newer:

```text
[HKEY_CURRENT_USER\Software\Microsoft\Office\Outlook\Addins\SuperOfficeRibbon-Outlook]
@=""
"CommandLineSafe"=dword:00000001
"Description"="A link between Outlook and SuperOffice for storing mails and attachments"
"FriendlyName"="SuperOffice Ribbon"
"LoadBehavior"=dword:00000003
"Manifest"="C:\Program Files\SuperOffice\SuperOffice Windows\MailLink\SuperOfficeRibbon-Outlook.vsto|vstolocal"
```

## Web Extensions deployment

### Installation on Citrix-server

1. Install **SuperOffice.Web.Tools.exe** in 'Install mode'

2. To **avoid all users** to run Web Extensions remove 'SuperOffice CRM.Web Extensions' (TrayApp) from `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup`

3. Make sure users **who should run Web Extensions** get the Web Extensions shortcut in: `C:\Users\"username"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`

### Upgrade of Web Extensions on Citrix-server

After the upgrade of WebTools on the server remember to remove Web Extensions startup from  `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup` again.

## MailLink language

How to change default MailLink language is described in this [article][2]. Another way is described in this [FAQ][3].

<!-- Referenced links -->
[2]: addins-language.md
[3]: https://crm.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=111721
