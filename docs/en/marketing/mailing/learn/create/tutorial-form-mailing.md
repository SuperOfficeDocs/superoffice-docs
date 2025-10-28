---
uid: help-en-tutorial-form-mailing
title: Tutorial - form response mailing
description: In this tutorial, you will learn to create a form response mailing.
keywords: form mailing, response mailing
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

# Tutorial - form response mailing

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Step 1: Setup

The first step in creating a form response, is called **Setup**. Here you can set the email header information such as sender, reply-to address and subject. You can also add attachments, set archive options for the mailing and select tracking options.

1. Enter a name in the **Name of mailing** field.

1. Enter the subject of the email in the **E-mail subject** field.

1. In the **From** list, select **Always use** and enter the sender's email address in the field below to use the same sender for all mailings. You can also choose a sales contact or support contact as the sender, if one is defined for this recipient. Enter an email address to be used if no sales contact or support contact is available. If your admin has activated the [global email validation preference][1], select the domain you want to send from in the drop-down list. If not, enter the address and domain you want to send from.

    [!include[Note](includes/spf-look-up.md)]

1. In the **Reply to** list, you have the same options as above. In addition, you can select **Use "From" as reply address**. Any replies will then be sent to the sender.

1. Select a folder to place the mailing in from the **Folder** list.

    [How do I create a mailing folder?][2]

1. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project. Start typing to search.

    If you add a selection, any contacts in the selection are added as recipients in the mailing.

1. **Attachments**: To add one or more attachments to the mailing, use one of the following methods:

    * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
    * Drag and drop a file from Windows Explorer to the attachments field.
    * Click **Choose a CRM document** to select a document in SuperOffice CRM.

1. Under **Tracking** are the following options:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Click **Next** to go to the next step.

## Step 2: Template

[!include[How to choose a template](includes/mailing-choose-template.md)]

## Step 3: Content

[!include[Step 3 email](includes/step-3-content-email.md)]

<!-- Referenced links -->
[1]: ../../admin/add-domain.md
[2]: ../../../learn/create-folder.md
