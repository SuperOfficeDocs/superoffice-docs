---
uid: sofo-save-to-superoffice
title: Save to SuperOffice
description: Save to SuperOffice
keywords: SuperOffice for Outlook, Outlook, archive email, email, save to SuperOffice, send and archive, save attachment, SOFO
author: Erik Lebiko, Bergfrid Dias, Andrea Schilde
date: 05.05.2026
version_sofo: 6.3.0
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

[Pin the SuperOffice for Outlook panel][2] to keep it visible while you work.

## Archive email to SuperOffice

To archive information from an email in Outlook and save it to SuperOffice:

1. Open or select the email you want to archive.

1. [Open SuperOffice for Outlook][1] (if not pinned).

1. SuperOffice matches the sender to a contact. If the email address matches multiple contacts, select the correct one — the **Company** and **Contact** fields fill in automatically.

1. Choose the appropriate action in the SuperOffice sidebar.

1. Make any necessary changes to the fields.

1. If you do not want to archive the attachments, select **Do not archive attachments**.

1. Click **Save** to archive the email.

![SuperOffice for Outlook, archive email -screenshot][img1]

## Archive email from a shared mailbox

If you have access to a shared mailbox in Outlook, you can archive emails from that mailbox to SuperOffice in the same way as emails from your personal mailbox.

> [!NOTE]
> The first time you use SuperOffice for Outlook with a shared mailbox, you might be asked to [approve additional Microsoft permissions][3]. If you do not have sufficient rights to approve these yourself, contact your Microsoft 365 administrator.
>
> The shared mailbox must already be available to you in Outlook. Access to shared mailboxes is managed in Microsoft 365.

1. Open the shared mailbox in Outlook and select the email you want to archive.

1. [Open SuperOffice for Outlook][1] (if not pinned).

1. SuperOffice matches the sender to a contact. If the email address matches multiple contacts, select the correct one — the **Company** and **Contact** fields fill in automatically.

1. Choose the appropriate action in the SuperOffice sidebar.

1. Make any necessary changes to the fields.

1. If you do not want to archive the attachments, select **Do not archive attachments**.

1. Select whether to remove the email from the inbox after archiving, if this option is available.

1. Click **Save** to archive the email.

## Save attachments to SuperOffice

You can also save email attachments directly to SuperOffice by following these steps:

1. Open the email that contains the attachments.

1. Choose **Save attachment in SuperOffice** from the SuperOffice sidebar.

1. Select the attachment you want to save from the list shown.

    > [!NOTE]
    > Attachments larger than 28 MB cannot be saved to SuperOffice.
    > Previously saved attachments will be marked as "Attachment already saved."

1. Fill in the required fields and click **Save**.

1. To save another attachment, repeat steps 1-4.

## Send and archive

To send an email and automatically archive it to SuperOffice, follow these steps:

1. Select **New mail** in Outlook.

1. [Open SuperOffice for Outlook][1].

1. The **Archive email in SuperOffice** toggle is turned on by default. Turn it off if you do not want this email archived in SuperOffice.

    ![SuperOffice for Outlook, send and archive -screenshot][img2]

    > [!NOTE]
    > Bcc to **SuperOffice Mail Archive** is required to ensure the email is archived in SuperOffice.

1. Add recipients to the **To** field. If their email is known to SuperOffice, **Company** and **Contact** fill in automatically. If the email matches multiple contacts, select the correct one first.

1. Fill in any missing information or make adjustments as needed.

1. Click **Send** to both send the email and archive it to SuperOffice.

## Send and archive from a shared mailbox

You can compose a new email from a shared mailbox and archive it to SuperOffice while sending.

> [!CAUTION]
> Always check the **From** address before sending from a shared mailbox.

1. Select **New mail** in Outlook.
1. Open and, if needed, pin SuperOffice for Outlook.
1. Select the shared mailbox address in the **From** field. If the **From** field is not visible, enable it in Outlook first.
1. Add recipients and write the email.
1. Keep **Archive email in SuperOffice** turned on to archive the email.
1. Check or adjust the SuperOffice fields.
1. Select **Send**.

<!-- Referenced links -->
[1]: get.md#open
[2]: get.md#pin
[3]: https://community.superoffice.com/en/support-faqs/faq/superoffice-for-outlook-authorisation-guide/

<!-- Referenced images -->
[img1]: media/outlook-save-to-superoffice.png
[img2]: media/outlook-send-and-archive.png
