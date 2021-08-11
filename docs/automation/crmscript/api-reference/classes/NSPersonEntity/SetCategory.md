---
uid: crmscript_ref_NSPersonEntity_SetCategory
title: SetCategory(NSCategory category)
intellisense: NSPersonEntity.SetCategory
keywords: NSPersonEntity, GetCategory
so.topic: reference
---

# SetCategory(NSCategory category)

Person's category. Usually null. Refer to the Contact.NSCategory instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Parameter:** 
 - **category** NSCategory

```crmscript
NSPersonEntity thing;
NSCategory category;
thing.SetCategory(category);
```

