---
uid: teams-overview
title: SuperOffice for Teams
description: Save Microsoft Teams conversations and files directly into SuperOffice CRM.
keywords: SuperOffice for Teams, Teams, Microsoft Teams, archive, chat, integration
author:
date: 07.05.2026
version:
content_type: overview
category: integration
topic: SuperOffice for Teams
language: en
---

# SuperOffice for Teams (pilot)

SuperOffice for Teams connects your Microsoft Teams conversations with your CRM. Instead of searching through channels and chats to find what a customer said, you can save conversations and standard-channel files directly to SuperOffice – right where they belong.

## What you can do

* Save messages from chats and standard channels to SuperOffice.
* Save a single file from a message in a standard channel.
* Archive a date range of messages: Today, Yesterday, Last 7 days, or a custom range.
* Generate an AI summary to capture the essence of a conversation without re-reading it. Requires AI Labs to be activated.

Archived conversations are stored as .EML files in SuperOffice, making them easy to preview and share.

## Who is it for?

SuperOffice for Teams is for anyone who communicates with customers or partners in Teams and wants that history visible in SuperOffice. This includes sales representatives, account managers, support teams, customer success teams, and project teams.

## What works – and what doesn't

Microsoft controls where Teams apps can run. SuperOffice for Teams works in chats between managed users and in standard channels.

| Context | Save messages | Save files |
|---|---|---|
| 1:1 chat (both managed users) | Yes | No |
| Group chat (all managed users) | Yes | No |
| Meeting chat (all managed users) | Yes | No |
| Standard channel | Yes | Yes |
| Private channel | No | No |
| Shared channel | No | No |
| 1:1 chat with unmanaged user | No | No |

> [!NOTE]
> File archiving is only available in standard channels. SuperOffice for Teams disables file uploading and attaching in chat contexts.

A **managed user** has a Teams account provided by an organization (for example, anna@yourcompany.com). An **unmanaged user** has a personal Microsoft account (for example, anna@hotmail.com). You can usually identify unmanaged users by the **External** banner in Teams.

A **guest** is an external user formally invited to your team. Guests show a **Guest** banner next to their name. Because they are invited through your organization's tenant, SuperOffice for Teams can work with them in standard channels.

> [!NOTE]
> Private and shared channels are not supported in the current pilot. Share your feedback with SuperOffice if these are important to you.

## Related topics

* [Requirements][1]
* [Deploy SuperOffice for Teams (administrators)][2]
* [Get SuperOffice for Teams (users)][3]
* [Archive a conversation][4]
* [Save a file from a channel][5]
* [AI summaries][6]
* [Preferences][7]
* [Permissions and security][8]

<!-- Referenced links -->
[1]: requirements.md
[2]: deploy.md
[3]: get.md
[4]: archive-conversation.md
[5]: archive-file.md
[6]: ai-summary.md
[7]: preferences.md
[8]: security.md