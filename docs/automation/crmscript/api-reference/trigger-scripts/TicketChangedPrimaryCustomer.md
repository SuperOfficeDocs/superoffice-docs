---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketChangedPrimaryCustomer (143)

Runs when a ticket is saved and the customer ID changes.

## Input values

* `entryId` = request ID
* `ticketId` = request ID
* `personId` = customer (person) ID
* `contactId` = company (contact) ID
* `cust_id.old` = old value
* `cust_id.new` = new value

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("personId");
```
