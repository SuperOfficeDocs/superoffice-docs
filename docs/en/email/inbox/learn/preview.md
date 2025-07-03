---
uid: help-en-email-inbox-preview
title: View email messages
description: How to preview, move, mark, and print email messages in SuperOffice Inbox
keywords: open email, view email, preview, move email, mark as read, print, email, e-mail, SuperOffice Inbox
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/inbox/learn/mark-as-read
  - /en/email/inbox/learn/move-email-to-folder
  - /en/email/inbox/learn/print
---

# View email messages

When you select an email in the inbox, a preview of the message appears on the right side of the screen. Double-clicking a message opens it in a separate window.

![Email preview with message selected and actions available -screenshot][img1]

## Preview pane

The preview shows the contents of the selected message, including recipients, attachments, and other details.

If the sender exists in SuperOffice CRM, you can hover over their name to view the [contact card][9].

### Show inline images

To display inline images in the preview pane:

1. Click <i class="ph ph-user-circle" aria-label="Personal settings"></i> in the top bar and select **Email options**.
1. Go to the **General** tab.
1. Check the box **Show inline images**.
1. Click **OK** to apply the setting.

![Email options: General tab -screenshot][img2]

### Open an attachment

Attachments are listed below the email header when a message is selected.

1. Click the <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the attachment name.
1. Select **Preview** to open the file directly in your browser.

    Browser behavior may vary depending on file type and settings. For example, PDFs might open in a new tab.

> [!TIP]
> You can also choose **Download** to save the file, or **Archive** to [store it as a document in SuperOffice CRM][2].

## <a id="mark-as-read"></a>Mark emails as read or unread

Emails are **not marked as read automatically** unless you enable this setting.

### Enable automatic marking

1. Go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Email options** > **General**.
1. Select **Mark as read in preview**.
1. Click **OK**.

### Mark messages manually

* To mark a single message:
    1. Select the message.
    1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Mark as read/unread**.

    ![Task menu showing mark and move options - screenshot][img3]

* To mark multiple messages:
    1. **Ctrl+click** (Windows) or **Cmd+click** (Mac) to select the messages you want to update.
    1. Use the **Mark as read** or **Mark as unread** buttons in the message pane.

    ![Move, mark, and delete options for multiple selected emails - screenshot][img4]

## <a id="move"></a>Move email to folder

You can move messages to other folders in your email account.

The list of folders comes from your email provider (for example, Outlook or Gmail). You cannot create, rename, or delete folders from inside SuperOffice CRM. To manage folders, open your email account directly.

### Move a single email

1. Select a message in the inbox.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Move to folder**.
1. Choose the destination folder.

    > [!CAUTION]
    > If a folder name is grayed out, it is not currently synchronized with your email account.
    >
    > To activate it, select the folder above the list of emails and click the **Subscribe** icon (<i class="ph ph-cloud-slash" aria-label="Cloud"></i>) in the lower-right corner. This ensures the email is moved correctly.

### Move multiple emails

1. Select the messages you want to move: **Ctrl+click** (Windows) or **Cmd+click** (Mac) to select multiple messages.
2. Use the **Move to folder** button in the message pane.

## <a id="print"></a>Print an email

1. Select a message in the inbox.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Print selected email**.
1. The message opens in a browser preview window.
1. Use your browser's **Print** option to print the message.

## Related content

* [Manage senders][1]
* [Receive invitations][3]
* [Create task][4]
* [Create request][5]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive.md#attachment
[3]: invitations.md
[4]: create-task.md
[5]: create-request.md
[9]: ../../../contact/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-preview-message.png
[img2]: ../../../../media/loc/en/email/email-options-general.png
[img3]: ../../../../media/loc/en/email/inbox-message-task-menu.png
[img4]: ../../../../media/loc/en/email/inbox-multiselect-actions.png
