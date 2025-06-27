---
uid: help-en-email-inbox-archive
title: Archive emails
description: Learn how to archive email messages and attachments from the SuperOffice inbox, including how to store them as documents in CRM.
keywords: Archive button, save email, save attachment, inbox, somail, document dialog, email attachment, incoming email, outgoing email, email, archive
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Archive email messages <i class="ph ph-archive" aria-hidden="true"></i>

You can save an email or a specific attachment to SuperOffice CRM by archiving it. This ensures the content is linked to the correct company, contact, and optionally a project or sale.

## <a id="in"></a>Archive incoming email

To save a received email to SuperOffice:

1. Select a message in the inbox.

1. Click the **Archive** button (<i class="ph ph-archive" aria-hidden="true"></i>) and choose **Archive email**.

   ![SuperOffice Inbox archive menu with Archive email, Create task, and Create request options -screenshot][img1]

1. If the sender is unknown, the **Add contact to SuperOffice** dialog opens.

    * Start typing to search for an existing company or contact.
    * Or, click **Create new company and contact** to register them.
    * To skip adding the sender, click **Do not add**.

1. The [Document dialog][1] opens with the email file (.somail) attached.

    ![Document dialog with .somail file attached -screenshot][img2]

1. Make any changes if needed, such as linking the email to a sale, project, or category.

1. Click **Create** to archive the message.

## <a id="out"></a>Archive outgoing email

To archive an email you are sending from the SuperOffice Inbox:

1. Compose your message as usual.
1. Click **Send and archive** instead of **Send**.
1. The [Document dialog][1] opens so you can review and confirm the archive details.

> [!TIP]
> If you forget to archive a message when sending, you can still archive it later from the **Sent** folder using the steps above.

## <a id="attachment"></a>Archive an attachment

You can also archive individual attachments separately from the email body.

1. Select the message in the inbox.
1. Below the email header, locate the list of attachments.
1. Click the <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the file name.
1. Choose **Archive** from the menu.

    The [Document dialog][1] opens with the file pre-attached.

1. Click **Create** to archive the attachment.

You can also select **Download** to save the file on your device.

## Related content

* [View email messages][3]
* [Create task][4]
* [Create request][5]
* [Manage senders][2]

<!-- Referenced links -->
[1]: ../../../document/learn/create.md#fields
[2]: manage-senders.md
[3]: preview.md
[4]: create-task.md
[5]: create-request.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-archive-button.png
[img2]: ../../../../media/loc/en/email/document-dialog-somail.png
