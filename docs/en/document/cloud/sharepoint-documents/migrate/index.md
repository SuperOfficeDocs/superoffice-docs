---
title: Migration guide
uid: sharepoint-documents-migration
description: Introduction to SuperOffice SharePoint document migration.
author: Frode Berntsen, Bergfrid Dias
so.date: 08.18.2023
keywords: SharePoint, document, Microsoft
so.topic: concept
so.version:
so.envir: cloud
so.client: online
---

# Migration guide

SuperOffice SharePoint Document Migration is a powerful tool that allows users to seamlessly transfer documents from CRM Online storage to a SharePoint document library. By leveraging this automated process, businesses can centralize their document management, ensuring easy access, collaboration, and organization of files.

## Why migrate

Optimize document management and foster a more productive and collaborative work environment. By migrating documents to SharePoint, users can leverage the full suite of Microsoft 365 features. This integration enables seamless access to advanced functionalities such as document versioning, advanced search, real-time co-authoring, and integration with other Microsoft applications.

SharePoint provides granular access control, allowing businesses to define permissions at the document, library, or site level. Users can restrict access to confidential information and ensure that only authorized individuals can view or edit specific documents.

[View more benefits][1]

## How it works

During the migration, selected documents and ALL templates are transferred to SharePoint. This ensures that users have access to their templates in the new document library.

After migration, you can open and edit your existing SuperOffice documents in Microsoft 365 SharePoint directly from SuperOffice. These documents can also be accessed from SharePoint by everyone in your company, even those who don't use SuperOffice.

> [!NOTE]
> If your organization has set up and uses "Visible for" in SuperOffice, "Visible for me" and "Visible for group" documents become private in Sharepoint. "Visible for all" documents get default access rights from SharePoint.

If a document is owned by a user who doesn't exist in SharePoint, the SharePoint App is set as its new owner (you can choose to not migrate such documents)​. These documents will also be in the folder *Other* if you have chosen *Folder structure – user group*.

Successfully moved documents will be deleted from the source library​ (ensuring a seamless transition to SharePoint).

If a document fails to be migrated, it is left as-is in SuperOffice CRM Online and can be re-migrated later. Documents that can't be moved will be available as before.

### The wizard

The migration wizard guides administrators step-by-step to transfer selected documents from CRM Online to SharePoint.

The migration wizard has 3 steps. Each step must be completed (passed) before you can move to the next step.

1. Select documents. This allows for a more targeted and organized migration process.
1. Review and test.
1. Confirm and schedule job. You can now start the job.

![SharePoint document migration wizard -screenshot][img5]

* The **Next step** button is unavailable until you have finished the current step.
* Click **Previous step** to go back one step.
* Click **Cancel** to go back to the **Status** page.

[Go to the wizard][6]

## Requirements

> [!NOTE]
> SuperOffice SharePoint Documents must be fully configured before you can migrate to SharePoint.
>
> [List of requirements to set up SharePoint Documents][2]

All SuperOffice users with a user plan must log in to CRM Online AFTER configuration and BEFORE migration. Otherwise, the migration-tool cannot create documents in SharePoint on behalf of the user.

To move orphaned documents (those without a SharePoint owner), we need a **Global Administrator** to authorize the SuperOffice Documents library app. This app has already been approved if customers are using Visible for.​

## Limitations

* Maximum 20 000 documents can be migrated in one migration job. You can select how many documents to migrate per job by creating a document selection. If you plan to migrate more than this limit, divide the documents into multiple migration jobs, each within the limit.

* The process of migrating documents is time-consuming since both the document itself and its metadata needs to be transferred.

    The API of SharePoint sets restrictions on speed and synchronous file-transfer and is usually the limiting factor. If you plan to migrate thousands of documents, it might take days to complete! We recommend that you take this into account in your project plan.

* Unmovable documents: Some documents may not be eligible for migration and will remain in CRM Online storage.

* Legacy Microsoft Office files(.doc, .xls, .ppt)​: Due to limitations in the Graph API and SharePoint itself, these documents can be edited only with the desktop application (not online).

    We strongly recommend that you replace your old legacy template with a template based on the current format.

## <a id="legacy" />Migrate from Microsoft 365 Document Integration (legacy)

How do you handle documents that have never been stored in SoArc Online? Perhaps your organization has used Microsoft 365 Document Integration since it started using SuperOffice.

For easier refrence and understanding, we use **"SharePoint version 1.0"** for the legacy version of "Microsoft 365 Document Integration" (aka. "Office 365 Document Integration", "365 CloudOffice", "365 SharePoint document integration", "O365 integration", and uses "SuperOffice Integrator App in Microsoft 365 SharePoint" to fasilitate the use of it), and **"SharePoint version 3.x"** for "SuperOffice SharePoint documents" (2.x and 3.x), and **"SuperOffice SharePoint Migration"** as the tool to migrate the documents to "SharePoint version 3.x", in this section:

Documents created with "SharePoint version 1.0" are already stored in SharePoint. In theory, [configuring "SharePoint version 3.x"][4] and [migrating existing documents to "SharePoint version 3.x"][6] are the very much same whether you use so_arc (online) or "SharePoint version 1.0" as an document archive for SuperOffice documents.
Our tests indicate that it works fine to migrate, but there is 2 manual steps needed to be performed by Online Operations / RnD Services team during migration, and there is one limitation in "SharePoint version 3.x" compared to "SharePoint version 1.0" affecting migration and useage for external users:
* Update access tokens to be able to read existing O365 documents
* Turn off "SharePoint version 1.0"
* IdP authentication needs all users using same MS subscription. 

> [!NOTE]
> The old legacy login process of "SharePoint version 1.0" (using "SuperOffice Integrator App" in Microsoft 365 SharePoint) provides the capability to authenticate both internal users (belonging to the same Azure Active Directory tenant) and external users (guest users belonging to another Azure subscription or even external organizations). "SharePoint version 3.x" does not support AAD external users due to limitations in the Microsoft Graph API. You should be able to migrate documents created by / owned by AAD external users in "SharePoint version 1.0" to"SharePoint version 3.x", but the owner will then be the "SuperOffice App" for all those documents. During migration Admin needs to remove the user plan for those users while migrating. As "SharePoint version 3.x" does not support AAD external users, those AAD external users will not be able to create new document in "SharePoint version 3.x" from SuperOffice afterwards. You can identify those users in Microsoft Azure Active Directory / Microsoft Entra ID -> Users: User Type or Identities say "Guest" or "External AD", or have 'User Principal Name' in format of [exernalUPN-nam]#EXT#@[internaldominaname].onmicrosoft.com etc.

Here are the steps:
1. SuperOffice Admin: Configure SuperOffice SharePoint documents (and if you have AAD external users: remove SuperOffice user plans for SuperOffice users who are AAD external users)
1. Online Operations: Run access token fix
1. SuperOffice Admin: Run SuperOffice SharePoint Migration to migrate documents to the SharePoint document library
1. Online Operations: Remove 'Microsoft 365 Document Integration' (legacy) setup

> [!NOTE]
> For step # 2 and step # 4: Ask support to **Run access token fix for customer XXXX** (This will  Update access tokens to be able to read existing O365 documents) / Ask support to **Turn off SharePoint 1.0 for customer XXXX** (This will remove/turn off the old legacy login process "SuperOffice Integrator App in Microsoft 365 SharePoint" to normal SuperID login process. )

### Hybrid solutions

Sometimes a customer uses Microsoft 365 Document Integration but store signed documents (from DataBridge or other 3.party document integration) in SoArc Online.

The solution is simple: Move everything to SharePoint documents 2.x

If you have a third-party app that creates documents in SuperOffice, you need to [enable the system user for storing documents in SharePoint][7].

## Related content

* [Step-by-step migration guide][6]
* [Best practices][5]
* [Scopes and explanations why our integration need it][3]

<!-- Referenced links -->
[1]: ../index.md#benefits
[2]: ../requirements.md
[3]: ../permissions-app.md
[4]: ../set-up.md
[5]: best-practices.md
[6]: steps.md
[7]: troubleshooting.md#approve-app

<!-- Referenced images -->
[img5]: ../media/sharepoint-wizard.png
