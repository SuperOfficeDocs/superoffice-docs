---
uid: crmscript_ref_NSArchiveAgent_GetArchiveList
title: ArchiveListItemArray GetArchiveList(String guiName, String providerName, ArchiveOrderByInfoArray sortOrder, ArchiveRestrictionInfoArray restriction, StringArray entities, Integer page, Integer pageSize)
intellisense: NSArchiveAgent.GetArchiveList
keywords: NSArchiveAgent, GetArchiveList
so.topic: reference
---

Get a page of data for an archive. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.

**Parameters:**
 - **guiName** The GUI name of the archive list, used to retrieve the currently configured set of columns (otherwise manipulated using the ArchiveConfiguration service)
 - **providerName** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
 - **sortOrder** Sort order for the archive. Can be null, which indicates 'no particular order'
 - **restriction** Archive restrictions. Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
 - **entities** Which entities to include. Can be null, which indicates 'include all entities'
 - **page** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
 - **pageSize** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)

**Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)

```crmscript
NSArchiveAgent agent;
String guiName;
String providerName;
ArchiveOrderByInfoArray sortOrder;
ArchiveRestrictionInfoArray restriction;
StringArray entities;
Integer page;
Integer pageSize;
ArchiveListItemArray res = agent.GetArchiveList(guiName, providerName, sortOrder, restriction, entities, page, pageSize);
```

