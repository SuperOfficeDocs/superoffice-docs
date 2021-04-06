---
uid: chatbot_alternatives
title: Chatbot Alternatives
author: christian
so.date: 2021-03-29
keywords: chatbot, ai
so.topic: concept
---

# Alternatives

Chatbot requires the AI license, which is only available online. On-site customers need to look at alternative approaches.

## CrmScripts Triggers

Without the AI license you can still make chatbots, it is just a bit harder.

There are corresponding Chat Session Created, Chat Session Changed, Chat Message Received/Sent triggers that you can create scripts for.

Unlike the chatbot scripts, these triggers apply to all chat channels and all chat messages, so you need to do more filtering to make the chatbot work only on specific channels.

## Webhooks

There are webhook events that are fired that correspond to the CRMscript triggers. 

These events are fired when chat sessions and messages change:

* `chatsession.created` - new session starts
* `chatsession.changed` - session has changed state
* `chatsession.message` - new message added to chat session

You would need to use the REST API to read the latest messages in the session and figure out what to do. 

    GET /api/v1/ChatSession/{chatSessionId}/Messages

Like the triggers, the webhooks apply to all chat channels and messages, not just the ones with a bot configured.

You would use the REST API to post messages to a chat session.

    POST /api/v1/ChatSession/{chatSessionId}/Messages

