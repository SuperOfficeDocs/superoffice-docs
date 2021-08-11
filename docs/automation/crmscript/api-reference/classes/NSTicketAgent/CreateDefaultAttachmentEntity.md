---
uid: crmscript_ref_NSTicketAgent_CreateDefaultAttachmentEntity
title: NSAttachmentEntity CreateDefaultAttachmentEntity()
intellisense: NSTicketAgent.CreateDefaultAttachmentEntity
keywords: NSTicketAgent, CreateDefaultAttachmentEntity
so.topic: reference
---

# NSAttachmentEntity CreateDefaultAttachmentEntity()
	  
Set default values into a new NSAttachmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSAttachmentEntity

```crmscript
NSTicketAgent agent;
NSAttachmentEntity thing = agent.CreateDefaultAttachmentEntity();
thing = agent.SaveAttachmentEntity(thing);
```

