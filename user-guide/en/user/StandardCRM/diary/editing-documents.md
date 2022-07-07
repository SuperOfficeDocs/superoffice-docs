---
uid: help-en-editing-documents
title: Editing documents
description: Editing documents
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Edit documents

Editing documents involves two things:

* Editing of the document properties, which is done in the **Document** dialog.
* Editing of the document file itself, which is done in the application the document was created in.

> [!NOTE]
> You can open a document in edit mode or in read mode. When you open the document in edit mode, only you can edit the document. Other users can open the document in read mode. See [Check in/out documents](doc-checkoutin.md).  
If your organisation uses a document library like SharePoint, multiple people can edit a document simultaneously.

Click the required link, depending on how documents are managed in your SuperOffice installation:

[Edit document content using SharePoint Documents](Editing-documents.md#Edit-document-content-using-SharePoint-Documents)

[Edit document content - without SuperOffice Web Tools](Editing-documents.md#Editing-document-properties-in-Document-dialog-without-plug-in-Web)

[Edit document content - using SuperOffice Web Tools](Editing-documents.md#Editing-document-properties-in-Document-dialog-with-plug-in-Web)

[!include[Requirement](../../includes/req-licence-gen.md)]

## How do I know if I am using SharePoint, SuperOffice Web Tools or not?

[!include[How to check document library](../../includes/webtools-or-sharepoint.md)]

## Edit document properties in the Document dialog

To change document properties, for example, the project to which the document is linked, you need to use the **Document** dialog:

1. Select the required document. (See [Open documents](Opening-documents.md) for how to do this.)
2. Right-click and select **Document**. If you double-click on the document, it opens directly in the application it was created in.
3. Make the required changes in the **Document** dialog. (See [The Document dialog](Document-dialog.md)).

<!-- -->

1. Click the **Save** button.

## Edit document content using SharePoint Documents

Do as follows:

1. Double-click the required document. (See [Open documents](Opening-documents.md) for how to do this.) The document opens in a new tab with the online text-editing program (Office Online).

    > [!NOTE]
    > If you want to use your desktop editing program, you can choose **Open in Desktop App** from Office Online.

2. Edit the document.

3. Close the tab or your desktop app. The document is automatically saved to SharePoint

## Edit document content - without SuperOffice Web Tools

> [!NOTE]
> This procedure describes how to create new documents if you are using a desktop text-editing application. The actual process may be slightly different if you use an online text-editing tool (like Microsoft Office Online) and a document library (like SharePoint).

1. Double-click the required document. (See [Open documents](Opening-documents.md) for how to do this.) The **Document** dialog opens.
2. Click **Open**.
3. If a dialog box displays, click **Edit**.
4. The file download dialog opens automatically. Choose from the following options:
    * **Open**: When you click the option for opening, the document is opened in the text-editing application. Type in the contents of the document and select **File** &gt; **Save As** to save it in the desired location on your PC.
    * **Save**: When you click the option for saving, the **Save As** dialog appears. Specify where on your PC you want to save the file, and save it. Then open the document, enter the required text and save the document.
5. Close the text-editing program.
6. Go to the **Document** dialog.

> [!NOTE]
> If **Completed** is checked in the **Document** dialog, the upload options are disabled. In that case, remove the **Completed** check mark.

1. Click the link to upload the document.  
    or  
    <!-- Fix reuse ID=a3 --> the document from Windows Explorer to the **Document** dialog.
    ![icon](../media/chap04-activities/DocFileUploadDragDrop.png)

<!-- -->

1. Close the **Document** dialog by clicking **Save**. The document is checked in and the status is set to **Completed**.

## Edit document content - using SuperOffice Web Tools

1. Double-click the required document. (See [Open documents](Opening-documents.md) for how to do this.)
2. If a dialog box displays, click **Edit**.
3. Save it and close the text-editing application.
4. (if applicable) In the dialog that appears, click **Yes** if you are done editing the document. Click **No** to keep the document checked out. This dialog only appears if you have activated this option in SuperOffice Web Tools.
5. The document is checked in and the status is set to **Completed**.

## Troubleshooting

If you double-click a document and nothing happens, try to right-click it and select **Document**. This opens the **Document** dialog. Click **Open** and see if the document opens now.
