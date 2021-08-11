---
uid: crmscript_ref_NSForeignSystemAgent_GetApplicationDevices
title: NSForeignDevice[] GetApplicationDevices(String applicationName)
intellisense: NSForeignSystemAgent.GetApplicationDevices
keywords: NSForeignSystemAgent, GetApplicationDevices
so.topic: reference
---

# NSForeignDevice[] GetApplicationDevices(String applicationName)

Gets all devices that belong to a foreign application.

**Parameters:**
 - **applicationName** The foreign application name

**Returns:** NSForeignDevice[]

```crmscript
NSForeignSystemAgent agent;
String applicationName;
NSForeignDevice[] res = agent.GetApplicationDevices(applicationName);
```

