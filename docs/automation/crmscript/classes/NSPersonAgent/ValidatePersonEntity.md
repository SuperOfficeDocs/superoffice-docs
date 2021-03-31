---
title: crmscript_ref_NSPersonAgent_ValidatePersonEntity
description: StringDictionary ValidatePersonEntity(PersonEntity personEntity)
intellisense: NSPersonAgent.ValidatePersonEntity
keywords: NSPersonAgent,ValidatePersonEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **personEntity** Entity to be checked for errors.

**Returns:** Error messages tagged by field.

```crmscript
NSPersonAgent agent;
PersonEntity personEntity;
StringDictionary res = agent.ValidatePersonEntity(personEntity);
```

