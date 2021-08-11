---
uid: crmscript_ref_NSTicketAgent_SetTicketReadByOwner
title: NSTicketEntity SetTicketReadByOwner(Integer ticketEntityId, Integer readStatus, Bool checkEscalating)
intellisense: NSTicketAgent.SetTicketReadByOwner
keywords: NSTicketAgent, SetTicketReadByOwner
so.topic: reference
---

# NSTicketEntity SetTicketReadByOwner(Integer ticketEntityId, Integer readStatus, Bool checkEscalating)

Set the ReadByOwner status for a ticket. It will only have an effect if the calling user is the same as the owner of the ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to set
 - **readStatus** The read status to set. See the enum for explanation of the different colors. Setting Unknown does nothing
     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 
 - **checkEscalating** If true, then the escalation system will be called and executed when setting the ReadByOwner

**Returns:** NSTicketEntity

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
Integer readStatus;
Bool checkEscalating;
NSTicketEntity res = agent.SetTicketReadByOwner(ticketEntityId, readStatus, checkEscalating);
```

