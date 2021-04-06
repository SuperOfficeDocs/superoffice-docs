---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ChatSessionChangedStatus (401)

Called when session changes status.
Equivalent to webhook 'chatsession.changed'

## Input values

* `chatSession.id` = the session ID
* `chatSession.status` = new status

[!include[ALT](./includes/status-values.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("chatSession.id");
```
