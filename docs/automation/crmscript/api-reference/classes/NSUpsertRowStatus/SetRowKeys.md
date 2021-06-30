---
uid: crmscript_ref_NSUpsertRowStatus_SetRowKeys
title: SetRowKeys(String[] rowKeys)
intellisense: NSUpsertRowStatus.SetRowKeys
keywords: NSUpsertRowStatus, GetRowKeys
so.topic: reference
---

The key values given in the incoming 'data' parameter to the Upsert call, in the order they were speicifed in the 'keys' array

**Parameter:** 
 - **rowKeys** StringArray

```crmscript
NSUpsertRowStatus thing;
String[] rowKeys;
thing.SetRowKeys(rowKeys);
```

