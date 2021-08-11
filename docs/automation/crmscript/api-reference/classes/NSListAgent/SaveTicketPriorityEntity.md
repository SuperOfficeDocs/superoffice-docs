---
uid: crmscript_ref_NSListAgent_SaveTicketPriorityEntity
title: NSTicketPriorityEntity SaveTicketPriorityEntity(NSTicketPriorityEntity ticketPriorityEntity);
intellisense: NSListAgent.SaveTicketPriorityEntity
keywords: NSListAgent, SaveTicketPriorityEntity
so.topic: reference
---

# NSTicketPriorityEntity SaveTicketPriorityEntity(NSTicketPriorityEntity ticketPriorityEntity);
	  
Updates the existing NSTicketPriorityEntity or creates a new NSTicketPriorityEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketPriorityEntity** The NSTicketPriorityEntity to save.

**Returns:** NSTicketPriorityEntity

```crmscript
NSList  agent;
NSTicketPriorityEntity thing = agent.CreateDefaultTicketPriorityEntity();
thing = agent.SaveTicketPriorityEntity(thing);
```

