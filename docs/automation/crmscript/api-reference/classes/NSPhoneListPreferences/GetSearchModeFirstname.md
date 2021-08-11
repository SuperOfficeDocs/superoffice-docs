---
uid: crmscript_ref_NSPhoneListPreferences_GetSearchModeFirstname
title: Integer GetSearchModeFirstname()
intellisense: NSPhoneListPreferences.GetSearchModeFirstname
keywords: NSPhoneListPreferences, GetSearchModeFirstname
so.topic: reference
---

# Integer GetSearchModeFirstname()

The firstname search type, e.g. BeginsWith, Contains, Endswith, Matches

**Returns:** Integer

     - Enum: 0 = Exact 
     - Enum: 1 = BeginsWith 
     - Enum: 2 = EndsWith 
     - Enum: 3 = Contains 

```crmscript
NSPhoneListPreferences thing;
Integer searchModeFirstname  = thing.GetSearchModeFirstname();
```

