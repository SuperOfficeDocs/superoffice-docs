---
uid: crmscript_ref_NSFindAgent_FindOrderBy
title: NSFindResults FindOrderBy(String storageType, String providerName, String storageKey, Integer pageSize, Integer pageNumber, NSArchiveOrderByInfo[] orderBy)
intellisense: NSFindAgent.FindOrderBy
keywords: NSFindAgent, FindOrderBy
so.topic: reference
---

# NSFindResults FindOrderBy(String storageType, String providerName, String storageKey, Integer pageSize, Integer pageNumber, NSArchiveOrderByInfo[] orderBy)

Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby parameter is used for sorting the results.<para/>The other variants of the Find method allow you greater control over the individual aspects of the process.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is to execute the search and return the result columns/rows
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
 - **pageSize** Size of result set pages
 - **pageNumber** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
 - **orderBy** Array of order by specifications. If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.

**Returns:** NSFindResults

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
Integer pageSize;
Integer pageNumber;
NSArchiveOrderByInfo[] orderBy;
NSFindResults res = agent.FindOrderBy(storageType, providerName, storageKey, pageSize, pageNumber, orderBy);
```

