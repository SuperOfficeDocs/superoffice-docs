---
title: System Messages
uid: system-messages
description: System Messages
author: Eivind Fasting
date: 08.14.2024
keywords: app, notification, message, systemmessage
topic: concept
envir: cloud
client: online
---

# System Messages

System messages are meant to be an API-based solution that triggers a yellow warning banner for relevant users, implemented within the SCIL framework, and was originally created to notify users if their session has expired, prompting users to re-authenticate.
Partners sometimes also need a reliable method to notify users when authentication to their system has expired, and this is where SystemMessages come in handy.

>[!WARNING]
>Developers need to be cautious/selective with what they send to the users, and this is not meant to be used as a form of messaging between clients!

* Regular users cannot send messages to others, but they can send reminders to themselves.
* Admin or systemusers can send messages to other users.

System messages support standard markdown.

## KeepAlive

To ensure timely delivery of messages and prevent indefinite queuing, we’ll tightly integrate the SystemMessages with the KeepAlive system.

The KeepAlive system periodically makes API calls to check the user’s authentication status.
When the KeepAlive is called, the server event plugin will checks for any pending messages associated with the current associate.
If there are relevant system messages found, they are returned in the KeepAlive response.

## Dismissing messages

When a user closes the with the banner (clicking ❌ button), the RemoveSystemMessage is called, which will remove the message from the database.

>[!NOTE]
>If a message is no longer relevant, its the partners responsibility to remove it from the table to avoid unnecessary warnings. E.g. after an associate connects to the partner app, partners can check if any messages exists in the message table and [remove them][1].

## Send system message

The [DiagnosticsAgent_SendSystemMessage][2] method puts a new system message into the message table for a specific user. It requires the following parameters:

| name | type | description |
| ---- | ---- | ----------- |
| AssociateId | integer | Associate identifier |
| SystemMessageId | string | Unique message ID |
| MarkdownMessage | string | Main content of the system message (in simple Markdown format) |
| Expire | DateTime | Expiration date and time for the system message |
| Type | [SystemMessageType][3] | Type of system message (e.g., Info, Warning, Error) |

## Remove system message

Removes a message from the message table for a specific associate.
Requires system user rights or user administrator rights when removing other’s messages.
Removing a message can be invoked through the [DiagnosticsAgent_RemoveSystemMessage][4], and requires the following parameters:

| name | type | description |
| ---- | ---- | ----------- |
| SystemMessageId | integer | Unique message ID to be removed |

## Get system messages

Retrieves system messages for a specific associate.
Removing a message can be invoked through the [DiagnosticsAgent_GetSystemMessages][5], and requires the following parameters:

| name | type | description |
| ---- | ---- | ----------- |
| AssociateId | integer | Associate identifier |

### SystemMessageType

| id | value | description |
| ------------- | ------------- |  ------------- |
| 0 | Unspecified | System message type is unspecified. |
| 1 | Info | There is information that the user should be made aware of. |
| 2 | Warning | There is a problem that the user must be made aware of. |
| 3 | Error | There is a problem that the system will not be able to resolve. |

<!-- Reference links -->
[1]: #removesystemmessage
[2]: www.vg.no
[3]: #systemmessagetype
[4]: www.vg.no
<!-- https://superofficenorge.sharepoint.com/:w:/r/sites/design/_layouts/15/Doc.aspx?sourcedoc=%7BD4594635-7AB3-4F32-B6B7-838B99883C90%7D&file=Tech%20Spec%20-%20yellow%20banner.docx&action=default&mobileredirect=true -->