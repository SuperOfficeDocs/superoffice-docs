---
uid: crmscript_ref_NSMDOAgent_GetSimpleList
title: MDOListItemArray GetSimpleList(String name)
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
MDOListItemArray res = agent.GetSimpleList(name);
```

