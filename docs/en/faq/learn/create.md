---
uid: help-en-faq-create
title: Create FAQ entries
description: Create FAQ entries
author: SuperOffice RnD
so.date: 06.29.2022
keywords: FAQ
so.topic: howto
language: en
---

# Create FAQ entries

By creating FAQ entries, your organization can build up a comprehensive collection of questions and answers that both customers and staff can use to find useful information. There are two ways to create FAQ entries:

* A user can create an FAQ entry, based on communication with a customer in **Requests**.
* An administrator can create an FAQ entry directly in **Knowledge Base > FAQ**.

## Create FAQ entries from a request

If you reply to an enquiry and think the same question may arise again, it is a good idea to create a reply that can be reused and made available to all customers.

1. [Open a request][1].

2. Click the ![icon][img1] **Actions** button and select **Publish to FAQ**. This takes you to the **FAQ entry properties** screen.

3. Edit the request name in the **Name** field if necessary.

4. In the **Position** field, select a number for the entry's position in the sort order of the folder it belongs in. 1 means the top of the list.

5. In the **Folder** field, select which folder you want to place the entry in (if you have a [folder structure for FAQ entries][2]).

6. In the **Access** field, select who is to have access to the FAQ entry in question:

    * **Private**: Only you. This can be relevant if you are creating new FAQ entries or updating outdated FAQ entries.
    * **Accessible to internal users**: Only internal users (and not customers using SuperOffice Customer Centre).
    * **Accessible to registered customers**: Registered customers who have login access to SuperOffice Customer Centre.
    * **Accessible to everyone**: Everyone (no login required to read the FAQ).

7. In the **Keywords** field, you can enter keywords (use a space or comma as a separator) for the entry. Make sure you only enter keywords that are relevant to the entry. Keywords make the entry easier to find when searching. In addition, keywords are used to automatically suggest FAQ entries that match a request from a customer.

8. As an FAQ administrator, you can choose from the following options in the **Workflow** field:

    * **Unpublished**: Choose this option if you do not want to publish the FAQ entry at the moment.
    * **Published**: Choose this option to [publish the FAQ entry immediately][3].
    * **Expired**: Select this option if the FAQ entry is no longer current. Relevant when editing existing FAQ entries.

    > [!NOTE]
    > The list also contains any custom workflow stages created in the system.

9. If you select a date in the **Valid to** field, the entry's status is changed to **Expired** on this date. After that it will not be available to anyone except the FAQ administrators. They will be warned that the entry is expired. This may be relevant in connection with marketing campaigns. If you enter no date here, the FAQ entry will remain available permanently.

10. In the **Attachment** field, you can add one or more documents as attachments to the request.

    <details><summary>How?</summary>
    To add an attachment to the FAQ entry:

    1. Click **Choose file** next to **Attachment**.
    2. Browse to the document you require in the dialog box that appears.
    3. Click ![icon][img1] to add the attachment.
    4. Repeat this procedure to add more attachments.
    </details>

11. In the **Link** field, you can add one or more addresses of relevant websites.

    <details><summary>How?</summary>
    To add links to an FAQ entry:

    1. In the field to the left, enter the name to be displayed for the link.
    2. In the field on the right, enter the actual web address after `http://`
    3. Click ![icon][img1] **Add** to add the link.
    4. Repeat this procedure to add more links.
    </details>

12. Go to the **Question** tab.

13. Enter the question that you want the FAQ entry to contain. By default, the first message in the request is pasted into the **Question** tab.

    > [!TIP]
    > Click ![icon][img2] and select a language to spell check the message in that language.

14. Go to the **Answer** tab and enter the answer. By default, the next messages in the request are pasted into the **Answer** tab.

15. Click **OK**. The **FAQ Entry** screen is displayed, and your proposed FAQ entry is sent to the administrator, who can publish it.

## Create new FAQ

1. Select **Knowledge Base** > **FAQ**.
2. Go to the folder you want to put the FAQ entry in. If it does not yet exist, you can [create a new folder][2].
3. Click the **New entry** button. This takes you to the **FAQ entry properties** screen.
4. Follow the procedure above starting at step 3.

Since the option to create FAQ entries this way is only available to administrators, there is no need for a separate publishing step in this process. The administrator can create and publish simultaneously.

## What would you like to do now?

* [Edit FAQ entries][4]
* [Publish FAQ entries][3]

<!-- Referenced links -->
[1]: ../../request/learn/index.md#open
[2]: manage-folders.md
[3]: publish.md
[4]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
[img2]: ../../../media/icons/service/spell-check.png
