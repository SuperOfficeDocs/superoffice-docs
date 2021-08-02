---
uid: crmscript_ref_NSDocumentAgent_CreateDefaultDocumentPreview
title: NSDocumentPreview CreateDefaultDocumentPreview()
intellisense: NSDocumentAgent.CreateDefaultDocumentPreview
keywords: NSDocumentAgent, CreateDefaultDocumentPreview
so.topic: reference
---
	  
Set default values into a new NSDocumentPreview.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSDocumentPreview

```crmscript
NSDocumentAgent agent;
NSDocumentPreview thing = agent.CreateDefaultDocumentPreview();
thing = agent.SaveDocumentPreview(thing);
```

