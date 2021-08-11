---
uid: crmscript_ref_NSPhoneListPreferences_SetSearchModeLastname
title: SetSearchModeLastname(Integer searchModeLastname)
intellisense: NSPhoneListPreferences.SetSearchModeLastname
keywords: NSPhoneListPreferences, GetSearchModeLastname
so.topic: reference
---

# SetSearchModeLastname(Integer searchModeLastname)

The lastname search type, e.g. BeginsWith, Contains, Endswith, Matches

**Parameter:** 
 - **searchModeLastname** Integer
     - Enum: 0 = Exact 
     - Enum: 1 = BeginsWith 
     - Enum: 2 = EndsWith 
     - Enum: 3 = Contains 

```crmscript
NSPhoneListPreferences thing;
Integer searchModeLastname;
thing.SetSearchModeLastname(searchModeLastname);
```

