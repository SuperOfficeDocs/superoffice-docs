---
uid: crmscript_ref_NSForeignSystemAgent_GetApplicationKeys
title: ForeignKey[] GetApplicationKeys(String applicationName)
intellisense: NSForeignSystemAgent.GetApplicationKeys
keywords: NSForeignSystemAgent, GetApplicationKeys
so.topic: reference
---

Returns all ForeignKeys that belong to an application.

**Parameters:**
 - **applicationName** The name of the foreign application.

**Returns:** Array of all ForeignKeys in the ForeignApp.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
ForeignKey[] res = agent.GetApplicationKeys(applicationName);
```

