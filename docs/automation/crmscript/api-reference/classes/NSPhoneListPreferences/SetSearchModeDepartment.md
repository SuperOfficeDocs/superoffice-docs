---
uid: crmscript_ref_NSPhoneListPreferences_SetSearchModeDepartment
title: SetSearchModeDepartment(Integer searchModeDepartment)
intellisense: NSPhoneListPreferences.SetSearchModeDepartment
keywords: NSPhoneListPreferences, GetSearchModeDepartment
so.topic: reference
---

# SetSearchModeDepartment(Integer searchModeDepartment)

The Department search type, e.g. BeginsWith, Contains, Endswith, Matches

**Parameter:** 
 - **searchModeDepartment** Integer
     - Enum: 0 = Exact 
     - Enum: 1 = BeginsWith 
     - Enum: 2 = EndsWith 
     - Enum: 3 = Contains 

```crmscript
NSPhoneListPreferences thing;
Integer searchModeDepartment;
thing.SetSearchModeDepartment(searchModeDepartment);
```

