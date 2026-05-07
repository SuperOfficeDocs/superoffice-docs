---
uid: teams-archive-conversation
title: Archive a Teams conversation
description: How to save Teams chat messages and channel conversations to SuperOffice.
keywords: SuperOffice for Teams, Teams, archive, save chat, conversation, messages
author:
date: 07.05.2026
version:
content_type: howto
category: integration
topic: SuperOffice for Teams
language: en
---

# Archive a Teams conversation

You can archive messages from chats and standard channels. See the [compatibility overview][1] for details on what is supported in each context.

There are two ways to open the archive window. Both lead to the same form.

## Option A – Start from a specific message

Use this when you want to capture a specific point in the conversation, such as a key decision, a handover, or a message that contains a file.

1. Find the message in the chat or channel.
2. Right-click the message (or click the **...** menu).
3. Choose **SuperOffice for Teams**.
4. Click **Save Chat**.
5. Choose your scope: **This message**, **This and later**, or **Custom**.
6. Fill in the details to link the archive to the right record in SuperOffice.
7. Click **Create**.

![The right-click context menu on a Teams message with SuperOffice for Teams highlighted][img1]

## Option B – Start from the compose bar

Use this when you want to archive a range of messages, such as Today, Yesterday, or the Last 7 days.

1. Open the chat or channel.
2. Click the **+** (apps) icon in the compose area.
3. Search for and select **SuperOffice for Teams**.
4. Click **Save Chat**.
5. Pick a date range, or choose **Custom** to set start and end dates.
6. Fill in the details to link the archive to the right record in SuperOffice.
7. Click **Create**.

![The compose bar with the apps icon expanded, showing SuperOffice for Teams in the picker][img2]

> [!NOTE]
> Starting apps from the compose bar is blocked in direct chats with external users. Use Option A from the message menu instead, provided both users are managed by an organization.

## What to include

Before saving, choose what gets included in the archive:

* **Include deleted message notices** – adds a placeholder where messages were removed. The original content is not retrieved.
* **Include emoji reactions** – captures reactions such as thumbs up or heart. Custom emojis are not supported.
* **Include files (attach to .EML)** – attaches files from the selected date range to the email file. Only available in standard channels.

## Link the archive to SuperOffice

Fill in the following fields to make sure the archive lands in the right place in SuperOffice:

* **Title** – pre-filled based on your selection, but editable.
* **Contact or Company** – automatically pre-populated if SuperOffice can match a participant to an existing contact. If no match is found, search manually. Click the **Chat** icon to pick someone from the Teams conversation who also exists in SuperOffice.
* **Sale** (optional) – link to a sale record.
* **Project** (optional) – link to a project record.
* **Document template** – choose the template your organization uses for Teams conversations.
* **Completed** – check this to mark the activity as completed. If unchecked, it appears in your open activities.

![The archive form showing title, contact, sale, project, template, and options fields][img3]

## After saving

After a successful save, SuperOffice for Teams shows an **Open in SuperOffice** link so you can go directly to the new document.

![The successfully archived chat confirmation with the Open in SuperOffice button][img4]

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
[img1]: media/teams-message-menu-sofo.png
[img2]: media/teams-compose-bar-picker.png
[img3]: media/teams-archive-form.png
[img4]: media/teams-archive-success.png