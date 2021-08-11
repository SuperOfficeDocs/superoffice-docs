---
uid: crmscript_ref_NSForeignSystemAgent_GetAppByName
title: NSForeignAppEntity GetAppByName(String applicationName)
intellisense: NSForeignSystemAgent.GetAppByName
keywords: NSForeignSystemAgent, GetAppByName
so.topic: reference
---

# NSForeignAppEntity GetAppByName(String applicationName)

Gets the ForeignApp with the given name.

**Parameters:**
 - **applicationName** The name of the foreign application.

**Returns:** NSForeignAppEntity

```crmscript
NSForeignSystemAgent agent;
String applicationName;
NSForeignAppEntity res = agent.GetAppByName(applicationName);
```

