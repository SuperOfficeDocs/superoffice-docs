---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: deploy_superoffice_for_outlook_centrally       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Centralized deployment # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# Centralized deployment

Centralized deployment can be performed either via O365 Admin GUI or via PowerShell.

The Centralized Deployment service lets you deploy ‎Office‎ Web add-ins to users of ‎Excel‎, ‎Outlook‎, ‎PowerPoint‎, and ‎Word‎.

> [!TIP]
> Deploy for a single user instead? [Go to guide](deploy-office-add-in.md)

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
> Read how to [install an add-in by using remote powershell][9] in Microsoft docs.

## Deploy using the admin center

1. Log in to Office365 admin (with "global admin" rights).
2. Open Admin center (and set to use "old" O365 Admin GUI).
3. Go to *Settings > Services & add-ins*.

![imageefsif.png][1]

4. Click **Deploy add-in**, then:
    * Choose add an add-in from the Office Store, or
    * Choose "upload custom app", Copy/paste in this URL to the dialog:
    `https://superofficeforoutlook.superoffice.com/manifest/manifest.xml`

![imageg8a0i.png][2]

5. Follow the steps and make your selections along the way.

![image9i9x1.png][3]

![imageevshb.png][4]

![imagep08e5.png][5]

![image5t4dr.png][6]

![image6dm4b.png][7]

![image2ha3f.png][8]

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/imageefsif.png
[2]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/imageg8a0i.png
[3]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/image9i9x1.png
[4]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/imageevshb.png
[5]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/imagep08e5.png
[6]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/image5t4dr.png
[7]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/image6dm4b.png
[8]: https://community.superoffice.com/contentassets/4676af12ff874b618e0cfb3ec0f05c8c/image2ha3f.png
[9]: https://docs.microsoft.com/en-us/office/dev/add-ins/outlook/testing-and-tips#install-an-add-in-by-using-remote-powershell