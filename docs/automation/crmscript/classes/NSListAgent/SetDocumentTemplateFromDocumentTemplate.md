---
title: crmscript_ref_NSListAgent_SetDocumentTemplateFromDocumentTemplate
description: DocumentTemplateEntity SetDocumentTemplateFromDocumentTemplate(Integer sourceDocumentTemplateId, DocumentTemplateEntity documentTemplateEntity)
intellisense: NSListAgent.SetDocumentTemplateFromDocumentTemplate
keywords: NSListAgent,SetDocumentTemplateFromDocumentTemplate
so.topic: reference
---

Create a new document template based on another template

**Parameters:**
 - **sourceDocumentTemplateId** The document template to copy contents from.
 - **documentTemplateEntity** The new document template entity

**Returns:** The new document template entity

```crmscript
NSListAgent agent;
Integer sourceDocumentTemplateId;
DocumentTemplateEntity documentTemplateEntity;
DocumentTemplateEntity res = agent.SetDocumentTemplateFromDocumentTemplate(sourceDocumentTemplateId, documentTemplateEntity);
```

