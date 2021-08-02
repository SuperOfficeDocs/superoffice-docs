---
uid: crmscript_ref_NSForeignSystemAgent_GetApplicationKeys
title: NSForeignKey[] GetApplicationKeys(String applicationName)
intellisense: NSForeignSystemAgent.GetApplicationKeys
keywords: NSForeignSystemAgent, GetApplicationKeys
so.topic: reference
---

Returns all ForeignKeys that belong to an application.

**Parameters:**
 - **applicationName** The name of the foreign application.

**Returns:** NSForeignKey[]

```crmscript
NSForeignSystemAgent agent;
String applicationName;
NSForeignKey[] res = agent.GetApplicationKeys(applicationName);
```

