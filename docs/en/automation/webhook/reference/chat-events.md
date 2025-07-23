---
uid: webhook_chat_event
title: Chat events
description: Chat events
keywords: chat webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Chat events

These events are fired when chat sessions and messages change:

* `chatsession.created` - new session starts
* `chatsession.message` - new message added to chat
* `chatsession.changed` - session has changed state

## ## FieldValues for chat events

The following fields are included in the `FieldValues` property of the webhook payload for chat events:

* `alertLevel` - alert level of the chat session
* `chatbotIsactive` - whether the chatbot is active or not
* `consented` - whether the customer has consented to the chat
* `contactId` - ID of the contact associated with the chat session
* `customerAlias` - alias of the customer
* `customerId` - ID of the customer
* `projectId` - ID of the project associated with the chat session
* `rating` - rating of the chat session
* `saleId` - ID of the sale associated with the chat session
* `status` - status of the chat session
* `ticketId` - ID of the ticket associated with the chat session
* `topicId` - ID of the topic associated with the chat session
* `userId` - ID of the user associated with the chat session

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
  "WebhookName": "Name you provided",
  "FieldValues": {
    "AlertLevel": 0,
    "ChatbotIsactive": false,
    "Consented": false,
    "ContactId": "21",
    "CustomerAlias": 5,
    "CustomerId": "12",
    "ProjectId": 5,
    "Rating": 0,
    "SaleId": 0,
    "Status": 0,
    "TicketId": 0,
    "TopicId": 0,
    "UserId": 0,
  }
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
