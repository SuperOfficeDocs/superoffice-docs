---
uid: crmscript_global_addchatmessage
title: addChatMessage
description: CRMScript function used to add a message to a chat session
intellisense: Void.addChatMessage
langref: 1
keywords: addChatMessage(Integer,String,Integer,String,Integer,String), addChatMessage(Integer,String,Integer,String,Integer,String,DateTime)
so.topic: reference
---

# Integer addChatMessage()

Adds a message to a chat session. You can optionally pass a `DateTime` to set when the message will show up. This variant of `addChatMessage` is especially used for ChatBot-integrations.

## Functions

* Integer addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams)
* Integer addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams, DateTime whenPosted)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| sessionId | Integer | The ID of the chat session. |
| message | String | The text of the message you want to add in HTML format. A few tags, such as `<b>`, `<i>`, `<ul>` are allowed. Other tags and attributes will be removed. |
| type | Integer | 1 to indicate the message is to the customer. |
| author | String | The string used as the author of the message. Placed above the message bubble. |
| specialType | Integer | Mostly internally used. 0 = no special type; 16 =  the message is from a chatbot |
|  specialParams | String | Various params based on the `specialType`. Specifically, for specialType=16, you can add `showAt=<datetime>` to specify when the message should show up to create a delay before the bot message is shown. |
| whenPosted | DateTime | Optional. If not null, this is when the message will show up in the clients and also the sorting field for messages. |
