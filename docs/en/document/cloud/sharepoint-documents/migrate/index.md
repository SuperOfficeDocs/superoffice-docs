---
title: Migration guide
uid: sharepoint-documents-migration
description: Introduction to SuperOffice SharePoint document migration.
author: Frode Berntsen, Bergfrid Dias
so.date: 11.02.2023
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

How do you handle documents that have never been stored in SoArc Online? Perhaps your organization has used Microsoft 365 Document Integration (also referred to as Office 365 Document Integration, 365 CloudOffice, 365 SharePoint document integration, and O365 integration) since it started using SuperOffice. Here's how it works:

We use **SharePoint version 1.0** for the legacy Microsoft 365 Document Integration. To facilitate this, we employ the **SuperOffice Integrator App** in Microsoft 365 SharePoint.

In addition, we use **SharePoint version 3.x** for "SuperOffice SharePoint documents" (2.x and 3.x). To migrate these documents to SharePoint version 3.x, we rely on the **SuperOffice SharePoint Migration** tool.

Documents created with SharePoint version 1.0 are already stored in SharePoint. The process of [configuring "SharePoint version 3.x"][4] and [migrating existing documents][6] to it is essentially the same, whether you use so_arc (online) or SharePoint version 1.0 as a document archive for SuperOffice documents. Our tests have shown that migration is successful, but **two manual steps** are required during migration by the Online Operations or RnD Services team:

* Update access tokens to enable reading of existing Office 365 documents.
* Deactivate SharePoint version 1.0.

### AAD external users

Additionally, there is one limitation in SharePoint version 3.x compared to version 1.0, which affects migration and usage for external users:

* IdP authentication requires all users to use the same MS subscription.

The legacy login process in SharePoint version 1.0 allows authentication for both internal users within the same Azure Active Directory tenant and external users, including those from other Azure subscriptions or external organizations. However, SharePoint version 3.x lacks support for AAD external users due to limitations in the Microsoft Graph API.

When migrating documents created by AAD external users from SharePoint version 1.0 to SharePoint version 3.x, the documents' ownership transfer to the **SuperOffice App**. Admins should remove the user plan for these users during migration.

After migration, AAD external users won't be able to create new documents in SharePoint version 3.x from SuperOffice. To identify AAD external users, refer to Microsoft Azure Active Directory or Microsoft Entra ID under **Users**, where they may be labeled as *Guest* or *External AD* in terms of user type or identity. Alternatively, their User Principal Name may be in a specific format, such as `[externalUPN-name]#EXT#@[internaldomainname].onmicrosoft.com`.

### Steps

1. SuperOffice Admin: [Configure SuperOffice SharePoint documents][4].

    > [!NOTE]
    > If you have AAD external users, remove SuperOffice user plans for SuperOffice users who are AAD external users.

1. Online Operations: Run access token fix. This will update access tokens to be able to read existing Office 365 documents.

    > [!NOTE]
    > Ask support to **Run access token fix for customer XXXX**.

1. SuperOffice Admin: [Run SuperOffice SharePoint Migration][6] to migrate documents to the SharePoint document library.

1. Online Operations: Remove Microsoft 365 Document Integration (legacy) setup. This will remove/turn off the old legacy login process "SuperOffice Integrator App in Microsoft 365 SharePoint" to normal SuperID login process.

    > [!NOTE]
    > Ask support to **Turn off SharePoint 1.0 for customer XXXX**.

### Hybrid solutions

Sometimes a customer uses Microsoft 365 Document Integration but store signed documents (from DataBridge or other 3.party document integration) in SoArc Online.

The solution is simple: Move everything to SharePoint documents 2.x.

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
[img5]: media/sharepoint-wizard.png
