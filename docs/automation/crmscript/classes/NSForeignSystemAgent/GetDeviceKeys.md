---
uid: crmscript_ref_NSForeignSystemAgent_GetDeviceKeys
title: ForeignKeyArray GetDeviceKeys(String applicationName, String deviceName)
intellisense: NSForeignSystemAgent.GetDeviceKeys
keywords: NSForeignSystemAgent, GetDeviceKeys
so.topic: reference
---

Returns all ForeignKeys that belong to a device.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.

**Returns:** Array of all ForeignKeys in the ForeignDevice.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
ForeignKeyArray res = agent.GetDeviceKeys(applicationName, deviceName);
```

