---
uid: superoffice-for-outlook-deploy
title: Centralized deployment
description: How to deploy SuperOffice for Outlook through the Microsoft 365 Admin Center or PowerShell.
keywords: SuperOffice for Outlook, Outlook, email, deploy, add-in, PowerShell, Microsoft 365 Admin Center.
author: Frode B, Martin Pavlas
date: 09.17.2024
version_sofo: 2024.8.12
topic: howto
language: en
---

# Centralized deployment

You can perform centralized deployment either through the Microsoft 365 Admin Center or PowerShell. The Centralized Deployment service lets you deploy **Office Web add-ins** to users of Excel, Outlook, PowerPoint, and Word.

> [!TIP]
> Install for a single user instead? [Go to the user guide][5].

## Deploy via PowerShell

After you create a remote Windows PowerShell session on your Exchange server, you can install an Outlook add-in using the **New-App** cmdlet with this PowerShell command:

```powershell
New-App -URL:"https://superofficeforoutlook.superoffice.com/manifest/manifest.xml">
```

> [!TIP]
> Read how to [install an add-in by using remote powershell][1] in Microsoft docs.

You can manage mailbox add-ins with the following PowerShell cmdlets:

| cmdlet | Description |
|---|---|
| Get-App | Lists the enabled add-ins for a mailbox. |
| Set-App | Enables or disables an add-in on a mailbox. |
| Remove-App | Removes a previously installed add-in from an Exchange server. |

## Deploy via Microsoft 365 admin center

To deploy SuperOffice for Outlook using the Microsoft 365 admin center, see [Microsoft's documentation][3].

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/office/dev/add-ins/outlook/testing-and-tips#install-an-add-in-by-using-remote-powershell
[3]: https://learn.microsoft.com/en-us/microsoft-365/admin/manage/manage-deployment-of-add-ins?view=o365-worldwide
[5]: ../learn/get.md
