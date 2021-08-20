---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 06.08.2021
keywords:
---

# TicketMessageSentimentCalculated (153)

Runs when a new sentiment is calculated.

## Input values
|Variable|Description|
|---|---|
| `entryId` | request ID|
| `ticketId` | request ID|
| `personId` | customer (person) ID|
| `language` | Two letter language code|
| `sentiment` | |
| `sentimentConfidence` | |
| `messageId` | message ID|
| `messageIsExternal` | Bool |
| `messageIsFirst` | Bool|
| `ticketTitle` | title for request|
| `ticketPriorityId` | priority ID|
| `ticketPriorityName` | priority name|
| `ticketCategoryId` | category ID|
| `ticketCategoryName` | category name|
| `ticketStatusId` | status ID|
| `ticketStatusName` | status name|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
