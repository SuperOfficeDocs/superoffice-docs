---
uid: chatbot_reference_registration
title: Chatbot Scripts Reference
author: christianm
so.date: 2021-03-29
keywords: chatbot, ai
so.topic: reference
---

## Bot Register

The script name must match the pattern `'%bot%register%'`.

Input variables

* `action` = "register" / "unregister"
* `topicid` = the id of the topic the bot is active on.

## Bot Session Create

The script name must match the pattern `'%bot%session%create%'`.

Called when a new session starts on a channel with the bot activated.

Input values:

* `chatSession.id` - session has been saved/created at this point.
* `chatSession.topicId` - topic the session belongs to
* `chatSession.customerAlias`
* `chatSession.sessionKey`
* `chatSession.customerHost`
* `chatSession.status` - state of new session
* `chatSession.chatbot_isactive` - "1" (true) for bot sessions
* `chatTopic.id` - same as "chatSession.topicId"
* `chatTopic.name` - name of channel
* `chatTopic.botName` - name of bot
* `foundAgents` - any agents found? Never true for bot channels

## Bot Session Change

The script name must match the pattern `'%bot%session%change%'`.

This script is called when session changes status - i.e. when pre-form is filled in by customer.

Input values

* `chatSession.id` - session id
* `chatSession.topicId` - topic the session belongs to
* `chatSession.status` - new status
* `chatSession.userId` - SuperOffice user handling the session
* `chatSession.customerId`
* `chatSession.botActive` - always going to be true
* `chatSession.customerName` - if filled in by pre-form
* `chatSession.customerEmail` - if filled in by pre-form
* `chatSession.companyName` - if filled in by pre-form
* `chatSession.customerPhone` - if filled in by pre-form

Variables `status.old` and `status.new` contain old and new values for chat session status.

## Chat session status values

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

## Bot Message Receive

The script name must match the pattern `'%bot%message%receive%'`.

Input values:

* `chatSession.topicId`
* `chatSession.status` - pre-chat form, in-queue, user message, etc
* `chatSession.userId` - the SuperOffice user handling the session, not set for bots
* `chatSession.botActive` - 1 for bots
* `chatSession.customerName` - from pre-form
* `chatSession.customerEmail` - from pre-form
* `chatSession.companyName` - from pre-form
* `chatSession.customerPhone` - from pre-form
* `chatSession.customerId`
* `chatSession.contactId`
* `chatSession.projectId`
* `chatSession.saleId`
* `chatSession.ticketId`
* `chatMessage.sessionId`
* `chatMessage.id`
* `chatMessage.message` - what the customer typed
* `chatMessage.type` - 2 = from the customer, or 3 = special
* `chatMessage.specialType` - if type = 3
* `chatMessage.specialParam` - if type = 3 - json containing options
* `chatMessage.author` - name shown in chat
* `chatTopic.id`
* `chatTopic.botName`

## Bot post message

`addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams, DateTime whenPosted)`

Posting a message will set the chat session status to 6 (user last) since the bot was the last to speak.

## Reset Chat

`resetChat(Integer sessionId)`

This starts the session over (session status starts at beginning again).

## Change status

`setChatStatus(sessionId, Integer newStatus)`

This changes the session status. This may trigger the session changed event.

## Chat Message types

* ToCustomer = 1,
* ToUser = 2,
* Special = 3

## Chat Message Special types

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
