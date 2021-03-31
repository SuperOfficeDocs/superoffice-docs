---
title: crmscript_ref_NSTicketAgent_CreateDefaultAttachmentEntity
description: NSAttachmentEntity CreateDefaultAttachmentEntity()
intellisense: NSTicketAgent.CreateDefaultAttachmentEntity
keywords: NSTicketAgent,CreateDefaultAttachmentEntity
so.topic: reference
---
	  
Set default values into a new NSAttachmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSAttachmentEntity with default values.

```crmscript
NSTicketAgent agent;
NSAttachmentEntity thing = agent.CreateDefaultAttachmentEntity();
thing = agent.SaveAttachmentEntity(thing);
```

