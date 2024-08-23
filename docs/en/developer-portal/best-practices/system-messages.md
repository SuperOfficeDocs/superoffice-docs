---
title: System Messages
uid: system-messages
description: System Messages
author: Eivind Fasting
date: 08.27.2024
version: 10.3.8
keywords: app, notification, message, systemmessage
topic: concept
envir: cloud
client: online
---

# System messages

System messages are an API-based solution that triggers a **yellow warning banner** for selected users, implemented within the SCIL framework. It was originally created to notify users if their session has expired, prompting them to re-authenticate.

Partners sometimes also need a reliable method to notify users when authentication to their system has expired, and this is where System messages come in handy.

> [!WARNING]
> Developers must be cautious/selective with what they send to users. System messages are not meant to be used as a form of messaging between clients!

* Regular users cannot send messages to others, but they can send reminders to themselves.
* Admin or system users can send messages to other users.

System messages support standard Markdown.

## KeepAlive

To ensure timely delivery of messages and prevent indefinite queuing, system messages are tightly integrated with the KeepAlive system.

The KeepAlive system periodically makes API calls to check the user's authentication status. When the KeepAlive is called, the server event plugin will checks for any pending messages associated with the current associate. If relevant system messages are found, they are returned in the KeepAlive response.

## Dismissing messages

When a user closes the banner (clicking ❌ button), `RemoveSystemMessage` is called, which will remove the message from the database.

> [!NOTE]
> If a message is no longer relevant, it is the partner's responsibility to remove it from the table to avoid unnecessary warnings. For example, after an associate connects to the partner application, partners can check if any messages exists in the message table and [remove them](#remove).

## Send system message

The [DiagnosticsAgent_SendSystemMessage][2] method puts a new system message into the message table for a specific user.

**Parameters:**

| Name | Type | Description |
|---|---|---|
| AssociateId | Integer | Associate identifier |
| SystemMessageId | String | Unique message ID |
| MarkdownMessage | String | Main content of the system message (in simple Markdown format) |
| Expire | DateTime | Expiration date and time for the system message |
| Type | [SystemMessageType](#systemmessagetype) | Type of system message (such as Info, Warning, Error) |

## <a id="remove"></a>Remove system message

The [DiagnosticsAgent_RemoveSystemMessage][4] method removes a message from the message table for a specific associate.

A system user or user administrator rights are required to remove other's messages.

**Parameters:**

| Name | Type | Description |
|---|---|---|
| SystemMessageId | Integer | Unique message ID to be removed |

## Get system messages

The [DiagnosticsAgent_GetSystemMessages][5] method retrieves system messages for a specific associate.

**Parameters:**

| Name | Type | Description |
|---|---|---|
| AssociateId | Integer | Associate identifier |

### <a id="systemmessagetype"></a>SystemMessageType

| ID | Value | Description |
|:-:|---|---|
| 0 | Unspecified | System message type is unspecified. |
| 1 | Info | There is information that the user should be made aware of. |
| 2 | Warning | There is a problem that the user must be made aware of. |
| 3 | Error | There is a problem that the system will not be able to resolve. |

<!-- Reference links -->
[2]: ../../api/reference/restful/agent/Diagnostics_Agent/v1DiagnosticsAgent_SendSystemMessage.md
[4]: ../../api/reference/restful/agent/Diagnostics_Agent/v1DiagnosticsAgent_RemoveSystemMessage.md
[5]: ../../api/reference/restful/agent/Diagnostics_Agent/v1DiagnosticsAgent_GetSystemMessages.md
