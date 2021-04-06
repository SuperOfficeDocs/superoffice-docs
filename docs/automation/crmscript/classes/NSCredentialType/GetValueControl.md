---
uid: crmscript_ref_NSCredentialType_GetValueControl
title: Integer GetValueControl()
intellisense: NSCredentialType.GetValueControl
keywords: NSCredentialType, GetValueControl
so.topic: reference
---

Type of control used to display the value.

**Returns:** Integer

     - Enum: 0 = Static 
     - Enum: 1 = Edit 
     - Enum: 2 = Password 
     - Enum: 3 = Link 
     - Enum: 4 = Hidden 

```crmscript
NSCredentialType thing;
Integer valueControl  = thing.GetValueControl();
```


