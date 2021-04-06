---
uid: crmscript_ref_NSProjectAgent_ValidateProjectEntity
title: StringDictionary ValidateProjectEntity(ProjectEntity projectEntity)
intellisense: NSProjectAgent.ValidateProjectEntity
keywords: NSProjectAgent, ValidateProjectEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **projectEntity** Entity to be checked for errors.

**Returns:** Error messages tagged by field.

```crmscript
NSProjectAgent agent;
ProjectEntity projectEntity;
StringDictionary res = agent.ValidateProjectEntity(projectEntity);
```

