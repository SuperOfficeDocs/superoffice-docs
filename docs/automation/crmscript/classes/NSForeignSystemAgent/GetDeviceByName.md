---
title: crmscript_ref_NSForeignSystemAgent_GetDeviceByName
description: ForeignDevice GetDeviceByName(String applicationName, String deviceName)
intellisense: NSForeignSystemAgent.GetDeviceByName
keywords: NSForeignSystemAgent,GetDeviceByName
so.topic: reference
---

Gets a ForeignDevice with deviceName that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.

**Returns:** The ForeignDevice.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
ForeignDevice res = agent.GetDeviceByName(applicationName, deviceName);
```

