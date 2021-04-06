---
uid: crmscript_ref_NSDocumentAgent_CreateDefaultDocumentEntity
title: NSDocumentEntity CreateDefaultDocumentEntity()
intellisense: NSDocumentAgent.CreateDefaultDocumentEntity
keywords: NSDocumentAgent, CreateDefaultDocumentEntity
so.topic: reference
---
	  
Set default values into a new NSDocumentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSDocumentEntity with default values.

```crmscript
NSDocumentAgent agent;
NSDocumentEntity thing = agent.CreateDefaultDocumentEntity();
thing = agent.SaveDocumentEntity(thing);
```

