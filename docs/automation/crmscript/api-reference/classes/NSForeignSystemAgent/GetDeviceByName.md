---
uid: crmscript_ref_NSForeignSystemAgent_GetDeviceByName
title: NSForeignDevice GetDeviceByName(String applicationName, String deviceName)
intellisense: NSForeignSystemAgent.GetDeviceByName
keywords: NSForeignSystemAgent, GetDeviceByName
so.topic: reference
---

Gets a NSForeignDevice with deviceName that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.

**Returns:** NSForeignDevice

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
NSForeignDevice res = agent.GetDeviceByName(applicationName, deviceName);
```

