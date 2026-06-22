---
uid: sofo-email-archive-reminder
title: Email archive reminder
description: How the email archive reminder works in SuperOffice for Outlook and what to do when the reminder appears.
keywords: SuperOffice for Outlook, Outlook, archive reminder, Smart Alerts, archive email, SOFO
author: schildea
date: 05.16.2026
version_sofo: 2026.6.3
content_type: howto
category: integration
topic: SuperOffice for Outlook
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
---

# Email archive reminder

The email archive reminder helps you make sure that important customer communication is captured in SuperOffice. When you send an email that is not set to be archived, SuperOffice for Outlook reminds you before the email is sent so you can decide what to do.

## How it works

When you click **Send** on a new email, reply, or forward, and the **Archive email in SuperOffice** toggle is off, a Smart Alerts dialog appears.

![Archive reminder dialog in SuperOffice for Outlook -screenshot][img1]

The dialog reads:

*This email is not marked for archiving in SuperOffice. You can archive it after sending, or open the SuperOffice panel to archive it now.*

You have three options:

| Option | What happens |
|---|---|
| **Don't send** (default) | Sending is cancelled so you can review or update the email. |
| **Archive email** | The SuperOffice compose pane opens, focused on the archive toggle, so you can turn archiving on. Sending is paused until you act. |
| **Send anyway** | The email is sent without being archived in SuperOffice. |

> [!NOTE]
> If you choose **Archive email** and turn the archive toggle on, then click **Send** again, the reminder will not appear a second time for that email.

## When the archive reminder appears

The reminder appears based on your personal settings. By default, it is shown for:

- New emails
- Replies
- Forwards

You can adjust these preferences – for example, to only be reminded when sending to recipients outside your organization. See [Settings][1] for details.

The reminder does **not** appear if:

- Archiving is already turned on for that email.
- The main **Remind me before sending emails** toggle is turned off in Settings.
- Your Outlook client does not meet the minimum requirement (mailbox requirement set 1.12).

## Configure the reminder

You can turn the reminder on or off and adjust which email types trigger it from the Settings menu.

1. Open the SuperOffice for Outlook side panel.
2. Click the **gear icon** to open Settings.
3. Scroll to the **Archive reminder** section and adjust your preferences.

See [Settings – Archive reminder][2] for a full description of each option.

## Related content

- [Settings][1]
- [Archive emails][3]

<!-- Referenced links -->
[1]: settings.md
[2]: settings.md#archive-reminder
[3]: save-to-superoffice.md

<!-- Referenced images -->
[img1]: media/outlook-archive-reminder-dialog.png
