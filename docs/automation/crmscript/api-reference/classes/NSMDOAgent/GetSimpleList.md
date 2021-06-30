---
uid: crmscript_ref_NSMDOAgent_GetSimpleList
title: MDOListItem[] GetSimpleList(String name)
intellisense: NSMDOAgent.GetSimpleList
keywords: NSMDOAgent, GetSimpleList
so.topic: reference
---

Method returns a simple flat MDO List.

**Parameters:**
 - **name** Conceptual name of the MDO list-

**Returns:** Array of MDOListItem

```crmscript
NSMDOAgent agent;
String name;
MDOListItem[] res = agent.GetSimpleList(name);
```

