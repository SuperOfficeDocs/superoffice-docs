---
uid: sofo-settings
title: Settings
description: How to open and configure the settings menu in SuperOffice for Outlook.
keywords: SuperOffice for Outlook, Outlook, settings, archive reminder, SOFO
author: schildea
date: 06.16.2026
version_sofo: 2026.6.3
content_type: reference
category: integration
topic: SuperOffice for Outlook
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
---
# Settings

The Settings menu lets you personalize how SuperOffice for Outlook behaves for you. From here you can review your profile, manage archiving preferences, and control when you are reminded to archive emails and meetings.

## Open settings

The gear icon (⚙) is available in both the **Action** panel and the **People** panel.

1. Open the SuperOffice for Outlook side panel.
2. Click the **gear icon** towards the top-right corner of the panel.

The Settings menu opens and shows:

* Your user profile (name and tenant)
* All user-configurable options
* The add-in version number
* A **Disconnect Outlook from SuperOffice** button

## Settings overview

| Setting | Description |
|---|---|
| Show contextual projects and sales | Displays projects and sales registered to the selected company or contact. |
| Remove from inbox | Moves the email to deleted items after archiving. |
| Archive reminder | Controls when you are reminded to archive before sending an email or meeting. See [Archive reminder](#archive-reminder) below. |

## Archive reminder

The **Archive reminder** section lets you control whether SuperOffice for Outlook prompts you to archive an email or meeting before you send it.

![Archive reminder settings showing toggles for emails and meetings -screenshot][img1]


### Enable or disable the reminder

Two separate toggles control reminders for emails and meetings:

* **Remind me before sending emails**
    * On (default): you are reminded to archive emails that are not yet set to be archived in SuperOffice.
    * Off: no email reminder is shown, and all email sub-settings are disabled and greyed out.
* **Remind me before sending meetings**
    * On (default): you are reminded to archive meetings that are not yet set to be archived in SuperOffice. This applies to appointments with at least one attendee.
    * Off: no meeting reminder is shown.

### Configure which emails trigger a reminder

When **Remind me before sending emails** is on, you can choose which types of outgoing emails trigger the reminder:

| Sub-setting | Default | Description |
|---|---|---|
| New emails | On | Reminder appears when sending a new email. |
| Replies | On | Reminder appears when replying to an email. |
| Forwards | On | Reminder appears when forwarding an email. |
| External recipients only | Off | When enabled, the reminder only appears for emails sent outside your organization. |

The **Remind me before sending meetings** toggle doesn't have additional sub-settings. When it's on, you're reminded to archive any meeting with at least one attendee that isn't yet archived in SuperOffice.

Your settings are saved automatically and sync across all your devices.

> [!NOTE]
> The archive reminder feature is only available in Outlook versions that support Microsoft Mailbox requirement set 1.12 or later. If it's not supported, the reminder won't appear and your email or meeting will be sent as usual.

## Related content

* [Archive reminder][1]
* [Send and archive][2]
* [Add CRM data to Outlook calendar events][3]

<!-- Referenced links -->
[1]: archive-reminder.md
[2]: send-and-archive.md
[3]: add-crm-data-to-event.md

<!-- Referenced images -->
[img1]: media/outlook-settings-archive-reminder.png