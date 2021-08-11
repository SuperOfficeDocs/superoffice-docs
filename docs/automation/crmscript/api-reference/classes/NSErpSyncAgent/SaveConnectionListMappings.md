---
uid: crmscript_ref_NSErpSyncAgent_SaveConnectionListMappings
title: NSErpConnectionListMappingContainer SaveConnectionListMappings(NSErpConnectionListMappingContainer listMapping)
intellisense: NSErpSyncAgent.SaveConnectionListMappings
keywords: NSErpSyncAgent, SaveConnectionListMappings
so.topic: reference
---

# NSErpConnectionListMappingContainer SaveConnectionListMappings(NSErpConnectionListMappingContainer listMapping)

Saves a connection to the database.

**Parameters:**
 - **listMapping** The list item mappings to save.

**Returns:** NSErpConnectionListMappingContainer

```crmscript
NSErpSyncAgent agent;
NSErpConnectionListMappingContainer listMapping;
NSErpConnectionListMappingContainer res = agent.SaveConnectionListMappings(listMapping);
```

