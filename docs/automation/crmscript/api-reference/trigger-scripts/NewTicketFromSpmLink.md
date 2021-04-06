---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromSpmLink (104)

Called when a mailing link was clicked and mailing specifies link tracking.

## Input values

* `custId` = customer person ID
* `personId` =  customer person ID
* `linkId` = link ID
* `shipmentId` = mailing ID
* `linkUrl` = url
* `linkHits` = number of hits
* `ticketTitle` = ticket title
* `ticketCategory` = ticket category ID
* `ticketPriority` = ticket priority ID
* `ticketOwnedBy` = owner of ticket
* `firstHit` = first click (0/1)

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
