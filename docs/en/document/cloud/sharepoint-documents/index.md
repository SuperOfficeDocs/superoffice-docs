---
title: SharePoint documents
uid: sharepoint-documents
description: SharePoint document integration for SuperOffice
author: Frode Berntsen
so.date: 05.11.2023
keywords: SharePoint, document
so.topic: concept
so.version:
so.envir: cloud
so.client: online
---

# SharePoint documents

## What is SharePoint documents?

Open, edit, and store documents in Microsoft 365 SharePoint directly from SuperOffice.

All documents you write or archive from SuperOffice will be stored in your SharePoint Online repository, where you have total control forever. These documents can also be accessed by everyone in your company. Even those who do not use SuperOffice.

Activating **SharePoint Online Documents** makes SharePoint Online the preferred document repository for all your documents.

A self-service UI to provision and configure SharePoint as SO repository from SuperOffice Settings and Maintenance.

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

* Backup of documents - this is now no longer managed by SuperOffice - evaluation is required if the current backup schedule of SharePoint fits well.

* Availability of documents - when documents are stored in SuperOffice, they are only available in the front-end client as the SO_ARC folder is unavailable to users. In SharePoint, the document libraries are accessible and therefore this may be considered a disadvantage by some customers.

  > [!NOTE]
  > You need **Global Admin** rights in Microsoft 365 to be able to authenticate SuperOffice as a trusted app in your Microsoft 365 solution.

You can also check out our [webinar about the SharePoint integration][1].

## Summarized steps on how to set up SharePoint documents

### If NOT using `Visible for` (Confidential activities)

1. Check Requirements
    * SuperOffice Online tenant
    * Microsoft 365 for business subscription
    * `Global Administrator` rights in Microsoft 365 / `AAD Service Account` user
    * All users in CRM Online use Microsoft AAD Authentication - read more: [Federated ID and identity providers][2]
    * All users with user plan must be in the same Microsoft AAD subscription

2. Set up Microsoft 365 SharePoint
	1. (* ) Aquire or create an `AAD Service Account` user, (*) with `Global Administrator`- [Read more][3]
	2. (*) Create or use existing AAD groups - [Read more][4]
	3. Create a SharePoint site (* use the `AAD Service Account` user) - [Read more][5]
	4. Create a document library for documents (* use the `AAD Service Account` user) - [Read more][6]
	5. Create a document library for templates (* use the `AAD Service Account` user) - [Read more][7]

3. Set up SuperOffice 
	1. Run Configuration wizard - [Read more][8]
	2. Enable system user for storing documents in SharePoint (* use the `AAD Service Account` user) - [Read more][9]

(*) = Recommended


### If using `Visible for` (Confidential activities)

1. Check Requirements
    * SuperOffice Online tenant
    * Microsoft 365 for business subscription
    * `Global Administrator` rights in Microsoft 365 / `AAD Service Account` user
    * All users in CRM Online use Microsoft AAD Authentication - read more: [Federated ID and identity providers][2]
    * All users with user plan must be in the same Microsoft AAD subscription
    * `Confidential activities` is enabled for one or more SuperOffice users in SuperOffice Settings and maintenance
        * `Visible for` set on one or more documents in SuperOffice

2. Set up Microsoft 365 SharePoint
    1. (*) Aquire or create an `AAD Service Account` user with `Global Administrator` - [Read more][3] 
    2. Create AAD groups - [Read more][10] 
        * The Group type must be Microsoft 365 and not Security
            1. Create `TemplateEditors` AAD group
            2. Create corresponding AAD groups to your SuperOffice user groups
        * Add AAD users to the AAD group they belong to
    4.  Create a SharePoint site (* use the `AAD Service Account` / Set `AAD Service Account` user or the one to be used in #3.2 - to be in the owner group of the site) - [read more][5]
    5.  Create a document library for documents (* use the `AAD Service Account` user) - [Read more][6]
    6.  Create a document library for templates (* use the `AAD Service Account` user) - [Read more][7]
    7.  Set up SharePoint document library permissions for *Documents* - [Read more][11] 
        * Grant permissions -> add AAD groups (from #2.ii.b)
            * Permission level `Edit` (off: "Share everything...", off: "Send an email invitation")
    8. Set up SharePoint document library permissions for *Templates* - [Read more][4]
        1. Stop inheriting permissions
        2. Change permissions for AAD groups (from #2.ii.b): Edit User Permissions -> `Read` - [Read more][12] 
        3. Grant permissions -> add AAD groups (from #2.ii) - [Read more][13]
            * For `TemplateEditors`:  permission level `Edit` (off: "Share everything...", off: "Send an email invitation")
            * For "normal users": permission level `Read` (off: "Share everything...", off: "Send an email invitation")

3. Set up SuperOffice
    1. Run Configuration wizard - [Read more][8]
    2. Enable system user for storing documents in SharePoint, use the Service Account - [Read more][9]
    3. Map your SuperOffice user groups to corresponding AAD groups - [Read more][14]

(*) = Recommended



<!-- Referenced links -->
[1]: https://youtu.be/8mIo3Yac2QI?t=589
[2]: ../../../identity-management/federated-id-and-identity-providers.md
[3]: permissions-in-sharepoint.md#aad-service-account-for-superoffice-documents
[4]: configure-permissions-templates.md#step-3b--grant-permissions
[5]: set-up.md#step-1---create-a-sharepoint-site-in-your-microsoft-365-sharepoint
[6]: set-up.md#step-2---create-a-document-library-for-documents-in-your-sharepoint-site
[7]: set-up.md#step-3---create-a-document-library-for-templates-in-your-sharepoint-site
[8]: configure-superoffice.md
[9]: configure-superoffice.md#apps-for-superoffice-system-user
[10]: permissions-in-sharepoint.md
[11]: configure-permissions-documents.md
[12]: configure-permissions-templates.md#step-3a--change-permissions
[13]: configure-permissions-templates.md#step-4--review-the-sharepoint-site-groups
[14]: configure-superoffice.md#group-access-based-on-visible-for-settings-in-superoffice-is-ticked-on

<!-- Referenced images -->
