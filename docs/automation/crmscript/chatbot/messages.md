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

The bot script can call a web service for help, or do its own text processing in the script.
The bot script should post a response message.

Response messages may be just text, or can include special response types, like options and links.

In addition to the bot script, these things also happen:

* All CrmScript triggers defined for the **Chat Message Received** event are run.
* Webhooks for **chatSession.message** are dispatched.

Note that the triggers and webhooks are fired for both incoming and outgoing messages, while the bot scripts are only fired for incoming messages.


### Example

```crmscript
#setLanguageLevel 3;

EventData ed = getEventData();
String botName = ed.getInputValue("chatTopic.botName");
Integer sessionId = ed.getInputValue("chatMessage.sessionId").toInteger();
String message   = ed.getInputValue("chatMessage.message");
Integer toCustomer = 1;
Bool human = false;
Bool stop = false;

if( message == "human" )
{
   message = "Transferring to human...";
   human = true;
}   
else if( message == "stop" || message == "quit" )
{
   message = "Bye bye - closing chat.";
   stop = true;
}
else message = "Echo " + message;

addChatMessage(sessionId, message, toCustomer, botName, 0, "" );

if( human )   resetChat(sessionId);
if( stop )   setChatStatus(sessionId, 7); // 7 = closed
```

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

