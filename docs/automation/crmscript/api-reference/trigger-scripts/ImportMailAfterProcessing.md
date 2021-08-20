---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ImportMailAfterProcessing (304)

## Input values
|Variable|Description|
|---|---|
| `messageId` | message ID (int)|
| `ticketId` | request ID|
| `customerId` | The ID of the primary person connected to this ticket|
| `customerEmail` |  Email address of the primary person connected to this ticket|
| `mailBackup` | Raw version of the email|
| `filterId` | filter ID|
| `to` | to header value|
| `from` | from header value|
| `isNewCustomer` | set to 1 if this email created a new customer/person (0/1)|

In addition, any variables set by the email filter are also available with the name specified in the email filter.

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
