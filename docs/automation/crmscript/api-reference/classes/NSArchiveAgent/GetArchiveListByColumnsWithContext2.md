---
uid: crmscript_ref_NSArchiveAgent_GetArchiveListByColumnsWithContext2
title: NSArchiveListItem[] GetArchiveListByColumnsWithContext2(String providerName, String columns, String sortOrder, String restriction, String entities, Integer page, Integer pageSize, String context)
intellisense: NSArchiveAgent.GetArchiveListByColumnsWithContext2
keywords: NSArchiveAgent, GetArchiveListByColumnsWithContext2
so.topic: reference
---

Get a page of results for an archive list with context parameter, explicitly specifying the restrictions as a string, orderby and chosen columns.

**Parameters:**
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **columns** Comma separated names of the columns wanted.
 - **sortOrder** Comma separated list of columns to sort order for the archive. e.g.: "name asc, dept desc, registeredBy" Can be null, which indicates 'no particular order'
 - **restriction** Archive restrictions as string. e.g. "name startsWith 'foo' and (dept = 'bar' or dept = 'baz')" Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
 - **entities** Comma separated list of entities to include. Can be null, which indicates 'include all entities'
 - **page** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
 - **pageSize** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)

```crmscript
NSArchiveAgent agent;
String providerName;
String columns;
String sortOrder;
String restriction;
String entities;
Integer page;
Integer pageSize;
String context;
NSArchiveListItem[] res = agent.GetArchiveListByColumnsWithContext2(providerName, columns, sortOrder, restriction, entities, page, pageSize, context);
```

