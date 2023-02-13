---
uid: chatbot_registration
title: Chatbot registration
author: christianm
so.date: 03.08.2021
keywords: chatbot, ai
so.topic: concept
---

# Chatbot registration

![Chat channel admin: chatbot tab][img1]

You pick a folder containing a CRMScript named `echobot register`.

## Bot Register

This script is called when a bot is configured or saved in channel admin. Not called during the chat with a customer.

This script identifies the script folder as a chatbot. It must exist for a script folder to be recognized as a chatbot.

First, any existing **bot register** script that is registered on the channel is called with input values:

* `action` = "unregister"
* `topicid` = the ID of the topic the bot is active on

This is to allow the old bot to clean up its scripts and triggers that it may have installed.

The script is also called during channel delete. The new bot's register script is called with input values:

* `action` = "register"
* `topicid` = the ID of the topic the bot is being saved on

The register script can do whatever it needs to - create new triggers, for example, set up state, fetch access/refresh tokens. It doesn't have to do anything.

SuperOffice will scan the folder for the names of other chatbot scripts and store the script IDs in the **ChatTopic** record:

* `%bot%Session%Created`
* `%bot%Session%Status%Changed`
* `%bot%Message%Received`

This means we don't have to scan the folder on every new message, but we won't pick up changes to the folder until the chatbot registration is changed. If you register a bot and then add a new script `bot message received` to the folder, it won't call the new script until you deactivate the chatbot and re-activate it. This will trigger a new scan of the folder, and pick up the new ID.

### Example

```crmscript
#setLanguageLevel 3;
String action = getEventData().getInputValue("action");
log("Echobot registered called: " + action);
```

<!-- Referenced images -->
[img1]: media/chatbot-channel-admin.png
