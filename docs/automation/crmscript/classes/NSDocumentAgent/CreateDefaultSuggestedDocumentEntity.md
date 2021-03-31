---
title: crmscript_ref_NSDocumentAgent_CreateDefaultSuggestedDocumentEntity
description: NSSuggestedDocumentEntity CreateDefaultSuggestedDocumentEntity()
intellisense: NSDocumentAgent.CreateDefaultSuggestedDocumentEntity
keywords: NSDocumentAgent,CreateDefaultSuggestedDocumentEntity
so.topic: reference
---
	  
Set default values into a new NSSuggestedDocumentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSuggestedDocumentEntity with default values.

```crmscript
NSDocumentAgent agent;
NSSuggestedDocumentEntity thing = agent.CreateDefaultSuggestedDocumentEntity();
thing = agent.SaveSuggestedDocumentEntity(thing);
```

