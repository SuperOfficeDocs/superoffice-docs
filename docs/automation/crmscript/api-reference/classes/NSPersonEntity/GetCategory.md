---
uid: crmscript_ref_NSPersonEntity_GetCategory
title: NSCategory GetCategory()
intellisense: NSPersonEntity.GetCategory
keywords: NSPersonEntity, GetCategory
so.topic: reference
---

# NSCategory GetCategory()

Person's category. Usually null. Refer to the Contact.NSCategory instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Returns:** NSCategory

```crmscript
NSPersonEntity thing;
NSCategory category  = thing.GetCategory();
```

