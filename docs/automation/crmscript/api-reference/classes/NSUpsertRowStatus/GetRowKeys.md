---
uid: crmscript_ref_NSUpsertRowStatus_GetRowKeys
title: String[] GetRowKeys()
intellisense: NSUpsertRowStatus.GetRowKeys
keywords: NSUpsertRowStatus, GetRowKeys
so.topic: reference
---

# String[] GetRowKeys()

The key values given in the incoming 'data' parameter to the Upsert call, in the order they were speicifed in the 'keys' array

**Returns:** String[]

```crmscript
NSUpsertRowStatus thing;
String[] rowKeys  = thing.GetRowKeys();
```

