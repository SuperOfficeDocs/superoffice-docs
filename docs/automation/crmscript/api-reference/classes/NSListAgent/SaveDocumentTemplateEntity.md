---
uid: crmscript_ref_NSListAgent_SaveDocumentTemplateEntity
title: NSDocumentTemplateEntity SaveDocumentTemplateEntity(NSDocumentTemplateEntity documentTemplateEntity);
intellisense: NSListAgent.SaveDocumentTemplateEntity
keywords: NSListAgent, SaveDocumentTemplateEntity
so.topic: reference
---

# NSDocumentTemplateEntity SaveDocumentTemplateEntity(NSDocumentTemplateEntity documentTemplateEntity);
	  
Updates the existing NSDocumentTemplateEntity or creates a new NSDocumentTemplateEntity if the id parameter is 0
	  
**Parameters**:
 - **documentTemplateEntity** The NSDocumentTemplateEntity to save.

**Returns:** NSDocumentTemplateEntity

```crmscript
NSList  agent;
NSDocumentTemplateEntity thing = agent.CreateDefaultDocumentTemplateEntity();
thing = agent.SaveDocumentTemplateEntity(thing);
```

