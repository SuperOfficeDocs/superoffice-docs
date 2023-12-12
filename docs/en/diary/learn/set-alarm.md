---
uid: help-en-follow-up-alarms
title: Set alarm for follow-up
description: How to sett an alarm for a follow-up in SuperOffice.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: diary, follow-up, meeting, alarm, notification, reminder, alert
so.topic: howto
language: en
---

# Set alarm for follow-up

SuperOffice CRM can remind you before your meeting starts. At the set lead time, a system notification will appear on your device.

![SuperOffice browser notification -screenshot][img4]

For video meetings, a notification from the meeting system provider (such as Microsoft Teams) will appear at the meeting's start. Click the **Join Meeting** button to participate, or, if you are the host, click **Start Meeting**.

## Steps

[!include[Recurrence](includes/note-repetition.md)]

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/old)

1. [Open or create a follow-up][1].
1. Select the **Details** tab.
1. Check the **Alarm** checkbox.
1. In the field next to the checkbox, add the number of hours and minutes ahead of your meeting you wish to be reminded.

    The default is 10 minutes, but you can change it.

1. Click **Save**.

![You can set an alarm to be notified before your meeting begins -screenshot][img2]

### [New (from version 10.2.11 pilot)](#tab/new)

1. [Open or create a follow-up][1].
1. Click the bell icon in the header and select a time.
1. Click **Save**.

![Alarm drop-down list in Follow-up dialog header -screenshot][img3]

***
<!-- markdownlint-restore -->

> [!NOTE]
> Follow-up reminders (alarms) are not the same as [activity notifications][2], which pertain to new or updated meeting invitations shown in the Notifications panel inside SuperOffice.

<!-- Referenced links -->
[1]: create-follow-up.md
[2]: ../../learn/basics/notifications.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/appointment-alarm-on-meeting.png
[img3]: ../../../media/loc/en/diary/set-alarm-in-header.png
[img4]: ../../../media/loc/en/diary/edge-meeting-alarm.png
