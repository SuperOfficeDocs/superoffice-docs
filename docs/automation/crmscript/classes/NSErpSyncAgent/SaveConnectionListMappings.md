---
title: crmscript_ref_NSErpSyncAgent_SaveConnectionListMappings
description: ErpConnectionListMappingContainer SaveConnectionListMappings(ErpConnectionListMappingContainer listMapping)
intellisense: NSErpSyncAgent.SaveConnectionListMappings
keywords: NSErpSyncAgent,SaveConnectionListMappings
so.topic: reference
---

Saves a connection to the database.

**Parameters:**
 - **listMapping** The list item mappings to save.

**Returns:** The saved list mappings.

```crmscript
NSErpSyncAgent agent;
ErpConnectionListMappingContainer listMapping;
ErpConnectionListMappingContainer res = agent.SaveConnectionListMappings(listMapping);
```

