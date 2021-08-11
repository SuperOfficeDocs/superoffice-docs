---
uid: crmscript_ref_NSPersonEntity_SetBusiness
title: SetBusiness(NSBusiness business)
intellisense: NSPersonEntity.SetBusiness
keywords: NSPersonEntity, GetBusiness
so.topic: reference
---

# SetBusiness(NSBusiness business)

Person's business - usually blank. Use Contact.NSBusiness instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Parameter:** 
 - **business** NSBusiness

```crmscript
NSPersonEntity thing;
NSBusiness business;
thing.SetBusiness(business);
```

