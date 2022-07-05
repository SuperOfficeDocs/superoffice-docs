---
uid: help-en-document-faq-newkbentry
title: document faq newKbEntry
description: document faq newKbEntry
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create FAQ entries

By creating FAQ entries, your organisation can build up a comprehensive collection of questions and answers which both customers and staff can use to find useful information. There are two ways to create FAQ entries:

* A user can create an FAQ entry, based on communication with a customer in **Requests**. See [Create an FAQ entry from a request](document.faq.newKbEntry.md#CreateFAQEntriesFromTheRequestsModule).
* An administrator can create an FAQ entry directly in **Knowledge Base &gt; FAQ**. See [Create new FAQ entries](document.faq.newKbEntry.md#CreateFAQEntriesFromTheFAQModule).

## Create FAQ entries from a request

If you reply to an enquiry and think the same question may arise again, it is a good idea to create a reply that can be reused and made available to all customers. To do this:

1. Open a request. See [Process requests](ticket.listTicket.md).

2. Click the ![icon](../../../media/icons/btn-menu.png)**Actions** button and select **Publish to FAQ**. This takes you to the **FAQ entry properties** screen.

3. Edit the request name in the **Name** field if necessary.

4. In the **Position** field, select a number for the entry's position in the sort order of the folder it belongs in. 1 means the top of the list.

5. In the **Folder** field, select which folder you want to place the entry in. This is relevant if you have a folder structure for FAQ entries. See [Administrate folders of FAQ entries](document.faq.editKbCategory.md).

6. In the **Access** field, select who is to have access to the FAQ entry in question:
    * **Private**: Only you. This can be relevant if you are creating new FAQ entries or updating outdated FAQ entries.
    * **Accessible to internal users**: Only internal users (and not customers using SuperOffice Customer Centre).
    * **Accessible to registered customers**: Registered customers who have login access to SuperOffice Customer Centre.
    * **Accessible to everyone**: Everyone (no login required to read the FAQ).

7. In the **Keywords** field, you can enter keywords (use a space or comma as a separator) for the entry. Make sure you only enter keywords that are relevant to the entry. Keywords make the entry easier to find when searching. In addition, keywords are used to automatically suggest FAQ entries that match a request from a customer.

8. As an FAQ administrator, you can choose from the following options in the **Workflow** field:

    * **Unpublished**: Choose this option if you do not want to publish the FAQ entry at the moment.
    * **Published**: Choose this option if you want to publish the FAQ entry immediately. See [Publish FAQ entries](document.faq.publishFAQ.md).
    * **Expired**: Select this option if the FAQ entry is no longer current. This will be most relevant when editing existing FAQ entries.

    > [!NOTE]
    > The list also contains any custom workflow stages created in the system.

9. If you select a date in the **Valid to** field, the entry's status is changed to **Expired** on this date. After that it will not be available to anyone except the FAQ administrators. They will be warned that the entry has expired. This may be relevant in connection with marketing campaigns. If you enter no date here, the FAQ entry will remain available permanently.

10. In the **Attachment** field, you can add one or more documents as attachments to the request. <!-- Fix reuse ID=a1 -->
    To add an attachment to the FAQ entry:

    1. Click **Choose file** next to **Attachment**.
    2. Browse to the document you require in the dialog box that appears.
    3. Click ![icon][img1] to add the attachment.
    4. Repeat this procedure to add more attachments.

11. In the **Link** field, you can add one or more addresses of relevant websites. <!-- Fix reuse ID=a2 -->
    To add links to an FAQ entry:

    1. In the field to the left, enter the name to be displayed for the link.
    2. In the field on the right, enter the actual web address after **http://**
    3. Click ![icon][img1] **Add** to add the link.
    4. Repeat this procedure to add more links.

12. Go to the **Question** tab.

13. Enter the question that you want the FAQ entry to contain. By default, the first message in the request is pasted into the **Question** tab.

    > [!TIP]
    > Click ![icon](../media/btn-spellcheck.png) and select a language to spell check the message in that language.

14. Go to the **Answer** tab and enter the answer. By default, the next messages in the request are pasted into the **Answer** tab.

15. Click **OK**. The **FAQ Entry** screen is displayed, and your proposed FAQ entry is sent to the administrator, who can publish it. See [Publish FAQ entries](document.faq.publishFAQ.md).

## Create new FAQ

You can also create an FAQ entry as follows:

1. Select **Knowledge Base** &gt; **FAQ**.
2. Go to the folder you want to put the FAQ entry in. If it does not yet exist, you can create a new folder. See [Administrate folders of FAQ entries](document.faq.editKbCategory.md).
3. Click the **New entry** button. This takes you to the **FAQ entry properties** screen.
4. Follow the procedure [above](document.faq.newKbEntry.md#step3), from step 3 onwards.

Since the option to create FAQ entries this way is only available to administrators, there is no need for a separate publishing step in this process. The administrator can create and publish simultaneously.

## What would you like to do now?

[Edit FAQ entries](document.faq.editKbEntry.md)

[Publish FAQ entries](document.faq.publishFAQ.md)

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
