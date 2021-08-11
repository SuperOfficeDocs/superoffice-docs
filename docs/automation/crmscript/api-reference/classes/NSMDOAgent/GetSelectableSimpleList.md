---
uid: crmscript_ref_NSMDOAgent_GetSelectableSimpleList
title: NSSelectableMDOListItem[] GetSelectableSimpleList(String name)
intellisense: NSMDOAgent.GetSelectableSimpleList
keywords: NSMDOAgent, GetSelectableSimpleList
so.topic: reference
---

# NSSelectableMDOListItem[] GetSelectableSimpleList(String name)

Method returns a flat Selectable MDO List.

**Parameters:**
 - **name** Conceptual name of the MDO list

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSMDOAgent agent;
String name;
NSSelectableMDOListItem[] res = agent.GetSelectableSimpleList(name);
```

