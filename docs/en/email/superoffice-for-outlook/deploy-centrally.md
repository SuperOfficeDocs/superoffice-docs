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

1. Log in to Microsoft 365 admin (with "global admin" rights).
2. Open Admin center (and set to use "old" Microsoft 365 Admin GUI).
3. Go to *Settings > Services & add-ins*.

    ![imageefsif.png -screenshot][img1]

4. Click **Deploy add-in**, then:
    * Choose to add an add-in from the Office Store, or
    * Choose "upload custom app", Copy/paste in this URL to the dialog:
    `https://superofficeforoutlook.superoffice.com/manifest/manifest.xml`

    ![imageg8a0i.png -screenshot][img2]

5. Follow the steps and make your selections along the way.

![image9i9x1.png -screenshot][img3]

![imageevshb.png -screenshot][img4]

![imagep08e5.png -screenshot][img5]

![image5t4dr.png -screenshot][img6]

![image6dm4b.png -screenshot][img7]

![image2ha3f.png -screenshot][img8]

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/office/dev/add-ins/outlook/testing-and-tips#install-an-add-in-by-using-remote-powershell
[2]: deploy-office-add-in.md

<!-- Referenced images -->
[img1]: media/imageefsif.png
[img2]: media/imageg8a0i.png
[img3]: media/image9i9x1.png
[img4]: media/imageevshb.png
[img5]: media/imagep08e5.png
[img6]: media/image5t4dr.png
[img7]: media/image6dm4b.png
[img8]: media/image2ha3f.png
