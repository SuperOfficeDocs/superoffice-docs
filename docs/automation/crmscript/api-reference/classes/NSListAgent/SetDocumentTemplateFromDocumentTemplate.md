---
uid: crmscript_ref_NSListAgent_SetDocumentTemplateFromDocumentTemplate
title: NSDocumentTemplateEntity SetDocumentTemplateFromDocumentTemplate(Integer sourceDocumentTemplateId, NSDocumentTemplateEntity documentTemplateEntity)
intellisense: NSListAgent.SetDocumentTemplateFromDocumentTemplate
keywords: NSListAgent, SetDocumentTemplateFromDocumentTemplate
so.topic: reference
---

# NSDocumentTemplateEntity SetDocumentTemplateFromDocumentTemplate(Integer sourceDocumentTemplateId, NSDocumentTemplateEntity documentTemplateEntity)

Create a new document template based on another template

**Parameters:**
 - **sourceDocumentTemplateId** The document template to copy contents from.
 - **documentTemplateEntity** The new document template entity

**Returns:** NSDocumentTemplateEntity

```crmscript
NSListAgent agent;
Integer sourceDocumentTemplateId;
NSDocumentTemplateEntity documentTemplateEntity;
NSDocumentTemplateEntity res = agent.SetDocumentTemplateFromDocumentTemplate(sourceDocumentTemplateId, documentTemplateEntity);
```

