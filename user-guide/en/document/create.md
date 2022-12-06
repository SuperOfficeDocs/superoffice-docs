---
uid: help-en-document-create
title: Creating new documents
description: Creating new documents
author: SuperOffice RnD
so.date: 06.29.2022
keywords: document
so.topic: help
language: en
---

# Create new documents

> [!TIP]
> If you just want to upload a document, see [Upload documents][1].

Follow the instructions below, depending on how documents are managed in your SuperOffice installation:

[!include[Requirement](../includes/req-licence-gen.md)]

## How do I know if I am using SharePoint, SuperOffice WebTools or not?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Create a new document with SharePoint Documents

1. Click **New** > **Document** on the top bar.

2. In the **Document** dialog, [complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The document is created in SharePoint and opened in a new tab with the online text-editing application (Office Online).

    > [!NOTE]
    > If you want to use your desktop editing program, you can choose **Open in Desktop App** from Office Online.

4. Type in the contents of the document.

5. Close the tab or your desktop app. The document is automatically saved to SharePoint.

## Create a new document without SuperOffice WebTools

If you have not installed SuperOffice WebTools, you need to manually download documents to edit them. Afterwards, you must upload the edited documents to the central server.

> [!NOTE]
> This procedure describes how to create new documents if you are using a desktop text-editing application. The actual process may be slightly different if you use an online text-editing tool (like Microsoft Office Online) and a document library (like SharePoint).

1. Click **New** > **Document** on the top bar.

2. In the **Document** dialog, [complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The document is created on the server.

4. Click **Open** and **Edit**.

5. In the **File download** dialog, select one of the following buttons:

    * **Open**: When you click **Open**, the document is opened in the text editing application. Type in the contents of the document and select **File** > **Save As** to save it in the desired location on your PC.

    * **Save**: When you click **Save**, the **Save As** dialog appears. Here you specify where on the PC you want to save the file, and then click **Save** to start the download. Click **Close** when the download has finished. Open Windows Explorer and browse to the document you have just saved. Open the document, enter the required text and save the document.

6. Close the text-editing program.

7. Go to the **Document** dialog.

    > [!NOTE]
    > If **Completed** is checked ( ![icon][img1] ) in the **Document** dialog, the upload options are disabled. In that case, remove the **Completed** check mark.

8. Click the link to upload the document.
    or drag and drop the document from Windows Explorer to the **Document** dialog.

    ![Create a new document -screenshot][img2]

9. Close the **Document** dialog by clicking **Save**.

## Create a new document using SuperOffice WebTools

With SuperOffice CRM, you can log in from any PC using a browser, but your documents will then be saved on the central server. Downloading and uploading of documents are handled automatically by SuperOffice WebTools.

1. Click **New** > **Document** on the top bar.

2. In the **Document** dialog, [complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The **Document** dialog is closed automatically, and the document opens in your default text-editing application.

4. Type in the content of your document.

5. Save it and close the text-editing application. The document is saved.

## Related topics

* [WebTools][3]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: web-tools.md

<!-- Referenced images -->
[img1]: ../../media/icons/followup-completed-small.png
[img2]: media/docfileuploaddragdrop.png
