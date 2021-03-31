---
title: crmscript_ref_NSForeignSystemAgent_GetAppByName
description: ForeignAppEntity GetAppByName(String applicationName)
intellisense: NSForeignSystemAgent.GetAppByName
keywords: NSForeignSystemAgent,GetAppByName
so.topic: reference
---

Gets the ForeignApp with the given name.

**Parameters:**
 - **applicationName** The name of the foreign application.

**Returns:** The ForeignApp that matches the name.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
ForeignAppEntity res = agent.GetAppByName(applicationName);
```

