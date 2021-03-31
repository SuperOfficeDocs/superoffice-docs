---
title: crmscript_ref_NSForeignSystemAgent_GetApplicationKeys
description: ForeignKeyArray GetApplicationKeys(String applicationName)
intellisense: NSForeignSystemAgent.GetApplicationKeys
keywords: NSForeignSystemAgent,GetApplicationKeys
so.topic: reference
---

Returns all ForeignKeys that belong to an application.

**Parameters:**
 - **applicationName** The name of the foreign application.

**Returns:** Array of all ForeignKeys in the ForeignApp.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
ForeignKeyArray res = agent.GetApplicationKeys(applicationName);
```

