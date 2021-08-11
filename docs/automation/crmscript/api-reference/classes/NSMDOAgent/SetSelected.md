---
uid: crmscript_ref_NSMDOAgent_SetSelected
title: NSSelectableMDOListItem[] SetSelected(String name, String additionalInfo, NSSelectableMDOListItem[] selectableMDOList)
intellisense: NSMDOAgent.SetSelected
keywords: NSMDOAgent, SetSelected
so.topic: reference
---

# NSSelectableMDOListItem[] SetSelected(String name, String additionalInfo, NSSelectableMDOListItem[] selectableMDOList)

Saves the selected values as selected by their given list representation.

**Parameters:**
 - **name** Conceptual name of the MDO list
 - **additionalInfo** Additional info to the MDO provider
 - **selectableMDOList** Items to be updated

**Returns:** NSSelectableMDOListItems[]

```crmscript
NSMDOAgent agent;
String name;
String additionalInfo;
NSSelectableMDOListItem[] selectableMDOList;
NSSelectableMDOListItem[] res = agent.SetSelected(name, additionalInfo, selectableMDOList);
```

