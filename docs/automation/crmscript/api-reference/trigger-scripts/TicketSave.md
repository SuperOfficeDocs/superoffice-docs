---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketSave (109)

Called when a ticket is being saved.

## Input values
|Variable|Description|
|---|---|
|`ticketId` | ticket ID|
|`activeUser`|  ejUser ID|

## Sample code

**Example input values:**

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```

**Example parser variables:**

```crmscript
if(getParserVariable("ticket.new.category") != getParserVariable("ticket.old.value"))
    log("Category has changed");
```

In this event it is possible to get more information regarding changes done using Parser variables to compare old values against new values.

## Parser variables

| Variable  |Description   |
|---|---|
| `id` | ID|
|`title`|title|
|`createdAt` | creation datetime|
| `lastChanged` | last changed datetime|
| `readByOwner` | last read by owner datetime|
| `readByCustomer` | last read by customer datetime|
| `firstReadByUser` | first read by user datetime|
| `firstReadByOwner` | first read by owner datetime|
| `activate` | activate datetime|
| `closedAt` | closed at datetime|
| `deadline` | deadline datetime|
| `timeToClose` |  time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&apos;s timeframe|
| `realTimeToClose` |  same as timeToClose, but not calculated based on priority|
| `repliedAt` | replied at datetime|
| `timeToReply` |  time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&apos;s timeframe|
| `m_realTimeToReply` |  same as timeToReply, but not calculated based on priority|
| `createdBy` |  ID of user who created ticket|
| `author` |  string representing author of ticket|
| `ownedBy` |  ID of user who owns ticket|
| `category` |  ID of category|
| `slevel` |  Security level of ticket (internal=1, external=2)|
| `priority` |  ID of priority|
| `status` |  ID of status|
| `ticketStatus` |  ID of user-defined status|
| `customer` |  ID of customer|
| `alertLevel` |  alert level for ticket|
| `alertTimeout` |  datetime for when next escalation level should happen|
| `alertStop` |  Number of seconds left before next escalation level|
| `connectId` |  ID of master ticket|
| `filterId` |  ID of receiving mailbox|
| `displayFilter` |  name of receiving mailbox|
| `filterAddress` |  E-mail address of receiving mailbox|
| `readStatus` |  Owner has read ticket (0=Unknown status, 1=The ticket has been read by the owner, 2=The ticket has received new information since last read, 3=The ticket is unread by the owner)|
| `hasAttachment` |  Bool indicating if ticket has one or more attachments|
| `dbiAgentId` |  integration agent|
| `dbiKey` |  integration key|
| `dbiLastModified` |  datetime when entry was last changed in integration|
| `dbiLastSyncronized` |  datetime when integration was last executed|
