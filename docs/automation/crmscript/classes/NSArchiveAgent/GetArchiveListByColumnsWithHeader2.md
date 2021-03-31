---
uid: crmscript_ref_NSArchiveAgent_GetArchiveListByColumnsWithHeader2
title: ArchiveListResult GetArchiveListByColumnsWithHeader2(String providerName, String columns, String sortOrder, String restriction, String entities, Integer page, Integer pageSize, String options)
intellisense: NSArchiveAgent.GetArchiveListByColumnsWithHeader2
keywords: NSArchiveAgent, GetArchiveListByColumnsWithHeader2
so.topic: reference
---

Get a page of results for an archive list, explicitly specifying the restrictions as strings, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.

**Parameters:**
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **columns** Comma separated string of the names of the columns wanted.
 - **sortOrder** Comma separated string of sort order for the archive. e.g. "name asc, dept desc" Can be null, which indicates 'no particular order'
 - **restriction** Archive restrictions. e.g. "category = 2 or business oneOf (2,3,4)" Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
 - **entities** Comma separated list of entities to include. Can be null, which indicates 'include all entities'
 - **page** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
 - **pageSize** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
 - **options** name=value&amp;... formatted set of options. "rowcount=true" will cause the rowcount to be calculated and populated.

**Returns:** Header with optional row count, plus array of archive list items, where each item represents one row of data (row level data + the requested columns)

```crmscript
NSArchiveAgent agent;
String providerName;
String columns;
String sortOrder;
String restriction;
String entities;
Integer page;
Integer pageSize;
String options;
ArchiveListResult res = agent.GetArchiveListByColumnsWithHeader2(providerName, columns, sortOrder, restriction, entities, page, pageSize, options);
```

