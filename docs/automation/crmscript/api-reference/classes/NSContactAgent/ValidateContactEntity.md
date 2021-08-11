---
uid: crmscript_ref_NSContactAgent_ValidateContactEntity
title: StringDictionary ValidateContactEntity(NSContactEntity contactEntity)
intellisense: NSContactAgent.ValidateContactEntity
keywords: NSContactAgent, ValidateContactEntity
so.topic: reference
---

# StringDictionary ValidateContactEntity(NSContactEntity contactEntity)

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **contactEntity** Entity to be checked for errors.

**Returns:** StringDictionary

```crmscript
NSContactAgent agent;
NSContactEntity contactEntity;
StringDictionary res = agent.ValidateContactEntity(contactEntity);
```

