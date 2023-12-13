---
uid: help-en-document-update
title: Editing documents
description: Editing documents
author: SuperOffice RnD
so.date: 12.06.2023
keywords: document
so.topic: howto
language: en
---

# Edit documents

Editing documents involves two things:

* Editing of the document properties in the Document screen.
* Editing of the document file itself in the application the document was created in.

You can open a document in [edit mode or in read mode][1]. When you open the document in edit mode, only you can edit the document. Other users can open the document in read mode.

If your organization uses a document library like SharePoint, multiple people can edit a document simultaneously.

> [!NOTE]
> This feature requires a license.

Follow the instructions below, depending on how documents are managed in your SuperOffice installation:

## How do I know if I am using SharePoint, SuperOffice WebTools or not?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Edit document properties in the Document screen

To change document properties, such the project the document is linked to, use the Document screen:

1. [Select the required document][2].
2. Right-click and select **Document**. If you double-click on the document, it opens directly in the application it was created in.
3. [Make the required changes][3].
4. Click the **Save** button.

## Edit document content using SharePoint Documents

1. [Double-click the required document][2]. The document opens in a new tab with the online text-editing program (Office Online).

    > [!NOTE]
    > To use your desktop editing program, you can choose **Open in Desktop App** from Office Online.

2. Edit the document.

3. Close the tab or your desktop app. The document is automatically saved to SharePoint

## Edit document content - without SuperOffice WebTools

> [!NOTE]
> This procedure describes how to create new documents if you are using a desktop text-editing application. The actual process may be slightly different if you use an online text-editing tool (like Microsoft Office Online) and a document library (like SharePoint).

1. [Double-click the required document][2].
2. In the **Document** dialog, click **Open**.
3. If a dialog opens, click **Edit**.
4. In the file download dialog, select one of following options:
    * **Open**: When you click the option for opening, the document is opened in the text-editing application. Type in the contents of the document and select **File** > **Save As** to save it in the desired location on your PC.
    * **Save**: When you click the option for saving, the **Save As** dialog appears. Specify where on your PC you want to save the file, and save it. Then open the document, enter the required text and save the document.
5. Close the text-editing program.
6. Go to the **Document** dialog.

    > [!NOTE]
    > If **Completed** is checked in the **Document** dialog, the upload options are disabled. In that case, remove the **Completed** check mark.

7. Click the link to upload the document or drag and drop the document from Windows Explorer to the **Document** dialog.

    ![Create a new document -screenshot][img1]

8. Close the **Document** dialog by clicking **Save**. The document is checked in and the status is set to **Completed**.

## Edit document content - using SuperOffice WebTools

1. [Double-click the required document][2].
2. If a dialog opens, click **Edit**.
3. Save it and close the text-editing application.
4. (if applicable) In the dialog that appears, click **Yes** if you are done editing the document. Click **No** to keep the document checked out.

    This dialog appears only if this option was activated in SuperOffice WebTools.

5. The document is checked in and the status is set to **Completed**.

### <a id="allow" />Browser security question for opening files

When you access and edit a document, file, or email in SuperOffice, your browser prompts you with a *security question* regarding the file download.

* To open the file, you must select the **Open**/**Allow** button.
* Select **Always allow** to skip the question next time.

The dialog is slightly different in Chrome, Edge, Firefox, and Safari.

**Chrome:** Select **Open URL:SuperOffice-Extensions**.

![Chrome: Open URL:SuperOffice-Extensions button -screenshot][img5]

**Edge:** Select **Open**.

![Edge: Open button -screenshot][img2]

**Firefox:** Select **Open Link**.

![Firefox: Open Link button -screenshot][img3]

**Safari:** Select **Always Allow** or **Allow**.

![Safari: Always Allow or Allow button -screenshot][img4]

## Troubleshooting

If you double-click a document and nothing happens, try to right-click it and select **Document**. This opens the **Document** dialog. Click **Open** and see if the document opens now.

<!-- Referenced links -->
[1]: lock.md
[2]: open.md
[3]: screen/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/document/upload.png
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
