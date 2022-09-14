---
uid: help-en-creating-new-documents
title: Creating new documents
description: Creating new documents
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Create new documents

> [!TIP]
> If you just want to upload a document, see [Upload documents][1].

Follow the instructions below, depending on how documents are managed in your SuperOffice installation:

[!include[Requirement](../includes/req-licence-gen.md)]

## How do I know if I am using SharePoint, SuperOffice Web Tools or not?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Create a new document with SharePoint Documents

Do as follows:

1. Click **New** &gt; **Document** on the top bar.

2. The **Document** dialog opens. Complete the fields with the required information. See [The Document dialog][2] for an explanation of what to enter here.

3. Click the **Create** button to create a new document based on the selected document template. The document is created in SharePoint and opened in a new tab with the online text-editing application (Office Online).

    > [!NOTE]
    > If you want to use your desktop editing program, you can choose **Open in Desktop App** from Office Online.

4. Type in the contents of the document.

5. Close the tab or your desktop app. The document is automatically saved to SharePoint.

## Create a new document without SuperOffice Web Tools

If you have not installed SuperOffice Web Tools, you need to manually download documents to edit them. You also have to upload the edited documents to the central server afterwards.

> [!NOTE]
> This procedure describes how to create new documents if you are using a desktop text-editing application. The actual process may be slightly different if you use an online text-editing tool (like Microsoft Office Online) and a document library (like SharePoint).

Do as follows:

1. Click **New** &gt; **Document** on the top bar.

2. The **Document** dialog opens. Complete the fields with the required information. See [The Document dialog][2] for an explanation of what to enter here.

3. Click the **Create** button to create a new document based on the selected document template. The document is created on the server.

4. Click **Open** and **Edit**. The **File download** dialog opens automatically. Here you can click one of the following buttons:

    * **Open**: When you click **Open**, the document is opened in the text editing application. Type in the contents of the document and select **File** &gt; **Save As** to save it in the desired location on your PC.

    * **Save**: When you click **Save**, the **Save As** dialog appears. Here you specify where on the PC you want to save the file, and then click **Save** to start the download. Click **Close** when the download has finished. Open Windows Explorer and browse to the document you have just saved. Open the document, enter the required text and save the document.

5. Close the text-editing program.

6. Go to the **Document** dialog.

    > [!NOTE]
    > If **Completed** is checked ( ![icon][img1] ) in the **Document** dialog, the upload options are disabled. In that case, remove the **Completed** check mark.

7. Click the link to upload the document.
    or
    <!-- Fix reuse ID=a3 --> the document from Windows Explorer to the **Document** dialog.

    ![Create a new document -screenshot][img2]

8. Close the **Document** dialog by clicking **Save**.

## Create a new document using SuperOffice Web Tools

With SuperOffice CRM, you can log in from any PC using a browser, but your documents will then be saved on the central server. Downloading and uploading of documents are handled automatically by SuperOffice Web Tools.

1. Click **New** &gt; **Document** on the top bar.

2. The **Document** dialog opens. Complete the fields with the required information. See [The Document dialog][2] for an explanation of what to enter here.

3. Click the **Create** button to create a new document based on the selected document template. The **Document** dialog is closed automatically, and the document opens in your default text-editing application.

4. Type in the content of your document.

5. Save it and close the text-editing application. The document is saved.

## Related topics

* [Web Tools][3]

<!-- Referenced links -->
[1]: upload-documents.md
[2]: document-dialog.md
[3]: ../document/web-tools.md

<!-- Referenced images -->
[img1]: ../../media/icons/followup-completed-small.png
[img2]: media/docfileuploaddragdrop.png
