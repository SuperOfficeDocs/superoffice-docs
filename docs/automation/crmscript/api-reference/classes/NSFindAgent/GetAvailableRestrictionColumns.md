---
uid: crmscript_ref_NSFindAgent_GetAvailableRestrictionColumns
title: String[] GetAvailableRestrictionColumns(String storageType, String providerName)
intellisense: NSFindAgent.GetAvailableRestrictionColumns
keywords: NSFindAgent, GetAvailableRestrictionColumns
so.topic: reference
---

Get a list of the column names corresponding to available restrictions for a certain archive provider and restriction storage provider. Such columns have CanRestrict set to true, and are supported by the given restriction storage provider.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is to execute the search and return the result columns/rows

**Returns:** String[]

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String[] res = agent.GetAvailableRestrictionColumns(storageType, providerName);
```

