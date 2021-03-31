---
title: crmscript_ref_NSTicketAgent_SaveTicketEntity
description: NSTicketEntity SaveTicketEntity(NSTicketEntity ticketEntity);
intellisense: NSTicketAgent.SaveTicketEntity
keywords: NSTicketAgent,SaveTicketEntity
so.topic: reference
---
	  
Updates the existing NSTicketEntity or creates a new NSTicketEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketEntity** The NSTicketEntity to save.

**Returns:** New or updated NSTicketEntity

```crmscript
NSTicket  agent;
NSTicketEntity thing = agent.CreateDefaultTicketEntity();
thing = agent.SaveTicketEntity(thing);
```

