---
title: crmscript_ref_NSSelectionAgent_GetSelectionForFind
description: SelectionForFind GetSelectionForFind(String entityName, Integer typicalSearchId)
intellisense: NSSelectionAgent.GetSelectionForFind
keywords: NSSelectionAgent,GetSelectionForFind
so.topic: reference
---

Obtain a selection for the given entity, for the current user, of type WorkingSetForFind. Optionally populate criteria from the TypicalSearches system

**Parameters:**
 - **entityName** The name of the entity to make a selection for; examples 'sale', 'project', 'y_equipment'
 - **typicalSearchId** If 0, keep existing criteria; if -1, reset to entity default; > 0 get criteria from given TypicalSearch

**Returns:** Target selection id and provider name

```crmscript
NSSelectionAgent agent;
String entityName;
Integer typicalSearchId;
SelectionForFind res = agent.GetSelectionForFind(entityName, typicalSearchId);
```

