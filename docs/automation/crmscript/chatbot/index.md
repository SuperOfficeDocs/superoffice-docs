---
title: chatbot_overview
description: Chatbot overview
author: christianm
so.date: 2021-03-08
keywords: chatbot, ai
so.topic: concept
---

## Chatbot needs AI License

Chatbot functionality in SuperOffice requires the AI license. This enables the **Chatbot** tab in chat administration.

![Chat channel admin: chatbot tab](../media/chatbot-channel-admin.png)

## CrmScripts

Chatbots are folders that contain one or more CrmScripts with names that fit a pattern.

* `...bot register...` signals the presence of a chatbot in the folder.
* `...bot session create...` is called when a new chat session starts.
* `...bot session change...` is called when the chat session changes state.
* `...bot message receive...` is called when a new message is received.

The names of the scripts 

The CrmScripts are not called after  the chatbot hands the session off to the queue for human processing.

![Chatbot scripts in a folder](../media/chatbot-scripts-folder.png)

The name of the folder is shown in the chatbot picker.

The chatbot scripts are called when events happen:

![Chatbot scripts sequence](../media/chatbot-scripts-sequence.png)

When a session starts on a channel with a chatbot:

* First the `bot session create` script is called.
* Then the `bot session change` script is called.
* Then the `bot message receive` script is called once for each message received.
* Then the `bot session change` script is called.
* Then the `bot message receive` script is called once for each message received.
* Repeat until completed