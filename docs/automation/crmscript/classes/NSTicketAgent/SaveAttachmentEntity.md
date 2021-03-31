---
title: crmscript_ref_NSTicketAgent_SaveAttachmentEntity
description: NSAttachmentEntity SaveAttachmentEntity(NSAttachmentEntity attachmentEntity);
intellisense: NSTicketAgent.SaveAttachmentEntity
keywords: NSTicketAgent,SaveAttachmentEntity
so.topic: reference
---
	  
Updates the existing NSAttachmentEntity or creates a new NSAttachmentEntity if the id parameter is 0
	  
**Parameters**:
 - **attachmentEntity** The NSAttachmentEntity to save.

**Returns:** New or updated NSAttachmentEntity

```crmscript
NSTicket  agent;
NSAttachmentEntity thing = agent.CreateDefaultAttachmentEntity();
thing = agent.SaveAttachmentEntity(thing);
```

