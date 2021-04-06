---
uid: crmscript_ref_NSDocumentAgent_SaveSuggestedDocumentEntity
title: NSSuggestedDocumentEntity SaveSuggestedDocumentEntity(NSSuggestedDocumentEntity suggestedDocumentEntity);
intellisense: NSDocumentAgent.SaveSuggestedDocumentEntity
keywords: NSDocumentAgent, SaveSuggestedDocumentEntity
so.topic: reference
---
	  
Updates the existing NSSuggestedDocumentEntity or creates a new NSSuggestedDocumentEntity if the id parameter is 0
	  
**Parameters**:
 - **suggestedDocumentEntity** The NSSuggestedDocumentEntity to save.

**Returns:** New or updated NSSuggestedDocumentEntity

```crmscript
NSDocument  agent;
NSSuggestedDocumentEntity thing = agent.CreateDefaultSuggestedDocumentEntity();
thing = agent.SaveSuggestedDocumentEntity(thing);
```

