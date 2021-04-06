---
uid: crmscript_ref_NSPersonEntity_GetCategory
title: Category GetCategory()
intellisense: NSPersonEntity.GetCategory
keywords: NSPersonEntity, GetCategory
so.topic: reference
---

Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Returns:** Category


```crmscript
NSPersonEntity thing;
Category category  = thing.GetCategory();
```


