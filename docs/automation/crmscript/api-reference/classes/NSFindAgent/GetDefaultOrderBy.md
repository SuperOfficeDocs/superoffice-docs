---
uid: crmscript_ref_NSFindAgent_GetDefaultOrderBy
title: NSArchiveOrderByInfo[] GetDefaultOrderBy(String storageType, String providerName, String storageKey)
intellisense: NSFindAgent.GetDefaultOrderBy
keywords: NSFindAgent, GetDefaultOrderBy
so.topic: reference
---

# NSArchiveOrderByInfo[] GetDefaultOrderBy(String storageType, String providerName, String storageKey)

Calculate the default orderby columns for a given provider and a search. The search is specified by a storage type, provider name and storage key, and is fetched from the database. Default desired columns are then calculated for the search, and those columns are then used as the basis for calculating an order by. If you want to specify the desired columns directly, use the GetDefaultOrderByFromDesiredColumns method instead.  This is the same algorithm that is used by the Find service method.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Provider name to calculate default orderby for
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** NSArchiveOrderByInfo[]

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
NSArchiveOrderByInfo[] res = agent.GetDefaultOrderBy(storageType, providerName, storageKey);
```

