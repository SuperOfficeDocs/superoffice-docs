---
title: chatbot_sessions
description: Chatbot Session Scripts
author: christianm
so.date: 2021-03-08
keywords: chatbot, ai
so.topic: reference
---

## Chat Sessions

Sessions are created when a customer connects to the chat service.

![Chatbot session states](../media/chatbot-states.png)

Depending on how the channel is configured, the initial state may be "in queue" or "pre-chat-form".

When a bot is active, the bot script takes over, and the message is not shown in the queue. 
The bot prevents the session from going to the offline form state, since the bot is always present.

When the bot hands off the session to humans, the session may go to `offline` status because there are no humans available.

## Bot Session Created 

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

The bot can post messages at this point, to say welcome.

`addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams, DateTime whenPosted)`

Posting a message will set the chat session status to 6 (user last) since the bot was the last to speak.
This keeps the session off the queue.

If you do nothing, then the session go to the queue, waiting for a human - or to the pre-chat form (if configured).

In addition to the bot script, these things also happen:

* all CrmScript triggers defined for the **Chat Session Created** event are run.
* webhooks for **chatSession.created** are dispatched.

### Example

```crmscript
#setLanguageLevel 3;

EventData ed = getEventData();
String botName = ed.getInputValue("chatTopic.botName");
Integer sessionId = ed.getInputValue("chatSession.id").toInteger();
Integer toCustomer = 1;

String message = "Welcome human. Say 'human' to transfer. Say 'quit' to end session.";
addChatMessage(sessionId, message, toCustomer, botName, 0, "" );
```

## Bot Session Changed

This script is called when session changes status - i.e. when pre-form is filled in by customer.

Input values

* `chatSession.id` - session id
* `chatSession.topicId` - topic the session belongs to
* `chatSession.status` - new status
* `chatSession.userId`
* `chatSession.customerId`
* `chatSession.botActive` - always going to be true
* `chatSession.customerName` - if filled in by pre-form
* `chatSession.customerEmail`
* `chatSession.companyName` 
* `chatSession.customerPhone`

Variables `status.old` and `status.new` contain old and new values for chat session status.

The bot can add messages to sign off, or do other tasks.

In addition to the bot script, these things also happen:

* all CrmScript triggers defined for the **Chat Session Changed** event are run.
* webhooks for **chatSession.changed** are dispatched.


### Chat session status values

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

## Handing off session

Call `resetChat(sessionId)` for the bot to hand off the session to humans.
This will trigger either the in-queue state, or the offline-form, depending on the
availability of humans.

When the session has been handed off, the bot scripts are not called any more.
The session is marked with 'botActive' = false, which blocks further calls to the bot scripts.

The generic CrmScript triggers for chat will continue to fire, as well as the webhooks. 

## Ending a session

Call `setChatStatus(sessionId, 7)` to end the session.

```crmscript
   setChatStatus(sessionId, 7); // 7 = closed
```

