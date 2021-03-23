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

* `chatSession.id` = session ID
* `chatSession.topicId` = the chat topic this chat session belongs to
* `chatSession.customerAlias` = person name from form
* `chatSession.sessionKey` = secret key
* `chatSession.customerHost` = hostname
* `chatSession.status` = session status

[!include[ALT](./includes/status-values.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("chatSession.id");
String param2 = getVariable("chatMessage.id");
String param3 = getVariable("chatMessage.message");
```
