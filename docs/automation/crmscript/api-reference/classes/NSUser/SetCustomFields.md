---
uid: crmscript_ref_NSUser_SetCustomFields
title: SetCustomFields(Map udefs)
intellisense: NSUser.SetCustomFields
keywords: NSUser, SetCustomFields
so.topic: reference
---

Set the user-defined and extra fields on a User with a map.

**Parameter:** 
 - **udefs** Map

```crmscript
NSUser thing;
Map udefs;
udefs["SuperOffice:1"] = "[I:123]";
udefs["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
udefs["custom.progid"] = "foobar";
udefs["x_foo"] = "foobar";
udefs["x_bar"] = "456"; // List item id
thing.SetCustomFields(udefs);
```

