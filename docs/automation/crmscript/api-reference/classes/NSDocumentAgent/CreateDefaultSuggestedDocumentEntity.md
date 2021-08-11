---
uid: crmscript_ref_NSDocumentAgent_CreateDefaultSuggestedDocumentEntity
title: NSSuggestedDocumentEntity CreateDefaultSuggestedDocumentEntity()
intellisense: NSDocumentAgent.CreateDefaultSuggestedDocumentEntity
keywords: NSDocumentAgent, CreateDefaultSuggestedDocumentEntity
so.topic: reference
---

# NSSuggestedDocumentEntity CreateDefaultSuggestedDocumentEntity()
	  
Set default values into a new NSSuggestedDocumentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSuggestedDocumentEntity

```crmscript
NSDocumentAgent agent;
NSSuggestedDocumentEntity thing = agent.CreateDefaultSuggestedDocumentEntity();
thing = agent.SaveSuggestedDocumentEntity(thing);
```

