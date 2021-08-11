---
uid: crmscript_ref_NSCommandInfo_GetReturnType
title: Integer GetReturnType()
intellisense: NSCommandInfo.GetReturnType
keywords: NSCommandInfo, GetReturnType
so.topic: reference
---

# Integer GetReturnType()

Declaration of what kind of return type the execution of this command will give.

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Message 
     - Enum: 2 = SoProtocol 
     - Enum: 3 = CustomGui 
     - Enum: 4 = Other 
     - Enum: 5 = URL 

```crmscript
NSCommandInfo thing;
Integer returnType  = thing.GetReturnType();
```

