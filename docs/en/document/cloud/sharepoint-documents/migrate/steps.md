---
title: Migration guide
uid: sharepoint-documents-migration-steps
description: SharePoint document migration - How to move documents from a previously used library.
author: Frode Berntsen, Bergfrid Dias
date: 08.18.2023
keywords: SharePoint, document
topic: howto
version:
envir: cloud
client: online
---

# Migration guide

Have you checked the [requirements][3] and [best practices][5]? We strongly advice you to do so.

## Step 0 - Start the wizard

1. Go to **Settings and maintenance** > **Preferences** > **Document library**.
2. Click **Move documents from a previously used library, or open migration overview**.

> [!WARNING]
> The SuperOffice administrator needs to complete the migration wizard before any changes are done to the documents. This is crucial!

## Step 1 - Select documents

In the first step of the wizard, you select which documents from your old library you want to migrate.

![SharePoint document migration step 1 -screenshot][img6]

1. Choose one of the following options:

    * All documents
    * All documents created after
      * January 1st the previous year by default. Adjust as needed.
    * All documents in selection
      * Choose a selection.

    > [!NOTE]
    > A document [selection][6] can be used as the source of which documents to migrate in a specific migration-job. It can also be used to ensure you don't exceed the limitation of 20 000 documents.

2. Optionally, mark the checkbox to skip documents owned by former employees.

3. Click **Next step**.

## Step 2 - review and test

Based on what was selected in step 1, the wizard will run tests to make sure the migration tool will be able to move documents.

![SharePoint document migration step 2 -screenshot][img7]

Click **Next step** to proceed. The button doesn't turn green and clickable until all tests pass.

* [Explanation of the tests][2]
* [Error codes and advice on how to fix them][4]

## Step 3 - Confirm and schedule job

![SharePoint document migration step 3 -screenshot][img8]

1. Review the summary of the job.
2. Read and pay attention to the notes.
3. When you are sure, click **Start job now**.

    The migration job begins. The wizard returns you to the overview page where you can track the progress. You can't start a new migration while the current job runs.

    ![SharePoint documents migration -screenshot][img2]

## Related content

* [About SharePoint Document migration][1]
* [Best practices][5]
* [How to create a selection][6]

<!-- Referenced links -->
[1]: index.md
[2]: reference.md
[3]: index.md#requirements
[4]: troubleshooting.md
[5]: best-practices.md
[6]: ../../../../search-options/selection/learn/create/index.md

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/document/migration-started.png
[img6]: ../../../../../media/loc/en/document/migrate-step-1.png
[img7]: ../../../../../media/loc/en/document/migrate-step-2.png
[img8]: ../../../../../media/loc/en/document/migrate-step-3.png
