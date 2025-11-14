---
uid: help-en-tutorial-email-mailing
title: Tutorial - email mailing
description: When you have completed the necessary preparations, which includes creating your target list and preparing your mailing template, then you are ready to create a new mailing in SuperOffice CRM. In this tutorial, you will learn to create an email mailing.
keywords: email mailing
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

# Tutorial - email mailing

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Step 1: Setup

You can create your new mailing in the Marketing screen in the Mailings tab. Click on the Create mailing button and you will get to the first step where you can set up your mailing.

The first step in creating an email mailing, is called **Setup**. Here you can set the email header information such as sender, reply-to address and subject. You can also add attachments, set archive options for the mailing and select tracking options.

1. Enter a name in the **Name of mailing** field.

1. Enter the subject of the email in the **E-mail subject** field.

1. In the **From** list, select **Always use** and enter the sender's email address in the field below to use the same sender for all mailings. You can also choose a sales contact or support contact as the sender, if one is defined for this recipient. Enter an email address to be used if no sales contact or support contact is available. If your admin has activated the [global email validation preference][2], select the domain you want to send from in the drop-down list.

    [!include[Note](includes/spf-look-up.md)]

1. In the **Reply to** list, you have the same options as above. In addition, you can select **Use "From" as reply address**. Any replies will then be sent to the sender.

1. Select a folder to place the mailing in from the **Folder** list.

    [How do I create a mailing folder?][4]

1. In the **Selection** and **Project** fields, you can associate the mailing with a selection and/or a project. Start typing to search.

    If you add a selection, any contacts in the selection are added as recipients in the mailing.

1. In the **Type** list, select the type of mailing you are creating. Select **(Any)** if the mailing matches two or more of the available types. Use **(Any)** after adding multiple recipients with multiple subscriptions and you want to send the mailing to all.

1. **Attachments**: To add one or more attachments to the mailing, use one of the following methods:

    * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
    * Drag and drop a file from Windows Explorer to the attachments field.
    * Click **Choose a CRM document** to select a document in SuperOffice CRM.

1. Under **Tracking** are the following options:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Click **Next** to go to the next step.

### E-mail Domain Validation (ONLINE ONLY)

If your admin has activated the [global preference][2] **Only use approved e-mail domains**, the **From address** field will be split, and you need to select the domain you want to send from in the drop-down list of approved domains.
Attempting to send from a domain that does not have a valid SPF record will prompt a warning, and you will not be able to send from that domain. This applies to all email domains even if the validation preference is not activated.

> [!NOTE]
> If the **Our contact address** has an email domain that has not been validated, the mailing will automatically be sent from the address specified in the **Otherwise use** drop-down list options.

## Step 2: Template

[!include[How to choose a template](includes/mailing-choose-template.md)]

## Step 3: Content

[!include[Step 3 email](includes/step-3-content-email.md)]

## Step 4: Recipients

[!include[Step 4 recipients](includes/step-4-recipients.md)]

## Step 5: Confirm

[!include[How to confirm and send a mailing](includes/step-5-confirm-and-send-mailing.md)]

<!-- Referenced links -->
[2]: ../../admin/add-domain.md
[4]: ../../../learn/create-folder.md
