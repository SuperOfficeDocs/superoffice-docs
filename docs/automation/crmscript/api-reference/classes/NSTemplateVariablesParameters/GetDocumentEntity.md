---
uid: crmscript_ref_NSTemplateVariablesParameters_GetDocumentEntity
title: NSDocumentEntity GetDocumentEntity()
intellisense: NSTemplateVariablesParameters.GetDocumentEntity
keywords: NSTemplateVariablesParameters, GetDocumentEntity
so.topic: reference
---

# NSDocumentEntity GetDocumentEntity()

Custom document entity to use for data retrieval. Useful for unsaved data.  NSDocumentEntity.DocumentId need to match the DocumentId specified in separate property.

**Returns:** NSDocumentEntity

```crmscript
NSTemplateVariablesParameters thing;
NSDocumentEntity documentEntity  = thing.GetDocumentEntity();
```

