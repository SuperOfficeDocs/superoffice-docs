---
uid: help-en-document-create
title: Create new document
description: Create a new document directly in SuperOffice CRM or upload existing ones, to make sure you and your colleagues always have access to the latest documents and versions. This how-to guide will show you how to do both.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: document
so.topic: howto
language: en
---

# Create new documents

> [!TIP]
> Already have the document? See [Upload documents][1].

Follow the instructions below, depending on how documents are managed in your SuperOffice installation:

> [!NOTE]
> This feature requires a license.

## How do I know if I am using SharePoint, SuperOffice WebTools or not?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Create a new document with SharePoint Documents

1. Click **New** > **Document** on the top bar.

2. [Complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The document is created in SharePoint and opened in a new tab with the online text-editing application (Office Online).

    > [!NOTE]
    > To use your desktop editing program, you can choose **Open in Desktop App** from Office Online.

4. Type in the contents of the document.

5. Close the tab or your desktop app. The document is automatically saved to SharePoint.

## Create a new document without SuperOffice WebTools

If you have not installed SuperOffice WebTools, you must manually download documents to edit them. Afterwards, you must upload the edited documents to the central server.

> [!NOTE]
> This procedure describes how to create new documents if you are using a desktop text-editing application. The actual process may be slightly different if you use an online text-editing tool (like Microsoft Office Online) and a document library (like SharePoint).

1. Click **New** > **Document** on the top bar.

2. [Complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The document is created on the server.

4. Click **Open** and **Edit**.

5. In the **File download** dialog, select one of the following buttons:

    * **Open**: When you click **Open**, the document is opened in the text editing application. Type in the contents of the document and select **File** > **Save As** to save it in the desired location on your PC.

    * **Save**: When you click **Save**, the **Save As** dialog appears. Specify where on the PC you want to save the file, and then click **Save** to start the download. Click **Close** when the download is finished. Open Windows Explorer and browse to the document you have just saved. Open the document, enter the required text and save the document.

6. Close the text-editing program.

7. Go to the Document screen.

    > [!NOTE]
    > If ![icon][img1] **Completed** is checked in the Document screen, the upload options are disabled. In that case, remove the **Completed** check mark.

8. Click the link to upload the document or drag and drop the document from Windows Explorer to the **Document** dialog.

    ![Create a new document -screenshot][img2]

9. Close the **Document** dialog by clicking **Save**.

## Create a new document using SuperOffice WebTools

With SuperOffice CRM, you can log in from any PC using a browser, but your documents will then be saved on the central server. Downloading and uploading of documents are handled automatically by SuperOffice WebTools.

1. Click **New** > **Document** on the top bar.

2. [Complete the fields with the required information][2].

3. Click the **Create** button to create a new document based on the selected document template. The **Document** dialog closes automatically, and the document opens in your default text-editing application.

4. Type in the content of your document.

5. Save it and close the text-editing application. The document is saved.

## Related topics

* [WebTools][3]
* [Send email attachments from SuperOffice][4]
* [Manage document templates in Settings and maintenance][5]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: ../../webtools/learn/index.md
[4]: send-as-email.md
[5]: ../../admin/lists/learn/add-template.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img2]: media/upload.png
