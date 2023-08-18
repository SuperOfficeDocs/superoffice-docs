---
title: Migration guide
uid: sharepoint-documents-migration
description: SharePoint document migration - How to move documents from a previously used library.
author: Frode Berntsen
so.date: 08.18.2023
keywords: SharePoint, document
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

## Best practices

1. Preparations. Read the [requirements](#requirements) and [best practices](#best-practices) carefully.
2. Run a test migration of a few documents.
3. Analyze the report (send it to SuperOffice R&D and receive guidance from us).
4. Correct issues and complete preparations.
5. Run migration.
6. Adjust and re-run documents that failed.

### Plan ahead

Before initiating the migration process, carefully plan the structure of your SharePoint document library. Consider creating folders, organizing documents by category or department, and defining permissions for different user groups.

### Clean up and organize

Take the opportunity to de-clutter and organize your documents before migrating them. Remove any unnecessary or outdated files, ensuring that only relevant and valuable documents are transferred to SharePoint.

Especially for old documents, it might be cumbersome to plan for all eventualities and make all necessary preparations up front. This will result in error-situations and unplanned events, which then lead to some documents failing on the first run.

### Test and validate

Before migrating all your documents, perform a test migration with a small sample set. This allows you to validate the migration process, ensure that the documents are transferred correctly, and identify any potential issues or errors.

Set aside time for corrections and re-runs.

### Communicate and train

Inform your team members about the upcoming migration and provide them with the necessary training to effectively use SharePoint. Conduct workshops or webinars to educate users on SharePoint's features and functionalities.

## Start migration

> [!WARNING]
> The SuperOffice administrator needs to complete the migration wizard before any changes are done to the documents. This is crucial!

1. Go to **Settings and maintenance** > **Preferences** > **Document library**.
2. Click **Move documents from a previously used library, or open migration overview**.

### Step 1 - Select documents

In the first step of the wizard, you select which documents from your old library you want to migrate.

![SharePoint document migration step 1 -screenshot][img6]

1. Choose one of the following options:

    * All documents
    * All documents created after
      * January 1st the previous year by default. Adjust as needed.
    * All documents in selection
      * Choose a selection.

    > [!NOTE]
    > A document selection can be used as the source of which documents to migrate in a specific migration-job. It can also be used to ensure you don't exceed the limitation of 20 000 documents.

2. Optionally, mark the checkbox to skip documents owned by former employees.

3. Click **Next step**.

### Step 2 - review and test

Based on what was selected in step 1, the wizard will run tests to make sure the migration tool will be able to move documents. If one of these tests failed, we will provide you with an [explanation and how to fix it](#troubleshooting).

![SharePoint document migration step 2 -screenshot][img7]

Click **Next step** to proceed. The button does not turn green and clickable until all tests pass.

**Analyzing documents to be moved:**

| Test | Description |
|---|---|
| Identifying number of documents | Counts all documents based on step 1. |
| Identifying number of templates | The first time, all templates are counted. |
| Access to target document library | Checks if the tool has sufficient rights to move documents to the new library. |
| Access to target template library | Checks if the tool has sufficient rights to move templates to the new library. |
| Testing user credentials | Checks if the tool has credentials for all users in the selected documents. |
| Testing access for users without credentials (app permission) | Checks if the document set includes orphaned documents (not skipping documents owned by former employees). Then checks if the required app is authorized. |
| Testing access rights for user groups (visible for) | Checks if you have enabled visible for. Then tests if user groups used by the documents being migrated are mapped to SharePoint domain groups |
| Identifying documents to migrate | Creates the result set after removing documents belonging to users without credential (if that is ticked) and documents belonging to users without credentials and visible for on document is set to "me". |

**Documents to be moved - estimates:**

| Statistic | Description |
|---|---|
| Total number of documents | Selected documents (from step 1). |
| Documents omitted | Documents belonging to users without credentials and visible for on document is set to "me" + documents belonging to users without credential (if that is ticked).
| Documents already moved | Documents already in your new library. |
| Documents to be moved | The number of documents that will actually be moved. |

### Step 3 - Confirm and schedule job

![SharePoint document migration step 3 -screenshot][img8]

1. Review the summary of the job.
2. Read and pay attention to the notes. This is your last warning before documents are changed!
3. When you are absolutely sure, click **Start job now**.

    The migration job begins. The wizard returns you to the overview page where you can track the progress. You can't start a new migration while the current job runs.

## Jobs

![SharePoint documents migration -screenshot][img2]

| Column | Description |
|---|---|
| Date | When the job was created. |
| Status | The current state of the job. |
| Start | Date and time the job started. |
| End | Date and time when the job ended, shows a progress bar during ongoing job. |
| #moved | The number of documents and templates that have been moved. |
| Source | The source selected in step 1 of the wizard. |
| Details | Light bluish = OK; Light orange = some failures; Light red = failed. Click the button to see details. |

![SharePoint documents migration -screenshot][img1]

### Status

| Status | Description |
|---|---|
| Not started | The job is preparing and has not started yet. |
| Templates started  | Currently moving of templates. |
| Documents started | Currently moving of documents. |
| Completed | All documents (and templates) were successfully migrated. |
| Completed with failures | One or more documents failed, but the job completed. |
| Failed | For some unknown reason, the job failed. |
| Cancellation in progress | Someone clicked **Cancel**, but the job needs to finish ongoing migration before stopping. |
| Cancelled | The job was cancelled. |

### Details

![SharePoint documents migration job details -screenshot][img3]

The **Summary** section shows a summary of the scheduled using the wizard.

The **Status** section shows a detailed status of ongoing and completed jobs.

## Troubleshooting

See [requirements for SharePoint document library][2].

### Migration tool need access to target library (Access Token Error 400)

The migration tool uses the user's Microsoft access token to create and store the document in SharePoint. (SuperOffice stores credentials on login from the point in time "SharePoint Documents" is configured.)

All users with a user plan and who owns a document that should be migrated must log in via `online.superoffice.com` AFTER "SharePoint Documents" is configured.

### User need access to SharePoint (Error 404)

All users with a user plan and who owns a document that should be migrated:

* Must use IDP authentication towards the target SharePoint site (SuperID password is not sufficient).

* Must be an AAD user in SharePoint-target (access right is not sufficient).

### Retired users need access to target library

You need **SuperOffice Documents library app** to migrate documents owned by old or retired users (no user plan). You can't turn this on the first time you configure SharePoint documents. It must be fully configured first.

To approve the app (system user):

1. Make sure the configuration of SharePoint document library is complete.
2. Go to **Settings and maintenance** > **Preferences** > **Document library**.
3. Click **Settings**. This re-starts the configuration wizard.
4. Go to **Step 3 - Groups and access**.

    ![SharePoint documents migration, authorize app (system user)-screenshot][img9]

5. Click **Enable system user for storing documents in SharePoint**.

    This is a one-time authorization and will include only the site you selected for your SuperOffice documents. If you are a Microsoft 365 Global Administrator, you can authorize now. If not, copy the URL and send it to someone in your organization with that role.​ They must also be in the owner group of the site (to set Read Write permission)​.

6. Complete the wizard and save.

### Missing files (Error Not found in the document archive)

**Problem:**

A file is no longer stored in source (CRM Online) after migrating from onsite or cleaning up manually with a CRMScript or similar.

**Solution:**

Open the file from the CRM client to be able to migrate it.

To check if the file exist in source (CRM Online), download the archive using the SuperOffice Download tool.

### Missing content in files (Error Bad Request - Value cannot be NULL)

**Problem:**

It is no longer possible to open or use a file (corrupted) after migrating from onsite or manually changing the file.

**Solution:**

Same as for missing files. See above.

### Access to files

If "Visible for" is set on a file, it requires **SuperOffice Documents library app** to migrate that document.

### File with same filename (Error 409 Conflict)

Conflicts might happen based upon how you have configured the folder structure in the target SharePoint site. If two files with identical names are migrated to the same folder, it will result in a 409 error.

**Solution:**

Manually rename the second file before your next migration job. Contact support if needed.

### Permission denied while creating document!

Most likely the SharePoint user account does not have sufficient rights to create the file in that folder.

Check your SharePoint setup. Ask your SharePoint admin for help.

### Unable to find document

**Cause:**

The document's "Visible for" property is set to a (SuperOffice) group that the user no longer belongs to and the group has been deleted in SuperOffice Settings and maintenance.

**Solution:**

Update the document's properties to an existing group or to "all". Alternatively, restore the deleted group.

### Unable to edit legacy office files (.doc, .xls, .ppt)​

This is a [known limitation](#limitations).

**Problem:**

* Creating a document from SuperOffice CRM works fine, but when you try to edit the document, you will notice that you cannot do so.

* Opening a document from SuperOffice CRM works fine, but when you try to edit the document, you will notice that you cannot do so.

**Solution:**

You must use **Edit Document** > **Open in Desktop App**.

![Open legacy Microsoft document -screenshot][img4]

> [!NOTE]
> Do NOT use **Edit and then convert**! This will create a copy of the document and next time you open it from SuperOffice the changes are gone. The same applies if you open a document from within SharePoint.

## Legacy

## Related content

* [Scopes and explanations why our integration need it][3]

<!-- Referenced links -->
[1]: index.md#benefits
[2]: requirements.md
[3]: permissions-app.md

<!-- Referenced images -->
[img1]: media/migration-completed-with-failures.png
[img2]: media/migration-started.png
[img3]: media/migration-job-details.png
[img4]: media/edit-legacy-document.png
[img5]: media/sharepoint-wizard.png
[img6]: media/migrate-step-1.png
[img7]: media/migrate-step-2.png
[img8]: media/migrate-step-3.png
[img9]: media/authorize-app.png
