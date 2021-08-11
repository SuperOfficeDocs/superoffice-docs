---
uid: crmscript_ref_NSListAgent_DeleteFromListDefinition
title: Void DeleteFromListDefinition(Integer id, Integer udListDefinitionId)
intellisense: NSListAgent.DeleteFromListDefinition
keywords: NSListAgent, DeleteFromListDefinition
so.topic: reference
---

# Void DeleteFromListDefinition(Integer id, Integer udListDefinitionId)

Delete a list item from the specified list defintion

**Parameters:**
 - **id** The identity of the list item to delete
 - **udListDefinitionId** The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.

```crmscript
NSListAgent agent;
Integer id;
Integer udListDefinitionId;
agent.DeleteFromListDefinition(id, udListDefinitionId);
```

