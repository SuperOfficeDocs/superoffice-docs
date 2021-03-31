---
uid: crmscript_ref_NSDocumentAgent_ValidateDocumentEntity
title: StringDictionary ValidateDocumentEntity(DocumentEntity documentEntity)
intellisense: NSDocumentAgent.ValidateDocumentEntity
keywords: NSDocumentAgent, ValidateDocumentEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **documentEntity** Entity to be checked for errors.

**Returns:** Error messages tagged by field.

```crmscript
NSDocumentAgent agent;
DocumentEntity documentEntity;
StringDictionary res = agent.ValidateDocumentEntity(documentEntity);
```

