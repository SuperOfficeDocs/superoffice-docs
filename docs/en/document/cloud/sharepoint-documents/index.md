---
title: SharePoint documents
uid: sharepoint-documents
description: SharePoint document integration for SuperOffice
author: Frode Berntsen
so.date: 11.01.2023
keywords: SharePoint, document
so.topic: concept
so.version:
so.envir: cloud
so.client: online
---

# SharePoint documents

In today's digital age, effective document management is essential for businesses to streamline their operations and enhance collaboration among team members.

## What is SharePoint documents?

Open, edit, and store documents in Microsoft 365 SharePoint directly from SuperOffice.

All documents you write or archive from SuperOffice will be stored in your SharePoint Online repository, where you have total control forever. These documents can also be accessed by everyone in your company. Even those who do not use SuperOffice.

Activating **SharePoint Online Documents** makes SharePoint Online the preferred document repository for all your documents.

A self-service UI to provision and configure SharePoint as SO repository from SuperOffice Settings and maintenance.

## Benefits

* Run SuperOffice as a SaaS solution without any need of locally-installed software on a client computer.
  * No need to deploy WebTools/OML to users.

* Enable true document collaboration.
  * All Microsoft 365 features are available as normal.
  * Be able to work together in the same document at the same time.
  * Be able to share documents with anyone and have access to older versions of the document at any time.

* As a SuperOffice user, you don't have to think about where the documents are located.
  * Make SuperOffice documents available as any other document in SharePoint.
  * Sharing, revision history and other MS 365 features made available.

* Work with SuperOffice documents from any device.

* Advanced data access options (Visible for...)
  * Visible for me - private in SharePoint
  * Visible for all - default access rights from SharePoint
  * Visible for group - private in SharePoint

## Things to consider

### Data rights for a role

[!include[data rights](includes/req-data-rights.md)]

### Backup

> [!NOTE]
> With SharePoint as your document library, SuperOffice no longer handles backup of documents
>
> Microsoft SharePoint Online has a different backup regime than SuperOffice CRM Online have!

As a platform, Microsoft 365 is secure, but your data is not backed up in a way that most organizations require. Typically, there's only a 30-day retention period built into Microsoft 365. Microsoft SharePoint Online is backed up only every 12 hours, with just a 14-day retention period.

> "SharePoint Online retains backups of all content for 14 additional days beyond actual deletion. If content cannot be restored via the Recycle Bin or Files Restore, an administrator can contact Microsoft Support to request a restore any time inside the 14 day window. Microsoft 365 backs up your SharePoint site every 12 hours."

*[Microsoft online documentation (technet.microsoft.com)][20]*

### Availability

When documents are stored in SuperOffice, they are available only in the front-end client as the SO_ARC folder is unavailable to users. In SharePoint, the document libraries are accessible and therefore this may be considered a disadvantage by some customers.

  > [!NOTE]
  > You need **Global Admin** rights in Microsoft 365 to be able to authenticate SuperOffice as a trusted app in your Microsoft 365 solution.

You can also check out our [webinar about the SharePoint integration][1].

## How to set up SharePoint documents - summary

(R) = Recommended

### If NOT using Visible for (Confidential activities)

1. Check requirements:
    [!include[ALT](includes/req-general.md)]
    [!include[AAD](includes/req-usage.md)]

2. Set up Microsoft 365 SharePoint
    1. (R) [Get or create an AAD Service Account user with Global Administrator][3].
    2. (R) [Create or use existing AAD groups][13].
    3. [Create a SharePoint site][5].
        (R) Use the *AAD Service Account* user.
    4. [Create a document library for documents][6].
        (R) Use the *AAD Service Account* user.
    5. [Create a document library for templates][7].
        (R) Use the *AAD Service Account* user.

3. Set up SuperOffice
    1. [Run Configuration wizard][8].
    2. [Enable system user][9] for storing documents in SharePoint, use the AAD Service Account.

### If using Visible for (Confidential activities)

1. Check requirements:
    [!include[ALT](includes/req-general.md)]
    [!include[AAD](includes/req-usage.md)]
    * *Confidential activities* is enabled for one or more SuperOffice users in SuperOffice Settings and maintenance.
      * *Visible for* is set on one or more documents in SuperOffice.

2. Set up Microsoft 365 SharePoint
    1. (R) [Get or create an AAD Service Account user with Global Administrator][3].
    2. [Create AAD groups][2]. The Group type must be Microsoft 365 and not Security.
        1. Create *TemplateEditors* AAD group.
        2. Create corresponding AAD groups to your SuperOffice user groups.
        3. Add AAD users to the AAD group they belong to.
    3. [Create a SharePoint site][5]
        (R) Use the *AAD Service Account* OR Set *AAD Service Account* user (or the one to be used later to create the library for templates) to be in the owner group of the site.
    4. [Create a document library for documents][6].
        (R) Use the *AAD Service Account* user.
    5. [Create a document library for templates][7].
        (R) Use the *AAD Service Account* user.
    6. [Set up SharePoint document library permissions for *Documents*][11]
        * Grant permissions to the AAD groups you added above in step 2.2 *except TemplateEditors*.

            | Group | Permission level | Values |
            |---|---|---|
            | Regular users | Edit | off: "Share everything...", off: "Send an email invitation |

    7. [Set up SharePoint document library permissions for *Templates*][13]
        1. Stop inheriting permissions.
        2. [Change permissions for existing AAD groups][12].
            Click **Edit User Permissions** and select **Read**.
        3. [Grant permissions to all AAD groups you added above in step 2.2][14].

            | Group | Permission level | Values |
            |---|---|---|
            | TemplateEditors | Edit | off: "Share everything...", off: "Send an email invitation |
            | Regular users | Read | off: "Share everything...", off: "Send an email invitation" |

3. Set up SuperOffice
    1. [Run Configuration wizard][8].
    2. [Enable system user][9] for storing documents in SharePoint, use the AAD Service Account.
    3. [Map your SuperOffice user groups to corresponding AAD groups][10].

<!-- Referenced links -->
[1]: https://youtu.be/8mIo3Yac2QI?t=589
[2]: permissions-in-sharepoint.md
[3]: permissions-in-sharepoint.md#aad-service-account

[5]: set-up.md#step-1
[6]: set-up.md#step-2
[7]: set-up.md#step-3

[8]: configure-superoffice.md
[9]: configure-superoffice.md#apps
[10]: configure-superoffice.md#step-3

[11]: configure-permissions-documents.md
[12]: configure-permissions-templates.md#step-3a
[13]: configure-permissions-templates.md#step-3b
[14]: configure-permissions-templates.md#step-4

[20]: https://social.technet.microsoft.com/Forums/en-US/1906d6db-94ea-42dd-9d4d-9c50205bdeac/do-we-have-to-backup-our-sharepoint-online-sites-or-this-is-been-managed-for-us?forum=onlineservicessharepoint

<!-- Referenced images -->
