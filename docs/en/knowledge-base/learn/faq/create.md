---
uid: help-en-faq-create
title: Create FAQ entries
description: Create FAQ entries
keywords: create FAQ
author: Bergfrid Dias
date: 03.14.2023
version: 10.5
content_type: howto
category: service
topic: faq
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: en
redirect_from: /en/faq/learn/create
---

# Create FAQ entries

By creating FAQ entries, your organization can build up a comprehensive collection of questions and answers that both customers and staff can use to find useful information. There are two ways to create FAQ entries:

* A user can create an FAQ entry, based on communication with a customer in the Requests screen.
* An administrator can create an FAQ entry directly in **Knowledge base** > **FAQ**.

## Requirements

* You need a license for Service premium or the Customer Engagement platform to use the knowledge base.
* If you do not see this feature, you need to add *Knowledge base* as functional right to create FAQ.

## Create FAQ entries from a request

If you reply to an enquiry and think the same question may arise again, it is a good idea to create a reply that can be reused and made available to all customers.

1. [Open a request][1].

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Publish to FAQ**. This takes you to the **FAQ entry properties** screen.

   ![The FAQ entry properties screen -screenshot][img5]

1. Edit the request name in the **Name** field if necessary.

1. In the **Position** field, select a number for the entry's position in the sort order of the folder it belongs in. 1 means the top of the list.

1. In the **Folder** field, select which folder you want to place the entry in (if you have a [folder structure for FAQ entries][2]).

1. In the **Access** field, select who is to have access to the FAQ entry in question:

    * **Private**: Only you. This can be relevant if you are creating new FAQ entries or updating outdated FAQ entries.
    * **Accessible to internal users**: Only internal users (and not customers using SuperOffice Customer Centre).
    * **Accessible to registered customers**: Registered customers who have login access to SuperOffice Customer Centre.
    * **Accessible to everyone**: Everyone (no login required to read the FAQ).

1. In the **Keywords** field, you can enter keywords (use a space or comma as a separator) for the entry. Make sure you only enter keywords that are relevant to the entry. Keywords make the entry easier to find when searching. In addition, keywords are used to automatically suggest FAQ entries that match a request from a customer.

1. As an FAQ administrator, you can choose from the following options in the **Workflow** field:

    * **Unpublished**: Choose this option if you do not want to publish the FAQ entry at the moment.
    * **Published**: Choose this option to [publish the FAQ entry immediately][3].
    * **Expired**: Select this option if the FAQ entry is no longer current. Relevant when editing existing FAQ entries.

    > [!NOTE]
    > The list also contains any custom workflow stages created in the system.

1. If you select a date in the **Valid to** field, the entry's status is changed to **Expired** on this date. After that it will not be available to anyone except the FAQ administrators. They will be warned that the entry is expired. This may be relevant in connection with marketing campaigns. If you enter no date here, the FAQ entry will remain available permanently.

1. In the **Attachment** field, you can add one or more documents as attachments to the request:

    1. Click **Choose file** next to **Attachment**.
    2. In the dialog, browse to the document you require.
    3. Click **+** to add the attachment.
    4. Repeat this procedure to add more attachments.

1. In the **Link** field, you can add one or more addresses of relevant websites:

    1. In the field to the left, enter the name to be displayed for the link.
    2. In the field on the right, enter the actual web address after `http://`
    3. Click **+** to add the link.
    4. Repeat this procedure to add more links.

1. Go to the **Question** tab.

1. Enter the question that you want the FAQ entry to contain. By default, the first message in the request is pasted into the **Question** tab.

    > [!TIP]
    > Click the **Format font** button (<i class="ph ph-text-a-underline" aria-hidden="true"></i>) to change the layout of the text.

1. Go to the **Answer** tab and enter the answer. By default, the next messages in the request are pasted into the **Answer** tab.

1. If you have more than one [language][6], you need to select the different **languages** in the footer and repeat the steps for **Question** and **Answer**.

1. Click **OK** when you are done. The **FAQ Entry** screen is displayed, and your proposed FAQ entry is sent to the administrator, who can publish it.

## Create new FAQ

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **FAQ**.

1. Go to the folder you want to put the FAQ entry in. If it does not yet exist, you can [create a new folder][2].

1. Click the **New entry** button. This takes you to the **FAQ entry properties** screen.

    ![The FAQ screen -screenshot][img3]

1. Follow the procedure above starting at **step 3**.

Because the option to create FAQ entries this way is only available to **administrators**, there is no need for a separate publishing step in this process. The administrator can create and publish simultaneously.

## Related content

* [Edit FAQ entries][4]
* [Add FAQ in a message][5]
* [Set up multiple languages][6]

<!-- Referenced links -->
[1]: ../../../request/learn/index.md#open
[2]: ../manage-folders.md
[3]: publish.md
[4]: edit.md
[5]: ../../../request/learn/reply.md#faq
[6]: ../../../localization/learn/customer-languages.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/faq/create-publish-faq.png
[img5]: ../../../../media/loc/en/faq/faq-create.png
