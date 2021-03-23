---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ChatBeforeSaveNewMessage (402)

## Input values

* `chatSession.topicId` = the topic this chat session belongs to
* `chatSession.userId` = ejUser ID
* `chatSession.customerId` = person ID
* `chatSession.customerName` = person name
* `chatSession.customerEmail` = person email
* `chatSession.companyName` = company name
* `chatSession.customerPhone` = person phone
* `chatMessage.sessionId` = session
* `chatMessage.message` = message text
* `chatMessage.type` = type of message
* `chatMessage.specialType` = Special type of message
* `chatMessage.specialParam` = depends on type
* `chatMessage.author` = author name

## Output values

* `chatMessage.message`
* `chatMessage.specialType` = Special type of message
* `chatMessage.specialParam` = depends on type
* `chatMessage.author` = author name

[!include[ALT](./includes/enum-type.md)]

[!include[ALT](./includes/enum-specialtype.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("chatSession.userId");
String param2 = getVariable("chatMessage.id");
String param3 = getVariable("chatMessage.message");
print("Params: " + param1 + " " + param2);
```
