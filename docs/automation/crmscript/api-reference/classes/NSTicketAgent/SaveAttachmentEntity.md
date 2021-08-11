---
uid: crmscript_ref_NSTicketAgent_SaveAttachmentEntity
title: NSAttachmentEntity SaveAttachmentEntity(NSAttachmentEntity attachmentEntity);
intellisense: NSTicketAgent.SaveAttachmentEntity
keywords: NSTicketAgent, SaveAttachmentEntity
so.topic: reference
---

# NSAttachmentEntity SaveAttachmentEntity(NSAttachmentEntity attachmentEntity);
	  
Updates the existing NSAttachmentEntity or creates a new NSAttachmentEntity if the id parameter is 0
	  
**Parameters**:
 - **attachmentEntity** The NSAttachmentEntity to save.

**Returns:** NSAttachmentEntity

```crmscript
NSTicketAgent agent;
NSAttachmentEntity thing = agent.CreateDefaultAttachmentEntity();
thing = agent.SaveAttachmentEntity(thing);
```

