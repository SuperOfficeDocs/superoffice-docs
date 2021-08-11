---
uid: crmscript_ref_NSListAgent_SaveTicketStatusEntity
title: NSTicketStatusEntity SaveTicketStatusEntity(NSTicketStatusEntity ticketStatusEntity);
intellisense: NSListAgent.SaveTicketStatusEntity
keywords: NSListAgent, SaveTicketStatusEntity
so.topic: reference
---

# NSTicketStatusEntity SaveTicketStatusEntity(NSTicketStatusEntity ticketStatusEntity);
	  
Updates the existing NSTicketStatusEntity or creates a new NSTicketStatusEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketStatusEntity** The NSTicketStatusEntity to save.

**Returns:** NSTicketStatusEntity

```crmscript
NSList  agent;
NSTicketStatusEntity thing = agent.CreateDefaultTicketStatusEntity();
thing = agent.SaveTicketStatusEntity(thing);
```

