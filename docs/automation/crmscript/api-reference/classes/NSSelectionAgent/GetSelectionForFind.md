---
uid: crmscript_ref_NSSelectionAgent_GetSelectionForFind
title: NSSelectionForFind GetSelectionForFind(String entityName, Integer typicalSearchId)
intellisense: NSSelectionAgent.GetSelectionForFind
keywords: NSSelectionAgent, GetSelectionForFind
so.topic: reference
---

# NSSelectionForFind GetSelectionForFind(String entityName, Integer typicalSearchId)

Obtain a selection for the given entity, for the current user, of type WorkingSetForFind. Optionally populate criteria from the TypicalSearches system

**Parameters:**
 - **entityName** The name of the entity to make a selection for; examples 'sale', 'project', 'y_equipment'
 - **typicalSearchId** If 0, keep existing criteria; if -1, reset to entity default; > 0 get criteria from given TypicalSearch

**Returns:** NSSelectionForFind

```crmscript
NSSelectionAgent agent;
String entityName;
Integer typicalSearchId;
NSSelectionForFind res = agent.GetSelectionForFind(entityName, typicalSearchId);
```

