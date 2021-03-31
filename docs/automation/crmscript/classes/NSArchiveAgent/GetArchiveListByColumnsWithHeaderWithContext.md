---
title: crmscript_ref_NSArchiveAgent_GetArchiveListByColumnsWithHeaderWithContext
description: ArchiveListResult GetArchiveListByColumnsWithHeaderWithContext(String providerName, StringArray columns, ArchiveOrderByInfoArray sortOrder, ArchiveRestrictionInfoArray restriction, StringArray entities, Integer page, Integer pageSize, String options, String context)
intellisense: NSArchiveAgent.GetArchiveListByColumnsWithHeaderWithContext
keywords: NSArchiveAgent,GetArchiveListByColumnsWithHeaderWithContext
so.topic: reference
---

Get a page of results for an archive list, with context parameter, explicitly specifying the restrictions, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.

**Parameters:**
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **columns** An array of the names of the columns wanted.
 - **sortOrder** Sort order for the archive. Can be null, which indicates 'no particular order'
 - **restriction** Archive restrictions. Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
 - **entities** Which entities to include. Can be null, which indicates 'include all entities'
 - **page** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
 - **pageSize** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
 - **options** name=value&amp;... formatted set of options. "rowcount=true" will cause the rowcount to be calculated and populated.
 - **context** Context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Header with optional row count, plus array of archive list items, where each item represents one row of data (row level data + the requested columns)

```crmscript
NSArchiveAgent agent;
String providerName;
StringArray columns;
ArchiveOrderByInfoArray sortOrder;
ArchiveRestrictionInfoArray restriction;
StringArray entities;
Integer page;
Integer pageSize;
String options;
String context;
ArchiveListResult res = agent.GetArchiveListByColumnsWithHeaderWithContext(providerName, columns, sortOrder, restriction, entities, page, pageSize, options, context);
```

