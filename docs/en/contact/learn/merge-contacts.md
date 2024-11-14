---
uid: help-en-contact-merge
title: Merge contacts
description: Merge contacts
author: SuperOffice RnD
date: 06.29.2022
keywords: company
topic: howto
language: en
---

# Merge contacts

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

If a physical person is registered as two different contacts in SuperOffice CRM, you can merge these contacts together. For example, if the person was registered under two different names at the same company ("Jonathan Clark" and "Jonathon Clarke"), or if the person was registered at both their old and new employer.

Project membership and activities will be moved to the target contact, and the source contact can be deleted or marked as a former employee.

1. Open the **Merge contacts** dialog bu doing one of the following:
    * In the Company screen: Go to the **Contacts** section tab, select and right-click one or two contacts you want to merge, select **Manage contacts** and **Merge contacts**.
    * In the Contact screen: Go to the required contact, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> in the contact card, and select **Manage contacts** and **Merge contacts**.

2. If you selected only one contact, select another contact under **To** (to search for a contact, start typing). The two contacts you want to merge are now displayed under **From** and **To**.

    > [!TIP]
    > To switch the **From** and **To** contacts, click <i class="ph ph-info" aria-label="Info"></i>.

3. Select one of the following under **Action on \[contact/company\] after merge**:
    * **Delete...**: If you select this option, the source contact is deleted after the merge.
        For example, if you registered the same contact twice under the same company.
    * **Mark as former employee**: If you select this option, the source contact is marked as a former employee after the merge.
        For example, if a person has changed jobs, but you still want them registered under the old company.

4. Select one of the following under **Action on all existing activities and sales**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Click **Merge**. The contacts are merged, and project memberships and memberships of static selections are moved.

> [!NOTE]
> You cannot merge contacts (SuperOffice users) in your own company, but you can merge a contact from another company with one in your own company.

## Related topics

* [Merge companies][1]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
