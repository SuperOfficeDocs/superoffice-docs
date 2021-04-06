---
uid: crmscript_ref_NSContactAgent_ValidateContactEntity
title: StringDictionary ValidateContactEntity(ContactEntity contactEntity)
intellisense: NSContactAgent.ValidateContactEntity
keywords: NSContactAgent, ValidateContactEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **contactEntity** Entity to be checked for errors.

**Returns:** Error messages tagged by field.

```crmscript
NSContactAgent agent;
ContactEntity contactEntity;
StringDictionary res = agent.ValidateContactEntity(contactEntity);
```

