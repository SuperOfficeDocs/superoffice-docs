---
uid: crmscript_ref_NSPhoneListPreferences_GetSearchModeDepartment
title: Integer GetSearchModeDepartment()
intellisense: NSPhoneListPreferences.GetSearchModeDepartment
keywords: NSPhoneListPreferences, GetSearchModeDepartment
so.topic: reference
---

The Department search type, e.g. BeginsWith, Contains, Endswith, Matches

**Returns:** Integer

     - Enum: 0 = Exact 
     - Enum: 1 = BeginsWith 
     - Enum: 2 = EndsWith 
     - Enum: 3 = Contains 

```crmscript
NSPhoneListPreferences thing;
Integer searchModeDepartment  = thing.GetSearchModeDepartment();
```


