---
uid: sofo-save-to-superoffice
title: Save to SuperOffice
description: Save to SuperOffice
keywords: SuperOffice for Outlook, Outlook, archive email, email, save to SuperOffice, send and archive, save attachment, SOFO
author: Erik Lebiko, Bergfrid Dias, Andrea Schilde
date: 05.05.2026
version_sofo: 6.2.0
content_type: howto
category: integration
topic: SuperOffice for Outlook
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
redirect_from: 
  - /en/email/superoffice-for-outlook/learn/save-to-superoffice
  - /da/email/superoffice-for-outlook/learn/save-to-superoffice
  - /de/email/superoffice-for-outlook/learn/save-to-superoffice
  - /nl/email/superoffice-for-outlook/learn/save-to-superoffice
  - /no/email/superoffice-for-outlook/learn/save-to-superoffice
  - /sv/email/superoffice-for-outlook/learn/save-to-superoffice
---

# Save to SuperOffice

[!include[Visible for drop-down condition](includes/note-visibility.md)]

## Archive email to SuperOffice

To archive information from an email in Outlook and save it to SuperOffice:

1. Open or select the email you want to archive.

1. [Open SuperOffice for Outlook][1] (if not pinned)​.

1. The SuperOffice sidebar will attempt to match the sender to a contact. If the email address is associated with multiple contacts in SuperOffice, you will be prompted to select the correct contact. The Company and Contact fields will then populate when you select your action.

1. Choose the appropriate action in the SuperOffice sidebar.

1. Make any necessary changes to the fields.

1. By default, **Include attachments** is selected. Uncheck it if you want to archive the email without its attachments.

1. Click **Save** to archive the email.

> [!NOTE]
> Attachments are included by default. Uncheck **Include attachments** only if you want to store the email body without the attached files.

![SuperOffice for Outlook, archive email -screenshot][img1]

## Archive email from a shared mailbox

If you have access to a shared mailbox in Outlook, you can archive emails from that mailbox to SuperOffice in the same way as emails from your personal mailbox.

> [!IMPORTANT]
> The first time you use SuperOffice for Outlook with a shared mailbox, you may be asked to approve additional Microsoft permissions. If you do not have sufficient rights to approve these yourself, contact your Microsoft 365 administrator. See [SuperOffice for Outlook: Authorisation guide](https://community.superoffice.com/en/support-faqs/faq/superoffice-for-outlook-authorisation-guide/) for details.

> [!NOTE]
> The shared mailbox must already be available to you in Outlook. Access to shared mailboxes is managed in Microsoft 365.

1. Open the shared mailbox in Outlook.
1. Select the email you want to archive.
1. Open SuperOffice for Outlook.
1. Choose the action you want to perform, such as archiving the email, saving attachments, creating a request, or adding the message to an existing request.
1. Check the company, contact, sale, project, or request details.
1. Choose whether to include attachments.
1. Select whether to remove the email from the inbox after archiving, if this option is available.
1. Select **Save**.

## Save attachments to SuperOffice

You can also save email attachments directly to SuperOffice by following these steps:

1. Open the email that contains the attachments.

1. Choose **Save attachment in SuperOffice** from the SuperOffice sidebar.

1. Select the attachment you want to save from the list shown.

1. Fill in the required fields and click **Save**.

1. To save another attachment, repeat steps 1-4.

> [!NOTE]
> Previously saved attachments will be marked as "Attachment already saved."

## Send and archive

To send an email and automatically archive it to SuperOffice, follow these steps:

1. Select **New mail** in Outlook.

1. [Open SuperOffice for Outlook][1].

1. The **Archive email in SuperOffice** toggle is turned on by default. Turn it 
   off if you do not want this email archived in SuperOffice.

    ![SuperOffice for Outlook, send and archive -screenshot][img2]

    > [!NOTE]
    > Bcc to **SuperOffice Mail Archive** is required to ensure the email is archived in SuperOffice.

1. Add recipients to the **To** field. If their email is known to SuperOffice, the Company and Contact fields will auto-fill. If the email address is associated with multiple contacts in SuperOffice, you will be prompted to select the correct one before the fields populate.

1. Fill in any missing information or make adjustments as needed.

1. Click **Send** to both send the email and archive it to SuperOffice.

## Send and archive from a shared mailbox

You can compose a new email from a shared mailbox and archive it to SuperOffice while sending.

Before sending, make sure the correct sender address is selected in the Outlook **From** field. If the **From** field is not visible, enable it in Outlook first. This is standard Outlook functionality.

> [!TIP]
> You can pin the SuperOffice for Outlook panel while composing to keep it visible as you write. See [Pin or unpin SuperOffice for Outlook](get.md#pin-or-unpin-superoffice-for-outlook).

> [!CAUTION]
> Always check the **From** address before sending from a shared mailbox.

1. Select **New mail** in Outlook.
1. Open and, if needed, pin SuperOffice for Outlook.
1. In Outlook, select the shared mailbox address in the **From** field.
1. Add recipients and write the email.
1. In SuperOffice for Outlook, keep **Archive email in SuperOffice** turned on if the email should be archived.
1. Check or adjust the SuperOffice fields.
1. Select **Send**.

<!-- Referenced links -->
[1]: get.md#open

<!-- Referenced images -->
[img1]: media/outlook-save-to-superoffice.png
[img2]: media/outlook-send-and-archive.png
