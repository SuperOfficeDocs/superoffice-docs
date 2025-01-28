---
uid: help-en-contact-merge
title: Merge contacts
description: Learn how to merge duplicate contacts in SuperOffice CRM to consolidate activities, sales, and project memberships. Includes step-by-step instructions for using the Merge contacts dialog.
keywords: Merge contacts, contact, person
author: Bergfrid Dias
date: 12.17.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Merge contacts

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

If the same person is registered under different names or companies in SuperOffice CRM (such as "Jonathan Clark" and "Jonathon Clarke") you can merge their contact records to consolidate activities, sales, and project memberships.

> [!NOTE]
> You cannot merge contacts (SuperOffice users) in your own company. You can merge a contact from another company with one in your own company.

## Steps

1. Open the **Merge contacts** dialog:

    * In the **Contact screen**: Go to the required contact, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i>, and select **Manage contacts** > **Merge contacts** from the menu.

    * In the **Company screen**: Go to the **Contacts** section tab, select one or two contacts, right-click, and choose **Manage contacts** > **Merge contacts**.

1. If you selected only one contact, choose a second contact under **To**. Start typing to search for the contact. To swap the **From** and **To** contacts, click the arrow button <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

1. Under **Action on \[company\] after merge**, choose one of the following:

    * **Delete \[source contact\]:** Deletes the source contact after merging (useful for duplicates).
    * **Mark as former employee:** Marks the source contact as a former employee (useful when the contact changed jobs).

1. Under **Action on all existing activities and sales**, choose one of the following:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

1. Click **Merge**. The following happens:

    * All details are merged.
    * Activities and sales remain linked to the target contact, or they are moved depending on the option you selected.
    * Project and static selection memberships follow the target company.
    * The specified action (delete or mark as former employee) is applied to the source contact.

![Merge contacts dialog showing options to handle duplicate contacts (including their activities)and choosing post-merge actions. -screenshot][img4]

## Related content

* [Merge companies][1]
* [Restore deleted companies and contacts][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img4]: ../../../media/loc/en/contact/merge-contacts.png
