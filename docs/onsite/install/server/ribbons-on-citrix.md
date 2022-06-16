---
title: Deploy Ribbons
uid: deploy_ribbons_on_citrix
description: Deploy Ribbons in a Citrix or Terminal Server environment
author: {github-id}
keywords: ribbons deploy citrix terminal
so.topic: howto
so.envir: onsite
# so.client:
---

# Deployment of SuperOffice Ribbons in a Citrix or Terminal Server environment

When installing SuperOffice in a Citrix environment, consider this to avoid problems when the customer starts to use our software.

## Ribbons on Citrix or Terminal server

Ask: Will the customer deploy Ribbons to ALL users running in the Citrix/Terminal Server environment?

**If all users want Ribbons, you can skip reading this document.**

> [!NOTE]
> We’re not using the Shadow key system in the registry anymore.

## Ribbons deployment

When deploying Ribbons in a Terminal Server/Citrix environment, we use a registry mechanism called Registry propagation built into Microsoft Office.

[!include[Registry propagation](includes/registry-propagation.md)]

## Supporting groups that should (not) have Ribbons

The correct way to support a scenario where some users/groups should get the Ribbons is to remove the registry keys mentioned below:

[!include[Registry keys](includes/registry-keys.md)]

### Registry scripts to import

Use the following Registry script to deploy Ribbons to those users/groups that should receive these components.
**Remember to substitute the paths with correct filenames for your installation!**

Windows Registry Editor Version 5.00

```text
[HKEY_CURRENT_USER\Software\Microsoft\Office\Excel\Addins\SuperOfficeRibbon-Excel]
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft Office Excel 2007"
"CommandLineSafe"=dword:00000001
"LoadBehavior"=dword:00000003
"Manifest"="C:\Program Files\SuperOffice\SuperOffice Windows\Ribbons\SuperOffice.Ribbon.Excel.vsto|vstolocal"

[HKEY_CURRENT_USER\Software\Microsoft\Office\PowerPoint\Addins\SuperOfficeRibbon-PowerPoint]
"CommandLineSafe"=dword:00000001
"Manifest"="C:\Program Files\SuperOffice\SuperOffice Windows\Ribbons\SuperOffice.Ribbon.PowerPoint.vsto|vstolocal"
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft PowerPoint 2007"
"LoadBehavior"=dword:00000003

[HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\SuperOfficeRibbon-Word]
"LoadBehavior"=dword:00000003
"Manifest"="C:\Program Files\SuperOffice\SuperOffice Windows\Ribbons\SuperOffice.Ribbon.Word.vsto|vstolocal"
"FriendlyName"="SuperOffice Ribbon"
"Description"="SuperOffice Ribbon for Microsoft Word 2007"
"CommandLineSafe"=dword:00000001
```

## Ribbons language

How to change default Ribbons language is described in this [article][2].

<!-- Referenced links -->
[2]: addins-language.md
