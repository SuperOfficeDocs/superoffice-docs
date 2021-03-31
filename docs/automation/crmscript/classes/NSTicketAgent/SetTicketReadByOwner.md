---
title: crmscript_ref_NSTicketAgent_SetTicketReadByOwner
description: TicketEntity SetTicketReadByOwner(Integer ticketEntityId, Integer readStatus, Bool checkEscalating)
intellisense: NSTicketAgent.SetTicketReadByOwner
keywords: NSTicketAgent,SetTicketReadByOwner
so.topic: reference
---

Set the ReadByOwner status for a ticket. It will only have an effect if the calling user is the same as the owner of the ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to set
 - **readStatus** The read status to set. See the enum for explanation of the different colors. Setting Unknown does nothing
     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 
 - **checkEscalating** If true, then the escalation system will be called and executed when setting the ReadByOwner

**Returns:** The ticket entity after setting the ReadByOwner

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
Integer readStatus;
Bool checkEscalating;
TicketEntity res = agent.SetTicketReadByOwner(ticketEntityId, readStatus, checkEscalating);
```

