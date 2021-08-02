---
uid: crmscript_ref_NSForeignSystemAgent_GetDeviceKeys
title: NSForeignKey[] GetDeviceKeys(String applicationName, String deviceName)
intellisense: NSForeignSystemAgent.GetDeviceKeys
keywords: NSForeignSystemAgent, GetDeviceKeys
so.topic: reference
---

Returns all ForeignKeys that belong to a device.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.

**Returns:** NSForeignKey[]

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
NSForeignKey[] res = agent.GetDeviceKeys(applicationName, deviceName);
```

