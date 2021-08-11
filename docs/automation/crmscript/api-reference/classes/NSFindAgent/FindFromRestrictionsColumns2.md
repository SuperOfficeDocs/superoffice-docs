---
uid: crmscript_ref_NSFindAgent_FindFromRestrictionsColumns2
title: NSFindResults FindFromRestrictionsColumns2(String restrictions, String providerName, String desiredColumns, Integer pageSize, Integer pageNumber)
intellisense: NSFindAgent.FindFromRestrictionsColumns2
keywords: NSFindAgent, FindFromRestrictionsColumns2
so.topic: reference
---

# NSFindResults FindFromRestrictionsColumns2(String restrictions, String providerName, String desiredColumns, Integer pageSize, Integer pageNumber)

Execute a Find operation and return a page of results. <para/>The criteria for the Find are passed in directly, not fetched by a restriction storage provider. <para/>The desired columns of the result set are also passed in directly.<para/>The orderby information is calculated by the system.<para/>Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them.

**Parameters:**
 - **restrictions** String of restrictions specifying the search. e.g.:"name begins 'Super'". Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
 - **providerName** Name of archive provider that is to execute the search and return the result columns/rows
 - **desiredColumns** Array of column names desired for the result. Each name must match a column offered by the given archive provider.
 - **pageSize** Size of result set pages
 - **pageNumber** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** NSFindResults

```crmscript
NSFindAgent agent;
String restrictions;
String providerName;
String desiredColumns;
Integer pageSize;
Integer pageNumber;
NSFindResults res = agent.FindFromRestrictionsColumns2(restrictions, providerName, desiredColumns, pageSize, pageNumber);
```

