---
title: crmscript_ref_NSListAgent_DeleteAllFromListName
description: Void DeleteAllFromListName(String udListDefinitionName)
intellisense: NSListAgent.DeleteAllFromListName
keywords: NSListAgent,DeleteAllFromListName
so.topic: reference
---

Marks all items in the list deleted

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to delete the items from.

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
String udListDefinitionName;
Void res = agent.DeleteAllFromListName(udListDefinitionName);
```

