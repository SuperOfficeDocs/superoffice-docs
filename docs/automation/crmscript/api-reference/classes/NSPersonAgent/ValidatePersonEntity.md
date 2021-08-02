---
uid: crmscript_ref_NSPersonAgent_ValidatePersonEntity
title: StringDictionary ValidatePersonEntity(NSPersonEntity personEntity)
intellisense: NSPersonAgent.ValidatePersonEntity
keywords: NSPersonAgent, ValidatePersonEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **personEntity** Entity to be checked for errors.

**Returns:** StringDictionary

```crmscript
NSPersonAgent agent;
NSPersonEntity personEntity;
StringDictionary res = agent.ValidatePersonEntity(personEntity);
```

