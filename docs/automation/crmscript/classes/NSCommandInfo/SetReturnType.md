---
uid: crmscript_ref_NSCommandInfo_SetReturnType
title: SetReturnType(Integer returnType)
intellisense: NSCommandInfo.SetReturnType
keywords: NSCommandInfo, GetReturnType
so.topic: reference
---

Declaration of what kind of return type the execution of this command will give.

**Parameter:** 
 - **returnType** Integer
     - Enum: 0 = None 
     - Enum: 1 = Message 
     - Enum: 2 = SoProtocol 
     - Enum: 3 = CustomGui 
     - Enum: 4 = Other 
     - Enum: 5 = URL 

```crmscript
NSCommandInfo thing;
Integer returnType;
thing.SetReturnType(returnType);
```

