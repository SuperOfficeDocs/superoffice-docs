---
uid: chatbot_overview
title: Chatbot overview
author: christianm
so.date: 03.08.2021
keywords: chatbot, ai
so.topic: concept
---

# Chatbot overview

## Chatbot needs AI License

Chatbot functionality in SuperOffice requires the AI license. This enables the **Chatbot** tab in chat administration.

![Chat channel admin: chatbot tab][img1]

## CRMScripts

Chatbots are folders that contain one or more CRMScripts with names that fit a pattern:

* `...bot register...` signals the presence of a chatbot in the folder.
* `...bot session create...` is called when a new chat session starts.
* `...bot session change...` is called when the chat session changes state.
* `...bot message receive...` is called when a new message is received.

The names of the scripts must follow this pattern, but they allow any prefix or suffix you want. `echobot register`, `my bot registered`, and `BotRegister` are all acceptable names for the registration script.

The CRMScripts are not called after the chatbot hands the session off to the queue for human processing. The `bot message receive` script is only called for incoming messages.

This removes the need for a bunch of book-keeping logic, simplifying the bot scripts.

![Chatbot scripts in a folder][img2]

The name of the folder is shown in the chatbot picker.

The chatbot scripts are called when events happen:

![Chatbot scripts sequence][img3]

When a session starts on a channel with a chatbot:

1. First the `bot session create` script is called.
2. Then the `bot session change` script may be called if there is a pre-chat form or faq suggestion.
3. Then the `bot message receive` script is called once for each message received from the customer.
4. Then the `bot session change` script is called when the session state changes.
5. Then the `bot message receive` script is called once for each message received from the customer.
6. Repeat until completed or handed off to queue for processing.

A script can hand off a chat session to a human by calling `resetChat(sessionId)`. This will tag the session with `botIsActive` = false so that the bot scripts are no longer called.

A script can end a session by setting it to closed: `setChatStatus(sessionId, 7);` (7 = closed).

## Alternatives

Chatbot requires an AI license, which is only available online. On-site customers need to look at alternative approaches.

### CrmScripts Triggers

Without the AI license you can still make chatbots, it is just a bit harder.

There are corresponding triggers that you can create scripts for:

* Chat Session Created
* Chat Session Changed
* Chat Message Received/Sent

Unlike the chatbot scripts, these triggers apply to all chat channels and all chat messages, so you need to do more filtering to make the chatbot work only on specific channels.

### Webhooks

There are webhook events that are fired that correspond to the CRMscript triggers.

These events are fired when chat sessions and messages change:

* `chatsession.created` - new session starts
* `chatsession.changed` - session has changed state
* `chatsession.message` - new message added to chat session

You would need to use the REST API to read the latest messages in the session and figure out what to do.

```html
GET /api/v1/ChatSession/{chatSessionId}/Messages
```

Like the triggers, the webhooks apply to all chat channels and messages, not just the ones with a bot configured.

You would use the REST API to post messages to a chat session.

```html
POST /api/v1/ChatSession/{chatSessionId}/Messages
```

## Examples

A full set of chatbot examples can be found on [GitHub SuperOffice/devnet-crmscript-chatbot][1]

* **Echo bot:** just mirrors the user's input back. Overrides pre-chat form.
* **Echo bot 2:** just mirrors the user's input back, but shows pre-chat form first.
* **Dad joke bot:** answers with a new joke from a web service.
* **Botkit bot:** talks to a simple bot service implemented using `botkit.ai`.
* **Azure bot:** uses the Azure bot platform to analyze messages and respond with intents.
* **Google Dialogflow bot:** uses Google's bot platform to analyze messages and respond with intents.

<!-- Referenced links -->
[1]: https://github.com/SuperOffice/devnet-crmscript-chatbot

<!-- Referenced links -->
[img1]: media/chatbot-channel-admin.png
[img2]: media/chatbot-scripts-folder.png
[img3]: media/chatbot-scripts-sequence.png
