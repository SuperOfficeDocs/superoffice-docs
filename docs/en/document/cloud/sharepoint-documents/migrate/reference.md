---
title: The SharePoint migration UI
uid: sharepoint-documents-migration-ui
description: An explanation of the SharePoint document migration wizard and overview page.
author: Frode Berntsen, Bergfrid Dias
so.date: 11.02.2023
keywords: SharePoint, document
so.topic: reference
so.version:
so.envir: cloud
so.client: online
---

# The SharePoint migration UI

## Overview of jobs

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

## Job status

| Status | Description |
|---|---|
| Not started | The job is preparing and has not started yet. |
| Templates started  | Currently moving templates. |
| Documents started | Currently moving documents. |
| Completed | All documents (and templates) were successfully migrated. |
| Partially completed | Unable to move some documents (missing CRM documents). |
| Completed with failures | One or more documents failed, but the job completed. |
| Failed | For some unknown reason, the job failed. |
| Cancellation in progress | Someone clicked **Cancel**, but the job needs to finish ongoing migration before stopping. |
| Cancelled | The job was cancelled. |

## Job details

![SharePoint documents migration job details -screenshot][img3]

The **Summary** section shows a summary of the jobs scheduled using the wizard.

The **Status** section shows a detailed status of ongoing and completed jobs. It sums up the migration. If the migration fails, you will get an error report.

## Pre-migration tests (step 2)

![SharePoint document migration step 2 -screenshot][img7]

### Analyzing documents to be moved

| Test | Description |
|---|---|
| Identifying number of documents | Counts all documents based on step 1. |
| Identifying number of templates | The first time, all templates are counted. |
| Access to target document library | Checks if the tool has sufficient rights to move documents to the new library. |
| Access to target template library | Checks if the tool has sufficient rights to move templates to the new library. |
| Testing licenses | Checks if there are user plans (licenses) for all user owning one or more of the selected documents. |
| Testing user credentials | Checks if the tool has credentials for all users in the selected documents. |
| Testing access for users without credentials (app permission) | Checks if the document set includes orphaned documents (not skipping documents owned by former employees). Then checks if the required app is authorized. |
| Testing access rights for user groups (visible for) | Checks if you have enabled visible for. Then tests if user groups used by the documents being migrated are mapped to SharePoint domain groups. |
| Identifying documents to migrate | Creates the result set after removing documents belonging to users without credential (if that is ticked) and documents belonging to users without credentials and visible for on document is set to "me". |

### Documents to be moved - estimates

| Statistic | Description |
|---|---|
| Total number of documents | Selected documents (from step 1). |
| Documents that will not be moved | Documents omitted for various reasons. Click the icon for more information. |
| Documents already moved | Documents already in your new library. |
| Documents to be moved | The number of documents that will actually be moved. |

![SharePoint document migration, not moved -screenshot][img4]

* **Owned by users that have not logged into CRM and given consent to store documents:** After configuring SharePoint, all users must log in and give their consent for the integration to store documents in SharePoint. Otherwise, documents belonging to those users will not be moved.

## Related content

* [Steps][1]

<!-- Referenced links -->
[1]: steps.md

<!-- Referenced images -->
[img1]: media/migration-completed-with-failures.png
[img3]: media/migration-job-details.png
[img4]: media/documents-omitted.png
[img7]: media/migrate-step-2.png
