---
uid: chatbot_reference_registration
title: Chatbot Scripts Reference
description: Chatbot scripts reference
author: christianm
so.date: 03.08.2021
keywords: chatbot, ai
so.topic: reference
---

# Chatbot scripts reference

## Bot Register

The script name must match the pattern `'%bot%register%'`.

### Input variables

| Variable | Description |
|---|---|
| action | "register" / "unregister" |
| topicid | the ID of the topic the bot is active on |

## Bot Session Create

The script name must match the pattern `'%bot%session%create%'`.

Called when a new session starts on a channel with the bot activated.

### Input values

| Value | Description |
|---|---|
| chatSession.id | session has been saved/created at this point |
| chatSession.topicId | topic the session belongs to |
| chatSession.customerAlias | |
| chatSession.sessionKey | |
| chatSession.customerHost | |
| chatSession.status | state of new session |
| chatSession.chatbot_isactive | "1" (true) for bot sessions |
| chatTopic.id | same as `chatSession.topicId` |
| chatTopic.name | name of channel |
| chatTopic.botName | name of bot |
| foundAgents | any agents found? Never true for bot channels |

## Bot Session Change

The script name must match the pattern `'%bot%session%change%'`.

This script is called when the session changes status (when pre-form is filled in by the customer).

### Input values

| Value | Description |
|---|---|
| chatSession.id | session ID |
| chatSession.topicId | topic the session belongs to |
| chatSession.status | new status |
| chatSession.userId | SuperOffice user handling the session |
| chatSession.customerId | |
| chatSession.botActive | always going to be true |
| chatSession.customerName | if filled in by pre-form |
| chatSession.customerEmail | if filled in by pre-form |
| chatSession.companyName | if filled in by pre-form |
| chatSession.customerPhone | if filled in by pre-form |

Variables `status.old` and `status.new` contain old and new values for chat session status.

### <a name="chatSessionStatus"></a>Chat session status values

| Value | Status |
|:-:|---|
| 0 | StatusInvalid |
| 1 | StatusPreChatForm |
| 2 | StatusFaq |
| 3 | StatusOfflineForm |
| 4 | StatusInQueue |
| 5 | StatusCustomerLast |
| 6 | StatusUserLast |
| 7 | StatusFinished |
| 8 | StatusDeleted |
| 9 | StatusClosed |
| 10 | StatusRequestPosted |
| 11 | StatusClosedFromQueue |

## Bot Message Receive

The script name must match the pattern `'%bot%message%receive%'`.

### Input values

| Value | Description |
|---|---|
| chatSession.topicId |
| chatSession.status | pre-chat form, in-queue, user message, and so on |
| chatSession.userId | the SuperOffice user handling the session, not set for bots |
| chatSession.botActive | 1 for bots |
| chatSession.customerName | from pre-form |
| chatSession.customerEmail | from pre-form |
| chatSession.companyName | from pre-form |
| chatSession.customerPhone | from pre-form |
| chatSession.customerId | |
| chatSession.contactId | |
| chatSession.projectId | |
| chatSession.saleId | |
| chatSession.ticketId | |
| chatMessage.sessionId | |
| chatMessage.id | |
| chatMessage.message | what the customer typed |
| chatMessage.type | 2 = from the customer, or 3 = special |
| chatMessage.specialType | if type = 3 |
| chatMessage.specialParam | if type = 3 - Json containing options |
| chatMessage.author | name shown in chat |
| chatTopic.id | |
| chatTopic.botName | |

## Bot Post Message

`addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams, DateTime whenPosted)`

Posting a message will set the chat session status to 6 (user last) since the bot was the last to speak.

## Reset Chat

`resetChat(Integer sessionId)`

This starts the session over (session status starts at the beginning again).

## Change Status

`setChatStatus(sessionId, Integer newStatus)`

This changes the session status. This may trigger the session changed event.

## <a name="chatMessageType">Chat message types

| Value | Type |
|:-:|---|
| 1 | ToCustomer |
| 2 | ToUser |
| 3 | Special |

## <a name="chatMessageSpecialType">Chat message special types

| Value | Type |
|:-:|---|
| 0 | None |
| 1 | Welcome |
| 2 | Url |
| 3 | Block |
| 5 | NewSession |
| 6 | TransferedSession |
| 7 | Error |
| 8 | Deleted |
| 9 | FaqSuccessQuestion |
| 10 | ClosedByUser |
| 11 | ClosedByCustomer |
| 12 | ClosedByIdle |
| 13 | TransferRejected |
| 14 | ReopenedByCustomer |
| 15 | ClickedOption |
| 17 | Options |

> [!NOTE]
> 17 means that the message has a **list of clickable options**. Options are as JSON array in `specialParam`.
