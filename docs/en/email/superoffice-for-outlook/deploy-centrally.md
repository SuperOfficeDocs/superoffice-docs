---
title: Centralized deployment
uid: deploy_superoffice_for_outlook_centrally
description: Centralized deployment
author: {github-id}
keywords:
topic: howto
envir: cloud
client: online
---

# Centralized deployment

Centralized deployment can be performed either via Microsoft 365 Admin GUI or via PowerShell.

The Centralized Deployment service lets you deploy Office Web add-ins to users of Excel, Outlook, PowerPoint, and Word.

> [!TIP]
> Deploy for a single user instead? [Go to guide][2].

## Deploy via PowerShell

Install the add-in by using remote PowerShell: 

After you create a remote Windows PowerShell session on your Exchange server, you can install an Outlook add-in by using the **New-App** cmdlet with the following PowerShell command.

```powershell
New-App -URL:"https://superofficeforoutlook.superoffice.com/manifest/manifest.xml">
```

You can use the following additional PowerShell cmdlets to manage the add-ins for a mailbox:

* **Get-App** - Lists the add-ins that are enabled for a mailbox.
* **Set-App** - Enables or disables an add-in on a mailbox.
* **Remove-App** - Removes a previously installed add-in from an Exchange server.

> [!TIP]
> Read how to [install an add-in by using remote powershell][1] in Microsoft docs.

## Deploy using the admin center

To deploy SuperOffice for Outlook using the admin center, see the documentation for Microsoft 365: [Microsoft learn][3]


<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/office/dev/add-ins/outlook/testing-and-tips#install-an-add-in-by-using-remote-powershell
[2]: deploy-office-add-in.md
[3]: https://learn.microsoft.com/en-us/microsoft-365/admin/manage/manage-deployment-of-add-ins?view=o365-worldwide

