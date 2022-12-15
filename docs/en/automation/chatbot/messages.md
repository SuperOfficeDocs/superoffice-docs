---
uid: chatbot_messages
title: Chatbot messages
author: christianm
so.date: 03.08.2021
keywords: chatbot, ai
so.topic: concept
---

# Chatbot messages

## Bot Message Received

This script is called when a user sends a new message to the bot - not called when the bot posts messages. Called after the generic **ChatBeforeSaveNewMessage** and **ChatAfterSaveNewMessage** triggers have run.

The bot can respond using `addChatMessage(sessionId, message, type, author, specialType, specialParams, whenPosted)` to add more messages to the chat.

Use type = 1 to indicate that the message is sent from bot to customer. You can use the `whenPosted` parameter to space out the bot replies to make them seem less robotic.

Some of the input values:

* `chatSession.topicId`
* `chatSession.status` - pre-chat form, in-queue, user message, etc
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

Response messages can be just text or can include special response types, like options or links.

In addition to the bot script, these things also happen:

* All CRMScript triggers defined for the **Chat Message Received** event are run.
* Webhooks for **chatSession.message** are dispatched.

Note that the triggers and webhooks are fired for both incoming and outgoing messages, while the bot scripts are only fired for incoming messages.

### Example

```crmscript
#setLanguageLevel 3;

EventData ed = getEventData();
String botName = ed.getInputValue("chatTopic.botName");
Integer sessionId = ed.getInputValue("chatMessage.sessionId").toInteger();
String message = ed.getInputValue("chatMessage.message");
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

if( human ) resetChat(sessionId);
if( stop ) setChatStatus(sessionId, 7); // 7 = closed
```
