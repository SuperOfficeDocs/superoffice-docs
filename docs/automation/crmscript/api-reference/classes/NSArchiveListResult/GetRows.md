---
uid: crmscript_ref_NSArchiveListResult_GetRows
title: NSArchiveListItem[] GetRows()
intellisense: NSArchiveListResult.GetRows
keywords: NSArchiveListResult, GetRows
so.topic: reference
---

# NSArchiveListItem[] GetRows()

The actual rows, according to the paging info, of the result. See RowCount for a paging-independent count estimate

**Returns:** NSArchiveListItem[]

```crmscript
NSArchiveListResult thing;
NSArchiveListItem[] rows  = thing.GetRows();
```

