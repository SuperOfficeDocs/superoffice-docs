---
uid: crmscript_ref_NSListAgent_SaveTicketCategoryEntity
title: NSTicketCategoryEntity SaveTicketCategoryEntity(NSTicketCategoryEntity ticketCategoryEntity);
intellisense: NSListAgent.SaveTicketCategoryEntity
keywords: NSListAgent, SaveTicketCategoryEntity
so.topic: reference
---
	  
Updates the existing NSTicketCategoryEntity or creates a new NSTicketCategoryEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketCategoryEntity** The NSTicketCategoryEntity to save.

**Returns:** New or updated NSTicketCategoryEntity

```crmscript
NSList  agent;
NSTicketCategoryEntity thing = agent.CreateDefaultTicketCategoryEntity();
thing = agent.SaveTicketCategoryEntity(thing);
```

