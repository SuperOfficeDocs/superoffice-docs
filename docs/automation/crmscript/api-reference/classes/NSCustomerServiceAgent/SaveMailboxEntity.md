---
uid: crmscript_ref_NSCustomerServiceAgent_SaveMailboxEntity
title: NSMailboxEntity SaveMailboxEntity(NSMailboxEntity mailboxEntity);
intellisense: NSCustomerServiceAgent.SaveMailboxEntity
keywords: NSCustomerServiceAgent, SaveMailboxEntity
so.topic: reference
---
	  
Updates the existing NSMailboxEntity or creates a new NSMailboxEntity if the id parameter is 0
	  
**Parameters**:
 - **mailboxEntity** The NSMailboxEntity to save.

**Returns:** NSMailboxEntity

```crmscript
NSCustomerService  agent;
NSMailboxEntity thing = agent.CreateDefaultMailboxEntity();
thing = agent.SaveMailboxEntity(thing);
```

