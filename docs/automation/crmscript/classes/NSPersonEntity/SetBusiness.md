---
uid: crmscript_ref_NSPersonEntity_SetBusiness
title: SetBusiness(Business business)
intellisense: NSPersonEntity.SetBusiness
keywords: NSPersonEntity, GetBusiness
so.topic: reference
---

Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Parameter:** 
 - **business** Business

```crmscript
NSPersonEntity thing;
Business business;
thing.SetBusiness(business);
```

