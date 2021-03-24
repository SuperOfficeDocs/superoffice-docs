---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: deploy_on_citrix       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Deploy MailLink/Ribbons in a Citrix/Terminal Server environment # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Deploy MailLink/Ribbons in a Citrix/Terminal Server environment

When installing SuperOffice in a Citrix environment, consider this to avoid problems when the customer starts to use our software.

## MailLink/Ribbons/Web Extensions on Citrix/Terminal server

Ask: Will the customer deploy MailLink/Ribbons to ALL users running in the Citrix/Terminal Server environment?

**If all users want MailLink/Ribbons, you can skip reading this document.**

> [!NOTE]
> We’re not using the Shadow key system in the registry anymore.

## Deployment

When deploying MailLink/Ribbons in a Terminal Server/Citrix environment, we use a registry mechanism called Registry propagation built into Microsoft Office.

> [!NOTE]
> Registry propagation does not work for Office 2013 in SuperOffice versions below 7.5.

The requirement to get the Ribbon components, a user needs to have the AddIns registered in the `HKEY_CURRENT_USER` hive of the registry. Since we don’t know who will log in (and new users can be added later on), there is no way for us to write anything to these areas in the registry when we install SuperOffice.

The way we’ve solved this is to register the necessary keys under the `HKEY_LOCAL_MACHINE` hive in the registry (64-bit machine).

These keys contain the values that will be copied to the `HKEY_CURRENT_USER` keys for a user when he/she starts a Microsoft Office program. **These keys will be written AFTER any login scripts has been run, so it is impossible to remove them using such a script**.

The problem with the above solution is that for every user that logs in and starts any of the Microsoft Office programs, these registry keys will be copied to their local `HKEY_CURRENT_USER` registry hive and they will get a question asking them if they want to install SuperOffice Ribbons.

## Supporting groups that should have and that should not have MailLink/Ribbons

The correct way to support a scenario where some users/groups should get the MailLink/Ribbons tools is to remove the registry keys mentioned above:

**32-bit environment:**

```text
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\16.0\User Settings\SuperOfficeOfficeRibbons
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\16.0\User Settings\SuperOfficeRibbons
```

These keys are for Office 2016, for other Office versions change the path accordingly.

**64-bit environment:**

```text
HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\16.0\User Settings\SuperOfficeOfficeRibbons
HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\16.0\User Settings\SuperOfficeRibbons
```

These keys are for Office 2016, for other Office versions change the path accordingly.

### Registry scripts to import

Use the following Registry scripts to deploy MailLink/Ribbons to those users/groups that should receive these components.  
**Remember to substitute the paths with correct filenames for your installation!**

### The first file is for getting Ribbons installed on 8.0 and newer

Windows Registry Editor Version 5.00

```text
[HKEY_CURRENT_USER\Software\Microsoft\Office\Excel\Addins\SuperOfficeRibbon-Excel]
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft Office Excel 2007"
"CommandLineSafe"=dword:00000001
"LoadBehavior"=dword:00000003
"Manifest"="M:\\Program Files\\SuperOffice\\SuperOffice Windows\\Ribbons\\SuperOffice.Ribbon.Excel.vsto|vstolocal"

[HKEY_CURRENT_USER\Software\Microsoft\Office\PowerPoint\Addins\SuperOfficeRibbon-PowerPoint]
"CommandLineSafe"=dword:00000001
"Manifest"="M:\\Program Files\\SuperOffice\\SuperOffice Windows\\Ribbons\\SuperOffice.Ribbon.PowerPoint.vsto|vstolocal"
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft PowerPoint 2007"
"LoadBehavior"=dword:00000003

[HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\SuperOfficeRibbon-Word]
"LoadBehavior"=dword:00000003
"Manifest"="M:\\Program Files\\SuperOffice\\SuperOffice Windows\\Ribbons\\SuperOffice.Ribbon.Word.vsto|vstolocal"
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft Word 2007"
"CommandLineSafe"=dword:00000001
```

### The following file is to get MailLink deployed on 8.0 and newer:

```text
[HKEY_CURRENT_USER\Software\Microsoft\Office\Outlook\Addins\SuperOfficeRibbon-Outlook]
@=""
"CommandLineSafe"=dword:00000001
"Description"="A link between Outlook and SuperOffice for storing mails and attachments"
"FriendlyName"="SuperOffice Ribbon"
"LoadBehavior"=dword:00000003
"Manifest"="M:\\Program Files\\SuperOffice\\SuperOffice Windows\\MailLink\\SuperOfficeRibbon-Outlook.vsto|vstolocal"
```

### Web Extensions

#### Installation on Citrix-server

1. Install **SuperOffice.Web.Tools.exe** in 'Install mode'

2. To **avoid all users** to run Web Extensions remove 'SuperOffice CRM.Web Extensions' (TrayApp) from `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup`

3. Make sure users **who should run Web Extensions** get the Web Extensions shortcut in: `C:\Users\"username"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`

#### Upgrade of Web Extensions on Citrix-server

After upgrade of WebTools on the server remember to remove Web Extensions startup from  `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup` again.

### How to change the language of MailLink

SuperOffice Ribbons use the *HKEY\_CURRENT\_USER\\Software\\Microsoft\\Office\\16.0\\Common\\LanguageResources\\UIFallback* to determine which language to use (the example is for Office 2016).

Example: In Outlook the language is Norwegian, but the SuperOffice Ribbon is in German language.

Registry can have these values 0;1031;1033;1044;1043;1030;1053
SuperOffice will choose the first valid value and if you have this language pack installed the SuperOffice Ribbon will be shown in this language.

In this example this is 1031 and that is the code for German language. Norwegian is 1044.

You can find [here][2] a full list of languages.

Another way how to change the language of the Mail Link is described in this [FAQ][3].

> [!NOTE]
> You need to do this for every user on the server as the setting is user-specific.

<!-- Referenced links -->
[2]: http://technet.microsoft.com/en-us/library/cc179219.aspx
[3]: https://crm.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=111721