---
uid: help-en-document-external
title: Work with external documents
description: Work with external documents and files
keywords: request, document, external, file, knowledge base
author: Kirsti Aakerholt, Bergfrid Dias
date: 10.29.2023
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Work with external documents (knowledge base)

You can add files to make them available to anyone using SuperOffice CRM, including unregistered customers. Files you upload to the knowledge base are available when you answer customer requests and create mailings.

For example, when [answering requests][1], you can enter text in the **Message** tab the same way as in a word processor. You can also insert images by clicking the **Image** button on the toolbar, but in that case the image must have already been uploaded to **External documents**. When the message is sent, links will be generated to files under **External documents**. The same applies when, for example, you create reply templates and SuperOffice Marketing messages.

## View file

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.

1. Go to the required folder.

1. Do one of the following:
    * Click the file name to go to the **Document properties** screen (view and edit contents).
    * Click <i class="ph ph-download-simple" aria-label="Download"></i> to download files that cannot be viewed in the browser, such as images, PDFs, and Microsoft Office files. An icon in the file list indicates the file type.

## Add file

> [!NOTE]
> You must create the physical file before you can add it to SuperOffice. For example, to create a price list, you could use Microsoft Word or Excel to write the contents.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.

1. Go to the folder you want to put the file in. If it does not yet exist, you can create a new folder as described below.

1. Click **New document**.

1. In the **Document properties** screen, enter a descriptive **Name** for the file.

1. The **In folder** field automatically shows the name of the folder you chose. If you change your mind, you can click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select a different folder in the list that appears.

1. In the **Access** field, select who is to have access to read and edit the file.

1. Optionally, add a unique **ID string** to use the file in a web-based customer centre.

1. In the **Description** field, enter a brief description of what the file contains.

1. Click the **Choose file** button next to **File**, and select the new file in the dialog that appears.

1. Click **Save**. If the file type can be edited in the browser, the **Contents** field is populated.

1. Click **OK**. The file is added to the specified folder.

> [!NOTE]
> Certain file types are blocked by default from being uploaded as external documents in Service. If you need to allow uploads of any of these types, such as **js**, an administrator can update the [**unsafe file types** system preference][9] in Settings and maintenance.

## Edit file content

Certain file types, such as html, txt and the native ejr format, can be edited directly in the **Document properties** screen. For other types, such as PDF, you need the application the file was originally created in.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.
1. Go to the folder where the file is located.
1. Click <i class="ph ph-download-simple" aria-hidden="true"></i> **Download**.
1. Edit and save the file using the application the file was originally created in.
1. Click the file name to go to the **Document properties** screen.
1. Click the **Choose file** button next to **File**, and in the dialog that appears select the file you edited.
1. Click **OK** to upload the file.

## Edit file properties

By editing the file's properties, you can, for example, change who is to have access to it.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.
1. Go to the folder where the file is located.
1. Click the file name to go to the **Document properties** screen.
1. Make the required changes (see above).
1. Click **OK**. The changes are saved.

> [!TIP]
> To move the file to a different folder, select the new folder in the **In folder** field.

## Delete file

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.
1. Go to the folder where the file is located.
1. Click the file name to go to the **Document properties** screen.
1. Click the **Delete** button at the bottom of the screen.
1. Click **OK** to confirm. The file is removed from SuperOffice.

## Create folders

You can create a folder structure for files, to give them a logical structure and make it easy for others to find information. You can create sub-folders in all folders, and you can place the files in any of these folders.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.

1. Go to the folder you want to create a sub-folder under. You can create it directly under the **Files** folder or under any of its sub-folders.

1. Click the **New folder** button at the top of the screen. This takes you to the **Document folder properties** screen.

1. Enter a descriptive name for the folder in the **Name** field.

1. The **In folder** field automatically shows the name of the parent folder you chose. If you change your mind, you can click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select a different folder in the list that appears.

1. In the **Access** list box, you select who is to have access to read and edit the folder.

1. Click **OK**. The new folder is created. You are now ready to add files to the new folder.

### Delete folders

When you delete a folder, all the files in it are also deleted from SuperOffice.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **External documents**.
1. Go to the required folder.
1. Click **Edit folder**. This takes you to the **Document folder properties** screen.
1. Click **Delete**.
1. Click **OK** to confirm. The folder and its contents are removed from SuperOffice.

<!-- Referenced links -->
[1]: reply.md
[9]: ../../../../release-notes/10.3/service/10.3.11-update.md
