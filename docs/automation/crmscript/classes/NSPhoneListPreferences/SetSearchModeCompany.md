---
uid: crmscript_ref_NSPhoneListPreferences_SetSearchModeCompany
title: SetSearchModeCompany(Integer searchModeCompany)
intellisense: NSPhoneListPreferences.SetSearchModeCompany
keywords: NSPhoneListPreferences, GetSearchModeCompany
so.topic: reference
---

The Company name search type, e.g. BeginsWith, Contains, Endswith, Matches

**Parameter:** 
 - **searchModeCompany** Integer
     - Enum: 0 = Exact 
     - Enum: 1 = BeginsWith 
     - Enum: 2 = EndsWith 
     - Enum: 3 = Contains 

```crmscript
NSPhoneListPreferences thing;
Integer searchModeCompany;
thing.SetSearchModeCompany(searchModeCompany);
```

