---
uid: crmscript_ref_NSTicketAgent_SaveTicketMessageEntity
title: NSTicketMessageEntity SaveTicketMessageEntity(NSTicketMessageEntity ticketMessageEntity);
intellisense: NSTicketAgent.SaveTicketMessageEntity
keywords: NSTicketAgent, SaveTicketMessageEntity
so.topic: reference
---
	  
Updates the existing NSTicketMessageEntity or creates a new NSTicketMessageEntity if the id parameter is 0
	  
**Parameters**:
 - **ticketMessageEntity** The NSTicketMessageEntity to save.

**Returns:** NSTicketMessageEntity

```crmscript
NSTicketAgent agent;
NSTicketMessageEntity thing = agent.CreateDefaultTicketMessageEntity();
thing = agent.SaveTicketMessageEntity(thing);
```

