---
uid: crmscript_ref_NSFindAgent_FindFromRestrictions2
title: FindResults FindFromRestrictions2(String restrictions, String providerName, Integer pageSize, Integer pageNumber)
intellisense: NSFindAgent.FindFromRestrictions2
keywords: NSFindAgent, FindFromRestrictions2
so.topic: reference
---

Execute a Find operation and return a page of results. The criteria for the Find are passed in directly, not fetched by a restriction storage provider. The columns of the result are calculated based on the restriction.

**Parameters:**
 - **restrictions** String of restrictions specifying the search. e.g. "name='SuperOffice'" Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
 - **providerName** Name of archive provider that is to execute the search and return the result columns/rows
 - **pageSize** Size of result set pages
 - **pageNumber** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** Results from search, containing column information and result rows.

```crmscript
NSFindAgent agent;
String restrictions;
String providerName;
Integer pageSize;
Integer pageNumber;
FindResults res = agent.FindFromRestrictions2(restrictions, providerName, pageSize, pageNumber);
```

