---
uid: crmscript_ref_NSPerson_GetActiveInterests
title: Integer GetActiveInterests()
intellisense: NSPerson.GetActiveInterests
keywords: NSPerson, GetActiveInterests
so.topic: reference
---

# Integer GetActiveInterests()

Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true

**Returns:** Integer

```crmscript
NSPerson thing;
Integer activeInterests  = thing.GetActiveInterests();
```

