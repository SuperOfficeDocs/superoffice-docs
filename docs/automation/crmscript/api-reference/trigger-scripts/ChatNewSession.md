---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ChatNewSession (400)

Fires when a new chat session starts.

Corresponds to the webhook `chatsession.created` event.

## Input values
|Variable|Description|
|---|---|
| `chatSession.id` | session ID|
| `chatSession.topicId` | the chat topic this chat session belongs to|
| `chatSession.customerAlias` | person name from form|
| `chatSession.sessionKey` | secret key|
| `chatSession.customerHost` | hostname|
| `chatSession.status` | session status|

## Status values

* StatusInvalid = 0,
* StatusPreChatForm = 1,
* StatusFaq = 2,
* StatusOfflineForm = 3,
* StatusInQueue = 4,
* StatusCustomerLast = 5,
* StatusUserLast = 6,
* StatusFinished = 7,
* StatusDeleted = 8,
* StatusClosed = 9,
* StatusRequestPosted = 10,
* StatusClosedFromQueue = 11

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("chatSession.id");
String param2 = ed.getInputValue("chatMessage.id");
String param3 = ed.getInputValue("chatMessage.message");
```
