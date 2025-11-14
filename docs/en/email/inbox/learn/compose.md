---
uid: help-en-email-inbox-compose
title: Compose email
description: Learn how to write and send email using SuperOffice Inbox
keywords: compose email, new email
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/email/learn/compose
---

# Compose email

Use SuperOffice Inbox to write new messages and reply to incoming email. You can include attachments, insert reusable content, and archive your messages to SuperOffice CRM.

## Create a new email message

1. Click **New e-mail** in the upper-left corner of the inbox.

    * Alternatively, click **New** in the top bar and select **Email**.

1. In the **New e-mail** dialog:

    * Start typing a name or email address in the **To** field and select a result from the search list. Alternatively, click <i class="ph ph-clock" aria-label="History list icon"></i> to pick a contact from the history list.
    * Click **Cc/Bcc** to add more recipients.
    * Enter a subject.

    ![New email dialog -screenshot][img1]

1. Type your message in the main body field.

    * Your [personal signature][3] is added automatically.
    * Use the formatting toolbar to apply styles, add links, tables, and images.
    * Click the **Sparkle** button (<i class="ph ph-sparkle" aria-hidden="true"></i>) to check spelling, translate, or rewrite your message using AI assistance.

1. To insert predefined content, place the cursor where you want the text to appear. Then click <i class="ph ph-article" aria-label="Insert"></i> and choose from the following options:

    * **FAQ:** Inserts a link to a published [FAQ][4].
    * **Reply templates:** Inserts a shared [reply template][5].
    * **Quick replies:** Inserts your personal [reusable text](#quick-reply).

    ![Insert content into email message -screenshot][img2]

1. Add attachments (optional):

    * Click **Upload file** or drag and drop files.
    * Or, click **Select a CRM document** to attach existing documents.

1. Click **Send** or **Send and archive**.

    * If you archive the message, the [Document dialog][1] opens with the message details prefilled.

## Start from a template

1. Click the dropdown arrow on the **New email** button in the upper-left of the inbox, and select a template.

    ![Dropdown menu with email templates -screenshot][img4]

    The available [email templates][6] are defined in Settings and maintenance.

1. If the selected template includes variables such as **Sale**, **Project**, or **Language**, a prompt dialog appears to capture the necessary details.

    ![Template prompt dialog with fields for sale, project, and language -screenshot][img5]

    Fill in the fields and click **Create**.

1. The email editor opens with the subject and message body prefilled from the template. Add recipients and update any additional details.

    ![Email editor with prefilled subject and body from template -screenshot][img6]

1. Click **Send** or **Send and archive** to finish.

## Reply to an email

1. Select a message in the inbox.

1. Click <i class="ph ph-arrow-bend-up-left" aria-label="Reply"></i> or <i class="ph ph-arrow-bend-double-up-left" aria-label="Reply all"></i> in the message header.

1. A reply draft opens in the right pane with:
    * **To** field prefilled with the sender.
    * Original message quoted below your cursor.
    * Your [personal signature][3] inserted automatically.

1. Edit the subject or message as needed.

1. Click **Send** or **Send and archive**.

> [!TIP]
> If the message is a customer inquiry, you may want to [archive the email as a request][2] instead of replying directly from the inbox. This lets you handle the case in SuperOffice Service and ensures it is tracked properly.

## <a id="quick-reply"></a>Quick replies (snippets)

A quick reply is a personal, reusable text snippet you can insert into email messages. Unlike reply templates, quick replies are created and managed by you, and are only visible to you.

### Insert a quick reply

1. Click <i class="ph ph-article" aria-label="Insert"></i> in the message toolbar.
1. Select **Quick replies**.
1. Choose the snippet you want to insert. The text is added at the cursor position.

### Create new quick reply

1. Click the **Edit** button in the **Insert** dialog.
1. Click **Add**.
1. Enter a name in the **New name** field (not visible to recipients).
1. Enter the text in the **New content** field.
1. Click **Save**.

![Edit new quick reply -screenshot][img3]

## Drafts

Click <i class="ph ph-x" aria-label="Close icon"></i> in the corner to close the message window. The draft is saved automatically to the **Drafts** folder.

## Sent messages

By default, sent messages are saved in the **Sent items** folder. You can change this setting in **E-mail options**.

If you forget to archive the email before sending it, you can still [archive it manually][1] from the **Sent items** folder.

## Email options

Use **Email options** to customize how SuperOffice Inbox handles message composition, formatting, and storage.

To access these settings:

1. Go to **Personal settings** (<i class="ph ph-user-circle" aria-hidden="true"></i>) and select **Email options**.
1. Adjust your preferences on the **General** tab.

| Option | Description |
|---|---|
| **Use signature in new email** | Automatically inserts your [personal signature][3] when creating a new message. |
| **Use signature for Reply/Forward** | Includes your signature when replying to or forwarding messages. |
| **Message font type/size/colour** | Sets the default font style for all new emails. |
| **Outgoing email template** | Selects the default template when starting a new message. |
| **Save a copy of sent email** | Stores sent emails in the **Sent items** folder. Enabled by default. |

## Related content

* [Archive email messages][1]
* [Edit email signature][3]

<!-- Referenced links -->
[1]: archive.md
[2]: create-request.md
[3]: ../../../learn/getting-started/edit-email-signature.md
[4]: ../../../knowledge-base/learn/faq/index.md
[5]: ../../../knowledge-base/learn/reply-templates/index.md
[6]: ../../admin/add-email-template.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-new-email.png
[img2]: ../../../../media/loc/en/email/inbox-insert-options.png
[img3]: ../../../../media/loc/en/email/add-quick-reply.png
[img4]: ../../../../media/loc/en/email/inbox-choose-template.png
[img5]: ../../../../media/loc/en/email/inbox-template-prompt-dialog.png
[img6]: ../../../../media/loc/en/email/new-email-from-template.png
