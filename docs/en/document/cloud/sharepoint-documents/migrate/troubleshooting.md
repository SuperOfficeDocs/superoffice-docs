---
title: Troubleshooting
uid: sharepoint-documents-migration-trouble
description: Tips for troubleshooting a SharePoint document migration.
author: Frode Berntsen, Bergfrid Dias
date: 01.15.2024
keywords: SharePoint, document, migrate, library, access, Microsoft Entra, ME-ID
topic: howto
version:
envir: cloud
client: online
---

# Troubleshooting

See [requirements for SharePoint document library][2].

## Migration tool need access to target library (Access Token Error 400)

The migration tool uses the user's Microsoft access token to create and store the document in SharePoint. (SuperOffice stores credentials on login from the point in time "SharePoint Documents" is configured.)

All users with a user plan and who owns a document that should be migrated must log in via `online.superoffice.com` AFTER "SharePoint Documents" is configured.

## User need access to SharePoint (Error 404)

All users with a user plan and who owns a document that should be migrated:

* Must use IDP authentication towards the target SharePoint site (SuperID password is not sufficient).

* Must be a Microsoft Entra (formerly AAD) user in SharePoint-target (access right is not sufficient).

## Retired users don't have access to target library

You need **SuperOffice Documents library app** to migrate documents owned by old or retired users (no user plan). You can't turn this on the first time you configure SharePoint documents. It must be fully configured first.

### <a id="approve-app"></a>To approve the app (system user)

1. Make sure the configuration of SharePoint document library is complete.
2. Go to **Settings and maintenance** > **Preferences** > **Document library**.
3. Click **Settings**. This re-starts the configuration wizard.
4. Go to **Step 3 - Groups and access**.

    ![SharePoint documents migration, authorize app (system user)-screenshot][img9]

5. Click **Enable system user for storing documents in SharePoint**.

    This is a one-time authorization and will include only the site you selected for your SuperOffice documents. If you are a Microsoft 365 Global Administrator, you can authorize now. If not, copy the URL and send it to someone in your organization with that role.​ They must also be in the owner group of the site (to set Read Write permission)​.

6. Complete the wizard and save.

## Missing files (Error Not found in the document archive)

**Problem:**

A file is no longer stored in source (CRM Online) after migrating from onsite or cleaning up manually with a CRMScript or similar.

**Solution:**

Open the file from the CRM client to be able to migrate it.

To check if the file exist in source (CRM Online), download the archive using the SuperOffice Download tool.

## Missing content in files (Error Bad Request - Value cannot be NULL)

**Problem:**

It is no longer possible to open or use a file (corrupted) after migrating from onsite or manually changing the file.

**Solution:**

Same as for missing files. See above.

## Access to files

If "Visible for" is set on a file, it requires **SuperOffice Documents library app** to migrate that document.

## File with same filename (Error 409 Conflict)

Conflicts might happen based upon how you have configured the folder structure in the target SharePoint site. If two files with identical names are migrated to the same folder, it will result in a 409 error.

**Solution:**

Manually rename the second file before your next migration job. Contact support if needed.

## Permission denied while creating document!

Most likely the SharePoint user account does not have sufficient rights to create the file in that folder.

Check your SharePoint setup. Ask your SharePoint admin for help.

## Unable to find document

**Cause:**

The document's "Visible for" property is set to a (SuperOffice) group that the user no longer belongs to and the group has been deleted in SuperOffice Settings and maintenance.

**Solution:**

Update the document's properties to an existing group or to "all". Alternatively, restore the deleted group.

## Unable to edit legacy office files (.doc, .xls, .ppt)​

This is a [known limitation][1].

**Problem:**

* Creating a document from SuperOffice CRM works fine, but when you try to edit the document, you will notice that you cannot do so.

* Opening a document from SuperOffice CRM works fine, but when you try to edit the document, you will notice that you cannot do so.

**Solution:**

You must use **Edit Document** > **Open in Desktop App**.

![Open legacy Microsoft document -screenshot][img4]

> [!NOTE]
> Do NOT use **Edit and then convert**! This will create a copy of the document and next time you open it from SuperOffice the changes are gone. The same applies if you open a document from within SharePoint.

## Related content

* [Scopes and explanations why our integration need it][3]

<!-- Referenced links -->
[1]: index.md#limitations
[2]: ../requirements.md
[3]: ../permissions-app.md

<!-- Referenced images -->
[img4]: ../../../../../media/loc/en/document/edit-legacy-document.png
[img9]: ../../../../../media/loc/en/document/authorize-app.png
