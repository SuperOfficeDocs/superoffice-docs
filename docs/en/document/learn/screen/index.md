---
uid: help-en-document-dialog
title: Document dialog
description: Document dialog
author: SuperOffice RnD
so.date: 06.29.2022
keywords: document
so.topic: concept
language: en
---

# The Document dialog

The central feature of the document function is the **Document** dialog, which you can open in different ways:

* By selecting **New** > **Document**.
* By opening an [existing document][1].

The dialog consists of a main section with general information about the document, and the following tabs with additional information:

* Details
* Links
* More

## Main section

The main section contains the following essential information about the document:

### Document template

Click the arrow ![icon][img1] next to the type field at the top of the dialog to display a list of document templates that you can choose from. [!include[SM](../../../learn/includes/are-defined-sm.md)] Or, type the whole or the beginning of the name to search for a specific template.

> [!NOTE]
> When you [create a document][5], the template opens in the program it was created in. For example, DOCX files will open in Word.

### Company

Enter here the name of the company you are writing to. You can search directly from this field.

### Contact

Click the arrow next to this field and a list of known contacts in the company is displayed.

### Project

Enter the name of the project that the document is linked to. You can search directly from this field.

### Sale

Enter the name of the sale (if any) that the document is linked to. You can search directly from this field.

### Type subject here

Enter the text to be used as a heading for the document (the text that is displayed in section tabs and reports where the document is listed).

### Language

Select a language for the template. This option is only available if the selected template includes translated versions.

### Date

Today's date is displayed automatically in this field. If you click the arrow next to the **Date** field, this brings up a monthly calendar where you can select the date you require.

> [!NOTE]
> You can change the date only when you create the document. You cannot access this field in edit mode.

### Our ref

Enter your own reference. The default entry for each template is defined in Settings and maintenance, but you can also edit the content of this field.

### Your ref

Enter the addressee's reference from their communication.

### Visible for

Click the **Visible for** field to display a list that allows you to choose if the document should be visible to all users, private (visible only to the user defined as owner), or visible to all users in one of the user groups that the owner belongs to.

> [!NOTE]
> If you set visibility to owner only, the document will appear in italics on the **Activities** section tab.

### Checked out for editing

If the document is checked out for editing, one of the following icons are displayed:

![icon][img2] The document is currently checked out for editing by you.

![icon][img3] The document is currently checked out for editing by another user.

> [!TIP]
> Hold the mouse pointer over an icon to show information about the user who checked out the document.

### Completed

By default, the document is marked as completed (![icon][img4]), but you can remove this check mark if you wish (![icon][img5]). The document will then be displayed on the **Activities** section tab in the Diary screen until it is marked as completed.

> [!NOTE]
> You cannot edit a completed document until you have undone its **Completed** status. [How to change Completed status of an activity][7].

### User-defined fields

[!include[3 udef](../../../learn/includes/more-udef.md)]

> [!NOTE]
> User group membership is defined in the Users screen in Settings and maintenance.

### Task

When you click this button, the following options are displayed:

* **Delete**: Deletes the current entry.
* **Help**: Opens the help for the active dialog.
* **Copy shortcut**: Copies a [shortcut to the active entry][9].
* **Revert to saved version**: Select this option to [cancel a check-out][4]. For example, if you checked out the document by mistake and are unable to check it in again.

Below these options are shortcuts to other relevant tasks that can be performed on the active entry. In Settings and maintenance, you can also define your own tasks and add them under the **Task** button.

## Details tab

The **Details** tab contains detailed information about the document.

* **Description:** Here you can enter a description of the document. This may be useful for freetext searching.

* **Document:** Click the link to upload the document or drag and drop the document from Windows Explorer to the **Document** dialog.

    For details, see [Create new documents][5] and [Edit documents][1].

**Publish:** Check here if you want the document to be visible to external users in Audience (requires a separate license).

## Links tab

This tab contains information about activities (documents and follow-ups) and sales that are linked to the document in question. If anything is registered in this tab, a dot is displayed next to **Links**.

[Read more about how to add links][2].

## More tab

This tab displays any [user-defined fields][3] configured in Settings and maintenance.

## The www tab

[!include[About the www tab](../../../learn/includes/www-tab.md)]

<!-- Referenced links -->
[1]: ../edit.md
[4]: ../lock.md
[5]: ../create.md
[7]: ../../../diary/learn/change-completed-status.md
[9]: ../../../onsite/win-client/learn/creating-shortcuts-to-entries-in-crm.md
[2]: ../../../diary/learn/linking-documents-to-follow-ups.md
[3]: ../../../custom-objects/learn/udef/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-icon.png
[img2]: ../../../../media/icons/document-lock-editing.png
[img3]: ../../../../media/icons/document-lock-locked.png
[img4]: ../../../../media/icons/followup-completed-small.png
[img5]: ../../../../media/icons/followup-not-completed-small.png
