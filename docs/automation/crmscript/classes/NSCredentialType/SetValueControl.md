---
uid: crmscript_ref_NSCredentialType_SetValueControl
title: SetValueControl(Integer valueControl)
intellisense: NSCredentialType.SetValueControl
keywords: NSCredentialType, GetValueControl
so.topic: reference
---

Type of control used to display the value.

**Parameter:** 
 - **valueControl** Integer
     - Enum: 0 = Static 
     - Enum: 1 = Edit 
     - Enum: 2 = Password 
     - Enum: 3 = Link 
     - Enum: 4 = Hidden 

```crmscript
NSCredentialType thing;
Integer valueControl;
thing.SetValueControl(valueControl);
```

