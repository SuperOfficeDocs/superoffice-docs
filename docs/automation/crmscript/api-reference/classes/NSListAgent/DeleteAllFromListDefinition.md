---
uid: crmscript_ref_NSListAgent_DeleteAllFromListDefinition
title: Void DeleteAllFromListDefinition(Integer udListDefinitionId)
intellisense: NSListAgent.DeleteAllFromListDefinition
keywords: NSListAgent, DeleteAllFromListDefinition
so.topic: reference
---

# Void DeleteAllFromListDefinition(Integer udListDefinitionId)

Marks all items in the list deleted

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
agent.DeleteAllFromListDefinition(udListDefinitionId);
```

