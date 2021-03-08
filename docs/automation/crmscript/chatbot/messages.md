---
title: chatbot_messages
description: Chatbot messages
author: christianm
so.date: 2021-03-08
keywords: chatbot, ai
so.topic: reference
---


## Bot Message Received

This script is called when user sends new message to bot - not called when bot posts messages.
Called after the generic ChatBeforeSaveNewMessage and ChatAfterSaveNewMessage triggers have run.

Bot can respond using `addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams, DateTime whenPosted)`
to add more messages to the chat. Use type = 1 to indicate message is sent to customer.

You can use the `whenPosted` parameter to space out the bot replies to make them seem less robotic.

Input values:

* `chatSession.topicId`
* `chatSession.status`
* `chatSession.userId`
* `chatSession.customerId`
* `chatSession.contactId`
* `chatSession.projectId`
* `chatSession.saleId`
* `chatSession.ticketId`
* `chatSession.botActive`
* `chatSession.customerName`
* `chatSession.customerEmail`
* `chatSession.companyName`
* `chatSession.customerPhone`
* `chatMessage.sessionId`
* `chatMessage.id`
* `chatMessage.message` - what the customer typed
* `chatMessage.type` - 2 = from the customer, or 3 = special
* `chatMessage.specialType` - if type = 3
* `chatMessage.specialParam` - if type = 3 - json containing options
* `chatMessage.author` - name shown in chat
* `chatTopic.id`
* `chatTopic.botName`

### Chat Message types

* ToCustomer = 1,
* ToUser = 2,
* Special = 3

### Chat Message Special types

* None = 0,
* Welcome = 1,
* Url = 2,
* Block = 3,
* NewSession = 5,
* TransferedSession = 6,
* Error = 7,
* Deleted = 8,
* FaqSuccessQuestion = 9,
* ClosedByUser = 10,
* ClosedByCustomer = 11,
* ClosedByIdle = 12,
* TransferRejected = 13,
* ReopenedByCustomer = 14,
* ClickedOption = 15,
* Options = 17 *Message has a list of clickable options. Options are as JSON array in specialParam*

