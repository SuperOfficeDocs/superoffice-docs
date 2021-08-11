---
uid: crmscript_ref_NSTemplateVariablesParameters_SetDocumentEntity
title: SetDocumentEntity(NSDocumentEntity documentEntity)
intellisense: NSTemplateVariablesParameters.SetDocumentEntity
keywords: NSTemplateVariablesParameters, GetDocumentEntity
so.topic: reference
---

# SetDocumentEntity(NSDocumentEntity documentEntity)

Custom document entity to use for data retrieval. Useful for unsaved data.  NSDocumentEntity.DocumentId need to match the DocumentId specified in separate property.

**Parameter:** 
 - **documentEntity** NSDocumentEntity

```crmscript
NSTemplateVariablesParameters thing;
NSDocumentEntity documentEntity;
thing.SetDocumentEntity(documentEntity);
```

