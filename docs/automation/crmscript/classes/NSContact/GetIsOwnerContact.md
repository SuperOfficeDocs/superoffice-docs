---
uid: crmscript_ref_NSContact_GetIsOwnerContact
title: Bool GetIsOwnerContact()
intellisense: NSContact.GetIsOwnerContact
keywords: NSContact, GetIsOwnerContact
so.topic: reference
---

Is the contact an owner contact.  This means that all persons on this contact can on only be internal users and not external users.

**Returns:** Bool


```crmscript
NSContact thing;
Bool isOwnerContact  = thing.GetIsOwnerContact();
```


