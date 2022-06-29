---
uid: help-en-document-dialog
title: Document dialog
description: Document dialog
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# The Document dialog

The central feature of the document function is the **Document** dialog, which you can open in different ways:

* By selecting **New** &gt; **Document**.
* By opening an existing document (see [Edit documents](Editing-documents.md)).

The dialog consists of a main section with general information about the document, and the following tabs with additional information.

* [Details](Details-tab-Document.md)
* [Links](Links-tab-(Document).md)
* [More](More-tab-Document.md)

The main section contains the following essential information about the document:

**\[Document template\]**

Click the arrow ( ![icon](../media/Dialogboksknapper-pil-ned.bmp) ) next to the type field at the top of the dialog to display a list of document templates that you can choose from. The available templates are defined in SuperOffice Settings and maintenance. Here you can also use [FastSearcher](../chap01/Using-FastSearcher.md).

> [!NOTE]
> The templates may have been created in various programs, for example, Word or Excel, so when you create a document (see [Create new documents](Creating-new-documents.md)), the template is opened in the program it was created in. This means, for example, that DOCX files will open in Word.

\[Company\]

Enter here the name of the company you are writing to. You can search directly from this field.

\[Contact\]

Click the arrow next to this field and a list of known contacts in the company is displayed.

\[Project\]

Enter the name of the project that the document is linked to. You can search directly from this field.

\[Sale\]

Here you enter the name of the sale, if any, that the document is linked to. You can search directly from this field.

\[Type subject here\]

Enter here the text to be used as a heading for the document. This is the text which is displayed in section tabs and reports where the document is listed.

Language

Select a language for the template. This option is only available if the selected template includes translated versions.

**Date**

Today's date is displayed automatically in this field. If you click the arrow next to the **Date** field, this brings up a monthly calendar where you can select the date you require.

> [!NOTE]
> You can only change the date when you create the document. You cannot access this field in edit mode.

**Our ref.**

Enter your own reference. The default entry for each template is defined in SuperOffice Settings and maintenance, but you can also edit the content of this field.

Your ref.

Enter the addressee’s reference from their communication.

Visible for

Click the **Visible for** field to display a list that allows you to choose whether the document will be visible to all users, private (i.e. visible only to the user defined as owner), or visible to all users in one of the user groups that the owner belongs to.

> [!NOTE]
> If you specify that a document will only be visible to the owner, it will appear in italics on the **Activities** section tab.

Checked out for editing

If the document has been checked out for editing, one of the following icons are displayed:

![icon](../media/documentlock-editing.png) The document is currently checked out for editing by you.

![icon](../media/documentlock-locked.png) The document is currently checked out for editing by another user.

**Tip**: Hold the mouse pointer over an icon to show information about the user who has checked out the document.

**Completed**

By default, the document is marked as completed ( ![icon](../media/followup-completed-SMALL.png) ), but you can remove this check mark if you wish ( ![icon](../media/followup-notcompleted-SMALL.png) ). The document will then be displayed on the **Activities** section tab in the **Diary** screen until it is marked as completed.

> [!NOTE]
> You cannot edit a completed document until you have undone its **Completed** status. See [Change Completed status of an activity](Marking-activities-as-completed-not-completed.md).

\[User-defined fields\]

Here, three of the fields from the **More** tab may be displayed (see [The More tab](More-tab-Document.md)), as defined in SuperOffice Settings and maintenance. The fields displayed can vary from user group to user group.

> [!NOTE]
> User group membership is defined in the **Users** screen in SuperOffice Settings and maintenance.

Task

When you click this button, the following options are displayed:

* **Delete**: Deletes the current entry.
* **Help**: Opens the help for the active dialog.
* **Copy shortcut**: Copies a shortcut to the active entry. See [Create shortcuts to entries in SuperOffice CRM](../chap03/Creating-shortcuts-to-entries-in-CRM.md).
* **Revert to saved version**: Select this option to cancel a check-out. This may be relevant if you have checked out the document by mistake and are unable to check it in again. See [Check in/out documents](doc-checkoutin.md).

Below these options are shortcuts to other relevant tasks that can be performed on the active entry. In SuperOffice Settings and maintenance, you can also define your own tasks and add them under the **Task** button. For more information about this, see the Help for SuperOffice Settings and maintenance.
