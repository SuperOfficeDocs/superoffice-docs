---
title: crmscript_ref_NSForeignSystemAgent_GetApplicationDevices
description: ForeignDeviceArray GetApplicationDevices(String applicationName)
intellisense: NSForeignSystemAgent.GetApplicationDevices
keywords: NSForeignSystemAgent,GetApplicationDevices
so.topic: reference
---

Gets all devices that belong to a foreign application.

**Parameters:**
 - **applicationName** The foreign application name

**Returns:** Array of ForeignDevices

```crmscript
NSForeignSystemAgent agent;
String applicationName;
ForeignDeviceArray res = agent.GetApplicationDevices(applicationName);
```

