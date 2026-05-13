---
uid: teams-archive-conversation
title: Archive a Teams conversation
description: How to save Teams chat messages and channel conversations to SuperOffice.
keywords: SuperOffice for Teams, Teams, archive, save chat, conversation, messages
author: schildea
date: 07.05.2026
version:
content_type: howto
category: integration
topic: SuperOffice for Teams
language: en
---

# How to archive a conversation

Archiving works in chats and standard channels – refer to the [compatibility overview][1] to see exactly what's supported where. You can start archiving in two ways. Both open the same archive window, where you choose your scope and fill in the details needed to save the content to the right place in SuperOffice.

## Option A – Start from a specific message

Use this when you want to capture a specific point in the conversation – a key decision, a handover, or (in a standard channel) a message with a file.

1. Find the message in the chat or channel.
2. Right-click the message (or select the **...** menu).
3. Choose **SuperOffice for Teams**.
4. Click **Save Chat**.
5. Choose your scope: **This message**, **This and later**, or **Custom**.
6. Fill in the details to connect the archive to the right record in SuperOffice (see below).
7. Click **Create**.

![The right-click context menu on a Teams message, with the "SuperOffice for Teams" option highlighted][img1]

## Option B – Start from the compose bar

Use this when you want to archive a range of messages – like Today, Yesterday, or the Last 7 days.

1. Open the chat or channel.
2. Click the **+** (apps) icon in the compose area.
3. Search for and select **SuperOffice for Teams**.
4. Click **Save Chat** in the pop-up.
5. Pick a date range or choose **Custom** to select start and end dates.
6. Fill in the details to connect the archive to the right record in SuperOffice (see below).
7. Click **Create**.

> [!NOTE]
> Starting apps from the compose bar is blocked in direct chats with external users. You can still launch SuperOffice for Teams from the message menu if both users are managed by an organization.

![The compose bar area with the "+" (apps) icon expanded, showing SuperOffice for Teams in the app picker][img2]

## Choosing what to include

Before you save, you can decide what gets included.

**Include deleted message notices** – Adds a placeholder line where messages were removed. The original deleted content is not retrieved.

**Include emoji reactions** – Captures reactions like thumbs up or heart alongside messages. Custom emojis are not supported.

**Include files (attach to .EML)** – Attaches files from the selected date range to the email file. This option is only available in standard channels.

![Archive window showing options for deleted message notices, emoji reactions, file attachments, and AI summary][img5]

## Choosing where it goes in SuperOffice

Whether you're saving a chat or a file, you'll fill in a few details so the archive lands in the right place.

**Title** – Prefilled based on your selection, but you can change it.

**Contact or Company** – SuperOffice will automatically pre-populate this field if it can match someone from the conversation to a contact in SuperOffice. If no match is found, pick a company or contact manually. You'll see recently used entries from SuperOffice, and you can search by name. Click the **Chat** icon to pick someone from the Teams conversation who also exists in SuperOffice.

**Sale (optional)** – Link the message or file to a sale.

**Project (optional)** – Link the message or file to a project.

**Document template (Type)** – Choose the document template your organization has set up for Teams conversations or files.

**Completed** – Check this to mark the activity as completed in SuperOffice. If unchecked, it appears in your open activities.

![The archive form showing title, contact, sale, project, template, and options fields][img3]

When you're ready, click **Create**. After a successful save, SuperOffice for Teams shows an **Open in SuperOffice** link so you can jump straight to the new document.

![The successfully archived chat confirmation with the Open in SuperOffice button][img4]

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
[img1]: media/teams-message-menu-sofo.png
[img2]: media/teams-compose-bar-picker.png
[img3]: media/teams-archive-form.png
[img4]: media/teams-archive-success.png
[img5]: media/tearms-archive-what-to-include.png