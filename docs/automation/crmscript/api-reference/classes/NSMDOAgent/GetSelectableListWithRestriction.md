---
uid: crmscript_ref_NSMDOAgent_GetSelectableListWithRestriction
title: SelectableMDOListItem[] GetSelectableListWithRestriction(String name, String additionalInfo, String searchValue)
intellisense: NSMDOAgent.GetSelectableListWithRestriction
keywords: NSMDOAgent, GetSelectableListWithRestriction
so.topic: reference
---

Method to get a Selectable MDO list with restrictions.

**Parameters:**
 - **name** Conceptual name of the MDO list
 - **additionalInfo** Additional info to the MDO provider
 - **searchValue** the value used to restrict the list

**Returns:** Array of SelectableMDOListItem

```crmscript
NSMDOAgent agent;
String name;
String additionalInfo;
String searchValue;
SelectableMDOListItem[] res = agent.GetSelectableListWithRestriction(name, additionalInfo, searchValue);
```

