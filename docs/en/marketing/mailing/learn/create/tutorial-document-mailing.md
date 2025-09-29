---
uid: help-en-tutorial-document-mailing
title: Tutorial - document mailing
description: In this tutorial, you will learn to create a document mailing.
keywords: document mailing
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Tutorial - document mailing

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Step 1: Setup

> [!TIP]
> To view and print an existing document mailing, close the **Setup** step (click **Cancel** or **Save + Close**). Select the **Mailings** tab, locate the document, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **View**. Click the button under **Download generated document**. The document is downloaded to your browser. Open and print the document.

Using the document mailing workflow you can generate a PDF document to print and send to your customers. The first step in creating a document mailing, is called **Setup**. Here you can set the name of the mailing, the heading and attention text in the document, and set archive options for the mailing.

You can connect the document mailing to a specific project. This can be relevant if you are creating mailings where the recipients are project members from a SuperOffice CRM project. By using template variables in the template, you can add project data to your mailing.

You can connect the document mailing to a specific sale. This can be relevant if you are creating mailings where the recipients are sale stakeholders from a SuperOffice CRM sale. By using template variables in the template, you can add sales data to your mailing.

**Steps:**

1. Enter a name in the **Name of mailing** field.

1. In the **Heading** field, enter the document title.

1. In the **Attention** field, you must select to whom the mailing should be directed. Select one of the following options:

    * **If none defined**: Select this option to use the recipients' names by default, or, if no recipient name is found, use the recipient you enter in the text field. If you are creating a mailing directed at IT professionals in a company, you can enter "IT department" or similar.

    * **Use always**: Select this option to override the recipients' names and only use the recipient you enter in the text field.

1. In the **Our ref** field, enter the name that should appear as our reference in the document. You can use SuperOffice CRM [template variables][1] in this field.

    > [!NOTE]
    > For variables such as sale ID or project ID to work, you must link the document mailing to a sale or project.

1. Select a folder to place the mailing in from the **Folder** list.

    [How do I create a mailing folder?][3]

1. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project. Start typing to search.

1. Click **Next** to go to the next step.

## Step 2: Template

[!include[How to choose a template](includes/mailing-choose-template.md)]

## Step 3: Content

In the **Content** step you can edit the appearance and content of the document.

1. Click the **Edit** button.

1. In the dialog, click **Download document**. The file is downloaded to your browser.

1. Open the document for editing. In most browsers you can click the downloaded file to open it in the default application.

1. Edit the contents of the document.

1. Save the document.

1. (if relevant) In SuperOffice Marketing, click **Edit** to reopen the dialog.

1. Click **Select file**, select the saved document, and click **Upload selected file**. The preview on the right is updated with the contents of the uploaded file.

1. Click **Next** to go to the next step.

### Use template variables

You can use SuperOffice CRM [template variables][1] in your document to insert customer-specific information. This will give the message a more personal touch.

## Step 4: Recipients

[!include[Step 4 recipients](includes/step-4-recipients.md)]

## Step 5: Confirm

> [!NOTE]
> Document mailings are not actually sent when you click **Send now**. A PDF document is generated, containing all the pages to all the persons/companies you selected as recipients in the mailing. You can [open and print](#pdf) the PDF from the **View mailing** screen.

In the final step, **Confirm**, you can view a summary of the mailing and verify that these are correct. Any error messages displayed in this screen must be solved before the mailing can be sent.

> [!NOTE]
> The send options are disabled if there are incomplete steps or missing information in your mailing. These are indicated in red.

### Send the mailing now

Click **Send now** to generate a PDF document. A PDF document is generated. The workflow closes and you are returned to the **Mailings** tab.

Click the mailing in the list to [view sending status and statistics][2].

### <a id="pdf"></a>Open and print the document

1. Select the **Mailings** tab.
1. Locate the document, click <i class="ph ph-list" aria-label="Task menu"></i> and select **View**.
1. Click the button under **Download generated document**. The document is downloaded to your browser.
1. Open and print the document.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md
