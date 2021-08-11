---
uid: crmscript_ref_NSForeignSystemAgent_GetForeignDevice
title: NSForeignDevice GetForeignDevice(Integer foreignDeviceId);
intellisense: NSForeignSystemAgent.GetForeignDevice
keywords: NSForeignSystemAgent, GetForeignDevice
so.topic: reference
---

# NSForeignDevice GetForeignDevice(Integer foreignDeviceId);

Gets a NSForeignDevice object.

**Parameters:**
 - **foreignDeviceId** The identifier of the NSForeignDevice object

**Returns:** NSForeignDevice

```crmscript
NSForeignSystemAgent agent;
NSForeignDevice thing = agent.GetForeignDevice(123);
```

