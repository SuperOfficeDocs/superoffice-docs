---
uid: crmscript_ref_NSConfigurationAgent_GetSystemEventEntity
title: NSSystemEventEntity GetSystemEventEntity(Integer systemEventEntityId);
intellisense: NSConfigurationAgent.GetSystemEventEntity
keywords: NSConfigurationAgent, GetSystemEventEntity
so.topic: reference
---

# NSSystemEventEntity GetSystemEventEntity(Integer systemEventEntityId);

Gets a NSSystemEventEntity object.

**Parameters:**
 - **systemEventEntityId** The identifier of the NSSystemEventEntity object

**Returns:** NSSystemEventEntity

```crmscript
NSConfigurationAgent agent;
NSSystemEventEntity thing = agent.GetSystemEventEntity(123);
```

