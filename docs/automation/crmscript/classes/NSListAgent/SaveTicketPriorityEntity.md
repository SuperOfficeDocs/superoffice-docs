---
title: crmscript_ref_NSListAgent_SaveTicketPriorityEntity
description: NSTicketPriorityEntity SaveTicketPriorityEntity(NSTicketPriorityEntity ticketPriorityEntity);
intellisense: NSListAgent.SaveTicketPriorityEntity
keywords: NSListAgent,SaveTicketPriorityEntity
so.topic: reference
---
	  
Updates the existing NSTicketPriorityEntity or creates a new NSTicketPriorityEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketPriorityEntity** The NSTicketPriorityEntity to save.

**Returns:** New or updated NSTicketPriorityEntity

```crmscript
NSList  agent;
NSTicketPriorityEntity thing = agent.CreateDefaultTicketPriorityEntity();
thing = agent.SaveTicketPriorityEntity(thing);
```

