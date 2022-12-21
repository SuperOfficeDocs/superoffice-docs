---
uid: help-en-document-lock
title: Check in/out documents
description: Check in/out documents
author: SuperOffice RnD
so.date: 06.29.2022
keywords: document
so.topic: help
language: en
---

# Check in/out documents

In SuperOffice CRM, many people are creating, editing and reading documents at any given time. If multiple users are editing the same document at the same time, they risk overwriting each other's data. To prevent this from happening, SuperOffice CRM will lock a document when it is being edited by a user. Other users can still open the document, but only in read mode.

> [!NOTE]
> If your organization uses a document library like SharePoint, multiple people can edit a document simultaneously.

## How do I know when a document is checked out?

In the **Document** dialog, a checked-out document has one of the following icons:

![icon][img3] The document is currently checked out for editing by you.

![icon][img4] The document is currently checked out for editing by another user.

Hold the mouse pointer over an icon to show information about the user who checked out the document.

If you attempt to open a checked-out document, a dialog appears with information about who checked out the document. You can open the document in read mode only.

## Check out a document for editing

Open a document and select to [edit the document][1]. The document is checked out for editing by you. Other users can only open the document in read mode.

## Check in a document after editing

In most cases, you can [save and close the document][1] in the application, and the document is checked in automatically.

## Edit mode and read mode

By default, a document is opened in edit mode.

> [!NOTE]
> If you prefer to select read mode or edit mode when you open a document, go to ![icon][img2] **Personal settings** > **Preferences** > **Functions** and set **Ask to edit or read** to **Yes**.

* Edit mode: The document is opened for editing. The document cannot be edited by other users until you save and close the document, which automatically checks in the document.

> [!NOTE]
> If you do not want a document to be automatically checked in when you save and close it, you can activate the **Suggest check-in when editing is complete** option in **Preferences** in SuperOffice WebTools.

* Read mode: The document is opened for reading. If you make changes to the document, they will not be saved. To [save the document with your changes][1], you must create a new document in SuperOffice CRM and upload the file with your changes.

## Cancel a check-out (revert to saved version)

> [!CAUTION]
> If another user has checked out a document, always contact that user before performing this procedure. Otherwise there is a risk that you overwrite someone else's changes or the other user overwrites your changes when they check in the document
>
> The best option may be to make a copy of the document and edit the copy.

If you or someone else checked out a document, and you want to edit the document, you can cancel the check out:

1. Right-click the document and select **Document**.
2. In the **Document** dialog, click ![icon][img1] and select **Revert to saved version**.

> [!NOTE]
> You need special privileges to access this option. You also need write access to the document.

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/document-lock-editing.png
[img4]: ../../../media/icons/document-lock-locked.png
