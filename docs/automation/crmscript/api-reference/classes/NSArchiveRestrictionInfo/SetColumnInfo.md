---
uid: crmscript_ref_NSArchiveRestrictionInfo_SetColumnInfo
title: SetColumnInfo(NSArchiveColumnInfo columnInfo)
intellisense: NSArchiveRestrictionInfo.SetColumnInfo
keywords: NSArchiveRestrictionInfo, GetColumnInfo
so.topic: reference
---

# SetColumnInfo(NSArchiveColumnInfo columnInfo)

Optional complete NSArchiveColumnInfo for this restriction; in that case, ColumnInfo.Name == this.Name will always be true

**Parameter:** 
 - **columnInfo** NSArchiveColumnInfo

```crmscript
NSArchiveRestrictionInfo thing;
NSArchiveColumnInfo columnInfo;
thing.SetColumnInfo(columnInfo);
```

