---
title: Security
uid: g_suite_security
description:  Google Workspace document integration security
author: {github-id}
keywords:
topic: concept
envir: cloud
client: online
---

# Security

## Default access permission on documents

Documents created via SuperOffice which are hosted in Google Drive will be given a default-permission that is "accessible to anyone in the Google Workspace" domain.
This default behavior can be changed to "inheritance to folder" by contacting Support.

## Security-related UI details

Users of SuperOffice Online opening documents hosted in Google Drive will see these documents in their Google drive recent document list.
The owner name will be the one used for the Service Account when the service-account was created:

![Owner of folders -screenshot][img1]

This is how Google Drive collaboration works.
The actual SOARC document-tree will not be visible nor accessible in the end-users drive directory tree:

![Google drive example -screenshot][img2]

This is not a bug. This is by design.

## Set access permission on document archive for cross-domain access

> [!WARNING]
> Items with any link sharing option can be published on the web, and potentially be a risk that other people can get access to it.

Documents are created in Google Drive by the service-account (owner), but users of other domains will by default not have access to open it.

* This can be achieved by either sharing the Google Drive folder with specific users or using Google Group (for easier management).

* Contact support if you like to put all SuperOffice documents and templates into one Google Drive folder; provide the folder name.

> [!NOTE]
> This is an example of custom setup and is not supported by SuperOffice, but can be achieved by configuring your Google Workspace access permissions and is supervised and managed by the customer themselves.

Documents created via SuperOffice that are hosted in Google Drive will be given a default-permission that is "accessible to anyone in the Google Workspace" domain.
If your company and business structure use/cross multiple Google Workspace domains (ie. companyA.com, companyB.com, companyC.com) - users belonging to other domains than the domain the service-account belongs to, will get a "You need permission" page, by default.

**To add access permission on document archive for cross-domain access:**

> [!TIP]
> Pay attention to which account you sign in with. Different steps require different accounts!

1. Sign in as Google Admin of the domain that belongs to the service-account.

2. Add your other domain names to the [Whitelisted external domains][3].

3. [Create a group][4] and edit the group information settings:
    * Select **Allow members outside your organization**
    * Modify the group settings to suit your needs (Posting options, who can join, Permissions, and so on)
    * For more info, see [Google Help: Create a Google Group][5]

4. Add your other domain-users to this [group][6] by selecting the group (clicking check), and click **Add users to group**. For more info, see [Google Help: Add members to the group][1].

    ![Add users to group -screenshot][img3]

5. Sign in as SO Google service-account.

6. Edit Share settings for the folder in [Drive][2] to include this group (from step 3).

![Edit share settings -screenshot][img4]

![Confirmation dialog -screenshot][img5]

The users belonging to other domains than the domain the service-account belongs to should now have access.

<!-- Referenced links -->
[1]: https://support.google.com/groups/answer/2465464
[2]: https://drive.google.com/drive/my-drive
[3]: https://admin.google.com/AdminHome?hl=en#DomainsDetails:flyout=trustedDomains
[4]: https://admin.google.com/AdminHome#GroupList:
[5]: https://support.google.com/groups/answer/2464926
[6]: https://admin.google.com/AdminHome?hl=en#GroupList:

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/gsiarc.png
[img2]: ../../../../media/loc/en/document/gsiarc2.png
[img3]: ../../../../media/loc/en/document/imagehhza.png
[img4]: ../../../../media/loc/en/document/googlesharearchive.png
[img5]: ../../../../media/loc/en/document/imagerrxjg.png
