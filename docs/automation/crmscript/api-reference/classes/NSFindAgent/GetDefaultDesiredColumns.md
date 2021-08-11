---
uid: crmscript_ref_NSFindAgent_GetDefaultDesiredColumns
title: NSArchiveColumnInfo[] GetDefaultDesiredColumns(String storageType, String providerName, String storageKey)
intellisense: NSFindAgent.GetDefaultDesiredColumns
keywords: NSFindAgent, GetDefaultDesiredColumns
so.topic: reference
---

# NSArchiveColumnInfo[] GetDefaultDesiredColumns(String storageType, String providerName, String storageKey)

Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a storage type, provider name and storage key, which are used to fetch the corresponding restrictions from the database (in the same way as Find does). If you want to specify the restriction directly, use the GetDefaultDesiredColumnsFromRestrictions method instead. This is the algorithm that is used by the Find service method.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of the provider to calculate default desired columns for
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** NSArchiveColumnInfo[]

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
NSArchiveColumnInfo[] res = agent.GetDefaultDesiredColumns(storageType, providerName, storageKey);
```

