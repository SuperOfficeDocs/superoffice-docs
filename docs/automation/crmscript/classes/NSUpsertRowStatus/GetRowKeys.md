---
uid: crmscript_ref_NSUpsertRowStatus_GetRowKeys
title: StringArray GetRowKeys()
intellisense: NSUpsertRowStatus.GetRowKeys
keywords: NSUpsertRowStatus, GetRowKeys
so.topic: reference
---

The key values given in the incoming 'data' parameter to the Upsert call, in the order they were speicifed in the 'keys' array

**Returns:** StringArray


```crmscript
NSUpsertRowStatus thing;
StringArray rowKeys  = thing.GetRowKeys();
```


