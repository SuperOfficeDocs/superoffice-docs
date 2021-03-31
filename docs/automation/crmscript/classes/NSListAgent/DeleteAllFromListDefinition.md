---
title: crmscript_ref_NSListAgent_DeleteAllFromListDefinition
description: Void DeleteAllFromListDefinition(Integer udListDefinitionId)
intellisense: NSListAgent.DeleteAllFromListDefinition
keywords: NSListAgent,DeleteAllFromListDefinition
so.topic: reference
---

Marks all items in the list deleted

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Void res = agent.DeleteAllFromListDefinition(udListDefinitionId);
```

