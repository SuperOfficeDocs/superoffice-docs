---
uid: crmscript_ref_NSCredentialType_GetDisplayType
title: String GetDisplayType()
intellisense: NSCredentialType.GetDisplayType
keywords: NSCredentialType, GetDisplayType
so.topic: reference
---

# String GetDisplayType()

The name of the credentials to be displayed in the user interface.  This will typically be Password for user-name/password scenarios and Active Directoru User for AD integration.

**Returns:** String

```crmscript
NSCredentialType thing;
String displayType  = thing.GetDisplayType();
```

