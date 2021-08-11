---
uid: crmscript_ref_NSTableRecord_GetValues
title: StringDictionary GetValues()
intellisense: NSTableRecord.GetValues
keywords: NSTableRecord, GetValues
so.topic: reference
---

# StringDictionary GetValues()

Values for the row, where the first string is the column name (e.g. x_number), and the second string is the value formatted as a DB-value, e.g. [I:42]

**Returns:** StringDictionary

```crmscript
NSTableRecord thing;
StringDictionary values  = thing.GetValues();
```

