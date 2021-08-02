---
uid: crmscript_ref_NSListAgent_CreateDefaultDocumentTemplateEntity
title: NSDocumentTemplateEntity CreateDefaultDocumentTemplateEntity()
intellisense: NSListAgent.CreateDefaultDocumentTemplateEntity
keywords: NSListAgent, CreateDefaultDocumentTemplateEntity
so.topic: reference
---
	  
Set default values into a new NSDocumentTemplateEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSDocumentTemplateEntity

```crmscript
NSListAgent agent;
NSDocumentTemplateEntity thing = agent.CreateDefaultDocumentTemplateEntity();
thing = agent.SaveDocumentTemplateEntity(thing);
```

