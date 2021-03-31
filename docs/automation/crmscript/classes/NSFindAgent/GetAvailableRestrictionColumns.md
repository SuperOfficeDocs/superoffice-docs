---
title: crmscript_ref_NSFindAgent_GetAvailableRestrictionColumns
description: StringArray GetAvailableRestrictionColumns(String storageType, String providerName)
intellisense: NSFindAgent.GetAvailableRestrictionColumns
keywords: NSFindAgent,GetAvailableRestrictionColumns
so.topic: reference
---

Get a list of the column names corresponding to available restrictions for a certain archive provider and restriction storage provider. Such columns have CanRestrict set to true, and are supported by the given restriction storage provider.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is to execute the search and return the result columns/rows

**Returns:** Array of column names, corresponding to support restrictions for the given archive and restriction storage providers.

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
StringArray res = agent.GetAvailableRestrictionColumns(storageType, providerName);
```

