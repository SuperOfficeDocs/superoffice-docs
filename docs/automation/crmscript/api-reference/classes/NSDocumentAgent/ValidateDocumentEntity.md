---
uid: crmscript_ref_NSDocumentAgent_ValidateDocumentEntity
title: StringDictionary ValidateDocumentEntity(NSDocumentEntity documentEntity)
intellisense: NSDocumentAgent.ValidateDocumentEntity
keywords: NSDocumentAgent, ValidateDocumentEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **documentEntity** Entity to be checked for errors.

**Returns:** StringDictionary

```crmscript
NSDocumentAgent agent;
NSDocumentEntity documentEntity;
StringDictionary res = agent.ValidateDocumentEntity(documentEntity);
```

