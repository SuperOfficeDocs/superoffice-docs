---
uid: crmscript_ref_NSPersonEntity_GetBusiness
title: NSBusiness GetBusiness()
intellisense: NSPersonEntity.GetBusiness
keywords: NSPersonEntity, GetBusiness
so.topic: reference
---

# NSBusiness GetBusiness()

Person's business - usually blank. Use Contact.NSBusiness instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)

**Returns:** NSBusiness

```crmscript
NSPersonEntity thing;
NSBusiness business  = thing.GetBusiness();
```

