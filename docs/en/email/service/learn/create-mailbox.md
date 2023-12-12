---
uid: help-en-service-mailbox-create
title: Create mailboxes
description: Create mailboxes
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: email
so.topic: howto
language: en
---

# Create mailboxes

You can create a mailbox to use for importing email into SuperOffice Service. Before you do that, you must create a mailbox on the mail server that the email is delivered to.

> [!NOTE]
> Before you set up a mailbox, make sure that there are no old messages in this mailbox on the mail server. SuperOffice Service will import all mail in the mailbox and you risk sending auto-replies to all contacts who have sent email to this address. To import these old emails, you should disable the auto-reply function. Above all, this concerns the **Do not auto-reply** option in the **Mailbox properties** screen and the **Do not send email to new contacts** option in the **Settings** tab in the **System** screen in SuperOffice Service.

## To create a new mailbox - online

1. [!include[Go to email](includes/goto-email.md)]

1. Click **New mailbox**. The **Mailbox properties** screen appears, with the **Properties** tab open.

1. In the **Address** field, enter the name without @domain.xx, and press **TAB** to add the CRM Online settings to the email address.

    > [!NOTE]
    > Friendly email address can be added to the address by adding ("friendly name") at the end of the email address.Example: <info@company.com> (Customer Ltd.).

1. Select category, priority, and request type:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Set reply:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **AI services**: Here you can select the following options for categorization and text analysis using [AI][4]:

    * **Use AI to suggest categories**: Select this option to [let the AI suggest a category][3] for requests based on the content of email messages.
    * **Use text analysis**: Select this option to [let the AI analyze the text][2] in email messages to detect language (for translation) and perform sentiment analysis.

1. Click **OK**. The mailbox is created.

## To create a new mailbox - onsite

1. [!include[Go to email](includes/goto-email.md)]

1. Click **New mailbox**. The **Mailbox properties** screen appears, with the **Properties** tab open.

1. In the **Address** field, enter the email address you want to use for the mailbox.

    > [!NOTE]
    > Set up forwarding to this mailbox address if you are going to use your company's email address (for example <info@company.com>). Use **Forwarding address** in the **Mailboxes** screen.

1. In the **Protocol** list box, select which protocol to use to communicate with the mail server. Some of the protocols may require further configuration.

1. In the **Email server** field, enter the server's host name.

1. In the **User name** and **Password** fields, enter the user name and password for the mailbox.

1. In the **Folder** field, enter the folder name for the mailbox on the server.

1. In the **Port** field, you can change the proposed default port for the selected protocol.

1. Select category, priority, and request type:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. In the **Interval** list box, select how often SuperOffice Service check for messages in this mailbox.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Set reply:

    [!include[Common steps](includes/step-set-reply.md)]

1. Go to the **Alias** tab. Here you can enter any email alias for a mailbox (for example, if <sales@company.com> and <sale@company.com> go to the same mailbox). You add an alias by entering an email address and then clicking ![icon][img1].

1. [!include[Import stuff](includes/step-import.md)]

1. Click **OK**. The mailbox is created.

## What would you like to do now?

* [Delete mailboxes][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
