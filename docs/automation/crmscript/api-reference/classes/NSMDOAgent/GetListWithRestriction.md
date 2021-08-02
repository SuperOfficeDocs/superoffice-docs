---
uid: crmscript_ref_NSMDOAgent_GetListWithRestriction
title: NSMDOListItem[] GetListWithRestriction(String name, String additionalInfo, String searchValue)
intellisense: NSMDOAgent.GetListWithRestriction
keywords: NSMDOAgent, GetListWithRestriction
so.topic: reference
---

Method to get a MDO list with restrictions.

**Parameters:**
 - **name** Conceptual name of the MDO list-
 - **additionalInfo** Additional info to the MDO provider
 - **searchValue** the value used to restrict the list

**Returns:** NSMDOListItem[]

```crmscript
NSMDOAgent agent;
String name;
String additionalInfo;
String searchValue;
NSMDOListItem[] res = agent.GetListWithRestriction(name, additionalInfo, searchValue);
```

