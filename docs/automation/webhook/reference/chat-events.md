---
title: Chat events
uid: webhook_chat_event
description: Chat events
author:
so.date:
keywords: automation
so.topic: reference
# so.envir:
# so.client:
---

# Chat events

These events are fired when chat sessions and messages change:

* `chatsession.created` - new session starts
* `chatsession.message` - new message added to chat
* `chatsession.changed` - session has changed state

## ChatSession.Created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: chatsession.created
X-Superoffice-Eventid: e87ac619-c864-4881-89eb-07ca5521ee2c
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
  ],
  "Event": "chatsession.created",
  "PrimaryKey": 178105,
  "Entity": "chatsession",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## ChatSession.Message

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
    "chatSession.topicId",
    "chatSession.userId",
    "chatSession.customerId",
    "chatSession.customerName",
    "chatSession.customerEmail",
    "chatSession.companyName",
    "chatSession.customerPhone",
    "chatMessage.sessionId",
    "chatMessage.id",
    "chatMessage.message",
    "chatMessage.type",
    "chatMessage.specialType",
    "chatMessage.specialParam",
    "chatMessage.author",
  ],
  "Event": "chatsession.message",
  "PrimaryKey": 178105,
  "Entity": "chatsession",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## ChatSession.changed

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Event": "chatsession.changed",
  "PrimaryKey": 178105,
  "Entity": "chatsession",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```
