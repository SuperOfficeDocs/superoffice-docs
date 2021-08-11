---
uid: crmscript_ref_NSForeignSystemAgent_GetForeignAppEntity
title: NSForeignAppEntity GetForeignAppEntity(Integer foreignAppEntityId);
intellisense: NSForeignSystemAgent.GetForeignAppEntity
keywords: NSForeignSystemAgent, GetForeignAppEntity
so.topic: reference
---

# NSForeignAppEntity GetForeignAppEntity(Integer foreignAppEntityId);

Gets a NSForeignAppEntity object.

**Parameters:**
 - **foreignAppEntityId** The identifier of the NSForeignAppEntity object

**Returns:** NSForeignAppEntity

```crmscript
NSForeignSystemAgent agent;
NSForeignAppEntity thing = agent.GetForeignAppEntity(123);
```

