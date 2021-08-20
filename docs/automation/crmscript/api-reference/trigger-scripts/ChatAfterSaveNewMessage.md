---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ChatAfterSaveNewMessage (403)

## Input values
|Variable|Description|
|---|---|
| `chatSession.topicId` | the topic this chat session belongs to|
| `chatSession.userId`| ejUser ID|
| `chatSession.customerId` | person ID|
| `chatSession.customerName` | person name|
| `chatSession.customerEmail` | person email|
| `chatSession.companyName` | company name|
| `chatSession.customerPhone` | person phone|
| `chatMessage.sessionId` | session|
| `chatMessage.id` | message ID|
| `chatMessage.message` | message text|
| `chatMessage.type` | type of message|
| `chatMessage.specialType` | Special type of message|
| `chatMessage.specialParam` | depends on type|
| `chatMessage.author` | author name|

## enum Type

* TypeToCustomer = 1
* TypeToUser = 2
* TypeSpecial = 3

## enum SpecialType

* SpecialTypeNone = 0
* SpecialTypeWelcome = 1
* SpecialTypeUrl = 2
* SpecialTypeBlock = 3
* SpecialTypeNewSession = 5
* SpecialTypeTransferedSession = 6
* SpecialTypeError = 7
* SpecialTypeSessionDeleted = 8
* SpecialTypeFaqSuccessQuestion = 9
* SpecialTypeClosedByUser = 10
* SpecialTypeClosedByCustomer = 11
* SpecialTypeClosedByIdle = 12
* SpecialTypeTransferRejected = 13
* SpecialTypeReopenedByCustomer = 14
* SpecialTypeClickedOption = 15
* SpecialTypeBotMessage = 16
* SpecialTypeOptions = 17

The message has a list of clickable options. Options are as JSON array in specialParam

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("chatSession.userId");
String param2 = ed.getInputValue("chatMessage.id");
String param3 = ed.getInputValue("chatMessage.message");
print("Params: " + param1 + " " + param2);
```
